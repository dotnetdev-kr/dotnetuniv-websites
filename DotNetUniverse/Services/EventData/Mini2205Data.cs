using DotNetUniverse.Models;
using DotNetUniverse.Models.Collections;

namespace DotNetUniverse.Services.EventData;

/// <summary>
/// 2022년 5월 .NET Conf Mini 22.05 행사 데이터
/// </summary>
public class Mini2205Data : IEventData
{
    public string Slug => "mini/2205";
    public int Year => 2022;
    public string ThemeColor => "#6f42c1";
    public string ThemeColorClass => "purple";

    #region Speakers

    private readonly Speaker jungsu_kim = new()
    {
        Id = nameof(jungsu_kim),
        Name = "김정수",
        Title = "프리랜서 개발자",
        Bio = "프리랜서 닷넷 개발자로 활동하며, DotNetAMA YouTube 채널을 운영하고 있습니다. 또한 Udemy 강사도 병행하고 있습니다.",
        ImageUrl = "/images/speakers/jungsu_kim.png"
    };

    private readonly Speaker seil_jung = new()
    {
        Id = nameof(seil_jung),
        Name = "정세일",
        Title = "기술이사",
        Company = "마음인",
        Bio = ".NET C#으로 개발을 즐겨하는 개발자입니다. 마음인 기술이사이자 대학교 시간 강사로 일하고 있고 닷넷데브 커뮤니티에서 활동하고 있습니다.",
        ImageUrl = "/images/speakers/seil_jung_2205.png"
    };

    private readonly Speaker sangjun_lee = new()
    {
        Id = nameof(sangjun_lee),
        Name = "이상준",
        Title = "개발자",
        Bio = "Windows Desktop 개발자입니다.",
        ImageUrl = "/images/speakers/sangjun_lee.png"
    };

    private readonly Speaker sungtae_jung = new()
    {
        Id = nameof(sungtae_jung),
        Name = "정성태",
        Title = "MVP",
        Company = "(주)제니퍼소프트",
        Bio = "(주)제니퍼소프트에서 성능 관리 솔루션의 닷넷 버전 개발을 담당하고 있습니다. 개인 블로그(http://www.sysnet.pe.kr)를 통해 개발 관련 지식을 공유하고 있으며, 2004년부터 C/C++, C# 분야에서 마이크로소프트 MVP로 활동하고 있습니다.",
        ImageUrl = "/images/speakers/sungtae_jung_2205.png"
    };

    private readonly Speaker jaewoong_lee = new()
    {
        Id = nameof(jaewoong_lee),
        Name = "이재웅",
        Title = "수석 연구원",
        Company = "(주)오픈에스지",
        Bio = "(주)오픈에스지에서 수석 연구원으로 재직중이며 WPF를 사랑하는 개발자입니다. 데브엔코어라는 오픈소스 단체를 만들어서 다양한 활동을 하고 있습니다.",
        ImageUrl = "/images/speakers/jaewoong_lee.png"
    };

    public SpeakerCollection Speakers => SpeakerCollection.Create(
        jungsu_kim, seil_jung, sangjun_lee, sungtae_jung, jaewoong_lee
    );

    #endregion

    #region Sessions

    private Session mvc_blazor_review => new()
    {
        Id = nameof(mvc_blazor_review),
        Title = "MVC와 Blazor 코드리뷰",
        Abstract = "MVC와 Blazor의 코드를 비교하고 리뷰합니다.",
        Speakers = [jungsu_kim],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(26),
        VideoUrl = "https://www.youtube.com/watch?v=KvPpfYNZxGc",
        Tags = ["MVC", "Blazor", "중급"]
    };

    private Session windows_app_sdk => new()
    {
        Id = nameof(windows_app_sdk),
        Title = "윈도우 앱 SDK v1.1 소개",
        Abstract = "최신 윈도우 앱 개발에 관심이 있는 윈도우 애플리케이션 개발자를 대상으로 윈도우 앱 SDK 및 버전 1.1에 대한 내용을 소개합니다.",
        Speakers = [seil_jung],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(15),
        VideoUrl = "https://www.youtube.com/watch?v=JwHCmVKnX3s",
        Tags = ["Windows App SDK", "WinUI", "중급"]
    };

    private Session devexpress_mvvm => new()
    {
        Id = nameof(devexpress_mvvm),
        Title = "DevExpress WPF MVVM Framework를 이용하여 MVVM을 지켜보자",
        Abstract = "DevExpress WPF MVVM Framework를 활용하여 MVVM 패턴을 구현하는 방법을 알아봅니다.",
        Speakers = [sangjun_lee],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(28),
        VideoUrl = "https://www.youtube.com/watch?v=dZFJNLW8n9I",
        Tags = ["WPF", "MVVM", "DevExpress", "초급"]
    };

    private Session ffmpeg_csharp => new()
    {
        Id = nameof(ffmpeg_csharp),
        Title = "C# 개발자를 위한 ffmpeg 라이브러리 사용법",
        Abstract = "C# 개발자가 ffmpeg 라이브러리를 활용하는 방법을 알아봅니다.",
        Speakers = [sungtae_jung],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(17),
        VideoUrl = "https://www.youtube.com/watch?v=hZTaO4kS92E",
        Tags = ["C#", "ffmpeg", "중급"]
    };

    private Session wpf_binding => new()
    {
        Id = nameof(wpf_binding),
        Title = "WPF 바인딩 활용하기",
        Abstract = "WPF에서 데이터 바인딩을 효과적으로 활용하는 방법을 알아봅니다.",
        Speakers = [jaewoong_lee],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(15),
        VideoUrl = "https://www.youtube.com/watch?v=9MR8C_qWWdc",
        Tags = ["WPF", "Binding", "초급"]
    };

    #endregion

    #region Sponsors

    private readonly Sponsor nipa = new()
    {
        Id = nameof(nipa),
        Name = "정보통신산업진흥원",
        Tier = SponsorTier.Gold,
        WebsiteUrl = "https://www.nipa.kr/main/index.do",
        LogoUrl = "/images/sponsors/nipa.png"
    };

    private readonly Sponsor grapecity = new()
    {
        Id = nameof(grapecity),
        Name = "그레이프시티 코리아",
        Tier = SponsorTier.Silver,
        WebsiteUrl = "https://www.grapecity.co.kr/",
        LogoUrl = "/images/sponsors/grapecity_2205.png"
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
            mvc_blazor_review, windows_app_sdk, devexpress_mvvm, ffmpeg_csharp, wpf_binding
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
        Year = 2022,
        Title = ".NET Conf Mini 22.05",
        Scale = EventScale.Meetup,
        Theme = "비정기 닷넷 개발자 온라인 세미나",
        Description = """
            .NET Conf Mini는 비정기적으로 열리는 닷넷 개발자들을 위한 온라인 세미나입니다. 
            닷넷을 사용하는 개발자 분들의 다채롭고 다양한 경험을 공유하기 위하여 만들어졌으며, 
            닷넷 개발자라면 누구나 발표할 수 있고, 닷넷에 관심있는 분들이라면 모두 환영합니다.
            """,
        Date = new DateTime(2022, 5, 6, 14, 0, 0),
        Type = EventType.Online,
        Venues = VenueCollection.Create(online),
        Sponsors = SponsorCollection.Create(nipa, grapecity)
    };

    public ScheduleGrid Schedule => new ScheduleGridBuilder()
        .ForDay(1)
        .AddTrack(main)

        .AddTimeSlot(new TimeOnly(14, 0), 26, slot => slot
            .At(0, mvc_blazor_review))

        .AddTimeSlot(new TimeOnly(14, 30), 15, slot => slot
            .At(0, windows_app_sdk))

        .AddTimeSlot(new TimeOnly(14, 50), 28, slot => slot
            .At(0, devexpress_mvvm))

        .AddTimeSlot(new TimeOnly(15, 20), 17, slot => slot
            .At(0, ffmpeg_csharp))

        .AddTimeSlot(new TimeOnly(15, 40), 15, slot => slot
            .At(0, wpf_binding))

        .Build();
}
