using Microsoft.AspNetCore.Mvc;
using proyectoShopmi.Models;
using proyectoShopmi.Repositorio.DAO;

namespace proyectoShopmi.Controllers
{
    [Route("clientes/[controller]"), ApiController]
    public class Cliente1Controller : ControllerBase
    {
        [HttpGet("listar")]
        public async Task<ActionResult<IEnumerable<Cliente>>> ListarClientes()
        {
            var listado = await Task.Run(() => new ClienteDAO().GetClientes());
            return Ok(listado);
        }

        [HttpGet("{codcliente}")]
        public async Task<ActionResult<Cliente>> BuscarCliente(int codcliente)
        {
            var registro = await Task.Run(() => new ClienteDAO().GetCliente(codcliente));
            return Ok(registro);
        }


        [HttpPost]
        public async Task<ActionResult<string>> RegistrarCliente([FromBody] Cliente cliente)
        {
            var mensaje = await Task.Run(() => new ClienteDAO().MergeCliente(cliente));
            return Ok(mensaje);
        }

        [HttpPut("{codcliente}")]
        public async Task<ActionResult<string>> ActualizarCliente([FromBody] Cliente cliente)
        {
            var mensaje = await Task.Run(() => new ClienteDAO().MergeCliente(cliente));
            return Ok(mensaje);
        }


        [HttpDelete("{codcliente}")]
        public async Task<ActionResult<string>> EliminarCliente(int codcliente)
        {
            var mensaje = await Task.Run(() => new ClienteDAO().DeleteCliente(codcliente));
            return Ok(mensaje);
        }
    }
}
