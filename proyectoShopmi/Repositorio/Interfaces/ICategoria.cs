using proyectoShopmi.Models;

namespace proyectoShopmi.Repositorio.Interfaces
{
    public interface ICategoria
    {
        Task<Categoria> getCategoria(int codcategoria);
        Task<string> insertCategoria(Categoria categoria);
        Task<string> updateCategoria(Categoria categoria);

    }
}

