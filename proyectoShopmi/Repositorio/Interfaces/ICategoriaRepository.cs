using proyectoShopmi.Models.Response;

namespace proyectoShopmi.Repositorio.Interfaces
{
    public interface ICategoriaRepository
    {
        Task<IEnumerable<CategoriaResponse>> GetCategorias();
        Task<IEnumerable<SelectResponse>> SelectCategorias();
        Task<CategoriaResponse> GetCategoria(int codcategoria);
        Task<string> MergeCategoria(CategoriaResponse categoria, string accion);
        Task<string> DeleteCategoria(int codcategoria);
    }
}

