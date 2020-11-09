using System;
using System.Collections.Generic;
using System.Text;

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
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int Status { get; set; }
    }
}
