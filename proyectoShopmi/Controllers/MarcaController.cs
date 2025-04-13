using Microsoft.AspNetCore.Mvc;
using proyectoShopmi.Models;
using proyectoShopmi.Repositorio.DAO;

namespace proyectoShopmi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcaController : ControllerBase
    {
        // GET: api/<MarcaController>
        [HttpGet("GetMarcas")]
        public async Task<ActionResult<IEnumerable<Marca>>> ListarMarcas()
        {
            var listado = await Task.Run(() => new MarcaDAO().GetMarcas());
            return Ok(listado);
        }

        // GET api/<MarcaController>/3
        [HttpGet("{codMarca}")]
        public async Task<ActionResult<Marca>> BuscarMarca(int codMarca)
        {
            var registro = await Task.Run(() => new MarcaDAO().GetMarca(codMarca));
            return Ok(registro);
        }

        // POST api/<MarcaController>
        [HttpPost]
        public async Task<ActionResult<string>> RegistrarMarca([FromBody] Marca marca)
        {
            var mensaje = await Task.Run(() => new MarcaDAO().MergeMarca(marca));
            return Ok(mensaje);
        }

        // PUT api/<MarcaController>/3
        [HttpPut("{codMarca}")]
        public async Task<ActionResult<string>> ActualizarMarca([FromBody] Marca marca)
        {
            var mensaje = await Task.Run(() => new MarcaDAO().MergeMarca(marca));
            return Ok(mensaje);
        }

        // DELETE api/<MarcaController>/3
        [HttpDelete("{codMarca}")]
        public async Task<ActionResult<string>> EliminarMarca(int codMarca)
        {
            var mensaje = await Task.Run(() => new MarcaDAO().DeleteMarca(codMarca));
            return Ok(mensaje);
        }
    }
}
