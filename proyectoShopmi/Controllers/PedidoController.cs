using Microsoft.AspNetCore.Mvc;
using proyectoShopmi.Models;
using proyectoShopmi.Repositorio.DAO;

namespace proyectoShopmi.Controllers
{
    [Route("pedidos/[controller]"), ApiController]
    public class PedidoController : ControllerBase
    {
        // GET pedidos/Pedido/listar
        [HttpGet("listar")]
        public async Task<ActionResult<IEnumerable<Pedido>>> ListarPedidos()
        {
            var listado = await Task.Run(() => new PedidoDAO().GetPedidos());
            return Ok(listado);
        }

        // GET pedidos/Pedido/listar/5
        [HttpGet("listar/{codPedido}")]
        public async Task<ActionResult<Pedido>> BuscarPedido(int codPedido)
        {
            var registro = await Task.Run(() => new PedidoDAO().GetPedido(codPedido));
            return Ok(registro);
        }

        // POST pedidos/Pedido/registrar
        [HttpPost("registrar")]
        public async Task<ActionResult<string>> RegistrarPedido(Pedido pedido)
        {
            var mensaje = await Task.Run(() => new PedidoDAO().MergePedido(pedido));
            return Ok(mensaje);
        }

        // PUT pedidos/Pedido/actualizar
        [HttpPut("actualizar")]
        public async Task<ActionResult<string>> ActualizarPedido(Pedido pedido)
        {
            var mensaje = await Task.Run(() => new PedidoDAO().MergePedido(pedido));
            return Ok(mensaje);
        }

        // DELETE pedidos/Pedido/5
        [HttpDelete("eliminar/{codPedido}")]
        public async Task<ActionResult<string>> EliminarPedido(int codPedido)
        {
            var mensaje = await Task.Run(() => new PedidoDAO().DeletePedido(codPedido));
            return Ok(mensaje);
        }

    }
}
