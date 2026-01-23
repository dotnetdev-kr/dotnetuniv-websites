using DotNetUniverse.Models;

namespace DotNetUniverse.Services.EventData;

/// <summary>
/// 행사 데이터를 관리하는 서비스
/// </summary>
public class EventDataService
{
    private readonly Dictionary<string, IEventData> _slugMap;
    private readonly Dictionary<int, List<IEventData>> _yearMap;
    private readonly List<IEventData> _allEvents;
    private readonly List<int> _availableYears;

    public EventDataService()
    {
        // 모든 행사 데이터 등록
        var eventDataList = new IEventData[]
        {
            new Year2019Data(),
            new Mini2007Data(),
            new TNL2020Data(),
            new Mini2010Data(),
            new Mini2104Data(),
            new Mini2108Data(),
            new Year2021Data(),
            new Mini2205Data(),
            new Mini2209Data(),
            new Year2022Data(),
            new Live23SpringData(),
            new Live23FallData(),
            new Year2023Data(),
            new Year2024Data(),
            new Year2025Data(),
            new Unplugged2508Data(),
            new CloudBroEditionData(),
            new BusanEdition2512Data(),
            new Year2026Data(),
        };

        _slugMap = eventDataList.ToDictionary(d => d.Slug, StringComparer.OrdinalIgnoreCase);
        _yearMap = eventDataList.GroupBy(d => d.Year).ToDictionary(g => g.Key, g => g.ToList());
        _allEvents = [.. eventDataList.OrderByDescending(d => d.Event.Date)];
        _availableYears = _yearMap.Keys.OrderByDescending(y => y).ToList();
    }

    /// <summary>
    /// 사용 가능한 연도 목록 (최신순)
    /// </summary>
    public IReadOnlyList<int> AvailableYears => _availableYears;

    /// <summary>
    /// 모든 행사 목록 (최신순)
    /// </summary>
    public IReadOnlyList<IEventData> AllEvents => _allEvents;

    /// <summary>
    /// 슬러그로 행사 데이터 조회
    /// </summary>
    public IEventData? GetBySlug(string slug) => _slugMap.GetValueOrDefault(slug);

    /// <summary>
    /// 슬러그로 행사 데이터가 있는지 확인
    /// </summary>
    public bool HasSlug(string slug) => _slugMap.ContainsKey(slug);

    /// <summary>
    /// 특정 연도의 데이터가 있는지 확인
    /// </summary>
    public bool HasYear(int year) => _yearMap.ContainsKey(year);

    /// <summary>
    /// 특정 연도의 모든 행사 데이터 조회
    /// </summary>
    public IReadOnlyList<IEventData> GetEventsByYear(int year) => 
        _yearMap.TryGetValue(year, out var events) ? events : [];

    /// <summary>
    /// 특정 연도의 주요 행사 데이터 조회 (첫 번째 컨퍼런스)
    /// </summary>
    public IEventData? GetEventByYear(int year) => 
        GetEventsByYear(year).FirstOrDefault(e => e.Event.Scale == Models.EventScale.Conference)
        ?? GetEventsByYear(year).FirstOrDefault();

    /// <summary>
    /// 모든 행사 데이터 조회 (최신순)
    /// </summary>
    public IEnumerable<IEventData> GetAllEvents() => _allEvents;

    /// <summary>
    /// 가장 최근 행사 데이터 조회
    /// </summary>
    public IEventData? GetLatestEvent() => _allEvents.FirstOrDefault();

    /// <summary>
    /// 영상이 있는 모든 세션 조회 (최신 행사 순)
    /// </summary>
    public IEnumerable<(IEventData Event, Session Session)> GetAllSessionsWithVideo()
    {
        return _allEvents
            .Where(e => !e.Event.IsUpcoming)
            .SelectMany(e => e.Event.Venues
                .SelectMany(v => v.Tracks)
                .SelectMany(t => t.Sessions)
                .Where(s => s.IsYouTubeVideo && s.IsPresentationSession)
                .Select(s => (Event: e, Session: s)));
    }

    /// <summary>
    /// 영상이 있는 세션 중 임의로 지정된 개수만큼 조회
    /// </summary>
    public IEnumerable<(IEventData Event, Session Session)> GetRandomSessionsWithVideo(int count)
    {
        var sessionsWithVideo = GetAllSessionsWithVideo().ToList();
        if (sessionsWithVideo.Count <= count)
            return sessionsWithVideo;

        return sessionsWithVideo
            .OrderBy(_ => Random.Shared.Next())
            .Take(count);
    }

    /// <summary>
    /// 역대 모든 후원사 목록 조회 (중복 제거, 가나다순 정렬)
    /// </summary>
    public IReadOnlyList<Sponsor> GetAllSponsors()
    {
        return _allEvents
            .Where(e => !e.Event.IsUpcoming)
            .SelectMany(e => e.Event.Sponsors)
            .DistinctBy(s => s.Id)
            .OrderBy(s => s.Name, StringComparer.CurrentCulture)
            .ToList();
    }

    /// <summary>
    /// 역대 후원사 목록을 등급별로 그룹화하여 조회 (중복 제거, 가나다순 정렬)
    /// </summary>
    public IEnumerable<IGrouping<SponsorTier, Sponsor>> GetAllSponsorsByTier()
    {
        return GetAllSponsors()
            .GroupBy(s => s.Tier)
            .OrderBy(g => g.Key);
    }

    /// <summary>
    /// 이전 행사 데이터 조회 (날짜순)
    /// </summary>
    public IEventData? GetPreviousEvent(string slug)
    {
        var current = GetBySlug(slug);
        if (current == null) return null;
        
        var index = _allEvents.IndexOf(current);
        return index >= 0 && index < _allEvents.Count - 1 ? _allEvents[index + 1] : null;
    }

    /// <summary>
    /// 다음 행사 데이터 조회 (날짜순)
    /// </summary>
    public IEventData? GetNextEvent(string slug)
    {
        var current = GetBySlug(slug);
        if (current == null) return null;
        
        var index = _allEvents.IndexOf(current);
        return index > 0 ? _allEvents[index - 1] : null;
    }

    /// <summary>
    /// 이전 연도 데이터 조회 (하위 호환성)
    /// </summary>
    public IEventData? GetPreviousEventByYear(int year)
    {
        var index = _availableYears.IndexOf(year);
        if (index < 0 || index >= _availableYears.Count - 1)
            return null;
        return GetEventByYear(_availableYears[index + 1]);
    }

    /// <summary>
    /// 다음 연도 데이터 조회 (하위 호환성)
    /// </summary>
    public IEventData? GetNextEventByYear(int year)
    {
        var index = _availableYears.IndexOf(year);
        if (index <= 0)
            return null;
        return GetEventByYear(_availableYears[index - 1]);
    }

    /// <summary>
    /// 연도별 타임라인 정보 생성
    /// </summary>
    public IEnumerable<EventYearTimelineItem> GetTimeline()
    {
        return _availableYears.Select(year =>
        {
            var data = GetEventByYear(year)!;
            return new EventYearTimelineItem
            {
                Year = year,
                Slug = data.Slug,
                Title = data.Event.Title,
                Description = $"{data.Event.AttendeeCount}명 참가" + 
                    (data.Event.IsUpcoming ? " (예정)" : ""),
                ThemeColorClass = data.ThemeColorClass,
                IsUpcoming = data.Event.IsUpcoming
            };
        });
    }

    /// <summary>
    /// 행사 타임라인 정보 생성 (모든 행사 포함)
    /// </summary>
    public IEnumerable<EventTimelineItem> GetEventTimeline()
    {
        return _allEvents.Select(data => new EventTimelineItem
        {
            Slug = data.Slug,
            Year = data.Year,
            Date = data.Event.Date,
            Title = data.Event.Title,
            Scale = data.Event.Scale,
            Description = $"{data.Event.AttendeeCount}명 참가" + 
                (data.Event.IsUpcoming ? " (예정)" : ""),
            ThemeColorClass = data.ThemeColorClass,
            IsUpcoming = data.Event.IsUpcoming
        });
    }
}

/// <summary>
/// 타임라인 표시용 연도 정보 (하위 호환성)
/// </summary>
public record EventYearTimelineItem
{
    public required int Year { get; init; }
    public required string Slug { get; init; }
    public required string Title { get; init; }
    public required string Description { get; init; }
    public required string ThemeColorClass { get; init; }
    public bool IsUpcoming { get; init; }
}

/// <summary>
/// 타임라인 표시용 행사 정보
/// </summary>
public record EventTimelineItem
{
    public required string Slug { get; init; }
    public required int Year { get; init; }
    public required DateTime Date { get; init; }
    public required string Title { get; init; }
    public required Models.EventScale Scale { get; init; }
    public required string Description { get; init; }
    public required string ThemeColorClass { get; init; }
    public bool IsUpcoming { get; init; }
}
