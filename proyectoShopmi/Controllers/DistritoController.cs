using Microsoft.AspNetCore.Mvc;
using proyectoShopmi.Models.Response;
using proyectoShopmi.Repositorio.Interfaces;

namespace proyectoShopmi.Controllers
{
    [Route("distritos/[controller]")]
    [ApiController]
    public class DistritoController : ControllerBase
    {
        private readonly IDistritoRepository _distritoRepository;

        public DistritoController(IDistritoRepository distritoRepository)
        {
            _distritoRepository = distritoRepository;
        }

        // GET: distritos/SelectDistritos
        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<SelectResponse>>> SelectDistritos()
        {
            var response = await _distritoRepository.SelectDistritos();
            return Ok(response);
        }
    }
}
