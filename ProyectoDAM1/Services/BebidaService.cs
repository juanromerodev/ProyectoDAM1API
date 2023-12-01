using ProyectoDAM1.Models;
using ProyectoDAM1.Repositories;

namespace ProyectoDAM1.Services
{
    public class BebidaService : IBebidaRepository
    {
        private readonly RestobarCandelabroDBContext dbContext;
        public BebidaService(RestobarCandelabroDBContext dbContext)
        {
            //por inyeccion de dependencia se instancia la clase(crear el objeto)
            this.dbContext = dbContext;
        }
        public async Task<Bebidum> GetBebidaById(int id)
        {
            return await dbContext.Bebida.FindAsync(id);
        }

        public async Task<IEnumerable<Bebidum>> GetBebidas()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Bebidum>> GetBebidasXCategoria(int idCategory)
        {
            throw new NotImplementedException();
        }

        public async Task<Bebidum> UpdateBebida(int id, Plato mesa)
        {
            throw new NotImplementedException();
        }
    }
}
