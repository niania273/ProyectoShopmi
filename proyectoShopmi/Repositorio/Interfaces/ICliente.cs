using proyectoShopmi.Models;

namespace proyectoShopmi.Repositorio.Interfaces
{
    public interface ICliente
    {
        Task<IEnumerable<Cliente>> GetClientes();
        Task<Cliente> GetCliente(int codCliente);
        Task<string> MergeCliente(Cliente cliente);
        Task<string> DeleteCliente(int codCliente);
    }
}
