using DotNetUniverse.Models;
using DotNetUniverse.Models.Collections;

namespace DotNetUniverse.Services.YearData;

/// <summary>
/// 행사 데이터를 정의하는 인터페이스
/// </summary>
public interface IEventData
{
    /// <summary>
    /// 행사 고유 URL 경로 (예: "2019", "live/2503", "events/dotnet-conf-2024")
    /// 선행 슬래시(/) 없이 지정하며, 이 경로가 그대로 URL이 됩니다.
    /// </summary>
    string Slug { get; }

    /// <summary>
    /// 행사 URL (선행 슬래시 포함, 예: "/2019", "/live/2503")
    /// </summary>
    string Url => $"/{Slug}";

    /// <summary>
    /// 행사 연도 (주 연도, 정렬/그룹화용)
    /// </summary>
    int Year { get; }

    /// <summary>
    /// 행사 정보
    /// </summary>
    EventInfo Event { get; }

    /// <summary>
    /// 연사 목록
    /// </summary>
    SpeakerCollection Speakers { get; }

    /// <summary>
    /// 행사별 고유 스토리/역사 콘텐츠 (있는 경우)
    /// </summary>
    EventStory? Story => null;

    /// <summary>
    /// 행사별 테마 컬러 (CSS 색상)
    /// </summary>
    string ThemeColor => "#6f42c1";

    /// <summary>
    /// 행사별 테마 컬러 클래스 (Bootstrap)
    /// </summary>
    string ThemeColorClass => "purple";

    /// <summary>
    /// 시간표 그리드 (행/열 기반 시간표)
    /// 기본값은 null이며, 각 연도별로 구현 가능
    /// </summary>
    ScheduleGrid? Schedule => null;

    /// <summary>
    /// 세션 ID로 스케줄 정보 조회
    /// Schedule 속성이 설정된 경우 ScheduleGrid에서 조회
    /// </summary>
    SessionSchedule? GetScheduleFor(string sessionId) => Schedule?.GetScheduleFor(sessionId);

    /// <summary>
    /// 세션 ID로 시간 슬롯 조회
    /// </summary>
    TimeSlot? GetTimeSlotFor(string sessionId) => Schedule?.GetTimeSlotFor(sessionId);
}

/// <summary>
/// 행사별 스토리/역사 콘텐츠
/// </summary>
public record EventStory
{
    /// <summary>
    /// 스토리 섹션 제목
    /// </summary>
    public required string Title { get; init; }

    /// <summary>
    /// 스토리 섹션 부제목
    /// </summary>
    public required string Subtitle { get; init; }

    /// <summary>
    /// 스토리 본문 (HTML 지원)
    /// </summary>
    public required string[] Paragraphs { get; init; }

    /// <summary>
    /// 당시 주요 주제 목록 (있는 경우)
    /// </summary>
    public EventHighlight[]? Highlights { get; init; }
}

/// <summary>
/// 행사별 주요 주제/하이라이트
/// </summary>
public record EventHighlight
{
    /// <summary>
    /// 아이콘 클래스 (Bootstrap Icons)
    /// </summary>
    public required string Icon { get; init; }

    /// <summary>
    /// 제목
    /// </summary>
    public required string Title { get; init; }

    /// <summary>
    /// 설명
    /// </summary>
    public required string Description { get; init; }
}
