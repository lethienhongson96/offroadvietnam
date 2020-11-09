using Microsoft.AspNetCore.Mvc;
using OffRoadVietNam.BAL.Interface;
using OffRoadVietNam.Domain.Request.PlanMember;
using System.Threading.Tasks;

namespace OffRoadVietNam.API.Controllers
{
    [ApiController]
    public class PlanMemberController : ControllerBase
    {
        private readonly IPlanMemberService planMemberService;

        public PlanMemberController(IPlanMemberService planMemberService)
        {
            this.planMemberService = planMemberService;
        }

        [HttpPost]
        [Route("api/planmember/Create")]
        public async Task<OkObjectResult> Create(JoinPlanReq request) => Ok(await planMemberService.Create(request));
    }
}
