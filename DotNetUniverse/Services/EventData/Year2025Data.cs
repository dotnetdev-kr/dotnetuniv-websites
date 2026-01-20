using DotNetUniverse.Models;
using DotNetUniverse.Models.Collections;

namespace DotNetUniverse.Services.EventData;

/// <summary>
/// 2025년 행사 데이터 (.NET Conf 2025 x Seoul)
/// </summary>
public class Year2025Data : IEventData
{
    public string Slug => "2025";
    public int Year => 2025;
    public string ThemeColor => "#ffc107";
    public string ThemeColorClass => "warning";

    #region Speakers

    // 키노트
    private readonly Speaker yun_seokchon = new()
    {
        Id = nameof(yun_seokchon),
        Name = "윤석찬",
        Title = "수석 테크 에반젤리스트",
        Company = "Amazon Web Services",
        Bio = "윤석찬 AWS 수석 테크 에반젤리스트는 AWS에서 클라우드 기술 전파와 개발자들의 클라우드 활용을 지원하는 역할을 담당하고 있습니다. 웹 개발자로 투신해 스타트업 CTO, 오픈소스 커뮤니티 리더, IT 분야 블로거 등 다양한 역할을 수행해 오고 있습니다.",
        ImageUrl = "/images/speakers/yun_seokchon.png"
    };

    // 개회사/폐회사
    private readonly Speaker nam_jeonghyun = new()
    {
        Id = nameof(nam_jeonghyun),
        Name = "남정현",
        Title = "Microsoft MVP",
        Company = "메가존클라우드",
        Bio = "메가존클라우드에서 소프트웨어 엔지니어로 일하고 있습니다. 닷넷데브 운영진, 네이버 TCN 카페 운영진으로 활동하고 있으며, 마이크로소프트 MVP로 2009년부터 현재까지 계속 활동하고 있습니다.",
        ImageUrl = "/images/speakers/nam_jeonghyun.png"
    };

    // 트랙 1 스피커들
    private readonly Speaker kim_soonkeun = new()
    {
        Id = nameof(kim_soonkeun),
        Name = "김순근",
        Title = "Sr. Technical Account Manager",
        Company = "Amazon Web Services",
        Bio = "비주얼스튜디오 사용자 모임 시삽 및 Microsoft MVP로 활동하였으며, 안랩, 마이크로소프트, 스타트업을 거쳐 현재는 AWS에서 Sr. Technical Account Manager로 근무하고 있습니다.",
        ImageUrl = "/images/speakers/kim_soonkeun.jpeg"
    };

    private readonly Speaker sakamoto_junichi = new()
    {
        Id = nameof(sakamoto_junichi),
        Name = "사카모토 준이치",
        Title = "테크니컬 컨설턴트",
        Company = "Infragistics",
        Bio = "INFRAGISTICS 일본지사 테크니컬 컨설턴트로 일하고 있으며, 10년 이상 Microsoft MVP 어워드를 받았습니다. Blazor 지식 공유에 열정적이고 일본 홋카이도 사포로에 살고 있습니다.",
        ImageUrl = "/images/speakers/sakamoto_junichi.png"
    };

    private readonly Speaker son_kwangrak = new()
    {
        Id = nameof(son_kwangrak),
        Name = "손광락",
        Title = "Solution Engineer",
        Company = "Couchbase",
        Bio = "Couchbase 솔루션 엔지니어로 일하고 있으며, 3S Soft 연구소장, Dell Tech vArchitect, Cisco 컨설턴트, Sun Microsystems 컨설턴트로 일했었습니다.",
        ImageUrl = "/images/speakers/son_kwangrak.jpeg"
    };

    private readonly Speaker ryu_dongcheol = new()
    {
        Id = nameof(ryu_dongcheol),
        Name = "류동철",
        Title = "솔루션 아키텍트",
        Company = "Amazon Web Services",
        Bio = "류동철님은 Microsoft MVP 출신의 AWS 솔루션 아키텍트입니다. 다양한 Microsoft 워크로드 경험과 게임 업계에서의 실전 지식을 바탕으로, 현재 AWS에서 파트너와 고객들에게 Microsoft 기술 기반의 클라우드 솔루션을 제공하고 있습니다.",
        ImageUrl = "/images/speakers/ryu_dongcheol.jpeg"
    };

    private readonly Speaker han_youngbin = new()
    {
        Id = nameof(han_youngbin),
        Name = "한영빈",
        Title = "Backend Developer",
        Company = "안랩클라우드메이트",
        Bio = "안랩클라우드메이트에서 백엔드 개발자로 근무하고 있습니다. 우분투한국커뮤니티에서 운영진으로도 오랜 시간 활동 중이고, Ubuntu LoCo Council 및 UbuCon Asia 준비위원회에서도 활동하고 있습니다.",
        ImageUrl = "/images/speakers/han_youngbin.png"
    };

    private readonly Speaker jo_jangwon = new()
    {
        Id = nameof(jo_jangwon),
        Name = "조장원",
        Title = "기술팀 리드",
        Company = "",
        Bio = "스타트업에서 기술팀을 맡고 있으며 .NET 기술과 오픈소스, 로우코드에 기술에 관심이 많습니다.",
        ImageUrl = "/images/speakers/jo_jangwon.jpeg"
    };

    // 트랙 2 스피커들
    private readonly Speaker lee_sangjun = new()
    {
        Id = nameof(lee_sangjun),
        Name = "이상준",
        Title = "DevSecOps Engineer",
        Company = "게임회사",
        Bio = "게임회사에서 DevSecOps 팀에 소속되어 일하고 있으며, IT 지식에 두루 흥미를 갖고 있습니다.",
        ImageUrl = "/images/speakers/lee_sangjun.png"
    };

    private readonly Speaker ahn_hyunmo = new()
    {
        Id = nameof(ahn_hyunmo),
        Name = "안현모",
        Title = "풀스택 웹개발자",
        Company = "",
        Bio = "풀스택 웹개발자입니다. 주로 인하우스 시스템 개발을 진행하고 있습니다. 닷넷 생태계에 관심이 많으며, 가독성 좋고 유지보수하기 쉬운 코드를 작성하는데 중점을 두고 있습니다.",
        ImageUrl = "/images/speakers/ahn_hyunmo.jpg"
    };

    private readonly Speaker kim_junhyung = new()
    {
        Id = nameof(kim_junhyung),
        Name = "김준형",
        Title = "개발자",
        Company = "",
        Bio = "경남 창원의 어느 중소기업에서 19년 가까이 개발자로 근무하고 있습니다. 태양광 인버터, 풍력 발전 제어기, 에너지 저장장치 등을 주로 닷넷을 이용하여 개발하고 있습니다.",
        ImageUrl = "/images/speakers/kim_junhyung.png"
    };

    private readonly Speaker kim_jinseok = new()
    {
        Id = nameof(kim_jinseok),
        Name = "김진석",
        Title = "Microsoft MVP",
        Company = "",
        Bio = "안녕하세요. 김진석입니다. 2024년부터 Microsoft MVP로 활동하고 있습니다.",
        ImageUrl = "/images/speakers/kim_jinseok.png"
    };

    private readonly Speaker justin_yoo = new()
    {
        Id = nameof(justin_yoo),
        Name = "유저스틴",
        Title = "Developer Advocate",
        Company = "Microsoft",
        Bio = "마이크로소프트에서 Developer Advocate로 일하고 있습니다. 개발자의 생산성 향상을 위해 자나깨나 고민합니다.",
        ImageUrl = "/images/speakers/justin_yoo.png"
    };

    private readonly Speaker shim_yunsub = new()
    {
        Id = nameof(shim_yunsub),
        Name = "심윤섭",
        Title = "프론트엔드 개발자",
        Company = "",
        Bio = "프론트엔드 개발자이며, 닷넷데브 운영진으로 활동하고 있는 심윤섭입니다. ASP .NET, 특히 Blazor에 관심이 많습니다.",
        ImageUrl = "/images/speakers/shim_yunsub.png"
    };

    private readonly Speaker choi_heungbae = new()
    {
        Id = nameof(choi_heungbae),
        Name = "최흥배",
        Title = "센트럴서버실 실장",
        Company = "컴투스",
        Bio = "현재 컴투스 센트럴서버실 실장으로 일하고 있으며, 게임 서버 개발 지원, R&D, 교육 등의 업무를 담당하고 있습니다. 온라인 게임 서버 프로그래머로, 2003년부터 온라인 게임의 서버를 개발하고 있습니다.",
        ImageUrl = "/images/speakers/choi_heungbae.jpg"
    };

    // 트랙 3 스피커들
    private readonly Speaker park_sanghyun = new()
    {
        Id = nameof(park_sanghyun),
        Name = "박상현",
        Title = "시니어 소프트웨어 엔지니어",
        Company = "",
        Bio = "삼성탈레스와 한화시스템에서 무기 체계 SW를 개발해 왔습니다. 현재는 미국 소재 비공개 스타트업에서 시니어 소프트웨어 엔지니어로 근무하고 있습니다. \"이것이 C#이다\", \"이것이 자료구조+알고리즘이다 with C\"의 저자입니다.",
        ImageUrl = "/images/speakers/park_sanghyun.png"
    };

    private readonly Speaker kim_sanghyun = new()
    {
        Id = nameof(kim_sanghyun),
        Name = "김상현",
        Title = "CTO",
        Company = "SomeOtherPlace",
        Bio = "SomeOtherPlace에서 CTO로 일하고 있으며, Microsoft MVP로 2023년에 어워드를 받았습니다.",
        ImageUrl = "/images/speakers/kim_sanghyun.png"
    };

    private readonly Speaker kang_changhoon = new()
    {
        Id = nameof(kang_changhoon),
        Name = "강창훈",
        Title = "CEO/CTO",
        Company = "엠소프트웨어",
        Bio = "웹 메시징 솔루션 전문기업 엠소프트웨어 대표, 글로벌 융합기술정보제공 플랫폼 믹스드코드닷컴 운영, 비영리 IT교육 단체 지니공공아카데미 운영을 맡고 있습니다.",
        ImageUrl = "/images/speakers/kang_changhoon.png"
    };

    private readonly Speaker lee_jonghoon = new()
    {
        Id = nameof(lee_jonghoon),
        Name = "이종훈",
        Title = "툴 엔지니어",
        Company = "게임회사",
        Bio = "게임회사 툴 엔지니어이자 닷넷데브 운영진, GDG Songdo 운영진으로 활동하고 있습니다.",
        ImageUrl = "/images/speakers/lee_jonghoon.png"
    };

    private readonly Speaker choi_eunjeong = new()
    {
        Id = nameof(choi_eunjeong),
        Name = "최은정",
        Title = "개발자",
        Company = "SomeOtherPlace",
        Bio = "'SomeOtherPlace'라는 .NET과 C#으로 크로스플랫폼 모바일 애플리케이션을 개발하는 스타트업에서 1년 조금 넘게 근무하고 있습니다. 최근에는 서버 개발에도 참여하며 경험을 쌓고 있습니다.",
        ImageUrl = "/images/speakers/choi_eunjeong.jpeg"
    };

    private readonly Speaker kim_jungwoo = new()
    {
        Id = nameof(kim_jungwoo),
        Name = "김정우",
        Title = "개발팀 리드",
        Company = "안랩클라우드메이트",
        Bio = "안랩클라우드메이트에서 개발팀 리드로 일하고 있습니다. 소프트웨어 개발로 비즈니스 목표를 달성시키는 것만 바라보고 살고 있습니다.",
        ImageUrl = "/images/speakers/kim_jungwoo.png"
    };

    public SpeakerCollection Speakers => SpeakerCollection.Create(
        yun_seokchon, nam_jeonghyun,
        kim_soonkeun, sakamoto_junichi, son_kwangrak, ryu_dongcheol, han_youngbin, jo_jangwon,
        lee_sangjun, ahn_hyunmo, kim_junhyung, kim_jinseok, justin_yoo, shim_yunsub, choi_heungbae,
        park_sanghyun, kim_sanghyun, kang_changhoon, lee_jonghoon, choi_eunjeong, kim_jungwoo
    );

    #endregion

    #region Sessions

    // 키노트
    private Session keynote => new()
    {
        Id = nameof(keynote),
        Title = "닷넷 개발자들이 알아 두어야 할 AWS클라우드에 대한 모든 것",
        Abstract = "클라우드 기반 현대적 앱 개발은 필수적인 시대가 되었으며, 닷넷 개발자들이 AWS 클라우드를 잘 활용할 수 있는 길잡이 세션입니다. AWS의 빌딩 블록 원리와 함께 2024년 리인벤트에서 소개된 주요 빌딩 블록 신규 기능을 알아봅니다.",
        Speakers = [yun_seokchon],
        Format = SessionFormat.Keynote,
        Duration = TimeSpan.FromMinutes(40),
        Topic = SessionTopic.Cloud,
        VideoUrl = "https://www.youtube.com/watch?v=dRBJO82Nv_0",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/blob/main/2025/2025-channy.pdf",
        Tags = ["AWS", "Cloud", "Keynote"]
    };

    // 트랙 1 세션들
    private Session amazon_q_developer => new()
    {
        Id = nameof(amazon_q_developer),
        Title = "Amazon Q Developer로 .NET 앱 현대화하기",
        Abstract = "개발자를 위한 생성형 AI 서비스인 Amazon Q Developer를 이용해서 여러분의 개발 워크플로를 보다 빠르고 쉽고 안전하게 바꿀 수 있습니다.",
        Speakers = [kim_soonkeun],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        Topic = SessionTopic.Cloud,
        VideoUrl = "https://www.youtube.com/watch?v=1aj-nwTgduY",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/blob/main/2025/2025-kimsoonkeun.pdf",
        Tags = ["Amazon Q", "AI", "Modernization"]
    };

    private Session tablecloth_cloud => new()
    {
        Id = nameof(tablecloth_cloud),
        Title = "식탁보 클라우드 버전 개발 여정: 클라우드 중립적 개발",
        Abstract = "많은 분들께서 관심을 가지고 사랑해주시는 식탁보 프로젝트를 2024년 한 해 동안 클라우드 서비스 버전으로 만드는 작업을 진행했습니다.",
        Speakers = [nam_jeonghyun],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        Topic = SessionTopic.Desktop,
        VideoUrl = "https://www.youtube.com/watch?v=Fh3pKb3ZjPM",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/blob/main/2025/2025-namjeonghyun-tablecloth.pdf",
        Tags = ["TableCloth", "Cloud", "Desktop"]
    };

    private Session cloud_native_ui => new()
    {
        Id = nameof(cloud_native_ui),
        Title = ".NET 및 효율적인 UI 재구축을 통한 클라우드 네이티브 전환",
        Abstract = "레거시 애플리케이션을 현대화하려면 많은 고려 사항이 필요합니다. 이 세션에서는 최신 웹 클라이언트 앱의 UI를 다시 만드는 데 중점을 두고 이를 신속하게 수행할 수 있는 방법을 보여 드리겠습니다.",
        Speakers = [sakamoto_junichi],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        Topic = SessionTopic.Cloud,
        VideoUrl = "https://www.youtube.com/watch?v=o1AnCHu3mOs",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/blob/main/2025/2025-sakamotojunichi.pdf",
        Tags = ["Cloud Native", "UI", "Migration"]
    };

    private Session couchbase_ai => new()
    {
        Id = nameof(couchbase_ai),
        Title = "AI-Powered Application 개발을 위한 최적 데이터플랫폼, 카우치베이스",
        Abstract = "이 세션에서는 JSON Document NoSQL 데이터플랫폼과 카우치베이스를 소개하고, SQL 기반의 하이브리드 서치로 AI 기반의 애플리케이션 개발 방법을 소개합니다.",
        Speakers = [son_kwangrak],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        Topic = SessionTopic.Cloud,
        VideoUrl = "https://www.youtube.com/watch?v=uveeOCfr0XQ",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/blob/main/2025/2025-sonkwangrak.pdf",
        Tags = ["Couchbase", "NoSQL", "AI"]
    };

    private Session dotnet_on_aws => new()
    {
        Id = nameof(dotnet_on_aws),
        Title = "About .NET on AWS: 클라우드 네이티브 개발을 위한 AWS 도구 및 서비스 소개",
        Abstract = "AWS에서 .NET 개발을 위한 핵심 도구와 서비스를 소개합니다. Visual Studio용 AWS Toolkit, .NET용 AWS SDK 그리고 애플리케이션 마이그레이션 및 현대화 도구들을 살펴봅니다.",
        Speakers = [ryu_dongcheol],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        Topic = SessionTopic.Cloud,
        VideoUrl = "https://www.youtube.com/watch?v=dtH6tPwkB8s",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/blob/main/2025/2025-ryudongcheol.pdf",
        Tags = ["AWS", ".NET", "Cloud Native"]
    };

    private Session rockcraft => new()
    {
        Id = nameof(rockcraft),
        Title = "Rockcraft를 활용한 .NET 앱 컨테이너 빌드",
        Abstract = "Canonical에서 개발한 컨테이너 이미지 빌드 도구인 Rockcraft를 통해 .NET 앱 컨테이너 이미지를 만드는 방법에 대해 알아봅니다.",
        Speakers = [han_youngbin],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        Topic = SessionTopic.Cloud,
        VideoUrl = "https://www.youtube.com/watch?v=UoocvB_GvYs",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/blob/main/2025/2025-hanyoungbin.pdf",
        Tags = ["Rockcraft", "Container", "Ubuntu"]
    };

    private Session maui_guide => new()
    {
        Id = nameof(maui_guide),
        Title = ".NET MAUI 앱 개발 실전 가이드",
        Abstract = ".NET MAUI로 앱을 개발하려 마음먹었지만 막상 자료를 찾으려면 정보가 부족해 막막하셨나요? 인증, 권한 설정, 푸시 알림, 배포 같은 까다로운 주제부터 네이티브 바인딩, Supabase 연동까지!",
        Speakers = [jo_jangwon],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        Topic = SessionTopic.Mobile,
        VideoUrl = "https://www.youtube.com/watch?v=AkADqmi0KOg",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/blob/main/2025/2025-jojangwon.pdf",
        Tags = [".NET MAUI", "Mobile", "Guide"]
    };

    // 트랙 2 세션들
    private Session devsecops => new()
    {
        Id = nameof(devsecops),
        Title = "DotNetDevSecOps",
        Abstract = "9년차 .NET 개발자의 DevSecOps 전향기를 이야기해보려고 합니다.",
        Speakers = [lee_sangjun],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        Topic = SessionTopic.General,
        VideoUrl = "https://www.youtube.com/watch?v=fDaq8ghGyuE",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/blob/main/2025/2025-leesangjoon.pdf",
        Tags = ["DevSecOps", "Career", "Security"]
    };

    private Session sqlkata => new()
    {
        Id = nameof(sqlkata),
        Title = "SqlKata를 이용한 Query 관리 기법",
        Abstract = "SqlKata를 이용한 Query 관리 기법과 Dapper, EF ORM과의 차이점을 이해합니다.",
        Speakers = [ahn_hyunmo],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        Topic = SessionTopic.Web,
        VideoUrl = "https://www.youtube.com/watch?v=CM2_I24T8kM",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/blob/main/2025/2025-anhyeonmo.pdf",
        Tags = ["SqlKata", "Query", "Database"]
    };

    private Session gpu_heatmap => new()
    {
        Id = nameof(gpu_heatmap),
        Title = "GPU를 이용한 공간보간 Heat map 구현 사례 소개",
        Abstract = "SharpDX, ComputeSharp, ILGPU 등의 라이브러리를 이용하여 IDW 보간법을 GPU에서 수행하고, 그 결과를 화면에 표시하는 WPF 기반 Heat map을 구현한 경험을 소개합니다.",
        Speakers = [kim_junhyung],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        Topic = SessionTopic.Desktop,
        VideoUrl = "https://www.youtube.com/watch?v=Zm5M0Px0cKI",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/blob/main/2025/2025-kimjoonhyeong.pdf",
        Tags = ["GPU", "WPF", "Heat Map"]
    };

    private Session csharp_ai => new()
    {
        Id = nameof(csharp_ai),
        Title = "C#도 AI랑 이야기할 수 있어, Python만 되는 거 아니야",
        Abstract = "AI를 오케스트레이션 하는 Semantic Kernel에 대한 이야기를 해봅니다. C#은 이 분야에서 엄청 뒤떨어진 것 같은 느낌을 받는데 그렇지 않습니다.",
        Speakers = [kim_jinseok],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        Topic = SessionTopic.AI,
        VideoUrl = "https://www.youtube.com/watch?v=x0ZUePbcJJQ",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/blob/main/2025/2025-kimjinseok.pdf",
        Tags = ["C#", "AI", "Semantic Kernel"]
    };

    private Session blazor_oauth => new()
    {
        Id = nameof(blazor_oauth),
        Title = "Blazor 앱에 손쉽게 OAuth 인증 기능을 구현해 보자!",
        Abstract = "Azure EasyAuth 기능을 이용하면 OAuth 기반 인증을 구현했을 경우 기존의 인증 관련 코드 플로우를 굉장히 단순화 시키거나 아예 코드 변경 없이도 로그인 기능을 구현할 수 있습니다.",
        Speakers = [justin_yoo],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        Topic = SessionTopic.Web,
        VideoUrl = "https://www.youtube.com/watch?v=fCLZ4MYBP9M",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/blob/main/2025/2025-justinyoo.pdf",
        Tags = ["Blazor", "OAuth", "Azure"]
    };

    private Session blazor_frontend => new()
    {
        Id = nameof(blazor_frontend),
        Title = "Blazor와 프론트엔드 생태계의 조화",
        Abstract = "Blazor에서 JavaScript 모듈을 효율적으로 호출하는 패턴과 프론트엔드 생태계를 잘 활용하는 법을 통해 Blazor 애플리케이션의 확장성을 극대화하는 실용적인 접근 방식을 제시합니다.",
        Speakers = [shim_yunsub],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        Topic = SessionTopic.Web,
        VideoUrl = "https://www.youtube.com/watch?v=1EArAy9eFgk",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/blob/main/2025/2025-simyoonsub.pdf",
        Tags = ["Blazor", "JavaScript", "Frontend"]
    };

    private Session game_server_network => new()
    {
        Id = nameof(game_server_network),
        Title = "게임 서버 개발을 위한 C# 네트워크 프로그래밍(초보자 Ver.)",
        Abstract = "실시간 통신을 하는 온라인 게임 서버를 개발하기를 원하는 분들을 대상으로 게임 서버 개발에 사용할 C# 네트워크 프로그래밍에 대한 기초에 대해서 설명합니다.",
        Speakers = [choi_heungbae],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        Topic = SessionTopic.Web,
        VideoUrl = "https://www.youtube.com/watch?v=pTChZ-gYn6o",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/blob/main/2025/2025-choiheungbae.pdf",
        Tags = ["Game Server", "Network", "C#"]
    };

    // 트랙 3 세션들
    private Session dotnet_nodejs => new()
    {
        Id = nameof(dotnet_nodejs),
        Title = ".NET+Node.js: 괴롭지만 함께라면 행복할거야",
        Abstract = "마이크로소프트의 node-api-dotnet를 소개합니다. Node.js의 구조와 장단점, Node.js의 단점을 보완해줄 node-api-dotnet의 동작 방식과 활용 방법을 설명합니다.",
        Speakers = [park_sanghyun],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        Topic = SessionTopic.General,
        VideoUrl = "https://www.youtube.com/watch?v=-AiV0FnEfJU",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/blob/main/2025/2025-parksanghyeon.pdf",
        Tags = [".NET", "Node.js", "Interop"]
    };

    private Session tech_vs_logic => new()
    {
        Id = nameof(tech_vs_logic),
        Title = "기술 주의자 v 논리 주의자 (개정 2판)",
        Abstract = "대부분의 개발자들이 기술 주의자라는 사실을 발견했습니다. 그리고 마틴 파울러, 로버트 C 마틴 등 세계적인 소프트웨어 리더들은 모두 논리 주의자들입니다.",
        Speakers = [kim_sanghyun],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        Topic = SessionTopic.General,
        VideoUrl = "https://www.youtube.com/watch?v=YZhXUezWgEk",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/blob/main/2025/2025-kimsanghyeon.pdf",
        Tags = ["Career", "Philosophy", "Software Design"]
    };

    private Session efcore_programming => new()
    {
        Id = nameof(efcore_programming),
        Title = "EF Core 8.0 ORM Code First Programming For RDBMS",
        Abstract = "ASP.NET Core 8.0/9.0 기반 ORM Framework인 EFCore 8.0/9.0이 지원하는 주요 RDBMS SW를 대상으로한 ORM Code First방식을 이용한 모델 기반 물리적 테이블 생성 방법을 소개합니다.",
        Speakers = [kang_changhoon],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        Topic = SessionTopic.Web,
        VideoUrl = "https://www.youtube.com/watch?v=TK_XF-FvS9Y",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/blob/main/2025/2025-kangchanghoon.pdf",
        Tags = ["EF Core", "ORM", "Database"]
    };

    private Session framework_agnostic => new()
    {
        Id = nameof(framework_agnostic),
        Title = "프레임워크 종속을 피하기 위한 C# 클라이언트 앱 설계",
        Abstract = "클라이언트 애플리케이션을 개발할 때 특정 프레임워크와 플랫폼에 의존하는 부분을 최소화하여 설계하는 법에 대해서 알아봅니다.",
        Speakers = [lee_jonghoon],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        Topic = SessionTopic.Web,
        VideoUrl = "https://www.youtube.com/watch?v=7aX8Wuw7ZIQ",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/blob/main/2025/2025-leejonghoon.pdf",
        Tags = ["C#", "Architecture", "Framework Agnostic"]
    };

    private Session aspnet_best_practice => new()
    {
        Id = nameof(aspnet_best_practice),
        Title = "초보 서버 개발자와 함께 보는 ASP.NET Core Best Practice",
        Abstract = "실제 사례를 통해 .NET에서 공개한 ASP.NET Core Best Practice를 이해하고 적용하는 방법을 알아봅니다.",
        Speakers = [choi_eunjeong],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        Topic = SessionTopic.Web,
        VideoUrl = "https://www.youtube.com/watch?v=JJ6m_KWxHmQ",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/blob/main/2025/2025-choieunjeong.pdf",
        Tags = ["ASP.NET Core", "Best Practice", "Junior"]
    };

    private Session generic_host => new()
    {
        Id = nameof(generic_host),
        Title = "Hello, World를 제네릭 호스트로 다시 쓰기",
        Abstract = "요즈음 최신 닷넷 애플리케이션 예제는 주로 웹, Blazor, Aspire 형태의 애플리케이션을 많이 접하실텐데요, 이런 애플리케이션 말고도 일반적인 콘솔, 데스크톱 애플리케이션도 제네릭 호스트를 이용하여 현대화된 형태로 개발할 수 있습니다.",
        Speakers = [nam_jeonghyun],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        Topic = SessionTopic.General,
        VideoUrl = "https://www.youtube.com/watch?v=90HFIm2Reqk",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/blob/main/2025/2025-namjeonghyun-helloworld.pdf",
        Tags = ["Generic Host", "Console", "Modern .NET"]
    };

    private Session azure_devops => new()
    {
        Id = nameof(azure_devops),
        Title = "Azure DevOps와 .NET을 활용하여 개발 조직의 생산성을 증가시킨 이야기",
        Abstract = "Azure DevOps을 활용하여 효율적으로 협업할 수 있는 사례, backlog task 관리, 편리하게 CI/CD 파이프라인을 구축한 이야기를 소개합니다.",
        Speakers = [kim_jungwoo],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        Topic = SessionTopic.General,
        VideoUrl = "https://www.youtube.com/watch?v=5CsCsuiopS0",
        SlidesUrl = "https://github.com/dotnetdev-kr/dotNETConf-Presentation/blob/main/2025/2025-kimjeongwoo.pdf",
        Tags = ["Azure DevOps", "CI/CD", "Productivity"]
    };

    #endregion

    #region Tracks

    private Track track1 => new()
    {
        Id = nameof(track1),
        Name = "갤럭시홀 (트랙 1)",
        Color = "#6f42c1",
        Sessions = SessionCollection.Create(
            keynote, amazon_q_developer, tablecloth_cloud, cloud_native_ui,
            couchbase_ai, dotnet_on_aws, rockcraft, maui_guide
        )
    };

    private Track track2 => new()
    {
        Id = nameof(track2),
        Name = "룸 B (트랙 2)",
        Color = "#0d6efd",
        Sessions = SessionCollection.Create(
            devsecops, sqlkata, gpu_heatmap, csharp_ai,
            blazor_oauth, blazor_frontend, game_server_network
        )
    };

    private Track track3 => new()
    {
        Id = nameof(track3),
        Name = "룸 C (트랙 3)",
        Color = "#198754",
        Sessions = SessionCollection.Create(
            dotnet_nodejs, tech_vs_logic, efcore_programming, framework_agnostic,
            aspnet_best_practice, generic_host, azure_devops
        )
    };

    #endregion

    #region Sponsors

    private readonly Sponsor aws = new()
    {
        Id = nameof(aws),
        Name = "Amazon Web Services",
        Tier = SponsorTier.Platinum,
        WebsiteUrl = "https://aws.amazon.com/",
        Description = "장소 제공",
        LogoUrl = "/images/sponsors/aws.png"
    };

    private readonly Sponsor megazone = new()
    {
        Id = nameof(megazone),
        Name = "메가존클라우드",
        Tier = SponsorTier.Gold,
        WebsiteUrl = "https://www.megazone.com",
        LogoUrl = "/images/sponsors/megazone.png"
    };

    private readonly Sponsor infragistics = new()
    {
        Id = nameof(infragistics),
        Name = "Infragistics",
        Tier = SponsorTier.Gold,
        WebsiteUrl = "https://www.infragistics.com/",
        LogoUrl = "/images/sponsors/infragistics.png"
    };

    private readonly Sponsor couchbase = new()
    {
        Id = nameof(couchbase),
        Name = "Couchbase",
        Tier = SponsorTier.Gold,
        WebsiteUrl = "https://www.couchbase.com/",
        LogoUrl = "/images/sponsors/couchbase.png"
    };

    private readonly Sponsor jetbrains = new()
    {
        Id = nameof(jetbrains),
        Name = "JetBrains",
        Tier = SponsorTier.Silver,
        WebsiteUrl = "https://www.jetbrains.com/",
        LogoUrl = "/images/sponsors/jetbrains.png"
    };

    #endregion

    #region Venues

    private VenueInfo spaceshare => new()
    {
        Id = nameof(spaceshare),
        Name = "스페이스쉐어 삼성역센터",
        Address = "서울시 강남구 영동대로96길 20 대화빌딩 지하 1층",
        Tracks = TrackCollection.Create(track1, track2, track3)
    };

    #endregion

    public EventInfo Event => new()
    {
        Slug = Slug,
        Year = 2025,
        Title = ".NET Conf 2025 x Seoul",
        Theme = "닷넷도 클라우드 네이티브였어!",
        Description = "닷넷콘 서울은 2019년부터 매년 대한민국 서울에서 개최하고 있는 닷넷 개발자 컨퍼런스입니다. 이번 행사는 닷넷이 클라우드, 인공 지능, 모바일과 정말 잘 어울리는 멋진 기술이라는 것을 보여드립니다.",
        Date = new DateTime(2025, 1, 9),
        Type = EventType.Offline,
        AttendeeCount = 200,
        HeroImageUrl = "/images/events/2025-hero.webp",
        Venues = VenueCollection.Create(spaceshare),
        Sponsors = SponsorCollection.Create(aws, megazone, infragistics, couchbase, jetbrains)
    };

    public ScheduleGrid Schedule => new ScheduleGridBuilder()
        .ForDay(1)
        .AddTrack(track1)
        .AddTrack(track2)
        .AddTrack(track3)

        // 09:00 ~ 09:40 체크인
        .AddTimeSlot(new TimeOnly(9, 0), 40, slot => slot
            .At(0, new Session { Id = "checkin", Title = "체크인", Abstract = "", Format = SessionFormat.CheckIn, Duration = TimeSpan.FromMinutes(40), Speakers = [] }))

        // 09:40 ~ 09:45 개회사
        .AddTimeSlot(new TimeOnly(9, 40), 5, slot => slot
            .At(0, new Session { Id = "opening", Title = "개회, 행사 안내, 후원사 및 부스 참여 업체 소개", Abstract = "", Format = SessionFormat.Opening, Duration = TimeSpan.FromMinutes(5), Speakers = [nam_jeonghyun] }))

        // 09:50 ~ 10:30 키노트
        .AddTimeSlot(new TimeOnly(9, 50), 40, slot => slot
            .At(0, keynote))

        // 10:40 ~ 11:20
        .AddTimeSlot(new TimeOnly(10, 40), 40, slot => slot
            .At(0, amazon_q_developer)
            .At(1, devsecops)
            .At(2, dotnet_nodejs))

        // 11:25 ~ 12:05
        .AddTimeSlot(new TimeOnly(11, 25), 40, slot => slot
            .At(0, tablecloth_cloud)
            .At(1, sqlkata)
            .At(2, tech_vs_logic))

        // 12:05 ~ 13:25 점심
        .AddTimeSlot(new TimeOnly(12, 5), 80, slot => slot
            .At(0, new Session { Id = "lunch", Title = "점심 식사", Abstract = "", Format = SessionFormat.Lunch, Duration = TimeSpan.FromMinutes(80), Speakers = [] }))

        // 13:25 ~ 14:05
        .AddTimeSlot(new TimeOnly(13, 25), 40, slot => slot
            .At(0, cloud_native_ui)
            .At(1, gpu_heatmap)
            .At(2, efcore_programming))

        // 14:10 ~ 14:50
        .AddTimeSlot(new TimeOnly(14, 10), 40, slot => slot
            .At(0, couchbase_ai)
            .At(1, csharp_ai)
            .At(2, framework_agnostic))

        // 14:50 ~ 15:10 휴식
        .AddTimeSlot(new TimeOnly(14, 50), 20, slot => slot
            .At(0, new Session { Id = "break", Title = "휴식 및 네트워킹", Abstract = "", Format = SessionFormat.Break, Duration = TimeSpan.FromMinutes(20), Speakers = [] }))

        // 15:10 ~ 15:50
        .AddTimeSlot(new TimeOnly(15, 10), 40, slot => slot
            .At(0, dotnet_on_aws)
            .At(1, blazor_oauth)
            .At(2, aspnet_best_practice))

        // 15:55 ~ 16:35
        .AddTimeSlot(new TimeOnly(15, 55), 40, slot => slot
            .At(0, rockcraft)
            .At(1, blazor_frontend)
            .At(2, generic_host))

        // 16:40 ~ 17:20
        .AddTimeSlot(new TimeOnly(16, 40), 40, slot => slot
            .At(0, maui_guide)
            .At(1, game_server_network)
            .At(2, azure_devops))

        // 17:20 ~ 17:30 경품추첨/폐회
        .AddTimeSlot(new TimeOnly(17, 20), 10, slot => slot
            .At(0, new Session { Id = "closing", Title = "경품 추첨, 폐회", Abstract = "", Format = SessionFormat.PrizeDrawing, Duration = TimeSpan.FromMinutes(10), Speakers = [nam_jeonghyun] }))

        .Build();
}
