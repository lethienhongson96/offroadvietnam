using OffRoadVietNam.Domain.Request.Plan;
using OffRoadVietNam.Domain.Response.Plan;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OffRoadVietNam.DAL.Interface
{
    public interface IPlanRepository
    {
        Task<SavePlanRes> Create(SavePlanReq createPlanReq);
        Task<IEnumerable<PlanView>> Gets();
        Task<SavePlanRes> ChangeStatus(ChangeStatusReq changeStatusReq);
    }
}
