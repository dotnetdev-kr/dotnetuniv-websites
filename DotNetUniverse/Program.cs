using DotNetUniverse.Services;
using DotNetUniverse.Services.EventData;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddSingleton<SessionDisplayService>();
builder.Services.AddSingleton<EventDataService>();

using var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

// 동적 행사 URL 라우팅 미들웨어
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
    
    // Slug 매칭 확인 - 매칭되는 경우만 처리
    var EventDataService = context.RequestServices.GetRequiredService<EventDataService>();
    var eventData = EventDataService.GetBySlug(path);
    
    if (eventData != null)
    {
        // 쿼리스트링 유지하면서 내부 경로로 리라이트
        var queryString = context.Request.QueryString.HasValue 
            ? context.Request.QueryString.Value + $"&slug={path}"
            : $"?slug={path}";
        
        context.Request.Path = $"/Years/Event/{path}";
        context.Request.QueryString = new QueryString(queryString);
        
        // 디버그 로그
        Console.WriteLine($"[Rewrite] /{path} -> /Years/Event/{path}{queryString}");
    }
    else
    {
        Console.WriteLine($"[NoMatch] /{path} - slug not found");
    }
    
    // 매칭 여부와 관계없이 다음 미들웨어로 전달
    // (매칭되면 리라이트된 경로로, 아니면 원래 경로로)
    await next();
});

app.UseRouting();
app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages().WithStaticAssets();
app.Run();
