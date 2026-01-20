namespace DotNetUniverse.Models;

/// <summary>
/// 연사 정보
/// </summary>
public record Speaker
{
    /// <summary>
    /// 연사 고유 ID
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// 연사 이름
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// 연사 직함
    /// </summary>
    public string Title { get; init; } = "";

    /// <summary>
    /// 연사 소속 회사
    /// </summary>
    public string Company { get; init; } = "";

    /// <summary>
    /// 연사 소개
    /// </summary>
    public string? Bio { get; init; }

    /// <summary>
    /// 프로필 이미지 URL
    /// </summary>
    public string? ImageUrl { get; init; }

    /// <summary>
    /// GitHub 프로필 URL
    /// </summary>
    public string? GitHubUrl { get; init; }

    /// <summary>
    /// Twitter 프로필 URL
    /// </summary>
    public string? TwitterUrl { get; init; }

    /// <summary>
    /// LinkedIn 프로필 URL
    /// </summary>
    public string? LinkedInUrl { get; init; }

    /// <summary>
    /// 개인 웹사이트 URL
    /// </summary>
    public string? WebsiteUrl { get; init; }

    /// <summary>
    /// 모달 ID (HTML용)
    /// </summary>
    public string ModalId => $"speaker-modal-{Id}";

    /// <summary>
    /// 앵커 해시 (URL용)
    /// </summary>
    public string AnchorHash => $"#speaker-{Id}";

    /// <summary>
    /// 소셜 링크가 있는지 여부
    /// </summary>
    public bool HasSocialLinks => !string.IsNullOrEmpty(GitHubUrl) 
        || !string.IsNullOrEmpty(TwitterUrl) 
        || !string.IsNullOrEmpty(LinkedInUrl) 
        || !string.IsNullOrEmpty(WebsiteUrl);

    /// <summary>
    /// ID 기반 프로필 이미지 경로 (ImageUrl이 없을 경우 사용)
    /// </summary>
    public string ProfileImagePath => $"/images/speakers/{Id}.webp";

    /// <summary>
    /// 실제 사용할 프로필 이미지 URL (명시적 ImageUrl 우선, 없으면 ID 기반 경로)
    /// </summary>
    public string? ResolvedImageUrl => !string.IsNullOrEmpty(ImageUrl) ? ImageUrl : ProfileImagePath;
}
