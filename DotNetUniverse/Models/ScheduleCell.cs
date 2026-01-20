namespace DotNetUniverse.Models;

/// <summary>
/// 시간표 셀 (특정 시간/트랙의 세션 정보)
/// </summary>
public record ScheduleCell
{
    /// <summary>
    /// 이 셀에 배치된 세션 (없으면 null)
    /// </summary>
    public Session? Session { get; init; }

    /// <summary>
    /// 가로 span (트랙 수) - 1이면 단일 트랙, 2 이상이면 여러 트랙에 걸침
    /// </summary>
    public int ColSpan { get; init; } = 1;

    /// <summary>
    /// 세로 span (시간 슬롯 수) - 1이면 단일 슬롯, 2 이상이면 여러 슬롯에 걸침
    /// </summary>
    public int RowSpan { get; init; } = 1;

    /// <summary>
    /// 이 셀이 다른 셀에 의해 span되어 숨겨져야 하는지 여부
    /// </summary>
    public bool IsHidden { get; init; } = false;

    /// <summary>
    /// 이 셀이 모든 트랙에 걸쳐 표시되는 공통 세션인지 여부
    /// </summary>
    public bool IsFullWidth => ColSpan > 1;

    /// <summary>
    /// 세션이 있는지 여부
    /// </summary>
    public bool HasSession => Session is not null;

    /// <summary>
    /// 빈 셀 생성
    /// </summary>
    public static ScheduleCell Empty => new();

    /// <summary>
    /// 숨겨진 셀 생성 (다른 셀에 의해 span됨)
    /// </summary>
    public static ScheduleCell Hidden => new() { IsHidden = true };
}
