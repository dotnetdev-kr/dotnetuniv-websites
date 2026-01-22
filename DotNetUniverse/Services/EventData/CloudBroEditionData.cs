using DotNetUniverse.Models;
using DotNetUniverse.Models.Collections;

namespace DotNetUniverse.Services.EventData;

/// <summary>
/// 2025년 9월 .NET Universe CloudBro Edition 행사 데이터
/// </summary>
public class CloudBroEditionData : IEventData
{
    public string Slug => "universe/cloudbro";
    public int Year => 2025;
    public string ThemeColor => "#0d6efd";
    public string ThemeColorClass => "primary";

    #region Speakers

    private readonly Speaker jeeung_lee = new()
    {
        Id = nameof(jeeung_lee),
        Name = "이제응",
        Title = "리눅스 재단 APAC 한국 대표",
        Company = "OSC Korea",
        Bio = "리눅스 재단 APAC 소속으로 주요 산하 재단인 CNCF, PyTorch 등의 한국 대표로 비영리 활동 중이며, OSC Korea 클라우드 컨설팅 창업자이자 CloudBro AI 커뮤니티 서비스 운영자입니다."
    };

    private readonly Speaker jeonghyun_nam = new()
    {
        Id = nameof(jeonghyun_nam),
        Name = "남정현",
        Title = "Microsoft MVP",
        Company = "메가존클라우드",
        Bio = "메가존클라우드에서 소프트웨어 엔지니어로 일하고 있습니다. 닷넷데브 운영진, 네이버 TCN 카페 운영진으로 활동하고 있으며, 마이크로소프트 MVP로 2009년부터 현재까지 계속 활동하고 있습니다.",
        ImageUrl = "/images/speakers/nam_jeonghyun.png"
    };

    private readonly Speaker giha_lee = new()
    {
        Id = nameof(giha_lee),
        Name = "이기하",
        Title = "클라우드 엔지니어",
        Company = "한화시스템",
        Bio = "CI/CD 환경 구축을 시작으로 MSA, Kubernetes, Docker 등 다양한 프로젝트를 경험하며 성장해온 클라우드 엔지니어입니다. OPA(Open Platform Alliance) 개발자 커뮤니티 리더이자 CloudBro Cloud Sages Club 멤버입니다."
    };

    public SpeakerCollection Speakers => SpeakerCollection.Create(
        jeeung_lee, jeonghyun_nam, giha_lee
    );

    #endregion

    #region Sessions

    private Session ai_developer_strategy => new()
    {
        Id = nameof(ai_developer_strategy),
        Title = "AI 혁신으로 인한 개발자 생존 전략 - 설계하는 개발자, 코드짜는 엔지니어링 환경 변화",
        Abstract = """
            AI 코딩 기술 혁신으로 인해 개발자의 클라우드 엔지니어링 기술은 필수 역량으로 변화하고 있으며, 
            또한 클라우드 엔지니어링의 다양한 서비스(퍼블릭 CSP, 오픈소스 클라우드 기술 등)들에 대해서 잘 알아야 하는 시대가 되었습니다. 
            이에 대한 글로벌 클라우드 시장 변화, 개인의 역량 강화 전략을 공유합니다.
            """,
        Speakers = [jeeung_lee],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(25),
        VideoUrl = "https://www.youtube.com/watch?v=_LipC8DwTY4",
        Tags = ["AI", "개발자 커리어", "클라우드"]
    };

    private Session dev_ops_aspire => new()
    {
        Id = nameof(dev_ops_aspire),
        Title = "C# 파일 1개와 AI 에디터로 끝내는 Dev式 Ops (진짜로요)",
        Abstract = """
            Aspire는 철저히 개발자의 관점에서 쓰여진 클라우드 네이티브 도구입니다. 
            이번 세션에서는 .NET 10의 File-based App과 Aspire AppHost를 활용해 단일 C# 파일로 로컬 오케스트레이션을 구성하고, 
            Aspire로 만든 JSON 매니페스트를 AI 기반 코드 에디터(Cursor, Windsurf 등)가 읽어 Helm 차트로 자동 변환하는 실전 접근 방법을 소개하면서, 
            Dev식 Ops에 대한 개념을 살펴보려 합니다.
            """,
        Speakers = [jeonghyun_nam],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(25),
        VideoUrl = "https://www.youtube.com/watch?v=FhNme0e2Q9Y",
        Tags = ["Aspire", ".NET 10", "DevOps", "AI", "Kubernetes"]
    };

    private Session cloud_engineer_career => new()
    {
        Id = nameof(cloud_engineer_career),
        Title = "데이터 플랫폼부터 서버 안정화까지: 클라우드 엔지니어의 커리어와 DevOps",
        Abstract = """
            CI/CD 환경 구축을 시작으로 MSA, Kubernetes, Docker 등 다양한 프로젝트를 경험하며 성장해온 클라우드 엔지니어가, 
            Kubernetes 기반 데이터 플랫폼과 인증·인가 체계 구축, GPU 서버 및 스토리지 운영, Kubeflow 재구성 등 
            실전 경험을 통해 얻은 노하우와 교훈과 클라우드 엔지니어로서의 커리어 여정을 담은 세션입니다.
            """,
        Speakers = [giha_lee],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(25),
        VideoUrl = "https://www.youtube.com/watch?v=H-NCmN6OqCs",
        Tags = ["Kubernetes", "DevOps", "클라우드 커리어", "데이터 플랫폼"]
    };

    private Session open_discussion => new()
    {
        Id = nameof(open_discussion),
        Title = "Open Discussion - 클라우드 관련 질문/답변",
        Abstract = "클라우드 관련 커리어, 기술 트렌드 등에 대한 질문과 답변 시간입니다.",
        Speakers = [jeeung_lee, jeonghyun_nam, giha_lee],
        Format = SessionFormat.Panel,
        Duration = TimeSpan.FromMinutes(20),
        Tags = ["Q&A", "패널토크"]
    };

    #endregion

    #region Sponsors

    private readonly Sponsor cloudbro = new()
    {
        Id = nameof(cloudbro),
        Name = "CloudBro",
        Tier = SponsorTier.Gold,
        WebsiteUrl = "https://cloudbro.ai",
        Description = "클라우드 엔지니어링 전문 기술 질문 공간 및 커뮤니티"
    };

    private readonly Sponsor maru360 = new()
    {
        Id = nameof(maru360),
        Name = "마루360",
        Tier = SponsorTier.Silver,
        WebsiteUrl = "https://maru.org/",
        Description = "장소 제공"
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
            ai_developer_strategy, dev_ops_aspire, cloud_engineer_career, open_discussion
        )
    };

    #endregion

    #region Venue

    private VenueInfo maru360_venue => new()
    {
        Id = nameof(maru360_venue),
        Name = "마루360 성장 세미나룸",
        Address = "서울특별시 강남구 역삼동",
        Tracks = TrackCollection.Create(main)
    };

    #endregion

    public EventInfo Event => new()
    {
        Slug = Slug,
        Year = 2025,
        Title = ".NET Universe: CloudBro Edition",
        Scale = EventScale.Meetup,
        Theme = "클라우드 네이티브와 DevOps",
        Description = """
            .NET L!VE의 새 이름, .NET Universe XYZ Edition을 소개합니다!
            .NET Universe CloudBro Edition은 클라우드 엔지니어링 전문 기술 질문 공간 및 커뮤니티를 지향하는 CloudBro와 닷넷데브가 공동으로 여는 미니 컨퍼런스입니다.
            이번 컨퍼런스에서는 개발자를 위한 DevOps 도구인 Aspire와 .NET 10의 강력한 DX를 완성하는 File-based App 기반을 새롭게 소개하며,
            Container, Kubernetes, Observability 등에 관한 업계 동향, 인사이트를 종합적으로 알아보실 수 있습니다.
            """,
        Date = new DateTime(2025, 9, 4, 18, 30, 0),
        Type = EventType.Offline,
        TicketPrice = 10000,
        AttendeeCount = 30,
        Venues = VenueCollection.Create(maru360_venue),
        Sponsors = SponsorCollection.Create(cloudbro, maru360)
    };

    public ScheduleGrid Schedule => new ScheduleGridBuilder()
        .ForDay(1)
        .AddTrack(main)

        .AddTimeSlot(new TimeOnly(19, 10), 25, slot => slot
            .At(0, ai_developer_strategy))

        .AddTimeSlot(new TimeOnly(19, 40), 25, slot => slot
            .At(0, dev_ops_aspire))

        .AddTimeSlot(new TimeOnly(20, 10), 25, slot => slot
            .At(0, cloud_engineer_career))

        .AddTimeSlot(new TimeOnly(20, 40), 20, slot => slot
            .At(0, open_discussion))

        .Build();
}
