using DotNetUniverse.Models;
using DotNetUniverse.Models.Collections;

namespace DotNetUniverse.Services.EventData;

/// <summary>
/// 2020년 7월 .NET Conf Mini 20.07 행사 데이터
/// </summary>
public class Mini2007Data : IEventData
{
    public string Slug => "mini/2007";
    public int Year => 2020;
    public string ThemeColor => "#17a2b8";
    public string ThemeColorClass => "info";

    #region Speakers

    private readonly Speaker jinwook_jung = new()
    {
        Id = nameof(jinwook_jung),
        Name = "정진욱",
        Title = "개발자",
        Bio = "F# 및 함수형 프로그래밍에 관심이 많은 개발자입니다."
    };

    private readonly Speaker hyunmo_ahn = new()
    {
        Id = nameof(hyunmo_ahn),
        Name = "안현모",
        Title = "개발자",
        Bio = "ASP.NET Core 웹 개발 전문가입니다."
    };

    private readonly Speaker changhoon_kang = new()
    {
        Id = nameof(changhoon_kang),
        Name = "강창훈",
        Title = "대표",
        Company = "(주)엠소프트웨어",
        Bio = "(주)엠소프트웨어 대표이며 Microsoft MVP (AI)로 활동하고 있습니다. SignalR을 활용한 실시간 웹 메시징 시스템 전문가입니다."
    };

    private readonly Speaker sanghoon_han = new()
    {
        Id = nameof(sanghoon_han),
        Name = "한상훈",
        Title = "개발자",
        Bio = "ASP.NET 웹 개발에 관심이 많은 개발자입니다."
    };

    private readonly Speaker minhyuk_kwon = new()
    {
        Id = nameof(minhyuk_kwon),
        Name = "권민혁",
        Title = "개발자",
        Bio = "데이터 엔지니어링 및 데이터 처리에 관심이 많은 개발자입니다."
    };

    public SpeakerCollection Speakers => SpeakerCollection.Create(
        jinwook_jung, hyunmo_ahn, changhoon_kang, sanghoon_han, minhyuk_kwon
    );

    #endregion

    #region Sessions

    private Session fsharp_order => new()
    {
        Id = nameof(fsharp_order),
        Title = "F# 소스 코드에는 순서가 있다",
        Abstract = """
            F#의 특징 중 하나인 소스 코드 순서에 대해 이야기합니다.
            함수형 프로그래밍 언어인 F#에서 코드 순서가 왜 중요한지, 어떻게 활용할 수 있는지 알아봅니다.
            """,
        Speakers = [jinwook_jung],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(30),
        Tags = ["F#", "함수형 프로그래밍"]
    };

    private Session request_parameter => new()
    {
        Id = nameof(request_parameter),
        Title = "ASP.NET Core의 Request Parameter와 FromBody에 대한 고찰",
        Abstract = """
            ASP.NET Core에서 Request Parameter를 처리하는 방법과 FromBody 속성의 동작 원리에 대해 심도 있게 살펴봅니다.
            실무에서 자주 마주치는 문제들과 해결 방법을 공유합니다.
            """,
        Speakers = [hyunmo_ahn],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        Tags = ["ASP.NET Core", "Web API", "Model Binding"]
    };

    private Session signalr_distributed => new()
    {
        Id = nameof(signalr_distributed),
        Title = "ASP.NET Core SignalR 분산 메시징 시스템 구축하기",
        Abstract = """
            ASP.NET Core SignalR을 활용하여 분산 환경에서 실시간 메시징 시스템을 구축하는 방법을 소개합니다.
            Scale-out 시나리오와 Redis Backplane 활용 방법을 다룹니다.
            """,
        Speakers = [changhoon_kang],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        Tags = ["SignalR", "분산 시스템", "실시간"]
    };

    private Session aspnet_beginner => new()
    {
        Id = nameof(aspnet_beginner),
        Title = "ASP.NET의 시작 (or 재시작)을 어려워하는 이들을 위한 길라잡이",
        Abstract = """
            ASP.NET을 처음 시작하거나 다시 시작하려는 개발자들을 위한 가이드입니다.
            ASP.NET의 기본 개념부터 실제 프로젝트 구성까지 단계별로 안내합니다.
            """,
        Speakers = [sanghoon_han],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        Tags = ["ASP.NET", "입문", "웹 개발"]
    };

    private Session data_handling => new()
    {
        Id = nameof(data_handling),
        Title = "데이터 잘 다루는 법",
        Abstract = """
            효율적인 데이터 처리 기법과 .NET에서의 데이터 다루기 베스트 프랙티스를 소개합니다.
            """,
        Speakers = [minhyuk_kwon],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        Tags = ["데이터", ".NET"],
        Notes = ["온디맨드 비디오"]
    };

    #endregion

    #region Tracks

    private Track main => new()
    {
        Id = nameof(main),
        Name = "Main",
        Description = "메인 세션",
        Color = "#17a2b8",
        Sessions = SessionCollection.Create(
            fsharp_order, request_parameter, signalr_distributed,
            aspnet_beginner, data_handling
        )
    };

    #endregion

    #region Venue

    private VenueInfo online => new()
    {
        Id = nameof(online),
        Name = "온라인 (Meetup)",
        Address = "온라인",
        Tracks = TrackCollection.Create(main)
    };

    #endregion

    public EventInfo Event => new()
    {
        Slug = Slug,
        Year = 2020,
        Title = ".NET Conf Mini 20.07",
        Scale = EventScale.Meetup,
        Theme = "비정기 닷넷 개발자 세미나",
        Description = """
            비정기적으로 열리는 닷넷 개발자들을 위한 세미나인 닷넷콘 미니의 2020년 7월 이벤트입니다.
            F#, ASP.NET Core, SignalR 등 다양한 주제의 세션이 진행되었습니다.
            """,
        Date = new DateTime(2020, 7, 1, 19, 0, 0),
        Type = EventType.Online,
        Venues = VenueCollection.Create(online)
    };

    public ScheduleGrid Schedule => new ScheduleGridBuilder()
        .ForDay(1)
        .AddTrack(main)

        .AddTimeSlot(new TimeOnly(19, 0), 30, slot => slot
            .At(0, fsharp_order))

        .AddTimeSlot(new TimeOnly(19, 35), 40, slot => slot
            .At(0, request_parameter))

        .AddTimeSlot(new TimeOnly(20, 20), 40, slot => slot
            .At(0, signalr_distributed))

        .AddTimeSlot(new TimeOnly(21, 5), 40, slot => slot
            .At(0, aspnet_beginner))

        .Build();
}
