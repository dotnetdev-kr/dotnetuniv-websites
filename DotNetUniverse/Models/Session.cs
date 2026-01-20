namespace DotNetUniverse.Models;

/// <summary>
/// 세션 정보
/// </summary>
public record Session
{
    /// <summary>
    /// 세션 고유 ID
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// 세션 제목
    /// </summary>
    public required string Title { get; init; }

    /// <summary>
    /// 세션 상세 설명
    /// </summary>
    public required string Abstract { get; init; }

    /// <summary>
    /// 발표자 목록
    /// </summary>
    public required Speaker[] Speakers { get; init; }

    /// <summary>
    /// 세션 형식 (키노트, 브레이크아웃 등)
    /// </summary>
    public required SessionFormat Format { get; init; }

    /// <summary>
    /// 세션 진행 시간
    /// </summary>
    public required TimeSpan Duration { get; init; }

    /// <summary>
    /// 모든 트랙에 걸쳐 표시되는 공통 세션 여부 (체크인, 점심, 휴식 등)
    /// </summary>
    public bool IsShared { get; init; } = false;

    /// <summary>
    /// 스케줄 정보
    /// </summary>
    public SessionSchedule? Schedule { get; init; }

    /// <summary>
    /// 세션 주제
    /// </summary>
    public SessionTopic? Topic { get; init; }

    /// <summary>
    /// 영상 URL
    /// </summary>
    public string? VideoUrl { get; init; }

    /// <summary>
    /// 발표 자료 URL
    /// </summary>
    public string? SlidesUrl { get; init; }

    /// <summary>
    /// 태그 목록
    /// </summary>
    public string[]? Tags { get; init; }

    /// <summary>
    /// 운영 노트
    /// </summary>
    public string[]? Notes { get; init; }

    /// <summary>
    /// 사전 요구 사항
    /// </summary>
    public string? Prerequisites { get; init; }

    /// <summary>
    /// 핸즈온랩 모듈 목록
    /// </summary>
    public LabModule[]? LabModules { get; init; }

    /// <summary>
    /// 요약 설명의 최대 길이
    /// </summary>
    private const int MaxDescriptionLength = 80;

    /// <summary>
    /// 대표 발표자 (첫 번째 발표자)
    /// </summary>
    public Speaker PrimarySpeaker => Speakers[0];

    /// <summary>
    /// 운영 노트가 있는지 여부
    /// </summary>
    public bool HasNotes => Notes is { Length: > 0 };

    /// <summary>
    /// 핸즈온랩 모듈이 있는지 여부
    /// </summary>
    public bool HasLabModules => LabModules is { Length: > 0 };

    /// <summary>
    /// 스케줄 정보가 있는지 여부
    /// </summary>
    public bool HasSchedule => Schedule is not null;

    /// <summary>
    /// 사전 요구 사항이 있는지 여부
    /// </summary>
    public bool HasPrerequisites => !string.IsNullOrWhiteSpace(Prerequisites);


    /// <summary>
    /// 모달 ID (HTML용)
    /// </summary>
    public string ModalId => $"session-modal-{Id}";

    /// <summary>
    /// 앵커 해시 (URL용)
    /// </summary>
    public string AnchorHash => $"#session-{Id}";

    /// <summary>
    /// YouTube 영상인지 여부
    /// </summary>
    public bool IsYouTubeVideo => !string.IsNullOrEmpty(VideoUrl) &&
        (VideoUrl.Contains("youtube.com") || VideoUrl.Contains("youtu.be"));

    /// <summary>
    /// YouTube 임베드 URL 추출
    /// </summary>
    public string? YouTubeEmbedUrl
    {
        get
        {
            if (!IsYouTubeVideo) return null;

            // youtube.com/watch?v=VIDEO_ID 형식
            if (VideoUrl!.Contains("watch?v="))
            {
                var videoId = VideoUrl.Split("watch?v=")[1].Split('&')[0];
                return $"https://www.youtube.com/embed/{videoId}";
            }

            // youtu.be/VIDEO_ID 형식
            if (VideoUrl.Contains("youtu.be/"))
            {
                var videoId = VideoUrl.Split("youtu.be/")[1].Split('?')[0];
                return $"https://www.youtube.com/embed/{videoId}";
            }

            return null;
        }
    }

    /// <summary>
    /// 한 줄 설명 (Abstract에서 자동 생성, 줄바꿈 제거 후 일정 길이 이상이면 ellipsis 처리)
    /// </summary>
    public string Description
    {
        get
        {
            // 줄바꿈을 공백으로 변환하고 연속 공백 제거
            var singleLine = System.Text.RegularExpressions.Regex.Replace(
                Abstract.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "),
                @"\s+", " ").Trim();
            
            if (singleLine.Length <= MaxDescriptionLength)
                return singleLine;
            
            // 단어 단위로 자르기
            var truncated = singleLine[..MaxDescriptionLength];
            var lastSpace = truncated.LastIndexOf(' ');
            if (lastSpace > MaxDescriptionLength / 2)
                truncated = truncated[..lastSpace];
            
            
            return truncated.TrimEnd() + "...";
        }
    }
}
