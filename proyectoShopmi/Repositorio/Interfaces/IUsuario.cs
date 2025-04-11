using proyectoShopmi.Models;

namespace proyectoShopmi.Repositorio.Interfaces
{
    public interface IUsuario
    {
        Task<IEnumerable<Usuario>> GetUsuarios();
        Task<Usuario> GetUsuario(int codUsu);
        Task<string> MergeUsuario(Usuario usuario, string accion);
    }
}
