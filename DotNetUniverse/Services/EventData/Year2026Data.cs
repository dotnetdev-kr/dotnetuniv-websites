using DotNetUniverse.Models;
using DotNetUniverse.Models.Collections;

namespace DotNetUniverse.Services.EventData;

/// <summary>
/// 2026년 행사 데이터 (.NET Conf 2026 x Seoul)
/// </summary>
public class Year2026Data : IEventData
{
    public string Slug => "2026";
    public int Year => 2026;
    public string ThemeColor => "#6f42c1";
    public string ThemeColorClass => "purple";

    #region Speakers

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

    public SpeakerCollection Speakers => SpeakerCollection.Create(
        nam_jeonghyun
    );

    #endregion

    #region Sessions

    // 세션은 추후 확정 시 추가 예정

    #endregion

    #region Tracks

    private Track track1 => new()
    {
        Id = nameof(track1),
        Name = "갤럭시홀 (트랙 1)",
        Color = "#6f42c1",
        Sessions = SessionCollection.Create()
    };

    private Track track2 => new()
    {
        Id = nameof(track2),
        Name = "룸 B (트랙 2)",
        Color = "#0d6efd",
        Sessions = SessionCollection.Create()
    };

    private Track track3 => new()
    {
        Id = nameof(track3),
        Name = "룸 C (트랙 3)",
        Color = "#198754",
        Sessions = SessionCollection.Create()
    };

    #endregion

    #region Sponsors


    // 후원사는 추후 확정 시 추가 예정

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
        Year = 2026,
        Title = ".NET Universe 2026",
        Theme = "Coming Soon",
        Description = ".NET Universe는 2019년부터 매년 대한민국 서울에서 개최하고 있는 국내 최대 .NET 개발자 컨퍼런스입니다.",
        Date = new DateTime(2026, 3, 12, 9, 0, 0),
        Type = EventType.Offline,
        AttendeeCount = 200,
        Status = EventStatus.CallForParticipation,

        // 모집 링크
        CallForSpeakersUrl = "https://forms.office.com/r/6zS7st7VtC",
        CallForSponsorsUrl = "https://forms.office.com/r/jjMB7ec8nE",
        CallForVolunteersUrl = "https://forms.office.com/r/JNeVzGS2SL",
        // RegistrationUrl = "https://festa.io/events/xxx",
        // NotificationSignupUrl = "https://forms.example.com/notify",

        // 티켓 가격 (추후 확정)
        TicketPrice = 20000,
        // EarlyBirdPrice = 5000,
        // EarlyBirdDeadline = new DateTime(2026, 2, 28),

        Venues = VenueCollection.Create(spaceshare),
        Sponsors = SponsorCollection.Create()
    };

    public ScheduleGrid? Schedule => null; // 스케줄은 추후 확정 시 추가 예정
}
