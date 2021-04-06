using Maestro.Authentication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maestro.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private UserManager<ApplicationUser> _userManager;
        public AuthController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<string> Get()
        {
            

            //var user = _userManager.FindByNameAsync("cj@gmail.com");

            //if (user == null) {
            string password = "Sample";

            var newUser = new ApplicationUser()
            {
                UserName = "cj@gmail.com",
                Email = "cj@gmail.com"

            };

            var d = await _userManager.CreateAsync(newUser, password);

            //}

            return d.Succeeded.ToString();
        }
    }
}
