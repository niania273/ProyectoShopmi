using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using proyectoShopmi.Models;
using proyectoShopmi.Models.Request;
using proyectoShopmi.Repositorio;
using proyectoShopmi.Repositorio.Interfaces;

namespace proyectoShopmi.Controllers
{
    [Route("inicio/")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IJwtTokenRepository _jwtTokenRepository;

        public AuthController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            RoleManager<IdentityRole<int>> roleManager,
            IJwtTokenRepository jwtTokenRepository
            )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _jwtTokenRepository = jwtTokenRepository;
        }

        [HttpPost("registrarse")]
        public async Task<IActionResult> Register([FromBody] UsuarioRequestRegistro reg)
        {
            var user = new ApplicationUser
            {
                UserName = reg.Correo,
                Email = reg.Correo,

                NumeroDocumento = reg.NumeroDocumento,
                Apellido = reg.Apellido,
                Nombre = reg.Nombre,
                Contrasenia = reg.Contrasenia,
                FechaNacimiento = reg.FechaNacimiento,
                Sexo = reg.Sexo,
                Telefono = reg.Telefono,
                Estado = true,
            };

            var result = await _userManager.CreateAsync(user);

            if (!result.Succeeded)
                return BadRequest(result.Errors);

            return Ok(new { mensaje = "Usuario registrado correctamente." });
        }

        [HttpPost("iniciarsesion")]
        public async Task<IActionResult> Login([FromBody] UsuarioRequestLogin reg)
        {
            var user = await _userManager.FindByNameAsync(reg.Correo);
            if (user == null)
                return Unauthorized("Usuario no encontrado.");

            var result = await _signInManager.CheckPasswordSignInAsync(user, reg.Contrasenia, false);

            if (!result.Succeeded)
                return Unauthorized("Contraseña incorrecta.");

            var token = _jwtTokenRepository.GenerarToken(user);

            return Ok(new
            {
                token = token,
                usuario = user
            });
        }
    }
}
