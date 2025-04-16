using Microsoft.AspNetCore.Mvc;
using proyectoShopmi.Models.Response;
using proyectoShopmi.Repositorio.Interfaces;

namespace proyectoShopmi.Controllers
{
    [Route("categorias/")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaController(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        // GET: categorias/ListarCategorias
        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<CategoriaResponse>>> ListarCategorias()
        {
            var response = await _categoriaRepository.GetCategorias();

            if (response == null)
            {
                return BadRequest("¡Error! No se encontraron categorías.");
            }

            return Ok(response);
        }

        // GET: categorias/SelectCategorias
        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<SelectResponse>>> SelectCategorias()
        {
            var response = await _categoriaRepository.SelectCategorias();
            return Ok(response);
        }

        // GET: categorias/BuscarCategoria
        [HttpGet("[action]/{codcategoria}")]
        public async Task<ActionResult<CategoriaResponse>> BuscarCategoria(int codcategoria)
        {
            var registro = await _categoriaRepository.GetCategoria(codcategoria);
            return Ok(registro);
        }

        // POST categorias/RegistrarCategoria
        [HttpPost("[action]")]
        public async Task<ActionResult<string>> RegistrarCategoria( CategoriaResponse categoria)
        {
            if (categoria == null)
            {
                return BadRequest("¡Error! Ingresar datos válidos.");
            }

            var mensaje = await _categoriaRepository.MergeCategoria(categoria, "inserción");
            return Ok(mensaje);
        }

        // PUT categorias/ActualizarCategoria
        [HttpPut("[action]")]
        public async Task<ActionResult<string>> ActualizarCategoria( CategoriaResponse categoria)
        {
            if (categoria == null)
            {
                return BadRequest("¡Error! Ingresar datos válidos.");
            }

            var mensaje = await _categoriaRepository.MergeCategoria(categoria, "actualización");
            return Ok(mensaje);
        }

        // DELETE categorias/EliminarCategoria
        [HttpDelete("[action]/{codcategoria}")]
        public async Task<ActionResult<string>> EliminarCategoria(int codcategoria)
        {
            if (codcategoria == 0)
            {
                return BadRequest("¡Error! Ingresar datos válidos.");
            }

            var mensaje = await _categoriaRepository.DeleteCategoria(codcategoria);
            return Ok(mensaje);
        }
    }
}
