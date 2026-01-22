using DotNetUniverse.Models;

namespace DotNetUniverse.Services.StudyData;

/// <summary>
/// 월간닷넷 2023년 11월 - C#에서 포인터로 프로그래밍 해보기 스터디 데이터
/// </summary>
public class MonthlyDotnet2311Data : IStudyData
{
    public string Slug => "study/monthly-dotnet-2311";
    public int Year => 2023;
    public string ThemeColor => "#512BD4";
    public string ThemeColorClass => "purple";

    public StudyInfo Study => new()
    {
        Slug = Slug,
        Year = Year,
        Title = "월간닷넷 2023년 11월 - C#에서 포인터로 프로그래밍 해보기",
        Description = """
            닷넷은 여전히 매우 빠른 속도로 발전하고 있는 기술입니다. 닷넷의 최신 기술도 좋지만, 닷넷의 기본 기능도 살펴볼 만한 내용이 무척 많습니다!

            월간 닷넷에서는 닷넷의 기본 클래스 라이브러리 범주 안에서 해볼 수 있는 알차고 실용적인 지식을 직접 배우고 실습하는 커뮤니티 밋업입니다.

            C# 1.0이 처음 나왔을 때는 C#이 그저 Java 프로그래밍 언어의 복제품이라는 평가가 있었습니다. 하지만 Unsafe Context와 여기서 쓸 수 있는 포인터가 그 차이를 만듭니다!

            이번 강의에서는 성능 향상, 네이티브 API 호출, Marshal 클래스 없이 직접 포인터 연산하기 등 C#에서 포인터를 사용하는 방법을 배웁니다.
            """,
        Date = new DateTime(2023, 11, 1, 19, 0, 0),
        EndTime = new DateTime(2023, 11, 1, 22, 0, 0),
        Format = "오프라인 + 온라인",
        Platform = "Google Meet (온라인 참가자)",
        Organizer = "남정현",
        OrganizerTitle = "닷넷데브 운영진 / Developer Technologies MVP",
        Status = EventStatus.Completed,
        Fee = 10000,
        ContactEmail = "rkttu@rkttu.com",
        TargetAudience =
        [
            "닷넷의 기본 클래스 라이브러리를 깊이 있게 배우고 싶은 분",
            "C#에서 포인터 사용에 관심이 있는 분",
            "성능 최적화나 네이티브 API 호출을 배우고 싶은 분"
        ],
        Prerequisites =
        [
            "본인 소유 노트북 지참",
            "닷넷 개발 환경 사전 설치 필수",
            "C/C++ 기초 지식 (포인터 개념) 권장"
        ]
    };
}
