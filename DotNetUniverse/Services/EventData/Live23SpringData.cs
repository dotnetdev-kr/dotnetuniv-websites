using DotNetUniverse.Models;
using DotNetUniverse.Models.Collections;

namespace DotNetUniverse.Services.EventData;

/// <summary>
/// 2023년 5월 .NET L!VE 2023 Spring 행사 데이터
/// </summary>
public class Live23SpringData : IEventData
{
    public string Slug => "live/2305";
    public int Year => 2023;
    public string ThemeColor => "#6f42c1";
    public string ThemeColorClass => "purple";

    #region Speakers

    private readonly Speaker donghoon_shin = new()
    {
        Id = nameof(donghoon_shin),
        Name = "신동훈",
        Title = "개발자",
        Bio = ".NET을 좋아하는 개발자입니다. 현재 .NET 데스크탑 애플리케이션 개발 업무를 처리하고 있습니다.",
        ImageUrl = "/images/speakers/donghoon_shin.jpg"
    };

    private readonly Speaker jangwon_jo = new()
    {
        Id = nameof(jangwon_jo),
        Name = "조장원",
        Title = "개발자",
        Bio = ".NET과 MAUI에 적용 가능한 Supabase에 대해 알아보고 누구보다 빠르게 백엔드에 집중하지 않고 서비스 개발을 시작해보는 시간을 가져봅니다.",
        ImageUrl = "/images/speakers/jangwon_jo.jpg"
    };

    private readonly Speaker jaewoong_lee = new()
    {
        Id = nameof(jaewoong_lee),
        Name = "이재웅",
        Title = "프리랜서",
        Bio = "현재 WPF 분야에서 프리랜서로 활동하고 있습니다. Avalonia UI를 WPF 개발자의 시각에서 자연스럽고 유연하게 접근할 수 있는 방법을 소개합니다.",
        ImageUrl = "/images/speakers/jaewoong_lee_2023.png"
    };

    private readonly Speaker sunghwan_lee = new()
    {
        Id = nameof(sunghwan_lee),
        Name = "이성환",
        Title = "백엔드 개발자",
        Company = "클로버추얼패션",
        Bio = "현재 클로버추얼패션에서 웹 백엔드 파트 개발을 맡고 있습니다. 10년 넘게 WPF 등의 데스크탑 클라이언트 프로그램을 개발했고 지금은 CLO-SET, CONNECT 라는 글로벌 서비스를 개발하고 있습니다.",
        ImageUrl = "/images/speakers/sunghwan_lee.png"
    };

    private readonly Speaker jinseok_kim = new()
    {
        Id = nameof(jinseok_kim),
        Name = "김진석",
        Title = "개발자",
        Bio = "매월 네번째 목요일에 Blazor Korea의 정기 밋업을 진행하고 있습니다. Everywhere .NET에 어울리는 Blazor Hybrid를 주제로 이야기를 진행합니다.",
        ImageUrl = "/images/speakers/jinseok_kim_2023.jpg"
    };

    public SpeakerCollection Speakers => SpeakerCollection.Create(
        donghoon_shin, jangwon_jo, jaewoong_lee, sunghwan_lee, jinseok_kim
    );

    #endregion

    #region Sessions

    private Session communitytoolkit_mvvm => new()
    {
        Id = nameof(communitytoolkit_mvvm),
        Title = "CommunityToolkit.Mvvm 살펴보기",
        Abstract = """
            CommunityToolkit.Mvvm 패키지는 MVVM 패턴 적용을 돕는 경량 라이브러리입니다. 
            CommunityToolkit.Mvvm 패키지에 포함된 여러 기능 요소와 다양한 활용 방법을 
            MVVM 패턴으로 개발된 샘플 앱과 함께 알아봅니다.
            """,
        Speakers = [donghoon_shin],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        Tags = ["CommunityToolkit", "MVVM", "초급"]
    };

    private Session supabase_maui => new()
    {
        Id = nameof(supabase_maui),
        Title = "Supabase로 시작하는 MAUI 앱 개발",
        Abstract = """
            .NET과 MAUI에 적용 가능한 Supabase에 대해 알아보고 
            누구보다 빠르게 백엔드에 집중하지 않고 서비스 개발을 시작해보는 시간을 가져봅니다.
            """,
        Speakers = [jangwon_jo],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        Tags = ["Supabase", ".NET MAUI", "중급"]
    };

    private Session avalonia_wpf => new()
    {
        Id = nameof(avalonia_wpf),
        Title = "WPF 시점에서 본 Avalonia UI",
        Abstract = """
            미지의 세계인 "Avalonia UI"를 WPF 개발자의 시각에서 자연스럽고 유연하게 
            접근할 수 있는 방법을 소개하면서, 이에 대해 여러분과 함께 의견을 나누고자 합니다.
            """,
        Speakers = [jaewoong_lee],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        Tags = ["Avalonia UI", "WPF", "크로스플랫폼", "초급"]
    };

    private Session azure_keyvault => new()
    {
        Id = nameof(azure_keyvault),
        Title = "쉿! 비밀이야! (Azure KeyVault를 이용한 민감정보 관리하기)",
        Abstract = """
            connection string, secret, token, key 등의 민감 정보를 소스코드나 파일에 저장하지 않고, 
            Azure KeyVault를 이용해 안전하게 보관하고 사용하는 방법을 이야기합니다.
            """,
        Speakers = [sunghwan_lee],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        Tags = ["Azure", "KeyVault", "보안", "중급"]
    };

    private Session blazor_hybrid => new()
    {
        Id = nameof(blazor_hybrid),
        Title = ".NET MAUI를 사용하는 Blazor Hybrid앱을 만들어보자",
        Abstract = """
            Blazor를 소개하고 .NET MAUI와 Hybrid앱을 통해 
            여러 플랫폼용 어플리케이션을 만드는 방법을 알아봅니다.
            """,
        Speakers = [jinseok_kim],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        Tags = ["Blazor", ".NET MAUI", "Hybrid", "초급"]
    };

    #endregion

    #region Sponsors

    private readonly Sponsor infragistics = new()
    {
        Id = nameof(infragistics),
        Name = "Infragistics",
        Tier = SponsorTier.Silver,
        WebsiteUrl = "https://www.infragistics.co.kr/",
        LogoUrl = "/images/sponsors/infragistics.png"
    };

    private readonly Sponsor maru180 = new()
    {
        Id = nameof(maru180),
        Name = "MARU 180",
        Tier = SponsorTier.Silver,
        WebsiteUrl = "https://maru.org/",
        Description = "장소 제공",
        LogoUrl = "/images/sponsors/maru180.png"
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
            communitytoolkit_mvvm, supabase_maui, avalonia_wpf, azure_keyvault, blazor_hybrid
        )
    };

    #endregion

    #region Venue

    private VenueInfo maru180_venue => new()
    {
        Id = nameof(maru180_venue),
        Name = "마루180 지하 1층 이벤트홀",
        Address = "서울특별시 강남구 역삼동",
        Tracks = TrackCollection.Create(main)
    };

    #endregion

    public EventInfo Event => new()
    {
        Slug = Slug,
        Year = 2023,
        Title = ".NET L!VE 2023 Spring",
        Scale = EventScale.Meetup,
        Theme = "Everywhere .NET",
        Description = """
            .NET Conf Mini의 새 이름, .NET L!VE를 소개합니다!
            .NET L!VE는 연중 2회 열리는 닷넷 개발자들을 위한 세미나입니다. 
            닷넷을 사용하는 개발자 분들의 다채롭고 다양한 경험을 공유하기 위하여 만들어졌으며, 
            닷넷 개발자라면 누구나 발표할 수 있고, 닷넷에 관심있는 분들이라면 모두 환영합니다.
            """,
        Date = new DateTime(2023, 5, 18, 13, 0, 0),
        Type = EventType.Offline,
        Venues = VenueCollection.Create(maru180_venue),
        Sponsors = SponsorCollection.Create(infragistics, maru180)
    };

    public ScheduleGrid Schedule => new ScheduleGridBuilder()
        .ForDay(1)
        .AddTrack(main)

        .AddTimeSlot(new TimeOnly(13, 0), 45, slot => slot
            .At(0, communitytoolkit_mvvm))

        .AddTimeSlot(new TimeOnly(13, 50), 45, slot => slot
            .At(0, supabase_maui))

        .AddTimeSlot(new TimeOnly(14, 40), 40, slot => slot
            .At(0, avalonia_wpf))

        .AddTimeSlot(new TimeOnly(15, 25), 45, slot => slot
            .At(0, azure_keyvault))

        .AddTimeSlot(new TimeOnly(16, 15), 40, slot => slot
            .At(0, blazor_hybrid))

        .Build();
}
