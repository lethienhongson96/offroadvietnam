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

        [HttpPost]
        [Route("api/Plan/Create")]
        public async Task<OkObjectResult> SaveCourse(CreatePlanReq request)
        {
            var result = await planService.Create(request);
            return Ok(result);
        }
    }
}
