using proyectoShopmi.Models;

namespace proyectoShopmi.Repositorio.Interfaces
{
    public interface IMarca
    {
        Task<IEnumerable<Marca>> GetMarcas();
        Task<Marca> GetMarca(int codMarca);

        Task<string> MergeMarca(Marca marca);

        Task<string> DeleteMarca(int codMarca);

    }
}
