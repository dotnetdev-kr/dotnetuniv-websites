using System.Collections.ObjectModel;

namespace DotNetUniverse.Models.Collections;

/// <summary>
/// Speaker 객체를 Id로 관리하는 KeyedCollection
/// </summary>
public class SpeakerCollection : KeyedCollection<string, Speaker>
{
    /// <summary>
    /// Speaker의 키(Id)를 반환합니다.
    /// </summary>
    protected override string GetKeyForItem(Speaker item) => item.Id;

    /// <summary>
    /// ID로 Speaker를 안전하게 조회합니다.
    /// </summary>
    public Speaker? TryGet(string id) => Contains(id) ? this[id] : null;

    /// <summary>
    /// 여러 ID로 Speaker 배열을 조회합니다.
    /// </summary>
    public Speaker[] GetMany(params string[] ids) => ids.Select(id => this[id]).ToArray();

    /// <summary>
    /// 컬렉션 초기화를 위한 팩토리 메서드
    /// </summary>
    public static SpeakerCollection Create(params Speaker[] speakers)
    {
        var collection = new SpeakerCollection();
        foreach (var speaker in speakers)
        {
            collection.Add(speaker);
        }
        return collection;
    }

    /// <summary>
    /// IEnumerable에서 컬렉션 생성
    /// </summary>
    public static SpeakerCollection Create(IEnumerable<Speaker> speakers)
    {
        var collection = new SpeakerCollection();
        foreach (var speaker in speakers)
        {
            collection.Add(speaker);
        }
        return collection;
    }
}
