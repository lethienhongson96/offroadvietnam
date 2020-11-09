using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OffRoadVietNam.API.Identity;
using OffRoadVietNam.API.Identity.ViewModel;

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
        public async Task<OkObjectResult> Create(CreateUserView createUserView)
        {
            var user = new ApplicationUser()
            {
                UserName = createUserView.Email,
                Email = createUserView.Email
            };

            var result = await userManager.CreateAsync(user, createUserView.PassWord);
            return Ok(result);
        }

    }
}
