using DotNetUniverse.Services;
using DotNetUniverse.Services.EventData;
using DotNetUniverse.Services.StudyData;
using Microsoft.AspNetCore.HttpOverrides;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<ForwardedHeadersOptions>(options =>
{
    options.ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;
    options.KnownIPNetworks.Clear();
    options.KnownProxies.Clear();
});
builder.Services.AddRazorPages();
builder.Services.AddSingleton<SessionDisplayService>();
builder.Services.AddSingleton<EventDataService>();
builder.Services.AddSingleton<StudyDataService>();

using var app = builder.Build();

// 애플리케이션 시작 시 이벤트와 스터디 slug 충돌 검사
var eventDataService = app.Services.GetRequiredService<EventDataService>();
var studyDataService = app.Services.GetRequiredService<StudyDataService>();

var eventSlugs = eventDataService.AllEvents.Select(e => e.Slug.ToLowerInvariant()).ToHashSet();
var studySlugs = studyDataService.AllStudies.Select(s => s.Slug.ToLowerInvariant()).ToHashSet();
var duplicateSlugs = eventSlugs.Intersect(studySlugs).ToList();

if (duplicateSlugs.Count > 0)
{
    throw new InvalidOperationException(
        $"이벤트와 스터디 간에 중복된 slug가 발견되었습니다: {string.Join(", ", duplicateSlugs)}");
}

if (!app.Environment.IsDevelopment())
{
    app.UseForwardedHeaders();
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

// 동적 행사/스터디 URL 라우팅 미들웨어
// 등록된 Slug 경로만 처리하고, 나머지는 그대로 통과
app.Use(async (context, next) =>
{
    var path = context.Request.Path.Value?.TrimStart('/') ?? "";
    
    // 빈 경로나 정적 파일은 바로 통과
    if (string.IsNullOrEmpty(path) || path.StartsWith("_") || path.Contains('.'))
    {
        await next();
        return;
    }
    
    // 이벤트 Slug 매칭 확인
    var eventService = context.RequestServices.GetRequiredService<EventDataService>();
    var eventData = eventService.GetBySlug(path);
    
    if (eventData != null)
    {
        // 쿼리스트링 유지하면서 내부 경로로 리라이트
        var queryString = context.Request.QueryString.HasValue 
            ? context.Request.QueryString.Value + $"&slug={path}"
            : $"?slug={path}";
        
        context.Request.Path = "/Events/Event";
        context.Request.QueryString = new QueryString(queryString);
        
        Console.WriteLine($"[Rewrite] /{path} -> /Events/Event{queryString}");
        await next();
        return;
    }
    
    // 스터디 Slug 매칭 확인
    var studyService = context.RequestServices.GetRequiredService<StudyDataService>();
    var studyData = studyService.GetBySlug(path);
    
    if (studyData != null)
    {
        var queryString = context.Request.QueryString.HasValue 
            ? context.Request.QueryString.Value + $"&slug={path}"
            : $"?slug={path}";
        
        context.Request.Path = "/Study";
        context.Request.QueryString = new QueryString(queryString);
        
        Console.WriteLine($"[Rewrite] /{path} -> /Study{queryString}");
        await next();
        return;
    }
    
    // 시리즈 접두사 매칭 확인 (mini, live, unplugged, edition 등)
    // 슬래시가 없는 단일 경로이고, 해당 접두사로 시작하는 이벤트가 있는 경우
    if (!path.Contains('/'))
    {
        var hasEventsWithPrefix = eventService.AllEvents
            .Any(e => e.Slug.StartsWith($"{path}/", StringComparison.OrdinalIgnoreCase));
        
        if (hasEventsWithPrefix)
        {
            var queryString = $"?prefix={path}";
            context.Request.Path = "/Events/Series";
            context.Request.QueryString = new QueryString(queryString);
            
            Console.WriteLine($"[Rewrite] /{path} -> /Events/Series{queryString}");
            await next();
            return;
        }
    }
    
    Console.WriteLine($"[NoMatch] /{path} - slug not found");
    await next();
});

app.UseRouting();
app.UseAuthorization();

// 404 상태 코드 페이지 처리
app.UseStatusCodePagesWithReExecute("/NotFound");

app.MapStaticAssets();
app.MapRazorPages().WithStaticAssets();
app.Run();
