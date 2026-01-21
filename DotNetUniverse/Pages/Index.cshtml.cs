using DotNetUniverse.Models;
using DotNetUniverse.Services.EventData;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetUniverse.Pages
{
    public class IndexModel : PageModel
    {
        private readonly EventDataService _eventDataService;

        public IndexModel(EventDataService eventDataService)
        {
            _eventDataService = eventDataService;
        }

        /// <summary>
        /// 예정된 (다가오는) 행사
        /// </summary>
        public IEventData? UpcomingEvent { get; private set; }

        /// <summary>
        /// 최근 완료된 행사들 (히스토리용)
        /// </summary>
        public IReadOnlyList<IEventData> PastEvents { get; private set; } = [];

        /// <summary>
        /// 예정된 행사가 있는지 여부
        /// </summary>
        public bool HasUpcomingEvent => UpcomingEvent != null;

        public void OnGet()
        {
            // 예정된 행사 (날짜가 미래인 행사 중 가장 가까운 것)
            UpcomingEvent = _eventDataService.AllEvents
                .FirstOrDefault(e => e.Event.IsUpcoming);

            // 과거 행사들 (최신순, 본 컨퍼런스만)
            PastEvents = _eventDataService.AllEvents
                .Where(e => !e.Event.IsUpcoming && e.Event.Scale == EventScale.Conference)
                .Take(6)
                .ToList();
        }
    }
}
