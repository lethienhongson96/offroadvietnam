using OffRoadVietNam.Domain.Request.PlanMember;
using OffRoadVietNam.Domain.Response.PlanMember;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OffRoadVietNam.BAL.Interface
{
    public interface IPlanMemberService
    {
        Task<JoinMemberRes> Create(JoinPlanReq request);
    }
}
