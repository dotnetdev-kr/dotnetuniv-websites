namespace DotNetUniverse.Models;

/// <summary>
/// 시간표 항목 (데이터 입력용)
/// 행/열 기반으로 세션을 배치할 때 사용
/// </summary>
public record ScheduleEntry
{
    /// <summary>
    /// 세션 정보
    /// </summary>
    public required Session Session { get; init; }

    /// <summary>
    /// 배치할 트랙 인덱스 (0부터 시작, null이면 공통 세션)
    /// </summary>
    public int? TrackIndex { get; init; }

    /// <summary>
    /// 가로 span (트랙 수) - 공통 세션에서 몇 개 트랙에 걸칠지
    /// 예: 트랙이 3개이고 ColSpan이 2이면 첫 2개 트랙에만 걸침
    /// null이면 모든 트랙에 걸침
    /// </summary>
    public int? ColSpan { get; init; }

    /// <summary>
    /// 세로 span (시간 슬롯 수) - 여러 슬롯에 걸치는 세션
    /// </summary>
    public int RowSpan { get; init; } = 1;

    /// <summary>
    /// 공통 세션 여부 (TrackIndex가 null이면 공통 세션)
    /// </summary>
    public bool IsShared => TrackIndex is null;
}
