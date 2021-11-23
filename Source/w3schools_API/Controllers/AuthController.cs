using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using w3schools_API.Models;
using w3schools_API.Services.Interfaces;

namespace w3schools_API.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public IAuth ser;
        private readonly string constr;
        public AuthController(IAuth ser, IConfiguration config)
        {
            this.ser = ser;
            constr = config.GetConnectionString("CN");
        }
        [HttpGet]
        public async Task<IActionResult> CheckLogin(string email, string password)
        {
            if (string.IsNullOrEmpty(email))
            {
                ModelState.AddModelError("Email", "Email is required");
            }

            if (string.IsNullOrEmpty(password))
            {
                ModelState.AddModelError("PassWord", "PassWord is required");
            }

            if (!ModelState.IsValid) return BadRequest(ModelState);

            var rs = await ser.CheckLogin(email, password,constr);

            return Ok(rs);
        }
        [HttpPost]
        public async Task<IActionResult> Signup(Users data)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);                      
            var rs = await ser.Signup(data, constr);          
            return Ok(rs);
        }
    }
}
