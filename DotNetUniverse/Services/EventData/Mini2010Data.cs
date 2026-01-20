using DotNetUniverse.Models;
using DotNetUniverse.Models.Collections;

namespace DotNetUniverse.Services.EventData;

/// <summary>
/// 2020년 10월 .NET Conf Mini 20.10 행사 데이터
/// </summary>
public class Mini2010Data : IEventData
{
    public string Slug => "mini/2010";
    public int Year => 2020;
    public string ThemeColor => "#17a2b8";
    public string ThemeColorClass => "info";

    #region Speakers

    private readonly Speaker junghyun_nam = new()
    {
        Id = nameof(junghyun_nam),
        Name = "남정현",
        Title = "DevOps 엔지니어",
        Company = "데브시스터즈",
        Bio = "데브시스터즈에서 DevOps 엔지니어로 일하고 있습니다. 닷넷데브 운영진으로 활동하며 커뮤니티 행사를 진행하고 있습니다."
    };

    private readonly Speaker jason_kim = new()
    {
        Id = nameof(jason_kim),
        Name = "제이슨 김",
        Title = "개발자",
        Bio = "C#과 C++ 간 상호 운용성에 관심이 많은 개발자입니다. .NET 5의 새로운 기능들을 활용한 네이티브 연동 전문가입니다."
    };

    private readonly Speaker hyunmo_ahn = new()
    {
        Id = nameof(hyunmo_ahn),
        Name = "안현모",
        Title = "개발자",
        Bio = "Windows Forms 기반 엔터프라이즈 애플리케이션 개발 전문가입니다. Infragistics 컨트롤을 활용한 비즈니스 애플리케이션 개발 경험이 풍부합니다."
    };

    private readonly Speaker justin_yoo = new()
    {
        Id = nameof(justin_yoo),
        Name = "유 저스틴",
        Title = "Cloud Advocate",
        Company = "Microsoft",
        Bio = "Microsoft Cloud Advocate로 활동하고 있습니다. GitHub Codespaces, VS Code Remote Containers 등 개발자 클라우드 도구 전문가입니다."
    };

    private readonly Speaker yongjun_park = new()
    {
        Id = nameof(yongjun_park),
        Name = "박용준",
        Title = "MVP",
        Bio = "C# 언어와 .NET 플랫폼의 새로운 기능을 꾸준히 연구하고 공유하는 Microsoft MVP입니다."
    };

    public SpeakerCollection Speakers => SpeakerCollection.Create(
        junghyun_nam, jason_kim, hyunmo_ahn, justin_yoo, yongjun_park
    );

    #endregion

    #region Sessions

    private Session opening => new()
    {
        Id = nameof(opening),
        Title = "스피커, 컨퍼런스 소개 및 커뮤니티 공지",
        Abstract = "닷넷콘 미니 20.10 행사 소개와 커뮤니티 공지사항을 안내합니다.",
        Speakers = [junghyun_nam],
        Format = SessionFormat.Keynote,
        Duration = TimeSpan.FromMinutes(10),
        VideoUrl = "https://youtu.be/flemyxCbl1o",
        Tags = ["Opening", "커뮤니티"]
    };

    private Session native_interop => new()
    {
        Id = nameof(native_interop),
        Title = "네이티브가 닷넷에게, 닷넷이 네이티브에게",
        Abstract = """
            C#과 C++ 간 기능을 상호 운영할 수 있는 방법에 대하여 살펴보고, 
            .NET 5에서 소개된 UnmanagedCallersOnlyAttribute를 이용하여 
            C# 기능을 C++에서 사용할 수 있는 가장 효율적인 방법을 알아봅니다.
            """,
        Speakers = [jason_kim],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        VideoUrl = "https://www.youtube.com/watch?v=cMfsZszpIMY",
        SlidesUrl = "https://drive.google.com/file/d/1eRjtmMGp2GFr2GSZJoMUdMH23gqusehB/view?usp=sharing",
        Tags = ["Interop", "C++", ".NET 5", "Native"]
    };

    private Session ultragrid => new()
    {
        Id = nameof(ultragrid),
        Title = "Infragistics UltraGrid를 활용한 범용 그리드 만들기",
        Abstract = """
            Windows Forms 기반의 Infragistics의 UltraGrid 컨트롤을 상속 받는 커스텀 데이터 그리드 컨트롤을 만들고 
            POCO 모델을 만들어 데이터 바인딩을 구현하고 비즈니스 애플리케이션에 활용하는 방법을 설명합니다.
            """,
        Speakers = [hyunmo_ahn],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        VideoUrl = "https://www.youtube.com/watch?v=mdWWs1-dEVo",
        SlidesUrl = "https://1drv.ms/p/s!Aj231qrFhIQxqcps9wFGv2N_BSEudQ?e=pxbcY1",
        Tags = ["Infragistics", "Windows Forms", "Grid", "데이터 바인딩"]
    };

    private Session codespaces => new()
    {
        Id = nameof(codespaces),
        Title = "닷넷 개발자를 위한 디벨로퍼 클라우드 - 코드스페이스, 리모트 컨테이너 소개",
        Abstract = """
            닷넷 개발을 하다 보면 매일같이 쓰는 도구들이 보통 세 가지 정도가 있습니다. 
            바로 깃헙과 비주얼 스튜디오 코드, 그리고 애저인데요. 마이크로소프트는 최근에 이를 통칭해서 디벨로퍼 클라우드라고 하고 있습니다.
            이 세션에서는 디벨로퍼 클라우드를 언제 어디서든 동일한 환경으로 쓸 수 있게 하는 코드스페이스와 리모트 컨테이너를 소개하고, 
            한 프로젝트 안에서 여러 사람이 신속하고 간편하게 동일한 개발 환경을 구축할 수 있는 방법을 함께 알아보도록 하겠습니다.
            """,
        Speakers = [justin_yoo],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(40),
        VideoUrl = "https://youtu.be/Ci_EHvrkfzE",
        SlidesUrl = "https://1drv.ms/b/s!ArWHNGHxF7lBgsw2HRY_Tp-yKL5sWQ",
        Tags = ["GitHub Codespaces", "VS Code", "Remote Containers", "DevOps"]
    };

    private Session csharp9 => new()
    {
        Id = nameof(csharp9),
        Title = "C# 9.0의 새로운 기능 소개",
        Abstract = """
            .NET 5에서 새롭게 소개되는 C# 9.0은 이전보다 더 많은 간편 구문을 제공합니다. 
            C# 9.0에 새롭게 도입된 최상위 문, 초기화 전용 Setter, 레코드, 패턴 일치 개선 사항에 대해 소개합니다.
            """,
        Speakers = [yongjun_park],
        Format = SessionFormat.Breakout,
        Duration = TimeSpan.FromMinutes(70),
        VideoUrl = "https://youtu.be/-MxSKwU9OCM",
        SlidesUrl = "https://1drv.ms/p/s!Aj231qrFhIQxqcptbkwgxjLwlQmCrA?e=9SAHMX",
        Tags = ["C# 9", "Record", "Pattern Matching", "Top-level Statements"]
    };

    private Session closing => new()
    {
        Id = nameof(closing),
        Title = "Q&A 및 경품 추첨",
        Abstract = "질의응답 및 경품 추첨 시간입니다.",
        Speakers = [],
        Format = SessionFormat.Closing,
        Duration = TimeSpan.FromMinutes(20),
        IsShared = true
    };

    #endregion

    #region Sponsors

    private readonly Sponsor jetbrains = new()
    {
        Id = nameof(jetbrains),
        Name = "JetBrains",
        Tier = SponsorTier.Silver,
        WebsiteUrl = "https://www.jetbrains.com/"
    };

    private readonly Sponsor infragistics = new()
    {
        Id = nameof(infragistics),
        Name = "Infragistics",
        Tier = SponsorTier.Silver,
        WebsiteUrl = "https://www.infragistics.co.kr/"
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
            opening, native_interop, ultragrid, codespaces, csharp9, closing
        )
    };

    #endregion

    #region Venue

    private VenueInfo online => new()
    {
        Id = nameof(online),
        Name = "온라인 (닷넷데브 YouTube 채널)",
        Address = "온라인",
        Tracks = TrackCollection.Create(main)
    };

    #endregion

    public EventInfo Event => new()
    {
        Slug = Slug,
        Year = 2020,
        Title = ".NET Conf Mini 20.10",
        Scale = EventScale.Meetup,
        Theme = "비정기 닷넷 개발자 온라인 세미나",
        Description = """
            .NET Conf Mini는 비정기적으로 열리는 닷넷 개발자들을 위한 온라인 세미나입니다. 
            닷넷을 사용하는 개발자 분들의 다채롭고 다양한 경험을 공유하기 위하여 만들어졌으며, 
            닷넷 개발자라면 누구나 발표할 수 있고, 닷넷에 관심있는 분들이라면 모두 환영합니다.
            """,
        Date = new DateTime(2020, 10, 13, 20, 0, 0),
        Type = EventType.Online,
        Venues = VenueCollection.Create(online),
        Sponsors = SponsorCollection.Create(jetbrains, infragistics)
    };

    public ScheduleGrid Schedule => new ScheduleGridBuilder()
        .ForDay(1)
        .AddTrack(main)

        .AddTimeSlot(new TimeOnly(20, 0), 10, slot => slot
            .At(0, opening))

        .AddTimeSlot(new TimeOnly(20, 10), 40, slot => slot
            .At(0, native_interop))

        .AddTimeSlot(new TimeOnly(21, 0), 40, slot => slot
            .At(0, ultragrid))

        .AddTimeSlot(new TimeOnly(21, 50), 40, slot => slot
            .At(0, codespaces))

        .AddTimeSlot(new TimeOnly(22, 40), 70, slot => slot
            .At(0, csharp9))

        .AddTimeSlot(new TimeOnly(23, 50), 20, slot => slot
            .FullWidth(closing))

        .Build();
}
