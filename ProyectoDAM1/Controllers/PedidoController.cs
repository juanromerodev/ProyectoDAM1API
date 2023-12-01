using Microsoft.AspNetCore.Mvc;
using ProyectoDAM1.Repositories;

namespace ProyectoDAM1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidoController: ControllerBase
    {
        private readonly IPedidoRepository pedidoRepository;
        public PedidoController(IPedidoRepository pedidoRepository)
        {
            this.pedidoRepository = pedidoRepository;
        }
    }
}
