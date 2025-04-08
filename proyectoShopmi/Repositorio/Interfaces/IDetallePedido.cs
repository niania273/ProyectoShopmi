using proyectoShopmi.Models;

namespace proyectoShopmi.Repositorio.Interfaces
{
    public interface IDetallePedido
    {
        Task<DetallePedido> getDetallePedido(int codDetallePedido);
        Task<string> insertDetallePedido(DetallePedido detallePedido);
        Task<string> updateDetallePedido(DetallePedido detallePedido);

    }
}
