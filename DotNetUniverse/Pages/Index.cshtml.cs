using DotNetUniverse.Models;
using DotNetUniverse.Services.EventData;
using DotNetUniverse.Services.StudyData;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetUniverse.Pages
{
    public class IndexModel : PageModel
    {
        private readonly EventDataService _eventDataService;
        private readonly StudyDataService _studyDataService;

        public IndexModel(EventDataService eventDataService, StudyDataService studyDataService)
        {
            _eventDataService = eventDataService;
            _studyDataService = studyDataService;
        }

        /// <summary>
        /// 현재 모집 중인 행사들 (Registration 또는 CallForParticipation 상태)
        /// </summary>
        public IReadOnlyList<IEventData> RegistrationEvents { get; private set; } = [];

        /// <summary>
        /// 최근 완료된 행사들 (히스토리용)
        /// </summary>
        public IReadOnlyList<IEventData> PastEvents { get; private set; } = [];

        /// <summary>
        /// 스터디 목록
        /// </summary>
        public IReadOnlyList<IStudyData> Studies { get; private set; } = [];

        public void OnGet()
        {
            // 현재 모집 중인 행사들
            RegistrationEvents = _eventDataService.AllEvents
                .Where(e => e.Event.Status == EventStatus.Registration || e.Event.Status == EventStatus.CallForParticipation)
                .ToList();

            // 과거 행사들 (최신순, 본 컨퍼런스만)
            PastEvents = _eventDataService.AllEvents
                .Where(e => !e.Event.IsUpcoming && e.Event.Scale == EventScale.Conference)
                .Take(6)
                .ToList();

            // 스터디 목록 (최신순)
            Studies = _studyDataService.AllStudies;
        }
    }
}
