using System;

namespace OffRoadVietNam.Domain.Request.Plan
{
    public class SavePlanReq
    {
        public int PlanId { get; set; }
        public string PlaceName { get; set; }
        public string Title { get; set; }
        public int LevelDifficult { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int Status { get; set; }
    }
}
