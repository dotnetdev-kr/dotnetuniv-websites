namespace DotNetUniverse.Models;

/// <summary>
/// 세션 형식 유형
/// </summary>
public enum SessionFormat
{
    /// <summary>일반 세션</summary>
    Keynote,
    Breakout,
    Workshop,
    HandsOnLab,
    Lightning,
    Panel,
    
    /// <summary>공통/운영 세션 (모든 트랙에 걸쳐 표시)</summary>
    CheckIn,
    Break,
    Lunch,
    Networking,
    PrizeDrawing,
    Closing,
    Opening
}


