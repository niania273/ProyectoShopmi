using Microsoft.AspNetCore.Mvc;
using proyectoShopmi.Models;
using proyectoShopmi.Repositorio.DAO;

namespace proyectoShopmi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : Controller
    {
        // GET: api/<ProductoController>
        [HttpGet("GetProductos")]

        public async Task<ActionResult<IEnumerable<Producto>>> ListarProductos()
        {
            var listado = await Task.Run(() => new ProductoDAO().GetProductos());
            return Ok(listado);
        }

        // GET api/<ProductoController>/5
        [HttpGet("{codProducto}")]
        public async Task<ActionResult<Producto>> BuscarProducto(int codProducto)
        {
            var registro = await Task.Run(() => new ProductoDAO().GetProducto(codProducto));
            return Ok(registro);
        }

        // POST api/<ProductoController>
        [HttpPost]
        public async Task<ActionResult<string>> RegistrarProducto([FromBody] Producto producto)
        {
            var mensaje = await Task.Run(() => new ProductoDAO().MergeProducto(producto));
            return Ok(mensaje);
        }

        // PUT api/<ProductoController>/5
        [HttpPut("{codProducto}")]
        public async Task<ActionResult<string>> ActualizarProducto([FromBody] Producto producto)
        {
            var mensaje = await Task.Run(() => new ProductoDAO().MergeProducto(producto));
            return Ok(mensaje);
        }

        // DELETE api/<ProductoController>/5
        [HttpDelete("{codProducto}")]
        public async Task<ActionResult<string>> EliminarProducto(int codProducto)
        {
            var mensaje = await Task.Run(() => new ProductoDAO().DeleteProducto(codProducto));
            return Ok(mensaje);
        }
    }
}
