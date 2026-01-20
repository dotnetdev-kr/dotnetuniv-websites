using System.Collections.ObjectModel;

namespace DotNetUniverse.Models.Collections;

/// <summary>
/// Track 객체를 Id로 관리하는 KeyedCollection
/// </summary>
public class TrackCollection : KeyedCollection<string, Track>
{
    /// <summary>
    /// Track의 키(Id)를 반환합니다.
    /// </summary>
    protected override string GetKeyForItem(Track item) => item.Id;

    /// <summary>
    /// ID로 Track을 안전하게 조회합니다.
    /// </summary>
    public Track? TryGet(string id) => Contains(id) ? this[id] : null;

    /// <summary>
    /// 컬렉션 초기화를 위한 팩토리 메서드
    /// </summary>
    public static TrackCollection Create(params Track[] tracks)
    {
        var collection = new TrackCollection();
        foreach (var track in tracks)
        {
            collection.Add(track);
        }
        return collection;
    }

    /// <summary>
    /// IEnumerable에서 컬렉션 생성
    /// </summary>
    public static TrackCollection Create(IEnumerable<Track> tracks)
    {
        var collection = new TrackCollection();
        foreach (var track in tracks)
        {
            collection.Add(track);
        }
        return collection;
    }

    /// <summary>
    /// 모든 세션 목록
    /// </summary>
    public IEnumerable<Session> AllSessions => this.SelectMany(t => t.Sessions);

    /// <summary>
    /// 총 세션 수
    /// </summary>
    public int TotalSessionCount => this.Sum(t => t.SessionCount);

    /// <summary>
    /// 모든 발표자 목록 (중복 제거)
    /// </summary>
    public IEnumerable<Speaker> AllSpeakers => AllSessions.SelectMany(s => s.Speakers).DistinctBy(s => s.Id);
}
