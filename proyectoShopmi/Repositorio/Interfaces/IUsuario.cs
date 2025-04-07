using proyectoShopmi.Models;

namespace proyectoShopmi.Repositorio.Interfaces
{
    public interface IUsuario
    {
        Task<Usuario> getUsuario(int codUsu);
        Task<string> insertUsuario(Usuario usuario);
        Task<string> updateUsuario(Usuario usuario);
    }
}
