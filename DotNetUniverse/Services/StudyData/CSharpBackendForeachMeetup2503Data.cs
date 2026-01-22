using DotNetUniverse.Models;

namespace DotNetUniverse.Services.StudyData;

/// <summary>
/// C# Backend Foreach Meetup 25 (3월) 스터디 데이터
/// </summary>
public class CSharpBackendForeachMeetup2503Data : IStudyData
{
    public string Slug => "study/csharp-backend-foreach-meetup-2503";
    public int Year => 2025;
    public string ThemeColor => "#68217A";
    public string ThemeColorClass => "purple";

    public StudyInfo Study => new()
    {
        Slug = Slug,
        Year = Year,
        Title = "C# Backend Foreach Meetup 25 (3월)",
        Description = """
            매달 C# 웹 백엔드에 관한 주제로 밋업을 진행합니다.

            3월 온라인 밋업에서는 초보자도 쉽게 따라 할 수 있는 웹 서버 구축과 C# 백엔드 개발의 기초를 함께 배웁니다.

            현대의 C# 웹 프레임워크인 ASP.NET Core는 다른 언어의 웹 프레임워크와 비교해도 뒤처지지 않는 쉽고 강력한 성능을 자랑합니다.
            개발 경험이 전혀 없으신 분도, 다른 언어로만 개발해 보신 분도, C#에 관심만 있었던 분도 
            누구나 쉽게 C# 백엔드 개발을 시작할 수 있다는 것을 직접 보여드립니다.

            함께 미니멀 API로 빠르게 웹 서버를 만들어 보며, ASP.NET Core의 강력함과 가벼움을 느껴보세요!
            """,
        Date = new DateTime(2025, 3, 13, 20, 0, 0),
        EndTime = new DateTime(2025, 3, 13, 22, 0, 0),
        Format = "온라인",
        Platform = "온라인 (이메일로 링크 전송)",
        Organizer = "이종훈",
        OrganizerTitle = "C# 개발자",
        Status = EventStatus.Completed,
        Fee = 0,
        RegistrationUrl = "https://event-us.kr/m/99575/31077",
        ContactEmail = "atawlee@hotmail.com",
        Sessions =
        [
            new StudySession
            {
                Title = "웹 서버 기초 설명 & C# 프로젝트 기초 설명",
                StartTime = new DateTime(2025, 3, 13, 20, 0, 0),
                EndTime = new DateTime(2025, 3, 13, 20, 50, 0),
                Order = 1
            },
            new StudySession
            {
                Title = "'딸깍' Minimal API로 웹 서버 구축하기 & C# 의존성 주입에 대한 설명",
                StartTime = new DateTime(2025, 3, 13, 21, 0, 0),
                EndTime = new DateTime(2025, 3, 13, 21, 50, 0),
                Order = 2
            }
        ],
        Prerequisites =
        [
            "JetBrains Rider 설치 (무료, 약 10~15분 소요)",
            "Visual Studio 사용자도 참여 가능하지만, 실습은 Rider 기준으로 진행"
        ],
        TargetAudience =
        [
            "웹 서버를 직접 구축해보고 싶은 분",
            "C# 백엔드 개발에 관심 있는 분",
            "백엔드 개발을 처음 접하는 초보자 누구나"
        ]
    };
}
