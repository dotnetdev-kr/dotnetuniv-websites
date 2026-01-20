using DotNetUniverse.Models;
using DotNetUniverse.Models.Collections;

namespace DotNetUniverse.Services.EventData;

/// <summary>
/// 2024년 행사 데이터 (.NET Conf 2024 x Seoul)
/// </summary>
public class Year2024Data : IEventData
{
    public string Slug => "2024";
    public int Year => 2024;
    public string ThemeColor => "#6f42c1";
    public string ThemeColorClass => "purple";

    #region Speakers

    // Keynote
    private readonly Speaker sriwantha_attanayake = new()
    {
        Id = nameof(sriwantha_attanayake),
        Name = "Sriwantha Attanayake",
        Title = "Principal Solution Architect",
        Company = "Amazon Web Services Korea",
        Bio = "AWS Principal Solution Architect – Microsoft Technologies. 소프트웨어 엔지니어 출신으로 금융, 매뉴팩쳐링, 스타트업 등 다양한 업계의 경험을 지니고 있으며 Asia pacific 지역의 주요 행사에서 폭넓은 주제의 발표를 진행해왔습니다.",
        ImageUrl = "/images/speakers/sriwantha_attanayake.png"
    };

    // Opening/Closing
    private readonly Speaker nam_jeonghyun = new()
    {
        Id = nameof(nam_jeonghyun),
        Name = "남정현",
        Title = "Microsoft MVP",
        Company = "메가존클라우드",
        Bio = "2009년부터 마이크로소프트 MVP로 활동 중이며, 닷넷데브 운영자로 활동하고 있습니다. 메가존클라우드에서 소프트웨어 엔지니어로 일하고 있으며, 개발 업무 외에도 테크니컬 라이팅, 개발자를 위한 글쓰기 노하우 전수에도 많은 시간을 투자하고 있습니다.",
        ImageUrl = "/images/speakers/nam_jeonghyun.jpeg"
    };

    // Track 1 Speakers
    private readonly Speaker son_kwangrak = new()
    {
        Id = nameof(son_kwangrak),
        Name = "손광락",
        Title = "Solution Engineer",
        Company = "Couchbase",
        Bio = "카우치베이스 솔루션 엔지니어로 일하고 있으며, 3S 소프트 연구소장, 델 테크놀로지스 vArchitect, 시스코 컨설턴트로 일했었습니다. NoSQL, AI, 기계 학습, 거대 언어 모델 분야에 관심이 많습니다.",
        ImageUrl = "/images/speakers/son_kwangrak.jpeg"
    };

    private readonly Speaker kim_jungwoo = new()
    {
        Id = nameof(kim_jungwoo),
        Name = "김정우",
        Title = "서비스개발팀 리드",
        Company = "클라우드메이트",
        Bio = "클라우드메이트 서비스개발팀 리드로 일하고 있으며, 주로 .NET, Python, Go를 사용하여 서버, 클라이언트 앱을 개발하고 있으며, Cloud Native 기반의 애플리케이션을 개발하여 서비스 목적을 달성하는 데에 집중하고 있습니다.",
        ImageUrl = "/images/speakers/kim_jungwoo.png"
    };

    private readonly Speaker lee_sangjun = new()
    {
        Id = nameof(lee_sangjun),
        Name = "이상준",
        Title = "운영진",
        Company = "닷넷데브",
        Bio = "10년차 .NET 개발자로, .NET Dev에서 운영진을 맡고 있으며, 프로그래밍 언어 패턴과 사내 문화와 연결 짓는 이론을 좋아합니다.",
        ImageUrl = "/images/speakers/lee_sangjun.jpg"
    };

    private readonly Speaker lee_jongin = new()
    {
        Id = nameof(lee_jongin),
        Name = "이종인",
        Title = "Microsoft MVP",
        Company = "DesignMe AI",
        Bio = "마이크로소프트 MVP이며, DesignMe AI 제품을 개발하고 있습니다.",
        ImageUrl = "/images/speakers/lee_jongin.jpg"
    };

    // Track 2 Speakers
    private readonly Speaker choi_youngrak = new()
    {
        Id = nameof(choi_youngrak),
        Name = "최영락",
        Title = "Container Specialist",
        Company = "Amazon Web Services Korea",
        Bio = "Amazon Web Services Container Specialist",
        ImageUrl = "/images/speakers/choi_youngrak.jpg"
    };

    private readonly Speaker justin_yoo = new()
    {
        Id = nameof(justin_yoo),
        Name = "유저스틴",
        Title = "Senior Cloud Advocate",
        Company = "Microsoft",
        Bio = "마이크로소프트에서 시니어 클라우드 아드보캇으로 일하고 있습니다. 닷넷과 애저, 클라우드네이티브 애플리케이션 개발에 관심이 많습니다.",
        ImageUrl = "/images/speakers/justin_yoo.png"
    };

    private readonly Speaker kim_jungsun = new()
    {
        Id = nameof(kim_jungsun),
        Name = "김정선",
        Title = "대표컨설턴트",
        Company = "씨퀄로",
        Bio = "(주)씨퀄로 대표컨설턴트/이사로 재직 중이며, SQL Server 컨설턴트로 활동 중입니다. 2002년부터 Microsoft Data Platform MVP로 꾸준히 활동 중이며, SQL Server, .NET 솔루션을 개발하고 강의를 진행하고 있습니다.",
        ImageUrl = "/images/speakers/kim_jungsun.png"
    };

    private readonly Speaker lee_jonghoon = new()
    {
        Id = nameof(lee_jonghoon),
        Name = "이종훈",
        Title = "Developer",
        Company = "",
        Bio = "백엔드와 게임 분야에 관심이 있습니다.",
        ImageUrl = "/images/speakers/lee_jonghoon.jpg"
    };

    // Track 3 Speakers
    private readonly Speaker kim_jinseok = new()
    {
        Id = nameof(kim_jinseok),
        Name = "김진석",
        Title = "Microsoft MVP",
        Company = "KH시스템",
        Bio = "한국블레이저개발자모임(Blazor Korea)에서 대표를 맡고 있습니다.",
        ImageUrl = "/images/speakers/kim_jinseok.jpg"
    };

    private readonly Speaker park_hyunwoo = new()
    {
        Id = nameof(park_hyunwoo),
        Name = "박현우",
        Title = "Backend Developer",
        Company = "스파이더크래프트",
        Bio = "5년차 개발자이며, 스파이더크래프트에서 백엔드 개발자로 일하고 있습니다.",
        ImageUrl = "/images/speakers/park_hyunwoo.jpg"
    };

    private readonly Speaker kim_sanghyun = new()
    {
        Id = nameof(kim_sanghyun),
        Name = "김상현",
        Title = "CTO",
        Company = "썸아더플레이스",
        Bio = "마이크로소프트 MVP이며, 현재 썸아더플레이스에서 CTO로 일하고 있습니다. 현실적인 엔지니어링을 추구합니다.",
        ImageUrl = "/images/speakers/kim_sanghyun.jpeg"
    };

    private readonly Speaker moon_yeji = new()
    {
        Id = nameof(moon_yeji),
        Name = "문예지",
        Title = "Developer",
        Company = "썸아더플레이스",
        Bio = "현재 썸아더플레이스에서 .NET과 Uno를 사용해서 보이스챗 앱 Hug를 만들고 있습니다. 비즈니스에 민첩하게 대응가능한 유연한 설계에 관심이 있습니다.",
        ImageUrl = "/images/speakers/moon_yeji.jpg"
    };

    private readonly Speaker choi_heungbae = new()
    {
        Id = nameof(choi_heungbae),
        Name = "최흥배",
        Title = "게임 서버 개발",
        Company = "Com2us",
        Bio = "2003년부터 온라인 게임 서버 개발을 시작하여 지금까지 하고 있으며, 사이에 잠깐 게임 개발자 양성을 위한 교육 관련 일을 한 적도 있습니다. 현재는 Com2us에서 게임 서버 개발 지원, 채용, 교육, R&D 업무를 하고 있습니다.",
        ImageUrl = "/images/speakers/choi_heungbae.jpg"
    };

    // Track 4 Speakers (HOL)
    private readonly Speaker choi_byungjoo = new()
    {
        Id = nameof(choi_byungjoo),
        Name = "최병주",
        Title = "Senior Solution Architect",
        Company = "Elastic",
        Bio = "넥슨, 스마일게이트 등 게임 회사를 거쳐 국내 SI 에서 클라우드 아키텍트로 일했으며, 현재 엘라스틱에서 시니어 솔루션 아키텍트로 한국 고객들을 지원하고 있습니다.",
        ImageUrl = "/images/speakers/choi_byungjoo.jpg"
    };

    private readonly Speaker park_juyeon = new()
    {
        Id = nameof(park_juyeon),
        Name = "박주연",
        Title = "Specialist Solution Architect",
        Company = "Amazon Web Services Korea",
        Bio = "AWS Specialist Solution Architect",
        ImageUrl = "/images/speakers/park_juyeon.jpeg"
    };

    private readonly Speaker ryu_dongcheol = new()
    {
        Id = nameof(ryu_dongcheol),
        Name = "류동철",
        Title = "Partner Solutions Architect",
        Company = "Amazon Web Services Korea",
        Bio = "Amazon Web Services Korea, Partner Solutions Architect",
        ImageUrl = "/images/speakers/ryu_dongcheol.jpeg"
    };

    public SpeakerCollection Speakers => SpeakerCollection.Create(
        sriwantha_attanayake, nam_jeonghyun,
        son_kwangrak, kim_jungwoo, lee_sangjun, lee_jongin,
        choi_youngrak, justin_yoo, kim_jungsun, lee_jonghoon,
        kim_jinseok, park_hyunwoo, kim_sanghyun, moon_yeji, choi_heungbae,
        choi_byungjoo, park_juyeon, ryu_dongcheol
    );

    #endregion

    #region Sessions

    // Opening
    private Session opening => new()
    {
        Id = nameof(opening),
        Title = "개회사",
        Abstract = ".NET Conf 2024 x Seoul 개회사",
        Speakers = [nam_jeonghyun],
        Format = SessionFormat.Keynote,
        Duration = TimeSpan.FromMinutes(10),
        Topic = SessionTopic.General,
        Tags = ["Opening", "Keynote"]
    };

    // Keynote
    private Session keynote => new()
    {
        Id = nameof(keynote),
        Title = "AWS에서 .NET 애플리케이션 현대화",
        Abstract = "AWS에서 .NET 애플리케이션을 현대화하는 방법을 소개합니다. (영어 발표)",
        Speakers = [sriwantha_attanayake],
        Format = SessionFormat.Keynote,
        Duration = TimeSpan.FromMinutes(40),
        Topic = SessionTopic.Cloud,
        VideoUrl = "https://www.youtube.com/watch?v=Q4GfcT96JWo",
        Tags = ["AWS", ".NET", "Modernization"]
    };

    // Track 1 Sessions
    private Session couchbase_nosql => new()
    {
        Id = nameof(couchbase_nosql),
        Title = "쉽고 효율적인 개발을 위한 NoSQL 활용법, 카우치베이스",
        Abstract = "카우치베이스를 활용하여 쉽고 효율적인 NoSQL 개발을 하는 방법을 배웁니다.",
        Speakers = [son_kwangrak],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(50),
        Topic = SessionTopic.General,
        VideoUrl = "https://www.youtube.com/watch?v=A3Nh7S7UXAM",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/tree/main/2024/dotNetConf/couchbase.pdf",
        Tags = ["Couchbase", "NoSQL", "Database"]
    };

    private Session native_aot => new()
    {
        Id = nameof(native_aot),
        Title = "Native AOT와 Chiselled Ubuntu로 쉽고 빠르고 가볍게 배포하자",
        Abstract = "Native AOT와 Chiselled Ubuntu를 활용하여 경량 배포를 하는 방법을 배웁니다.",
        Speakers = [kim_jungwoo],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(30),
        Topic = SessionTopic.Cloud,
        VideoUrl = "https://www.youtube.com/watch?v=smnKJaQINpc",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/tree/main/2024/dotNetConf/nativeaot_ChiselledUbuntu.pptx",
        Tags = ["Native AOT", "Ubuntu", "Deployment"]
    };

    private Session reactive_extensions => new()
    {
        Id = nameof(reactive_extensions),
        Title = "데이터 마술사: LINQ의 친구 Reactive Extensions!",
        Abstract = "Reactive Extensions를 활용하여 데이터 처리를 하는 방법을 배웁니다.",
        Speakers = [lee_sangjun],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        Topic = SessionTopic.General,
        VideoUrl = "https://www.youtube.com/watch?v=nmfqfNEPNCg",
        SlidesUrl = "https://1drv.ms/p/s!Au3QF22QIfCXhsheeFCktgPjq-Minw",
        Tags = ["Reactive Extensions", "LINQ", "Rx"]
    };

    private Session semantic_kernel => new()
    {
        Id = nameof(semantic_kernel),
        Title = "Semantic Kernel로 만드는 LLM (OpenAI) 어플리케이션",
        Abstract = "Semantic Kernel을 활용하여 LLM 애플리케이션을 만드는 방법을 배웁니다.",
        Speakers = [lee_jongin],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(50),
        Topic = SessionTopic.AI,
        VideoUrl = "https://www.youtube.com/watch?v=Jd_m1-3tjIg",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/tree/main/2024/dotNetConf/semantic_kernel.pptx",
        Tags = ["Semantic Kernel", "OpenAI", "LLM"]
    };

    private Session tablecloth_deepdive => new()
    {
        Id = nameof(tablecloth_deepdive),
        Title = "식탁보 프로젝트 Deep Dive",
        Abstract = "식탁보 프로젝트의 심층 분석을 진행합니다.",
        Speakers = [nam_jeonghyun],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(50),
        Topic = SessionTopic.Desktop,
        VideoUrl = "https://www.youtube.com/watch?v=mz8kn_g4gWE",
        SlidesUrl = "https://1drv.ms/p/s!Aj231qrFhIQxquAfJpOsOOuec02HQw?e=OiFZpA",
        Tags = ["TableCloth", "Desktop", "Open Source"]
    };

    private Session bofs_tablecloth => new()
    {
        Id = nameof(bofs_tablecloth),
        Title = "BoFs: 식탁보 프로젝트",
        Abstract = "식탁보 프로젝트에 대한 Birds of Feather 세션입니다.",
        Speakers = [nam_jeonghyun],
        Format = SessionFormat.Panel,
        Duration = TimeSpan.FromMinutes(50),
        Topic = SessionTopic.Desktop,
        Tags = ["TableCloth", "BoFs", "Community"]
    };

    // Track 2 Sessions
    private Session aws_serverless => new()
    {
        Id = nameof(aws_serverless),
        Title = "AWS에서 서버리스 .NET 앱을 개발 및 활용하기",
        Abstract = "AWS에서 서버리스 .NET 애플리케이션을 개발하고 활용하는 방법을 배웁니다.",
        Speakers = [choi_youngrak],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(50),
        Topic = SessionTopic.Cloud,
        VideoUrl = "https://www.youtube.com/watch?v=C0QAB3jE8Yo",
        Tags = ["AWS", "Serverless", ".NET"]
    };

    private Session tablecloth_roadmap => new()
    {
        Id = nameof(tablecloth_roadmap),
        Title = "식탁보 (TableCloth) 프로젝트 현황과 향후 로드맵",
        Abstract = "식탁보 프로젝트의 현황과 향후 로드맵을 공유합니다.",
        Speakers = [nam_jeonghyun],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(50),
        Topic = SessionTopic.Desktop,
        VideoUrl = "https://www.youtube.com/watch?v=kfrm_KoC0j4",
        SlidesUrl = "https://1drv.ms/p/s!Aj231qrFhIQxquAdfH4vkTO_ki8FVQ?e=Fr24gQ",
        Tags = ["TableCloth", "Desktop", "Roadmap"]
    };

    private Session dotnet_aspire => new()
    {
        Id = nameof(dotnet_aspire),
        Title = ".NET Aspire - Cloud-Native 애플리케이션 개발의 동반자",
        Abstract = ".NET Aspire를 활용하여 Cloud-Native 애플리케이션을 개발하는 방법을 배웁니다.",
        Speakers = [justin_yoo],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(55),
        Topic = SessionTopic.Cloud,
        VideoUrl = "https://www.youtube.com/watch?v=nsxpnfmXmbI",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/tree/main/2024/dotNetConf/DotNetAspire.pdf",
        Tags = [".NET Aspire", "Cloud-Native", "Development"]
    };

    private Session efcore_query => new()
    {
        Id = nameof(efcore_query),
        Title = "Entity Framework Core 효율적인 쿼리 사용",
        Abstract = "Entity Framework Core에서 효율적으로 쿼리를 사용하는 방법을 배웁니다.",
        Speakers = [kim_jungsun],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(50),
        Topic = SessionTopic.General,
        VideoUrl = "https://www.youtube.com/watch?v=d-FCJemb8Wc",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/tree/main/2024/dotNetConf/efcore.pdf",
        Tags = ["Entity Framework Core", "Query", "Database"]
    };

    private Session blazor_mvvm => new()
    {
        Id = nameof(blazor_mvvm),
        Title = "Blazor with MVVM",
        Abstract = "Blazor에서 MVVM 패턴을 활용하는 방법을 배웁니다.",
        Speakers = [lee_jonghoon],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        Topic = SessionTopic.Web,
        VideoUrl = "https://www.youtube.com/watch?v=vQkycHdnlsQ",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/tree/main/2024/dotNetConf/blazormvvm.pptx",
        Tags = ["Blazor", "MVVM", "Web"]
    };

    private Session bofs_career => new()
    {
        Id = nameof(bofs_career),
        Title = "BoFs: 개발자 커리어 상담소",
        Abstract = "개발자 커리어에 대한 Birds of Feather 세션입니다.",
        Speakers = [justin_yoo, kim_jinseok],
        Format = SessionFormat.Panel,
        Duration = TimeSpan.FromMinutes(50),
        Topic = SessionTopic.General,
        Tags = ["Career", "BoFs", "Community"]
    };

    // Track 3 Sessions
    private Session blazor_lowcode => new()
    {
        Id = nameof(blazor_lowcode),
        Title = "Blazor도 LOW CODE처럼!",
        Abstract = "Blazor를 Low Code처럼 사용하는 방법을 배웁니다.",
        Speakers = [kim_jinseok],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(50),
        Topic = SessionTopic.Web,
        VideoUrl = "https://www.youtube.com/watch?v=JKMwgkCo1D0",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/tree/main/2024/dotNetConf/blazorlowcode.pdf",
        Tags = ["Blazor", "Low Code", "Web"]
    };

    private Session clean_architecture => new()
    {
        Id = nameof(clean_architecture),
        Title = "클린아키텍쳐로 이사가기",
        Abstract = "클린 아키텍처로 이전하는 방법을 배웁니다.",
        Speakers = [park_hyunwoo],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(55),
        Topic = SessionTopic.General,
        VideoUrl = "https://www.youtube.com/watch?v=G5s1ZQiPBv8",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/tree/main/2024/dotNetConf/clean_architecture.pptx",
        Tags = ["Clean Architecture", "Architecture", "Design"]
    };

    private Session someotherplace_strategy => new()
    {
        Id = nameof(someotherplace_strategy),
        Title = ".NET 8을 중심으로 선택한 썸아더플레이스의 서비스 기술 전략",
        Abstract = "썸아더플레이스에서 .NET 8을 중심으로 선택한 기술 전략을 공유합니다.",
        Speakers = [kim_sanghyun],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        Topic = SessionTopic.General,
        VideoUrl = "https://www.youtube.com/watch?v=M3gFxxvv0mQ",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/tree/main/2024/dotNetConf/strategy_of_someotherplace.pdf",
        Tags = [".NET 8", "Strategy", "Startup"]
    };

    private Session ios_to_dotnet => new()
    {
        Id = nameof(ios_to_dotnet),
        Title = "iOS 개발자가 해본 첫 .NET 앱 개발",
        Abstract = "iOS 개발자가 .NET으로 앱을 개발한 경험을 공유합니다.",
        Speakers = [moon_yeji],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        Topic = SessionTopic.Mobile,
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/tree/main/2024/dotNetConf/dotnetconf2024-yeji-ppt.pdf",
        Tags = ["iOS", ".NET", "Mobile"]
    };

    private Session thread_message => new()
    {
        Id = nameof(thread_message),
        Title = "닷넷에서의 스레드 메시지 전송",
        Abstract = ".NET에서 스레드 간 메시지 전송 방법을 배웁니다.",
        Speakers = [choi_heungbae],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(30),
        Topic = SessionTopic.General,
        VideoUrl = "https://www.youtube.com/watch?v=2Wm6to6yxds",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/tree/main/2024/dotNetConf/threadmessage.pptx",
        Tags = ["Threading", "Message", "Concurrency"]
    };

    private Session bofs_startup => new()
    {
        Id = nameof(bofs_startup),
        Title = "BoFs: 극초기 스타트업 리얼 스토리 AMA",
        Abstract = "극초기 스타트업의 리얼 스토리를 공유하는 AMA 세션입니다.",
        Speakers = [kim_sanghyun, moon_yeji],
        Format = SessionFormat.Panel,
        Duration = TimeSpan.FromMinutes(50),
        Topic = SessionTopic.General,
        Tags = ["Startup", "AMA", "Community"]
    };

    // Track 4 Sessions (HOL)
    private Session hol_elastic => new()
    {
        Id = nameof(hol_elastic),
        Title = "HOL: Elastic, AI-powered 옵저버빌리티 소개 & APM 핸즈온 워크샵",
        Abstract = "Elastic의 AI-powered 옵저버빌리티와 APM 핸즈온 워크샵입니다.",
        Speakers = [choi_byungjoo],
        Format = SessionFormat.HandsOnLab,
        Duration = TimeSpan.FromMinutes(150),
        Topic = SessionTopic.DevOps,
        VideoUrl = "https://www.youtube.com/watch?v=uTnoBwoC2fY",
        Tags = ["Elastic", "Observability", "APM"]
    };

    private Session dotnet_on_aws => new()
    {
        Id = nameof(dotnet_on_aws),
        Title = ".NET on AWS (AWS에서 .NET 애플리케이션 개발, 테스트 및 배포하기)",
        Abstract = "AWS에서 .NET 애플리케이션을 개발, 테스트, 배포하는 방법을 배웁니다.",
        Speakers = [park_juyeon],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(50),
        Topic = SessionTopic.Cloud,
        VideoUrl = "https://www.youtube.com/watch?v=VtDQOEmVCdQ",
        Tags = ["AWS", ".NET", "Deployment"]
    };

    private Session hol_aws_aiml => new()
    {
        Id = nameof(hol_aws_aiml),
        Title = "HOL: AWS의 AI/ML 서비스를 사용하여 .NET 애플리케이션을 빌드하는 방법",
        Abstract = "AWS의 AI/ML 서비스를 활용하여 .NET 애플리케이션을 빌드하는 핸즈온 세션입니다.",
        Speakers = [ryu_dongcheol],
        Format = SessionFormat.HandsOnLab,
        Duration = TimeSpan.FromMinutes(90),
        Topic = SessionTopic.AI,
        VideoUrl = "https://www.youtube.com/watch?v=aSmpiM6vxao",
        Tags = ["AWS", "AI/ML", ".NET"]
    };

    private Session bofs_aws => new()
    {
        Id = nameof(bofs_aws),
        Title = "BoFs: AWS에 관해 무엇이든 물어보세요",
        Abstract = "AWS에 관한 모든 질문을 받는 Birds of Feather 세션입니다.",
        Speakers = [ryu_dongcheol],
        Format = SessionFormat.Panel,
        Duration = TimeSpan.FromMinutes(50),
        Topic = SessionTopic.Cloud,
        Tags = ["AWS", "AMA", "Community"]
    };

    // Closing
    private Session closing => new()
    {
        Id = nameof(closing),
        Title = "마무리",
        Abstract = ".NET Conf 2024 x Seoul 마무리",
        Speakers = [nam_jeonghyun],
        Format = SessionFormat.PrizeDrawing,
        Duration = TimeSpan.FromMinutes(30),
        Topic = SessionTopic.General,
        Tags = ["Closing", "Prize"]
    };

    #endregion

    #region Tracks

    private Track track1 => new()
    {
        Id = nameof(track1),
        Name = "트랙 1",
        Color = "#6f42c1",
        Sessions = SessionCollection.Create(
            couchbase_nosql, native_aot, reactive_extensions,
            semantic_kernel, tablecloth_deepdive, bofs_tablecloth
        )
    };

    private Track track2 => new()
    {
        Id = nameof(track2),
        Name = "트랙 2",
        Color = "#0d6efd",
        Sessions = SessionCollection.Create(
            aws_serverless, tablecloth_roadmap, dotnet_aspire,
            efcore_query, blazor_mvvm, bofs_career
        )
    };

    private Track track3 => new()
    {
        Id = nameof(track3),
        Name = "트랙 3",
        Color = "#198754",
        Sessions = SessionCollection.Create(
            blazor_lowcode, clean_architecture, someotherplace_strategy,
            ios_to_dotnet, thread_message, bofs_startup
        )
    };

    private Track track4 => new()
    {
        Id = nameof(track4),
        Name = "트랙 4 (HOL)",
        Color = "#dc3545",
        Sessions = SessionCollection.Create(
            dotnet_on_aws, hol_elastic, hol_aws_aiml, bofs_aws
        )
    };

    #endregion

    #region Sponsors

    private readonly Sponsor aws = new()
    {
        Id = nameof(aws),
        Name = "Amazon Web Services Korea",
        Tier = SponsorTier.Platinum,
        WebsiteUrl = "https://aws.amazon.com/",
        Description = "장소 및 식사 제공"
    };

    private readonly Sponsor couchbase = new()
    {
        Id = nameof(couchbase),
        Name = "Couchbase",
        Tier = SponsorTier.Gold,
        WebsiteUrl = "https://www.couchbase.com/"
    };

    private readonly Sponsor elastic = new()
    {
        Id = nameof(elastic),
        Name = "Elastic",
        Tier = SponsorTier.Gold,
        WebsiteUrl = "https://www.elastic.co/"
    };

    private readonly Sponsor blazor_korea = new()
    {
        Id = nameof(blazor_korea),
        Name = "한국블레이저개발자모임",
        Tier = SponsorTier.Community,
        Description = "커뮤니티 후원"
    };

    #endregion

    #region Venues

    private VenueInfo aws_office => new()
    {
        Id = nameof(aws_office),
        Name = "AWS Korea",
        Address = "서울시 강남구 테헤란로 231 센터필드 EAST TOWER 18F",
        Tracks = TrackCollection.Create(track1, track2, track3, track4)
    };

    #endregion

    public EventInfo Event => new()
    {
        Slug = Slug,
        Year = 2024,
        Title = ".NET Conf 2024 x Seoul",
        Theme = "Empowering Tomorrow: .NET 8 - Full Stack, AI Enhanced, Developer Focused",
        Description = "닷넷데브가 매년 개최하는 닷넷콘은 개발자 여러분들의 미래의 혁신을 하나로 묶어 나가며, 더욱 성공적인 개발자 커리어를 만들어나갈 수 있도록 매년 꾸준히 행사를 만들어나가고 있습니다. 이번 컨퍼런스는 AWS Korea의 지원 아래 열렸습니다.",
        Date = new DateTime(2024, 2, 21),
        Type = EventType.Offline,
        AttendeeCount = 200,
        HeroImageUrl = "/images/events/2024-hero.webp",
        Venues = VenueCollection.Create(aws_office),
        Sponsors = SponsorCollection.Create(aws, couchbase, elastic, blazor_korea)
    };

    public ScheduleGrid Schedule => new ScheduleGridBuilder()
        .ForDay(1)
        .AddTrack(track1)
        .AddTrack(track2)
        .AddTrack(track3)
        .AddTrack(track4)

        // 09:30 ~ 10:00 체크인
        .AddTimeSlot(new TimeOnly(9, 30), 30, slot => slot
            .At(0, new Session { Id = "checkin", Title = "체크인", Abstract = "", Format = SessionFormat.CheckIn, Duration = TimeSpan.FromMinutes(30), Speakers = [] }))

        // 10:00 ~ 10:10 개회사
        .AddTimeSlot(new TimeOnly(10, 0), 10, slot => slot
            .At(0, opening))

        // 10:10 ~ 10:50 Keynote
        .AddTimeSlot(new TimeOnly(10, 10), 40, slot => slot
            .At(0, keynote))

        // 11:00 ~ 11:50
        .AddTimeSlot(new TimeOnly(11, 0), 50, slot => slot
            .At(0, couchbase_nosql)
            .At(1, aws_serverless)
            .At(2, blazor_lowcode)
            .At(3, dotnet_on_aws))

        // 12:00 ~ 13:00 점심
        .AddTimeSlot(new TimeOnly(12, 0), 60, slot => slot
            .At(0, new Session { Id = "lunch", Title = "점심 식사", Abstract = "", Format = SessionFormat.Lunch, Duration = TimeSpan.FromMinutes(60), Speakers = [] }))

        // 13:00 ~ 13:50
        .AddTimeSlot(new TimeOnly(13, 0), 50, slot => slot
            .At(0, native_aot)
            .At(1, tablecloth_roadmap)
            .At(2, clean_architecture)
            .At(3, hol_elastic))

        // 14:00 ~ 14:50
        .AddTimeSlot(new TimeOnly(14, 0), 50, slot => slot
            .At(0, reactive_extensions)
            .At(1, dotnet_aspire)
            .At(2, someotherplace_strategy)
            .At(3, hol_elastic))

        // 15:00 ~ 15:50
        .AddTimeSlot(new TimeOnly(15, 0), 50, slot => slot
            .At(0, semantic_kernel)
            .At(1, efcore_query)
            .At(2, ios_to_dotnet)
            .At(3, hol_elastic))

        // 16:00 ~ 16:50
        .AddTimeSlot(new TimeOnly(16, 0), 50, slot => slot
            .At(0, tablecloth_deepdive)
            .At(1, blazor_mvvm)
            .At(2, thread_message)
            .At(3, hol_aws_aiml))

        // 17:00 ~ 17:50
        .AddTimeSlot(new TimeOnly(17, 0), 50, slot => slot
            .At(0, bofs_tablecloth)
            .At(1, bofs_career)
            .At(2, bofs_startup)
            .At(3, bofs_aws))

        // 18:00 ~ 18:30 마무리
        .AddTimeSlot(new TimeOnly(18, 0), 30, slot => slot
            .At(0, closing))

        .Build();
}
