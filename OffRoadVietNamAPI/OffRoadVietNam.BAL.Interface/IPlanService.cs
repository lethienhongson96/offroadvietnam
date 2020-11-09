using OffRoadVietNam.Domain.Request.Plan;
using OffRoadVietNam.Domain.Response.Plan;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OffRoadVietNam.BAL.Interface
{
    public interface IPlanService
    {
        Task<CreatePlanRes> Create(CreatePlanReq request);
    }
}
