using System.Collections.ObjectModel;

namespace DotNetUniverse.Models.Collections;

/// <summary>
/// Session 객체를 Id로 관리하는 KeyedCollection
/// </summary>
public class SessionCollection : KeyedCollection<string, Session>
{
    /// <summary>
    /// Session의 키(Id)를 반환합니다.
    /// </summary>
    protected override string GetKeyForItem(Session item) => item.Id;

    /// <summary>
    /// ID로 Session을 안전하게 조회합니다.
    /// </summary>
    public Session? TryGet(string id) => Contains(id) ? this[id] : null;

    /// <summary>
    /// 컬렉션 초기화를 위한 팩토리 메서드
    /// </summary>
    public static SessionCollection Create(params Session[] sessions)
    {
        var collection = new SessionCollection();
        foreach (var session in sessions)
        {
            collection.Add(session);
        }
        return collection;
    }

    /// <summary>
    /// IEnumerable에서 컬렉션 생성
    /// </summary>
    public static SessionCollection Create(IEnumerable<Session> sessions)
    {
        var collection = new SessionCollection();
        foreach (var session in sessions)
        {
            collection.Add(session);
        }
        return collection;
    }

    /// <summary>
    /// 특정 발표자의 세션 목록 조회
    /// </summary>
    public IEnumerable<Session> GetBySpeaker(string speakerId) =>
        this.Where(s => s.Speakers.Any(sp => sp.Id == speakerId));

    /// <summary>
    /// 특정 형식의 세션 목록 조회
    /// </summary>
    public IEnumerable<Session> GetByFormat(SessionFormat format) =>
        this.Where(s => s.Format == format);

    /// <summary>
    /// 모든 발표자 목록 (중복 제거)
    /// </summary>
    public IEnumerable<Speaker> AllSpeakers =>
        this.SelectMany(s => s.Speakers).DistinctBy(s => s.Id);
}
