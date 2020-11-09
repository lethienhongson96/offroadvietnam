using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OffRoadVietNam.Domain.Request.User;
using System.Threading.Tasks;

namespace OffRoadVietNam.API.Controllers
{
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<IdentityUser> userManager;

        public AccountController(UserManager<IdentityUser> userManager)
        {
            this.userManager = userManager;
        }

        [HttpPost]
        [Route("api/Account/Create")]
        public async Task<OkObjectResult> Create(CreateUserReq createUserReq)
        {
            var user = new IdentityUser()
            {
                UserName = createUserReq.Email,
                Email = createUserReq.Email
            };
            var result = await userManager.CreateAsync(user, createUserReq.PassWord);

            return Ok(result);
        }

        [HttpGet]
        [Route("api/Account/Gets")]
        public async Task<OkObjectResult> Gets() => Ok(await userManager.Users.ToListAsync());

    }
}
