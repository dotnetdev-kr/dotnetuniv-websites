using DotNetUniverse.Services.EventData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetUniverse.Pages.Events;

public class SeriesModel : PageModel
{
    private readonly EventDataService _eventDataService;

    public SeriesModel(EventDataService eventDataService)
    {
        _eventDataService = eventDataService;
    }

    public string Prefix { get; private set; } = "";
    public string SeriesTitle { get; private set; } = "";
    public string SeriesDescription { get; private set; } = "";
    public IReadOnlyList<IEventData> Events { get; private set; } = [];

    private static readonly Dictionary<string, (string Title, string Description)> SeriesInfo = new(StringComparer.OrdinalIgnoreCase)
    {
        ["mini"] = (".NET Conf Mini", "소규모로 진행되는 .NET Conf 미니 시리즈입니다."),
        ["live"] = (".NET L!VE", ".NET L!VE 시리즈는 라이브 스트리밍 형태로 진행되는 온라인 행사입니다."),
        ["unplugged"] = (".NET Universe: Unplugged", "언플러그드 시리즈는 소규모 네트워킹 중심의 행사입니다."),
        ["edition"] = (".NET Universe: Edition", "지역별 에디션 시리즈입니다."),
    };

    public IActionResult OnGet(string prefix)
    {
        if (string.IsNullOrEmpty(prefix))
        {
            return NotFound();
        }

        Prefix = prefix.ToLowerInvariant();

        // 해당 접두사로 시작하는 이벤트 검색
        Events = _eventDataService.AllEvents
            .Where(e => e.Slug.StartsWith($"{Prefix}/", StringComparison.OrdinalIgnoreCase))
            .OrderByDescending(e => e.Event.Date)
            .ToList();

        if (Events.Count == 0)
        {
            return NotFound();
        }

        // 시리즈 정보 설정
        if (SeriesInfo.TryGetValue(Prefix, out var info))
        {
            SeriesTitle = info.Title;
            SeriesDescription = info.Description;
        }
        else
        {
            SeriesTitle = $"{Prefix.ToUpperInvariant()} 시리즈";
            SeriesDescription = $"{Prefix} 시리즈의 행사 목록입니다.";
        }

        return Page();
    }
}
