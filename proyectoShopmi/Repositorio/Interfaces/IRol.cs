using proyectoShopmi.Models;

namespace proyectoShopmi.Repositorio.Interfaces
{
    public interface IRol
    {
        Task<IEnumerable<Rol>> GetRoles();
    }
}
