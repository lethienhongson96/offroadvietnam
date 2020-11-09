using System;
using System.Collections.Generic;
using System.Text;

namespace OffRoadVietNam.Domain.Request.User
{
    public class CreateUserReq
    {
        public string Email { get; set; }
        public string PassWord { get; set; }
    }
}
