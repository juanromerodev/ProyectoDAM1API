using ProyectoDAM1.Models;
using ProyectoDAM1.Repositories;

namespace ProyectoDAM1.Services
{
    public class BebidaService : IBebidaRepository
    {
        public Task<Bebidum> GetBebidaById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Bebidum>> GetBebidas()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Bebidum>> GetBebidasXCategoria(int idCategory)
        {
            throw new NotImplementedException();
        }

        public Task<Bebidum> UpdateBebida(int id, Plato mesa)
        {
            throw new NotImplementedException();
        }
    }
}
