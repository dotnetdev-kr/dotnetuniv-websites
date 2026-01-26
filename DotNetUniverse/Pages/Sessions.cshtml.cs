using DotNetUniverse.Models;
using DotNetUniverse.Services.EventData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetUniverse.Pages;

public class SessionsModel : PageModel
{
    private readonly EventDataService _eventDataService;

    public SessionsModel(EventDataService eventDataService)
    {
        _eventDataService = eventDataService;
    }

    /// <summary>
    /// 필터: 주제
    /// </summary>
    [BindProperty(SupportsGet = true)]
    public SessionTopic? Topic { get; set; }

    /// <summary>
    /// 필터: 연도
    /// </summary>
    [BindProperty(SupportsGet = true)]
    public int? Year { get; set; }

    /// <summary>
    /// 검색 쿼리
    /// </summary>
    [BindProperty(SupportsGet = true)]
    public string? Query { get; set; }

    /// <summary>
    /// 정렬 기준
    /// </summary>
    [BindProperty(SupportsGet = true)]
    public string Sort { get; set; } = "latest";

    /// <summary>
    /// 세션 목록
    /// </summary>
    public IReadOnlyList<SessionWithEvent> Sessions { get; private set; } = [];

    /// <summary>
    /// 사용 가능한 연도 목록
    /// </summary>
    public IReadOnlyList<int> AvailableYears { get; private set; } = [];

    /// <summary>
    /// 전체 세션 수
    /// </summary>
    public int TotalSessionCount { get; private set; }

    /// <summary>
    /// 주제별 세션 수
    /// </summary>
    public Dictionary<SessionTopic, int> TopicCounts { get; private set; } = [];

    public void OnGet()
    {
        var allSessions = _eventDataService.GetAllSessionsWithVideo()
            .Select(x => new SessionWithEvent(x.Event, x.Session))
            .ToList();

        TotalSessionCount = allSessions.Count;

        // 연도별 필터링에 사용할 연도 목록
        AvailableYears = allSessions
            .Select(x => x.Event.Year)
            .Distinct()
            .OrderByDescending(y => y)
            .ToList();

        // 주제별 세션 수 계산
        TopicCounts = allSessions
            .Where(x => x.Session.Topic.HasValue)
            .GroupBy(x => x.Session.Topic!.Value)
            .ToDictionary(g => g.Key, g => g.Count());

        // 필터 적용
        var filteredSessions = allSessions.AsEnumerable();

        if (Topic.HasValue)
        {
            filteredSessions = filteredSessions.Where(x => x.Session.Topic == Topic);
        }

        if (Year.HasValue)
        {
            filteredSessions = filteredSessions.Where(x => x.Event.Year == Year);
        }

        if (!string.IsNullOrWhiteSpace(Query))
        {
            var keywords = Query.ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            filteredSessions = filteredSessions.Where(x =>
                keywords.All(k =>
                    x.Session.Title.Contains(k, StringComparison.OrdinalIgnoreCase) ||
                    x.Session.Abstract.Contains(k, StringComparison.OrdinalIgnoreCase) ||
                    x.Session.Speakers.Any(s => s.Name.Contains(k, StringComparison.OrdinalIgnoreCase)) ||
                    (x.Session.Tags?.Any(t => t.Contains(k, StringComparison.OrdinalIgnoreCase)) ?? false)));
        }

        // 정렬
        Sessions = Sort switch
        {
            "oldest" => filteredSessions.OrderBy(x => x.Event.Event.Date).ToList(),
            "title" => filteredSessions.OrderBy(x => x.Session.Title).ToList(),
            "speaker" => filteredSessions.OrderBy(x => x.Session.PrimarySpeaker.Name).ToList(),
            _ => filteredSessions.OrderByDescending(x => x.Event.Event.Date).ToList() // latest (default)
        };
    }
}
