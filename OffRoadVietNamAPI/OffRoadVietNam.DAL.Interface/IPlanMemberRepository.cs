using OffRoadVietNam.Domain.Request.PlanMember;
using OffRoadVietNam.Domain.Response.PlanMember;
using System.Threading.Tasks;

namespace OffRoadVietNam.DAL.Interface
{
    public interface IPlanMemberRepository
    {
        Task<JoinMemberRes> Create(JoinPlanReq joinPlanReq);
    }
}
