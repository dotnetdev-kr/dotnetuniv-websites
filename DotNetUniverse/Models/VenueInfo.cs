using DotNetUniverse.Models.Collections;

namespace DotNetUniverse.Models;

/// <summary>
/// 행사장 정보
/// </summary>
public record VenueInfo
{
    /// <summary>
    /// 행사장 고유 ID
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// 행사장 이름
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// 행사장 주소
    /// </summary>
    public required string Address { get; init; }

    /// <summary>
    /// 네이버 지도 URL
    /// </summary>
    public string? NaverMapUrl { get; init; }

    /// <summary>
    /// 카카오 지도 URL
    /// </summary>
    public string? KakaoMapUrl { get; init; }

    /// <summary>
    /// 구글 지도 URL
    /// </summary>
    public string? GoogleMapUrl { get; init; }

    /// <summary>
    /// 오시는 길 안내
    /// </summary>
    public string[]? Directions { get; init; }

    /// <summary>
    /// 주차 안내
    /// </summary>
    public string? ParkingInfo { get; init; }

    /// <summary>
    /// 이 장소의 트랙 목록 (TrackCollection으로 관리)
    /// </summary>
    public TrackCollection Tracks { get; init; } = [];

    /// <summary>
    /// 이 장소의 시간표 그리드 목록 (행/열 기반)
    /// </summary>
    public ScheduleGridCollection Schedules { get; init; } = [];

    /// <summary>
    /// 트랙이 있는지 여부
    /// </summary>
    public bool HasTracks => Tracks.Count > 0;

    /// <summary>
    /// 시간표 그리드가 있는지 여부
    /// </summary>
    public bool HasSchedules => Schedules.Count > 0;

    /// <summary>
    /// 트랙 수
    /// </summary>
    public int TrackCount => Tracks.Count;

    /// <summary>
    /// ID로 트랙 찾기
    /// </summary>
    public Track? GetTrack(string id) => Tracks.TryGet(id);

    /// <summary>
    /// 이 장소의 모든 세션
    /// </summary>
    public IEnumerable<Session> AllSessions => Tracks.AllSessions;

    /// <summary>
    /// 이 장소의 총 세션 수
    /// </summary>
    public int TotalSessionCount => Tracks.TotalSessionCount;

    /// <summary>
    /// 이 장소의 모든 발표자 (중복 제거)
    /// </summary>
    public IEnumerable<Speaker> AllSpeakers => Tracks.AllSpeakers;

    /// <summary>
    /// 지도 링크가 있는지 여부
    /// </summary>
    public bool HasMapLinks => !string.IsNullOrEmpty(NaverMapUrl) 
        || !string.IsNullOrEmpty(KakaoMapUrl) 
        || !string.IsNullOrEmpty(GoogleMapUrl);

    /// <summary>
    /// 교통편 정보가 있는지 여부
    /// </summary>
    public bool HasDirections => Directions is { Length: > 0 };

    /// <summary>
    /// 주차 정보가 있는지 여부
    /// </summary>
    public bool HasParkingInfo => !string.IsNullOrEmpty(ParkingInfo);
}
