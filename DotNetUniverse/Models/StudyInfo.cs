namespace DotNetUniverse.Models;

/// <summary>
/// 스터디/시청 모임 정보
/// </summary>
public record StudyInfo
{
    /// <summary>
    /// 스터디 고유 슬러그 (URL 경로용)
    /// </summary>
    public required string Slug { get; init; }

    /// <summary>
    /// 스터디 연도
    /// </summary>
    public required int Year { get; init; }

    /// <summary>
    /// 스터디 제목
    /// </summary>
    public required string Title { get; init; }

    /// <summary>
    /// 스터디 소개
    /// </summary>
    public required string Description { get; init; }

    /// <summary>
    /// 스터디 날짜
    /// </summary>
    public required DateTime Date { get; init; }

    /// <summary>
    /// 스터디 종료 시간
    /// </summary>
    public DateTime? EndTime { get; init; }

    /// <summary>
    /// 스터디 형태 (온라인/오프라인)
    /// </summary>
    public required string Format { get; init; }

    /// <summary>
    /// 스터디 플랫폼 (Google Meet, Zoom 등)
    /// </summary>
    public string? Platform { get; init; }

    /// <summary>
    /// 진행자
    /// </summary>
    public required string Organizer { get; init; }

    /// <summary>
    /// 진행자 직함
    /// </summary>
    public string? OrganizerTitle { get; init; }

    /// <summary>
    /// 스터디 진행 상태
    /// </summary>
    public EventStatus Status { get; init; } = EventStatus.Completed;

    /// <summary>
    /// 참가 비용 (무료인 경우 null 또는 0)
    /// </summary>
    public decimal? Fee { get; init; }

    /// <summary>
    /// 참가 신청 URL
    /// </summary>
    public string? RegistrationUrl { get; init; }

    /// <summary>
    /// 문의 이메일
    /// </summary>
    public string? ContactEmail { get; init; }

    /// <summary>
    /// 시청 영상 목록
    /// </summary>
    public List<WatchVideo> Videos { get; init; } = [];

    /// <summary>
    /// 세션/발표 목록
    /// </summary>
    public List<StudySession> Sessions { get; init; } = [];

    /// <summary>
    /// 사전 준비 사항
    /// </summary>
    public List<string> Prerequisites { get; init; } = [];

    /// <summary>
    /// 대상 참가자
    /// </summary>
    public List<string> TargetAudience { get; init; } = [];

    /// <summary>
    /// 예정된 스터디 여부 (Date가 미래인 경우 자동 계산)
    /// </summary>
    public bool IsUpcoming => Date > DateTime.Now;

    /// <summary>
    /// 무료 스터디 여부
    /// </summary>
    public bool IsFree => Fee is null or 0;

    /// <summary>
    /// 참가 등록 가능 여부
    /// </summary>
    public bool IsRegistrationOpen => !string.IsNullOrEmpty(RegistrationUrl) && Status == EventStatus.Registration;
}

/// <summary>
/// 시청 영상 정보
/// </summary>
public record WatchVideo
{
    /// <summary>
    /// 영상 제목
    /// </summary>
    public required string Title { get; init; }

    /// <summary>
    /// 영상 URL
    /// </summary>
    public required string Url { get; init; }

    /// <summary>
    /// 영상 순서
    /// </summary>
    public int Order { get; init; }
}

/// <summary>
/// 스터디 세션/발표 정보
/// </summary>
public record StudySession
{
    /// <summary>
    /// 세션 제목
    /// </summary>
    public required string Title { get; init; }

    /// <summary>
    /// 세션 시작 시간
    /// </summary>
    public DateTime? StartTime { get; init; }

    /// <summary>
    /// 세션 종료 시간
    /// </summary>
    public DateTime? EndTime { get; init; }

    /// <summary>
    /// 발표자 (없으면 진행자가 발표)
    /// </summary>
    public string? Speaker { get; init; }

    /// <summary>
    /// 세션 순서
    /// </summary>
    public int Order { get; init; }
}
