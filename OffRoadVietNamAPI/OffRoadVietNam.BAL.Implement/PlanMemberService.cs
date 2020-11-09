using OffRoadVietNam.BAL.Interface;
using OffRoadVietNam.DAL.Interface;
using OffRoadVietNam.Domain.Request.PlanMember;
using OffRoadVietNam.Domain.Response.PlanMember;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OffRoadVietNam.BAL.Implement
{
    public class PlanMemberService : IPlanMemberService
    {
        private readonly IPlanMemberRepository planMemberRepository;

        public PlanMemberService(IPlanMemberRepository planMemberRepository)
        {
            this.planMemberRepository = planMemberRepository;
        }

        public async Task<JoinMemberRes> Create(JoinPlanReq request) => await planMemberRepository.Create(request);
    }
}
