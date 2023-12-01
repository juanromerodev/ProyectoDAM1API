using Microsoft.AspNetCore.Mvc;
using ProyectoDAM1.Models;
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
        [HttpGet]
        public async Task<IActionResult> GetPlatos()
        {
            var platos = await bebidaRepository.GetBebidas();
            return Ok(platos);
        }

        [HttpGet("categoria/{idCategory}")]
        public async Task<IActionResult> GetPlatosXCategoria(int idCategory)
        {
            var platos = await bebidaRepository.GetBebidasXCategoria(idCategory);
            return Ok(platos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBebidaById(int id)
        {
            var plato = await bebidaRepository.GetBebidaById(id);
            if (plato == null)
            {
                return NotFound();
            }
            return Ok(plato);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBebida(int id, Bebidum bebida)
        {
            var updatedBebida = await bebidaRepository.UpdateBebida(id, bebida);
            if (updatedBebida == null)
            {
                return NotFound();
            }
            return Ok(updatedBebida);
        }
    }
}
