using DotNetUniverse.Models;
using DotNetUniverse.Models.Collections;

namespace DotNetUniverse.Services.YearData;

/// <summary>
/// 2024년 행사 데이터
/// </summary>
public class Year2024Data : IEventData
{
    public string Slug => "2024";
    public int Year => 2024;
    public string ThemeColor => "#6f42c1";
    public string ThemeColorClass => "purple";

    #region Speakers

    private readonly Speaker kim_dotnet = new()
    {
        Id = nameof(kim_dotnet),
        Name = "김닷넷",
        Title = "Microsoft MVP",
        Company = "테크컴퍼니",
        Bio = ".NET 생태계 전문가로 10년 이상의 개발 경험을 보유하고 있습니다. 다양한 .NET 프로젝트를 리드하며 커뮤니티에서 활발하게 활동하고 있습니다.",
        GitHubUrl = "https://github.com/kimdotnet"
    };

    private readonly Speaker lee_cloud = new()
    {
        Id = nameof(lee_cloud),
        Name = "이클라우드",
        Title = "Cloud Architect",
        Company = "클라우드코리아",
        Bio = "Azure 및 클라우드 네이티브 전문가로서 대규모 클라우드 인프라 설계 및 구축 경험을 가지고 있습니다."
    };

    private readonly Speaker park_blazor = new()
    {
        Id = nameof(park_blazor),
        Name = "박블레이저",
        Title = "Senior Developer",
        Company = "웹테크",
        Bio = "Blazor 및 웹 기술 전문가로서 SPA 및 풀스택 웹 애플리케이션 개발에 풍부한 경험을 보유하고 있습니다."
    };

    private readonly Speaker jung_ai = new()
    {
        Id = nameof(jung_ai),
        Name = "정에이아이",
        Title = "AI Engineer",
        Company = "AI랩스",
        Bio = "ML.NET 및 AI 통합 전문가로서 .NET 환경에서의 머신러닝 솔루션 구축에 전문성을 가지고 있습니다."
    };

    private readonly Speaker choi_maui = new()
    {
        Id = nameof(choi_maui),
        Name = "최마우이",
        Title = "Mobile Developer",
        Company = "앱팩토리",
        Bio = ".NET MAUI 크로스플랫폼 전문가로서 iOS, Android, Windows 앱 개발에 깊은 경험을 가지고 있습니다."
    };

    private readonly Speaker han_devops = new()
    {
        Id = nameof(han_devops),
        Name = "한데브옵스",
        Title = "DevOps Engineer",
        Company = "데브옵스코리아",
        Bio = "CI/CD 및 컨테이너 전문가로서 GitHub Actions, Azure DevOps를 활용한 자동화 파이프라인 구축에 전문성을 가지고 있습니다."
    };

    public SpeakerCollection Speakers => SpeakerCollection.Create(
        kim_dotnet, lee_cloud, park_blazor, jung_ai, choi_maui, han_devops
    );

    #endregion

    #region Sessions

    private Session keynote => new()
    {
        Id = nameof(keynote),
        Title = ".NET 8 새로운 기능 총정리",
        Abstract = """
            .NET 8에서 추가된 주요 기능들을 총정리합니다.
            C# 12의 새로운 언어 기능, Native AOT 개선, ASP.NET Core 업데이트,
            Blazor United, .NET Aspire 미리보기 등 개발자가 알아야 할 모든 것을 다룹니다.
            """,
        Speakers = [kim_dotnet],
        Format = SessionFormat.Keynote,
        Duration = TimeSpan.FromMinutes(60),
        Topic = SessionTopic.General,
        VideoUrl = "https://youtube.com/watch?v=example1",
        SlidesUrl = "/slides/2024/dotnet8-features.pdf",
        Tags = [".NET 8", "C# 12", "Performance"]
    };

    private Session cloud_native => new()
    {
        Id = nameof(cloud_native),
        Title = "Azure로 시작하는 클라우드 네이티브",
        Abstract = """
            Azure 서비스를 활용하여 클라우드 네이티브 애플리케이션을 개발하는 방법을 알아봅니다.
            Azure Container Apps, Azure Kubernetes Service, Azure Functions 등
            다양한 서비스를 활용한 현대적인 클라우드 아키텍처 설계 방법을 소개합니다.
            """,
        Speakers = [lee_cloud],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        Topic = SessionTopic.Cloud,
        VideoUrl = "https://youtube.com/watch?v=example2",
        Tags = ["Azure", "Cloud Native", "Container"]
    };

    private Session blazor_united => new()
    {
        Id = nameof(blazor_united),
        Title = "Blazor United 실전 적용기",
        Abstract = """
            Blazor Server와 WebAssembly를 통합한 Blazor United의 실제 적용 사례를 공유합니다.
            Server-Side Rendering, Streaming Rendering, Interactive 모드 전환 등
            새로운 렌더링 모델을 활용한 웹 앱 개발 전략을 다룹니다.
            """,
        Speakers = [park_blazor],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        Topic = SessionTopic.Web,
        VideoUrl = "https://youtube.com/watch?v=example3",
        Tags = ["Blazor", "WebAssembly", "SSR"]
    };

    private Session mlnet_ai => new()
    {
        Id = nameof(mlnet_ai),
        Title = "ML.NET으로 AI 서비스 구축하기",
        Abstract = """
            ML.NET을 활용하여 실시간 AI 서비스를 개발하는 방법을 배웁니다.
            이미지 분류, 텍스트 분석, 추천 시스템 등 다양한 ML 시나리오를
            .NET 환경에서 구현하는 실용적인 방법을 소개합니다.
            """,
        Speakers = [jung_ai],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        Topic = SessionTopic.AI,
        Tags = ["ML.NET", "AI", "Machine Learning"]
    };

    private Session maui_crossplatform => new()
    {
        Id = nameof(maui_crossplatform),
        Title = ".NET MAUI 크로스플랫폼 앱 개발",
        Abstract = """
            하나의 코드베이스로 iOS, Android, Windows, macOS 앱을 개발하는 방법을 알아봅니다.
            .NET MAUI의 아키텍처, UI 컴포넌트, 플랫폼별 커스터마이징 방법과
            실제 프로덕션 앱 개발 시 고려해야 할 사항들을 다룹니다.
            """,
        Speakers = [choi_maui],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        Topic = SessionTopic.Mobile,
        Tags = [".NET MAUI", "Cross-platform", "Mobile"]
    };

    private Session github_actions => new()
    {
        Id = nameof(github_actions),
        Title = "GitHub Actions로 .NET CI/CD 구축",
        Abstract = """
            GitHub Actions를 활용하여 .NET 프로젝트의 CI/CD 파이프라인을 구축하는 방법을 배웁니다.
            빌드, 테스트, 배포 자동화부터 보안 스캔, 코드 품질 검사까지
            현대적인 DevOps 워크플로우를 설계하고 구현하는 방법을 소개합니다.
            """,
        Speakers = [han_devops],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        Topic = SessionTopic.DevOps,
        Tags = ["DevOps", "CI/CD", "GitHub Actions"]
    };

    #endregion

    #region Tracks

    private Track main_hall => new()
    {
        Id = nameof(main_hall),
        Name = "메인 홀",
        Color = "#6f42c1",
        Sessions = SessionCollection.Create(keynote, cloud_native, blazor_united, mlnet_ai, maui_crossplatform, github_actions)
    };

    #endregion

    #region Sponsors

    private readonly Sponsor microsoft = new() { Id = nameof(microsoft), Name = "Microsoft", Tier = SponsorTier.Platinum, WebsiteUrl = "https://microsoft.com", Description = "공식 플래티넘 스폰서" };
    private readonly Sponsor jetbrains = new() { Id = nameof(jetbrains), Name = "JetBrains", Tier = SponsorTier.Gold, WebsiteUrl = "https://jetbrains.com" };
    private readonly Sponsor aws = new() { Id = nameof(aws), Name = "AWS", Tier = SponsorTier.Gold, WebsiteUrl = "https://aws.amazon.com" };
    private readonly Sponsor github = new() { Id = nameof(github), Name = "GitHub", Tier = SponsorTier.Silver, WebsiteUrl = "https://github.com" };
    private readonly Sponsor telerik = new() { Id = nameof(telerik), Name = "Telerik", Tier = SponsorTier.Silver, WebsiteUrl = "https://telerik.com" };

    #endregion

    #region Venue

    private VenueInfo coex => new()
    {
        Id = nameof(coex),
        Name = "서울 코엑스",
        Address = "서울시 강남구 영동대로 513",
        Tracks = TrackCollection.Create(main_hall)
    };

    #endregion

    public EventInfo Event => new()
    {
        Slug = Slug,
        Year = 2024,
        Title = ".NET Conf 2024 x Seoul",
        Theme = ".NET 8의 새로운 시대",
        Description = ".NET 8의 새로운 기능들과 함께 400명 이상의 개발자가 함께한 역대 최대 규모의 컨퍼런스입니다.",
        Date = new DateTime(2024, 11, 16),
        Type = EventType.Offline,
        AttendeeCount = 400,
        HeroImageUrl = "/images/events/2024-hero.webp",
        Venues = VenueCollection.Create(coex),
        Sponsors = SponsorCollection.Create(microsoft, jetbrains, aws, github, telerik)
    };

    public ScheduleGrid Schedule => new ScheduleGridBuilder()
        .ForDay(1)
        .AddTrack(main_hall)

        .AddTimeSlot(new TimeOnly(13, 0), 60, slot => slot
            .At(0, keynote))

        .AddTimeSlot(new TimeOnly(14, 0), 45, slot => slot
            .At(0, cloud_native))

        .AddTimeSlot(new TimeOnly(14, 55), 45, slot => slot
            .At(0, blazor_united))

        .AddTimeSlot(new TimeOnly(15, 50), 45, slot => slot
            .At(0, mlnet_ai))

        .AddTimeSlot(new TimeOnly(16, 45), 45, slot => slot
            .At(0, maui_crossplatform))

        .AddTimeSlot(new TimeOnly(17, 40), 45, slot => slot
            .At(0, github_actions))

        .Build();
}
