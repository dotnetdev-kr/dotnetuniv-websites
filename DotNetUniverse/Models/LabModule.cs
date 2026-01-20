namespace DotNetUniverse.Models;

/// <summary>
/// 핸즈온랩 모듈 정보
/// </summary>
public record LabModule
{
    /// <summary>
    /// 모듈 제목
    /// </summary>
    public required string Title { get; init; }

    /// <summary>
    /// 모듈 URL
    /// </summary>
    public required string Url { get; init; }

    /// <summary>
    /// 모듈 설명
    /// </summary>
    public string? Description { get; init; }
}
