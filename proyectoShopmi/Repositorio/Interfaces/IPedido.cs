using proyectoShopmi.Models;

namespace proyectoShopmi.Repositorio.Interfaces
{
    public interface IPedido
    {
        Task<IEnumerable<Pedido>> GetPedidos();

        Task<Pedido> GetPedido(int codPedido);
        Task<string> MergePedido(Pedido pedido, string accion);
        Task<string> DeletePedido(int codPedido);
    }
}
