using Microsoft.AspNetCore.Mvc;
using ProyectoDAM1.Models;
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

        [HttpGet]
        public async Task<IActionResult> GetPlatos()
        {
            var platos = await platoRepository.GetPlatos();
            return Ok(platos);
        }

        [HttpGet("categoria/{idCategory}")]
        public async Task<IActionResult> GetPlatosXCategoria(int idCategory)
        {
            var platos = await platoRepository.GetPlatosXCategoria(idCategory);
            return Ok(platos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPlatoById(int id)
        {
            var plato = await platoRepository.GetPlatoById(id);
            if (plato == null)
            {
                return NotFound();
            }
            return Ok(plato);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePlato(int id, Plato plato)
        {
            var updatedPlato = await platoRepository.UpdatePlato(id, plato);
            if (updatedPlato == null)
            {
                return NotFound();
            }
            return Ok(updatedPlato);
        }
    }
}
