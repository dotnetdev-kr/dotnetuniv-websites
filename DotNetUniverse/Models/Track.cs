using DotNetUniverse.Models.Collections;

namespace DotNetUniverse.Models;

/// <summary>
/// 트랙 정보 (대관 장소 내 트랙)
/// </summary>
public record Track
{
    /// <summary>
    /// 트랙 고유 ID
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// 트랙 이름 (예: "Room A", "Track 1", "메인 홀")
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// 트랙 설명
    /// </summary>
    public string? Description { get; init; }

    /// <summary>
    /// 트랙 색상 (UI 표시용)
    /// </summary>
    public string? Color { get; init; }

    /// <summary>
    /// 트랙에 배정된 세션 목록 (SessionCollection으로 관리)
    /// </summary>
    public SessionCollection Sessions { get; init; } = [];

    /// <summary>
    /// 세션이 있는지 여부
    /// </summary>
    public bool HasSessions => Sessions.Count > 0;

    /// <summary>
    /// 세션 수
    /// </summary>
    public int SessionCount => Sessions.Count;

    /// <summary>
    /// ID로 세션 조회
    /// </summary>
    public Session? GetSession(string id) => Sessions.TryGet(id);

    /// <summary>
    /// 모든 발표자 목록 (중복 제거)
    /// </summary>
    public IEnumerable<Speaker> AllSpeakers => Sessions.AllSpeakers;
}
