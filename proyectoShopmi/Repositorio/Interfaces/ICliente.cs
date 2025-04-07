using proyectoShopmi.Models;

namespace proyectoShopmi.Repositorio.Interfaces
{
    public interface ICliente
    {
        IEnumerable<Cliente> getClientes();

        Task<Cliente> getCliente(int codCliente);
        Task<string> insertCliente(Cliente cliente);
        Task<string> updateCliente(Cliente cliente);

    }
}
