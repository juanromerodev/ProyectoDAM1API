using Microsoft.AspNetCore.Mvc;
using ProyectoDAM1.Repositories;

namespace ProyectoDAM1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BebidaController: ControllerBase
    {
        private readonly IBebidaRepository bebidaRepository;
        public BebidaController(IBebidaRepository bebidaRepository)
        {
            this.bebidaRepository = bebidaRepository;
        }
    }
}
