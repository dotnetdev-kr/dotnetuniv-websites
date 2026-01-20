using DotNetUniverse.Services.EventData;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetUniverse.Pages;

public class ArchiveModel(EventDataService EventDataService) : PageModel
{
    public IReadOnlyList<IEventData> Events { get; private set; } = [];

    public void OnGet()
    {
        Events = EventDataService.AllEvents;
    }
}
