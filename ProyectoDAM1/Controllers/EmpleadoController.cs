using Microsoft.AspNetCore.Mvc;
using ProyectoDAM1.Repositories;

namespace ProyectoDAM1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmpleadoController: ControllerBase
    {
        private readonly IEmpleadoRepository empleadoRepository;
        public EmpleadoController(IEmpleadoRepository empleadoRepository)
        {
            this.empleadoRepository = empleadoRepository;
        }
    }
}
