using CourseAPI.Models.Usuarios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseAPI.Controllers
{
    [Route("api/v1/usuario")]
    [ApiController]
    public class UsuarioController: ControllerBase
    {
        [HttpPost]
        [Route("logar")]
        public IActionResult Logar(LoginViewModelInput loginViewModelInput)
        {
            return Ok(loginViewModelInput);
        }

        [HttpPost]
        [Route("registrar")]
        public IActionResult Registrar(RegistroViewModelInput registroViewModelInput)
        {
            return Created("", registroViewModelInput);
        }
    }
}
