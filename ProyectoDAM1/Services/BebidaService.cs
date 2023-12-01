using Microsoft.EntityFrameworkCore;
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
            return await dbContext.Bebida.ToListAsync();
        }

        public async Task<IEnumerable<Bebidum>> GetBebidasXCategoria(int idCategory)
        {
            return await dbContext.Bebida.Where(p => p.CategoriaBebidaId == idCategory).ToListAsync();
        }

        public async Task<Bebidum> UpdateBebida(int id, Bebidum bebida)
        {
            var existingBebida = await dbContext.Bebida.FindAsync(id);
            if (existingBebida != null)
            {   
                existingBebida.DetalleBebida = bebida.DetalleBebida;
                existingBebida.DescripcionBebida = bebida.DescripcionBebida;
                existingBebida.ImagenUrl = bebida.ImagenUrl;
                existingBebida.IdProducto = bebida.IdProducto;
                existingBebida.CategoriaBebidaId = bebida.CategoriaBebidaId;

                await dbContext.SaveChangesAsync();
            }
            return existingBebida;
        }

    }
}
