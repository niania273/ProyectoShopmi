using Microsoft.AspNetCore.Mvc;
using proyectoShopmi.Models.Response;
using proyectoShopmi.Repositorio.Interfaces;

namespace proyectoShopmi.Controllers
{
    [Route("sucursales/")]
    [ApiController]
    public class SucursalController : ControllerBase
    {
        private readonly ISucursalRepository _sucursalRepository;

        public SucursalController(ISucursalRepository sucursalRepository)
        {
            _sucursalRepository = sucursalRepository;
        }

        // GET: sucursales/SelectSucursales
        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<SelectResponse>>> SelectSucursales()
        {
            var response = await _sucursalRepository.SelectSucursales();
            return Ok(response);
        }
    }
}
