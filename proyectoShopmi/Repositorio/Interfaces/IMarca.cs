using proyectoShopmi.Models;

namespace proyectoShopmi.Repositorio.Interfaces
{
    public interface IMarca
    {
        Task<Marca> GetMarca(int codMarca);

        Task<string> insertMarca(Marca marca);

        Task<string> updateMarca(Marca marca);

    }
}
