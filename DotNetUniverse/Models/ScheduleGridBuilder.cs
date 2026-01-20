namespace DotNetUniverse.Models;

/// <summary>
/// 시간표 데이터를 쉽게 구성하기 위한 빌더
/// 행(시간)/열(트랙) 기반으로 세션을 배치
/// </summary>
public class ScheduleGridBuilder
{
    private readonly List<ScheduleColumn> _columns = [];
    private readonly List<(int Day, TimeSlot Slot, List<ScheduleEntry> Entries)> _rows = [];
    private int _day = 1;

    /// <summary>
    /// 행사 일자 설정 (Day 1, Day 2 등)
    /// </summary>
    public ScheduleGridBuilder ForDay(int day)
    {
        _day = day;
        return this;
    }

    /// <summary>
    /// 트랙(열) 추가
    /// </summary>
    public ScheduleGridBuilder AddTrack(string id, string name, string? description = null, string? color = null)
    {
        _columns.Add(new ScheduleColumn
        {
            Id = id,
            Name = name,
            Description = description,
            Color = color
        });
        return this;
    }

    /// <summary>
    /// Track 객체에서 트랙(열) 추가
    /// </summary>
    public ScheduleGridBuilder AddTrack(Track track)
    {
        _columns.Add(ScheduleColumn.FromTrack(track));
        return this;
    }

    /// <summary>
    /// 여러 트랙(열) 한번에 추가
    /// </summary>
    public ScheduleGridBuilder AddTracks(params Track[] tracks)
    {
        foreach (var track in tracks)
        {
            AddTrack(track);
        }
        return this;
    }

    /// <summary>
    /// 시간 슬롯(행) 추가
    /// </summary>
    public ScheduleGridBuilder AddTimeSlot(TimeOnly startTime, TimeOnly endTime, Action<TimeSlotBuilder> configure)
    {
        var slot = new TimeSlot { StartTime = startTime, EndTime = endTime };
        var builder = new TimeSlotBuilder(_columns.Count);
        configure(builder);
        _rows.Add((_day, slot, builder.Entries));
        return this;
    }

    /// <summary>
    /// 시간 슬롯(행) 추가 (분 단위로 duration 지정)
    /// </summary>
    public ScheduleGridBuilder AddTimeSlot(TimeOnly startTime, int durationMinutes, Action<TimeSlotBuilder> configure)
    {
        return AddTimeSlot(startTime, startTime.AddMinutes(durationMinutes), configure);
    }

    /// <summary>
    /// ScheduleGrid 생성
    /// </summary>
    public ScheduleGrid Build()
    {
        var columns = _columns.ToArray();
        var trackCount = columns.Length;
        
        // 각 행을 ScheduleRow로 변환
        var rows = new List<ScheduleRow>();
        
        // 이전 행에서 rowspan으로 인해 현재 행에 영향을 주는 셀 추적
        // [trackIndex] = 남은 rowspan 수
        var rowSpanTracker = new int[trackCount];

        foreach (var (day, slot, entries) in _rows)
        {
            var cells = new ScheduleCell[trackCount];
            
            // 먼저 rowspan이 진행 중인 셀 처리
            for (int i = 0; i < trackCount; i++)
            {
                if (rowSpanTracker[i] > 0)
                {
                    cells[i] = ScheduleCell.Hidden;
                    rowSpanTracker[i]--;
                }
            }

            // 현재 행의 엔트리 처리
            foreach (var entry in entries)
            {
                if (entry.IsShared)
                {
                    // 공통 세션: ColSpan 만큼 트랙에 걸침
                    var colSpan = entry.ColSpan ?? trackCount;
                    var startTrack = 0; // 공통 세션은 항상 첫 트랙부터 시작
                    
                    cells[startTrack] = new ScheduleCell
                    {
                        Session = entry.Session,
                        ColSpan = colSpan,
                        RowSpan = entry.RowSpan
                    };

                    // colspan에 의해 숨겨지는 셀 처리
                    for (int i = startTrack + 1; i < startTrack + colSpan && i < trackCount; i++)
                    {
                        cells[i] = ScheduleCell.Hidden;
                    }

                    // rowspan 추적
                    if (entry.RowSpan > 1)
                    {
                        for (int i = startTrack; i < startTrack + colSpan && i < trackCount; i++)
                        {
                            rowSpanTracker[i] = entry.RowSpan - 1;
                        }
                    }
                }
                else
                {
                    // 트랙별 세션
                    var trackIndex = entry.TrackIndex!.Value;
                    if (trackIndex < trackCount)
                    {
                        var colSpan = entry.ColSpan ?? 1;
                        
                        cells[trackIndex] = new ScheduleCell
                        {
                            Session = entry.Session,
                            ColSpan = colSpan,
                            RowSpan = entry.RowSpan
                        };

                        // colspan에 의해 숨겨지는 셀 처리
                        for (int i = trackIndex + 1; i < trackIndex + colSpan && i < trackCount; i++)
                        {
                            cells[i] = ScheduleCell.Hidden;
                        }

                        // rowspan 추적
                        if (entry.RowSpan > 1)
                        {
                            for (int i = trackIndex; i < trackIndex + colSpan && i < trackCount; i++)
                            {
                                rowSpanTracker[i] = entry.RowSpan - 1;
                            }
                        }
                    }
                }
            }

            // 비어있는 셀은 Empty로 채움
            for (int i = 0; i < trackCount; i++)
            {
                cells[i] ??= ScheduleCell.Empty;
            }

            rows.Add(new ScheduleRow
            {
                Day = day,
                TimeSlot = slot,
                Cells = cells
            });
        }

        return new ScheduleGrid
        {
            Day = _day,
            Columns = columns,
            Rows = rows.ToArray()
        };
    }
}

/// <summary>
/// 시간 슬롯 내 세션 배치를 위한 빌더
/// </summary>
public class TimeSlotBuilder
{
    private readonly int _trackCount;
    internal List<ScheduleEntry> Entries { get; } = [];

    internal TimeSlotBuilder(int trackCount)
    {
        _trackCount = trackCount;
    }

    /// <summary>
    /// 특정 트랙에 세션 배치
    /// </summary>
    /// <param name="trackIndex">트랙 인덱스 (0부터 시작)</param>
    /// <param name="session">배치할 세션</param>
    /// <param name="colSpan">가로 span (기본값 1)</param>
    /// <param name="rowSpan">세로 span (기본값 1)</param>
    public TimeSlotBuilder At(int trackIndex, Session session, int colSpan = 1, int rowSpan = 1)
    {
        Entries.Add(new ScheduleEntry
        {
            Session = session,
            TrackIndex = trackIndex,
            ColSpan = colSpan,
            RowSpan = rowSpan
        });
        return this;
    }

    /// <summary>
    /// 공통 세션 배치 (여러 트랙에 걸침)
    /// </summary>
    /// <param name="session">배치할 세션</param>
    /// <param name="colSpan">가로 span (null이면 모든 트랙)</param>
    /// <param name="rowSpan">세로 span (기본값 1)</param>
    public TimeSlotBuilder Shared(Session session, int? colSpan = null, int rowSpan = 1)
    {
        Entries.Add(new ScheduleEntry
        {
            Session = session,
            TrackIndex = null,
            ColSpan = colSpan,
            RowSpan = rowSpan
        });
        return this;
    }

    /// <summary>
    /// 모든 트랙에 걸치는 공통 세션 배치
    /// </summary>
    public TimeSlotBuilder FullWidth(Session session, int rowSpan = 1)
    {
        return Shared(session, null, rowSpan);
    }
}
