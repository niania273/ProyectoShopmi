using proyectoShopmi.Models;

namespace proyectoShopmi.Repositorio.Interfaces
{
    public interface IProducto
    {
        Task<IEnumerable<Producto>> GetProductos();

        Task<Producto> GetProducto(int codProducto);

        Task<string> MergeProducto(Producto producto);

        Task<string> DeleteProducto(int codProducto);
    }
}
