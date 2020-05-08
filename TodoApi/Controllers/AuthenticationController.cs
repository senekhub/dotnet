using System.Collections.Generic;
using TodoApi.Models;
using TodoApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace TodoApi.Controllers{

    [Authorize]
    [ApiController]
    [Route("api/[Controller]")]
    public class AuthenticationController : ControllerBase{

        private readonly IJwtAuthenticationManager jwtAuthenticationManager;

        public AuthenticationController(IJwtAuthenticationManager jwtAuthenticationManager)
        {
            this.jwtAuthenticationManager=jwtAuthenticationManager;
        }
        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate(){
            var token=jwtAuthenticationManager.Authenticate("test1","password1");
            if (token==null)
                return Unauthorized();
            return Ok(token);
        }
    }
}