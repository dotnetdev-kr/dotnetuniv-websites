using DotNetUniverse.Models;

namespace DotNetUniverse.Services.StudyData;

/// <summary>
/// Build 2023 After Party 스터디 데이터
/// </summary>
public class Build2023AfterPartyData : IStudyData
{
    public string Slug => "study/build-2023-after-party";
    public int Year => 2023;
    public string ThemeColor => "#0078d4";
    public string ThemeColorClass => "primary";

    public StudyInfo Study => new()
    {
        Slug = Slug,
        Year = Year,
        Title = "Build 2023 After Party",
        Description = """
            이 이벤트에서는 지난 5월 23일에 열린 Microsoft Build 2023에서 공개된 여러 새로운 기술 관련 주제들 중, 
            닷넷 기술, 개발자 경험, 그리고 ChatGPT를 개발자 관점에서 고도화하기 위한 내용을 중심으로 
            핵심 콘텐츠들을 살펴보는 온라인 미니 세미나를 진행합니다.

            Build After Party 2023 x .NET Dev는 Build 2023에서 공개된 영상들 중, 이벤트 오거나이저가 엄선한 영상 3편을 
            연속으로 시청하고, 그후 1시간 정도 새롭게 출시된 기술에 대한 정보를 자유롭게 이야기하면서 네트워킹하는 
            Birds of Feather 세션으로 구성됩니다.
            """,
        Date = new DateTime(2023, 6, 10, 13, 0, 0),
        EndTime = new DateTime(2023, 6, 10, 17, 50, 0),
        Format = "온라인",
        Platform = "Google Meet",
        Organizer = "남정현",
        OrganizerTitle = "닷넷데브/Microsoft Azure MVP",
        Status = EventStatus.Completed,
        Fee = 0,
        ContactEmail = "rkttu@rkttu.com",
        Videos =
        [
            new WatchVideo
            {
                Title = "What's new in C# 12 and beyond",
                Url = "https://build.microsoft.com/en-US/sessions/7bdbc522-10ed-4114-a0f1-afd45acbf7ee?source=sessions",
                Order = 1
            },
            new WatchVideo
            {
                Title = "New developer experiences in Windows",
                Url = "https://build.microsoft.com/en-US/sessions/5017d756-1ed1-468c-bd43-1ac98079f71e?source=sessions",
                Order = 2
            },
            new WatchVideo
            {
                Title = "Building AI solutions with Semantic Kernel",
                Url = "https://build.microsoft.com/en-US/sessions/31e11443-70d3-4020-8c8c-0a654bccd233?source=sessions",
                Order = 3
            }
        ]
    };
}
