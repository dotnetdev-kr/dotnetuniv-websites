using DotNetUniverse.Models;
using DotNetUniverse.Models.Collections;

namespace DotNetUniverse.Services.YearData;

/// <summary>
/// 2022년 행사 데이터
/// </summary>
public class Year2022Data : IEventData
{
    public string Slug => "2022";
    public int Year => 2022;
    public string ThemeColor => "#198754";
    public string ThemeColorClass => "success";

    #region Speakers

    private readonly Speaker kim_dotnet6 = new()
    {
        Id = nameof(kim_dotnet6),
        Name = "김닷넷식스",
        Title = "Microsoft MVP",
        Company = "테크컴퍼니",
        Bio = ".NET 6 LTS 전문가로서 엔터프라이즈 개발에 풍부한 경험을 보유하고 있습니다."
    };

    private readonly Speaker lee_minimal = new()
    {
        Id = nameof(lee_minimal),
        Name = "이미니멀",
        Title = "Backend Developer",
        Company = "API스타트업",
        Bio = "Minimal API 전문가로서 간결한 API 설계에 대한 전문성을 가지고 있습니다."
    };

    private readonly Speaker park_maui = new()
    {
        Id = nameof(park_maui),
        Name = "박마우이",
        Title = "Mobile Developer",
        Company = "앱팩토리",
        Bio = ".NET MAUI 얼리어답터로서 크로스플랫폼 모바일 개발에 깊은 관심을 가지고 있습니다."
    };

    private readonly Speaker jung_hotreload = new()
    {
        Id = nameof(jung_hotreload),
        Name = "정핫리로드",
        Title = "Senior Developer",
        Company = "개발툴즈",
        Bio = "개발자 생산성 도구 전문가로서 Hot Reload 등 최신 개발 경험에 대한 지식을 보유하고 있습니다."
    };

    private readonly Speaker choi_container = new()
    {
        Id = nameof(choi_container),
        Name = "최컨테이너",
        Title = "DevOps Engineer",
        Company = "클라우드랩",
        Bio = "컨테이너 및 Kubernetes 전문가로서 클라우드 네이티브 개발에 전문성을 가지고 있습니다."
    };

    public SpeakerCollection Speakers => SpeakerCollection.Create(
        kim_dotnet6, lee_minimal, park_maui, jung_hotreload, choi_container
    );

    #endregion

    #region Sessions

    private Session keynote => new()
    {
        Id = nameof(keynote),
        Title = ".NET 6 LTS 완전 정복",
        Abstract = """
            장기 지원 버전인 .NET 6의 새로운 기능과 성능 개선사항을 총정리합니다.
            C# 10, Hot Reload, Minimal API 등 개발자 경험을 혁신하는 기능들을 소개합니다.
            """,
        Speakers = [kim_dotnet6],
        Format = SessionFormat.Keynote,
        Duration = TimeSpan.FromMinutes(60),
        Topic = SessionTopic.General,
        VideoUrl = "https://youtube.com/watch?v=2022keynote",
        Tags = [".NET 6", "LTS", "C# 10"]
    };

    private Session minimal_api => new()
    {
        Id = nameof(minimal_api),
        Title = "Minimal API로 간결한 웹 API 구축",
        Abstract = """
            ASP.NET Core의 Minimal API를 활용한 간결하고 빠른 API 개발 방법을 배웁니다.
            기존 Controller 기반 API와의 비교 및 적절한 사용 시나리오를 다룹니다.
            """,
        Speakers = [lee_minimal],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        Topic = SessionTopic.Web,
        VideoUrl = "https://youtube.com/watch?v=2022minimal",
        Tags = ["Minimal API", "ASP.NET Core", "Web API"]
    };

    private Session maui_preview => new()
    {
        Id = nameof(maui_preview),
        Title = ".NET MAUI 미리보기",
        Abstract = """
            .NET MAUI의 첫 번째 정식 버전을 미리 살펴봅니다.
            Xamarin.Forms에서 MAUI로의 마이그레이션 전략과 새로운 기능들을 소개합니다.
            """,
        Speakers = [park_maui],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        Topic = SessionTopic.Mobile,
        VideoUrl = "https://youtube.com/watch?v=2022maui",
        Tags = [".NET MAUI", "Cross-platform", "Mobile"]
    };

    private Session hot_reload => new()
    {
        Id = nameof(hot_reload),
        Title = "Hot Reload로 개발 생산성 극대화",
        Abstract = """
            .NET 6의 Hot Reload 기능을 활용한 빠른 개발 사이클을 경험합니다.
            코드 변경 즉시 반영되는 개발 환경 구축 방법을 배웁니다.
            """,
        Speakers = [jung_hotreload],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        Topic = SessionTopic.DevOps,
        VideoUrl = "https://youtube.com/watch?v=2022hotreload",
        Tags = ["Hot Reload", "Developer Experience", "Productivity"]
    };

    private Session container_dotnet => new()
    {
        Id = nameof(container_dotnet),
        Title = ".NET 컨테이너화 베스트 프랙티스",
        Abstract = """
            .NET 애플리케이션을 Docker 컨테이너로 패키징하고 배포하는 최적의 방법을 배웁니다.
            멀티스테이지 빌드, 이미지 최적화, Kubernetes 배포 전략을 다룹니다.
            """,
        Speakers = [choi_container],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        Topic = SessionTopic.Cloud,
        VideoUrl = "https://youtube.com/watch?v=2022container",
        Tags = ["Docker", "Kubernetes", "Container"]
    };

    #endregion

    #region Tracks

    private Track main => new()
    {
        Id = nameof(main),
        Name = "메인 트랙",
        Color = "#198754",
        Sessions = SessionCollection.Create(keynote, minimal_api, maui_preview, hot_reload, container_dotnet)
    };

    #endregion

    #region Sponsors

    private readonly Sponsor microsoft = new() { Id = nameof(microsoft), Name = "Microsoft", Tier = SponsorTier.Platinum, WebsiteUrl = "https://microsoft.com" };
    private readonly Sponsor jetbrains = new() { Id = nameof(jetbrains), Name = "JetBrains", Tier = SponsorTier.Gold, WebsiteUrl = "https://jetbrains.com" };
    private readonly Sponsor github = new() { Id = nameof(github), Name = "GitHub", Tier = SponsorTier.Silver, WebsiteUrl = "https://github.com" };

    #endregion

    #region Venue

    private VenueInfo ms_korea => new()
    {
        Id = nameof(ms_korea),
        Name = "한국마이크로소프트 + 온라인",
        Address = "서울시 종로구 종로1길 50",
        Tracks = TrackCollection.Create(main)
    };

    #endregion

    public EventInfo Event => new()
    {
        Slug = Slug,
        Year = 2022,
        Title = ".NET Universe 2022",
        Theme = ".NET 6 LTS와 함께하는 엔터프라이즈",
        Description = ".NET 6 LTS 출시와 함께 첫 하이브리드 형태로 개최된 컨퍼런스입니다.",
        Date = new DateTime(2022, 11, 12),
        Type = EventType.Hybrid,
        AttendeeCount = 300,
        HeroImageUrl = "/images/events/2022-hero.webp",
        Venues = VenueCollection.Create(ms_korea),
        Sponsors = SponsorCollection.Create(microsoft, jetbrains, github)
    };

    public ScheduleGrid Schedule => new ScheduleGridBuilder()
        .ForDay(1)
        .AddTrack(main)

        .AddTimeSlot(new TimeOnly(13, 0), 60, slot => slot
            .At(0, keynote))

        .AddTimeSlot(new TimeOnly(14, 0), 45, slot => slot
            .At(0, minimal_api))

        .AddTimeSlot(new TimeOnly(14, 55), 45, slot => slot
            .At(0, maui_preview))

        .AddTimeSlot(new TimeOnly(15, 50), 45, slot => slot
            .At(0, hot_reload))

        .AddTimeSlot(new TimeOnly(16, 45), 45, slot => slot
            .At(0, container_dotnet))

        .Build();
}
