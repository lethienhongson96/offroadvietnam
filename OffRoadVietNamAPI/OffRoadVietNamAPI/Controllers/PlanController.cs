using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OffRoadVietNam.BAL.Interface;
using OffRoadVietNam.Domain.Request.Plan;

namespace OffRoadVietNam.API.Controllers
{
    [ApiController]
    public class PlanController : ControllerBase
    {
        private readonly IPlanService planService;

        public PlanController(IPlanService planService)
        {
            this.planService = planService;
        }

        [HttpPost,HttpPatch]
        [Route("api/plan/Save")]
        public async Task<OkObjectResult> SavePlan(SavePlanReq request)
        {
            var result = await planService.Create(request);
            return Ok(result);
        }

        [HttpGet]
        [Route("api/plan/gets")]
        public async Task<OkObjectResult> GetPlans()
        {
            var result = await planService.GetPlans();
            return Ok(result);
        }
    }
}
