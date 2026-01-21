using DotNetUniverse.Models;
using DotNetUniverse.Models.Collections;

namespace DotNetUniverse.Services.EventData;

/// <summary>
/// 2021년 8월 .NET Conf Mini 21.08 행사 데이터
/// </summary>
public class Mini2108Data : IEventData
{
    public string Slug => "mini/2108";
    public int Year => 2021;
    public string ThemeColor => "#6f42c1";
    public string ThemeColorClass => "purple";

    #region Speakers

    private readonly Speaker seil_jung = new()
    {
        Id = nameof(seil_jung),
        Name = "정세일",
        Title = "기술이사",
        Bio = "디모이라는 이름으로 활동하고 있습니다. .NET 기술을 좋아하고 최신 기술을 빠르게 습득하려고 노력합니다. 작은 회사의 기술이사이고 대학 강사로도 활동하고 있습니다.",
        ImageUrl = "/images/speakers/seil_jung_2108.png"
    };

    private readonly Speaker brian_lagunas = new()
    {
        Id = nameof(brian_lagunas),
        Name = "브라이언 라구나스 (Brian Lagunas)",
        Title = "수석 제품 PO",
        Company = "Infragistics",
        Bio = "Microsoft MVP, Xamarin MVP, Microsoft Patterns & Practices Champion. Prism Library OSS 프로젝트 소유 및 유지 관리자로 총 다운로드 2천만 회를 돌파했습니다.",
        ImageUrl = "/images/speakers/brian_lagunas.png"
    };

    private readonly Speaker sanghyun_kim = new()
    {
        Id = nameof(sanghyun_kim),
        Name = "김상현",
        Title = "Solution Architect",
        Bio = "Machine Learning을 활용해 스마트팜을 위한 솔루션을 연구 개발하는 스타트업에서 Solution Architect로 근무하고 있습니다.",
        ImageUrl = "/images/speakers/sanghyun_kim_2108.png"
    };

    private readonly Speaker james_lee = new()
    {
        Id = nameof(james_lee),
        Name = "제임스 (james.lee)",
        Title = "연구원",
        Company = "(주)오픈에스지",
        Bio = "닷넷에 푹 빠져 있는 15년차 개발자입니다. 닷넷은 끊임없이 변화를 시도하고 발전해 나가는 것에 진심이 느껴져서 좋아합니다.",
        ImageUrl = "/images/speakers/james_lee.jpeg"
    };

    private readonly Speaker gusam_park = new()
    {
        Id = nameof(gusam_park),
        Name = "박구삼",
        Title = "개발자",
        Bio = "닷넷 기술에 관심을 갖고 공부하기 시작했습니다. 현재 Xamarin을 이용하여 모바일 애플리케이션 개발을 진행하고 있습니다.",
        ImageUrl = "/images/speakers/gusam_park.jpg"
    };

    public SpeakerCollection Speakers => SpeakerCollection.Create(
        seil_jung, brian_lagunas, sanghyun_kim, james_lee, gusam_park
    );

    #endregion

    #region Sessions

    private Session winui3_intro => new()
    {
        Id = nameof(winui3_intro),
        Title = "WinUI 3 소개",
        Abstract = """
            올 하반기 공식 릴리즈가 예정된 Windows App SDK (구 Project Reunion)은 현재 안정화 버전 0.8.1로 
            Microsoft Store에서 Windows App SDK 0.8.1이 적용된 WinUI 3 갤러리를 내려받을 수 있습니다. 
            버전 1이 되면 Windows Desktop 뿐만 아니라 UWP, WPF, Windows Forms 등에서 WinUI 3을 사용할 수 있게 됩니다.
            """,
        Speakers = [seil_jung],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(20),
        VideoUrl = "https://www.youtube.com/watch?v=Gg0WfSonXgs",
        Tags = ["WinUI 3", "Windows App SDK", "주니어"]
    };

    private Session yield_return => new()
    {
        Id = nameof(yield_return),
        Title = "Yield Return은 무엇이며 어떻게 작동할까요?",
        Abstract = """
            이 세션에서는 C#의 yield return이 무엇인지, yield return이 작동하는 방식 및 
            yield return을 사용하는 경우에 대해 설명합니다. 
            또한 yield return을 비동기적으로 사용하는 방법도 보여드릴 예정입니다.
            """,
        Speakers = [brian_lagunas],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(26),
        VideoUrl = "https://www.youtube.com/watch?v=rc6XdnXuT2s",
        Tags = ["C#", "yield return", "시니어"]
    };

    private Session nuget_intro => new()
    {
        Id = nameof(nuget_intro),
        Title = "늦었지만 Nuget을 소개합니다.",
        Abstract = "이제 NuGet은 .NET과 뗄 수 없는 사이가 되었죠? NuGet에 대한 전반적인 내용을 간략하게 살펴봅니다.",
        Speakers = [sanghyun_kim],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(25),
        Tags = ["NuGet", "주니어"]
    };

    private Session blazor_oauth => new()
    {
        Id = nameof(blazor_oauth),
        Title = "Blazor ID 구조와 외부 인증(OAuth) 끝내기",
        Abstract = "Blazor의 Identity 구조와 OAuth를 활용한 외부 인증 구현 방법을 알아봅니다.",
        Speakers = [james_lee],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(20),
        VideoUrl = "https://www.youtube.com/watch?v=grXtvHvoKoo",
        Tags = ["Blazor", "OAuth", "Identity", "시니어"]
    };

    private Session wpf_animation => new()
    {
        Id = nameof(wpf_animation),
        Title = "WPF에서 애니메이션을 사용하기",
        Abstract = "WPF 내 애니메이션 기능을 활용하여 UI에 생동감을 더하는 방법을 알아봅니다.",
        Speakers = [gusam_park],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(23),
        VideoUrl = "https://www.youtube.com/watch?v=uYobpnwSdik",
        Tags = ["WPF", "Animation", "주니어"]
    };

    #endregion

    #region Sponsors

    private readonly Sponsor grapecity = new()
    {
        Id = nameof(grapecity),
        Name = "GrapeCity",
        Tier = SponsorTier.Silver,
        WebsiteUrl = "https://www.grapecity.co.kr/",
        LogoUrl = "/images/sponsors/grapecity_2108.png"
    };

    private readonly Sponsor infragistics = new()
    {
        Id = nameof(infragistics),
        Name = "Infragistics",
        Tier = SponsorTier.Silver,
        WebsiteUrl = "https://www.infragistics.co.kr/about-us/contact-us",
        LogoUrl = "/images/sponsors/infragistics_2108.png"
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
            winui3_intro, yield_return, nuget_intro, blazor_oauth, wpf_animation
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
        Title = ".NET Conf Mini 21.08",
        Scale = EventScale.Meetup,
        Theme = "비정기 닷넷 개발자 온라인 세미나",
        Description = """
            .NET Conf Mini는 비정기적으로 열리는 닷넷 개발자들을 위한 온라인 세미나입니다. 
            닷넷을 사용하는 개발자 분들의 다채롭고 다양한 경험을 공유하기 위하여 만들어졌으며, 
            닷넷 개발자라면 누구나 발표할 수 있고, 닷넷에 관심있는 분들이라면 모두 환영합니다.
            """,
        Date = new DateTime(2021, 8, 15, 14, 0, 0),
        Type = EventType.Online,
        Venues = VenueCollection.Create(online),
        Sponsors = SponsorCollection.Create(grapecity, infragistics)
    };

    public ScheduleGrid Schedule => new ScheduleGridBuilder()
        .ForDay(1)
        .AddTrack(main)

        .AddTimeSlot(new TimeOnly(14, 0), 20, slot => slot
            .At(0, winui3_intro))

        .AddTimeSlot(new TimeOnly(14, 20), 26, slot => slot
            .At(0, yield_return))

        .AddTimeSlot(new TimeOnly(14, 46), 25, slot => slot
            .At(0, nuget_intro))

        .AddTimeSlot(new TimeOnly(15, 11), 20, slot => slot
            .At(0, blazor_oauth))

        .AddTimeSlot(new TimeOnly(15, 31), 23, slot => slot
            .At(0, wpf_animation))

        .Build();
}
