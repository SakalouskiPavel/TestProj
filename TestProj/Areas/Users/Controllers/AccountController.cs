using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using TestProj.Common.DTO.Users;
using TestProj.Common.Interfaces.Services.Users;

namespace TestProj.Areas.Users.Controllers
{
    public class AccountController : ApiController
    {
        private IAccountService _service;

        public AccountController(IAccountService service)
        {
            this._service = service;
        }

        public async Task<IHttpActionResult> RegisterUser([FromBody] RegisterUserDto registerData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            await this._service.RegisterAsync(registerData);

            return Ok();
        }
    }
}
