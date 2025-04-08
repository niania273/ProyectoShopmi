using proyectoShopmi.Models;

namespace proyectoShopmi.Repositorio.Interfaces
{
    public interface IDistrito
    {
        Task<IEnumerable <Distrito>> getDistrito();
    }
}
