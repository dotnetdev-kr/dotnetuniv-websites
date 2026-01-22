namespace DotNetUniverse.Services.StudyData;

/// <summary>
/// 스터디 데이터를 관리하는 서비스
/// </summary>
public class StudyDataService
{
    private readonly Dictionary<string, IStudyData> _slugMap;
    private readonly Dictionary<int, List<IStudyData>> _yearMap;
    private readonly List<IStudyData> _allStudies;
    private readonly List<int> _availableYears;

    public StudyDataService()
    {
        // 모든 스터디 데이터 등록
        var studyDataList = new IStudyData[]
        {
            new Build2023AfterPartyData(),
            new CSharpBackendForeachMeetup2503Data(),
            new MonthlyDotnet2308Data(),
            new MonthlyDotnet2310Data(),
            new MonthlyDotnet2311Data(),
        };

        _slugMap = studyDataList.ToDictionary(d => d.Slug, StringComparer.OrdinalIgnoreCase);
        _yearMap = studyDataList.GroupBy(d => d.Year).ToDictionary(g => g.Key, g => g.ToList());
        _allStudies = [.. studyDataList.OrderByDescending(d => d.Study.Date)];
        _availableYears = _yearMap.Keys.OrderByDescending(y => y).ToList();
    }

    /// <summary>
    /// 사용 가능한 연도 목록 (최신순)
    /// </summary>
    public IReadOnlyList<int> AvailableYears => _availableYears;

    /// <summary>
    /// 모든 스터디 목록 (최신순)
    /// </summary>
    public IReadOnlyList<IStudyData> AllStudies => _allStudies;

    /// <summary>
    /// 슬러그로 스터디 데이터 조회
    /// </summary>
    public IStudyData? GetBySlug(string slug) => _slugMap.GetValueOrDefault(slug);

    /// <summary>
    /// 슬러그로 스터디 데이터가 있는지 확인
    /// </summary>
    public bool HasSlug(string slug) => _slugMap.ContainsKey(slug);

    /// <summary>
    /// 특정 연도의 데이터가 있는지 확인
    /// </summary>
    public bool HasYear(int year) => _yearMap.ContainsKey(year);

    /// <summary>
    /// 특정 연도의 모든 스터디 데이터 조회
    /// </summary>
    public IReadOnlyList<IStudyData> GetStudiesByYear(int year) => 
        _yearMap.TryGetValue(year, out var studies) ? studies : [];

    /// <summary>
    /// 모든 스터디 데이터 조회 (최신순)
    /// </summary>
    public IEnumerable<IStudyData> GetAllStudies() => _allStudies;

    /// <summary>
    /// 가장 최근 스터디 데이터 조회
    /// </summary>
    public IStudyData? GetLatestStudy() => _allStudies.FirstOrDefault();
}
