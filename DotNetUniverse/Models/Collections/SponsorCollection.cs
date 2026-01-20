using System.Collections.ObjectModel;

namespace DotNetUniverse.Models.Collections;

/// <summary>
/// Sponsor 객체를 Id로 관리하는 KeyedCollection
/// </summary>
public class SponsorCollection : KeyedCollection<string, Sponsor>
{
    /// <summary>
    /// Sponsor의 키(Id)를 반환합니다.
    /// </summary>
    protected override string GetKeyForItem(Sponsor item) => item.Id;

    /// <summary>
    /// ID로 Sponsor를 안전하게 조회합니다.
    /// </summary>
    public Sponsor? TryGet(string id) => Contains(id) ? this[id] : null;

    /// <summary>
    /// 컬렉션 초기화를 위한 팩토리 메서드
    /// </summary>
    public static SponsorCollection Create(params Sponsor[] sponsors)
    {
        var collection = new SponsorCollection();
        foreach (var sponsor in sponsors)
        {
            collection.Add(sponsor);
        }
        return collection;
    }

    /// <summary>
    /// IEnumerable에서 컬렉션 생성
    /// </summary>
    public static SponsorCollection Create(IEnumerable<Sponsor> sponsors)
    {
        var collection = new SponsorCollection();
        foreach (var sponsor in sponsors)
        {
            collection.Add(sponsor);
        }
        return collection;
    }

    /// <summary>
    /// 특정 등급의 스폰서 목록 조회
    /// </summary>
    public IEnumerable<Sponsor> GetByTier(SponsorTier tier) => this.Where(s => s.Tier == tier);

    /// <summary>
    /// 등급별 스폰서 그룹
    /// </summary>
    public IEnumerable<IGrouping<SponsorTier, Sponsor>> ByTier => this.GroupBy(s => s.Tier).OrderBy(g => g.Key);
}
