using proyectoShopmi.Models;

namespace proyectoShopmi.Repositorio.Interfaces
{
    public interface IPedidoRepository
    {
        Task<IEnumerable<PedidoRequest>> GetPedidos();

        Task<PedidoRequest> GetPedido(int codPedido);
        Task<int> InsertPedido(PedidoRequest pedido);

        Task<int> UpdatePedidoPrecio(PedidoRequest pedido);
        Task<string> DeletePedido(int codPedido);
    }
}
