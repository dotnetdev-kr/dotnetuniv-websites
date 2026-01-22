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
    /// 스터디 목록
    /// </summary>
    public IReadOnlyList<IStudyData> Studies { get; private set; } = [];

    public void OnGet()
    {
        Studies = _studyDataService.AllStudies;
    }
}
