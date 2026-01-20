namespace DotNetUniverse.Models;

/// <summary>
/// 시간표 행 (특정 시간의 모든 트랙 세션)
/// </summary>
public record ScheduleRow
{
    /// <summary>
    /// 행사 일차 (Day 1, Day 2 등)
    /// </summary>
    public int Day { get; init; } = 1;

    /// <summary>
    /// 이 행의 시간 슬롯
    /// </summary>
    public required TimeSlot TimeSlot { get; init; }

    /// <summary>
    /// 각 트랙별 셀 목록 (트랙 순서대로)
    /// </summary>
    public required ScheduleCell[] Cells { get; init; }

    /// <summary>
    /// 실제로 렌더링해야 할 셀 목록 (숨겨진 셀 제외)
    /// </summary>
    public IEnumerable<ScheduleCell> VisibleCells => Cells.Where(c => !c.IsHidden);

    /// <summary>
    /// 이 행이 공통 세션만 있는지 여부
    /// </summary>
    public bool IsSharedOnly => Cells.Length == 1 && Cells[0].IsFullWidth;
}
