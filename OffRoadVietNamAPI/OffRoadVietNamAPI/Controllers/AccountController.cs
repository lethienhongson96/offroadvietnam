using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OffRoadVietNam.API.Identity;
using OffRoadVietNam.Domain.Request.User;
using System.Threading.Tasks;

namespace OffRoadVietNam.API.Controllers
{
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;

        public AccountController(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }

        [HttpPost]
        [Route("api/Account/Create")]
        public async Task<OkObjectResult> Create(CreateUserReq createUserReq)
        {
            var user = new ApplicationUser()
            {
                UserName = createUserReq.Email,
                Email = createUserReq.Email
            };

            var result = await userManager.CreateAsync(user, createUserReq.PassWord);
            return Ok(result);
        }

    }
}
