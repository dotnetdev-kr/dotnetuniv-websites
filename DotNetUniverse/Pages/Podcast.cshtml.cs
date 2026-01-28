using DotNetUniverse.Services.StudyData;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetUniverse.Pages;

public class PodcastModel : PageModel
{
    private readonly StudyDataService _studyDataService;

    public PodcastModel(StudyDataService studyDataService)
    {
        _studyDataService = studyDataService;
    }

    /// <summary>
    /// 팟캐스트 지난 에피소드 목록
    /// </summary>
    public IReadOnlyList<IStudyData> PastEpisodes { get; private set; } = [];

    public void OnGet()
    {
        // 팟캐스트 에피소드만 필터링 (slug가 podcast/로 시작하는 것)
        PastEpisodes = _studyDataService.AllStudies
            .Where(s => s.Slug.StartsWith("podcast/"))
            .OrderByDescending(s => s.Study.Date)
            .ToList();
    }
}
