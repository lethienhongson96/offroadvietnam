using OffRoadVietNam.Domain.Request.Plan;
using OffRoadVietNam.Domain.Response.Plan;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OffRoadVietNam.DAL.Interface
{
    public interface IPlanRepository
    {
        Task<SavePlanRes> Create(SavePlanReq createPlanReq);
        Task<IEnumerable<PlanView>> Gets();
    }
}
