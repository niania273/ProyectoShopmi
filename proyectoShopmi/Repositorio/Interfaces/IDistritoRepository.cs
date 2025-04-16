using proyectoShopmi.Models.Response;

namespace proyectoShopmi.Repositorio.Interfaces
{
    public interface IDistritoRepository
    {
        Task<IEnumerable<SelectResponse>> SelectDistritos();
    }
}
