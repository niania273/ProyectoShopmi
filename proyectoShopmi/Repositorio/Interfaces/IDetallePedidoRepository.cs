using proyectoShopmi.Models;
using proyectoShopmi.Models.Request;

namespace proyectoShopmi.Repositorio.Interfaces
{
    public interface IDetallePedidoRepository
    {
        Task<DetallePedidoRequest> getDetallePedido(int codPedido, int codProducto);
        Task<int> insertDetallePedido(DetallePedidoRequest detallePedido);
        //Task<int> updateDetallePedido(DetallePedidoRequest detallePedido);
    }
}
