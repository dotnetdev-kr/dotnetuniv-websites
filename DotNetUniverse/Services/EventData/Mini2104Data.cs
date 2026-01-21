using DotNetUniverse.Models;
using DotNetUniverse.Models.Collections;

namespace DotNetUniverse.Services.EventData;

/// <summary>
/// 2021년 4월 .NET Conf Mini 21.04 행사 데이터
/// </summary>
public class Mini2104Data : IEventData
{
    public string Slug => "mini/2104";
    public int Year => 2021;
    public string ThemeColor => "#6f42c1";
    public string ThemeColorClass => "purple";

    #region Speakers

    private readonly Speaker heechang_kim = new()
    {
        Id = nameof(heechang_kim),
        Name = "김희창",
        Title = "운영진",
        Company = "닷넷오픈채팅방",
        Bio = "닷넷 C# 개발자 모임 운영을 맡고 있으며, VB6.0을 시작으로 현재는 C# 및 JAVA 개발을 진행하고 있습니다.",
        ImageUrl = "/images/speakers/heechang_kim.png"
    };

    private readonly Speaker hyunmo_ahn = new()
    {
        Id = nameof(hyunmo_ahn),
        Name = "안현모",
        Title = "수석연구원",
        Company = "MSoftware",
        Bio = "온라인에서 bluepope(블루포프)라는 닉네임으로 활동하고 있습니다. Web 기반 기술에 관심을 가지며, .NET 기반 기술 전반에 관심을 갖고 있습니다.",
        ImageUrl = "/images/speakers/hyunmo_ahn.png"
    };

    private readonly Speaker seil_jung = new()
    {
        Id = nameof(seil_jung),
        Name = "정세일",
        Title = "기술이사",
        Company = "마음인",
        Bio = "온라인에서 디모이라는 닉네임으로 활동하고 있습니다. C# 초기 버전부터 사용해온 C#을 좋아하는 프로그래머입니다.",
        ImageUrl = "/images/speakers/seil_jung.png"
    };

    public SpeakerCollection Speakers => SpeakerCollection.Create(
        heechang_kim, hyunmo_ahn, seil_jung
    );

    #endregion

    #region Sessions

    private Session vs_debug => new()
    {
        Id = nameof(vs_debug),
        Title = "Visual Studio 사용법 (출력을 이용한 디버그 사용방법)",
        Abstract = "Visual Studio의 출력 창을 이용한 디버그 사용 방법을 소개합니다.",
        Speakers = [heechang_kim],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(34),
        VideoUrl = "https://www.youtube.com/watch?v=lZYigfYzwHk",
        Tags = ["Visual Studio", "Debug", "주니어"]
    };

    private Session blazor_intro => new()
    {
        Id = nameof(blazor_intro),
        Title = "ASP.NET Blazor는 처음이라.",
        Abstract = """
            닷넷 3.0부터 추가된 Blazor에 대한 간단한 소개 및 향후 발전 방향에 대한 내용입니다.
            Blazor의 기본 개념과 활용 방법을 알아봅니다.
            """,
        Speakers = [hyunmo_ahn],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(53),
        VideoUrl = "https://www.youtube.com/watch?v=-lI68dDHTAM",
        Tags = ["Blazor", "ASP.NET", "Web", "시니어"]
    };

    private Session span_t => new()
    {
        Id = nameof(span_t),
        Title = "Span<T>을 실무에 사용해보자",
        Abstract = """
            C# 7.2, .NET Core 2.1부터 사용 가능한 Span<T>에 대해 빠르게 개념적으로 이해하고, 
            실무에 적용하면 어떤 이점이 있는지 알아봅니다.
            """,
        Speakers = [seil_jung],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(24),
        VideoUrl = "https://www.youtube.com/watch?v=fYPlHocxy3Y",
        Tags = ["Span<T>", "C#", "Performance", "시니어"]
    };

    private Session closing => new()
    {
        Id = nameof(closing),
        Title = "마무리",
        Abstract = "행사 마무리 및 질의응답 시간입니다.",
        Speakers = [],
        Format = SessionFormat.Closing,
        Duration = TimeSpan.FromMinutes(7),
        IsShared = true
    };

    #endregion

    #region Sponsors

    private readonly Sponsor infragistics = new()
    {
        Id = nameof(infragistics),
        Name = "Infragistics",
        Tier = SponsorTier.Silver,
        WebsiteUrl = "https://www.infragistics.co.kr/about-us/contact-us",
        LogoUrl = "/images/sponsors/infragistics_2104.png"
    };

    private readonly Sponsor grapecity = new()
    {
        Id = nameof(grapecity),
        Name = "GrapeCity",
        Tier = SponsorTier.Silver,
        WebsiteUrl = "https://www.grapecity.co.kr/",
        LogoUrl = "/images/sponsors/grapecity_2104.png"
    };

    private readonly Sponsor jetbrains = new()
    {
        Id = nameof(jetbrains),
        Name = "JetBrains",
        Tier = SponsorTier.Silver,
        WebsiteUrl = "https://www.jetbrains.com/ko-kr",
        LogoUrl = "/images/sponsors/jetbrains_2104.png"
    };

    private readonly Sponsor microsoft = new()
    {
        Id = nameof(microsoft),
        Name = "Microsoft Korea",
        Tier = SponsorTier.Gold,
        WebsiteUrl = "https://www.microsoft.com/ko-kr",
        LogoUrl = "/images/sponsors/microsoft_2104.png"
    };

    #endregion

    #region Tracks

    private Track main => new()
    {
        Id = nameof(main),
        Name = "Main",
        Description = "메인 세션",
        Color = "#6f42c1",
        Sessions = SessionCollection.Create(
            vs_debug, blazor_intro, span_t, closing
        )
    };

    #endregion

    #region Venue

    private VenueInfo online => new()
    {
        Id = nameof(online),
        Name = "온라인 (닷넷데브 YouTube 채널)",
        Address = "온라인",
        Tracks = TrackCollection.Create(main)
    };

    #endregion

    public EventInfo Event => new()
    {
        Slug = Slug,
        Year = 2021,
        Title = ".NET Conf Mini 21.04",
        Scale = EventScale.Meetup,
        Theme = "비정기 닷넷 개발자 온라인 세미나",
        Description = """
            .NET Conf Mini는 비정기적으로 열리는 닷넷 개발자들을 위한 온라인 세미나입니다. 
            닷넷을 사용하는 개발자 분들의 다채롭고 다양한 경험을 공유하기 위하여 만들어졌으며, 
            닷넷 개발자라면 누구나 발표할 수 있고, 닷넷에 관심있는 분들이라면 모두 환영합니다.
            """,
        Date = new DateTime(2021, 4, 4, 10, 0, 0),
        Type = EventType.Online,
        Venues = VenueCollection.Create(online),
        Sponsors = SponsorCollection.Create(microsoft, infragistics, grapecity, jetbrains)
    };

    public ScheduleGrid Schedule => new ScheduleGridBuilder()
        .ForDay(1)
        .AddTrack(main)

        .AddTimeSlot(new TimeOnly(10, 0), 34, slot => slot
            .At(0, vs_debug))

        .AddTimeSlot(new TimeOnly(10, 39), 53, slot => slot
            .At(0, blazor_intro))

        .AddTimeSlot(new TimeOnly(11, 36), 24, slot => slot
            .At(0, span_t))

        .AddTimeSlot(new TimeOnly(12, 0), 7, slot => slot
            .FullWidth(closing))

        .Build();
}
