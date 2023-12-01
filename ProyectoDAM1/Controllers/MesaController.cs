using Microsoft.AspNetCore.Mvc;
using ProyectoDAM1.Models;
using ProyectoDAM1.Repositories;

namespace ProyectoDAM1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MesaController : ControllerBase
    {
        private readonly IMesaRepository mesaRepository;
        public MesaController(IMesaRepository mesaRepository) { 
            this.mesaRepository = mesaRepository; 
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mesa>>> GetMesas()
        {
            return StatusCode(StatusCodes.Status200OK, await mesaRepository.GetMesas());
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Mesa>> GetMesaById(int id)
        {
            return StatusCode(StatusCodes.Status200OK, await mesaRepository.GetMesaById(id));
        }

        [HttpPut]
        [Route("modificar/{id}")]
        public async Task<ActionResult<Mesa>> UpdateMesa(int id, Mesa mesa)
        {
            return StatusCode(StatusCodes.Status200OK,
                await mesaRepository.UpdateMesa(id, mesa));
            
        }

    }
}
