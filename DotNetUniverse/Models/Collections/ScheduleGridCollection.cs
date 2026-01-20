using System.Collections.ObjectModel;

namespace DotNetUniverse.Models.Collections;

/// <summary>
/// ScheduleGrid 객체를 Day로 관리하는 KeyedCollection
/// </summary>
public class ScheduleGridCollection : KeyedCollection<int, ScheduleGrid>
{
    /// <summary>
    /// ScheduleGrid의 키(Day)를 반환합니다.
    /// </summary>
    protected override int GetKeyForItem(ScheduleGrid item) => item.Day;

    /// <summary>
    /// Day로 ScheduleGrid를 안전하게 조회합니다.
    /// </summary>
    public ScheduleGrid? TryGet(int day) => Contains(day) ? this[day] : null;

    /// <summary>
    /// 컬렉션 초기화를 위한 팩토리 메서드
    /// </summary>
    public static ScheduleGridCollection Create(params ScheduleGrid[] grids)
    {
        var collection = new ScheduleGridCollection();
        foreach (var grid in grids)
        {
            collection.Add(grid);
        }
        return collection;
    }

    /// <summary>
    /// 모든 세션 (중복 제거)
    /// </summary>
    public IEnumerable<Session> AllSessions =>
        this.SelectMany(g => g.AllSessions).DistinctBy(s => s.Id);

    /// <summary>
    /// 총 세션 수
    /// </summary>
    public int TotalSessionCount => AllSessions.Count();
}
