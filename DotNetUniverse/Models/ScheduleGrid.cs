namespace DotNetUniverse.Models;

/// <summary>
/// 행/열 기반 시간표 그리드
/// </summary>
public record ScheduleGrid
{
    /// <summary>
    /// 행사 일자 (Day 1, Day 2 등)
    /// </summary>
    public int Day { get; init; } = 1;

    /// <summary>
    /// 열 목록 (트랙 헤더)
    /// </summary>
    public required ScheduleColumn[] Columns { get; init; }

    /// <summary>
    /// 행 목록 (시간별 세션)
    /// </summary>
    public required ScheduleRow[] Rows { get; init; }

    /// <summary>
    /// 트랙 수
    /// </summary>
    public int TrackCount => Columns.Length;

    /// <summary>
    /// 시간 슬롯 수
    /// </summary>
    public int SlotCount => Rows.Length;

    /// <summary>
    /// 모든 세션 (중복 제거)
    /// </summary>
    public IEnumerable<Session> AllSessions =>
        Rows.SelectMany(r => r.Cells)
            .Where(c => c.HasSession)
            .Select(c => c.Session!)
            .DistinctBy(s => s.Id);

    /// <summary>
    /// 세션 ID로 스케줄 정보 조회
    /// </summary>
    public SessionSchedule? GetScheduleFor(string sessionId)
    {
        foreach (var row in Rows)
        {
            foreach (var cell in row.Cells)
            {
                if (cell.HasSession && cell.Session!.Id == sessionId)
                {
                    return new SessionSchedule
                    {
                        Day = Day,
                        StartTime = row.TimeSlot.StartTime,
                        EndTime = row.TimeSlot.EndTime
                    };
                }
            }
        }
        return null;
    }

    /// <summary>
    /// 세션 ID로 시간 슬롯 조회
    /// </summary>
    public TimeSlot? GetTimeSlotFor(string sessionId)
    {
        foreach (var row in Rows)
        {
            foreach (var cell in row.Cells)
            {
                if (cell.HasSession && cell.Session!.Id == sessionId)
                {
                    return row.TimeSlot;
                }
            }
        }
        return null;
    }

    /// <summary>
    /// 세션 ID로 트랙 인덱스 조회 (-1이면 찾지 못함)
    /// </summary>
    public int GetTrackIndexFor(string sessionId)
    {
        foreach (var row in Rows)
        {
            for (int i = 0; i < row.Cells.Length; i++)
            {
                var cell = row.Cells[i];
                if (cell.HasSession && cell.Session!.Id == sessionId)
                {
                    return i;
                }
            }
        }
        return -1;
    }
}
