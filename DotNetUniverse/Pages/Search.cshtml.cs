using DotNetUniverse.Services.EventData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetUniverse.Pages;

public class SearchModel : PageModel
{
    private readonly EventDataService _eventDataService;

    public SearchModel(EventDataService eventDataService)
    {
        _eventDataService = eventDataService;
    }

    [BindProperty(SupportsGet = true)]
    public string? Query { get; set; }

    public IReadOnlyList<SearchResult> Results { get; private set; } = [];

    public int SessionCount { get; private set; }
    public int SpeakerCount { get; private set; }
    public int EventCount { get; private set; }

    public void OnGet()
    {
        if (!string.IsNullOrWhiteSpace(Query))
        {
            Results = _eventDataService.Search(Query).ToList();
            SessionCount = Results.Count(r => r.Type == SearchResultType.Session);
            SpeakerCount = Results.Count(r => r.Type == SearchResultType.Speaker);
            EventCount = Results.Count(r => r.Type == SearchResultType.Event);
        }
    }
}
