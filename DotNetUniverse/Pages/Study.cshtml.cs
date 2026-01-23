using DotNetUniverse.Services.StudyData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetUniverse.Pages;

public class StudyModel : PageModel
{
    private readonly StudyDataService _studyDataService;

    public StudyModel(StudyDataService studyDataService)
    {
        _studyDataService = studyDataService;
    }

    /// <summary>
    /// 스터디 데이터
    /// </summary>
    public IStudyData? StudyData { get; private set; }

    public IActionResult OnGet(string slug)
    {
        // slug를 사용해 스터디 데이터 조회
        StudyData = _studyDataService.GetBySlug(slug);

        if (StudyData == null)
        {
            return NotFound();
        }

        return Page();
    }
}
