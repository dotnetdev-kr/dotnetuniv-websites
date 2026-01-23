using DotNetUniverse.Models;
using DotNetUniverse.Services.EventData;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetUniverse.Pages;

public class SponsorshipModel : PageModel
{
    private readonly EventDataService _eventDataService;

    public SponsorshipModel(EventDataService eventDataService)
    {
        _eventDataService = eventDataService;
    }

    /// <summary>
    /// 역대 후원사 목록 (중복 제거, 가나다순)
    /// </summary>
    public IReadOnlyList<Sponsor> AllSponsors { get; private set; } = [];

    public void OnGet()
    {
        AllSponsors = _eventDataService.GetAllSponsors();
    }
}
