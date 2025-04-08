using proyectoShopmi.Models;

namespace proyectoShopmi.Repositorio.Interfaces
{
    public interface IPedido
    {
        Task<Pedido> getPedido(int codPedido);
        Task<string> insertPedido(Pedido pedido);
        Task<string> updatePedido(Pedido pedido);
    }
}
