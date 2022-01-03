using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GaryVaultAPI.Controllers
{
    [Route("api/[controller]")]
    public class AuthenticationController : Controller
    {
        private readonly IAuthenticationService _authService;
        public AuthenticationController(IAuthenticationService authService)
        {
            _authService = authService;
        }

        [HttpGet("AuthToken")]
        public async Task<IActionResult> GetAuthToken()
        {
            return Ok(await _authService.GetAuthKeys());
        }
    }
}

