using Microsoft.AspNetCore.Mvc;
using proyectoShopmi.Models;
using proyectoShopmi.Repositorio;

namespace proyectoShopmi.Controllers
{
    [Route("usuarios/[controller]"), ApiController]
    public class UsuarioController : ControllerBase
    {
        // GET usuarios/<UsuarioController>
        [HttpGet("listar")]
        public async Task<ActionResult<IEnumerable<Usuario>>> ListarUsuarios()
        {
            var listado = await Task.Run(() => new UsuarioRepository().GetUsuarios());
            return Ok(listado);
        }

        // GET usuarios/<UsuarioController>/5
        [HttpGet("listar/{codUsu}")]
        public async Task<ActionResult<Usuario>> BuscarUsuario(int codUsu)
        {
            var registro = await Task.Run(() => new UsuarioRepository().GetUsuario(codUsu));
            return Ok(registro);
        }

        // POST usuarios/<UsuarioController>
        [HttpPost("registrar")]
        public async Task<ActionResult<string>> RegistrarUsuario(Usuario usuario)
        {
            var mensaje = await Task.Run(() => new UsuarioRepository().MergeUsuario(usuario, "inserción"));
            return Ok(mensaje);
        }

        // PUT usuarios/<UsuarioController>/5
        [HttpPut("actualizar")]
        public async Task<ActionResult<string>> ActualizarUsuario(Usuario usuario)
        {
            var mensaje = await Task.Run(() => new UsuarioRepository().MergeUsuario(usuario, "actualización"));
            return Ok(mensaje);
        }

        // DELETE usuarios/<UsuarioController>/5
        [HttpDelete("{codUsu}")]
        public async Task<ActionResult<string>> EliminarUsuario(int codUsu)
        {
            var mensaje = await Task.Run(() => new UsuarioRepository().DeleteUsuario(codUsu));
            return Ok(mensaje);
        }
    }
}