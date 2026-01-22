using DotNetUniverse.Services.StudyData;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetUniverse.Pages;

public class MonthlyDotnetModel : PageModel
{
    private readonly StudyDataService _studyDataService;

    public MonthlyDotnetModel(StudyDataService studyDataService)
    {
        _studyDataService = studyDataService;
    }

    /// <summary>
    /// 월간닷넷 지난 스터디 목록
    /// </summary>
    public IReadOnlyList<IStudyData> PastStudies { get; private set; } = [];

    public void OnGet()
    {
        // 월간닷넷 스터디만 필터링 (slug가 monthly-dotnet으로 시작하는 것)
        PastStudies = _studyDataService.AllStudies
            .Where(s => s.Slug.Contains("monthly-dotnet-"))
            .OrderByDescending(s => s.Study.Date)
            .ToList();
    }
}
