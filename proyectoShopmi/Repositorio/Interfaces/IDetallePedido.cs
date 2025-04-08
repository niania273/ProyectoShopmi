using proyectoShopmi.Models;

namespace proyectoShopmi.Repositorio.Interfaces
{
    public interface IDetallePedido
    {
        Task<DetallePedido> getDetallePedido(int codPedido, int codProducto);
        Task<string> insertDetallePedido(DetallePedido detallePedido);
        Task<string> updateDetallePedido(DetallePedido detallePedido);

    }
}
