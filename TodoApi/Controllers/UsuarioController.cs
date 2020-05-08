using System.Collections.Generic;
using TodoApi.Models;
using TodoApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace TodoApi.Controllers{
    
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController{
        private readonly UsuarioService _service;
        public UsuarioController(UsuarioService service)
        {
            _service=service;
        }
        [HttpGet]
        public ActionResult<List<Usuario>> Get(){
            _service.Create(new Usuario(){
                Name="oscar",
                Completed=true
            });
            return _service.Get();
        }
        [HttpPost]
        public ActionResult<Usuario> Create(Usuario usuario){
            _service.Create(usuario);
            return usuario; 
        }
    }
}