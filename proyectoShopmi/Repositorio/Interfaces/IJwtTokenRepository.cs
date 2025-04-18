using proyectoShopmi.Models;

namespace proyectoShopmi.Repositorio.Interfaces
{
    public interface IJwtTokenRepository
    {
        string GenerarToken(ApplicationUser user);
    }
}
