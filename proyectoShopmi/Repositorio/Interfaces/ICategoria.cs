using proyectoShopmi.Models;

namespace proyectoShopmi.Repositorio.Interfaces
{
    public interface ICategoria
    {
        Task<IEnumerable<Categoria>> GetCategorias();

        Task<Categoria> GetCategoria(int codcategoria);

        Task<string> MergeCategoria(Categoria categoria);

        Task<string> DeleteCategoria(int codcategoria);

    }
}

