using DotNetUniverse.Services.StudyData;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetUniverse.Pages;

public class StudyListModel : PageModel
{
    private readonly StudyDataService _studyDataService;

    public StudyListModel(StudyDataService studyDataService)
    {
        _studyDataService = studyDataService;
    }

    /// <summary>
    /// 사용 가능한 연도 목록 (최신순)
    /// </summary>
    public IReadOnlyList<int> AvailableYears { get; private set; } = [];

    /// <summary>
    /// 연도별 스터디 목록
    /// </summary>
    public Dictionary<int, IReadOnlyList<IStudyData>> StudiesByYear { get; private set; } = [];

    public void OnGet()
    {
        AvailableYears = _studyDataService.AvailableYears;
        StudiesByYear = AvailableYears.ToDictionary(
            year => year,
            year => _studyDataService.GetStudiesByYear(year));
    }
}
