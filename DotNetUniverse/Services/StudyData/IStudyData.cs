using DotNetUniverse.Models;

namespace DotNetUniverse.Services.StudyData;

/// <summary>
/// 스터디/시청 모임 데이터를 정의하는 인터페이스
/// </summary>
public interface IStudyData
{
    /// <summary>
    /// 스터디 고유 URL 경로 (예: "study/build-2023-after-party")
    /// 선행 슬래시(/) 없이 지정하며, 이 경로가 그대로 URL이 됩니다.
    /// </summary>
    string Slug { get; }

    /// <summary>
    /// 스터디 URL (선행 슬래시 포함)
    /// </summary>
    string Url => $"/{Slug}";

    /// <summary>
    /// 스터디 연도 (정렬/그룹화용)
    /// </summary>
    int Year { get; }

    /// <summary>
    /// 스터디 정보
    /// </summary>
    StudyInfo Study { get; }

    /// <summary>
    /// 스터디별 테마 컬러 (CSS 색상)
    /// </summary>
    string ThemeColor => "#0078d4";

    /// <summary>
    /// 스터디별 테마 컬러 클래스 (Bootstrap)
    /// </summary>
    string ThemeColorClass => "primary";
}
