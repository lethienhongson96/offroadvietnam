using System;

namespace OffRoadVietNam.Domain.Response.Plan
{
    public class PlanView
    {
        public int PlanId { get; set; }
        public string PlaceName { get; set; }
        public string Title { get; set; }
        public int LevelDifficult { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string StartDateStr { get; set; }
        public string EndDateStr { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateDateStr { get; set; }
        public int Status { get; set; }
        public string StatusName { get; set; }
    }
}
