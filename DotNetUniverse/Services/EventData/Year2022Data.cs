using DotNetUniverse.Models;
using DotNetUniverse.Models.Collections;

namespace DotNetUniverse.Services.EventData;

/// <summary>
/// 2022년 행사 데이터 - .NET Conf 2022 x Seoul
/// </summary>
public class Year2022Data : IEventData
{
    public string Slug => "2022";
    public int Year => 2022;
    public string ThemeColor => "#512bd4";
    public string ThemeColorClass => "primary";

    #region Speakers

    private readonly Speaker jungwoo_kim = new()
    {
        Id = nameof(jungwoo_kim),
        Name = "김정우",
        Title = "DevOps 엔지니어",
        Company = "클라우드메이트",
        Bio = "클라우드메이트 DevOps 엔지니어. 관심 분야: CNCF, C#, Dependency Injection, MSA, Database HA",
        ImageUrl = "/images/speakers/jungwoo_kim.jpg"
    };

    private readonly Speaker yohan_ko = new()
    {
        Id = nameof(yohan_ko),
        Name = "고요한",
        Title = "개발자",
        Bio = "정규표현식과 C#을 활용한 텍스트 처리 전문가입니다.",
        ImageUrl = "/images/speakers/yohan_ko.webp"
    };

    private readonly Speaker sungwon_moon = new()
    {
        Id = nameof(sungwon_moon),
        Name = "문성원",
        Title = "프로그래머",
        Bio = "게임을 위한 블록체인 라이브러리를 C#/.NET으로 만들고 있습니다.",
        ImageUrl = "/images/speakers/sungwon_moon.webp"
    };

    private readonly Speaker jongin_lee = new()
    {
        Id = nameof(jongin_lee),
        Name = "이종인",
        Title = "Microsoft MVP",
        Company = "DesignMe AI",
        Bio = ".NET은 iOS 앱부터 ML.NET에 이르기까지 모든 곳에 갈 수 있습니다. Xamarin, Uno, MAUI 같은 .NET 크로스 플랫폼 앱 개발 전문가.",
        ImageUrl = "/images/speakers/jongin_lee.webp"
    };

    private readonly Speaker sunghyun_min = new()
    {
        Id = nameof(sunghyun_min),
        Name = "민성현",
        Title = "모바일 개발자",
        Bio = ".NET MAUI와 크로스플랫폼 모바일 개발에 대한 깊은 지식을 보유하고 있습니다."
    };

    private readonly Speaker sangman_park = new()
    {
        Id = nameof(sangman_park),
        Name = "박상만",
        Title = "개발팀본부장",
        Company = "루나소프트",
        Bio = "루나소프트 개발팀본부장. AKKA를 DDD와 접목한 메시징 중심의 웹서비스 설계에 관심이 있으며 닷넷코어 저변확대에도 노력을 하고 있습니다.",
        ImageUrl = "/images/speakers/sangman_park.png"
    };

    private readonly Speaker greg_lutz = new()
    {
        Id = nameof(greg_lutz),
        Name = "Greg Lutz",
        Title = "Global Product Manager of ComponentOne",
        Company = "GrapeCity",
        Bio = "GrapeCity에서 ComponentOne의 Global Product Manager로 일하고 있습니다.",
        ImageUrl = "/images/speakers/greg_lutz.jpg"
    };

    private readonly Speaker yegun_kim = new()
    {
        Id = nameof(yegun_kim),
        Name = "김예건",
        Title = "웹 개발자",
        Bio = "Blazor WebAssembly와 프론트엔드 기술 통합에 전문성을 가지고 있습니다."
    };

    private readonly Speaker jungsu_kim = new()
    {
        Id = nameof(jungsu_kim),
        Name = "김정수",
        Title = "개발자",
        Bio = "Entity Framework Core와 데이터베이스 마이그레이션 작업에 전문성을 보유하고 있습니다."
    };

    private readonly Speaker youngsun_choi = new()
    {
        Id = nameof(youngsun_choi),
        Name = "최영선",
        Title = "개발자",
        Bio = "Azure 모니터링 및 Application Insights를 활용한 애플리케이션 관측 전문가입니다."
    };

    private readonly Speaker junghyun_nam = new()
    {
        Id = nameof(junghyun_nam),
        Name = "남정현",
        Title = "DevOps 엔지니어",
        Company = "데브시스터즈",
        Bio = "데브시스터즈 DevOps 엔지니어. Microsoft Azure MVP (2009~). 닷넷데브, 한국 WSL 사용자 그룹 운영진 활동.",
        ImageUrl = "/images/speakers/junghyun_nam.webp"
    };

    private readonly Speaker seil_jung = new()
    {
        Id = nameof(seil_jung),
        Name = "정세일",
        Title = "Chief Technology Officer",
        Company = "MAUMIN Co.,Ltd.",
        Bio = "MAUMIN Co.,Ltd. CTO. 라즈베리파이 및 .NET을 이용한 볼링시스템 구축 경험 보유. WinUI 3 및 Windows 앱 개발 전문가.",
        ImageUrl = "/images/speakers/seil_jung.jpg"
    };

    private readonly Speaker gusam_park = new()
    {
        Id = nameof(gusam_park),
        Name = "박구삼",
        Title = "모바일 개발자",
        Bio = ".NET MAUI 기술과 Xamarin에서 MAUI로의 마이그레이션에 대한 전문성을 가지고 있습니다."
    };

    private readonly Speaker jason_beres = new()
    {
        Id = nameof(jason_beres),
        Name = "Jason Beres",
        Title = "Senior Vice President",
        Company = "Infragistics",
        Bio = "Infragistics에서 Senior Vice President로 일하고 있습니다. 혁신적이면서도 고객 중심의 사용자 경험을 다양한 플랫폼에 반영하는 것을 목표로 합니다.",
        ImageUrl = "/images/speakers/jason_beres.webp"
    };

    private readonly Speaker eunchan_lee = new()
    {
        Id = nameof(eunchan_lee),
        Name = "이은찬",
        Title = "개발자",
        Bio = "Go, Spring, Node 등 다양한 언어와 프레임워크 경험을 바탕으로 .NET 6를 비교 분석합니다."
    };

    private readonly Speaker sanghyun_kim = new()
    {
        Id = nameof(sanghyun_kim),
        Name = "김상현",
        Title = "솔루션즈 아키텍트",
        Company = "Saiage Research",
        Bio = "Saiage Research에서 솔루션즈 아키텍트로 일하고 있습니다. 닷넷 기술에 관심이 많으며 마이크로서비스 아키텍처 전문가입니다.",
        ImageUrl = "/images/speakers/sanghyun_kim.jpg"
    };

    private readonly Speaker justin_yoo = new()
    {
        Id = nameof(justin_yoo),
        Name = "유 저스틴",
        Title = "클라우드 아보카도",
        Company = "Microsoft",
        Bio = "Microsoft에서 클라우드 아보카도로 일하고 있습니다. 닷넷을 중심으로 애저 클라우드, 서버리스, 메시징 등 엔터프라이즈 애플리케이션 통합 솔루션을 구현하는데 관심이 많습니다.",
        ImageUrl = "/images/speakers/justin_yoo.png"
    };

    public SpeakerCollection Speakers => SpeakerCollection.Create(
        jungwoo_kim, yohan_ko, sungwon_moon, jongin_lee, sunghyun_min,
        sangman_park, greg_lutz, yegun_kim, jungsu_kim, youngsun_choi,
        junghyun_nam, seil_jung, gusam_park, jason_beres, eunchan_lee,
        sanghyun_kim, justin_yoo
    );

    #endregion

    #region Sessions - Day 1

    private Session orm_compare => new()
    {
        Id = nameof(orm_compare),
        Title = "ORM의 특성을 비교해보자",
        Abstract = "다양한 ORM 프레임워크의 특성과 장단점을 비교하고, 적절한 사용 시나리오를 다룹니다.",
        Speakers = [jungwoo_kim],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        VideoUrl = "https://www.youtube.com/watch?v=I9fKlY2VMpI",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/raw/main/2022/dotNETConf/11_NetConf2022_%EA%B9%80%EC%A0%95%EC%9A%B0_ORM%EC%9D%98_%ED%8A%B9%EC%84%B1%EC%9D%84_%EB%B9%84%EA%B5%90%ED%95%B4%EB%B3%B4%EC%9E%90.pdf",
        Tags = ["ORM", "Entity Framework", "Dapper"]
    };

    private Session regex_csharp => new()
    {
        Id = nameof(regex_csharp),
        Title = "C#으로 하는 정규표현식",
        Abstract = "C#에서 정규표현식을 효과적으로 활용하는 방법과 실용적인 예제를 다룹니다.",
        Speakers = [yohan_ko],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        VideoUrl = "https://www.youtube.com/watch?v=2qT2sVpdTEA",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/raw/main/2022/dotNETConf/10_dotnetconf2022-deck-template-korean_정규표현식.pdf",
        Tags = ["정규표현식", "Regex", "C#"]
    };

    private Session dotnet6_migration => new()
    {
        Id = nameof(dotnet6_migration),
        Title = ".NET 6 전환기",
        Abstract = "기존 프로젝트를 .NET 6로 전환하면서 겪은 경험과 노하우를 공유합니다.",
        Speakers = [sungwon_moon],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        VideoUrl = "https://www.youtube.com/watch?v=SByPYYtGWvo",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/raw/main/2022/dotNETConf/12_dotnetconf2022-swenmun.pdf",
        Tags = [".NET 6", "마이그레이션", "LTS"]
    };

    private Session minimal_api => new()
    {
        Id = nameof(minimal_api),
        Title = "미니멀하게 만드는 API 서버: .NET 6 Minimal API",
        Abstract = """
            ASP.NET Core의 Minimal API를 활용한 간결하고 빠른 API 개발 방법을 배웁니다.
            기존 Controller 기반 API와의 비교 및 적절한 사용 시나리오를 다룹니다.
            """,
        Speakers = [jongin_lee],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        VideoUrl = "https://www.youtube.com/watch?v=7Gqnw1R_nZc",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/raw/main/2022/dotNETConf/18_Minimal_API.pdf",
        Tags = ["Minimal API", "ASP.NET Core", "Web API"]
    };

    private Session blazor_graphic_chat => new()
    {
        Id = nameof(blazor_graphic_chat),
        Title = "Blazor를 활용한 그래픽 웹 채팅",
        Abstract = "Blazor를 사용하여 실시간 그래픽 웹 채팅 애플리케이션을 개발하는 방법을 소개합니다.",
        Speakers = [sangman_park],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        VideoUrl = "https://www.youtube.com/watch?v=yt64Tn5uMe0",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/raw/main/2022/dotNETConf/16_dotnetconf2022-%EA%B7%B8%EB%9E%98%ED%94%BD%EC%9B%B9%EC%B1%84%ED%8C%85-%EB%B0%95%EC%83%81%EB%A7%8C.pdf",
        Tags = ["Blazor", "WebSocket", "실시간"]
    };

    private Session blazor_wasm_webpack => new()
    {
        Id = nameof(blazor_wasm_webpack),
        Title = "Blazor WebAssembly + Webpack + Sass + TypeScript",
        Abstract = "Blazor WebAssembly와 프론트엔드 빌드 도구들을 통합하여 현대적인 웹 개발 환경을 구축하는 방법을 다룹니다.",
        Speakers = [yegun_kim],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        VideoUrl = "https://www.youtube.com/watch?v=qt1TWAHM01E",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/raw/main/2022/dotNETConf/14_dotnetconf2022-YegunKim.pdf",
        Tags = ["Blazor WebAssembly", "Webpack", "Sass", "TypeScript"]
    };

    private Session efcore_migration => new()
    {
        Id = nameof(efcore_migration),
        Title = "개별 Project에서 EFCore Migration 작업하기",
        Abstract = "개별 프로젝트에서 Entity Framework Core Migration을 효과적으로 관리하는 방법을 소개합니다.",
        Speakers = [jungsu_kim],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        VideoUrl = "https://www.youtube.com/watch?v=mhDFjiR_jTw",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/raw/main/2022/dotNETConf/15_Conf2022-%EA%B9%80%EC%A0%95%EC%88%98.pdf",
        Tags = ["Entity Framework Core", "Migration", "데이터베이스"]
    };

    private Session blazor_infragistics => new()
    {
        Id = nameof(blazor_infragistics),
        Title = "Blazor로 앱 개발 가속화 (Infragistics)",
        Abstract = "Infragistics 컴포넌트를 활용하여 Blazor 애플리케이션 개발을 가속화하는 방법을 소개합니다.",
        Speakers = [jason_beres],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        VideoUrl = "https://www.youtube.com/watch?v=EbXDd7Jd-0k",
        Tags = ["Blazor", "Infragistics", "UI 컴포넌트"],
        Notes = ["스폰서 세션, 영어"]
    };

    private Session dotnet6_from_other_devs => new()
    {
        Id = nameof(dotnet6_from_other_devs),
        Title = "Go, Spring, Node 개발자가 본 .NET 6",
        Abstract = "다른 언어와 프레임워크 경험을 가진 개발자의 시각에서 .NET 6를 분석하고 비교합니다.",
        Speakers = [eunchan_lee],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        VideoUrl = "https://www.youtube.com/watch?v=ZmIFXWB70Ac",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/raw/main/2022/dotNETConf/17_dotnetconf2022.pdf",
        Tags = [".NET 6", "Go", "Spring", "Node.js"]
    };

    private Session azure_app_insights => new()
    {
        Id = nameof(azure_app_insights),
        Title = "Azure Application Insight를 이용한 ASP.NET Core 모니터링",
        Abstract = "Azure Application Insights를 활용하여 ASP.NET Core 애플리케이션을 효과적으로 모니터링하는 방법을 다룹니다.",
        Speakers = [youngsun_choi],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        VideoUrl = "https://www.youtube.com/watch?v=SS2TLFOCM4A",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/raw/main/2022/dotNETConf/19_dotnetconf2022-%EC%B5%9C%EC%98%81%EC%84%A0.pdf",
        Tags = ["Azure", "Application Insights", "모니터링", "ASP.NET Core"]
    };

    #endregion

    #region Sessions - Day 2

    private Session maui_intro => new()
    {
        Id = nameof(maui_intro),
        Title = ".NET MAUI 소개",
        Abstract = ".NET MAUI의 핵심 기능과 크로스플랫폼 모바일 앱 개발 방법을 소개합니다.",
        Speakers = [sunghyun_min],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        VideoUrl = "https://www.youtube.com/watch?v=enzj7XMI1o4",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/raw/main/2022/dotNETConf/22_netconf2021seoul_%EB%B0%9C%ED%91%9C%EC%9E%90%EB%A3%8C_%EB%AF%BC%EC%84%B1%ED%98%84.pdf",
        Tags = [".NET MAUI", "모바일", "크로스플랫폼"]
    };

    private Session dotnet6_desktop_uiux => new()
    {
        Id = nameof(dotnet6_desktop_uiux),
        Title = "당신이 알아야 할 .NET 6와 프로페셔널 데스크톱 애플리케이션 UI/UX의 모든 것",
        Abstract = ".NET 6를 활용한 프로페셔널 데스크톱 애플리케이션의 UI/UX 디자인 베스트 프랙티스를 소개합니다.",
        Speakers = [greg_lutz],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        VideoUrl = "https://www.youtube.com/watch?v=yJJ78G_OP80",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/raw/main/2022/dotNETConf/20_%5BGrapeCity%5D.NET6_Webinar_by.GregLutz.pdf",
        Tags = [".NET 6", "데스크톱", "UI/UX"],
        Notes = ["스폰서 세션, 영어"]
    };

    private Session tablecloth => new()
    {
        Id = nameof(tablecloth),
        Title = "인터넷 뱅킹에 자유를! 식탁보 프로젝트 이야기",
        Abstract = "식탁보 프로젝트의 개발 배경과 .NET을 활용한 구현 과정을 소개합니다.",
        Speakers = [junghyun_nam],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        VideoUrl = "https://www.youtube.com/watch?v=zlCWvPE22e4",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/raw/main/2022/dotNETConf/21_%EB%B0%9C%ED%91%9C1-%EC%8B%9D%ED%83%81%EB%B3%B4.pdf",
        Tags = ["식탁보", "인터넷 뱅킹", "Windows"]
    };

    private Session maui_vs_xamarin => new()
    {
        Id = nameof(maui_vs_xamarin),
        Title = ".NET 6에서 도입 예정인 MAUI 기술 소개 및 Xamarin과의 차이점 알아보기",
        Abstract = ".NET MAUI와 Xamarin.Forms의 차이점을 비교하고 마이그레이션 전략을 다룹니다.",
        Speakers = [gusam_park],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        VideoUrl = "https://www.youtube.com/watch?v=eXcdQ9KzfoQ",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/raw/main/2022/dotNETConf/22_netconf2021seoul_%EB%B0%9C%ED%91%9C%EC%9E%90%EB%A3%8C_%EB%AF%BC%EC%84%B1%ED%98%84.pdf",
        Tags = [".NET MAUI", "Xamarin", "마이그레이션"]
    };

    private Session uno_platform => new()
    {
        Id = nameof(uno_platform),
        Title = "WinUI로 iOS, Android, 심지어 웹 앱까지 개발할 수 있다고? Uno Platform 소개",
        Abstract = "Uno Platform을 활용하여 WinUI 기반으로 다양한 플랫폼용 앱을 개발하는 방법을 소개합니다.",
        Speakers = [jongin_lee],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        VideoUrl = "https://www.youtube.com/watch?v=wRAE_ppi0jw",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/raw/main/2022/dotNETConf/24_Uno_Platform.pdf",
        Tags = ["Uno Platform", "WinUI", "크로스플랫폼"]
    };

    private Session winui3_recorder => new()
    {
        Id = nameof(winui3_recorder),
        Title = "WinUI 3로 녹음기를 만들어보자 (feat. Win2D)",
        Abstract = "WinUI 3와 Win2D를 활용하여 녹음기 애플리케이션을 개발하는 과정을 소개합니다.",
        Speakers = [seil_jung],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        VideoUrl = "https://www.youtube.com/watch?v=zAD43bE7AHw",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/raw/main/2022/dotNETConf/25_WinUI3%EB%A1%9C%EB%85%B9%EC%9D%8C%EA%B8%B0%EB%A5%BC%EB%A7%8C%EB%93%A4%EC%96%B4%EB%B3%B4%EC%9E%90_%EC%A0%95%EC%84%B8%EC%9D%BC.pdf",
        Tags = ["WinUI 3", "Win2D", "Windows 앱"]
    };

    private Session dapr => new()
    {
        Id = nameof(dapr),
        Title = "마이크로서비스에서도 정신건강 챙길 수 있어! Dapr!",
        Abstract = "Dapr을 활용하여 마이크로서비스 개발의 복잡성을 줄이고 개발자 생산성을 높이는 방법을 소개합니다.",
        Speakers = [sanghyun_kim],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        VideoUrl = "https://www.youtube.com/watch?v=1GC6UzXbAk0",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/raw/main/2022/dotNETConf/26_dotnetconf2022-sh.kim.pdf",
        Tags = ["Dapr", "마이크로서비스", "클라우드 네이티브"]
    };

    private Session modern_stateless => new()
    {
        Id = nameof(modern_stateless),
        Title = "IIS/ASP.NET과 Azure로 시작하는 모던 Stateless 서비스 개발",
        Abstract = "IIS/ASP.NET과 Azure를 활용한 현대적인 Stateless 서비스 개발 방법을 소개합니다.",
        Speakers = [junghyun_nam],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        VideoUrl = "https://www.youtube.com/watch?v=8wOa0zmtUA0",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/raw/main/2022/dotNETConf/27_%EB%B0%9C%ED%91%9C2-%EB%AA%A8%EB%8D%98_IIS_ASPX.pdf",
        Tags = ["IIS", "ASP.NET", "Azure", "Stateless"]
    };

    private Session azure_functions_openapi => new()
    {
        Id = nameof(azure_functions_openapi),
        Title = "신상! 닷넷 6를 위한 애저 펑션 OpenAPI 확장 기능 소개",
        Abstract = ".NET 6용 Azure Functions OpenAPI 확장 기능의 새로운 기능들을 소개합니다.",
        Speakers = [justin_yoo],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        VideoUrl = "https://www.youtube.com/watch?v=2azUDp63ANs",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/raw/main/2022/dotNETConf/28_JustinYoo.DotNetConfKorea.2022.pdf",
        Tags = ["Azure Functions", "OpenAPI", "서버리스"]
    };

    #endregion

    #region Tracks

    private Track main => new()
    {
        Id = nameof(main),
        Name = "메인 트랙",
        Color = "#512bd4",
        Sessions = SessionCollection.Create(
            orm_compare, regex_csharp, dotnet6_migration, minimal_api, blazor_graphic_chat,
            blazor_wasm_webpack, efcore_migration, blazor_infragistics, dotnet6_from_other_devs, azure_app_insights,
            maui_intro, dotnet6_desktop_uiux, tablecloth, maui_vs_xamarin, uno_platform,
            winui3_recorder, dapr, modern_stateless, azure_functions_openapi
        )
    };

    #endregion

    #region Sponsors

    private readonly Sponsor microsoft = new()
    {
        Id = nameof(microsoft),
        Name = "Microsoft Korea",
        Tier = SponsorTier.Platinum,
        WebsiteUrl = "https://www.microsoft.com/ko-kr",
        LogoUrl = "/images/sponsors/microsoft.webp"
    };

    private readonly Sponsor infragistics = new()
    {
        Id = nameof(infragistics),
        Name = "Infragistics",
        Tier = SponsorTier.Gold,
        WebsiteUrl = "https://www.infragistics.com/",
        LogoUrl = "/images/sponsors/infragistics.webp"
    };

    private readonly Sponsor grapecity = new()
    {
        Id = nameof(grapecity),
        Name = "Grapecity Korea",
        Tier = SponsorTier.Gold,
        WebsiteUrl = "https://www.grapecity.co.kr/",
        LogoUrl = "/images/sponsors/2021/grapecity.png"
    };

    private readonly Sponsor jetbrains = new()
    {
        Id = nameof(jetbrains),
        Name = "JetBrains",
        Tier = SponsorTier.Silver,
        WebsiteUrl = "https://www.jetbrains.com/",
        LogoUrl = "/images/sponsors/jetbrains.webp"
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
        Title = ".NET Conf 2022 x Seoul",
        Theme = ".NET 6 LTS와 함께하는 엔터프라이즈",
        Description = """
            .NET 6 LTS 출시와 함께 온라인으로 개최된 .NET Conf 2022 x Seoul입니다.
            .NET 6의 새로운 기능들과 MAUI, Blazor, Azure 등 다양한 주제로 19개의 세션이 진행되었습니다.
            """,
        Date = new DateTime(2022, 1, 20, 10, 0, 0),
        Type = EventType.Online,
        AttendeeCount = 400,
        HeroImageUrl = "/images/events/2022-hero.webp",
        Venues = VenueCollection.Create(online),
        Sponsors = SponsorCollection.Create(microsoft, infragistics, grapecity, jetbrains)
    };

    public ScheduleGrid Schedule => new ScheduleGridBuilder()
        .ForDay(1)
        .AddTrack(main)

        // Day 1
        .AddTimeSlot(new TimeOnly(10, 0), 40, slot => slot
            .At(0, orm_compare))
        .AddTimeSlot(new TimeOnly(10, 40), 40, slot => slot
            .At(0, regex_csharp))
        .AddTimeSlot(new TimeOnly(11, 20), 40, slot => slot
            .At(0, dotnet6_migration))
        .AddTimeSlot(new TimeOnly(12, 0), 40, slot => slot
            .At(0, minimal_api))
        .AddTimeSlot(new TimeOnly(13, 0), 40, slot => slot
            .At(0, blazor_graphic_chat))
        .AddTimeSlot(new TimeOnly(13, 40), 40, slot => slot
            .At(0, blazor_wasm_webpack))
        .AddTimeSlot(new TimeOnly(14, 20), 40, slot => slot
            .At(0, efcore_migration))
        .AddTimeSlot(new TimeOnly(15, 0), 40, slot => slot
            .At(0, blazor_infragistics))
        .AddTimeSlot(new TimeOnly(15, 40), 40, slot => slot
            .At(0, dotnet6_from_other_devs))
        .AddTimeSlot(new TimeOnly(16, 20), 40, slot => slot
            .At(0, azure_app_insights))

        .ForDay(2)
        .AddTrack(main)

        // Day 2
        .AddTimeSlot(new TimeOnly(10, 0), 40, slot => slot
            .At(0, maui_intro))
        .AddTimeSlot(new TimeOnly(10, 40), 40, slot => slot
            .At(0, dotnet6_desktop_uiux))
        .AddTimeSlot(new TimeOnly(11, 20), 40, slot => slot
            .At(0, tablecloth))
        .AddTimeSlot(new TimeOnly(12, 0), 40, slot => slot
            .At(0, maui_vs_xamarin))
        .AddTimeSlot(new TimeOnly(13, 0), 40, slot => slot
            .At(0, uno_platform))
        .AddTimeSlot(new TimeOnly(13, 40), 40, slot => slot
            .At(0, winui3_recorder))
        .AddTimeSlot(new TimeOnly(14, 20), 40, slot => slot
            .At(0, dapr))
        .AddTimeSlot(new TimeOnly(15, 0), 40, slot => slot
            .At(0, modern_stateless))
        .AddTimeSlot(new TimeOnly(15, 40), 40, slot => slot
            .At(0, azure_functions_openapi))

        .Build();
}
