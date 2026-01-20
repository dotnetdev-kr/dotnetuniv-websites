namespace DotNetUniverse.Models;

/// <summary>
/// 스폰서 정보
/// </summary>
public record Sponsor
{
    /// <summary>
    /// 스폰서 고유 ID
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// 스폰서 이름
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// 스폰서 등급
    /// </summary>
    public required SponsorTier Tier { get; init; }

    /// <summary>
    /// 로고 이미지 URL
    /// </summary>
    public string? LogoUrl { get; init; }

    /// <summary>
    /// 웹사이트 URL
    /// </summary>
    public string? WebsiteUrl { get; init; }

    /// <summary>
    /// 스폰서 설명
    /// </summary>
    public string? Description { get; init; }

    /// <summary>
    /// ID 기반 로고 이미지 경로 (LogoUrl이 없을 경우 사용)
    /// </summary>
    public string LogoImagePath => $"/images/sponsors/{Id}.webp";

    /// <summary>
    /// 실제 사용할 로고 이미지 URL (명시적 LogoUrl 우선, 없으면 ID 기반 경로)
    /// </summary>
    public string ResolvedLogoUrl => !string.IsNullOrEmpty(LogoUrl) ? LogoUrl : LogoImagePath;

    /// <summary>
    /// 로고가 있는지 여부 (항상 true - ID 기반 fallback 있음)
    /// </summary>
    public bool HasLogo => true;
}
