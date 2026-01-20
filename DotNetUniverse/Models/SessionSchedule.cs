namespace DotNetUniverse.Models;

/// <summary>
/// 세션 스케줄 정보
/// </summary>
public record SessionSchedule
{
    /// <summary>
    /// 행사 일차
    /// </summary>
    public required int Day { get; init; }

    /// <summary>
    /// 시작 시간
    /// </summary>
    public required TimeOnly StartTime { get; init; }

    /// <summary>
    /// 종료 시간 (선택적, Duration으로 계산 가능)
    /// </summary>
    public TimeOnly? EndTime { get; init; }
}
