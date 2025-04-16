using Microsoft.AspNetCore.Mvc;
using proyectoShopmi.Models.Response;
using proyectoShopmi.Repositorio.Interfaces;

namespace proyectoShopmi.Controllers
{
    [Route("roles/")]
    [ApiController]
    public class RolController : ControllerBase
    {
        private readonly IRolRepository _rolRepository;

        public RolController(IRolRepository rolRepository)
        {
            _rolRepository = rolRepository;
        }

        // GET: roles/SelectRoles
        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<SelectResponse>>> SelectRoles()
        {
            var response = await _rolRepository.SelectRoles();
            return Ok(response);
        }
    }
}
