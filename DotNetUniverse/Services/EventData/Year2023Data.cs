using DotNetUniverse.Models;
using DotNetUniverse.Models.Collections;

namespace DotNetUniverse.Services.EventData;

/// <summary>
/// 2023년 행사 데이터 (.NET Conf 2023 x Seoul)
/// </summary>
public class Year2023Data : IEventData
{
    public string Slug => "2023";
    public int Year => 2023;
    public string ThemeColor => "#0d6efd";
    public string ThemeColorClass => "primary";

    #region Speakers

    // Keynote
    private readonly Speaker lee_gunbok = new()
    {
        Id = nameof(lee_gunbok),
        Name = "이건복",
        Title = "Cloud Architect",
        Company = "Microsoft",
        Bio = "마이크로소프트 IoT솔루션 사업부에서 일하고 있습니다. SI 회사에서 호스트 프로그램 개발자로 시작해 마이크로소프트에서 VB/COM/DCOM 기술엔지니어, 모바일 프로그램 매니저로 활동했습니다. 현재는 클라우드 아키텍트로 한국과 호주 지역 IoT 솔루션 개발을 지원하고 있습니다.",
        ImageUrl = "/images/speakers/lee_gunbok.png"
    };

    // Breakout 1/2/3
    private readonly Speaker park_junghoon = new()
    {
        Id = nameof(park_junghoon),
        Name = "박정훈",
        Title = "방문 엔지니어",
        Company = "Microsoft",
        Bio = "Microsoft 개발 지원 방문엔지니어 입니다. Azure Kubernetes Service, Azure App Service, Azure DevOps, .NET 기술 엔지니어로 일하고 있습니다.",
        ImageUrl = "/images/speakers/park_junghoon.jpg"
    };

    private readonly Speaker motoki_nakae = new()
    {
        Id = nameof(motoki_nakae),
        Name = "Motoki Nakae",
        Title = "Solution Consultant",
        Company = "Infragistics",
        Bio = "인프라지스틱스의 솔루션 컨설턴트 이자 수석 엔지니어 및 프로젝트 관리자로서 글로벌 비즈니스에서 7년 이상의 경험을 가진 숙련된 소프트웨어 개발자입니다.",
        ImageUrl = "/images/speakers/motoki_nakae.png"
    };

    private readonly Speaker lee_suho = new()
    {
        Id = nameof(lee_suho),
        Name = "이수호",
        Title = "Core Engine Engineer",
        Company = "플라네타리움",
        Bio = "플라네타리움 랩스에서 블록체인 디비전 소속 코어 엔진 팀에서 엔지니어로 블록체인 코어 엔진을 만들고 있습니다. 주로 Layer 4-7 위에서의 일이나, 분산 네트워크 간의 합의 알고리즘을 C#으로 구현하는 일을 하고 있습니다.",
        ImageUrl = "/images/speakers/lee_suho.png"
    };

    // Breakout 4/5/6
    private readonly Speaker nam_jeonghyun = new()
    {
        Id = nameof(nam_jeonghyun),
        Name = "남정현",
        Title = "Technical Writer",
        Company = "데브시스터즈",
        Bio = "2009년부터 Microsoft MVP로 활동하면서 닷넷 기반 프로그래밍 기술을 알리고, 개발자 커뮤니티에 기여하는 활동을 지속하고 있습니다. 최근에는 데브시스터즈에서 테크니컬 라이터로 재직하며 소프트웨어 프로젝트의 문서화, 다국어 번역에 관련된 업무를 주로 담당하고 있습니다.",
        ImageUrl = "/images/speakers/nam_jeonghyun.png"
    };

    private readonly Speaker han_jaejun = new()
    {
        Id = nameof(han_jaejun),
        Name = "한재준",
        Title = "개발팀장",
        Company = "크레비스파트너스",
        Bio = "크레비스파트너스의 기술사업 본부인 브릭투웍스 개발팀에서 개발팀장으로 일하고 있습니다. Azure 클라우드, .NET 기술을 활용하여 국내 최대 SaaS 모금 솔루션인 도너스(Donus)를 개발하고 있습니다.",
        ImageUrl = "/images/speakers/han_jaejun.jpg"
    };

    private readonly Speaker kang_younjung = new()
    {
        Id = nameof(kang_younjung),
        Name = "강연정",
        Title = "Customer Success Engineer",
        Company = "랭코드",
        Bio = "대화형 AI 솔루션으로 비즈니스 혁신을 가속화하는 스타트업 랭코드에서 Customer Success Engineer로 일하고 있습니다. WWCode Seoul의 운영진, Google WomenTechMakers Ambassador로 활동하며 IT 커뮤니티 활성화에 기여하고 있습니다.",
        ImageUrl = "/images/speakers/kang_younjung.jpg"
    };

    // Breakout 7/8/9
    private readonly Speaker cho_junghyun = new()
    {
        Id = nameof(cho_junghyun),
        Name = "조중현",
        Title = ".NET Developer",
        Company = "Samsung Research",
        Bio = "Samsung Research의 Tizen .NET팀 개발자 입니다. Tizen에서 Xamarin.Forms를 거쳐 MAUI 및 .NET6 환경 지원하는 일을 하고 있습니다. 현재는 Maui Community Toolkit의 Core Maintainer로 활동하고 있습니다.",
        ImageUrl = "/images/speakers/cho_junghyun.jpg"
    };

    private readonly Speaker mats_lundell = new()
    {
        Id = nameof(mats_lundell),
        Name = "Mats Lundell-Nygjelten",
        Title = "Lead Architect",
        Company = "Fishwell Technology",
        Bio = "Full stack Azure developer by heart. Evolved into a software architect and are today working as the lead architect for a Norwegian startup called Fishwell Technology.",
        ImageUrl = "/images/speakers/mats_lundell.jpeg"
    };

    private readonly Speaker kim_juho = new()
    {
        Id = nameof(kim_juho),
        Name = "김주호",
        Title = "Frontend Developer",
        Company = "",
        Bio = "3년차 프론트엔드 개발자이며 .NET과 F# 프로그래밍 언어에 관심이 많으며, 개발자가 덜 일하고 지속 가능하게 활동할 수 있는 기술을 찾고 있습니다.",
        ImageUrl = "/images/speakers/kim_juho.jpg"
    };

    // Breakout 10/11/12
    private readonly Speaker park_moonchan = new()
    {
        Id = nameof(park_moonchan),
        Name = "박문찬",
        Title = "수석연구원",
        Company = "Yrism",
        Bio = "Yrism 수석연구원, Windows Development MVP, Future Of DotNet 블로그, YouTube 채널 운영, 닷넷 프로그래머 모임 운영자로 활동하고 있습니다.",
        ImageUrl = "/images/speakers/park_moonchan.jpg"
    };

    private readonly Speaker oh_minseok = new()
    {
        Id = nameof(oh_minseok),
        Name = "오민석",
        Title = "Platform Engineer",
        Company = "쿼리파이",
        Bio = "데이터 거버넌스 솔루션인 쿼리파이를 개발하는 체커의 플랫폼 팀에 근무 중입니다. 현재 플랫폼팀에서는 .NET 6을 사용하고 있습니다.",
        ImageUrl = "/images/speakers/oh_minseok.jpg"
    };

    private readonly Speaker lee_jongin = new()
    {
        Id = nameof(lee_jongin),
        Name = "이종인",
        Title = "Microsoft MVP",
        Company = "DesignMe.ai",
        Bio = "거의 모든 것을 개발해낼 수 있는 닷넷을 좋아하는 개발자 입니다. Microsoft Developer Technologies MVP로 활동하고 있습니다.",
        ImageUrl = "/images/speakers/lee_jongin.jpg"
    };

    // Hands-on-Lab
    private readonly Speaker lee_sangjun = new()
    {
        Id = nameof(lee_sangjun),
        Name = "이상준",
        Title = "Developer",
        Company = "엔픽셀",
        Bio = "주로 Microsoft 데스크톱 애플리케이션 개발 스택을 사용하며 .NET 개발자 커뮤니티에서 .NET 관련 전문 블로그 작성 및 세미나를 통해 활발하게 활동 중입니다. GrapeCity의 MVP로서 개발자분들이 컴포넌트 제품을 활용하여 쉬운 개발을 할 수 있도록 도움을 주고 있습니다.",
        ImageUrl = "/images/speakers/lee_sangjun.jpg"
    };

    private readonly Speaker justin_yoo = new()
    {
        Id = nameof(justin_yoo),
        Name = "Justin Yoo",
        Title = "Cloud Advocate",
        Company = "Microsoft",
        Bio = "마이크로소프트에서 Cloud Advocate로 일하고 있습니다. 주로 .NET, 애저 클라우드, 파워 플랫폼 등을 이용해 모든 개발자/비개발자의 생산성 향상에 도움이 될 수 있는 방법을 찾는데 진심입니다.",
        ImageUrl = "/images/speakers/justin_yoo.png"
    };

    private readonly Speaker choi_heungbae = new()
    {
        Id = nameof(choi_heungbae),
        Name = "최흥배",
        Title = "Microsoft MVP",
        Company = "COM2US",
        Bio = "2003년부터 온라인 게임 서버 개발을 시작하였고, 지금은 COM2US에서 게임 서버 개발 지원, 채용, 교육, R&D 업무를 하고 있습니다. 현재 Developer Technologies 부문의 Microsoft MVP로도 활동하고 있습니다.",
        ImageUrl = "/images/speakers/choi_heungbae.png"
    };

    private readonly Speaker jeong_seil = new()
    {
        Id = nameof(jeong_seil),
        Name = "정세일",
        Title = "Microsoft MVP",
        Company = "",
        Bio = "닷넷데브 커뮤니티의 디모이 입니다. 닷넷데브 운영진, 신구대 겸임교수 및 작은 회사의 CTO로 활동하고 있습니다.",
        ImageUrl = "/images/speakers/jeong_seil.jpeg"
    };

    // Birds of Feather
    private readonly Speaker lee_jaewoong = new()
    {
        Id = nameof(lee_jaewoong),
        Name = "이재웅",
        Title = ".NET Engineer",
        Company = "",
        Bio = "닷넷데브 운영진으로 활동하고 있으며, WPF 프레임워크 아키텍쳐, 닷넷 기술지원 등을 전문으로 하는 닷넷 엔지니어입니다. 여가시간을 닷넷 커뮤니티와 오픈소스 활동으로 보내고 있습니다.",
        ImageUrl = "/images/speakers/lee_jaewoong.png"
    };

    public SpeakerCollection Speakers => SpeakerCollection.Create(
        lee_gunbok, park_junghoon, motoki_nakae, lee_suho,
        nam_jeonghyun, han_jaejun, kang_younjung,
        cho_junghyun, mats_lundell, kim_juho,
        park_moonchan, oh_minseok, lee_jongin,
        lee_sangjun, justin_yoo, choi_heungbae, jeong_seil, lee_jaewoong
    );

    #endregion

    #region Sessions

    // Keynote
    private Session keynote => new()
    {
        Id = nameof(keynote),
        Title = "디지털 트랜스포메이션 시대의 .NET 개발자",
        Abstract = "디지털 트랜스포메이션 시대에 .NET 개발자로서의 역할과 미래를 조망합니다.",
        Speakers = [lee_gunbok],
        Format = SessionFormat.Keynote,
        Duration = TimeSpan.FromMinutes(30),
        Topic = SessionTopic.General,
        VideoUrl = "https://www.youtube.com/watch?v=g1bWadLzmHs",
        SlidesUrl = "https://raw.githubusercontent.com/dotnetdev-kr/dotNETConf-Presentation/main/2023/dotNETConf/Breakout-01-dotnet-conf-_Seoul.pdf",
        Tags = [".NET", "Digital Transformation", "Keynote"]
    };

    // Breakout 1/2/3
    private Session aspnet_monitoring => new()
    {
        Id = nameof(aspnet_monitoring),
        Title = "ASP.NET Core 애플리케이션 모니터링",
        Abstract = "ASP.NET Core 애플리케이션의 성능을 모니터링하고 분석하는 방법을 배웁니다.",
        Speakers = [park_junghoon],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(35),
        Topic = SessionTopic.DevOps,
        VideoUrl = "https://www.youtube.com/watch?v=_h6UNeaSWO8",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/raw/main/2023/dotNETConf/Breakout-03-aspnetCoreMonitoring.pptx",
        Tags = ["ASP.NET Core", "Monitoring", "DevOps"]
    };

    private Session blazor_highperf => new()
    {
        Id = nameof(blazor_highperf),
        Title = "\"고성능\" 튜닝으로 Blazor 애플리케이션 개발을 시작해 봅시다!",
        Abstract = "Blazor 애플리케이션의 성능을 최적화하는 방법을 배웁니다.",
        Speakers = [motoki_nakae],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(35),
        Topic = SessionTopic.Web,
        VideoUrl = "https://www.youtube.com/watch?v=7jpIX5jEODs",
        SlidesUrl = "https://igjp-sample.github.io/DotNETConf2023Seoul/",
        Tags = ["Blazor", "Performance", "Web"]
    };

    private Session serilog => new()
    {
        Id = nameof(serilog),
        Title = "Serilog를 통해 애플리케이션 데이터를 수집하고 분석하기",
        Abstract = "Serilog를 활용하여 애플리케이션 로그를 수집하고 분석하는 방법을 배웁니다.",
        Speakers = [lee_suho],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(35),
        Topic = SessionTopic.DevOps,
        VideoUrl = "https://www.youtube.com/watch?v=9nOgbVQxhVU",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/raw/main/2023/dotNETConf/Breakout-04-Serilog%EB%A5%BC%20%ED%86%B5%ED%95%B4%20%EC%95%A0%ED%94%8C%EB%A6%AC%EC%BC%80%EC%9D%B4%EC%85%98%20%EB%8D%B0%EC%9D%B4%ED%84%B0%EB%A5%BC%20%EC%88%98%EC%A7%91%ED%95%98%EA%B3%A0%20%EB%B6%84%EC%84%9D%ED%95%98%EC%9E%90.pptx",
        Tags = ["Serilog", "Logging", "Monitoring"]
    };

    // Breakout 4/5/6
    private Session windows_container => new()
    {
        Id = nameof(windows_container),
        Title = "윈도우 기반 서버를 클라우드 친화적으로 바꾸는 법 (feat. 윈도우 컨테이너)",
        Abstract = "윈도우 컨테이너를 활용하여 레거시 윈도우 서버를 클라우드 친화적으로 전환하는 방법을 배웁니다.",
        Speakers = [nam_jeonghyun],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(35),
        Topic = SessionTopic.Cloud,
        VideoUrl = "https://www.youtube.com/watch?v=3N44lpt91Tg",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/raw/main/2023/dotNETConf/Breakout-05-dotnetconf-seoul-2023-rkttu.pptx",
        Tags = ["Windows Container", "Cloud", "Migration"]
    };

    private Session dotnet6_migration => new()
    {
        Id = nameof(dotnet6_migration),
        Title = ".NET Framework 기반 SaaS 솔루션 .NET 6 전환기",
        Abstract = ".NET Framework 기반 SaaS 솔루션을 .NET 6로 마이그레이션한 경험을 공유합니다.",
        Speakers = [han_jaejun],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(35),
        Topic = SessionTopic.Web,
        VideoUrl = "https://www.youtube.com/watch?v=AYbALQdyD84",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/raw/main/2023/dotNETConf/Breakout-06-dotnetconf2023_%ED%81%AC%EB%A0%88%EB%B9%84%EC%8A%A4%ED%8C%8C%ED%8A%B8%EB%84%88%EC%8A%A4_%ED%95%9C%EC%9E%AC%EC%A4%80.pdf",
        Tags = [".NET 6", "Migration", "SaaS"]
    };

    private Session blazor_cosmosdb => new()
    {
        Id = nameof(blazor_cosmosdb),
        Title = "나만의 To-do 앱 빌드하기 (feat. Blazor & CosmosDB)",
        Abstract = "Blazor와 CosmosDB를 활용하여 To-do 애플리케이션을 만드는 방법을 배웁니다.",
        Speakers = [kang_younjung],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(35),
        Topic = SessionTopic.Web,
        VideoUrl = "https://www.youtube.com/watch?v=WCpJJIzfUYU",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/raw/main/2023/dotNETConf/Breakout-07-dotnetconf2023_YounjungKang.pptx",
        Tags = ["Blazor", "CosmosDB", "Azure"]
    };

    // Breakout 7/8/9
    private Session maui_toolkit => new()
    {
        Id = nameof(maui_toolkit),
        Title = "MAUI Community Toolkit을 활용한 효과적인 MAUI 앱 개발",
        Abstract = "MAUI Community Toolkit을 활용하여 효과적으로 MAUI 앱을 개발하는 방법을 배웁니다.",
        Speakers = [cho_junghyun],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(35),
        Topic = SessionTopic.Mobile,
        VideoUrl = "https://www.youtube.com/watch?v=1dVIFsqfC7U",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/raw/main/2023/dotNETConf/Breakout-08-dotnetconf2023-MCT-%EC%A1%B0%EC%A4%91%ED%98%84.pptx",
        Tags = ["MAUI", "Community Toolkit", "Mobile"]
    };

    private Session azure_ad => new()
    {
        Id = nameof(azure_ad),
        Title = ".NET 6와 Azure Active Directory로 웹 애플리케이션 사용자 관리하기",
        Abstract = ".NET 6와 Azure Active Directory를 활용하여 웹 애플리케이션의 사용자 인증 및 관리를 구현하는 방법을 배웁니다.",
        Speakers = [mats_lundell],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(35),
        Topic = SessionTopic.Cloud,
        VideoUrl = "https://www.youtube.com/watch?v=-PpmioIE854",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/raw/main/2023/dotNETConf/Breakout-09-AD%20B2X%20-%20Identity%20and%20Access%20Management%20for%20Customers%20and%20Partners.pdf",
        Tags = ["Azure AD", "Authentication", ".NET 6"]
    };

    private Session csharp11_static_abstract => new()
    {
        Id = nameof(csharp11_static_abstract),
        Title = "C# 11 static abstract members 이해와 대비",
        Abstract = "C# 11의 static abstract members 기능을 이해하고 활용하는 방법을 배웁니다.",
        Speakers = [kim_juho],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(35),
        Topic = SessionTopic.General,
        VideoUrl = "https://www.youtube.com/watch?v=3FvKQB-lVrQ",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/raw/main/2023/dotNETConf/Breakout-10-slides-export.pdf",
        Tags = ["C# 11", "Static Abstract", "Language Features"]
    };

    // Breakout 10/11/12
    private Session mvvm_toolkit => new()
    {
        Id = nameof(mvvm_toolkit),
        Title = "MVVM Toolkit을 사용하려는 개발자를 위한 안내",
        Abstract = "MVVM Toolkit을 활용하여 효과적으로 MVVM 패턴을 구현하는 방법을 배웁니다.",
        Speakers = [park_moonchan],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(35),
        Topic = SessionTopic.Desktop,
        VideoUrl = "https://www.youtube.com/watch?v=PaW62J11_-g",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/raw/main/2023/dotNETConf/Breakout-13-dotnetconf2023-deck-%EB%B0%95%EB%AC%B8%EC%B0%AC.pptx",
        Tags = ["MVVM Toolkit", "MVVM", "Desktop"]
    };

    private Session debug_dotnet => new()
    {
        Id = nameof(debug_dotnet),
        Title = "닷넷을 디버깅해 보자!",
        Abstract = ".NET 애플리케이션을 효과적으로 디버깅하는 방법과 팁을 배웁니다.",
        Speakers = [oh_minseok],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(35),
        Topic = SessionTopic.General,
        VideoUrl = "https://www.youtube.com/watch?v=j2peu5VgHEE",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/raw/main/2023/dotNETConf/Breakout-11-lets-debug-dotnet-min-seok-oh.pptx",
        Tags = ["Debugging", ".NET", "Tools"]
    };

    private Session dotnet_everything => new()
    {
        Id = nameof(dotnet_everything),
        Title = ".NET 안되는게 뭔가요?",
        Abstract = ".NET으로 할 수 있는 다양한 개발 영역을 소개합니다.",
        Speakers = [lee_jongin],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(35),
        Topic = SessionTopic.General,
        VideoUrl = "https://www.youtube.com/watch?v=NOAT6xNAqGg",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/raw/main/2023/dotNETConf/Breakout-12-%5B%EC%9D%B4%EC%A2%85%EC%9D%B8%5D%20.NET%20%EC%95%88%EB%90%98%EB%8A%94%20%EA%B2%8C%20%EB%AD%94%EA%B0%80%EC%9A%94.pptx",
        Tags = [".NET", "Overview", "Use Cases"]
    };

    // Hands-on-Lab
    private Session spread_net => new()
    {
        Id = nameof(spread_net),
        Title = "Spread.NET과 함께하는 쾌-적 Excel 개발",
        Abstract = "Spread.NET을 활용하여 Excel 기능을 구현하는 방법을 배웁니다.",
        Speakers = [lee_sangjun],
        Format = SessionFormat.HandsOnLab,
        Duration = TimeSpan.FromMinutes(55),
        Topic = SessionTopic.Desktop,
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/raw/main/2023/dotNETConf/HOL-15-dotnetconf2023.pptx",
        Tags = ["Spread.NET", "Excel", "Desktop"]
    };

    private Session github_codespaces => new()
    {
        Id = nameof(github_codespaces),
        Title = "닷넷 개발자를 위한 깃헙 코드스페이스 설정",
        Abstract = "GitHub Codespaces를 .NET 개발 환경으로 설정하는 방법을 배웁니다.",
        Speakers = [justin_yoo],
        Format = SessionFormat.HandsOnLab,
        Duration = TimeSpan.FromMinutes(55),
        Topic = SessionTopic.DevOps,
        SlidesUrl = "https://github.com/justinyoo/hol-devcontainers-dotnet-ko",
        Tags = ["GitHub Codespaces", "Dev Containers", "DevOps"]
    };

    private Session supersocketlite => new()
    {
        Id = nameof(supersocketlite),
        Title = "SuperSocketLite로 고성능 Socket 서버 개발하기",
        Abstract = "SuperSocketLite를 활용하여 고성능 소켓 서버를 개발하는 방법을 배웁니다.",
        Speakers = [choi_heungbae],
        Format = SessionFormat.HandsOnLab,
        Duration = TimeSpan.FromMinutes(115),
        Topic = SessionTopic.Performance,
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/raw/main/2023/dotNETConf/HOL-17-SuperSocketLite%EB%A1%9C%20%EA%B3%A0%EC%84%B1%EB%8A%A5%20Socket%20%EC%84%9C%EB%B2%84%20%EA%B0%9C%EB%B0%9C%ED%95%98%EA%B8%B0%20(Hands-on-Lab%20%EC%84%B8%EC%85%98).pptx",
        Tags = ["SuperSocketLite", "Socket", "High Performance"]
    };

    private Session stl_fusion => new()
    {
        Id = nameof(stl_fusion),
        Title = "Stl.Fusion 소개 - 실시간 앱 서비스 만들기",
        Abstract = "Stl.Fusion을 활용하여 실시간 앱 서비스를 만드는 방법을 배웁니다.",
        Speakers = [jeong_seil],
        Format = SessionFormat.HandsOnLab,
        Duration = TimeSpan.FromMinutes(55),
        Topic = SessionTopic.Web,
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/raw/main/2023/dotNETConf/HOL-18-Stl.Fusion%20%EC%86%8C%EA%B0%9C-%EC%8B%A4%EC%8B%9C%EA%B0%84%20%EC%95%B1%20%EC%84%9C%EB%B9%84%EC%8A%A4%20%EB%A7%8C%EB%93%A4%EA%B8%B0.pptx",
        Tags = ["Stl.Fusion", "Real-time", "Web"]
    };

    // Birds of Feather
    private Session devkit_2023 => new()
    {
        Id = nameof(devkit_2023),
        Title = "Windows Dev Kit 2023 체험해보기",
        Abstract = "Windows Dev Kit 2023을 직접 체험하고 개발 경험을 공유합니다.",
        Speakers = [lee_jaewoong],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(55),
        Topic = SessionTopic.Desktop,
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/raw/main/2023/dotNETConf/BirdsOfFeather-14-DevKit2023.pptx",
        Tags = ["Windows Dev Kit", "ARM64", "Desktop"]
    };

    #endregion

    #region Tracks

    private Track breakout => new()
    {
        Id = nameof(breakout),
        Name = "Breakout 세션",
        Color = "#0d6efd",
        Sessions = SessionCollection.Create(
            keynote,
            aspnet_monitoring, blazor_highperf, serilog,
            windows_container, dotnet6_migration, blazor_cosmosdb,
            maui_toolkit, azure_ad, csharp11_static_abstract,
            mvvm_toolkit, debug_dotnet, dotnet_everything
        )
    };

    private Track handsonlab => new()
    {
        Id = nameof(handsonlab),
        Name = "Hands-on-Lab 세션",
        Color = "#198754",
        Sessions = SessionCollection.Create(
            spread_net, github_codespaces, supersocketlite, devkit_2023, stl_fusion
        )
    };

    #endregion

    #region Sponsors

    private readonly Sponsor microsoft = new()
    {
        Id = nameof(microsoft),
        Name = "Microsoft",
        Tier = SponsorTier.Platinum,
        WebsiteUrl = "https://www.microsoft.com/",
        Description = "식사 제공",
        LogoUrl = "/images/sponsors/microsoft.png"
    };

    private readonly Sponsor maru180 = new()
    {
        Id = nameof(maru180),
        Name = "아산나눔재단/마루180,마루360",
        Tier = SponsorTier.Platinum,
        WebsiteUrl = "https://www.maru.org/",
        Description = "장소 제공",
        LogoUrl = "/images/sponsors/maru180.png"
    };

    private readonly Sponsor dotnet_foundation = new()
    {
        Id = nameof(dotnet_foundation),
        Name = ".NET Foundation",
        Tier = SponsorTier.Gold,
        WebsiteUrl = "https://www.dotnetfoundation.org/",
        Description = "개최 지원",
        LogoUrl = "/images/sponsors/dotnet_foundation.png"
    };

    private readonly Sponsor infragistics = new()
    {
        Id = nameof(infragistics),
        Name = "Infragistics",
        Tier = SponsorTier.Gold,
        WebsiteUrl = "https://www.infragistics.com/",
        Description = "커피 간식 제공",
        LogoUrl = "/images/sponsors/infragistics.png"
    };

    private readonly Sponsor planetarium = new()
    {
        Id = nameof(planetarium),
        Name = "플라네타리움",
        Tier = SponsorTier.Gold,
        WebsiteUrl = "https://recruit.planetariumhq.com/",
        Description = "커피 간식 제공",
        LogoUrl = "/images/sponsors/planetarium.png"
    };

    private readonly Sponsor crevisse = new()
    {
        Id = nameof(crevisse),
        Name = "크레비스 파트너스",
        Tier = SponsorTier.Silver,
        WebsiteUrl = "https://www.crevisse.com/",
        Description = "경품 굿즈 제공",
        LogoUrl = "/images/sponsors/crevisse.png"
    };

    private readonly Sponsor querypie = new()
    {
        Id = nameof(querypie),
        Name = "쿼리파이",
        Tier = SponsorTier.Silver,
        WebsiteUrl = "https://www.querypie.com/",
        Description = "경품 굿즈 제공",
        LogoUrl = "/images/sponsors/querypie.png"
    };

    private readonly Sponsor someotherplace = new()
    {
        Id = nameof(someotherplace),
        Name = "썸아더플레이스",
        Tier = SponsorTier.Community,
        Description = "행사 운영 지원",
        LogoUrl = "/images/sponsors/someotherplace.png"
    };

    #endregion

    #region Venues

    private VenueInfo maru180_venue => new()
    {
        Id = nameof(maru180_venue),
        Name = "마루180",
        Address = "서울 강남구 역삼로 180 지하 1층 이벤트홀",
        Tracks = TrackCollection.Create(breakout)
    };

    private VenueInfo maru360_venue => new()
    {
        Id = nameof(maru360_venue),
        Name = "마루360",
        Address = "서울 강남구 역삼로 172 지하 1층 성장 세미나룸",
        Tracks = TrackCollection.Create(handsonlab)
    };

    #endregion

    public EventInfo Event => new()
    {
        Slug = Slug,
        Year = 2023,
        Title = ".NET Conf 2023 x Seoul",
        Theme = "MAUI, Blazor, ASP.NET Core와 함께하는 풀 스택 개발",
        Description = ".NET Conf 2022의 공식 지역 이벤트로, MAUI, Blazor, ASP.NET Core 등 풀 스택 애플리케이션 개발에 필요한 여러 기술에 관한 최신 정보와 인사이트를 커뮤니티 발표자들과 함께 공유했습니다.",
        Date = new DateTime(2023, 1, 19),
        Type = EventType.Offline,
        AttendeeCount = 200,
        HeroImageUrl = "/images/events/2023-hero.webp",
        Venues = VenueCollection.Create(maru180_venue, maru360_venue),
        Sponsors = SponsorCollection.Create(microsoft, maru180, dotnet_foundation, infragistics, planetarium, crevisse, querypie, someotherplace)
    };

    public ScheduleGrid Schedule => new ScheduleGridBuilder()
        // Breakout 세션 (마루180)
        .ForDay(1)
        .AddTrack(breakout)

        .AddTimeSlot(new TimeOnly(9, 0), 60, slot => slot
        .At(0, new Session { Id = "checkin", Title = "행사 등록", Abstract = "", Format = SessionFormat.CheckIn, Duration = TimeSpan.FromMinutes(60), Speakers = [] }))

        .AddTimeSlot(new TimeOnly(9, 30), 30, slot => slot
            .At(0, keynote))

        .AddTimeSlot(new TimeOnly(10, 0), 35, slot => slot
            .At(0, aspnet_monitoring))

        .AddTimeSlot(new TimeOnly(10, 40), 35, slot => slot
            .At(0, blazor_highperf))

        .AddTimeSlot(new TimeOnly(11, 20), 35, slot => slot
            .At(0, serilog))

        .AddTimeSlot(new TimeOnly(12, 0), 60, slot => slot
        .At(0, new Session { Id = "lunch", Title = "점심 식사", Abstract = "", Format = SessionFormat.Lunch, Duration = TimeSpan.FromMinutes(60), Speakers = [] }))

        .AddTimeSlot(new TimeOnly(13, 0), 35, slot => slot
            .At(0, windows_container))

        .AddTimeSlot(new TimeOnly(13, 40), 35, slot => slot
            .At(0, dotnet6_migration))

        .AddTimeSlot(new TimeOnly(14, 20), 35, slot => slot
            .At(0, blazor_cosmosdb))

        .AddTimeSlot(new TimeOnly(15, 0), 10, slot => slot
        .At(0, new Session { Id = "break1", Title = "휴식", Abstract = "", Format = SessionFormat.Break, Duration = TimeSpan.FromMinutes(10), Speakers = [] }))

        .AddTimeSlot(new TimeOnly(15, 10), 35, slot => slot
            .At(0, maui_toolkit))

        .AddTimeSlot(new TimeOnly(15, 50), 35, slot => slot
            .At(0, azure_ad))

        .AddTimeSlot(new TimeOnly(16, 30), 35, slot => slot
            .At(0, csharp11_static_abstract))

        .AddTimeSlot(new TimeOnly(17, 10), 10, slot => slot
        .At(0, new Session { Id = "break2", Title = "휴식", Abstract = "", Format = SessionFormat.Break, Duration = TimeSpan.FromMinutes(10), Speakers = [] }))

        .AddTimeSlot(new TimeOnly(17, 20), 35, slot => slot
            .At(0, mvvm_toolkit))

        .AddTimeSlot(new TimeOnly(18, 0), 35, slot => slot
            .At(0, debug_dotnet))

        .AddTimeSlot(new TimeOnly(18, 40), 35, slot => slot
            .At(0, dotnet_everything))

        .AddTimeSlot(new TimeOnly(19, 20), 10, slot => slot
        .At(0, new Session { Id = "closing", Title = "마무리 및 경품 추첨", Abstract = "", Format = SessionFormat.PrizeDrawing, Duration = TimeSpan.FromMinutes(10), Speakers = [] }))

        // Hands-on-Lab 세션 (마루360)
        .AddTrack(handsonlab)

        .AddTimeSlot(new TimeOnly(10, 0), 55, slot => slot
            .At(1, spread_net))

        .AddTimeSlot(new TimeOnly(11, 0), 55, slot => slot
            .At(1, github_codespaces))

        .AddTimeSlot(new TimeOnly(13, 0), 115, slot => slot
            .At(1, supersocketlite))

        .AddTimeSlot(new TimeOnly(15, 0), 55, slot => slot
            .At(1, devkit_2023))

        .AddTimeSlot(new TimeOnly(16, 0), 55, slot => slot
            .At(1, stl_fusion))

        .Build();
}
