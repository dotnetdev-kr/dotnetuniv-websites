using System.Text.RegularExpressions;
using DotNetUniverse.Models;
using DotNetUniverse.Services.EventData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetUniverse.Pages.Events;

/// <summary>
/// 행사 페이지 모델 (Slug 또는 연도 기반 라우팅 지원)
/// </summary>
public partial class EventModel : PageModel
{
    private readonly EventDataService _yearDataService;

    public EventModel(EventDataService EventDataService)
    {
        _yearDataService = EventDataService;
    }

    /// <summary>
    /// 현재 행사 데이터
    /// </summary>
    public IEventData EventData { get; private set; } = null!;

    /// <summary>
    /// 이전 행사 데이터 (있는 경우)
    /// </summary>
    public IEventData? PreviousEvent { get; private set; }

    /// <summary>
    /// 다음 행사 데이터 (있는 경우)
    /// </summary>
    public IEventData? NextEvent { get; private set; }

    /// <summary>
    /// 타임라인 정보
    /// </summary>
    public IEnumerable<EventYearTimelineItem> Timeline { get; private set; } = [];

    /// <summary>
    /// 세션 ID (쿼리스트링)
    /// </summary>
    public string? SessionId { get; set; }

    /// <summary>
    /// 연사 ID (쿼리스트링)
    /// </summary>
    public string? SpeakerId { get; set; }

    /// <summary>
    /// 하위 호환성을 위한 YearData 속성
    /// </summary>
    public IEventData YearData => EventData;

    public IActionResult OnGet(string slug, string? session, string? speaker)
    {
        IEventData? eventData = null;

        // Slug 기반 조회
        if (!string.IsNullOrEmpty(slug))
        {
            eventData = _yearDataService.GetBySlug(slug);
            
            // 연도로 해석 시도 (하위 호환성)
            if (eventData == null && int.TryParse(slug, out var year))
            {
                eventData = _yearDataService.GetEventByYear(year);
            }
        }

        if (eventData == null)
        {
            return NotFound();
        }

        EventData = eventData;
        PreviousEvent = _yearDataService.GetPreviousEvent(eventData.Slug);
        NextEvent = _yearDataService.GetNextEvent(eventData.Slug);
        Timeline = _yearDataService.GetTimeline();

        SessionId = session;
        SpeakerId = speaker;

        var baseUrl = $"{Request.Scheme}://{Request.Host}";
        var eventUrl = $"{baseUrl}/{eventData.Slug}";

        if (!string.IsNullOrEmpty(session))
        {
            var sessionInfo = EventData.Event.GetSession(session);
            if (sessionInfo != null)
            {
                ViewData["Title"] = $"{sessionInfo.Title} - {EventData.Event.Title}";
                ViewData["OgTitle"] = sessionInfo.Title;
                ViewData["OgDescription"] = sessionInfo.Description;
                ViewData["OgType"] = "article";
                ViewData["OgUrl"] = $"{eventUrl}?session={session}";
                ViewData["OgImage"] = GetYouTubeThumbnail(sessionInfo.VideoUrl) 
                    ?? EventData.Event.SocialImageUrl 
                    ?? "/card.jpg";
            }
        }
        else if (!string.IsNullOrEmpty(speaker))
        {
            var speakerInfo = EventData.Speakers.TryGet(speaker);
            if (speakerInfo != null)
            {
                ViewData["Title"] = $"{speakerInfo.Name} - {EventData.Event.Title}";
                ViewData["OgTitle"] = $"{speakerInfo.Name} ({speakerInfo.Title})";
                ViewData["OgDescription"] = speakerInfo.Bio ?? $"{speakerInfo.Name} - {EventData.Event.Title} 연사";
                ViewData["OgType"] = "profile";
                ViewData["OgUrl"] = $"{eventUrl}?speaker={speaker}";
                ViewData["OgImage"] = speakerInfo.ImageUrl 
                    ?? EventData.Event.SocialImageUrl 
                    ?? "/card.jpg";
            }
        }
        else
        {
            ViewData["Title"] = EventData.Event.Title;
            ViewData["OgTitle"] = EventData.Event.Title;
            ViewData["OgDescription"] = EventData.Event.SocialDescription;
            ViewData["OgImage"] = EventData.Event.SocialImageUrl ?? "/card.jpg";
            ViewData["OgType"] = "website";
            ViewData["OgUrl"] = eventUrl;
        }

        return Page();
    }

    private static partial class YouTubeRegex
    {
        [GeneratedRegex(@"(?:youtube\.com\/(?:watch\?v=|embed\/|v\/)|youtu\.be\/)([a-zA-Z0-9_-]{11})")]
        public static partial Regex VideoIdPattern();
    }

    private static string? GetYouTubeThumbnail(string? videoUrl)
    {
        if (string.IsNullOrEmpty(videoUrl))
            return null;

        var match = YouTubeRegex.VideoIdPattern().Match(videoUrl);
        if (match.Success)
        {
            var videoId = match.Groups[1].Value;
            return $"https://img.youtube.com/vi/{videoId}/maxresdefault.jpg";
        }

        return null;
    }
}
