using proyectoShopmi.Models.Response;

namespace proyectoShopmi.Repositorio.Interfaces
{
    public interface IMarcaRepository
    {
        Task<IEnumerable<MarcaResponse>> GetMarcas();
        Task<IEnumerable<SelectResponse>> SelectMarcas();
        Task<MarcaResponse> GetMarca(int codMarca);
        Task<string> MergeMarca(MarcaResponse marca, string accion);
        Task<string> DeleteMarca(int codMarca);

    }
}
