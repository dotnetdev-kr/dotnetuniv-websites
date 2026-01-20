using DotNetUniverse.Models;
using DotNetUniverse.Models.Collections;

namespace DotNetUniverse.Services.YearData;

/// <summary>
/// 2021년 행사 데이터
/// </summary>
public class Year2021Data : IEventData
{
    public string Slug => "2021";
    public int Year => 2021;
    public string ThemeColor => "#6c757d";
    public string ThemeColorClass => "secondary";

    #region Speakers

    private readonly Speaker kim_dotnet5 = new()
    {
        Id = nameof(kim_dotnet5),
        Name = "김닷넷",
        Title = "Microsoft MVP",
        Company = "테크스타트업",
        Bio = ".NET 5 전문가로서 크로스플랫폼 개발에 대한 풍부한 경험을 보유하고 있습니다."
    };

    private readonly Speaker lee_blazor = new()
    {
        Id = nameof(lee_blazor),
        Name = "이블레이저",
        Title = "Web Developer",
        Company = "웹테크",
        Bio = "Blazor WebAssembly 전문가로서 SPA 개발에 깊은 경험을 가지고 있습니다."
    };

    private readonly Speaker park_efcore = new()
    {
        Id = nameof(park_efcore),
        Name = "박이에프",
        Title = "Backend Developer",
        Company = "데이터컴퍼니",
        Bio = "Entity Framework Core 전문가로서 데이터 액세스 패턴에 대한 전문 지식을 보유하고 있습니다."
    };

    private readonly Speaker choi_grpc = new()
    {
        Id = nameof(choi_grpc),
        Name = "최지알피씨",
        Title = "Senior Developer",
        Company = "마이크로서비스랩",
        Bio = "gRPC 및 마이크로서비스 아키텍처 전문가입니다."
    };

    public SpeakerCollection Speakers => SpeakerCollection.Create(
        kim_dotnet5, lee_blazor, park_efcore, choi_grpc
    );

    #endregion

    #region Sessions

    private Session keynote => new()
    {
        Id = nameof(keynote),
        Title = ".NET 5 새로운 시대의 시작",
        Abstract = """
            .NET Framework와 .NET Core가 통합된 .NET 5의 새로운 기능들을 소개합니다.
            단일 플랫폼으로 통합된 .NET의 비전과 앞으로의 로드맵을 공유합니다.
            """,
        Speakers = [kim_dotnet5],
        Format = SessionFormat.Keynote,
        Duration = TimeSpan.FromMinutes(60),
        Topic = SessionTopic.General,
        VideoUrl = "https://youtube.com/watch?v=2021keynote",
        Tags = [".NET 5", "Unified Platform"]
    };

    private Session blazor_wasm => new()
    {
        Id = nameof(blazor_wasm),
        Title = "Blazor WebAssembly 실전 가이드",
        Abstract = """
            Blazor WebAssembly를 활용한 SPA 개발의 실전 노하우를 공유합니다.
            JavaScript 없이 C#으로 프론트엔드를 개발하는 방법을 배웁니다.
            """,
        Speakers = [lee_blazor],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        Topic = SessionTopic.Web,
        VideoUrl = "https://youtube.com/watch?v=2021blazor",
        Tags = ["Blazor", "WebAssembly", "SPA"]
    };

    private Session efcore5 => new()
    {
        Id = nameof(efcore5),
        Title = "Entity Framework Core 5 새로운 기능",
        Abstract = """
            EF Core 5에서 추가된 새로운 기능들을 살펴봅니다.
            Many-to-Many, Table-per-Type, Filtered Include 등 실용적인 기능들을 다룹니다.
            """,
        Speakers = [park_efcore],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        Topic = SessionTopic.Data,
        VideoUrl = "https://youtube.com/watch?v=2021efcore",
        Tags = ["EF Core 5", "Database", "ORM"]
    };

    private Session grpc_dotnet => new()
    {
        Id = nameof(grpc_dotnet),
        Title = "gRPC와 .NET으로 고성능 API 구축",
        Abstract = """
            gRPC를 활용한 고성능 마이크로서비스 API 구축 방법을 배웁니다.
            Protocol Buffers, 스트리밍, 인증 등 실전 사용법을 다룹니다.
            """,
        Speakers = [choi_grpc],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        Topic = SessionTopic.Web,
        VideoUrl = "https://youtube.com/watch?v=2021grpc",
        Tags = ["gRPC", "Microservices", "Performance"]
    };

    #endregion

    #region Tracks

    private Track main => new()
    {
        Id = nameof(main),
        Name = "메인 트랙",
        Color = "#6c757d",
        Sessions = SessionCollection.Create(keynote, blazor_wasm, efcore5, grpc_dotnet)
    };

    #endregion

    #region Sponsors

    private readonly Sponsor microsoft = new() { Id = nameof(microsoft), Name = "Microsoft", Tier = SponsorTier.Platinum, WebsiteUrl = "https://microsoft.com" };
    private readonly Sponsor jetbrains = new() { Id = nameof(jetbrains), Name = "JetBrains", Tier = SponsorTier.Gold, WebsiteUrl = "https://jetbrains.com" };

    #endregion

    #region Venue

    private VenueInfo online => new()
    {
        Id = nameof(online),
        Name = "온라인 (YouTube Live)",
        Address = "온라인",
        Tracks = TrackCollection.Create(main)
    };

    #endregion

    public EventInfo Event => new()
    {
        Slug = Slug,
        Year = 2021,
        Title = ".NET Universe 2021",
        Theme = ".NET 5 통합의 시대",
        Description = ".NET 5로 통합된 .NET 생태계의 새로운 시작을 함께한 첫 번째 공식 컨퍼런스입니다.",
        Date = new DateTime(2021, 11, 13),
        Type = EventType.Online,
        AttendeeCount = 200,
        HeroImageUrl = "/images/events/2021-hero.webp",
        Venues = VenueCollection.Create(online),
        Sponsors = SponsorCollection.Create(microsoft, jetbrains)
    };

    public ScheduleGrid Schedule => new ScheduleGridBuilder()
        .ForDay(1)
        .AddTrack(main)

        .AddTimeSlot(new TimeOnly(13, 0), 60, slot => slot
            .At(0, keynote))

        .AddTimeSlot(new TimeOnly(14, 0), 45, slot => slot
            .At(0, blazor_wasm))

        .AddTimeSlot(new TimeOnly(14, 55), 45, slot => slot
            .At(0, efcore5))

        .AddTimeSlot(new TimeOnly(15, 50), 45, slot => slot
            .At(0, grpc_dotnet))

        .Build();
}
