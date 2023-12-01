using Microsoft.AspNetCore.Mvc;
using ProyectoDAM1.Repositories;

namespace ProyectoDAM1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DetallePedidoController: ControllerBase
    {
        private readonly IDetallePedidoRepository detallePedidoRepository;
        public DetallePedidoController(IDetallePedidoRepository detallePedidoRepository)
        {
            this.detallePedidoRepository = detallePedidoRepository;
        }
    }
}
