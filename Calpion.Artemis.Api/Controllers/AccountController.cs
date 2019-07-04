using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Calpion.Artemis.Api.Controllers
{
    public class LoginRequestContract
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    [Produces("application/json")]
    
    public class AccountController : Controller
    {
        [HttpPost]
        [Route("Account/Login")]
        public bool Login([FromBody] LoginRequestContract loginRequestContract)
        {
            if(loginRequestContract.UserName == "john@truckstop.com" && loginRequestContract.Password =="Welcome@123")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}