using DotNetUniverse.Models.Collections;

namespace DotNetUniverse.Models;

/// <summary>
/// 행사 규모
/// </summary>
public enum EventScale
{
    /// <summary>
    /// 대규모 컨퍼런스 (연례 행사)
    /// </summary>
    Conference,

    /// <summary>
    /// 중규모 밋업/세미나
    /// </summary>
    Meetup,

    /// <summary>
    /// 소규모 워크샵/핸즈온랩
    /// </summary>
    Workshop,

    /// <summary>
    /// 온라인 웨비나
    /// </summary>
    Webinar
}

/// <summary>
/// 행사 정보
/// </summary>
public record EventInfo
{
    /// <summary>
    /// 행사 고유 슬러그 (URL 경로용, 예: "dotnet-universe-2024", "blazor-workshop-2024-03")
    /// </summary>
    public required string Slug { get; init; }

    /// <summary>
    /// 행사 연도
    /// </summary>
    public required int Year { get; init; }

    /// <summary>
    /// 행사 제목
    /// </summary>
    public required string Title { get; init; }

    /// <summary>
    /// 행사 규모
    /// </summary>
    public EventScale Scale { get; init; } = EventScale.Conference;

    /// <summary>
    /// 행사 테마
    /// </summary>
    public required string Theme { get; init; }

    /// <summary>
    /// 행사 날짜
    /// </summary>
    public required DateTime Date { get; init; }

    /// <summary>
    /// 행사 유형
    /// </summary>
    public required EventType Type { get; init; }

    /// <summary>
    /// 참가자 수
    /// </summary>
    public int? AttendeeCount { get; init; }

    /// <summary>
    /// 예정된 행사 여부
    /// </summary>
    public bool IsUpcoming { get; init; }

    /// <summary>
    /// 트레일러 URL
    /// </summary>
    public string? TrailerUrl { get; init; }

    /// <summary>
    /// 히어로 이미지 URL (행사 페이지 상단 배경 및 소셜 공유 이미지)
    /// </summary>
    public string? HeroImageUrl { get; init; }

    /// <summary>
    /// 소셜 공유용 설명 (Open Graph description)
    /// </summary>
    public string? Description { get; init; }

    /// <summary>
    /// 행사장 목록 (VenueCollection으로 관리)
    /// </summary>
    public VenueCollection Venues { get; init; } = [];

    /// <summary>
    /// 스폰서 목록 (SponsorCollection으로 관리)
    /// </summary>
    public SponsorCollection Sponsors { get; init; } = [];

    /// <summary>
    /// 공통 세션 목록 (체크인, 점심, 휴식 등 모든 트랙에 걸쳐 표시되는 세션)
    /// </summary>
    public SessionCollection SharedSessions { get; init; } = [];

    /// <summary>
    /// 트레일러가 있는지 여부
    /// </summary>
    public bool HasTrailer => !string.IsNullOrEmpty(TrailerUrl);

    /// <summary>
    /// 히어로 이미지가 있는지 여부
    /// </summary>
    public bool HasHeroImage => !string.IsNullOrEmpty(HeroImageUrl);

    /// <summary>
    /// 해석된 히어로 이미지 URL (기본값: /images/events/{Year}-hero.webp)
    /// </summary>
    public string ResolvedHeroImageUrl => HeroImageUrl ?? $"/images/events/{Year}-hero.webp";

    /// <summary>
    /// 소셜 공유용 이미지 URL (히어로 이미지 또는 기본 이미지)
    /// </summary>
    public string SocialImageUrl => HeroImageUrl ?? $"/images/events/{Year}-og.webp";

    /// <summary>
    /// 소셜 공유용 설명 (기본값: 테마)
    /// </summary>
    public string SocialDescription => Description ?? $"{Title} - {Theme}";

    /// <summary>
    /// 행사장 정보가 있는지 여부
    /// </summary>
    public bool HasVenues => Venues.Count > 0;

    /// <summary>
    /// 스폰서 정보가 있는지 여부
    /// </summary>
    public bool HasSponsors => Sponsors.Count > 0;

    /// <summary>
    /// 기본 행사장 (첫 번째 행사장)
    /// </summary>
    public VenueInfo? PrimaryVenue => Venues.Primary;

    /// <summary>
    /// ID로 행사장 찾기
    /// </summary>
    public VenueInfo? GetVenue(string id) => Venues.TryGet(id);

    /// <summary>
    /// ID로 트랙 찾기 (모든 장소에서)
    /// </summary>
    public Track? GetTrack(string id) => Venues.AllTracks.FirstOrDefault(t => t.Id == id);

    /// <summary>
    /// ID로 세션 찾기 (모든 장소, 모든 트랙에서)
    /// </summary>
    public Session? GetSession(string id) => AllSessions.FirstOrDefault(s => s.Id == id);

    /// <summary>
    /// ID로 발표자 찾기 (모든 세션에서)
    /// </summary>
    public Speaker? GetSpeaker(string id) => AllSpeakers.FirstOrDefault(s => s.Id == id);

    /// <summary>
    /// YouTube 영상인지 여부
    /// </summary>
    public bool IsYouTubeTrailer => HasTrailer && 
        (TrailerUrl!.Contains("youtube.com") || TrailerUrl.Contains("youtu.be"));

    /// <summary>
    /// YouTube 임베드 URL 추출
    /// </summary>
    public string? YouTubeEmbedUrl
    {
        get
        {
            if (!IsYouTubeTrailer) return null;
            
            // youtube.com/watch?v=VIDEO_ID 형식
            if (TrailerUrl!.Contains("watch?v="))
            {
                var videoId = TrailerUrl.Split("watch?v=")[1].Split('&')[0];
                return $"https://www.youtube.com/embed/{videoId}";
            }
            
            // youtu.be/VIDEO_ID 형식
            if (TrailerUrl.Contains("youtu.be/"))
            {
                var videoId = TrailerUrl.Split("youtu.be/")[1].Split('?')[0];
                return $"https://www.youtube.com/embed/{videoId}";
            }
            
            return null;
        }
    }

    /// <summary>
        /// 모든 트랙 목록 (모든 장소의 트랙 합계)
        /// </summary>
        public IEnumerable<Track> AllTracks => Venues.AllTracks;

        /// <summary>
        /// 모든 세션 목록 (공통 세션 + 모든 장소, 모든 트랙의 세션 합계)
        /// </summary>
        public IEnumerable<Session> AllSessions => SharedSessions.Concat(Venues.AllSessions);

        /// <summary>
        /// 트랙 세션만 (공통 세션 제외)
        /// </summary>
        public IEnumerable<Session> TrackSessions => Venues.AllSessions;

        /// <summary>
        /// 총 세션 수
        /// </summary>
        public int TotalSessionCount => Venues.TotalSessionCount;

        /// <summary>
        /// 총 트랙 수
        /// </summary>
        public int TotalTrackCount => Venues.TotalTrackCount;

        /// <summary>
        /// 모든 발표자 목록 (중복 제거)
        /// </summary>
        public IEnumerable<Speaker> AllSpeakers => Venues.AllSpeakers;

        /// <summary>
        /// 총 발표자 수 (중복 제거)
        /// </summary>
        public int TotalSpeakerCount => AllSpeakers.Count();
    }
