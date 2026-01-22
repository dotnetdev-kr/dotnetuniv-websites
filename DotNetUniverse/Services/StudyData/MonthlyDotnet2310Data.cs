using DotNetUniverse.Models;

namespace DotNetUniverse.Services.StudyData;

/// <summary>
/// 월간닷넷 2023년 10월 - Windows COM 서버 사용하기 스터디 데이터
/// </summary>
public class MonthlyDotnet2310Data : IStudyData
{
    public string Slug => "study/monthly-dotnet-2310";
    public int Year => 2023;
    public string ThemeColor => "#512BD4";
    public string ThemeColorClass => "purple";

    public StudyInfo Study => new()
    {
        Slug = Slug,
        Year = Year,
        Title = "월간닷넷 2023년 10월 - Windows COM 서버 사용하기",
        Description = """
            닷넷은 여전히 매우 빠른 속도로 발전하고 있는 기술입니다. 닷넷의 최신 기술도 좋지만, 닷넷의 기본 기능도 살펴볼 만한 내용이 무척 많습니다!

            월간 닷넷에서는 닷넷의 기본 클래스 라이브러리 범주 안에서 해볼 수 있는 알차고 실용적인 지식을 직접 배우고 실습하는 커뮤니티 밋업입니다.

            Windows 프로그래밍에서 COM (Component Object Model) 기술은 닷넷 프레임워크가 출시되기 전에 나온 고급 프로그래밍 기술입니다. 
            COM은 각각의 구성 요소들을 독립적으로 재사용할 수 있게 해주고, 서로 다른 프로그래밍 언어로 만든 구성 요소를 활용할 수 있게 해주는 기술입니다.

            여러분이 매일같이 사용하는 Windows를 좀 더 심도있게 제어하고 활용할 수 있는 기술이 바로 COM입니다!
            """,
        Date = new DateTime(2023, 10, 1, 19, 0, 0),
        EndTime = new DateTime(2023, 10, 1, 22, 0, 0),
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
                Title = "월간닷넷 2023년 10월 - Windows COM 서버 사용하기",
                Url = "https://www.youtube.com/watch?v=pI1mEI_fFnc",
                Order = 1
            }
        ],
        TargetAudience =
        [
            "닷넷의 기본 클래스 라이브러리를 깊이 있게 배우고 싶은 분",
            "Windows COM 기술에 관심이 있는 분",
            "순수한 닷넷 코드만으로는 활용하기 어려운 고급 기능을 배우고 싶은 분"
        ],
        Prerequisites =
        [
            "본인 소유 노트북 지참",
            "닷넷 개발 환경 사전 설치 필수",
            "LINQPad 설치 권장 (https://linqpad.net)"
        ]
    };
}
