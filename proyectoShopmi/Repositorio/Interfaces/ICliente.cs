using proyectoShopmi.Models;

namespace proyectoShopmi.Repositorio.Interfaces
{
    public interface ICliente
    {
        Task<Cliente> getCliente(int codCliente);
        Task<string> insertCliente(Cliente cliente);
        Task<string> updateCliente(Cliente cliente);
    }
}
