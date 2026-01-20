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
            .NET 및 개발자 도구 에반젤리스트로서 전 세계 개발자들에게 .NET의 가치를 전파하고 있습니다.
            팟캐스트 'Hanselminutes'를 진행하며, 개발자 커뮤니티에서 활발하게 활동하고 있습니다.
            """,
        TwitterUrl = "https://twitter.com/shanselman",
        GitHubUrl = "https://github.com/shanselman",
        WebsiteUrl = "https://hanselman.com"
    };

    private readonly Speaker jason_beres = new()
    {
        Id = nameof(jason_beres),
        Name = "Jason Beres",
        Title = "Sr. VP of Developer Tools",
        Company = "Infragistics",
        Bio = """
            Jason Beres는 모든 Infragistics의 제품에서 고객 중심의 혁신적인 기능을 주도적으로 개발하는 역할을 맡고 있습니다. 또한 Microsoft .NET MVP이자 INETA 스피커 국의 멤버이며 INETA의 학술위원회 위원장입니다.
            """
    };

    private readonly Speaker younglak_choi = new()
    {
        Id = nameof(younglak_choi),
        Name = "최영락",
        Company = "Microsoft",
        Bio = """
            키노트 진행을 맡았으며, 국내 .NET 커뮤니티 활성화에 기여하고 있습니다.
            """
    };

    private readonly Speaker kijun_seo = new()
    {
        Id = nameof(kijun_seo),
        Name = "서기준",
        Title = "대표",
        Company = "플라네타리움",
        Bio = """
            키노트 진행을 맡았으며, 블록체인 기반 게임 개발에 주력하고 있습니다.
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
            JetBrains Korea
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
            C# 언어 전문가로서 최신 C# 기능 및 언어 발전 방향에 대해 깊이 있는 지식을 가지고 있습니다.
            """
    };

    private readonly Speaker hongmin_kim = new()
    {
        Id = nameof(hongmin_kim),
        Name = "김홍민",
        Title = "Developer",
        Bio = """
            ASP.NET Core 전문가로서 웹 API 및 마이크로서비스 개발에 풍부한 경험을 보유하고 있습니다.
            """
    };

    private readonly Speaker youngha_kim = new()
    {
        Id = nameof(youngha_kim),
        Name = "김영하",
        Title = "Developer",
        Bio = """
            ML.NET 전문가로서 .NET 환경에서의 머신러닝 구현에 대한 실무 경험을 가지고 있습니다.
            """
    };

    private readonly Speaker sungtae_jung = new()
    {
        Id = nameof(sungtae_jung),
        Name = "정성태",
        Title = "Developer",
        Bio = """
            .NET 17년 역사를 함께한 전문가로서 .NET Framework부터 .NET Core까지 깊이 있는 경험을 보유하고 있습니다.
            """,
        WebsiteUrl = "https://www.sysnet.pe.kr"
    };

    private readonly Speaker changhoon_kang = new()
    {
        Id = nameof(changhoon_kang),
        Name = "강창훈",
        Title = "Developer",
        Bio = """
            Azure LUIS 및 자연어 처리 전문가로서 AI 서비스와 .NET 통합에 대한 전문 지식을 가지고 있습니다.
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
            이 실습에서는 .NET Core 3 및 Infragistics 도구를 사용하여 대시 보드 UI 및 피벗 분석 UI를 빠르게 구축합니다.
            """,
        Speakers = [jason_beres, dahye_lee, satoru_yamaguchi],
        Format = SessionFormat.HandsOnLab,
        Duration = TimeSpan.FromMinutes(90),
        SlidesUrl = "https://github.com",
        Tags = [".NET Core 3", "Infragistics", "데이터 시각화"],
        Notes = ["Jason Beres님의 세션은 행사의 원활한 진행을 위하여 통역사 이다혜님께서 도움 주실 예정입니다."],
        Prerequisites = """
            • Visual Studio 2019 (16.3 이상) 설치
            • .NET Core 3.0 SDK 설치
            • Infragistics Ultimate Trial 라이선스 (현장에서 제공)
            """,
        LabModules = [
            new() { Title = "Lab 1: 프로젝트 설정 및 환경 구성", Url = "https://github.com/user/lab1", Description = "Infragistics 도구 설치 및 프로젝트 생성" },
            new() { Title = "Lab 2: 데이터 그리드 UI 구현", Url = "https://github.com/user/lab2", Description = "XamDataGrid를 활용한 데이터 표시" },
            new() { Title = "Lab 3: 피벗 분석 UI 구현", Url = "https://github.com/user/lab3", Description = "XamPivotGrid를 활용한 데이터 분석" },
            new() { Title = "Lab 4: 대시보드 구성", Url = "https://github.com/user/lab4", Description = "차트와 게이지를 활용한 시각화" }
        ]
    };

    private Session crossplatform_library => new()
    {
        Id = nameof(crossplatform_library),
        Title = "여러 .NET 구현과 플랫폼을 두루 지원하는 라이브러리 만들기",
        Abstract = """
            .NET Framework, .NET Core, Xamarin 등 다양한 .NET 구현체에서 
            동작하는 크로스 플랫폼 라이브러리를 만드는 방법을 알아봅니다.
            .NET Standard의 활용법과 플랫폼별 차이점 처리 방법을 다룹니다.
            """,
        Speakers = [minhui_hong],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        VideoUrl = "https://www.youtube.com",
        SlidesUrl = "https://speakerdeck.com",
        Tags = [".NET Standard", "Cross-platform", "Library"]
    };

    private Session async_programming => new()
    {
        Id = nameof(async_programming),
        Title = ".NET에서 비동기 프로그래밍 배우기",
        Abstract = """
            async/await 키워드를 활용한 비동기 프로그래밍의 기초부터 고급 패턴까지 다룹니다.
            Task, ValueTask, IAsyncEnumerable 등의 활용법과 
            비동기 코드에서 발생할 수 있는 일반적인 문제들과 해결 방법을 소개합니다.
            """,
        Speakers = [sungwon_moon],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        VideoUrl = "https://www.youtube.com",
        SlidesUrl = "https://www.slideshare.net",
        Tags = ["Async", "Await", "비동기"]
    };

    private Session healthcheck => new()
    {
        Id = nameof(healthcheck),
        Title = "ASP.NET Core를 통한 HealthCheck 서비스 구현",
        Abstract = """
            마이크로서비스 아키텍처에서 필수적인 헬스체크 서비스를 
            ASP.NET Core의 Health Checks 기능을 활용하여 구현하는 방법을 알아봅니다.
            데이터베이스, 외부 서비스, 캐시 등 다양한 의존성에 대한 헬스체크 구현 방법을 다룹니다.
            """,
        Speakers = [hongmin_kim],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        SlidesUrl = "https://www.slideshare.net",
        Tags = ["ASP.NET Core", "HealthCheck", "Microservices"]
    };

    private Session dotnet_history => new()
    {
        Id = nameof(dotnet_history),
        Title = "닷넷 17년의 변화 정리 및 닷넷 코어 3.0",
        Abstract = """
            2002년 .NET Framework 1.0 출시 이후 17년간의 .NET 역사를 돌아보고,
            .NET Core 3.0이 가져온 변화와 앞으로의 발전 방향을 소개합니다.
            .NET 5 통합 로드맵과 함께 .NET 생태계의 미래를 전망합니다.
            """,
        Speakers = [sungtae_jung],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        VideoUrl = "https://www.youtube.com",
        SlidesUrl = "https://www.sysnet.pe.kr",
        Tags = [".NET History", ".NET Core 3.0"]
    };

    #endregion

    #region Sessions - Room B

    private Session hol_supersocket => new()
    {
        Id = nameof(hol_supersocket),
        Title = "SuperSocket을 이용하여 .NET Core 플랫폼에서 고성능 TCP Socket 서버 만들기",
        Abstract = """
            SuperSocket 프레임워크를 활용하여 .NET Core에서 고성능 TCP 소켓 서버를 
            구축하는 방법을 배웁니다. 실시간 통신, 게임 서버, IoT 등 
            다양한 분야에서 활용할 수 있는 네트워크 프로그래밍 기법을 실습합니다.
            """,
        Speakers = [heungbae_choi],
        Format = SessionFormat.HandsOnLab,
        Duration = TimeSpan.FromMinutes(90),
        SlidesUrl = "https://docs.google.com",
        Tags = ["SuperSocket", ".NET Core", "TCP"],
        Prerequisites = """
            • Visual Studio 2019 또는 Visual Studio Code 설치
            • .NET Core 3.0 SDK 설치
            • TCP/IP 네트워크 기본 지식
            """,
        LabModules = [
            new() { Title = "Lab 1: SuperSocket 기본 설정", Url = "https://github.com/user/supersocket-lab1" },
            new() { Title = "Lab 2: 에코 서버 구현", Url = "https://github.com/user/supersocket-lab2" },
            new() { Title = "Lab 3: 프로토콜 커스터마이징", Url = "https://github.com/user/supersocket-lab3" }
        ]
    };

    private Session windows_desktop => new()
    {
        Id = nameof(windows_desktop),
        Title = ".NET Core 3.0과 Windows Desktop",
        Abstract = """
            .NET Core 3.0에서 새롭게 지원되는 WPF와 Windows Forms 개발에 대해 알아봅니다.
            기존 .NET Framework 앱을 .NET Core로 마이그레이션하는 방법과 
            새로운 기능들을 활용한 Windows 데스크톱 앱 개발 방법을 소개합니다.
            """,
        Speakers = [junghyun_nam],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        VideoUrl = "https://www.youtube.com",
        SlidesUrl = "https://1drv.ms",
        Tags = [".NET Core 3.0", "WPF", "WinForms"]
    };

    private Session csharp8 => new()
    {
        Id = nameof(csharp8),
        Title = "새로워진 C#: C# 8의 새로운 기능",
        Abstract = """
            C# 8.0에서 추가된 새로운 언어 기능들을 상세히 살펴봅니다.
            Nullable Reference Types, Pattern Matching 개선, 
            Async Streams, Indices and Ranges 등 개발 생산성을 높여주는 기능들을 소개합니다.
            """,
        Speakers = [jongin_lee],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        VideoUrl = "https://www.youtube.com",
        SlidesUrl = "https://github.com",
        Tags = ["C# 8", "Nullable", "Pattern Matching"]
    };

    private Session automl => new()
    {
        Id = nameof(automl),
        Title = ".NET Core로 해보는 AutoML",
        Abstract = """
            ML.NET의 AutoML 기능을 활용하여 머신러닝 모델을 자동으로 생성하고 
            최적화하는 방법을 배웁니다. 데이터 전처리부터 모델 학습, 평가까지 
            전체 ML 파이프라인을 코드 몇 줄로 구현하는 방법을 소개합니다.
            """,
        Speakers = [youngha_kim],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        VideoUrl = "https://www.youtube.com",
        SlidesUrl = "https://www.slideshare.net",
        Tags = ["ML.NET", "AutoML", "Machine Learning"]
    };

    private Session azure_luis => new()
    {
        Id = nameof(azure_luis),
        Title = "ML기반 자연어 처리 서비스 Azure LUIS .NET 어플리케이션으로 제어하고 통합하기",
        Abstract = """
            Azure의 Language Understanding (LUIS) 서비스를 활용하여 
            자연어 처리 기능을 .NET 애플리케이션에 통합하는 방법을 배웁니다.
            챗봇, 음성 인식 앱 등에서 활용할 수 있는 인텐트 분류와 엔티티 추출 기법을 다룹니다.
            """,
        Speakers = [changhoon_kang],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        VideoUrl = "https://www.youtube.com",
        SlidesUrl = "https://bit.ly",
        Tags = ["Azure LUIS", "NLP", "AI"]
    };

    #endregion

    #region Sessions - Shared

    private Session keynote => new()
    {
        Id = nameof(keynote),
        Title = "키노트",
        Abstract = """
            .NET Conf 2019 @ Seoul의 오프닝 키노트 세션입니다. 
            .NET Core 3.0의 출시와 함께 .NET 생태계의 새로운 방향성을 소개하고, 
            국내외 .NET 전문가들이 함께 모여 .NET의 미래에 대해 이야기합니다.
            Scott Hanselman의 특별 메시지와 함께 시작됩니다.
            """,
        Speakers = [younglak_choi, scott_hanselman, kijun_seo, jason_beres, dahye_lee, jungeun_cho, yohan_ko, junghyun_nam],
        Format = SessionFormat.Keynote,
        Duration = TimeSpan.FromMinutes(60),
        IsShared = true,
        VideoUrl = "https://www.youtube.com",
        SlidesUrl = "https://1drv.ms",
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
