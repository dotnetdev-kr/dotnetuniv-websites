using DotNetUniverse.Models;
using DotNetUniverse.Models.Collections;

namespace DotNetUniverse.Services.EventData;

/// <summary>
/// 2022년 9월 .NET Conf Mini 22.09 행사 데이터
/// </summary>
public class Mini2209Data : IEventData
{
    public string Slug => "mini/2209";
    public int Year => 2022;
    public string ThemeColor => "#0d6efd";
    public string ThemeColorClass => "primary";

    #region Speakers

    private readonly Speaker jason_beres = new()
    {
        Id = nameof(jason_beres),
        Name = "Jason Beres",
        Title = "부회장",
        Company = "Infragistics",
        Bio = "Infragistics 부회장 Jason과 그의 팀은 Infragistics의 모든 테스트, 개발자 및 사용자 경험 제품 전반에 걸쳐 고객 중심의 혁신적인 기능을 주도하고 있습니다. 전 Microsoft .NET MVP이며 소프트웨어 개발에 관한 여러 책의 저자입니다.",
        ImageUrl = "/images/speakers/jason_beres_2209.png"
    };

    private readonly Speaker jangwon_jo = new()
    {
        Id = nameof(jangwon_jo),
        Name = "조장원",
        Title = "기술이사",
        Bio = "실버라이트부터 윈도우폰, UWP 까지 건드리는 것마다 수렁에 빠지는 11년차 닷넷 개발자입니다. 현재 예약 플랫폼 스타트업에서 기술 이사로 재직 중에 있으며 주로 자마린 단톡방에서 활동하고 있습니다.",
        ImageUrl = "/images/speakers/jangwon_jo_2209.png"
    };

    private readonly Speaker sangjun_lee = new()
    {
        Id = nameof(sangjun_lee),
        Name = "이상준",
        Title = "개발자",
        Bio = "닷넷데브에서 운영진으로 활동하면서 2022년 GrapeCity MVP로 선정된 .NET Desktop Application 개발자입니다. 현재 .NET의 크로스 플랫폼 기술들을 통해 .NET이 더 이상 Windows 종속이 아니며, 그것을 알리는 것이 주된 관심사입니다.",
        ImageUrl = "/images/speakers/sangjun_lee_2209.jpg"
    };

    private readonly Speaker jaewoong_lee = new()
    {
        Id = nameof(jaewoong_lee),
        Name = "이재웅",
        Title = "개발자",
        Bio = "devncore, Leagueoflegends 등 다수의 GitHub 오픈소스 소유자이며 WPF 프레임워크를 전문적으로 만들고 제공하는 일을 하고 있으며 닷넷데브에서 운영진으로도 활동하고 있습니다.",
        ImageUrl = "/images/speakers/jaewoong_lee_2209.png"
    };

    private readonly Speaker seil_jung = new()
    {
        Id = nameof(seil_jung),
        Name = "정세일 (디모이)",
        Title = "기술이사",
        Bio = "마음인 기술이사 및 신구대 겸임 교수로 일하고 있습니다. 개발자 기술 부문 2022 Microsoft MVP이며 닷넷데브에서 운영진으로도 활동하고 있습니다.",
        ImageUrl = "/images/speakers/seil_jung_2209.png"
    };

    private readonly Speaker hyunmo_ahn = new()
    {
        Id = nameof(hyunmo_ahn),
        Name = "안현모",
        Title = "개발자",
        Bio = "bluepope 라는 닉네임으로 이곳 저곳 활동하고 있으며, 지식공유를 위한 유튜브 활동을 하고 있습니다. ASP.NET Core를 메인으로 하고 있으며, .NET 전반적인 기술 자체에 많은 관심을 갖고 있습니다.",
        ImageUrl = "/images/speakers/hyunmo_ahn_2209.jpg"
    };

    private readonly Speaker jongin_lee = new()
    {
        Id = nameof(jongin_lee),
        Name = "이종인",
        Title = "개발자",
        Bio = "닷넷으로 모든 플랫폼의 앱 그리고 서버 개발을 하고 있는 닷넷을 좋아하는 개발자입니다. Microsoft MVP로도 활동하고 있습니다.",
        ImageUrl = "/images/speakers/jongin_lee_2209.png"
    };

    private readonly Speaker sungsu_kim = new()
    {
        Id = nameof(sungsu_kim),
        Name = "김성수",
        Title = "엔지니어",
        Company = "삼성리서치",
        Bio = "삼성 리서치 플랫폼 팀에서 Tizen 플랫폼과 .NET 프레임워크 개발을 하는 엔지니어로 현재는 .NET MAUI Tizen Backend 개발을 하고 있습니다.",
        ImageUrl = "/images/speakers/sungsu_kim_2209.jpg"
    };

    private readonly Speaker jinyong_choi = new()
    {
        Id = nameof(jinyong_choi),
        Name = "최진용",
        Title = "개발자",
        Company = "CHEQUER",
        Bio = "CHEQUER에서 .NET의 크로스 플랫폼 기술을 사용하여 프록시 서버, 데스크탑 에이전트를 개발하고 있는 .NET을 사랑하는 개발자입니다.",
        ImageUrl = "/images/speakers/jinyong_choi_2209.jpg"
    };

    public SpeakerCollection Speakers => SpeakerCollection.Create(
        jason_beres, jangwon_jo, sangjun_lee, jaewoong_lee, seil_jung,
        hyunmo_ahn, jongin_lee, sungsu_kim, jinyong_choi
    );

    #endregion

    #region Sessions

    private Session keynote_crossplatform => new()
    {
        Id = nameof(keynote_crossplatform),
        Title = ".NET 크로스플랫폼 개발",
        Abstract = """
            이번 Keynote에서는 .NET 개발자들이 플랫폼 간 모바일, 데스크톱 및 웹 응용 프로그램을 빌드하기 위해 사용할 수 있는 옵션에 대해 설명합니다.
            개발 플랫폼과 옵션이 무엇인지 직접 확인하고 거의 모든 플랫폼에서 실행할 수 있는 하이브리드 .NET MAUI 및 ASP.NET Blazor 응용 프로그램을 빌드하는 방법을 단계별로 확인하실 수 있습니다.
            """,
        Speakers = [jason_beres],
        Format = SessionFormat.Keynote,
        Duration = TimeSpan.FromMinutes(37),
        VideoUrl = "https://www.youtube.com/watch?v=x0IPTJOmrE8",
        Tags = [".NET", "크로스플랫폼", "MAUI", "Blazor", "중급"]
    };

    private Session maui_monetization => new()
    {
        Id = nameof(maui_monetization),
        Title = "MAUI로 시작하는 수익형 앱 개발",
        Abstract = "Google Admob과 인앱 결제 등을 사용한 수익형 앱 개발 방법과 준비사항 및 유의사항을 알아봅니다.",
        Speakers = [jangwon_jo],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(49),
        VideoUrl = "https://www.youtube.com/watch?v=fdsTA-3AUtQ",
        Tags = ["MAUI", "Admob", "인앱결제", "중급"]
    };

    private Session gcexcel_linux => new()
    {
        Id = nameof(gcexcel_linux),
        Title = "Azure + Linux + GCExcel = 성공적",
        Abstract = "GCExcel (GrapeCity Excel 라이브러리)를 이용하여 Linux 기반 .NET Application에서 Excel 파일 핸들링하는 방법을 알아보고 퍼포먼스를 비교해봅니다.",
        Speakers = [sangjun_lee],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(20),
        VideoUrl = "https://www.youtube.com/watch?v=bCGr4n66tws",
        Tags = ["GCExcel", "Azure", "Linux", "초급"]
    };

    private Session maui_mac => new()
    {
        Id = nameof(maui_mac),
        Title = "MAC 환경에서 MAUI 앱 만들기",
        Abstract = "MAC 환경에서 Visual Studio를 통해 MAUI 앱을 만들어봅니다. 탭, 리스트, 페이지 이동 등 앱을 구성하는 기본적인 요소들을 구성해봅시다.",
        Speakers = [jaewoong_lee],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(30),
        VideoUrl = "https://www.youtube.com/watch?v=s__skhaAj-c",
        Tags = ["MAUI", "macOS", "중급"]
    };

    private Session raspberrypi_ui => new()
    {
        Id = nameof(raspberrypi_ui),
        Title = ".NET으로 라즈베리파이 UI 앱 만들기",
        Abstract = """
            윈도와 라즈베리파이OS에서 동일한 소스코드로 동작하는 UI 앱을 만들어봅니다.
            .NET 크로스플랫폼 UI 프레임워크들을 간략히 살펴보고 Eto.Forms, Uno, Avalonia UI 프레임워크를 이용해서 라즈베리파이에서 동작하는 UI 앱을 만들고 소개합니다.
            """,
        Speakers = [seil_jung],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(21),
        VideoUrl = "https://www.youtube.com/watch?v=md3Ee5DihbY",
        Tags = ["Raspberry Pi", "크로스플랫폼", "UI", "중급"]
    };

    private Session avalonia_signboard => new()
    {
        Id = nameof(avalonia_signboard),
        Title = "AvaloniaUI + RaspberryPi = 전광판완성",
        Abstract = "Avalonia UI를 이용하여 라즈베리파이4에서 전광판을 개발해봅니다. 산업현장에서 쓰이는 간단한 전광판을 만들어봅니다.",
        Speakers = [sangjun_lee],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(24),
        VideoUrl = "https://www.youtube.com/watch?v=Okw864MxoxI",
        Tags = ["Avalonia UI", "Raspberry Pi", "중급"]
    };

    private Session appbuilder_maui_blazor => new()
    {
        Id = nameof(appbuilder_maui_blazor),
        Title = "Infragistics App Builder를 이용한 .NET MAUI Blazor 앱 만들기",
        Abstract = "Infragistics App Builder를 이용하여 Blazor 앱을 디자인하고, 코드를 복사하여 MAUI Blazor 앱을 만들어봅니다.",
        Speakers = [hyunmo_ahn],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(28),
        VideoUrl = "https://www.youtube.com/watch?v=R2H2jPMWJ10",
        Tags = ["Infragistics", "App Builder", "MAUI", "Blazor", "초급"]
    };

    private Session dotnet6_crossplatform => new()
    {
        Id = nameof(dotnet6_crossplatform),
        Title = ".NET6로 iOS, Android, Web.. 그냥 다 돌아가는 앱 개발하기",
        Abstract = ".NET 6에서 닷넷의 크로스 플랫폼 앱 개발이 어떻게 달라졌는지 알아봅니다. MAUI, Blazor, Uno와 같이 여러 .NET의 크로스플랫폼 개발 기술들을 살펴봅니다.",
        Speakers = [jongin_lee],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(41),
        VideoUrl = "https://www.youtube.com/watch?v=S5-quabOV60",
        Tags = [".NET 6", "크로스플랫폼", "MAUI", "Blazor", "Uno", "중급"]
    };

    private Session maui_tizen => new()
    {
        Id = nameof(maui_tizen),
        Title = ".NET MAUI Application on Tizen RPI",
        Abstract = "Visual Studio 2022에서 .NET MAUI 앱을 만들고 TizenOS RaspberryPi에서 실행해봅니다.",
        Speakers = [sungsu_kim],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(20),
        VideoUrl = "https://www.youtube.com/watch?v=x0IPTJOmrE8",
        Tags = ["MAUI", "Tizen", "Raspberry Pi", "초급"]
    };

    private Session avalonia_service => new()
    {
        Id = nameof(avalonia_service),
        Title = "서비스 가능한 Avalonia 데스크탑 앱 만들기",
        Abstract = """
            Avalonia UI는 아직 서비스를 하기에는 많이 부족한 프레임워크입니다.
            부족한 부분을 어떻게 해결할 수 있는지 알아보고 macOS, Windows, Linux에서 잘 돌아가는 앱을 개발해봅니다.
            Avalonia 데스크탑 앱을 1년간 서비스해본 경험을 공유합니다.
            """,
        Speakers = [jinyong_choi],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(26),
        VideoUrl = "https://www.youtube.com/watch?v=8nSB9oCpxvg",
        Tags = ["Avalonia UI", "Desktop", "고급"]
    };

    #endregion

    #region Sponsors

    private readonly Sponsor nipa = new()
    {
        Id = nameof(nipa),
        Name = "정보통신산업진흥원",
        Tier = SponsorTier.Gold,
        WebsiteUrl = "https://www.nipa.kr/main/index.do",
        LogoUrl = "/images/sponsors/nipa_2209.png"
    };

    private readonly Sponsor grapecity = new()
    {
        Id = nameof(grapecity),
        Name = "그레이프시티 코리아",
        Tier = SponsorTier.Silver,
        WebsiteUrl = "https://www.grapecity.co.kr/",
        LogoUrl = "/images/sponsors/grapecity_2209.png"
    };

    private readonly Sponsor infragistics = new()
    {
        Id = nameof(infragistics),
        Name = "인프라지스틱스",
        Tier = SponsorTier.Silver,
        WebsiteUrl = "https://www.infragistics.co.kr/",
        LogoUrl = "/images/sponsors/infragistics.png"
    };

    #endregion

    #region Tracks

    private Track main => new()
    {
        Id = nameof(main),
        Name = "Main",
        Description = "메인 세션",
        Color = "#0d6efd",
        Sessions = SessionCollection.Create(
            keynote_crossplatform, maui_monetization, gcexcel_linux, maui_mac,
            raspberrypi_ui, avalonia_signboard, appbuilder_maui_blazor,
            dotnet6_crossplatform, maui_tizen, avalonia_service
        )
    };

    #endregion

    #region Venue

    private VenueInfo online => new()
    {
        Id = nameof(online),
        Name = "유튜브 프리미어 (닷넷데브 YouTube 채널)",
        Address = "온라인",
        Tracks = TrackCollection.Create(main)
    };

    #endregion

    public EventInfo Event => new()
    {
        Slug = Slug,
        Year = 2022,
        Title = ".NET Conf Mini 22.09",
        Scale = EventScale.Meetup,
        Theme = "닷넷으로 시작하는 크로스플랫폼 앱 개발",
        Description = """
            .NET Conf Mini는 비정기적으로 열리는 닷넷 개발자들을 위한 세미나입니다.
            닷넷을 사용하는 개발자 분들의 다채롭고 다양한 경험을 공유하기 위하여 만들어졌으며,
            닷넷 개발자라면 누구나 발표할 수 있고, 닷넷에 관심있는 분들이라면 모두 환영합니다.
            .NET Conf Mini 22.09는 '닷넷으로 시작하는 크로스플랫폼 앱 개발'을 주제로 행사를 진행합니다.
            """,
        Date = new DateTime(2022, 9, 30, 13, 0, 0),
        Type = EventType.Online,
        TrailerUrl = "https://www.youtube.com/watch?v=Z6Z3qgHYaOg",
        Venues = VenueCollection.Create(online),
        Sponsors = SponsorCollection.Create(nipa, grapecity, infragistics)
    };

    public ScheduleGrid Schedule => new ScheduleGridBuilder()
        .ForDay(1)
        .AddTrack(main)

        .AddTimeSlot(new TimeOnly(13, 0), 37, slot => slot
            .At(0, keynote_crossplatform))

        .AddTimeSlot(new TimeOnly(13, 45), 49, slot => slot
            .At(0, maui_monetization))

        .AddTimeSlot(new TimeOnly(14, 40), 20, slot => slot
            .At(0, gcexcel_linux))

        .AddTimeSlot(new TimeOnly(15, 5), 30, slot => slot
            .At(0, maui_mac))

        .AddTimeSlot(new TimeOnly(15, 40), 21, slot => slot
            .At(0, raspberrypi_ui))

        .AddTimeSlot(new TimeOnly(16, 5), 24, slot => slot
            .At(0, avalonia_signboard))

        .AddTimeSlot(new TimeOnly(16, 35), 28, slot => slot
            .At(0, appbuilder_maui_blazor))

        .AddTimeSlot(new TimeOnly(17, 10), 41, slot => slot
            .At(0, dotnet6_crossplatform))

        .AddTimeSlot(new TimeOnly(17, 55), 20, slot => slot
            .At(0, maui_tizen))

        .AddTimeSlot(new TimeOnly(18, 20), 26, slot => slot
            .At(0, avalonia_service))

        .Build();
}
