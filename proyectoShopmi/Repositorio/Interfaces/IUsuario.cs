using proyectoShopmi.Models;

namespace proyectoShopmi.Repositorio.Interfaces
{
    public interface IUsuario
    {
        Task<Usuario> GetUsuario(int codUsu);
        Task<string> MergeUsuario(Usuario usuario);
    }
}
