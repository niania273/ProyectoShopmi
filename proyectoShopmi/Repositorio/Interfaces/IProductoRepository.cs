using proyectoShopmi.Models.Request;
using proyectoShopmi.Models.Response;

namespace proyectoShopmi.Repositorio.Interfaces
{
    public interface IProductoRepository
    {
        Task<IEnumerable<ProductoResponse>> GetProductos();
        Task<IEnumerable<ProductoResponse>> GetProductosPorCategoria(int codCategoria);
        Task<ProductoResponse> GetProducto(int codProducto);
        Task<string> MergeProducto(ProductoRequest producto, string accion);
        Task<string> DeleteProducto(int codProducto);
    }
}
