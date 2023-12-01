using ProyectoDAM1.Models;
using ProyectoDAM1.Repositories;

namespace ProyectoDAM1.Services
{
    public class UsuarioService : IUsuarioRepository
    {
        public Task<Usuario> GetUsuarioById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Usuario>> GetUsuarios()
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> UpdateUsuario(int id, Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
