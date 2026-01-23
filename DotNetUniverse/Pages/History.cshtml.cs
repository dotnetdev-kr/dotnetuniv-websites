using DotNetUniverse.Services.EventData;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetUniverse.Pages;

public class HistoryModel(EventDataService EventDataService) : PageModel
{
    public IReadOnlyList<int> AvailableYears { get; private set; } = [];
    public Dictionary<int, IReadOnlyList<IEventData>> EventsByYear { get; private set; } = [];

    public void OnGet()
    {
        AvailableYears = EventDataService.AvailableYears;
        EventsByYear = AvailableYears.ToDictionary(
            year => year,
            year => EventDataService.GetEventsByYear(year));
    }
}
