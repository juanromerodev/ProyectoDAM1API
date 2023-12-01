using Microsoft.AspNetCore.Mvc;
using ProyectoDAM1.Repositories;

namespace ProyectoDAM1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController: ControllerBase
    {
        private readonly IUsuarioRepository usuarioRepository;
        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            this.usuarioRepository = usuarioRepository;
        }

    }
}
