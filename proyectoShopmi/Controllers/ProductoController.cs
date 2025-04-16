using Microsoft.AspNetCore.Mvc;
using proyectoShopmi.Models.Request;
using proyectoShopmi.Models.Response;
using proyectoShopmi.Repositorio.Interfaces;

namespace proyectoShopmi.Controllers
{
    [Route("productos/")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoRepository _productoRepository;

        public ProductoController(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        // GET: productos/ListarProductos
        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<ProductoResponse>>> ListarProductos()
        {
            var response = await _productoRepository.GetProductos();

            if (response == null)
            {
                return BadRequest("¡Error! No se encontraron productos.");
            }

            return Ok(response);
        }

        // GET productos/BuscarProducto/5
        [HttpGet("[action]/{codProducto}")]
        public async Task<ActionResult<ProductoResponse>> BuscarProducto(int codProducto)
        {
            if (codProducto == 0)
            {
                return BadRequest("¡Error! Ingresar datos válidos.");
            }

            var registro = await _productoRepository.GetProducto(codProducto);
            return Ok(registro);
        }

        // GET productos/RegistrarProducto
        [HttpGet("[action]")]
        public async Task<ActionResult<string>> RegistrarProducto()
        {
            
            return Ok(await Task.Run( () => new ProductoRequest()));
        }

        // POST productos/RegistrarProducto
        [HttpPost("[action]")]
        public async Task<ActionResult<string>> RegistrarProducto(ProductoRequest producto)
        {
            if (producto == null)
            {
                return BadRequest("¡Error! Ingresar datos válidos.");
            }

            var mensaje = await _productoRepository.MergeProducto(producto, "inserción");
            return Ok(mensaje);
        }

        // PUT productos/ActualizarProducto
        [HttpPut("[action]")]
        public async Task<ActionResult<string>> ActualizarProducto(ProductoRequest producto)
        {
            var mensaje = await _productoRepository.MergeProducto(producto, "actualización");
            return Ok(mensaje);
        }

        // DELETE productos/EliminarProducto/5
        [HttpDelete("{codProducto}")]
        public async Task<ActionResult<string>> EliminarProducto(int codProducto)
        {
            if (codProducto == 0)
            {
                return BadRequest("¡Error! Ingresar datos válidos.");
            }

            var mensaje = await _productoRepository.DeleteProducto(codProducto);
            return Ok(mensaje);
        }
    }
}
