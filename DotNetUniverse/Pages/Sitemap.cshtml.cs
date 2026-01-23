using DotNetUniverse.Models;
using DotNetUniverse.Services.EventData;
using DotNetUniverse.Services.StudyData;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetUniverse.Pages;

public class SitemapModel : PageModel
{
    private readonly EventDataService _eventDataService;
    private readonly StudyDataService _studyDataService;
    private readonly IConfiguration _configuration;

    public SitemapModel(
        EventDataService eventDataService,
        StudyDataService studyDataService,
        IConfiguration configuration)
    {
        _eventDataService = eventDataService;
        _studyDataService = studyDataService;
        _configuration = configuration;
    }

    public List<SitemapUrl> Urls { get; private set; } = [];

    public void OnGet()
    {
        var baseUrl = _configuration["SiteUrl"] ?? "https://dotnetuniverse.kr";
        var now = DateTime.UtcNow;

        // 메인 페이지들
        Urls.Add(new SitemapUrl($"{baseUrl}/", now, "daily", 1.0));
        Urls.Add(new SitemapUrl($"{baseUrl}/About", now, "monthly", 0.8));
        Urls.Add(new SitemapUrl($"{baseUrl}/History", now, "weekly", 0.8));
        Urls.Add(new SitemapUrl($"{baseUrl}/Calendar", now, "weekly", 0.7));
        Urls.Add(new SitemapUrl($"{baseUrl}/Search", now, "weekly", 0.6));
        Urls.Add(new SitemapUrl($"{baseUrl}/Sponsorship", now, "monthly", 0.7));
        Urls.Add(new SitemapUrl($"{baseUrl}/Sponsorship/Ko", now, "monthly", 0.6));
        Urls.Add(new SitemapUrl($"{baseUrl}/Sponsorship/En", now, "monthly", 0.6));
        Urls.Add(new SitemapUrl($"{baseUrl}/CodeOfConduct", now, "yearly", 0.5));
        Urls.Add(new SitemapUrl($"{baseUrl}/Privacy", now, "yearly", 0.3));
        Urls.Add(new SitemapUrl($"{baseUrl}/StudyList", now, "weekly", 0.6));

        // 이벤트 시리즈 페이지들
        foreach (var year in _eventDataService.AvailableYears)
        {
            Urls.Add(new SitemapUrl($"{baseUrl}/Events/Series/{year}", now, "weekly", 0.7));
        }

        // 개별 이벤트 페이지들
        foreach (var eventData in _eventDataService.AllEvents)
        {
            var priority = eventData.Event.Status switch
            {
                EventStatus.Registration or EventStatus.CallForParticipation => 0.9,
                EventStatus.Completed => 0.6,
                _ => 0.5
            };

            var changeFreq = eventData.Event.Status switch
            {
                EventStatus.Registration or EventStatus.CallForParticipation => "daily",
                EventStatus.Completed => "monthly",
                _ => "weekly"
            };

            Urls.Add(new SitemapUrl($"{baseUrl}/Events/{eventData.Slug}", now, changeFreq, priority));
        }

        // 스터디 페이지들
        foreach (var studyData in _studyDataService.AllStudies)
        {
            Urls.Add(new SitemapUrl($"{baseUrl}/Study/{studyData.Slug}", now, "monthly", 0.5));
        }
    }
}

public record SitemapUrl(string Loc, DateTime LastMod, string ChangeFreq, double Priority);
