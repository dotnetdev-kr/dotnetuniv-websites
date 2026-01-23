using DotNetUniverse.Models;

namespace DotNetUniverse.Services.StudyData;

/// <summary>
/// 월간닷넷 2023년 8월 - 정규표현식 기초 배워보기 스터디 데이터
/// </summary>
public class MonthlyDotnet2308Data : IStudyData
{
    public string Slug => "monthly/202308";
    public int Year => 2023;
    public string ThemeColor => "#512BD4";
    public string ThemeColorClass => "purple";

    public StudyInfo Study => new()
    {
        Slug = Slug,
        Year = Year,
        Title = "월간닷넷 2023년 8월 - 정규표현식 기초 배워보기",
        Description = """
            닷넷은 여전히 매우 빠른 속도로 발전하고 있는 기술입니다. 닷넷의 최신 기술도 좋지만, 닷넷의 기본 기능도 살펴볼 만한 내용이 무척 많습니다!

            월간 닷넷에서는 닷넷의 기본 클래스 라이브러리 범주 안에서 해볼 수 있는 알차고 실용적인 지식을 직접 배우고 실습하는 커뮤니티 밋업입니다.

            정규표현식을 사용하면 복잡하고 까다로운 문자열 형식 검사, 문자열 치환 작업, 그리고 문자열 내에서 여러 패턴을 그룹으로 묶어서 논리적으로 관리할 수 있는 기능을 쉽게 구현할 수 있습니다. 
            같은 작업이지만, 정규표현식을 사용하면 수십줄이 넘는 코드를 5줄 이내로 줄이는 것도 가능합니다!
            """,
        Date = new DateTime(2023, 8, 1, 19, 0, 0),
        EndTime = new DateTime(2023, 8, 1, 22, 0, 0),
        Format = "오프라인 + 온라인",
        Platform = "Google Meet (온라인 참가자)",
        Organizer = "남정현",
        OrganizerTitle = "닷넷데브 운영진 / Developer Technologies MVP",
        Status = EventStatus.Completed,
        Fee = 10000,
        ContactEmail = "rkttu@rkttu.com",
        Videos =
        [
            new WatchVideo
            {
                Title = "월간닷넷 2023년 8월 - 정규표현식 기초 배워보기",
                Url = "https://www.youtube.com/watch?v=zMkoKO9VKzU",
                Order = 1
            }
        ],
        TargetAudience =
        [
            "닷넷의 기본 클래스 라이브러리를 깊이 있게 배우고 싶은 분",
            "정규표현식을 처음 접하거나 기초를 다지고 싶은 분",
            "문자열 처리를 효율적으로 하고 싶은 개발자"
        ],
        Prerequisites =
        [
            "본인 소유 노트북 지참",
            "닷넷 개발 환경 사전 설치 필수",
            "LINQPad 설치 권장 (https://linqpad.net)"
        ]
    };
}
