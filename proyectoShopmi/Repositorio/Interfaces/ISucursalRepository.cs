using proyectoShopmi.Models.Response;

namespace proyectoShopmi.Repositorio.Interfaces
{
    public interface ISucursalRepository
    {
        Task<IEnumerable<SelectResponse>> SelectSucursales();
    }
}
