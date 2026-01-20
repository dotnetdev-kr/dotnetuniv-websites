using DotNetUniverse.Models;
using DotNetUniverse.Models.Collections;

namespace DotNetUniverse.Services.YearData;

/// <summary>
/// 2025년 행사 데이터
/// </summary>
public class Year2025Data : IEventData
{
    public string Slug => "2025";
    public int Year => 2025;
    public string ThemeColor => "#ffc107";
    public string ThemeColorClass => "warning";

    #region Speakers

    private readonly Speaker kim_copilot = new()
    {
        Id = nameof(kim_copilot),
        Name = "김코파일럿",
        Title = "AI Developer Advocate",
        Company = "Microsoft",
        Bio = "GitHub Copilot 및 AI 개발 도구 전문가로서 개발자 생산성 향상을 위한 AI 도구 활용법을 전파하고 있습니다.",
        GitHubUrl = "https://github.com/kimcopilot"
    };

    private readonly Speaker lee_aspire = new()
    {
        Id = nameof(lee_aspire),
        Name = "이아스파이어",
        Title = "Cloud Native Architect",
        Company = "Azure Korea",
        Bio = ".NET Aspire 및 클라우드 네이티브 전문가로서 분산 시스템 설계와 구축에 풍부한 경험을 보유하고 있습니다."
    };

    private readonly Speaker park_united = new()
    {
        Id = nameof(park_united),
        Name = "박유나이티드",
        Title = "Blazor Expert",
        Company = "웹테크놀로지",
        Bio = "Blazor United 및 풀스택 개발 전문가로서 현대적인 웹 애플리케이션 아키텍처에 대한 깊은 이해를 가지고 있습니다."
    };

    private readonly Speaker jung_semantic = new()
    {
        Id = nameof(jung_semantic),
        Name = "정시멘틱",
        Title = "ML Engineer",
        Company = "AI 스타트업",
        Bio = "Semantic Kernel 및 LLM 통합 전문가로서 AI 기반 지능형 애플리케이션 개발에 전문성을 가지고 있습니다."
    };

    private readonly Speaker choi_mobile = new()
    {
        Id = nameof(choi_mobile),
        Name = "최모바일",
        Title = "Mobile Developer",
        Company = "앱컴퍼니",
        Bio = ".NET MAUI 및 모바일 개발 전문가로서 크로스플랫폼 앱 개발에 깊은 경험을 보유하고 있습니다."
    };

    private readonly Speaker han_performance = new()
    {
        Id = nameof(han_performance),
        Name = "한퍼포먼스",
        Title = "Performance Engineer",
        Company = "테크기업",
        Bio = ".NET 성능 최적화 및 AOT 전문가로서 고성능 애플리케이션 구축에 전문성을 가지고 있습니다."
    };

    private readonly Speaker yoo_cloud = new()
    {
        Id = nameof(yoo_cloud),
        Name = "유클라우드",
        Title = "DevOps Lead",
        Company = "클라우드코리아",
        Bio = "Azure DevOps 및 인프라 전문가로서 클라우드 인프라 자동화 및 관리에 풍부한 경험을 보유하고 있습니다."
    };

    private readonly Speaker kang_security = new()
    {
        Id = nameof(kang_security),
        Name = "강시큐리티",
        Title = "Security Architect",
        Company = "보안회사",
        Bio = ".NET 보안 및 Identity 전문가로서 애플리케이션 보안 아키텍처 설계에 전문성을 가지고 있습니다."
    };

    public SpeakerCollection Speakers => SpeakerCollection.Create(
        kim_copilot, lee_aspire, park_united, jung_semantic,
        choi_mobile, han_performance, yoo_cloud, kang_security
    );

    #endregion

    #region Sessions

    private Session keynote => new()
    {
        Id = nameof(keynote),
        Title = "키노트: .NET 10의 새로운 기능",
        Abstract = """
            .NET 10에서 추가된 주요 기능들과 앞으로의 로드맵을 소개합니다.
            C# 14의 새로운 언어 기능, 런타임 성능 개선, AI 통합 기능 강화 등
            .NET 생태계의 최신 트렌드와 미래 방향성을 공유합니다.
            """,
        Speakers = [kim_copilot],
        Format = SessionFormat.Keynote,
        Duration = TimeSpan.FromMinutes(60),
        Topic = SessionTopic.General,
        Tags = [".NET 10", "C# 14", "Roadmap"]
    };

    private Session github_copilot => new()
    {
        Id = nameof(github_copilot),
        Title = "GitHub Copilot으로 생산성 10배 높이기",
        Abstract = """
            GitHub Copilot을 활용한 AI 페어 프로그래밍으로 개발 생산성을 극대화하는 방법을 배웁니다.
            코드 자동 완성, 테스트 생성, 문서화, 코드 리뷰 등 다양한 시나리오에서
            Copilot을 효과적으로 활용하는 팁과 베스트 프랙티스를 공유합니다.
            """,
        Speakers = [kim_copilot],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        Topic = SessionTopic.AI,
        Tags = ["GitHub Copilot", "AI", "Productivity"]
    };

    private Session aspire => new()
    {
        Id = nameof(aspire),
        Title = ".NET Aspire로 클라우드 네이티브 앱 구축",
        Abstract = """
            .NET Aspire를 활용하여 분산 시스템을 개발하고 오케스트레이션하는 방법을 알아봅니다.
            서비스 디스커버리, 구성 관리, 헬스 체크, 텔레메트리 등
            클라우드 네이티브 앱 개발에 필요한 모든 것을 Aspire로 간소화하는 방법을 다룹니다.
            """,
        Speakers = [lee_aspire],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        Topic = SessionTopic.Cloud,
        Tags = ["Aspire", "Cloud Native", "Microservices"]
    };

    private Session blazor_united => new()
    {
        Id = nameof(blazor_united),
        Title = "Blazor United 완전 정복",
        Abstract = """
            Blazor의 Server, WebAssembly, Auto 모드를 완벽하게 이해하고 활용하는 방법을 배웁니다.
            렌더링 모드 선택 전략, 상태 관리, 인증/인가, 성능 최적화 등
            실제 프로덕션 환경에서 Blazor를 효과적으로 사용하는 방법을 소개합니다.
            """,
        Speakers = [park_united],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        Topic = SessionTopic.Web,
        Tags = ["Blazor", "WebAssembly", "SSR"]
    };

    private Session semantic_kernel => new()
    {
        Id = nameof(semantic_kernel),
        Title = "Semantic Kernel로 LLM 앱 개발하기",
        Abstract = """
            Microsoft Semantic Kernel을 활용하여 대규모 언어 모델을 .NET 앱에 통합하는 방법을 배웁니다.
            프롬프트 엔지니어링, 플러그인 개발, 메모리 관리, 에이전트 구현 등
            LLM 기반 지능형 애플리케이션을 구축하는 실용적인 방법을 다룹니다.
            """,
        Speakers = [jung_semantic],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        Topic = SessionTopic.AI,
        Tags = ["Semantic Kernel", "LLM", "OpenAI"]
    };

    private Session maui_hybrid => new()
    {
        Id = nameof(maui_hybrid),
        Title = ".NET MAUI Hybrid 앱 개발",
        Abstract = """
            Blazor와 .NET MAUI를 결합한 Hybrid 앱 개발 방법을 알아봅니다.
            웹 기술의 유연성과 네이티브 플랫폼의 성능을 모두 활용하여
            iOS, Android, Windows, macOS에서 동작하는 크로스플랫폼 앱을 개발하는 방법을 소개합니다.
            """,
        Speakers = [choi_mobile],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        Topic = SessionTopic.Mobile,
        Tags = [".NET MAUI", "Hybrid", "Blazor"]
    };

    private Session performance => new()
    {
        Id = nameof(performance),
        Title = ".NET 10 성능 최적화 전략",
        Abstract = """
            .NET 10에서 제공하는 다양한 성능 최적화 기법을 상세히 살펴봅니다.
            Native AOT 컴파일, GC 튜닝, 메모리 최적화, Span/Memory 활용 등
            고성능 .NET 애플리케이션을 구축하기 위한 실전 전략을 공유합니다.
            """,
        Speakers = [han_performance],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        Topic = SessionTopic.Performance,
        Tags = ["Performance", "AOT", "Optimization"]
    };

    private Session container_apps => new()
    {
        Id = nameof(container_apps),
        Title = "Azure Container Apps로 .NET 배포하기",
        Abstract = """
            Azure Container Apps를 활용한 컨테이너 기반 서버리스 배포 전략을 알아봅니다.
            자동 스케일링, 리비전 관리, 서비스 메시, Dapr 통합 등
            현대적인 클라우드 배포 아키텍처를 설계하고 구현하는 방법을 다룹니다.
            """,
        Speakers = [yoo_cloud],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        Topic = SessionTopic.Cloud,
        Tags = ["Azure", "Container Apps", "Serverless"]
    };

    #endregion

    #region Tracks

    private Track main_hall => new()
    {
        Id = nameof(main_hall),
        Name = "메인 홀",
        Color = "#6f42c1",
        Sessions = SessionCollection.Create(
            keynote, github_copilot, aspire, blazor_united,
            semantic_kernel, maui_hybrid, performance, container_apps
        )
    };

    #endregion

    #region Sponsors

    private readonly Sponsor microsoft = new() { Id = nameof(microsoft), Name = "Microsoft", Tier = SponsorTier.Platinum, WebsiteUrl = "https://microsoft.com", Description = "공식 플래티넘 스폰서" };
    private readonly Sponsor github = new() { Id = nameof(github), Name = "GitHub", Tier = SponsorTier.Platinum, WebsiteUrl = "https://github.com" };
    private readonly Sponsor jetbrains = new() { Id = nameof(jetbrains), Name = "JetBrains", Tier = SponsorTier.Gold, WebsiteUrl = "https://jetbrains.com" };
    private readonly Sponsor aws = new() { Id = nameof(aws), Name = "AWS", Tier = SponsorTier.Gold, WebsiteUrl = "https://aws.amazon.com" };
    private readonly Sponsor telerik = new() { Id = nameof(telerik), Name = "Telerik", Tier = SponsorTier.Silver, WebsiteUrl = "https://telerik.com" };
    private readonly Sponsor syncfusion = new() { Id = nameof(syncfusion), Name = "Syncfusion", Tier = SponsorTier.Silver, WebsiteUrl = "https://syncfusion.com" };

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
        Year = 2025,
        Title = ".NET Conf 2025 x Seoul",
        Theme = "AI 시대의 .NET 개발",
        Description = ".NET 10과 AI 통합을 주제로 500명 이상의 개발자가 함께할 닷넷 유니버스 2025입니다.",
        Date = new DateTime(2025, 11, 15),
        Type = EventType.Offline,
        AttendeeCount = 500,
        IsUpcoming = true,
        HeroImageUrl = "/images/events/2025-hero.webp",
        Venues = VenueCollection.Create(coex),
        Sponsors = SponsorCollection.Create(microsoft, github, jetbrains, aws, telerik, syncfusion)
    };

    public ScheduleGrid Schedule => new ScheduleGridBuilder()
        .ForDay(1)
        .AddTrack(main_hall)

        .AddTimeSlot(new TimeOnly(13, 0), 60, slot => slot
            .At(0, keynote))

        .AddTimeSlot(new TimeOnly(14, 0), 45, slot => slot
            .At(0, github_copilot))

        .AddTimeSlot(new TimeOnly(14, 55), 45, slot => slot
            .At(0, aspire))

        .AddTimeSlot(new TimeOnly(15, 50), 45, slot => slot
            .At(0, blazor_united))

        .AddTimeSlot(new TimeOnly(16, 45), 45, slot => slot
            .At(0, semantic_kernel))

        .AddTimeSlot(new TimeOnly(17, 40), 45, slot => slot
            .At(0, maui_hybrid))

        .AddTimeSlot(new TimeOnly(18, 35), 45, slot => slot
            .At(0, performance))

        .AddTimeSlot(new TimeOnly(19, 30), 45, slot => slot
            .At(0, container_apps))

        .Build();
}
