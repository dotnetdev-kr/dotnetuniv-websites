using DotNetUniverse.Models;
using DotNetUniverse.Models.Collections;

namespace DotNetUniverse.Services.EventData;

/// <summary>
/// 2023년 10월 .NET L!VE 2023 Fall 행사 데이터
/// </summary>
public class Live23FallData : IEventData
{
    public string Slug => "live/2310";
    public int Year => 2023;
    public string ThemeColor => "#ff6b35";
    public string ThemeColorClass => "warning";

    #region Speakers

    private readonly Speaker soonkeun_kim = new()
    {
        Id = nameof(soonkeun_kim),
        Name = "김순근",
        Title = "Sr. Technical Account Manager",
        Company = "Amazon Web Services",
        Bio = "오래된 닷넷 개발자입니다. 비주얼스튜디오 사용자 모임 시삽 및 Microsoft MVP로 활동하였으며, 안랩, 마이크로소프트, 스타트업을 거쳐 현재는 AWS에서 Sr. Technical Account Manager로 근무하고 있습니다.",
        ImageUrl = "/images/speakers/soonkeun_kim_2023.jpeg"
    };

    private readonly Speaker jonghoon_lee = new()
    {
        Id = nameof(jonghoon_lee),
        Name = "이종훈",
        Title = "개발자",
        Bio = "다양한 분야에서 Windows 프로그램과 ASP.NET으로 웹을 개발한 9년차 닷넷 개발자입니다. Web Backend 및 서버 프로그램 개발 쪽에 관심을 많이 가지고 있습니다.",
        ImageUrl = "/images/speakers/jonghoon_lee_2023fall.jpg"
    };

    private readonly Speaker sangjun_lee = new()
    {
        Id = nameof(sangjun_lee),
        Name = "이상준",
        Title = "개발자",
        Bio = "게임 디자이너를 위한 Windows Desktop Application을 만들고 있습니다.",
        ImageUrl = "/images/speakers/sangjun_lee_2023fall.jpg"
    };

    private readonly Speaker dongcheol_ryu = new()
    {
        Id = nameof(dongcheol_ryu),
        Name = "류동철",
        Title = "Partner Solution Architect",
        Company = "Amazon Web Services",
        Bio = "게임 회사에서 약 10여년간 엔지니어로 근무하며, 2012년~2019년까지 MS MVP(Clustering) 활동도 하였고 현재 AWS에서 Partner Solution Architect로서 Microsoft 워크로드를 담당하고 있습니다.",
        ImageUrl = "/images/speakers/dongcheol_ryu_2023.png"
    };

    private readonly Speaker heungbae_choi = new()
    {
        Id = nameof(heungbae_choi),
        Name = "최흥배",
        Title = "센트럴서버실 실장",
        Company = "컴투스",
        Bio = "2003년부터 온라인 게임의 서버(PC or Mobile)를 개발하고 있습니다. 현재는 컴투스의 센트럴서버실에서 게임 서버 개발 지원 업무를 하고 있습니다. 온라인 게임 서버 개발과 고성능 프로그래밍, 교육에 관심이 많습니다.",
        ImageUrl = "/images/speakers/heungbae_choi_2023.jpg"
    };

    private readonly Speaker changhoon_kang = new()
    {
        Id = nameof(changhoon_kang),
        Name = "강창훈",
        Title = "대표",
        Company = "(주)엠소프트웨어",
        Bio = "글쓰고, 강의하고, 사업하는 개발자입니다.",
        ImageUrl = "/images/speakers/changhoon_kang_2023.jpg"
    };

    public SpeakerCollection Speakers => SpeakerCollection.Create(
        soonkeun_kim, jonghoon_lee, sangjun_lee, dongcheol_ryu, heungbae_choi, changhoon_kang
    );

    #endregion

    #region Sessions

    private Session keynote_aws => new()
    {
        Id = nameof(keynote_aws),
        Title = "키노트: Exploring .NET on AWS",
        Abstract = "AWS에서 .NET을 탐험하는 방법과 다양한 활용 사례를 소개합니다.",
        Speakers = [soonkeun_kim],
        Format = SessionFormat.Keynote,
        Duration = TimeSpan.FromMinutes(30),
        VideoUrl = "https://www.youtube.com/watch?v=QSiAl22Bdrc",
        Tags = ["AWS", ".NET", "Keynote"]
    };

    private Session unit_test => new()
    {
        Id = nameof(unit_test),
        Title = "유닛테스트의 사실과 오해",
        Abstract = "유닛테스트에 대한 일반적인 오해와 실제 사실에 대해 이야기합니다.",
        Speakers = [jonghoon_lee],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(35),
        VideoUrl = "https://www.youtube.com/watch?v=s04883SoMCo",
        Tags = ["Unit Test", "Testing"]
    };

    private Session mef_plugin => new()
    {
        Id = nameof(mef_plugin),
        Title = "당신의 플러그인 기술, MEF",
        Abstract = "Managed Extensibility Framework(MEF)를 활용한 플러그인 아키텍처 구현 방법을 소개합니다.",
        Speakers = [sangjun_lee],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        VideoUrl = "https://www.youtube.com/watch?v=dxPBewOUNmo",
        Tags = ["MEF", "Plugin", "Architecture"]
    };

    private Session dotnet_modernization_aws => new()
    {
        Id = nameof(dotnet_modernization_aws),
        Title = ".NET Modernization on AWS",
        Abstract = "AWS에서 .NET 애플리케이션을 현대화하는 방법과 전략을 소개합니다.",
        Speakers = [dongcheol_ryu],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        VideoUrl = "https://www.youtube.com/watch?v=DoHClkcpXAA",
        Tags = ["AWS", "Modernization", ".NET"]
    };

    private Session memorypack => new()
    {
        Id = nameof(memorypack),
        Title = "고성능 데이터 직렬화 라이브러리 MemoryPack 소개",
        Abstract = "MemoryPack 라이브러리를 사용한 고성능 데이터 직렬화 방법을 소개합니다.",
        Speakers = [heungbae_choi],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(30),
        VideoUrl = "https://www.youtube.com/watch?v=D2DSXJHoQJo",
        Tags = ["MemoryPack", "Serialization", "Performance"]
    };

    private Session distributed_messaging => new()
    {
        Id = nameof(distributed_messaging),
        Title = "분산형 실시간 메시징 서비스 개발하기",
        Abstract = "분산 환경에서 실시간 메시징 서비스를 개발하는 방법을 소개합니다.",
        Speakers = [changhoon_kang],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(45),
        VideoUrl = "https://www.youtube.com/watch?v=ETQHZFGOGhw",
        Tags = ["SignalR", "Distributed", "Real-time"]
    };

    #endregion

    #region Sponsors

    private readonly Sponsor aws = new()
    {
        Id = nameof(aws),
        Name = "Amazon Web Services Korea",
        Tier = SponsorTier.Gold,
        WebsiteUrl = "https://aws.amazon.com/ko/",
        LogoUrl = "/images/sponsors/aws.png"
    };

    private readonly Sponsor maru180 = new()
    {
        Id = nameof(maru180),
        Name = "아산나눔재단 마루180",
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
        Color = "#ff6b35",
        Sessions = SessionCollection.Create(
            keynote_aws, unit_test, mef_plugin, dotnet_modernization_aws, memorypack, distributed_messaging
        )
    };

    #endregion

    #region Venue

    private VenueInfo maru180_venue => new()
    {
        Id = nameof(maru180_venue),
        Name = "마루180 지하 1층",
        Address = "서울특별시 강남구 역삼동",
        Tracks = TrackCollection.Create(main)
    };

    #endregion

    public EventInfo Event => new()
    {
        Slug = Slug,
        Year = 2023,
        Title = ".NET L!VE 2023 Fall",
        Scale = EventScale.Meetup,
        Theme = "Exploring .NET",
        Description = """
            .NET Conf Mini의 새 이름, .NET L!VE를 소개합니다!
            .NET L!VE는 연중 2회 열리는 닷넷 개발자들을 위한 세미나입니다.
            이번 .NET L!VE 2023 Fall은 'Exploring .NET'을 주제로 행사를 진행합니다.
            """,
        Date = new DateTime(2023, 10, 19, 12, 0, 0),
        Type = EventType.Offline,
        Venues = VenueCollection.Create(maru180_venue),
        Sponsors = SponsorCollection.Create(aws, maru180)
    };

    public ScheduleGrid Schedule => new ScheduleGridBuilder()
        .ForDay(1)
        .AddTrack(main)

        .AddTimeSlot(new TimeOnly(13, 5), 30, slot => slot
            .At(0, keynote_aws))

        .AddTimeSlot(new TimeOnly(13, 50), 35, slot => slot
            .At(0, unit_test))

        .AddTimeSlot(new TimeOnly(14, 40), 40, slot => slot
            .At(0, mef_plugin))

        .AddTimeSlot(new TimeOnly(15, 35), 40, slot => slot
            .At(0, dotnet_modernization_aws))

        .AddTimeSlot(new TimeOnly(16, 30), 30, slot => slot
            .At(0, memorypack))

        .AddTimeSlot(new TimeOnly(17, 15), 45, slot => slot
            .At(0, distributed_messaging))

        .Build();
}
