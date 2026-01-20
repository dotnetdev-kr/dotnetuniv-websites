namespace DotNetUniverse.Services;

using DotNetUniverse.Models;

/// <summary>
/// 세션 형식 및 토픽 표시 정보를 제공하는 서비스
/// </summary>
public class SessionDisplayService
{
    /// <summary>
    /// 세션 형식의 표시 정보 (텍스트, 색상)
    /// </summary>
    public record FormatDisplayInfo(string DisplayName, string BadgeColor, string IconClass);

    /// <summary>
    /// 세션 토픽의 표시 정보 (텍스트, 색상, 아이콘)
    /// </summary>
    public record TopicDisplayInfo(string DisplayName, string Color, string IconClass);

    /// <summary>
    /// 세션 형식별 표시 정보 (한국어)
    /// </summary>
    private static readonly Dictionary<SessionFormat, FormatDisplayInfo> FormatDisplayMap = new()
    {
        // 일반 세션
        [SessionFormat.Keynote] = new("키노트", "purple", "bi-star-fill"),
        [SessionFormat.Breakout] = new("브레이크아웃", "danger", "bi-mic-fill"),
        [SessionFormat.Workshop] = new("워크샵", "success", "bi-tools"),
        [SessionFormat.HandsOnLab] = new("핸즈온랩", "info", "bi-laptop"),
        [SessionFormat.Lightning] = new("라이트닝 토크", "warning", "bi-lightning-fill"),
        [SessionFormat.Panel] = new("패널 토론", "secondary", "bi-people-fill"),
        
        // 공통/운영 세션
        [SessionFormat.CheckIn] = new("체크인", "dark", "bi-person-check"),
        [SessionFormat.Break] = new("휴식", "secondary", "bi-cup-hot"),
        [SessionFormat.Lunch] = new("점심식사", "warning", "bi-egg-fried"),
        [SessionFormat.Networking] = new("네트워킹", "info", "bi-chat-dots"),
        [SessionFormat.PrizeDrawing] = new("경품추첨", "success", "bi-gift"),
        [SessionFormat.Closing] = new("클로징", "purple", "bi-flag-fill"),
        [SessionFormat.Opening] = new("오프닝", "primary", "bi-door-open")
    };

    /// <summary>
    /// 세션 토픽별 표시 정보 (한국어)
    /// </summary>
    private static readonly Dictionary<SessionTopic, TopicDisplayInfo> TopicDisplayMap = new()
    {
        [SessionTopic.Cloud] = new("클라우드", "success", "bi-cloud-fill"),
        [SessionTopic.Web] = new("웹", "danger", "bi-window-stack"),
        [SessionTopic.AI] = new("AI/ML", "primary", "bi-robot"),
        [SessionTopic.Mobile] = new("모바일", "warning", "bi-phone-fill"),
        [SessionTopic.Desktop] = new("데스크톱", "purple", "bi-display"),
        [SessionTopic.DevOps] = new("DevOps", "secondary", "bi-gear-fill"),
        [SessionTopic.Performance] = new("성능", "info", "bi-speedometer2"),
        [SessionTopic.Security] = new("보안", "dark", "bi-shield-fill"),
        [SessionTopic.Data] = new("데이터", "teal", "bi-database"),
        [SessionTopic.Gaming] = new("게임", "pink", "bi-controller"),
        [SessionTopic.General] = new("일반", "secondary", "bi-code-slash")
    };

    /// <summary>
    /// 세션 형식의 표시 이름을 반환합니다.
    /// </summary>
    public string GetFormatDisplayName(SessionFormat format)
        => FormatDisplayMap.TryGetValue(format, out var info) ? info.DisplayName : format.ToString();

    /// <summary>
    /// 세션 형식의 배지 색상 클래스를 반환합니다.
    /// </summary>
    public string GetFormatBadgeColor(SessionFormat format)
        => FormatDisplayMap.TryGetValue(format, out var info) ? info.BadgeColor : "secondary";

    /// <summary>
    /// 세션 형식의 아이콘 클래스를 반환합니다.
    /// </summary>
    public string GetFormatIconClass(SessionFormat format)
        => FormatDisplayMap.TryGetValue(format, out var info) ? info.IconClass : "bi-mic-fill";

    /// <summary>
    /// 세션 형식의 전체 표시 정보를 반환합니다.
    /// </summary>
    public FormatDisplayInfo GetFormatDisplayInfo(SessionFormat format)
        => FormatDisplayMap.TryGetValue(format, out var info) 
            ? info 
            : new FormatDisplayInfo(format.ToString(), "secondary", "bi-mic-fill");

    /// <summary>
    /// 세션 토픽의 표시 이름을 반환합니다.
    /// </summary>
    public string GetTopicDisplayName(SessionTopic topic)
        => TopicDisplayMap.TryGetValue(topic, out var info) ? info.DisplayName : topic.ToString();

    /// <summary>
    /// 세션 토픽의 색상 클래스를 반환합니다.
    /// </summary>
    public string GetTopicColor(SessionTopic topic)
        => TopicDisplayMap.TryGetValue(topic, out var info) ? info.Color : "secondary";

    /// <summary>
    /// 세션 토픽의 아이콘 클래스를 반환합니다.
    /// </summary>
    public string GetTopicIconClass(SessionTopic topic)
        => TopicDisplayMap.TryGetValue(topic, out var info) ? info.IconClass : "bi-code-slash";

    /// <summary>
    /// 세션 토픽의 전체 표시 정보를 반환합니다.
    /// </summary>
    public TopicDisplayInfo GetTopicDisplayInfo(SessionTopic topic)
        => TopicDisplayMap.TryGetValue(topic, out var info)
            ? info
            : new TopicDisplayInfo(topic.ToString(), "secondary", "bi-code-slash");
}
