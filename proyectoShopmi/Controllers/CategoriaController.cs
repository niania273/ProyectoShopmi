using Microsoft.AspNetCore.Mvc;
using proyectoShopmi.Models;
using proyectoShopmi.Repositorio.DAO;
using proyectoShopmi.Repositorio.Interfaces;

namespace proyectoShopmi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        // GET: api/<CategoriaController>
        [HttpGet("GetCategorias")]
        public async Task<ActionResult<IEnumerable<Categoria>>> ListarCategorias()
        {
            var listado = await Task.Run(() => new CategoriaDAO().GetCategorias());
            return Ok(listado);
        }

        // GET: api/<CategoriaController>/5
        [HttpGet("{codcategoria}")]
        public async Task<ActionResult<Categoria>> BuscarCategoria(int codcategoria)
        {
            var registro = await Task.Run(() => new CategoriaDAO().GetCategoria(codcategoria));
            return Ok(registro);
        }

        // POST api/<CategoriaController>
        [HttpPost]
        public async Task<ActionResult<string>> RegistrarCategoria([FromBody] Categoria categoria)
        {
            var mensaje = await Task.Run(() => new CategoriaDAO().MergeCategoria(categoria));
            return Ok(mensaje);
        }

        // PUT api/<CategoriaController>/5
        [HttpPut("{codcategoria}")]
        public async Task<ActionResult<string>> ActualizarCategoria([FromBody] Categoria categoria)
        {
            var mensaje = await Task.Run(() => new CategoriaDAO().MergeCategoria(categoria));
            return Ok(mensaje);
        }

        // DELETE api/<CategoriaController>/5
        [HttpDelete("{codcategoria}")]
        public async Task<ActionResult<string>> EliminarCategoria(int codcategoria)
        {
            var mensaje = await Task.Run(() => new CategoriaDAO().DeleteCategoria(codcategoria));
            return Ok(mensaje);
        }
    }
}
