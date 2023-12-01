using Microsoft.AspNetCore.Mvc;
using ProyectoDAM1.Repositories;

namespace ProyectoDAM1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlatoController: ControllerBase
    {
        private readonly IPlatoRepository platoRepository;
        public PlatoController(IPlatoRepository platoRepository)
        {
            this.platoRepository = platoRepository;
        }
    }
}
