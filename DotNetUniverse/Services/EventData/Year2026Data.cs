using DotNetUniverse.Models;
using DotNetUniverse.Models.Collections;

namespace DotNetUniverse.Services.EventData;

/// <summary>
/// 2026년 행사 데이터 (.NET Universe 2026)
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
        Name = "리젠시홀",
        Color = "#6f42c1",
        Sessions = SessionCollection.Create()
    };

    #endregion

    #region Sponsors

    private readonly Sponsor aws = new()
    {
        Id = nameof(aws),
        Name = "Amazon Web Services",
        Tier = SponsorTier.Gold,
        WebsiteUrl = "https://aws.amazon.com/",
        LogoUrl = "/images/sponsors/aws.png"
    };

    private readonly Sponsor infragistics = new()
    {
        Id = nameof(infragistics),
        Name = "Infragistics",
        Tier = SponsorTier.Silver,
        WebsiteUrl = "https://www.infragistics.com/",
        LogoUrl = "/images/sponsors/infragistics.png"
    };

    #endregion

    #region Venues

    private VenueInfo spaceshare => new()
    {
        Id = nameof(spaceshare),
        Name = "스페이스쉐어 삼성역센터",
        Address = "서울시 강남구 영동대로96길 20 대화빌딩 지하 1층",
        NaverMapUrl = "https://naver.me/FWJPhIzz",
        KakaoMapUrl = "https://place.map.kakao.com/1624633856",
        GoogleMapUrl = "https://maps.app.goo.gl/6B7fQ8NQVTHAboFh8",
        Tracks = TrackCollection.Create(track1),
        ImportantNotice = "2호선 삼성역 확장 공사, 영동대로 복합환승센터 공사 및 현대자동차그룹 GBC센터 건축 공사가 진행 중이어서 <strong>인근 보도 통행 및 교통 상황이 매우 혼잡합니다.</strong> 여유 시간을 충분히 가지고 방문하시는 것을 권장합니다.",
        TransportNotices =
        [
            "<strong class=\"text-danger\">별도 무료 주차 지원이 되지 않으므로, 가급적 대중 교통 이용을 부탁드립니다.</strong>",
            "2호선 삼성역 확장 공사, 영동대로 복합환승센터 공사 및 현대자동차그룹 GBC센터 건축 공사가 진행 중이어서 <strong>인근 보도 통행 및 교통 상황이 매우 혼잡합니다.</strong> 여유 시간을 충분히 가지고 방문하시는 것을 권장합니다."
        ],
        SubwayInfo =
        [
            "<span class=\"text-success\">서울 지하철 2호선 삼성역 7, 8번 출구 (권장)</span>, <span class=\"text-warning\">서울 지하철 9호선 봉은사역 5, 6번 출구</span>"
        ],
        BusInfo =
        [
            "<strong>삼성역7번출구</strong> (23197, 23922, 23923), <strong>강남경찰서면허시험장</strong> (23196), <strong>무역센터</strong> (23198, 23199), <strong>한국무역센터 삼성역</strong> (23201, 23251, 23804), <strong>삼성역 3번 출구</strong> (23438), <strong>삼성역</strong> (23242, 23244, 23741, 23781), <strong>강남경찰서/강남운전면허시험장</strong> (23473), <strong>코엑스동문</strong> (23818), <strong>코엑스도심공항</strong> (23801)",
            "시외 버스 — 안양 11-3",
            "서울 마을 버스 — 강남01, 강남06, 강남07, 강남08",
            "서울 지선 버스 — 2413, 2415, 2416, 3217, 3411, 3412, 3414, 3417, 3422, 4318, 4319, 4425",
            "서울 간선 버스 — 143, 146, 301, 333, 341, 342, 343, 345, 350, 360, 401, 740, 8146",
            "광역 버스 — 광주 500-2, 광주 500-2N, 남양주 1100, 남양주 1700, 남양주 2000, 남양주 2000-1, 용인 6900, 남양주 7007, 남양주 8001, 하남 9303, 성남 9407, 성남 9507, 성남 9607, 광주 G3202, 양주 P9601 출근/퇴근, 양주 P9602 출근/퇴근, 인천 M6450",
            "공항 버스 — 6006, 6103, 심야 N6703",
            "심야 버스 — N13, N31, N61, 공항 N6703"
        ],
        ParkingLots =
        [
            ("영동대로96길 공영주차장", "https://place.map.kakao.com/27218154", "유료 (일 최대 24,000원)"),
            ("섬유센터빌딩 주차장", "https://place.map.kakao.com/26843491", "유료 (시간 당 6000원)"),
            ("코엑스 동문주차장", "https://place.map.kakao.com/2138840199", "유료 (시간 당 4800원)")
        ],
        NearbyPlacesUrl = "https://naver.me/GSczKHPl",
        NearbyPlacesDescription = "행사장 인근의 식당과 카페를 네이버 지도에서 확인하실 수 있습니다."
    };

    #endregion

    public EventInfo Event => new()
    {
        Slug = Slug,
        Year = 2026,
        Title = ".NET Universe 2026",
        Theme = ".NET & AI — Shaping the Future of Software Development, Together.",
        Description = "올해의 테마는 AI와 닷넷이 만나 새롭게 정의하는 소프트웨어 개발 생애주기 입니다. 특정 벤더나 플랫폼에 국한되지 않고, 기획에서 배포까지 전 과정을 아우르는 개발 패러다임의 전환을 다루며, 닷넷이 그 중심에서 어떤 역할을 할 수 있는지 탐구합니다. 이는 단순한 생산성 향상을 넘어, 개발자 경험(Developer Experience)의 혁신이자 닷넷 커뮤니티가 함께 만들어갈 미래의 표준입니다.",
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
        Sponsors = SponsorCollection.Create(aws, infragistics),

        // 경품 안내
        PrizesDescription = "행사 당일 경품 추첨을 통해 다양한 상품을 드립니다.",
        Prizes =
        [
        ],

        // 문의 안내
        ContactEmail = "support@dotnetconf.kr",
        ContactDescription = "다음의 내용을 포함한 각종 문의에 답해드릴 수 있습니다.",
        ContactTopics =
        [
            "행사 일반 문의",
            "취재 문의",
            "후원사 제안 및 혜택 문의",
            "발표자 등록 및 제안 관련 문의",
            "기타 행사 관련 모든 문의"
        ]
    };

    public ScheduleGrid? Schedule => new ScheduleGridBuilder()
        .ForDay(1)
        .AddTrack(track1)

        // 09:00 ~ 09:40 체크인
        .AddTimeSlot(new TimeOnly(9, 0), 40, slot => slot
            .At(0, new Session { Id = "checkin", Title = "체크인", Abstract = "", Format = SessionFormat.CheckIn, Duration = TimeSpan.FromMinutes(40), Speakers = [] }))

        // 09:40 ~ 10:00 키노트 / 닷넷데브
        .AddTimeSlot(new TimeOnly(9, 40), 20, slot => slot
            .At(0, new Session { Id = "keynote-dotnetdev", Title = "키노트 / 닷넷데브", Abstract = "", Format = SessionFormat.Keynote, Duration = TimeSpan.FromMinutes(20), Speakers = [nam_jeonghyun] }))

        // 10:00 ~ 10:20 키노트 / 골드 후원사
        .AddTimeSlot(new TimeOnly(10, 0), 20, slot => slot
            .At(0, new Session { Id = "keynote-sponsor", Title = "키노트 / 골드 후원사", Abstract = "", Format = SessionFormat.Keynote, Duration = TimeSpan.FromMinutes(20), Speakers = [] }))

        // 10:30 ~ 11:00 Breakout 1
        .AddTimeSlot(new TimeOnly(10, 30), 30, slot => slot
            .At(0, new Session { Id = "breakout-1", Title = "Breakout 1", Abstract = "", Format = SessionFormat.Breakout, Duration = TimeSpan.FromMinutes(30), Speakers = [] }))

        // 11:00 ~ 11:30 Breakout 2
        .AddTimeSlot(new TimeOnly(11, 0), 30, slot => slot
            .At(0, new Session { Id = "breakout-2", Title = "Breakout 2", Abstract = "", Format = SessionFormat.Breakout, Duration = TimeSpan.FromMinutes(30), Speakers = [] }))

        // 11:30 ~ 12:30 점심 식사
        .AddTimeSlot(new TimeOnly(11, 30), 60, slot => slot
            .At(0, new Session { Id = "lunch", Title = "점심 식사", Abstract = "", Format = SessionFormat.Lunch, Duration = TimeSpan.FromMinutes(60), Speakers = [] }))

        // 12:30 ~ 13:00 Breakout 3
        .AddTimeSlot(new TimeOnly(12, 30), 30, slot => slot
            .At(0, new Session { Id = "breakout-3", Title = "Breakout 3", Abstract = "", Format = SessionFormat.Breakout, Duration = TimeSpan.FromMinutes(30), Speakers = [] }))

        // 13:00 ~ 13:30 Breakout 4
        .AddTimeSlot(new TimeOnly(13, 0), 30, slot => slot
            .At(0, new Session { Id = "breakout-4", Title = "Breakout 4", Abstract = "", Format = SessionFormat.Breakout, Duration = TimeSpan.FromMinutes(30), Speakers = [] }))

        // 13:40 ~ 14:10 Breakout 5
        .AddTimeSlot(new TimeOnly(13, 40), 30, slot => slot
            .At(0, new Session { Id = "breakout-5", Title = "Breakout 5", Abstract = "", Format = SessionFormat.Breakout, Duration = TimeSpan.FromMinutes(30), Speakers = [] }))

        // 14:10 ~ 14:40 Breakout 6
        .AddTimeSlot(new TimeOnly(14, 10), 30, slot => slot
            .At(0, new Session { Id = "breakout-6", Title = "Breakout 6", Abstract = "", Format = SessionFormat.Breakout, Duration = TimeSpan.FromMinutes(30), Speakers = [] }))

        // 14:50 ~ 15:20 Breakout 7
        .AddTimeSlot(new TimeOnly(14, 50), 30, slot => slot
            .At(0, new Session { Id = "breakout-7", Title = "Breakout 7", Abstract = "", Format = SessionFormat.Breakout, Duration = TimeSpan.FromMinutes(30), Speakers = [] }))

        // 15:20 ~ 16:00 Breakout 8
        .AddTimeSlot(new TimeOnly(15, 20), 40, slot => slot
            .At(0, new Session { Id = "breakout-8", Title = "Breakout 8", Abstract = "", Format = SessionFormat.Breakout, Duration = TimeSpan.FromMinutes(40), Speakers = [] }))

        // 16:10 ~ 16:40 Breakout 9
        .AddTimeSlot(new TimeOnly(16, 10), 30, slot => slot
            .At(0, new Session { Id = "breakout-9", Title = "Breakout 9", Abstract = "", Format = SessionFormat.Breakout, Duration = TimeSpan.FromMinutes(30), Speakers = [] }))

        // 16:40 ~ 17:10 Breakout 10
        .AddTimeSlot(new TimeOnly(16, 40), 30, slot => slot
            .At(0, new Session { Id = "breakout-10", Title = "Breakout 10", Abstract = "", Format = SessionFormat.Breakout, Duration = TimeSpan.FromMinutes(30), Speakers = [] }))

        // 17:10 ~ 17:40 Breakout 11
        .AddTimeSlot(new TimeOnly(17, 10), 30, slot => slot
            .At(0, new Session { Id = "breakout-11", Title = "Breakout 11", Abstract = "", Format = SessionFormat.Breakout, Duration = TimeSpan.FromMinutes(30), Speakers = [] }))

        // 17:40 ~ 18:00 경품 추첨 및 폐회
        .AddTimeSlot(new TimeOnly(17, 40), 20, slot => slot
            .At(0, new Session { Id = "closing", Title = "경품 추첨 및 폐회", Abstract = "", Format = SessionFormat.PrizeDrawing, Duration = TimeSpan.FromMinutes(20), Speakers = [nam_jeonghyun] }))

        .Build();
}
