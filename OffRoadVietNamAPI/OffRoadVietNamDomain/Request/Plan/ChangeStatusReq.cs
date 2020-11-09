using System;
using System.Collections.Generic;
using System.Text;

namespace OffRoadVietNam.Domain.Request.Plan
{
    public class ChangeStatusReq
    {
        public int PlanId { get; set; }
        public int Status { get; set; }
    }
}
