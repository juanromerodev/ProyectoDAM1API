using ProyectoDAM1.Models;

namespace ProyectoDAM1.Repositories
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<Usuario>> GetUsuarios();
        Task<Usuario> GetUsuarioById(int id);
        Task<Usuario> UpdateUsuario(int id, Usuario usuario);
    }
}
