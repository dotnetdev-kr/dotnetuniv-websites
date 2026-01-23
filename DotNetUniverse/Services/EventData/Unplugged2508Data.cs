using DotNetUniverse.Models;
using DotNetUniverse.Models.Collections;

namespace DotNetUniverse.Services.EventData;

/// <summary>
/// 2025년 8월 .NET Universe: Unplugged 2025-08 행사 데이터
/// </summary>
public class Unplugged2508Data : IEventData
{
    public string Slug => "unplugged/202508";
    public int Year => 2025;
    public string ThemeColor => "#6f42c1";
    public string ThemeColorClass => "purple";

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

    private readonly Speaker dimohy = new()
    {
        Id = nameof(dimohy),
        Name = "dimohy (정세일)",
        Title = "Microsoft MVP",
        Bio = "닷넷데브 운영진으로 활동하고 있으며 Microsoft MVP입니다. GitHub Copilot을 활용한 개발 경험을 공유합니다."
    };

    public SpeakerCollection Speakers => SpeakerCollection.Create(
        jeonghyun_nam, dimohy
    );

    #endregion

    #region Sessions

    private Session dotnet10_file_based_app => new()
    {
        Id = nameof(dotnet10_file_based_app),
        Title = ".NET 10의 File-based App 미리보기",
        Abstract = ".NET 10에서 새롭게 도입될 File-based App을 통해 완전히 새로워진 C# 프로그래밍 환경을 미리 살펴보고, Native AOT에 대해서도 이야기해보려 합니다.",
        Speakers = [jeonghyun_nam],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(30),
        VideoUrl = "https://www.youtube.com/watch?v=f6DMr_fnfnM",
        Tags = [".NET 10", "File-based App", "Native AOT"]
    };

    private Session ai_agent_copilot => new()
    {
        Id = nameof(ai_agent_copilot),
        Title = "AI Agent를 이용한 개발 - Visual Studio 2022에서 GitHub Copilot Agent로 개발하기",
        Abstract = "최근 GitHub Copilot을 이용해 개발에 활용할 수 있을지를 확인하는 과정에서 경험한 것들을 나누는 시간을 갖겠습니다.",
        Speakers = [dimohy],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(30),
        VideoUrl = "https://www.youtube.com/watch?v=RToioPfGKQI",
        Tags = ["GitHub Copilot", "AI Agent", "Visual Studio"]
    };

    private Session bof => new()
    {
        Id = nameof(bof),
        Title = "BoF (Birds of a Feather)",
        Abstract = "세션 종료 후에는 자유롭게 네트워킹하는 시간을 진행합니다.",
        Speakers = [jeonghyun_nam, dimohy],
        Format = SessionFormat.Panel,
        Duration = TimeSpan.FromMinutes(30),
        Tags = ["네트워킹", "BoF"]
    };

    #endregion

    #region Tracks

    private Track main => new()
    {
        Id = nameof(main),
        Name = "Main",
        Description = "메인 세션",
        Color = "#6f42c1",
        Sessions = SessionCollection.Create(
            dotnet10_file_based_app, ai_agent_copilot, bof
        )
    };

    #endregion

    #region Venue

    private VenueInfo online => new()
    {
        Id = nameof(online),
        Name = "Google Meet (온라인)",
        Address = "온라인",
        Tracks = TrackCollection.Create(main)
    };

    #endregion

    public EventInfo Event => new()
    {
        Slug = Slug,
        Year = 2025,
        Title = ".NET Universe: Unplugged 2025-08",
        Scale = EventScale.Meetup,
        Theme = ".NET 10 Preview와 AI Agent 개발",
        Description = """
            .NET Unplugged는 .NET에 관심이 있는 분들 누구나 참여할 수 있는 행사로, 
            행사에 직접 참석하는 것은 물론 행사 종료 이후 닷넷데브 YouTube 채널을 통해 세션이 공유되는 온라인 이벤트입니다.
            이벤트는 Google Meet으로 평일 저녁에 진행됩니다.
            
            .NET 기술에 관한 본인의 인사이트, 최근에 만들어서 자랑하고 싶었던 오픈 소스 프로젝트, 
            회사에서의 도입 사례 등 다양한 주제로 자유롭게 발표할 수 있습니다.
            """,
        Date = new DateTime(2025, 8, 1, 19, 0, 0),
        Type = EventType.Online,
        Venues = VenueCollection.Create(online),
        Sponsors = SponsorCollection.Create()
    };

    public ScheduleGrid Schedule => new ScheduleGridBuilder()
        .ForDay(1)
        .AddTrack(main)

        .AddTimeSlot(new TimeOnly(19, 0), 30, slot => slot
            .At(0, dotnet10_file_based_app))

        .AddTimeSlot(new TimeOnly(19, 35), 30, slot => slot
            .At(0, ai_agent_copilot))

        .AddTimeSlot(new TimeOnly(20, 10), 30, slot => slot
            .At(0, bof))

        .Build();
}
