using OffRoadVietNam.BAL.Interface;
using OffRoadVietNam.DAL.Interface;
using OffRoadVietNam.Domain.Request.Plan;
using OffRoadVietNam.Domain.Response.Plan;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OffRoadVietNam.BAL.Implement
{
    public class PlanService : IPlanService
    {
        private readonly IPlanRepository planRepository;

        public PlanService(IPlanRepository planRepository)
        {
            this.planRepository = planRepository;
        }
        public async Task<SavePlanRes> Create(SavePlanReq request)
        {
            return await planRepository.Create(request);
        }

        public async Task<IEnumerable<PlanView>> GetPlans()
        {
            return await planRepository.Gets();
        }
    }
}
