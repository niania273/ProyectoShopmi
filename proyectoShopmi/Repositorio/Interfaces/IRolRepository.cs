using proyectoShopmi.Models.Response;

namespace proyectoShopmi.Repositorio.Interfaces
{
    public interface IRolRepository
    {
        Task<IEnumerable<SelectResponse>> SelectRoles();
    }
}
