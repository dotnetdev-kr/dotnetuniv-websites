using System.Collections.ObjectModel;

namespace DotNetUniverse.Models.Collections;

/// <summary>
/// VenueInfo 객체를 Id로 관리하는 KeyedCollection
/// </summary>
public class VenueCollection : KeyedCollection<string, VenueInfo>
{
    /// <summary>
    /// VenueInfo의 키(Id)를 반환합니다.
    /// </summary>
    protected override string GetKeyForItem(VenueInfo item) => item.Id;

    /// <summary>
    /// ID로 VenueInfo를 안전하게 조회합니다.
    /// </summary>
    public VenueInfo? TryGet(string id) => Contains(id) ? this[id] : null;

    /// <summary>
    /// 컬렉션 초기화를 위한 팩토리 메서드
    /// </summary>
    public static VenueCollection Create(params VenueInfo[] venues)
    {
        var collection = new VenueCollection();
        foreach (var venue in venues)
        {
            collection.Add(venue);
        }
        return collection;
    }

    /// <summary>
    /// IEnumerable에서 컬렉션 생성
    /// </summary>
    public static VenueCollection Create(IEnumerable<VenueInfo> venues)
    {
        var collection = new VenueCollection();
        foreach (var venue in venues)
        {
            collection.Add(venue);
        }
        return collection;
    }

    /// <summary>
    /// 기본 장소 (첫 번째 장소)
    /// </summary>
    public VenueInfo? Primary => Count > 0 ? this[0] : null;

    /// <summary>
    /// 모든 트랙 목록
    /// </summary>
    public IEnumerable<Track> AllTracks => this.SelectMany(v => v.Tracks);

    /// <summary>
    /// 모든 세션 목록
    /// </summary>
    public IEnumerable<Session> AllSessions => AllTracks.SelectMany(t => t.Sessions);

    /// <summary>
    /// 총 트랙 수
    /// </summary>
    public int TotalTrackCount => this.Sum(v => v.TrackCount);

    /// <summary>
    /// 총 세션 수
    /// </summary>
    public int TotalSessionCount => this.Sum(v => v.TotalSessionCount);

    /// <summary>
    /// 모든 발표자 목록 (중복 제거)
    /// </summary>
    public IEnumerable<Speaker> AllSpeakers => AllSessions.SelectMany(s => s.Speakers).DistinctBy(s => s.Id);
}
