namespace DotNetUniverse.Models;

/// <summary>
/// 시간표의 시간 슬롯 (행)
/// </summary>
public record TimeSlot
{
    /// <summary>
    /// 슬롯 시작 시간
    /// </summary>
    public required TimeOnly StartTime { get; init; }

    /// <summary>
    /// 슬롯 종료 시간
    /// </summary>
    public required TimeOnly EndTime { get; init; }

    /// <summary>
    /// 슬롯 시간 범위 문자열 (예: "13:00 - 14:00")
    /// </summary>
    public string TimeRange => $"{StartTime:HH:mm} - {EndTime:HH:mm}";

    /// <summary>
    /// 슬롯 지속 시간
    /// </summary>
    public TimeSpan Duration => EndTime - StartTime;
}
