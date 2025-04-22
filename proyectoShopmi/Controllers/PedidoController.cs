using Microsoft.AspNetCore.Mvc;
using proyectoShopmi.Models;
using proyectoShopmi.Models.Request;
using proyectoShopmi.Repositorio.Interfaces;

namespace proyectoShopmi.Controllers
{
    [Route("pedidos/[controller]"), ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IDetallePedidoRepository _detallePedidoRepository;

        public PedidoController(IPedidoRepository pedidoRepository, IDetallePedidoRepository detallePedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
            _detallePedidoRepository = detallePedidoRepository;
        }

        // GET pedidos/Pedido/listar
        [HttpGet("listar")]
        public async Task<ActionResult<IEnumerable<PedidoRequest>>> ListarPedidos()
        {
            var listado = _pedidoRepository.GetPedidos();
            return Ok(listado);
        }

        // GET pedidos/Pedido/listar/5
        [HttpGet("listar/{codPedido}")]
        public async Task<ActionResult<PedidoRequest>> BuscarPedido(int codPedido)
        {
            var registro = await _pedidoRepository.GetPedido(codPedido);
            return Ok(registro);
        }

        // POST pedidos/Pedido/registrar
        [HttpPost("registrar")]
        public async Task<ActionResult<string>> RegistrarPedido(PedidoDetallePedidoRequest pedidoDetallePedido)
        {
            //Total de inserciones a DetallePedido
            decimal precioTotal = 0;
            int filaInsertada = 0;
            int filaActualizada = 0;
            int totalRespuestas = 0;
            string mensaje = "";

            // 1. Crear un objeto pedido a partir de PedidoDetallePedidoRequest
            PedidoRequest pedido = new PedidoRequest
            {
                codUsuario = pedidoDetallePedido.codUsuario,
                fecPed = DateTime.Today
            };

            //2. Insertar Pedido y devolver ID
            pedido.codPedido = await _pedidoRepository.InsertPedido(pedido); 

            if (pedido.codPedido != 0)
            {
                // 3. Recorrer la lista de productos ingresados
                for (int i = 0; i < pedidoDetallePedido.productos.Count(); i++)
                {
                    // 4. Crear un objeto de Producto
                    var producto = pedidoDetallePedido.productos[i];
                    var cantidad = pedidoDetallePedido.cantidades[i];

                    // 4. Crear un objeto de DetallePedido
                    DetallePedidoRequest detallePedidoRequest = new DetallePedidoRequest
                    {
                        codPedido = pedido.codPedido,
                        codProducto = producto.codProducto,
                        cantidad = cantidad,
                        preUni = producto.preUni,
                        estPP = true
                    };

                    // 5. Insertar DetallePedido
                    filaInsertada = await _detallePedidoRepository.insertDetallePedido(detallePedidoRequest);
                    precioTotal += producto.preUni;
                    totalRespuestas += filaInsertada;
                }
                pedido.precioTotal = precioTotal;
                filaActualizada = await _pedidoRepository.UpdatePedidoPrecio(pedido);

                if (filaActualizada != 0)
                {
                    mensaje = $"Se han registrado {totalRespuestas} detalles de pedido. El precio total es {precioTotal}";
                }
            }
            return Ok(mensaje);
        }

        // PUT pedidos/Pedido/actualizar
        //[HttpPut("actualizar")]
        //public async Task<ActionResult<string>> ActualizarPedido(PedidoRequest pedido)
        //{
        //    var mensaje = await _pedidoRepository.UpdatePedido(pedido);
        //    return Ok(mensaje);
        //}

        // DELETE pedidos/Pedido/5
        [HttpDelete("eliminar/{codPedido}")]
        public async Task<ActionResult<string>> EliminarPedido(int codPedido)
        {
            var mensaje = await _pedidoRepository.DeletePedido(codPedido);
            return Ok(mensaje);
        }

    }
}
