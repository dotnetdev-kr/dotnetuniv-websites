namespace DotNetUniverse.Models;

/// <summary>
/// 시간표 열 정보 (트랙 헤더)
/// </summary>
public record ScheduleColumn
{
    /// <summary>
    /// 트랙 ID
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// 트랙 이름
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// 트랙 설명
    /// </summary>
    public string? Description { get; init; }

    /// <summary>
    /// 트랙 색상
    /// </summary>
    public string? Color { get; init; }

    /// <summary>
    /// Track에서 ScheduleColumn 생성
    /// </summary>
    public static ScheduleColumn FromTrack(Track track) => new()
    {
        Id = track.Id,
        Name = track.Name,
        Description = track.Description,
        Color = track.Color
    };
}
