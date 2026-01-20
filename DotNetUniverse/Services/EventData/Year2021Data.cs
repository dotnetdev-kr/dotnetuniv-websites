using DotNetUniverse.Models;
using DotNetUniverse.Models.Collections;

namespace DotNetUniverse.Services.EventData;

/// <summary>
/// 2021년 행사 데이터 - .NET Conf 2021 x Seoul
/// </summary>
public class Year2021Data : IEventData
{
    public string Slug => "2021";
    public int Year => 2021;
    public string ThemeColor => "#512bd4";
    public string ThemeColorClass => "primary";

    #region Speakers

    private readonly Speaker younglak_choi = new()
    {
        Id = nameof(younglak_choi),
        Name = "최영락",
        Title = "개발자 프로덕트 마케팅 매니저",
        Company = "한국마이크로소프트",
        Bio = "2018년부터 한국마이크로소프트 개발자 프로덕트 마케팅 매니저로 일하고 있습니다. 퓨즈툴스코리아, 휴레이포지티브, 나임네트웍스 등 역임. 오픈스택 한국 커뮤니티 운영진, 페이스북 디벨로퍼 써클 서울 리드.",
        ImageUrl = "/images/speakers/younglak_choi.png"
    };

    private readonly Speaker jason_beres = new()
    {
        Id = nameof(jason_beres),
        Name = "Jason Beres",
        Title = "Senior Vice President",
        Company = "Infragistics",
        Bio = "Infragistics에서 Senior Vice President로 일하고 있습니다. 혁신적이면서도 고객 중심의 사용자 경험을 Windows Forms, ASP.NET, 실버라이트, WPF, 그리고 자바 기반 제품에 반영하는 것을 목표로 합니다.",
        ImageUrl = "/images/speakers/jason_beres.png"
    };

    private readonly Speaker junghyun_nam = new()
    {
        Id = nameof(junghyun_nam),
        Name = "남정현",
        Title = "DevOps 엔지니어",
        Company = "데브시스터즈",
        Bio = "데브시스터즈 DevOps 엔지니어. Microsoft Azure MVP (2009~). 닷넷데브, 한국 WSL 사용자 그룹 운영진 활동.",
        ImageUrl = "/images/speakers/junghyun_nam.jpeg"
    };

    private readonly Speaker sanghyun_kim = new()
    {
        Id = nameof(sanghyun_kim),
        Name = "김상현",
        Title = "솔루션즈 아키텍트",
        Company = "Saiage Research",
        Bio = "Saiage Research에서 솔루션즈 아키텍트로 일하고 있습니다. 닷넷 기술에 관심이 많으며 현재 닷넷을 주 프레임워크로 사용하고 있습니다.",
        ImageUrl = "/images/speakers/sanghyun_kim.jpg"
    };

    private readonly Speaker heungbae_choi = new()
    {
        Id = nameof(heungbae_choi),
        Name = "최흥배",
        Title = "기술지원팀 팀장",
        Company = "Com2us",
        Bio = "Com2us 센트럴서버실 기술지원팀 팀장. Unity 소켓 통신 프로그래밍 전문가.",
        ImageUrl = "/images/speakers/heungbae_choi.png"
    };

    private readonly Speaker youngsu_son = new()
    {
        Id = nameof(youngsu_son),
        Name = "손영수",
        Title = "상무, 성능 분석 엔지니어",
        Company = "어니컴",
        Bio = "어니컴 상무, 성능 분석 엔지니어. 부하 테스트 기법 및 성능 분석 전문가.",
        ImageUrl = "/images/speakers/youngsu_son.jpeg"
    };

    private readonly Speaker jongin_lee = new()
    {
        Id = nameof(jongin_lee),
        Name = "이종인",
        Title = "Microsoft MVP",
        Company = "DesignMe AI",
        Bio = ".NET은 iOS 앱부터 ML.NET에 이르기까지 모든 곳에 갈 수 있습니다. Xamarin, Uno, MAUI 같은 .NET 크로스 플랫폼 앱 개발 전문가.",
        ImageUrl = "/images/speakers/jongin_lee.jpg"
    };

    private readonly Speaker seil_jung = new()
    {
        Id = nameof(seil_jung),
        Name = "정세일",
        Title = "Chief Technology Officer",
        Company = "MAUMIN Co.,Ltd.",
        Bio = "MAUMIN Co.,Ltd. CTO. 라즈베리파이 및 .NET을 이용한 볼링시스템 구축 경험 보유. Blazor Server 전문가.",
        ImageUrl = "/images/speakers/seil_jung.jpg"
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

    private readonly Speaker youngha_kim = new()
    {
        Id = nameof(youngha_kim),
        Name = "김영하",
        Title = "개발자",
        Company = "디플러스",
        Bio = "디플러스 소속으로 개발과 데이터를 다루고 있습니다. 계속 배우고 공유하는 것을 좋아합니다.",
        ImageUrl = "/images/speakers/youngha_kim.jpg"
    };

    private readonly Speaker yongjun_park = new()
    {
        Id = nameof(yongjun_park),
        Name = "박용준",
        Title = "대표",
        Company = "하와소",
        Bio = "Visual Studio 분야 Microsoft 공인 강사(MCT)를 거쳐 2006년부터 연속해서 Developer Technologies 분야 Microsoft MVP로 활동하고 있다. 현재는 하와소(hawaso.com) 대표로 소프트웨어 개발과 강의를 병행하고 있다.",
        ImageUrl = "/images/speakers/yongjun_park.jpg"
    };

    private readonly Speaker hyunmo_ahn = new()
    {
        Id = nameof(hyunmo_ahn),
        Name = "안현모",
        Title = "C# 웹 풀스택 개발자",
        Bio = "C# 웹 풀스택 개발자입니다. 읽기 좋은 코드와 라이브러리 개발에 관심이 많습니다. bluepope라는 닉네임으로 커뮤니티 활동을 하고 있습니다.",
        ImageUrl = "/images/speakers/hyunmo_ahn.jpg"
    };

    private readonly Speaker jungwoo_kim = new()
    {
        Id = nameof(jungwoo_kim),
        Name = "김정우",
        Title = "DevOps 엔지니어",
        Company = "클라우드메이트",
        Bio = "클라우드메이트 DevOps 엔지니어. 관심 분야: CNCF, C#, Dependency Injection, MSA, Database HA",
        ImageUrl = "/images/speakers/jungwoo_kim.jpg"
    };

    private readonly Speaker chanhyuk_ko = new()
    {
        Id = nameof(chanhyuk_ko),
        Name = "고찬혁",
        Title = "프로그래머",
        Company = "플라네타리움",
        Bio = "플라네타리움에서 블록체인 기반의 탈중앙 게임 엔진 Libplanet을 개발하고 있는 프로그래머입니다.",
        ImageUrl = "/images/speakers/chanhyuk_ko.png"
    };

    private readonly Speaker suho_lee = new()
    {
        Id = nameof(suho_lee),
        Name = "이수호",
        Title = "프로그래머",
        Company = "플라네타리움",
        Bio = "플라네타리움에서 블록체인 기반의 탈중앙 게임 엔진 Libplanet을 개발하고 있는 프로그래머입니다. F/OSS를 지지하며 분산화된 환경에서의 프로그래밍에 관심이 많습니다.",
        ImageUrl = "/images/speakers/suho_lee.jpeg"
    };

    private readonly Speaker john_juback = new()
    {
        Id = nameof(john_juback),
        Name = "John Juback",
        Title = "Product Architect of ComponentOne",
        Company = "GrapeCity",
        Bio = "GrapeCity에서 ComponentOne의 Product Architect로 일하고 있습니다. Electron.NET을 이용한 크로스 플랫폼 데스크톱 앱 개발 전문가.",
        ImageUrl = "/images/speakers/john_juback.png"
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

    private readonly Speaker brian_lagunas = new()
    {
        Id = nameof(brian_lagunas),
        Name = "Brian Lagunas",
        Title = "Senior Product Owner",
        Company = "Infragistics",
        Bio = "Microsoft MVP, Infragistics Senior Product Owner. Prism 프레임워크로 복합 XAML 응용 프로그램 구축 전문가.",
        ImageUrl = "/images/speakers/brian_lagunas.jpg"
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

    private readonly Speaker kihyuk_kim = new()
    {
        Id = nameof(kihyuk_kim),
        Name = "김기혁",
        Title = "개발자",
        Bio = "서비스 개발과 데이터 엔지니어링에 많은 관심을 가지고 있습니다. .NET for Apache Spark, .NET Runtime 프로젝트의 컨트리뷰터로 참여중입니다. SW Maestro 8기 수료.",
        ImageUrl = "/images/speakers/kihyuk_kim.jpg"
    };

    private readonly Speaker chequer_team = new()
    {
        Id = nameof(chequer_team),
        Name = "CHEQUER 팀",
        Title = "개발팀",
        Company = "CHEQUER",
        Bio = "김동우, 소현섭, 장유탁, 최진용 / CHEQUER. 크로스플랫폼 데스크탑 애플리케이션 QueryPie를 개발하며 겪은 기술적 문제와 .NET Core를 통해 해결한 경험을 공유합니다.",
        ImageUrl = "/images/speakers/chequer_team.jpg"
    };

    private readonly Speaker changhoon_kang = new()
    {
        Id = nameof(changhoon_kang),
        Name = "강창훈",
        Title = "대표",
        Company = "(주)엠소프트웨어",
        Bio = ".NET 개발 및 풀스택개발자(React.js/ASP.NET CORE/NODE). (주)엠소프트웨어 대표. .NET 5/웹/Full Stack 개발/강의/신기술 기반 솔루션 개발.",
        ImageUrl = "/images/speakers/changhoon_kang.jpg"
    };

    private readonly Speaker hongmin_kim = new()
    {
        Id = nameof(hongmin_kim),
        Name = "김홍민",
        Title = "산업기능요원",
        Company = "필라웨어",
        Bio = "현재 필라웨어에서 산업기능요원으로 재직하고 있으며, MLSA (Microsoft Learn Student Ambassadors)로 활동하고 있습니다. 닷넷을 이용하여 여러 클라이언트, 웹 어플리케이션을 개발하고 있습니다.",
        ImageUrl = "/images/speakers/hongmin_kim.jpg"
    };

    private readonly Speaker sungwon_moon = new()
    {
        Id = nameof(sungwon_moon),
        Name = "문성원",
        Title = "프로그래머",
        Bio = "게임을 위한 블록체인 라이브러리를 C#/.NET으로 만들고 있습니다.",
        ImageUrl = "/images/speakers/sungwon_moon.png"
    };

    private readonly Speaker gyuwon_lee = new()
    {
        Id = nameof(gyuwon_lee),
        Name = "이규원",
        Title = "개발자",
        Bio = "가끔 코딩도 하는 관리자입니다. 코딩이 더 재밌습니다.",
        ImageUrl = "/images/speakers/gyuwon_lee.jpg"
    };

    private readonly Speaker hayden = new()
    {
        Id = nameof(hayden),
        Name = "Hayden",
        Title = "클라우드 데이터 엔지니어",
        Bio = "클라우드 데이터 엔지니어로 활동하고 있으며, 서버리스 컴퓨팅, 데이터 웨어하우스, 서버리스 데이터 애널리틱스에 관심을 가지고 공부하고 있습니다."
    };

    public SpeakerCollection Speakers => SpeakerCollection.Create(
        younglak_choi, jason_beres, junghyun_nam, sanghyun_kim, heungbae_choi,
        youngsu_son, jongin_lee, seil_jung, justin_yoo, youngha_kim,
        yongjun_park, hyunmo_ahn, jungwoo_kim, chanhyuk_ko, suho_lee,
        john_juback, greg_lutz, brian_lagunas, sangman_park, kihyuk_kim,
        chequer_team, changhoon_kang, hongmin_kim, sungwon_moon, gyuwon_lee, hayden
    );

    #endregion

    #region Sessions - Day 1

    private Session keynote => new()
    {
        Id = nameof(keynote),
        Title = "키노트",
        Abstract = """
            20여년 역사를 가진 닷넷(.NET), 오픈소스 관점에서 보다 자세히 살펴보는 과거와 현재 그리고 미래를 
            이번 .NET Conf 2021 x Seoul을 통해 만나보셨으면 합니다.
            """,
        Speakers = [younglak_choi],
        Format = SessionFormat.Keynote,
        Duration = TimeSpan.FromMinutes(60),
        VideoUrl = "https://www.youtube.com/watch?v=RCH6bzwbhF0",
        SlidesUrl = "https://1drv.ms/b/s!Aj231qrFhIQxqdMp1FFXrAG9aNt5mA?e=EN9CqN",
        Tags = ["키노트", ".NET 5", "오픈소스"]
    };

    private Session keynote_sponsor => new()
    {
        Id = nameof(keynote_sponsor),
        Title = "모든 개발자들을 위해 준비된 닷넷 5",
        Abstract = """
            이번 세션에서는 닷넷 5가 닷넷 개발자를 포함한 모든 개발자들에게 어떤 청사진을 제시할 수 있는지를 보여주고, 
            Infragistics의 방향성과 비전을 닷넷 개발자 여러분들과 같이 공유하기 위한 내용을 준비하였습니다.
            """,
        Speakers = [jason_beres],
        Format = SessionFormat.Keynote,
        Duration = TimeSpan.FromMinutes(10),
        VideoUrl = "https://www.youtube.com/watch?v=tdsMjBuXaY0",
        SlidesUrl = "https://1drv.ms/p/s!Aj231qrFhIQxqcxenOdklsrg1KcZqA?e=5xi875",
        Tags = ["키노트", "Infragistics", ".NET 5"],
        Notes = ["스폰서, 영어"]
    };

    private Session raspberry_pi => new()
    {
        Id = nameof(raspberry_pi),
        Title = "라즈베리 파이에서 닷넷 개발 및 사례",
        Abstract = """
            라즈베리파이는 이제 .NET의 놀이터가 될 수 있습니다. 
            라즈베리파이 및 .NET을 이용해 볼링시스템을 구축한 경험을 여러분과 나눕니다.
            """,
        Speakers = [seil_jung],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        VideoUrl = "https://www.youtube.com/watch?v=Lzb7-sHz2es",
        SlidesUrl = "https://1drv.ms/p/s!Aj231qrFhIQxqdIcBGHSQplAXDgQAg?e=svDdju",
        Tags = ["Raspberry Pi", "IoT", ".NET"]
    };

    private Session blazor_server => new()
    {
        Id = nameof(blazor_server),
        Title = "블레이저 서버 소개 및 개발 사례",
        Abstract = """
            Blazor Server 및 Syncfusion Blazor를 이용한 시스템 개발 경험을 여러분과 나눕니다.
            """,
        Speakers = [seil_jung],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        VideoUrl = "https://www.youtube.com/watch?v=hFXm37_eSrg",
        SlidesUrl = "https://1drv.ms/p/s!Aj231qrFhIQxqdIa0OGSjT2ifNdrPg?e=gc82mg",
        Tags = ["Blazor Server", "Syncfusion", "Web"]
    };

    private Session source_generator => new()
    {
        Id = nameof(source_generator),
        Title = "소스 제너레이터로 정신 건강 챙기기",
        Abstract = """
            언제부턴가 각광을 받기 시작한 자동화 프로세스. 자동화 테스트, 자동화 빌드, 자동화 배포...
            이제 코드도 자동화 작성 시기가 오는걸까요? .NET 5에서 정식으로 포함된 Source Generator에 대해서 살펴봅니다.
            """,
        Speakers = [sanghyun_kim],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(50),
        VideoUrl = "https://www.youtube.com/watch?v=DjB2DfbcxgY",
        SlidesUrl = "https://1drv.ms/b/s!Aj231qrFhIQxqdMeDZZ64AyEyM1C2Q?e=CFdz3R",
        Tags = ["Source Generator", "C#", "코드 생성"]
    };

    private Session socket_programming => new()
    {
        Id = nameof(socket_programming),
        Title = "클라이언트 게임 개발자를 위한 소켓 프로그래밍 기초에서 활용까지",
        Abstract = """
            Unity는 현재 모바일 게임 개발에서 가장 많이 사용하고 있는 3D 엔진입니다. 
            Unity에서 소켓 통신 프로그래밍을 하기 위해 알아야할 지식과 실제 서버와 소켓 프로그래밍 할 수 있는 방법까지 설명합니다.
            """,
        Speakers = [heungbae_choi],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(60),
        VideoUrl = "https://www.youtube.com/watch?v=hcM_PReblyg",
        SlidesUrl = "https://1drv.ms/b/s!Aj231qrFhIQxqcxUu_fl9-8ELApumw?e=EbtiHc",
        Tags = ["Socket", "Unity", "네트워크"]
    };

    private Session performance_test => new()
    {
        Id = nameof(performance_test),
        Title = "클라우드 환경에서의 성능 테스트 기법",
        Abstract = "부하 테스트 기법 및 성능 분석 방법",
        Speakers = [youngsu_son],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        VideoUrl = "https://www.youtube.com/watch?v=Qqf9HOhyqes",
        SlidesUrl = "https://1drv.ms/b/s!Aj231qrFhIQxqdIfGJKeNvkqKyYbcw?e=tPpXpT",
        Tags = ["성능 테스트", "클라우드", "부하 테스트"],
        Notes = ["스폰서 세션"]
    };

    private Session crossplatform_app => new()
    {
        Id = nameof(crossplatform_app),
        Title = "닷넷으로 하는 크로스 플랫폼 앱 개발의 현재와 미래",
        Abstract = """
            .NET은 iOS 앱부터 ML.NET에 이르기까지 모든 곳에 갈 수 있습니다. 
            이 세션에서는 .NET 5가 나온 이 시점에서 Xamarin, Uno, MAUI 같은 .NET으로 크로스 플랫폼 앱을 개발하는 방법들에 대해 알아봅니다.
            """,
        Speakers = [jongin_lee],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(60),
        VideoUrl = "https://www.youtube.com/watch?v=WdssztHlPDI",
        SlidesUrl = "https://1drv.ms/b/s!Aj231qrFhIQxqdIiV4cyaPMW1AFk7Q?e=QPdgaV",
        Tags = ["Xamarin", "MAUI", "Uno", "크로스플랫폼"]
    };

    private Session azure_devops => new()
    {
        Id = nameof(azure_devops),
        Title = "애저 DevOps로 하는 닷넷 크로스 플랫폼 프로젝트 배포 자동화",
        Abstract = """
            .NET은 다재다능합니다. iOS, Android, Windows와 같은 클라이언트 뿐만 아니라 ASP.NET, Cloud, ML.NET과 같이 다양한 곳에서 개발할 수 있습니다. 
            Azure DevOps를 활용해 .NET으로 짠 코드를 쉽고 빠르게 배포할 수 있는 방법에 대해 살펴봅니다.
            """,
        Speakers = [jongin_lee],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        VideoUrl = "https://www.youtube.com/watch?v=iTYL4qrrN78",
        SlidesUrl = "https://1drv.ms/b/s!Aj231qrFhIQxqdVnRultug4qClPPSA?e=gc69gx",
        Tags = ["Azure DevOps", "CI/CD", "배포 자동화"]
    };

    private Session webforms_to_blazor => new()
    {
        Id = nameof(webforms_to_blazor),
        Title = "레거시 닷넷 웹 폼을 블레이저로 이전하면서 고려하면 좋을 것들",
        Abstract = """
            레거시 닷넷프레임워크의 웹폼을 쓰고 있는데, 닷넷5를 사용하는 블레이저로 이전하고 싶으신가요?
            웹폼과 블레이저의 공통점과 차이점, 그리고 웹폼에서 블레이저로 이전할 때 반드시 고려해야 할 부분에 대해 다뤄보도록 하겠습니다.
            """,
        Speakers = [justin_yoo],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        VideoUrl = "https://www.youtube.com/watch?v=WvIoKHUge1I",
        SlidesUrl = "https://1drv.ms/b/s!Aj231qrFhIQxqcw_w6ivI-pBWQqMvg?e=BM4sug",
        Tags = ["WebForms", "Blazor", "마이그레이션"]
    };

    private Session apache_spark => new()
    {
        Id = nameof(apache_spark),
        Title = "아파치 스파크용 닷넷 맛보기",
        Abstract = """
            .NET for Spark에 대해 설명하고, C#으로 Apache Spark programming을 해봅니다.
            docker 기반 로컬 개발환경 소개 및 시연, AWS EMR에 배포하는 과정까지 시연합니다.
            """,
        Speakers = [kihyuk_kim],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(30),
        VideoUrl = "https://www.youtube.com/watch?v=XCnv5rXDDsQ",
        SlidesUrl = "https://1drv.ms/p/s!Aj231qrFhIQxqcxBg8Zx9Y53R_yRZg?e=8wL1im",
        Tags = ["Apache Spark", "빅데이터", ".NET for Spark"]
    };

    private Session mlnet => new()
    {
        Id = nameof(mlnet),
        Title = "ML.NET으로 간단히 해보는 머신러닝",
        Abstract = """
            ML.NET 소개, 개발환경 구성, 두 가지 머신러닝 예제를 다룹니다.
            """,
        Speakers = [youngha_kim],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(50),
        VideoUrl = "https://www.youtube.com/watch?v=rJCeTkmd-iA",
        SlidesUrl = "https://1drv.ms/p/s!Aj231qrFhIQxqdgTYnYAxLATLHlAfg?e=9QAlZf",
        Tags = ["ML.NET", "머신러닝", "AI"]
    };

    private Session querypie => new()
    {
        Id = nameof(querypie),
        Title = "QueryPie를 지탱하는 .NET 기술",
        Abstract = """
            크로스플랫폼 데스크탑 애플리케이션 QueryPie를 개발하며 겪은 기술적 문제와 
            이를 .NET Core를 통해 해결해 가는 과정을 공유합니다.
            """,
        Speakers = [chequer_team],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(30),
        VideoUrl = "https://www.youtube.com/watch?v=-JV6mPpPHZk",
        SlidesUrl = "https://1drv.ms/b/s!Aj231qrFhIQxqdMb84dt-mXuMbO3zw?e=Ovs3EH",
        Tags = ["QueryPie", ".NET Core", "크로스플랫폼"]
    };

    private Session iac_pulumi => new()
    {
        Id = nameof(iac_pulumi),
        Title = "닷넷으로 시작하는 Infra as Code (IaC)",
        Abstract = """
            Pulumi는 Terraform과는 조금 다른 컨셉으로 만들어진 Infrastructure as Code (IaC) 자동화 도구입니다. 
            특히 C#을 사용하여 Azure, AWS, GCP는 물론 여러 클라우드와 쿠버네티스 클러스터 제어까지 할 수 있습니다.
            """,
        Speakers = [junghyun_nam],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        VideoUrl = "https://www.youtube.com/watch?v=-1bpKpKfGlg",
        SlidesUrl = "https://1drv.ms/b/s!Aj231qrFhIQxqdI8FPvGo35A-iwwsg?e=p7TSL0",
        Tags = ["Pulumi", "IaC", "인프라"]
    };

    private Session jupyter_csharp => new()
    {
        Id = nameof(jupyter_csharp),
        Title = "주피터 노트북으로 시작하는 C# 학습",
        Abstract = """
            주피터 노트북에서 C#을 사용할 수 있다는 사실, 알고 계셨나요? 
            이번 세션에서는 주피터 노트북에서 C#을 사용할 수 있는 방법을 소개하고, 
            주피터 노트북을 슬라이드로 만들어 발표하는 노하우까지 공유합니다.
            """,
        Speakers = [junghyun_nam],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(30),
        VideoUrl = "https://www.youtube.com/watch?v=EOruaiFGyUE",
        SlidesUrl = "https://1drv.ms/b/s!Aj231qrFhIQxqdMAK8kDoypB3fuzrg?e=zREIgk",
        Tags = ["Jupyter", "C#", "학습"]
    };

    private Session linqpad => new()
    {
        Id = nameof(linqpad),
        Title = "LINQPad, 어디까지 써봤니?",
        Abstract = """
            LINQPad를 이용하여 Visual Studio나 Rider 같은 IDE 없이도 강력하고 생산성 높은 코드 개발 환경을 체험해보세요.
            """,
        Speakers = [junghyun_nam],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(30),
        VideoUrl = "https://www.youtube.com/watch?v=Vn4ltabZGbc",
        SlidesUrl = "https://1drv.ms/b/s!Aj231qrFhIQxqdJqRV86lBt3sTfaMQ?e=lYDPQS",
        Tags = ["LINQPad", "생산성", "도구"]
    };

    private Session native_programming => new()
    {
        Id = nameof(native_programming),
        Title = "닷넷 5와 네이티브 프로그래밍",
        Abstract = """
            .NET Core 3.1 이후로 업데이트된 .NET의 네이티브 프로그래밍 기술과 여러 주변 동향 기술들에 대해 정리하여 소개해드리는 세션입니다.
            """,
        Speakers = [junghyun_nam],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(50),
        VideoUrl = "https://www.youtube.com/watch?v=GL_mz1Y_-Vk",
        SlidesUrl = "https://1drv.ms/b/s!Aj231qrFhIQxqdJTVDgol1dohJPHEA?e=8zrEE4",
        Tags = ["네이티브", "P/Invoke", "AOT"]
    };

    private Session bullseye => new()
    {
        Id = nameof(bullseye),
        Title = "Bullseye로 쉽게 만드는 의존성 로직",
        Abstract = """
            Bullseye라는 다소 생소하지만 흥미로운 라이브러리를 소개합니다. 
            순차적 프로그래밍이 아닌 의존성 기반의 프로그래밍을 통해 새로운 로직 패러다임을 적용해볼 수 있는 방법을 소개합니다.
            """,
        Speakers = [junghyun_nam],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(20),
        VideoUrl = "https://www.youtube.com/watch?v=9UwS3I5iUVY",
        SlidesUrl = "https://1drv.ms/b/s!Aj231qrFhIQxqdMOCBR1N6-wFCV3Yg?e=SFpvub",
        Tags = ["Bullseye", "빌드", "의존성"]
    };

    private Session signalr => new()
    {
        Id = nameof(signalr),
        Title = "SignalR 기반 실시간 협업 시스템 구축 사례 소개",
        Abstract = """
            .NET 5 실시간 웹 메시징 기술 SignalR 소개, SignalR Redis Backplane 분산 웹 메시징 시스템 구현 소개, 
            SignalR 기반 실시간 협업 시스템 구축 사례 소개.
            """,
        Speakers = [changhoon_kang],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(50),
        VideoUrl = "https://www.youtube.com/watch?v=bIEO28qWgT0",
        SlidesUrl = "https://1drv.ms/b/s!Aj231qrFhIQxqdMhQYrJ-kbEYIEwvw?e=8ExgYC",
        Tags = ["SignalR", "실시간", "Redis"]
    };

    private Session async_enumerable => new()
    {
        Id = nameof(async_enumerable),
        Title = "당김 기반 비동기 스트림 - IAsyncEnumerable<T>",
        Abstract = """
            C# 8.0에 추가된 IAsyncEnumerable<T> 인터페이스와 C#의 지원은 당김 기반(pull-based) 비동기 스트림을 쉽게 만들고 사용할 수 있게 도와줍니다.
            """,
        Speakers = [gyuwon_lee],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        VideoUrl = "https://www.youtube.com/watch?v=cs2qsnbYFUc",
        SlidesUrl = "https://1drv.ms/p/s!Aj231qrFhIQxqdM59W4G_BXddYB2Kg?e=JHnAHR",
        Tags = ["IAsyncEnumerable", "비동기", "스트림"]
    };

    private Session yarp => new()
    {
        Id = nameof(yarp),
        Title = "YARP를 이용한 리버스 프록시 서버 구축",
        Abstract = """
            YARP(Yet Another Reverse Proxy)는 쉽고 빠르게 프록시 서버를 구축할 수 있는 리버스 프록시 도구입니다. 
            기본적인 소개와 더불어 몇 가지 시나리오를 소개합니다.
            """,
        Speakers = [hongmin_kim],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(30),
        VideoUrl = "https://www.youtube.com/watch?v=YrmE9aNGRaE",
        SlidesUrl = "https://1drv.ms/b/s!Aj231qrFhIQxqdM7TdjqYWPDh9wvPA?e=6c0g58",
        Tags = ["YARP", "리버스 프록시", "네트워크"]
    };

    private Session cli_app => new()
    {
        Id = nameof(cli_app),
        Title = "닷넷 5로 (다시) 만들어보는 CLI 애플리케이션",
        Abstract = """
            .NET 5에 추가된 여러 기능들을 활용하여, 보다 현대적인 방법으로 CLI 애플리케이션을 작성하는 방법을 살펴봅니다.
            """,
        Speakers = [sungwon_moon],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(30),
        VideoUrl = "https://www.youtube.com/watch?v=yx3_LluUHXY",
        SlidesUrl = "https://1drv.ms/b/s!Aj231qrFhIQxqdMoRifrGyRXoMdgJA?e=65xX6Q",
        Tags = ["CLI", "Console", ".NET 5"]
    };

    private Session fsharp5 => new()
    {
        Id = nameof(fsharp5),
        Title = "닷넷 5 와 F# 5, 그리고 해외 .NET 커뮤니티",
        Abstract = """
            .NET 5와 F# 5의 주요 기능에 대해 알아보고, 해외 닷넷 커뮤니티의 동향에 대한 이야기를 전합니다.
            """,
        Speakers = [hayden],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(30),
        VideoUrl = "https://www.youtube.com/watch?v=fOHaJd24f1Q",
        Tags = ["F#", ".NET 5", "커뮤니티"]
    };

    private Session dapper => new()
    {
        Id = nameof(dapper),
        Title = "Dapper를 이용한 ORM 활용",
        Abstract = """
            Micro ORM 프레임워크인 Dapper를 이용하여 쉽고 빠르게 데이터베이스 프로그래밍을 시작할 수 있는 방법을 소개합니다.
            """,
        Speakers = [hyunmo_ahn],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(30),
        VideoUrl = "https://www.youtube.com/watch?v=KBaqHJif9Hc",
        Tags = ["Dapper", "ORM", "데이터베이스"]
    };

    private Session microservices => new()
    {
        Id = nameof(microservices),
        Title = "닷넷과 클라우드로 안정적인 마이크로 서비스 구현하기",
        Abstract = """
            부하 분산, 고가용성, 운영&성능 효율성을 모두 고려한다면 Azure Serverless가 좋은 솔루션이 될 수 있습니다.
            Azure Serverless를 활용하여 다량의 요청을 처리할 수 있는 마이크로 서비스를 .NET으로 구현했던 경험을 공유합니다.
            """,
        Speakers = [jungwoo_kim],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(30),
        VideoUrl = "https://www.youtube.com/watch?v=7wZlKmmTDaA",
        SlidesUrl = "https://1drv.ms/p/s!Aj231qrFhIQxqdV6LQB20jxdXfqWbA?e=QXCAy1",
        Tags = ["Azure Serverless", "마이크로서비스", "클라우드"],
        Notes = ["스폰서 세션"]
    };

    private Session nat_traversal => new()
    {
        Id = nameof(nat_traversal),
        Title = "NAT를 넘어서 가자",
        Abstract = """
            TURN서버를 이용한 NAT 통과 기법을 어떻게 .NET으로 구현했는지 간략하게 소개합니다.
            """,
        Speakers = [chanhyuk_ko],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(20),
        VideoUrl = "https://www.youtube.com/watch?v=NK5lxhwt8Nc",
        Tags = ["NAT", "TURN", "네트워크"]
    };

    private Session ilgpu => new()
    {
        Id = nameof(ilgpu),
        Title = "ILGPU로 시작하는 GPGPU 프로그래밍",
        Abstract = """
            ILGPU라는 JIT 컴파일러는 네이티브 의존성 없이 .NET으로만 이루어져 있다는 장점 이외에도 
            CUDA급의 성능과 C++ AMP 편리성을 제공합니다. ILGPU의 간단한 설명과 함께 예제를 소개합니다.
            """,
        Speakers = [suho_lee],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(30),
        VideoUrl = "https://www.youtube.com/watch?v=TUs_Jsy7_Sg",
        SlidesUrl = "https://1drv.ms/p/s!Aj231qrFhIQxqdIX-Nh-tfCS73JAAA?e=QHXcqX",
        Tags = ["ILGPU", "GPGPU", "GPU"]
    };

    private Session electron_dotnet => new()
    {
        Id = nameof(electron_dotnet),
        Title = "일렉트론 닷넷을 이용한 크로스 플랫폼 데스크톱 앱 개발",
        Abstract = """
            ASP.NET Core 어플리케이션을 Electron.NET을 이용하여 윈도우, 리눅스, 맥에서 동작하는 네이티브 어플리케이션을 개발하는 방법을 공유합니다.
            """,
        Speakers = [john_juback],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(30),
        VideoUrl = "https://www.youtube.com/watch?v=I0MxOB9BX-U",
        SlidesUrl = "https://1drv.ms/b/s!Aj231qrFhIQxqdInSShJ5ynwDkedOw?e=KRw0gX",
        Tags = ["Electron.NET", "크로스플랫폼", "데스크톱"],
        Notes = ["스폰서 세션, 영어"]
    };

    private Session migration_dotnet5 => new()
    {
        Id = nameof(migration_dotnet5),
        Title = "닷넷 프레임워크에서 닷넷 5로 마이그레이션 하기",
        Abstract = """
            기존에 .NET Framework로 개발된 데스크톱 어플리케이션을 .NET 5로 쉽게 업그레이드 하는 방법을 알아봅니다.
            """,
        Speakers = [greg_lutz],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(30),
        VideoUrl = "https://www.youtube.com/watch?v=JKkSYOlkbxs",
        SlidesUrl = "https://1drv.ms/b/s!Aj231qrFhIQxqdIl5dkid-w33OQYig?e=2pemUq",
        Tags = [".NET Framework", ".NET 5", "마이그레이션"],
        Notes = ["스폰서 세션, 영어"]
    };

    private Session prism => new()
    {
        Id = nameof(prism),
        Title = "프리즘으로 합성 XAML 애플리케이션 만들기",
        Abstract = """
            컴포넌트를 사용하여 전체 응용 프로그램에 쉽고 원활하게 통합할 수 있는 WPF 데스크톱 응용 프로그램을 디자인하고 빌드하는 방법을 배웁니다.
            Prism 프레임워크로 복합 응용 프로그램을 구축하는 데 필요한 기본 개념에 중점을 둡니다.
            """,
        Speakers = [brian_lagunas],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        VideoUrl = "https://www.youtube.com/watch?v=5Mitsg9D5Ok",
        Tags = ["Prism", "WPF", "XAML"],
        Notes = ["스폰서 세션, 영어"]
    };

    private Session akka_net => new()
    {
        Id = nameof(akka_net),
        Title = "AKKA.NET - 닷넷 코어 API와 AKKA의 만남",
        Abstract = """
            닷넷코어 API에 메시징 큐 (AKKA.NET)를 탑재하고 활용하는 방법에 대해서 설명합니다.
            """,
        Speakers = [sangman_park],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        VideoUrl = "https://www.youtube.com/watch?v=BzTAdSxtrq0",
        SlidesUrl = "https://1drv.ms/p/s!Aj231qrFhIQxqdIVLpxdNbFxYAXMow?e=ehVD9E",
        Tags = ["AKKA.NET", "Actor Model", "메시징"]
    };

    private Session csharp9 => new()
    {
        Id = nameof(csharp9),
        Title = "C# 9.0의 새로운 기능 소개",
        Abstract = "이 세션에서는 C# 9.0의 새로운 기능을 상세하게 살펴봅니다.",
        Speakers = [yongjun_park],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(70),
        VideoUrl = "https://www.youtube.com/watch?v=rtzmRgfyITw",
        SlidesUrl = "https://1drv.ms/p/s!Aj231qrFhIQxqcxJQlBtc2mZW4dXrA?e=mTCe8B",
        Tags = ["C# 9", "Record", "Pattern Matching"]
    };

    private Session tye => new()
    {
        Id = nameof(tye),
        Title = "닷넷 개발자를 위한 클라우드 네이티브, Tye",
        Abstract = """
            닷넷으로 클라우드 네이티브 기반의 애플리케이션을 개발할 때 기존에는 다루기 까다로웠던 멀티 프로젝트 애플리케이션은 물론, 
            컨테이너 오케스트레이션 기반의 개발 환경, 로그 수집, 분산 추적까지 지원하는 새로운 오픈소스 도구인 Tye에 대해 알아봅니다.
            """,
        Speakers = [junghyun_nam],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(50),
        VideoUrl = "https://www.youtube.com/watch?v=CZzZ0RWAp2M",
        SlidesUrl = "https://1drv.ms/b/s!Aj231qrFhIQxqdgkuZPgwp8zXrVAcw?e=Ec8Ldv",
        Tags = ["Tye", "클라우드 네이티브", "마이크로서비스"]
    };

    private Session nullable_switch => new()
    {
        Id = nameof(nullable_switch),
        Title = "갈림길 인지 - nullable 참조 형식과 switch 식",
        Abstract = """
            코딩은 때론 간편해야 하기도 때론 꼼꼼해야 하기도 합니다. 
            C#의 nullable 참조 형식과 switch 식이 프로그래머에게 어떤 도움을 주는지 얘기합니다.
            """,
        Speakers = [gyuwon_lee],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        VideoUrl = "https://www.youtube.com/watch?v=g-SXdtF7k3c",
        SlidesUrl = "https://1drv.ms/p/s!Aj231qrFhIQxqdg37-NBvODclmSj8w?e=FtkQen",
        Tags = ["Nullable", "switch 식", "C#"]
    };

    #endregion

    #region Tracks

    private Track main => new()
    {
        Id = nameof(main),
        Name = "메인 트랙",
        Color = "#512bd4",
        Sessions = SessionCollection.Create(
            keynote, keynote_sponsor, raspberry_pi, blazor_server, source_generator,
            socket_programming, performance_test, crossplatform_app, azure_devops, webforms_to_blazor,
            apache_spark, mlnet, querypie, iac_pulumi, jupyter_csharp, linqpad,
            native_programming, bullseye, signalr, async_enumerable, yarp, cli_app,
            fsharp5, dapper, microservices, nat_traversal, ilgpu, electron_dotnet,
            migration_dotnet5, prism, akka_net, csharp9, tye, nullable_switch
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
        LogoUrl = "/images/sponsors/2021/microsoft.png"
    };

    private readonly Sponsor cloudmate = new()
    {
        Id = nameof(cloudmate),
        Name = "클라우드메이트",
        Tier = SponsorTier.Gold,
        WebsiteUrl = "https://cloudmt.co.kr/",
        LogoUrl = "/images/sponsors/2021/cloudmate.png"
    };

    private readonly Sponsor infragistics = new()
    {
        Id = nameof(infragistics),
        Name = "Infragistics",
        Tier = SponsorTier.Gold,
        WebsiteUrl = "https://www.infragistics.com/",
        LogoUrl = "/images/sponsors/2021/infragistics.png"
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
        LogoUrl = "/images/sponsors/2021/jetbrains.png"
    };

    private readonly Sponsor onycom = new()
    {
        Id = nameof(onycom),
        Name = "ONYCOM",
        Tier = SponsorTier.Silver,
        WebsiteUrl = "http://www.onycom.com/",
        LogoUrl = "/images/sponsors/2021/onycom.gif"
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
        Title = ".NET Conf 2021 x Seoul",
        Theme = "하나의 닷넷을 이야기합니다",
        Description = """
            COVID-19로 인해 100% 온라인으로 진행된 .NET Conf 2021 x Seoul은 2021년 1월 15일부터 17일까지 3일간 
            닷넷데브 YouTube 채널을 통해 진행되었습니다. 이제 닷넷은 공식적으로 윈도우, 리눅스, 맥은 물론, 
            모바일, 클라우드, 머신러닝, 웹 어셈블리, 에지 컴퓨팅을 모두 지원하는 완전한 크로스 플랫폼 기술로서 거듭났습니다.
            닷넷 5 출시에 맞추어 "하나의 닷넷"을 이야기하며, 34개의 세션과 26명의 연사가 함께했습니다.
            """,
        Date = new DateTime(2021, 1, 15, 10, 0, 0),
        Type = EventType.Online,
        AttendeeCount = 500,
        HeroImageUrl = "/images/events/2021-hero.webp",
        Venues = VenueCollection.Create(online),
        Sponsors = SponsorCollection.Create(
            microsoft, cloudmate, infragistics, grapecity, jetbrains, onycom
        )
    };

    public ScheduleGrid Schedule => new ScheduleGridBuilder()
        .ForDay(1)
        .AddTrack(main)

        // Day 1 - 2021년 1월 15일 금요일
        .AddTimeSlot(new TimeOnly(10, 0), 60, slot => slot
            .At(0, keynote))
        .AddTimeSlot(new TimeOnly(11, 0), 10, slot => slot
            .At(0, keynote_sponsor))
        .AddTimeSlot(new TimeOnly(11, 10), 40, slot => slot
            .At(0, raspberry_pi))
        .AddTimeSlot(new TimeOnly(11, 50), 40, slot => slot
            .At(0, blazor_server))
        .AddTimeSlot(new TimeOnly(12, 30), 50, slot => slot
            .At(0, source_generator))
        .AddTimeSlot(new TimeOnly(13, 20), 60, slot => slot
            .At(0, socket_programming))
        .AddTimeSlot(new TimeOnly(14, 20), 40, slot => slot
            .At(0, performance_test))
        .AddTimeSlot(new TimeOnly(15, 0), 60, slot => slot
            .At(0, crossplatform_app))
        .AddTimeSlot(new TimeOnly(16, 0), 40, slot => slot
            .At(0, azure_devops))
        .AddTimeSlot(new TimeOnly(16, 40), 40, slot => slot
            .At(0, webforms_to_blazor))

        .ForDay(2)
        .AddTrack(main)

        // Day 2 - 2021년 1월 16일 토요일
        .AddTimeSlot(new TimeOnly(10, 0), 30, slot => slot
            .At(0, apache_spark))
        .AddTimeSlot(new TimeOnly(10, 30), 50, slot => slot
            .At(0, mlnet))
        .AddTimeSlot(new TimeOnly(11, 20), 30, slot => slot
            .At(0, querypie))
        .AddTimeSlot(new TimeOnly(11, 50), 40, slot => slot
            .At(0, iac_pulumi))
        .AddTimeSlot(new TimeOnly(12, 30), 30, slot => slot
            .At(0, jupyter_csharp))
        .AddTimeSlot(new TimeOnly(13, 0), 30, slot => slot
            .At(0, linqpad))
        .AddTimeSlot(new TimeOnly(13, 30), 50, slot => slot
            .At(0, native_programming))
        .AddTimeSlot(new TimeOnly(14, 20), 20, slot => slot
            .At(0, bullseye))
        .AddTimeSlot(new TimeOnly(14, 40), 50, slot => slot
            .At(0, signalr))
        .AddTimeSlot(new TimeOnly(15, 30), 40, slot => slot
            .At(0, async_enumerable))
        .AddTimeSlot(new TimeOnly(16, 10), 30, slot => slot
            .At(0, yarp))
        .AddTimeSlot(new TimeOnly(16, 40), 30, slot => slot
            .At(0, cli_app))

        .ForDay(3)
        .AddTrack(main)

        // Day 3 - 2021년 1월 17일 일요일
        .AddTimeSlot(new TimeOnly(10, 0), 30, slot => slot
            .At(0, fsharp5))
        .AddTimeSlot(new TimeOnly(10, 30), 30, slot => slot
            .At(0, dapper))
        .AddTimeSlot(new TimeOnly(11, 0), 30, slot => slot
            .At(0, microservices))
        .AddTimeSlot(new TimeOnly(11, 30), 20, slot => slot
            .At(0, nat_traversal))
        .AddTimeSlot(new TimeOnly(11, 50), 30, slot => slot
            .At(0, ilgpu))
        .AddTimeSlot(new TimeOnly(12, 20), 30, slot => slot
            .At(0, electron_dotnet))
        .AddTimeSlot(new TimeOnly(12, 50), 30, slot => slot
            .At(0, migration_dotnet5))
        .AddTimeSlot(new TimeOnly(13, 20), 40, slot => slot
            .At(0, prism))
        .AddTimeSlot(new TimeOnly(14, 0), 40, slot => slot
            .At(0, akka_net))
        .AddTimeSlot(new TimeOnly(14, 40), 70, slot => slot
            .At(0, csharp9))
        .AddTimeSlot(new TimeOnly(15, 50), 50, slot => slot
            .At(0, tye))
        .AddTimeSlot(new TimeOnly(16, 40), 40, slot => slot
            .At(0, nullable_switch))

        .Build();
}
