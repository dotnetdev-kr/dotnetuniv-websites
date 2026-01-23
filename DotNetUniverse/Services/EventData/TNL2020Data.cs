using DotNetUniverse.Models;
using DotNetUniverse.Models.Collections;

namespace DotNetUniverse.Services.EventData;

/// <summary>
/// 2020년 Thursday .NET Live! 2020 행사 데이터
/// </summary>
public class TNL2020Data : IEventData
{
    public string Slug => "mini/2020";
    public int Year => 2020;
    public string ThemeColor => "#512BD4";
    public string ThemeColorClass => "purple";

    #region Speakers

    private readonly Speaker jeonghyun_nam = new()
    {
        Id = nameof(jeonghyun_nam),
        Name = "남정현",
        Title = "Microsoft MVP",
        Bio = ".NET 5와 새로 출시되는 기술들을 소개하며 닷넷데브 운영진으로 활동하고 있습니다."
    };

    private readonly Speaker youngrak_choi = new()
    {
        Id = nameof(youngrak_choi),
        Name = "최영락",
        Title = "개발자",
        Bio = "Thursday .NET Live의 호스트로 참여하며 닷넷데브 운영진으로 활동하고 있습니다."
    };

    private readonly Speaker hayden = new()
    {
        Id = nameof(hayden),
        Name = "Hayden",
        Title = "개발자",
        Bio = ".NET 5와 F# 5, 그리고 해외 .NET 커뮤니티의 재미난 소식을 전합니다."
    };

    private readonly Speaker sungwon_moon = new()
    {
        Id = nameof(sungwon_moon),
        Name = "문성원",
        Title = "개발자",
        Bio = ".NET에서 비동기 프로그래밍을 처음 해보는 개발자가 겪은 에피소드와 유용한 라이브러리들을 소개합니다."
    };

    private readonly Speaker hyunmo_ahn = new()
    {
        Id = nameof(hyunmo_ahn),
        Name = "안현모",
        Title = "개발자",
        Bio = "Dapper에 대한 소개 및 CRUD 활용법, DataTable과의 차이점을 설명합니다."
    };

    public SpeakerCollection Speakers => SpeakerCollection.Create(
        jeonghyun_nam, youngrak_choi, hayden, sungwon_moon, hyunmo_ahn
    );

    #endregion

    #region Sessions

    private Session session_intro => new()
    {
        Id = nameof(session_intro),
        Title = "세션 소개",
        Abstract = "Thursday .NET Live의 세션을 소개합니다. 이번 온라인 미니 컨퍼런스는 총 4명의 발표자의 세션과 패널 토크 세션 1개로 구성되어있습니다.",
        Speakers = [jeonghyun_nam, youngrak_choi],
        Format = SessionFormat.Keynote,
        Duration = TimeSpan.FromMinutes(10),
        VideoUrl = "https://www.youtube.com/watch?v=BX7Oj0vEKM8",
        Tags = ["소개"]
    };

    private Session dotnet5_chronicles => new()
    {
        Id = nameof(dotnet5_chronicles),
        Title = ".NET 5 Chronicles",
        Abstract = ".NET Framework, .NET Core, Mono를 하나로 묶어줄 .NET 5와 새로 출시되는 기술들을 둘러봅니다.",
        Speakers = [jeonghyun_nam],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(30),
        VideoUrl = "https://www.youtube.com/watch?v=7JTuNeg6ls0",
        Tags = [".NET 5", "Preview"]
    };

    private Session dotnet5_fsharp5 => new()
    {
        Id = nameof(dotnet5_fsharp5),
        Title = ".NET 5 와 F# 5, 그리고 해외 .NET 커뮤니티",
        Abstract = "10월 정식 출시 예정인 .NET 5와 F# 5의 간단한 특징에 대해서 살펴보고, 해외 .NET 커뮤니티의 재미난 소식을 전합니다.",
        Speakers = [hayden],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(30),
        VideoUrl = "https://www.youtube.com/watch?v=TmSmuc7bLpU",
        Tags = [".NET 5", "F# 5", "커뮤니티"]
    };

    private Session async_programming => new()
    {
        Id = nameof(async_programming),
        Title = ".NET에서 비동기 프로그래밍 배우기 at 20Q1",
        Abstract = ".NET에서 비동기 프로그래밍을 처음 해보는 개발자가 겪은 에피소드와 유용한 라이브러리들을 소개합니다.",
        Speakers = [sungwon_moon],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(30),
        VideoUrl = "https://www.youtube.com/watch?v=LJltIrs6Eqw",
        Tags = ["비동기", "async/await"]
    };

    private Session dapper_orm => new()
    {
        Id = nameof(dapper_orm),
        Title = "Dapper를 이용한 ORM 활용",
        Abstract = "Dapper에 대한 소개 및 CRUD 활용법, DataTable과의 차이점을 설명합니다.",
        Speakers = [hyunmo_ahn],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(30),
        VideoUrl = "https://www.youtube.com/watch?v=MIRFZ1iDVN4",
        Tags = ["Dapper", "ORM", "데이터베이스"]
    };

    private Session panel_talk => new()
    {
        Id = nameof(panel_talk),
        Title = "패널 토크",
        Abstract = "패널 토크 시간에는 질문/답변 및 이번 행사에 대한 회고를 진행했습니다.",
        Speakers = [jeonghyun_nam, sungwon_moon, youngrak_choi],
        Format = SessionFormat.Panel,
        Duration = TimeSpan.FromMinutes(30),
        VideoUrl = "https://www.youtube.com/watch?v=tbdW_6G0y5U",
        Tags = ["패널토크", "Q&A"]
    };

    #endregion

    #region Sponsors

    private readonly Sponsor microsoft_azure = new()
    {
        Id = nameof(microsoft_azure),
        Name = "Microsoft Azure 개발자 커뮤니티",
        Tier = SponsorTier.Gold,
        WebsiteUrl = "https://aka.ms/thursday-dotnet-live",
        LogoUrl = "/images/sponsors/microsoft_azure_2020.png"
    };

    private readonly Sponsor dotnetdev = new()
    {
        Id = nameof(dotnetdev),
        Name = "닷넷데브",
        Tier = SponsorTier.Silver,
        WebsiteUrl = "https://dotnetdev.kr/",
        LogoUrl = "/images/sponsors/dotnetdev_2020.png"
    };

    #endregion

    #region Tracks

    private Track main => new()
    {
        Id = nameof(main),
        Name = "Main",
        Description = "메인 세션",
        Color = "#512BD4",
        Sessions = SessionCollection.Create(
            session_intro, dotnet5_chronicles, dotnet5_fsharp5,
            async_programming, dapper_orm, panel_talk
        )
    };

    #endregion

    #region Venue

    private VenueInfo online => new()
    {
        Id = nameof(online),
        Name = "유튜브 라이브 (온라인)",
        Address = "온라인",
        Tracks = TrackCollection.Create(main)
    };

    #endregion

    public EventInfo Event => new()
    {
        Slug = Slug,
        Year = 2020,
        Title = "Thursday .NET Live! 2020",
        Scale = EventScale.Meetup,
        Theme = ".NET 5 Preview 소개",
        Description = """
            Thursday .NET Live!는 닷넷데브와 Microsoft Azure 개발자 커뮤니티가 함께하는 온라인 미니 컨퍼런스입니다.
            이번 행사에서는 .NET 5 Preview와 F# 5, 비동기 프로그래밍, Dapper ORM 등 다양한 주제의 세션이 진행되었습니다.
            """,
        Date = new DateTime(2020, 9, 3, 19, 0, 0),
        Type = EventType.Online,
        TrailerUrl = "https://www.youtube.com/watch?v=BX7Oj0vEKM8&list=PLFVJi7gR5oaPzcl9h3aOY3prpkewEtQhh",
        Venues = VenueCollection.Create(online),
        Sponsors = SponsorCollection.Create(microsoft_azure, dotnetdev)
    };

    public ScheduleGrid Schedule => new ScheduleGridBuilder()
        .ForDay(1)
        .AddTrack(main)

        .AddTimeSlot(new TimeOnly(19, 0), 10, slot => slot
            .At(0, session_intro))

        .AddTimeSlot(new TimeOnly(19, 15), 30, slot => slot
            .At(0, dotnet5_chronicles))

        .AddTimeSlot(new TimeOnly(19, 50), 30, slot => slot
            .At(0, dotnet5_fsharp5))

        .AddTimeSlot(new TimeOnly(20, 25), 30, slot => slot
            .At(0, async_programming))

        .AddTimeSlot(new TimeOnly(21, 0), 30, slot => slot
            .At(0, dapper_orm))

        .AddTimeSlot(new TimeOnly(21, 35), 30, slot => slot
            .At(0, panel_talk))

        .Build();
}
