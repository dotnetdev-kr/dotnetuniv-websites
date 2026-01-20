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
                        Day = row.Day,
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

    /// <summary>
    /// 세션 ID로 해당 세션의 Day 조회 (0이면 찾지 못함)
    /// </summary>
    public int GetDayFor(string sessionId)
    {
        foreach (var row in Rows)
        {
            foreach (var cell in row.Cells)
            {
                if (cell.HasSession && cell.Session!.Id == sessionId)
                {
                    return row.Day;
                }
            }
        }
        return 0;
    }

    /// <summary>
    /// 세션을 Day별로 그룹화하여 반환
    /// </summary>
    public IEnumerable<IGrouping<int, Session>> SessionsByDay =>
        Rows.SelectMany(r => r.Cells
                .Where(c => c.HasSession)
                .Select(c => new { Day = r.Day, Session = c.Session! }))
            .DistinctBy(x => x.Session.Id)
            .GroupBy(x => x.Day, x => x.Session)
            .OrderBy(g => g.Key);

    /// <summary>
    /// 발표 세션만 Day별로 그룹화하여 반환 (휴식, 점심 등 운영 세션 제외)
    /// </summary>
    public IEnumerable<IGrouping<int, Session>> PresentationSessionsByDay =>
        Rows.SelectMany(r => r.Cells
                .Where(c => c.HasSession && c.Session!.IsPresentationSession)
                .Select(c => new { Day = r.Day, Session = c.Session! }))
            .DistinctBy(x => x.Session.Id)
            .GroupBy(x => x.Day, x => x.Session)
            .OrderBy(g => g.Key);

    /// <summary>
    /// 총 일차 수
    /// </summary>
    public int TotalDays => Rows.Select(r => r.Day).Distinct().Count();

    /// <summary>
    /// 다중 일차 행사인지 여부
    /// </summary>
    public bool IsMultiDay => TotalDays > 1;
}
