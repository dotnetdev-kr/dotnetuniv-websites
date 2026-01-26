using DotNetUniverse.Models;
using DotNetUniverse.Services.EventData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetUniverse.Pages.Sessions;

public class DetailModel : PageModel
{
    private readonly EventDataService _eventDataService;

    public DetailModel(EventDataService eventDataService)
    {
        _eventDataService = eventDataService;
    }

    /// <summary>
    /// 세션 정보
    /// </summary>
    public Session Session { get; private set; } = null!;

    /// <summary>
    /// 행사 정보
    /// </summary>
    public IEventData Event { get; private set; } = null!;

    /// <summary>
    /// 관련 세션 목록
    /// </summary>
    public IReadOnlyList<SessionWithEvent> RelatedSessions { get; private set; } = [];

    public IActionResult OnGet(string id)
    {
        if (string.IsNullOrWhiteSpace(id))
            return NotFound();

        var sessionWithEvent = _eventDataService.GetSessionById(id);
        if (sessionWithEvent == null)
            return NotFound();

        Session = sessionWithEvent.Session;
        Event = sessionWithEvent.Event;
        RelatedSessions = _eventDataService.GetRelatedSessions(Session, 4).ToList();

        return Page();
    }
}
