using DotNetUniverse.Models;
using DotNetUniverse.Models.Collections;

namespace DotNetUniverse.Services.YearData;

/// <summary>
/// 2023년 행사 데이터
/// </summary>
public class Year2023Data : IEventData
{
    public string Slug => "2023";
    public int Year => 2023;
    public string ThemeColor => "#0d6efd";
    public string ThemeColorClass => "primary";

    #region Speakers

    private readonly Speaker kim_dotnet7 = new()
    {
        Id = nameof(kim_dotnet7),
        Name = "김닷넷세븐",
        Title = "Microsoft MVP",
        Company = "테크기업",
        Bio = ".NET 7 및 성능 최적화 전문가로서 고성능 애플리케이션 개발에 풍부한 경험을 보유하고 있습니다."
    };

    private readonly Speaker lee_aot = new()
    {
        Id = nameof(lee_aot),
        Name = "이에이오티",
        Title = "Performance Engineer",
        Company = "퍼포먼스랩",
        Bio = "Native AOT 및 성능 최적화 전문가입니다."
    };

    private readonly Speaker park_blazor = new()
    {
        Id = nameof(park_blazor),
        Name = "박블레이저",
        Title = "Frontend Developer",
        Company = "웹테크",
        Bio = "Blazor 전문가로서 SPA 및 서버사이드 렌더링에 대한 깊은 지식을 보유하고 있습니다."
    };

    private readonly Speaker jung_orleans = new()
    {
        Id = nameof(jung_orleans),
        Name = "정올리언스",
        Title = "Distributed Systems Engineer",
        Company = "분산시스템랩",
        Bio = "Microsoft Orleans 및 분산 시스템 전문가입니다."
    };

    private readonly Speaker choi_openai = new()
    {
        Id = nameof(choi_openai),
        Name = "최오픈에이아이",
        Title = "AI Engineer",
        Company = "AI스타트업",
        Bio = "OpenAI API 및 .NET 통합 전문가로서 AI 애플리케이션 개발에 전문성을 가지고 있습니다."
    };

    public SpeakerCollection Speakers => SpeakerCollection.Create(
        kim_dotnet7, lee_aot, park_blazor, jung_orleans, choi_openai
    );

    #endregion

    #region Sessions

    private Session keynote => new()
    {
        Id = nameof(keynote),
        Title = ".NET 7 성능 혁신",
        Abstract = """
            .NET 7에서 이루어진 다양한 성능 개선사항을 심층 분석합니다.
            JIT 컴파일러 개선, GC 최적화, 라이브러리 성능 향상 등을 다룹니다.
            """,
        Speakers = [kim_dotnet7],
        Format = SessionFormat.Keynote,
        Duration = TimeSpan.FromMinutes(60),
        Topic = SessionTopic.General,
        VideoUrl = "https://youtube.com/watch?v=2023keynote",
        Tags = [".NET 7", "Performance", "JIT"]
    };

    private Session native_aot => new()
    {
        Id = nameof(native_aot),
        Title = "Native AOT로 초고속 시작 시간 달성",
        Abstract = """
            Native AOT 컴파일을 통해 밀리초 단위의 시작 시간을 달성하는 방법을 배웁니다.
            AOT 호환성 검사, 트리밍, 리플렉션 처리 등 실전 노하우를 공유합니다.
            """,
        Speakers = [lee_aot],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        Topic = SessionTopic.Performance,
        VideoUrl = "https://youtube.com/watch?v=2023aot",
        Tags = ["Native AOT", "Performance", "Startup"]
    };

    private Session blazor_custom => new()
    {
        Id = nameof(blazor_custom),
        Title = "Blazor 커스텀 컴포넌트 개발",
        Abstract = """
            재사용 가능한 Blazor 컴포넌트를 설계하고 개발하는 방법을 배웁니다.
            컴포넌트 라이브러리 구축, NuGet 패키지 배포까지 전체 과정을 다룹니다.
            """,
        Speakers = [park_blazor],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        Topic = SessionTopic.Web,
        VideoUrl = "https://youtube.com/watch?v=2023blazor",
        Tags = ["Blazor", "Components", "NuGet"]
    };

    private Session orleans => new()
    {
        Id = nameof(orleans),
        Title = "Microsoft Orleans로 분산 시스템 구축",
        Abstract = """
            Microsoft Orleans를 활용한 확장 가능한 분산 시스템 구축 방법을 배웁니다.
            Virtual Actor 패턴, 그레인 설계, 클러스터 구성 등을 다룹니다.
            """,
        Speakers = [jung_orleans],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        Topic = SessionTopic.Cloud,
        VideoUrl = "https://youtube.com/watch?v=2023orleans",
        Tags = ["Orleans", "Distributed Systems", "Actor Model"]
    };

    private Session openai_dotnet => new()
    {
        Id = nameof(openai_dotnet),
        Title = "OpenAI API와 .NET 통합",
        Abstract = """
            OpenAI API를 .NET 애플리케이션에 통합하는 방법을 배웁니다.
            ChatGPT, DALL-E 등 다양한 AI 서비스를 활용한 지능형 앱 개발을 소개합니다.
            """,
        Speakers = [choi_openai],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        Topic = SessionTopic.AI,
        VideoUrl = "https://youtube.com/watch?v=2023openai",
        Tags = ["OpenAI", "ChatGPT", "AI"]
    };

    #endregion

    #region Tracks

    private Track main => new()
    {
        Id = nameof(main),
        Name = "메인 트랙",
        Color = "#0d6efd",
        Sessions = SessionCollection.Create(keynote, native_aot, blazor_custom, orleans, openai_dotnet)
    };

    #endregion

    #region Sponsors

    private readonly Sponsor microsoft = new() { Id = nameof(microsoft), Name = "Microsoft", Tier = SponsorTier.Platinum, WebsiteUrl = "https://microsoft.com" };
    private readonly Sponsor jetbrains = new() { Id = nameof(jetbrains), Name = "JetBrains", Tier = SponsorTier.Gold, WebsiteUrl = "https://jetbrains.com" };
    private readonly Sponsor github = new() { Id = nameof(github), Name = "GitHub", Tier = SponsorTier.Gold, WebsiteUrl = "https://github.com" };
    private readonly Sponsor aws = new() { Id = nameof(aws), Name = "AWS", Tier = SponsorTier.Silver, WebsiteUrl = "https://aws.amazon.com" };

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
        Year = 2023,
        Title = ".NET Universe 2023",
        Theme = ".NET 7 성능의 새로운 기준",
        Description = ".NET 7의 성능 개선과 Native AOT를 중심으로 350명 이상이 참여한 온라인 컨퍼런스입니다.",
        Date = new DateTime(2023, 11, 11),
        Type = EventType.Online,
        AttendeeCount = 350,
        HeroImageUrl = "/images/events/2023-hero.webp",
        Venues = VenueCollection.Create(online),
        Sponsors = SponsorCollection.Create(microsoft, jetbrains, github, aws)
    };

    public ScheduleGrid Schedule => new ScheduleGridBuilder()
        .ForDay(1)
        .AddTrack(main)

        .AddTimeSlot(new TimeOnly(13, 0), 60, slot => slot
            .At(0, keynote))

        .AddTimeSlot(new TimeOnly(14, 0), 45, slot => slot
            .At(0, native_aot))

        .AddTimeSlot(new TimeOnly(14, 55), 45, slot => slot
            .At(0, blazor_custom))

        .AddTimeSlot(new TimeOnly(15, 50), 45, slot => slot
            .At(0, orleans))

        .AddTimeSlot(new TimeOnly(16, 45), 45, slot => slot
            .At(0, openai_dotnet))

        .Build();
}
