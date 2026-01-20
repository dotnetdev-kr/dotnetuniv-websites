using DotNetUniverse.Models;
using DotNetUniverse.Models.Collections;

namespace DotNetUniverse.Services.YearData;

/// <summary>
/// 2019년 행사 데이터
/// </summary>
public class Year2019Data : IEventData
{
    public string Slug => "2019";
    public int Year => 2019;
    public string ThemeColor => "#dc3545";
    public string ThemeColorClass => "danger";

    #region Speakers

    private readonly Speaker scott_hanselman = new()
    {
        Id = nameof(scott_hanselman),
        Name = "Scott Hanselman",
        Title = "Principal Program Manager",
        Company = "Microsoft",
        Bio = """
            마이크로소프트의 파트너 프로그램 매니저이자, 20년 넘게 개발 생태계의 성장을 이끌어온 베테랑 소프트웨어 엔지니어입니다. 그는 기술 블로그와 팟캐스트인 'Hanselminutes'를 통해 복잡한 기술 개념을 대중에게 쉽게 전달하는 탁월한 능력을 갖추고 있습니다. 특히 오픈 소스, 웹 개발, 그리고 접근성(Accessibility) 분야에서 목소리를 높이며 전 세계 개발자들에게 영감을 주는 교육자이자 멘토로 활동하고 있습니다.
            """,
        TwitterUrl = "https://twitter.com/shanselman",
        GitHubUrl = "https://github.com/shanselman",
        WebsiteUrl = "https://hanselman.com",
    };

    private readonly Speaker jason_beres = new()
    {
        Id = nameof(jason_beres),
        Name = "Jason Beres",
        Title = "Sr. VP of Developer Tools",
        Company = "Infragistics",
        Bio = """
            글로벌 소프트웨어 솔루션 기업인 인프라지스틱스(Infragistics)의 개발자 도구 부문 수석 부사장(SVP)입니다. 그는 20년 이상 소프트웨어 산업에 종사하며 기업용 애플리케이션 개발, 사용자 인터페이스(UI) 디자인, 그리고 개발자 경험(DX) 혁신을 이끌어온 베테랑 전문가입니다.
            """
    };

    private readonly Speaker younglak_choi = new()
    {
        Id = nameof(younglak_choi),
        Name = "최영락",
        Company = "Microsoft",
        Bio = """
            글로벌 IT 기업에서의 실무 경험과 오픈소스 거버넌스에 대한 깊은 이해를 결합하여, 기술 생태계의 성장을 이끄는 개발자 경험(DX) 전문가입니다.
            """
    };

    private readonly Speaker kijun_seo = new()
    {
        Id = nameof(kijun_seo),
        Name = "서기준",
        Title = "대표",
        Company = "플라네타리움",
        Bio = """
            '영원히 멈추지 않는 게임 생태계'를 꿈꾸는 연쇄 창업가이자, 전 세계 최초로 중앙 서버가 없는 탈중앙화 RPG '나인 크로니클(Nine Chronicles)'을 선보인 웹3 게임 업계의 선구자입니다.
            """
    };

    private readonly Speaker dahye_lee = new()
    {
        Id = nameof(dahye_lee),
        Name = "이다혜",
        Title = "Developer",
        Company = "Infragistics",
        Bio = """
            통역 및 개발 지원으로 행사에 기여했습니다.
            """
    };

    private readonly Speaker jungeun_cho = new()
    {
        Id = nameof(jungeun_cho),
        Name = "조정은",
        Title = "Developer",
        Company = "JetBrains",
        Bio = """
            JetBrains에서 Regional Marketing Manager로 일하고 있습니다.
            """
    };

    private readonly Speaker yohan_ko = new()
    {
        Id = nameof(yohan_ko),
        Name = "고요한",
        Title = "운영진",
        Company = "닷넷데브",
        Bio = """
            .NET 개발자로서 커뮤니티 활동에 참여하고 있습니다.
            """
    };

    private readonly Speaker junghyun_nam = new()
    {
        Id = nameof(junghyun_nam),
        Name = "남정현",
        Title = "운영진",
        Company = "닷넷데브",
        Bio = """
            데브시스터즈에서 DevOps 엔지니어로 일하고 있다. 마이크로소프트가 추구하는 오픈 소스와의 융합에 관한 시도에 관심이 많다. 최근에는 윈도 컨테이너와 윈도 쿠버네티스, 그리고 WSL에 관하여 연구하고 있다. 한국 애저 사용자 그룹과 닷넷 데브, 그리고 모여서 각자 코딩하는 모임이라는 커뮤니티에서도 활동하며 많은 개발자들과 이야기를 나누는 것을 즐긴다.
            """
    };

    private readonly Speaker satoru_yamaguchi = new()
    {
        Id = nameof(satoru_yamaguchi),
        Name = "야마구치 사토루",
        Title = "Developer",
        Company = "Infragistics",
        Bio = """
            사토루는 .NET 및 HTML5와 JavaScript 등 클라이언트 기술 분야에서 10년 이상의 경력을 지닌 Infragistics 베테랑 솔루션 컨설턴트입니다.
            현재 야마구치는 Infragistics 클라이언트 응용 프로그램 개발 관련 문제를 해결하는 솔루션 컨설턴트로 근무하고 있습니다.
            """
    };

    private readonly Speaker heungbae_choi = new()
    {
        Id = nameof(heungbae_choi),
        Name = "최흥배",
        Title = "Developer",
        Company = "컴투스",
        Bio = """
            2003년부터 온라인 게임 서버 개발을 시작하여 온라인 보드 게임, 액션, MMORPG 등 다양한 장르의 게임 개발에 참여하였다.
            2016, 2017년에는 NHN Next 라는 교육 기관에서 게임 개발 과정의 겸임 교수로 일을 하였다.
            현재는 컴투스에서 게임 서버 기술 R&D 및 기술 교육 관련 일을 하고 있다.
            Microsoft MVP 2009, 2010, 2011, 2017, 2018, 2019
            """,
        GitHubUrl = "https://github.com/jacking75"
    };

    private readonly Speaker minhui_hong = new()
    {
        Id = nameof(minhui_hong),
        Name = "홍민희",
        Title = "Developer",
        Bio = """
            지난 10년간 Python을 주로 쓰며, 여러 오픈 소스 활동을 해왔다.
            현재는 플라네타리움에서 게임을 위한 오픈 소스 블록체인 라이브러리 Libplanet을 만들며, 새로운 플랫폼인 .NET을 배워나가고 있다.
            """,
        WebsiteUrl = "https://hongminhee.org/"
    };

    private readonly Speaker sungwon_moon = new()
    {
        Id = nameof(sungwon_moon),
        Name = "문성원",
        Title = "Developer",
        Bio = """
            웹 개발로 프로그래밍을 시작하여 10여년간 PHP, Java, Python 등으로 주로 웹과 Win32 애플리케이션을 개발해왔습니다. 작년 말부터 직접 블록체인을 구현하는 것에 관심을 가지게 되어 Unity에서 사용할 수 있는 C# / .NET 기반의 libplanet을 개발하고 있습니다.
            """
    };

    private readonly Speaker jongin_lee = new()
    {
        Id = nameof(jongin_lee),
        Name = "이종인",
        Title = "Developer",
        Bio = """
            .NET Everywhere and for Everyone. 모든 사람을 위해 모든 곳에서 돌아가고 싶은 .NET을 오래전부터 흥미로워했고 계속 사용해오고 있습니다.
            .NET Standard에서 작성, 테스트한 코드를 ASP.NET, Azure Functions, Windows, Android, iOS에서 돌리고 이를 Azure DevOps와 자연스럽게 연결해 배포와 테스트를 하는데, 이런 좋은 개발 경험을 가질 수 있도록 해준 .NET을 좋아합니다.
            최근에 ML 영역으로 확장하고 있는 ML.NET에도 관심이 많네요. Microsoft의 MVP로 6년째 활동 중이며 현재 Developer Technologies 분야에서 활동 중입니다.
            """
    };

    private readonly Speaker hongmin_kim = new()
    {
        Id = nameof(hongmin_kim),
        Name = "김홍민",
        Title = "Developer",
        Company = "필라웨어",
        Bio = """
            Microsoft Student Partners 활동을 시작으로 닷넷의 세계에 발 담그게 되었습니다.
            주변인들이 다른 언어나 플랫폼으로 떠날 때 홀로 닷넷을 고수 해왔는데, 요즈음에 그 보람이 느껴집니다.
            현재 필라웨어에서 산업기능요원으로 재직하며, 여러 클라이언트, 웹 어플리케이션을 개발하고 있습니다.
            """
    };

    private readonly Speaker youngha_kim = new()
    {
        Id = nameof(youngha_kim),
        Name = "김영하",
        Title = "연구원",
        Company = "디플러스",
        Bio = """
            디플러스 연구원으로 재직 중이며, 2019년 MS Azure Discovery Day (2월 ~ 7월) 2일차 AI 활용 강연을 진행하였습니다.
            Korea ML.NET User Group을 운영하고 있습니다.
            """
    };

    private readonly Speaker sungtae_jung = new()
    {
        Id = nameof(sungtae_jung),
        Name = "정성태",
        Title = "Developer",
        Company = "제니퍼소프트",
        Bio = """
            현재 제니퍼소프트에서 .NET Framework 환경을 위한 애플리케이션 성능 관리(APM) 모듈을 개발하면서 틈틈이 책을 쓰거나 .NET 관련 지식을 블로그에 공유하며 15년째 Microsoft의 MVP로 활동하고 있습니다.
            """,
        WebsiteUrl = "https://www.sysnet.pe.kr"
    };

    private readonly Speaker changhoon_kang = new()
    {
        Id = nameof(changhoon_kang),
        Name = "강창훈",
        Title = "대표",
        Company = "(주)엠소프트웨어",
        Bio = """
            (주)엠소프트웨어 대표이며 Microsoft MVP (AI)로 활동하고 있습니다.
            Korea ML.NET User Group을 운영하고 있습니다.
            """
    };

    public SpeakerCollection Speakers => SpeakerCollection.Create(
        scott_hanselman, jason_beres, younglak_choi, kijun_seo, dahye_lee,
        jungeun_cho, yohan_ko, junghyun_nam, satoru_yamaguchi, heungbae_choi,
        minhui_hong, sungwon_moon, jongin_lee, hongmin_kim, youngha_kim,
        sungtae_jung, changhoon_kang
    );

    #endregion

    #region Sessions - Room A

    private Session hol_infragistics => new()
    {
        Id = nameof(hol_infragistics),
        Title = ".NET Core 3 및 Infragistics로 데이터 시각화 솔루션 구축",
        Abstract = """
            오늘날 우리는 종종 최종 사용자 / 최종 고객의 BI 대시 보드 및 데이터 분석과 같은 데이터 시각화 요구에 대해 듣습니다. 빅 데이터 / IoT 솔루션은 사용자에게 너무 많은 데이터를 저장하지만 이제는 실제 이점을 얻기 위해 시각화해야합니다. 데이터 시각화 수요에 대해 고객의 의견을 듣는 경우 어떻게 해결합니까?
            이 실습에서는 .NET Core 3 및 Infragistics 도구를 사용하여 대시 보드 UI 및 피벗 분석 UI를 빠르게 구축합니다. Infragistics를 사용하여 .NET 환경에서 스크래치 개발을 통해 데이터 시각화 솔루션을 구축하는 방법을 쉽게 배울 수 있습니다.
            """,
        Speakers = [jason_beres, dahye_lee, satoru_yamaguchi],
        Format = SessionFormat.HandsOnLab,
        Duration = TimeSpan.FromMinutes(90),
        SlidesUrl = "https://github.com/gdayori/Infragistics-WPF-Core3.0-Workshop",
        Tags = [".NET Core 3", "Infragistics", "데이터 시각화"],
        Notes = ["Jason Beres님의 세션은 행사의 원활한 진행을 위하여 통역사 이다혜님께서 도움 주실 예정입니다."],
        Prerequisites = """
            * 노트북을 지참해야 합니다.
            * .NET Core 3.0 설치
            * Visual Studio 2019 16.3 이상
            * Infragistics WPF 2019.1 (트라이얼 버전도 가능합니다.)
            """,
        LabModules = [
            new() { Title = "핸즈온랩 모듈: Infragistics WPF NuGet 패키지 설치", Url = "https://github.com/gdayori/How-to-get-Infragistics-WPF-Nuget-packages", Description = "Infragistics 도구 설치 및 프로젝트 생성" }
        ]
    };

    private Session crossplatform_library => new()
    {
        Id = nameof(crossplatform_library),
        Title = "여러 .NET 구현과 플랫폼을 두루 지원하는 라이브러리 만들기",
        Abstract = """
            Mono, .NET Core, .NET Framework, Unity와 같은 여러 .NET 구현과 Linux, macOS, Windows와 같은 여러 플랫폼을 두루 지원하는 오픈 소스 라이브러리를 만들어 오며 겦었던 경험담을 공유합니다. 또, 오픈 소스 프로젝트에서 여러 사람들의 패치를 받으면서도 일정한 코드 품질을 유지할 수 있도록 돕는 .NET/C# 도구들을 소개합니다.
            """,
        Speakers = [minhui_hong],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        VideoUrl = "https://www.youtube.com/watch?v=CiejcYxz3fs",
        SlidesUrl = "https://speakerdeck.com/minhee/yeoreo-net-guhyeongwa-peulraespomeul-duru-jiweonhaneun-raibeureori-opeun-soseuro-mandeulgi",
        Tags = [".NET Standard", "Cross-platform", "Library"]
    };

    private Session async_programming => new()
    {
        Id = nameof(async_programming),
        Title = ".NET에서 비동기 프로그래밍 배우기",
        Abstract = """
            .NET을 처음 접한 프로그래머가 P2P 네트워킹 기능을 구현하면서 마주쳄던 문제와 해결 방법등 개발 경험 전반에 걸쳐서 이야기 해 보려 합니다. 또한 C# 8.0에 추가되는 비동기 스트림을 미리 써볼 수 있는 AsyncEnumerable과 비동기 잠금(lock) 등의 편리한 기능을 갖춘 AsyncEx등의 라이브러리들도 소개합니다.
            """,
        Speakers = [sungwon_moon],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        VideoUrl = "https://www.youtube.com/watch?v=A73UGlCG4yM",
        SlidesUrl = "https://www.slideshare.net/seongwonmun3/net-179320414",
        Tags = ["Async", "Await", "비동기"]
    };

    private Session healthcheck => new()
    {
        Id = nameof(healthcheck),
        Title = "ASP.NET Core를 통한 HealthCheck 서비스 구현",
        Abstract = """
            ASP.NET Core를 통해 HealthCheck 서비스를 구현하고, 프로덕션에 배포한 경험을 공유합니다.
            이와 더불어 짧은 Hands-On-Lab을 통해 Customize한 미들웨어를 개발하고, 적용하는 방법을 진행 할 예정입니다.
            마지막으로, WebHook 등을 연계하는 과정까지 소개합니다.
            """,
        Speakers = [hongmin_kim],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        SlidesUrl = "https://www.slideshare.net/HongMinKim1/net-conf-2019-korea-aspnet-core-healthcheck",
        Tags = ["ASP.NET Core", "HealthCheck", "Microservices"],
        Notes = ["발표자 요청으로 세션 다시보기 영상은 제공되지 않습니다."]
    };

    private Session dotnet_history => new()
    {
        Id = nameof(dotnet_history),
        Title = "닷넷 17년의 변화 정리 및 닷넷 코어 3.0",
        Abstract = """
            .NET Framework는 지난 17년의 세월 동안 꾸준한 진화를 거듭해 왔고 이로 인해 근래에 시작한 개발자들은 닷넷 개발 환경의 현 위치에 혼란을 느낄 수 있습니다. 이번 세션은, 닷넷의 초기 개발 환경부터 시작해 그와 함께 발전해 온 언어 (예를 들어, C#)과의 관계를 되짚어 봄으로써 가장 최근에 릴리스된 닷넷 코어 3.0까지의 변화를 일목요연하게 정리합니다.
            """,
        Speakers = [sungtae_jung],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        VideoUrl = "https://www.youtube.com/watch?v=pTN2paCE3kc",
        SlidesUrl = "http://www.sysnet.pe.kr/2/0/12030",
        Tags = [".NET History", ".NET Core 3.0"]
    };

    #endregion

    #region Sessions - Room B

    private Session hol_supersocket => new()
    {
        Id = nameof(hol_supersocket),
        Title = "SuperSocket을 이용하여 .NET Core 플랫폼에서 고성능 TCP Socket 서버 만들기",
        Abstract = """
            Hands-on-Lab 세션으로 진행할 예정으로 시간은 2~3시간 정도 예상합니다.
            오픈 소스인 SuperSocket을 사용하면 쉽고 간단하게 고성능 TCP Socket 서버를 만들 수 있습니다.
            Socket 프로그래밍이나 SuperSocket을 잘 모르는 분들을 대상으로 하고 있습니다.
            먼저 간단하게 SuperSocket에 대해서 설명하고, 실습으로 간단한 Echo 서버를 시작으로 채팅 서버까지 만들어갈 예정입니다.
            """,
        Speakers = [heungbae_choi],
        Format = SessionFormat.HandsOnLab,
        Duration = TimeSpan.FromMinutes(90),
        SlidesUrl = "https://docs.google.com/presentation/d/1m86UXCwV7DzkRn3PHjrzDk9W1y1VgD5RQOyl_2K_D-A",
        Tags = ["SuperSocket", ".NET Core", "TCP"],
        Notes = ["세션 다시보기는 제공되지 않습니다."],
        Prerequisites = """
            * 기본적인 C# 프로그래밍이 가능해야 합니다.
            * 노트북을 지참해야 합니다.
            * .NET Core 2.2 or 3.0 설치
            * 다음 IDE 중 하나 설치: Visual Studio 2019 16.3 이상, Visual Studio 2019 for Mac 8.3 이상, JetBrains Rider 2019.2 이상 또는 Visual Studio Code
            """,
        LabModules = [
            new() { Title = "SuperSocket GitHub 저장소", Url = "https://github.com/jacking75/SuperSocketLite", Description = "SuperSocketLite 오픈 소스 저장소" }
        ]
    };

    private Session windows_desktop => new()
    {
        Id = nameof(windows_desktop),
        Title = ".NET Core 3.0과 Windows Desktop",
        Abstract = """
            .NET Core 3.0에 새롭게 추가된 Windows Desktop에 관한 새로운 기능들을 살펴보고, 어떻게 실무에 적용할 수 있는지에 대해 살펴봅니다.
            """,
        Speakers = [junghyun_nam],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        VideoUrl = "https://www.youtube.com/watch?v=vS0DoxNhkgc",
        SlidesUrl = "https://1drv.ms/p/s!Aj231qrFhIQxqbRoHCRQX4vc_RHTGQ",
        Tags = [".NET Core 3.0", "WPF", "WinForms"]
    };

    private Session csharp8 => new()
    {
        Id = nameof(csharp8),
        Title = "새로워진 C#: C# 8의 새로운 기능",
        Abstract = """
            .NET과 함께 C#은 빠르게 변하고 진화해왔습니다. 그동안 Async-await 부터 튜플, 패턴매칭과 이외의 많은 언어 기능들이 추가되며 .NET으로 복잡한 문제들을 풀어가고 있는 개발자들에게 도움을 주어왔습니다. C# 8에서는 더 나아진 패턴매칭, Nullable reference types, 비동기 스트림과 같은 많은 기능들이 추가되었는데요, 그 동안의 C#의 변화와 .NET Core 3.0 시대를 맞아 함께 출시되는 C# 8의 새로운 기능들을 알아봅니다. 새로운 언어 기능과 함께 여러분이 고민하고 있는 문제들을 어떻게 더 잘 풀어나갈 수 있을까요?
            """,
        Speakers = [jongin_lee],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        VideoUrl = "https://www.youtube.com/watch?v=UJNll6rxqGo",
        SlidesUrl = "https://github.com/lunelake/DotNetConference2019_Seoul",
        Tags = ["C# 8", "Nullable", "Pattern Matching"]
    };

    private Session automl => new()
    {
        Id = nameof(automl),
        Title = ".NET Core로 해보는 AutoML",
        Abstract = """
            .NET Core로 현재 활발하게 개발되고 있는 ML.NET을 활용한 머신러닝을 시작하는 방법 및 가능성을 알아보고, ML.NET의 핵심기능중 하나인 Model Builder를 활용한 AutoML을 알아봅니다.
            """,
        Speakers = [youngha_kim],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        VideoUrl = "https://www.youtube.com/watch?v=bxYtXMAjRE8",
        SlidesUrl = "https://www.slideshare.net/fermat39/mlnet-automl",
        Tags = ["ML.NET", "AutoML", "Machine Learning"]
    };

    private Session azure_luis => new()
    {
        Id = nameof(azure_luis),
        Title = "ML기반 자연어 처리 서비스 Azure LUIS .NET 어플리케이션으로 제어하고 통합하기",
        Abstract = """
            Azure 클라우드 기반 인공지능 활용서비스인 Azure Cognitive Service의 자연어 처리 서비스를 담당하고 있는 Azure LUIS 서비스의 기초적인 사용법을 알아보고 LUIS OPEN API 서비스 와 .NET Standard 2.0 기반으로 개발된 오픈소스 라이브러리인 Cognitive.LUIS.Programmatic 팩키지를 활용한 .NET Application에서 LUIS 서비스를 제어하고 .NET Application과 LUIS를 통합하는 방법을 소개합니다.
            """,
        Speakers = [changhoon_kang],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        VideoUrl = "https://www.youtube.com/watch?v=YoDQSZ9Dqdw",
        SlidesUrl = "http://bit.ly/335AvCe",
        Tags = ["Azure LUIS", "NLP", "AI"]
    };

    #endregion

    #region Sessions - Shared

    private Session keynote => new()
    {
        Id = nameof(keynote),
        Title = "키노트",
        Abstract = """
            닷넷 코어 3.0 출시에 맞추어 무엇이 새로워졌는지, 왜 개발자들이 닷넷을 선택했는지, 그리고 닷넷 코어의 출시가 개발자들에게 어떤 인사이트를 가져다 줄 수 있을지 한 눈에 둘러볼 수 있는 세션을 준비하였습니다.
            """,
        Speakers = [younglak_choi, scott_hanselman, kijun_seo, jason_beres, dahye_lee, jungeun_cho, yohan_ko, junghyun_nam],
        Format = SessionFormat.Keynote,
        Duration = TimeSpan.FromMinutes(60),
        IsShared = true,
        VideoUrl = "https://www.youtube.com/watch?v=8qtmRG5vQxM",
        SlidesUrl = "https://1drv.ms/p/s!AmGH7-hAj4RKoEUKjOWgy3OBfdy1",
        Tags = [".NET Conf", "Keynote"],
        Notes = [
            "Scott Hanselman님의 세션은 동영상으로 준비되며, 자막이 추가됩니다.",
            "Jason Beres님의 세션은 행사의 원활한 진행을 위하여 통역사 이다혜님께서 도움 주실 예정입니다."
        ]
    };

    private Session break_1 => new()
    {
        Id = nameof(break_1),
        Title = "휴식",
        Abstract = "쉬는 시간입니다. 로비에서 다과와 음료가 제공됩니다.",
        Speakers = [],
        Format = SessionFormat.Break,
        Duration = TimeSpan.FromMinutes(10),
        IsShared = true
    };

    private Session break_2 => new()
    {
        Id = nameof(break_2),
        Title = "휴식",
        Abstract = "쉬는 시간입니다.",
        Speakers = [],
        Format = SessionFormat.Break,
        Duration = TimeSpan.FromMinutes(10),
        IsShared = true
    };

    private Session break_3 => new()
    {
        Id = nameof(break_3),
        Title = "휴식",
        Abstract = "쉬는 시간입니다.",
        Speakers = [],
        Format = SessionFormat.Break,
        Duration = TimeSpan.FromMinutes(10),
        IsShared = true
    };

    private Session break_4 => new()
    {
        Id = nameof(break_4),
        Title = "휴식",
        Abstract = "쉬는 시간입니다.",
        Speakers = [],
        Format = SessionFormat.Break,
        Duration = TimeSpan.FromMinutes(10),
        IsShared = true
    };

    private Session closing => new()
    {
        Id = nameof(closing),
        Title = "클로징 및 경품추첨",
        Abstract = "행사 마무리 및 경품추첨이 진행됩니다. 끝까지 함께해 주세요!",
        Speakers = [],
        Format = SessionFormat.Closing,
        Duration = TimeSpan.FromMinutes(30),
        IsShared = true
    };

    #endregion

    #region Tracks

    private Track room_a => new()
    {
        Id = nameof(room_a),
        Name = "Room A",
        Description = "핸즈온랩 및 브레이크아웃 세션",
        Color = "#0d6efd",
        Sessions = SessionCollection.Create(
            hol_infragistics, crossplatform_library, async_programming,
            healthcheck, dotnet_history
        )
    };

    private Track room_b => new()
    {
        Id = nameof(room_b),
        Name = "Room B",
        Description = "핸즈온랩 및 브레이크아웃 세션",
        Color = "#198754",
        Sessions = SessionCollection.Create(
            hol_supersocket, windows_desktop, csharp8,
            automl, azure_luis
        )
    };

    #endregion

    #region Sponsors

    private readonly Sponsor microsoft = new() { Id = nameof(microsoft), Name = "Microsoft Korea", Tier = SponsorTier.Platinum, WebsiteUrl = "https://microsoft.com" };
    private readonly Sponsor planetarium = new() { Id = nameof(planetarium), Name = "Planetarium", Tier = SponsorTier.Gold, WebsiteUrl = "https://planetariumhq.com" };
    private readonly Sponsor infragistics = new() { Id = nameof(infragistics), Name = "Infragistics", Tier = SponsorTier.Gold, WebsiteUrl = "https://infragistics.com" };
    private readonly Sponsor blueport = new() { Id = nameof(blueport), Name = "(주)블루포트", Tier = SponsorTier.Gold, WebsiteUrl = "https://blueport.co.kr", Description = "BLUEPORT" };
    private readonly Sponsor microsoftware = new() { Id = nameof(microsoftware), Name = "마이크로소프트웨어", Tier = SponsorTier.Silver, Description = "MICRO SOFTWARE" };
    private readonly Sponsor jetbrains = new() { Id = nameof(jetbrains), Name = "JetBrains", Tier = SponsorTier.Silver, WebsiteUrl = "https://jetbrains.com" };
    private readonly Sponsor gilbut = new() { Id = nameof(gilbut), Name = "(주)도서출판 길벗", Tier = SponsorTier.Silver, WebsiteUrl = "https://gilbut.co.kr" };

    #endregion

    #region Venue

    private VenueInfo microsoft_korea => new()
    {
        Id = nameof(microsoft_korea),
        Name = "더케이트윈타워 A동 11층, 한국 마이크로소프트",
        Address = "서울시 종로구 종로1길 50",
        NaverMapUrl = "https://naver.me/xYz123abc",
        KakaoMapUrl = "https://place.map.kakao.com/12345678",
        GoogleMapUrl = "https://maps.app.goo.gl/abcdef123456",
        Directions = [
            "지하철: 1호선 종각역 3번 출구에서 도보 5분",
            "지하철: 5호선 광화문역 2번 출구에서 도보 7분",
            "버스: 종로1가 정류장 하차 (간선 101, 102, 103번)"
        ],
        ParkingInfo = """
            건물 지하 주차장 이용 가능 (유료)
            주차 요금: 10분당 1,000원
            행사 참가자 주차 할인권 제공 (3시간 무료)
            """,
        Tracks = TrackCollection.Create(room_a, room_b)
    };

    #endregion

    public EventInfo Event => new()
    {
        Slug = Slug,
        Year = 2019,
        Title = ".NET Conf 2019 @ Seoul",
        Theme = ".NET의 새로운 시대를 엽니다.",
        Description = ".NET Core 3.0 출시와 함께 국내외 .NET 전문가들이 모여 .NET의 미래를 이야기한 행사입니다.",
        Date = new DateTime(2019, 10, 5, 13, 0, 0),
        Type = EventType.Offline,
        AttendeeCount = 100,
        TrailerUrl = "https://www.youtube.com/watch?v=CaIaLDacrDs",
        HeroImageUrl = "/images/events/2019-hero.webp",
        Venues = VenueCollection.Create(microsoft_korea),
        SharedSessions = SessionCollection.Create(
            keynote, break_1, break_2, break_3, break_4, closing
        ),
        Sponsors = SponsorCollection.Create(
            microsoft, planetarium, infragistics, blueport,
            microsoftware, jetbrains, gilbut
        )
    };

    public EventStory Story => new()
    {
        Title = "시작 이야기",
        Subtitle = "모든 위대한 것은 작은 시작에서",
        Paragraphs = [
            "2019년 11월, .NET Core 3.0이 출시되고 .NET 생태계가 큰 변화를 맞이하던 시기, 국내 .NET 개발자들이 모여 .NET Conf 2019 @ Seoul을 개최했습니다.",
            "Scott Hanselman을 포함한 국내외 전문가들이 함께하여 .NET Core 3.0의 새로운 기능들과 앞으로의 .NET 생태계에 대해 이야기를 나눴습니다. 이 행사가 바로 .NET Universe의 시작이었습니다.",
            "키노트부터 핸즈온랩, 다양한 브레이크아웃 세션까지 풍성한 프로그램으로 진행된 이 행사에서 \"국내에도 .NET 개발자들을 위한 정기적인 컨퍼런스가 필요하다\"는 공감대가 형성되었고, 이후 .NET Dev 커뮤니티가 결성되어 .NET Universe로 발전하게 됩니다."
        ],
        Highlights = [
            new() { Icon = "bi-arrow-repeat", Title = ".NET Core 3.0", Description = "Windows Desktop 앱 지원 시작" },
            new() { Icon = "bi-code-square", Title = "C# 8.0", Description = "Nullable Reference Types 도입" },
            new() { Icon = "bi-window-desktop", Title = "Blazor 미리보기", Description = "WebAssembly의 가능성" }
        ]
    };

    public ScheduleGrid Schedule => new ScheduleGridBuilder()
        .ForDay(1)
        .AddTrack(room_a)
        .AddTrack(room_b)

        // 13:00-14:00 키노트
        .AddTimeSlot(new TimeOnly(13, 0), 60, slot => slot
            .FullWidth(keynote))

        // 14:00-14:10 휴식
        .AddTimeSlot(new TimeOnly(14, 0), 10, slot => slot
            .FullWidth(break_1))

        // 14:10-15:40 핸즈온랩
        .AddTimeSlot(new TimeOnly(14, 10), 90, slot => slot
            .At(0, hol_infragistics)
            .At(1, hol_supersocket))

        // 15:40-15:50 휴식
        .AddTimeSlot(new TimeOnly(15, 40), 10, slot => slot
            .FullWidth(break_2))

        // 15:50-16:35 브레이크아웃 세션
        .AddTimeSlot(new TimeOnly(15, 50), 45, slot => slot
            .At(0, crossplatform_library)
            .At(1, windows_desktop))

        // 16:35-16:45 휴식
        .AddTimeSlot(new TimeOnly(16, 35), 10, slot => slot
            .FullWidth(break_3))

        // 16:45-17:30 브레이크아웃 세션
        .AddTimeSlot(new TimeOnly(16, 45), 45, slot => slot
            .At(0, async_programming)
            .At(1, csharp8))

        // 17:30-17:40 휴식
        .AddTimeSlot(new TimeOnly(17, 30), 10, slot => slot
            .FullWidth(break_4))

        // 17:40-18:25 브레이크아웃 세션
        .AddTimeSlot(new TimeOnly(17, 40), 45, slot => slot
            .At(0, healthcheck)
            .At(1, automl))

        // 18:35-19:20 브레이크아웃 세션
        .AddTimeSlot(new TimeOnly(18, 35), 45, slot => slot
            .At(0, dotnet_history)
            .At(1, azure_luis))

        // 19:20-19:50 클로징
        .AddTimeSlot(new TimeOnly(19, 20), 30, slot => slot
            .FullWidth(closing))

        .Build();
}
