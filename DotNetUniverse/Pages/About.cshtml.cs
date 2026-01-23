using DotNetUniverse.Models;
using DotNetUniverse.Services.EventData;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetUniverse.Pages;

public class AboutModel : PageModel
{
    private readonly EventDataService _eventDataService;

    public AboutModel(EventDataService eventDataService)
    {
        _eventDataService = eventDataService;
    }

    /// <summary>
    /// 행사 통계
    /// </summary>
    public EventStatistics Statistics { get; private set; } = new();

    /// <summary>
    /// 역대 후원사 목록 (중복 제거, 가나다순)
    /// </summary>
    public IReadOnlyList<Sponsor> AllSponsors { get; private set; } = [];

    public void OnGet()
    {
        Statistics = _eventDataService.GetStatistics();
        AllSponsors = _eventDataService.GetAllSponsors();
    }
}
