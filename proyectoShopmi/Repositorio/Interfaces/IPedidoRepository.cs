using proyectoShopmi.Models;

namespace proyectoShopmi.Repositorio.Interfaces
{
    public interface IPedidoRepository
    {
        Task<IEnumerable<Pedido>> GetPedidos();

        Task<Pedido> GetPedido(int codPedido);
        Task<string> MergePedido(Pedido pedido);
        Task<string> DeletePedido(int codPedido);
    }
}
