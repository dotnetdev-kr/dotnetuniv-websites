using DotNetUniverse.Models;
using DotNetUniverse.Models.Collections;

namespace DotNetUniverse.Services.EventData;

/// <summary>
/// 2025년 12월 .NET Universe Busan Edition, 2512 행사 데이터
/// </summary>
public class BusanEdition2512Data : IEventData
{
    public string Slug => "xyz/busan-2512";
    public int Year => 2025;
    public string ThemeColor => "#198754";
    public string ThemeColorClass => "success";

    #region Speakers

    private readonly Speaker jeonghyun_nam = new()
    {
        Id = nameof(jeonghyun_nam),
        Name = "남정현",
        Title = "Microsoft MVP",
        Company = "메가존클라우드",
        Bio = "메가존클라우드에서 소프트웨어 엔지니어로 일하고 있습니다. 닷넷데브 운영진, 네이버 TCN 카페 운영진으로 활동하고 있으며, 마이크로소프트 MVP로 2009년부터 현재까지 계속 활동하고 있습니다.",
        ImageUrl = "/images/speakers/nam_jeonghyun.png"
    };

    public SpeakerCollection Speakers => SpeakerCollection.Create(
        jeonghyun_nam
    );

    #endregion

    #region Sessions

    private Session dotnet10_file_based_app => new()
    {
        Id = nameof(dotnet10_file_based_app),
        Title = ".NET 10의 File-based App 미리보기",
        Abstract = """
            .NET 10에서 새롭게 도입될 File-based App을 통해 완전히 새로워진 C# 프로그래밍 환경을 미리 살펴보고, 
            C# 파일 하나로 스크립트부터 AI 에이전트까지 구현하는 방법을 소개합니다.
            
            "간단한 코드 하나 돌리는데 프로젝트 만들고, 솔루션 열고... 언제까지 무겁게 개발하실 건가요?"
            이제 C#도 파이썬처럼 가볍고 섹시해집니다.
            """,
        Speakers = [jeonghyun_nam],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(60),
        VideoUrl = "https://www.youtube.com/watch?v=-R6U3Y4T-Ok",
        Tags = [".NET 10", "File-based App", "C#", "AI"]
    };

    #endregion

    #region Sponsors

    private readonly Sponsor busan_it_mogakko = new()
    {
        Id = nameof(busan_it_mogakko),
        Name = "부산IT모각코",
        Tier = SponsorTier.Gold,
        WebsiteUrl = "https://open.kakao.com/o/go2tr8bf",
        Description = "부산 지역 IT 개발자 커뮤니티"
    };

    private readonly Sponsor lounge_j = new()
    {
        Id = nameof(lounge_j),
        Name = "라운지J",
        Tier = SponsorTier.Silver,
        Description = "장소 제공"
    };

    #endregion

    #region Tracks

    private Track main => new()
    {
        Id = nameof(main),
        Name = "Main",
        Description = "메인 세션",
        Color = "#198754",
        Sessions = SessionCollection.Create(
            dotnet10_file_based_app
        )
    };

    #endregion

    #region Venue

    private VenueInfo lounge_j_venue => new()
    {
        Id = nameof(lounge_j_venue),
        Name = "라운지J",
        Address = "부산시 부산진구 동성로87번길 30",
        Tracks = TrackCollection.Create(main)
    };

    #endregion

    public EventInfo Event => new()
    {
        Slug = Slug,
        Year = 2025,
        Title = ".NET Universe: Busan Edition, 2512",
        Scale = EventScale.Meetup,
        Theme = ".NET 10 File-based App 미리보기",
        Description = """
            .NET Universe Busan Edition은 지역 간 최신 기술 정보 격차를 해소하기 위해 시작된 부산 지역 출장 세미나입니다.
            이번을 시작으로 향후 격월(2개월) 간격으로 진행될 예정이며, .NET에 관심이 있는 부산 지역 개발자 분들 누구나 참여할 수 있습니다.
            
            부산 개발자 여러분, 2025년 한 해 고생 많으셨습니다! 🎄
            마이크로소프트 MVP이신 닷넷데브의 남정현님과 부산 IT 모각코가 함께하는 이번 부산 닷넷 이야기 마당에서는 
            마이크로소프트가 준비하고 있는 새로운 문명!! .NET 10을 가장 먼저 열어보는 시간을 가집니다.
            """,
        Date = new DateTime(2025, 12, 6, 14, 0, 0),
        Type = EventType.Offline,
        TrailerUrl = "https://www.youtube.com/watch?v=-R6U3Y4T-Ok",
        Venues = VenueCollection.Create(lounge_j_venue),
        Sponsors = SponsorCollection.Create(busan_it_mogakko, lounge_j)
    };

    public ScheduleGrid Schedule => new ScheduleGridBuilder()
        .ForDay(1)
        .AddTrack(main)

        .AddTimeSlot(new TimeOnly(14, 0), 60, slot => slot
            .At(0, dotnet10_file_based_app))

        .Build();
}
