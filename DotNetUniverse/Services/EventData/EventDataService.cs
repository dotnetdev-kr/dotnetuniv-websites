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
    /// 행사 통계 조회
    /// </summary>
    public EventStatistics GetStatistics()
    {
        var completedEvents = _allEvents.Where(e => !e.Event.IsUpcoming).ToList();
        var conferences = completedEvents.Where(e => e.Event.Scale == EventScale.Conference).ToList();
        
        // 연도 계산 (첫 행사부터 현재까지)
        var firstYear = completedEvents.Min(e => e.Event.Date.Year);
        var yearsOfHistory = DateTime.Now.Year - firstYear + 1;
        
        // 총 참가자 수
        var totalAttendees = completedEvents
            .Where(e => e.Event.AttendeeCount.HasValue)
            .Sum(e => e.Event.AttendeeCount!.Value);
        
        // 총 세션 수
        var totalSessions = completedEvents
            .SelectMany(e => e.Event.Venues)
            .SelectMany(v => v.Tracks)
            .SelectMany(t => t.Sessions)
            .Count(s => s.IsPresentationSession);
        
        // 총 연사 수 (중복 제거)
        var totalSpeakers = completedEvents
            .SelectMany(e => e.Speakers)
            .DistinctBy(s => s.Id)
            .Count();
        
        // 총 후원사 수 (중복 제거)
        var totalSponsors = GetAllSponsors().Count;
        
        // 총 컨퍼런스 개최 횟수
        var totalConferences = conferences.Count;
        
        return new EventStatistics
        {
            YearsOfHistory = yearsOfHistory,
            TotalAttendees = totalAttendees,
            TotalSessions = totalSessions,
            TotalSpeakers = totalSpeakers,
            TotalSponsors = totalSponsors,
            TotalConferences = totalConferences
        };
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

    /// <summary>
    /// 키워드로 세션 검색
    /// </summary>
    public IEnumerable<SearchResult> Search(string query)
    {
        if (string.IsNullOrWhiteSpace(query))
            return [];

        var keywords = query.ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var results = new List<SearchResult>();

        foreach (var eventData in _allEvents)
        {
            // 행사 검색
            if (MatchesKeywords(eventData.Event.Title, keywords) ||
                MatchesKeywords(eventData.Event.Theme, keywords))
            {
                results.Add(new SearchResult
                {
                    Type = SearchResultType.Event,
                    Title = eventData.Event.Title,
                    Description = eventData.Event.Theme,
                    Url = $"/{eventData.Slug}",
                    EventSlug = eventData.Slug,
                    Date = eventData.Event.Date
                });
            }

            // 세션 검색
            foreach (var venue in eventData.Event.Venues)
            {
                foreach (var track in venue.Tracks)
                {
                    foreach (var session in track.Sessions)
                    {
                        if (!session.IsPresentationSession)
                            continue;

                        if (MatchesKeywords(session.Title, keywords) ||
                            MatchesKeywords(session.Abstract, keywords) ||
                            (session.Tags?.Any(t => MatchesKeywords(t, keywords)) ?? false))
                        {
                            var shortDesc = session.Abstract.Length > 100 
                                ? session.Abstract[..100] + "..." 
                                : session.Abstract;
                            results.Add(new SearchResult
                            {
                                Type = SearchResultType.Session,
                                Title = session.Title,
                                Description = shortDesc,
                                Url = $"/{eventData.Slug}?session={session.Id}",
                                EventSlug = eventData.Slug,
                                EventTitle = eventData.Event.Title,
                                Date = eventData.Event.Date,
                                SpeakerName = session.PrimarySpeaker.Name,
                                Tags = session.Tags
                            });
                        }
                    }
                }
            }

            // 발표자 검색
            foreach (var speaker in eventData.Speakers)
            {
                if (MatchesKeywords(speaker.Name, keywords) ||
                    MatchesKeywords(speaker.Company, keywords) ||
                    MatchesKeywords(speaker.Title, keywords))
                {
                    // 중복 발표자 제외
                    if (!results.Any(r => r.Type == SearchResultType.Speaker && r.Title == speaker.Name))
                    {
                        results.Add(new SearchResult
                        {
                            Type = SearchResultType.Speaker,
                            Title = speaker.Name,
                            Description = string.IsNullOrEmpty(speaker.Company) 
                                ? speaker.Title 
                                : $"{speaker.Company} - {speaker.Title}",
                            Url = $"/{eventData.Slug}?speaker={speaker.Id}",
                            EventSlug = eventData.Slug,
                            ImageUrl = speaker.ResolvedImageUrl
                        });
                    }
                }
            }
        }

        return results
            .OrderByDescending(r => r.Date ?? DateTime.MinValue)
            .ThenBy(r => r.Type);
    }

    private static bool MatchesKeywords(string? text, string[] keywords)
    {
        if (string.IsNullOrEmpty(text))
            return false;

        var lowerText = text.ToLower();
        return keywords.All(k => lowerText.Contains(k));
    }

    /// <summary>
    /// 영상이 있는 모든 세션 개수 조회
    /// </summary>
    public int GetSessionsWithVideoCount()
    {
        return GetAllSessionsWithVideo().Count();
    }

    /// <summary>
    /// 영상이 있는 세션을 주제별로 그룹화하여 조회
    /// </summary>
    public IEnumerable<IGrouping<SessionTopic?, SessionWithEvent>> GetSessionsWithVideoByTopic()
    {
        return GetAllSessionsWithVideo()
            .Select(x => new SessionWithEvent(x.Event, x.Session))
            .GroupBy(x => x.Session.Topic)
            .OrderBy(g => g.Key);
    }

    /// <summary>
    /// 영상이 있는 세션을 연도별로 그룹화하여 조회
    /// </summary>
    public IEnumerable<IGrouping<int, SessionWithEvent>> GetSessionsWithVideoByYear()
    {
        return GetAllSessionsWithVideo()
            .Select(x => new SessionWithEvent(x.Event, x.Session))
            .GroupBy(x => x.Event.Year)
            .OrderByDescending(g => g.Key);
    }

    /// <summary>
    /// 특정 세션 ID로 세션과 행사 정보 조회
    /// </summary>
    public SessionWithEvent? GetSessionById(string sessionId)
    {
        foreach (var eventData in _allEvents)
        {
            foreach (var venue in eventData.Event.Venues)
            {
                foreach (var track in venue.Tracks)
                {
                    var session = track.Sessions.FirstOrDefault(s => s.Id == sessionId);
                    if (session != null)
                        return new SessionWithEvent(eventData, session);
                }
            }
        }
        return null;
    }

    /// <summary>
    /// 특정 세션의 관련 세션 조회 (같은 주제 또는 같은 발표자, 부족하면 랜덤으로 채움)
    /// </summary>
    public IEnumerable<SessionWithEvent> GetRelatedSessions(Session session, int count = 4)
    {
        var allSessions = GetAllSessionsWithVideo()
            .Where(x => x.Session.Id != session.Id)
            .Select(x => new SessionWithEvent(x.Event, x.Session))
            .ToList();

        // 같은 주제의 세션
        var relatedByTopic = session.Topic.HasValue
            ? allSessions.Where(x => x.Session.Topic == session.Topic).ToList()
            : [];

        // 같은 발표자의 세션
        var relatedBySpeaker = allSessions
            .Where(x => x.Session.Speakers.Any(s => session.Speakers.Any(ss => ss.Id == s.Id)))
            .ToList();

        // 관련 세션 합치기 (중복 제거)
        var relatedSessions = relatedByTopic
            .Concat(relatedBySpeaker)
            .DistinctBy(x => x.Session.Id)
            .Take(count)
            .ToList();

        // 관련 세션이 부족하면 랜덤 세션으로 채움
        if (relatedSessions.Count < count)
        {
            var excludeIds = relatedSessions.Select(x => x.Session.Id).Append(session.Id).ToHashSet();
            var randomSessions = allSessions
                .Where(x => !excludeIds.Contains(x.Session.Id))
                .OrderBy(_ => Random.Shared.Next())
                .Take(count - relatedSessions.Count);
            
            relatedSessions.AddRange(randomSessions);
        }

        return relatedSessions;
    }
}

/// <summary>
/// 세션과 행사 정보를 함께 담는 레코드
/// </summary>
public record SessionWithEvent(IEventData Event, Session Session);

/// <summary>
/// 검색 결과 유형
/// </summary>
public enum SearchResultType
{
    Event,
    Session,
    Speaker
}

/// <summary>
/// 검색 결과
/// </summary>
public record SearchResult
{
    public required SearchResultType Type { get; init; }
    public required string Title { get; init; }
    public string? Description { get; init; }
    public required string Url { get; init; }
    public string? EventSlug { get; init; }
    public string? EventTitle { get; init; }
    public DateTime? Date { get; init; }
    public string? SpeakerName { get; init; }
    public string[]? Tags { get; init; }
    public string? ImageUrl { get; init; }
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

/// <summary>
/// 행사 통계 정보
/// </summary>
public record EventStatistics
{
    /// <summary>
    /// 역사 (년)
    /// </summary>
    public int YearsOfHistory { get; init; }
    
    /// <summary>
    /// 총 참가자 수
    /// </summary>
    public int TotalAttendees { get; init; }
    
    /// <summary>
    /// 총 세션 수
    /// </summary>
    public int TotalSessions { get; init; }
    
    /// <summary>
    /// 총 연사 수 (중복 제거)
    /// </summary>
    public int TotalSpeakers { get; init; }
    
    /// <summary>
    /// 총 후원사 수 (중복 제거)
    /// </summary>
    public int TotalSponsors { get; init; }
    
    /// <summary>
    /// 총 컨퍼런스 개최 횟수
    /// </summary>
    public int TotalConferences { get; init; }
}
