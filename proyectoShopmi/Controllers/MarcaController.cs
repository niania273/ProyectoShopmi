using Microsoft.AspNetCore.Mvc;
using proyectoShopmi.Models.Response;
using proyectoShopmi.Repositorio.Interfaces;

namespace proyectoShopmi.Controllers
{
    [Route("marcas/")]
    [ApiController]
    public class MarcaController : ControllerBase
    {
        private readonly IMarcaRepository _marcaRepository;

        public MarcaController(IMarcaRepository marcaRepository)
        {
            _marcaRepository = marcaRepository;
        }

        // GET: marcas/ListarMarcas
        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<MarcaResponse>>> ListarMarcas()
        {
            var response = await _marcaRepository.GetMarcas();
            
            if (response == null)
            {
                return BadRequest("¡Error! No se encontraron marcas.");
            }

            return Ok(response);
        }

        // GET: marcas/SelectMarcas
        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<SelectResponse>>> SelectMarcas()
        {
            var response = await _marcaRepository.SelectMarcas();
            return Ok(response);
        }

        // GET marcas/BuscarMarca
        [HttpGet("[action]/{codMarca}")]
        public async Task<ActionResult<MarcaResponse>> BuscarMarca(int codMarca)
        {
            var response = await _marcaRepository.GetMarca(codMarca);

            if (response == null)
            {
                return BadRequest("¡Error! No se encontraron marcas.");
            }

            return Ok(response);
        }

        // POST marcas/RegistrarMarca
        [HttpPost("[action]")]
        public async Task<ActionResult<string>> RegistrarMarca(MarcaResponse marca)
        {
            if (marca == null)
            {
                return BadRequest("¡Error! Ingresar datos válidos.");
            }
            var mensaje = await _marcaRepository.MergeMarca(marca, "inserción");
            return Ok(mensaje);
        }

        // PUT marcas/ActualizarMarca
        [HttpPut("[action]")]
        public async Task<ActionResult<string>> ActualizarMarca(MarcaResponse marca)
        {
            if (marca == null)
            {
                return BadRequest("¡Error! Ingresar datos válidos.");
            }
            var mensaje = await _marcaRepository.MergeMarca(marca, "actualización");
            return Ok(mensaje);
        }

        // DELETE marcas/EliminarMarca
        [HttpDelete("[action]/{codMarca}")]
        public async Task<ActionResult<string>> EliminarMarca(int codMarca)
        {
            if (codMarca == 0)
            {
                return BadRequest("¡Error! Ingresar datos válidos.");
            }
            var mensaje = await _marcaRepository.DeleteMarca(codMarca);
            return Ok(mensaje);
        }
    }
}
