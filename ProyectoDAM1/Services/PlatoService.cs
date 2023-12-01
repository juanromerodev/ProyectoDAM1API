using Microsoft.EntityFrameworkCore;
using ProyectoDAM1.Models;
using ProyectoDAM1.Repositories;

namespace ProyectoDAM1.Services
{
    public class PlatoService : IPlatoRepository
    {
        private readonly RestobarCandelabroDBContext dbContext;
        public PlatoService(RestobarCandelabroDBContext dbContext)
        {
            //por inyeccion de dependencia se instancia la clase(crear el objeto)
            this.dbContext = dbContext;
        }

        public async Task<Plato> GetPlatoById(int id)
        {
            return await dbContext.Platos.FindAsync(id);
        }

        public async Task<IEnumerable<Plato>> GetPlatos()
        {
            return await dbContext.Platos.ToListAsync();
        }

        public async Task<IEnumerable<Plato>> GetPlatosXCategoria(int idCategory)
        {
            return await dbContext.Platos.Where(p => p.CategoriaPlatoId == idCategory).ToListAsync();
        }

        public async Task<Plato> UpdatePlato(int id, Plato plato)
        {
            var existingPlato = await dbContext.Platos.FindAsync(id);
            if (existingPlato != null)
            {
                existingPlato.DetallePlato = plato.DetallePlato;
                existingPlato.DescripcionPlato = plato.DescripcionPlato;
                existingPlato.ImagenUrl = plato.ImagenUrl;
                existingPlato.IdProducto = plato.IdProducto;
                existingPlato.CategoriaPlatoId = plato.CategoriaPlatoId;

                await dbContext.SaveChangesAsync();
            }
            return existingPlato;
        }
    }
}
