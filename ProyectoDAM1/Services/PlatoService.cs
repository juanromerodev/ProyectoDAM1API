using ProyectoDAM1.Models;
using ProyectoDAM1.Repositories;

namespace ProyectoDAM1.Services
{
    public class PlatoService : IPlatoRepository
    {
        public Task<Plato> GetPlatoById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Plato>> GetPlatos()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Plato>> GetPlatosXCategoria(int idCategory)
        {
            throw new NotImplementedException();
        }

        public Task<Plato> UpdatePlato(int id, Plato plato)
        {
            throw new NotImplementedException();
        }
    }
}
