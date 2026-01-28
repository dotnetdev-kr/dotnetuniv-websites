using DotNetUniverse.Models;

namespace DotNetUniverse.Services.StudyData;

/// <summary>
/// 닷넷데브 팟캐스트 시리즈 데이터 (2025년 12월 ~ 2026년 1월)
/// </summary>
public class DotNetDevPodcast2512Data : IStudyData
{
    public string Slug => "podcast/202512-1";
    public int Year => 2025;
    public string ThemeColor => "#512BD4";
    public string ThemeColorClass => "purple";

    public StudyInfo Study => new()
    {
        Slug = Slug,
        Year = Year,
        Title = "닷넷데브 팟캐스트 - C#과 닷넷의 새로운 기능",
        Description = """
            닷넷데브 운영진이 직접 진행하는 팟캐스트입니다.

            이번 에피소드에서는 C# 및 닷넷의 새로운 기능, 데이터베이스 및 ORM 비교, Async/Await 사용 시 주의사항, 그리고 객체 매핑 라이브러리 비교에 대해 이야기합니다.
            """,
        Date = new DateTime(2025, 12, 13, 0, 0, 0),
        Format = "온라인 (팟캐스트)",
        Platform = "YouTube",
        Organizer = "이종훈",
        OrganizerTitle = "닷넷데브 운영진",
        Status = EventStatus.Completed,
        Videos =
        [
            new WatchVideo
            {
                Title = "닷넷데브 팟캐스트 - C#과 닷넷의 새로운 기능",
                Url = "https://www.youtube.com/watch?v=7UY2Y2g7A4Y",
                Order = 1
            }
        ],
        Sessions =
        [
            new StudySession { Title = "C# 및 닷넷의 새로운 기능", Speaker = "이종훈", Order = 1 },
            new StudySession { Title = "데이터베이스 및 ORM 비교", Speaker = "이종훈", Order = 2 },
            new StudySession { Title = "Async/Await 사용 시 주의사항", Speaker = "이종훈", Order = 3 },
            new StudySession { Title = "객체 매핑 라이브러리 비교", Speaker = "이종훈", Order = 4 }
        ],
        TargetAudience =
        [
            "C# 및 닷넷 개발에 관심 있는 개발자",
            "최신 닷넷 기술 트렌드를 알고 싶은 분"
        ]
    };
}

/// <summary>
/// 닷넷데브 팟캐스트 - C#의 미래와 닷넷 10
/// </summary>
public class DotNetDevPodcast2512_2Data : IStudyData
{
    public string Slug => "podcast/202512-2";
    public int Year => 2025;
    public string ThemeColor => "#512BD4";
    public string ThemeColorClass => "purple";

    public StudyInfo Study => new()
    {
        Slug = Slug,
        Year = Year,
        Title = "닷넷데브 팟캐스트 - C#의 미래와 닷넷 10",
        Description = """
            닷넷데브 운영진이 직접 진행하는 팟캐스트입니다.

            이번 에피소드에서는 C#의 미래가 더 빠른 이유, 그리고 닷넷 10의 신규 문법과 혼종에 대해 깊이 있게 이야기합니다.
            """,
        Date = new DateTime(2025, 12, 27, 0, 0, 0),
        Format = "온라인 (팟캐스트)",
        Platform = "YouTube",
        Organizer = "이종훈, 남정현",
        OrganizerTitle = "닷넷데브 운영진",
        Status = EventStatus.Completed,
        Videos =
        [
            new WatchVideo
            {
                Title = "닷넷데브 팟캐스트 - C#의 미래와 닷넷 10",
                Url = "https://www.youtube.com/watch?v=WP6c8kojABE",
                Order = 1
            }
        ],
        Sessions =
        [
            new StudySession { Title = "C#의 미래가 더 빠른 이유", Speaker = "이종훈, 남정현", Order = 1 },
            new StudySession { Title = "닷넷 10의 신규 문법과 혼종", Speaker = "이종훈, 남정현", Order = 2 }
        ],
        TargetAudience =
        [
            "C# 및 닷넷의 미래에 관심 있는 개발자",
            "닷넷 10의 새로운 기능을 알고 싶은 분"
        ]
    };
}

/// <summary>
/// 닷넷데브 팟캐스트 - C# 성능 최적화
/// </summary>
public class DotNetDevPodcast2601Data : IStudyData
{
    public string Slug => "podcast/202601-1";
    public int Year => 2026;
    public string ThemeColor => "#512BD4";
    public string ThemeColorClass => "purple";

    public StudyInfo Study => new()
    {
        Slug = Slug,
        Year = Year,
        Title = "닷넷데브 팟캐스트 - C# 성능 최적화",
        Description = """
            닷넷데브 운영진이 직접 진행하는 팟캐스트입니다.

            이번 에피소드에서는 왜 당신의 C# 코드는 기대보다 느리게 실행되는지 (Unity Mono 문제 등), 그리고 외부 라이브러리 없이 고성능 캐시를 구축하는 방법에 대해 이야기합니다.
            """,
        Date = new DateTime(2026, 1, 10, 0, 0, 0),
        Format = "온라인 (팟캐스트)",
        Platform = "YouTube",
        Organizer = "이종훈, 송영재",
        OrganizerTitle = "닷넷데브 운영진",
        Status = EventStatus.Completed,
        Videos =
        [
            new WatchVideo
            {
                Title = "닷넷데브 팟캐스트 - C# 성능 최적화",
                Url = "https://www.youtube.com/watch?v=n2S-Z-WogTg",
                Order = 1
            }
        ],
        Sessions =
        [
            new StudySession { Title = "왜 당신의 C# 코드는 기대보다 느리게 실행되는가 (Unity Mono 문제 등)", Speaker = "이종훈, 송영재", Order = 1 },
            new StudySession { Title = "외부 라이브러리 없이 고성능 캐시 구축하기", Speaker = "이종훈, 송영재", Order = 2 }
        ],
        TargetAudience =
        [
            "C# 성능 최적화에 관심 있는 개발자",
            "Unity 개발자",
            "고성능 시스템을 구축하고 싶은 분"
        ]
    };
}

/// <summary>
/// 닷넷데브 팟캐스트 - AI Agent와 C# 14
/// </summary>
public class DotNetDevPodcast2601_2Data : IStudyData
{
    public string Slug => "podcast/202601-2";
    public int Year => 2026;
    public string ThemeColor => "#512BD4";
    public string ThemeColorClass => "purple";

    public StudyInfo Study => new()
    {
        Slug = Slug,
        Year = Year,
        Title = "닷넷데브 팟캐스트 - AI Agent와 C# 14",
        Description = """
            닷넷데브 운영진이 직접 진행하는 팟캐스트입니다.

            이번 에피소드에서는 AI Agent와 잘 어울리는 .NET DNX 활용기, 그리고 C# 14와 .NET 10에서 프로덕션에서 실제로 중요한 언어 기능에 대해 이야기합니다.
            """,
        Date = new DateTime(2026, 1, 24, 0, 0, 0),
        Format = "온라인 (팟캐스트)",
        Platform = "YouTube",
        Organizer = "이종훈, 이상준",
        OrganizerTitle = "닷넷데브 운영진",
        Status = EventStatus.Completed,
        Videos =
        [
            new WatchVideo
            {
                Title = "닷넷데브 팟캐스트 - AI Agent와 C# 14",
                Url = "https://www.youtube.com/watch?v=DO9CddlpG3s",
                Order = 1
            }
        ],
        Sessions =
        [
            new StudySession { Title = "AI Agent와 잘 어울리는 .NET DNX 활용기", Speaker = "이종훈, 이상준", Order = 1 },
            new StudySession { Title = "C# 14와 .NET 10: 프로덕션에서 실제로 중요한 언어 기능", Speaker = "이종훈, 이상준", Order = 2 }
        ],
        TargetAudience =
        [
            "AI Agent 개발에 관심 있는 닷넷 개발자",
            "C# 14 및 닷넷 10의 새로운 기능을 알고 싶은 분",
            "프로덕션 환경에서 최신 언어 기능을 활용하고 싶은 분"
        ]
    };
}
