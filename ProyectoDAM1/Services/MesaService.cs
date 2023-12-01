using Microsoft.EntityFrameworkCore;
using ProyectoDAM1.Exceptions;
using ProyectoDAM1.Models;
using ProyectoDAM1.Repositories;

namespace ProyectoDAM1.Services
{
    public class MesaService : IMesaRepository
    {
        private readonly RestobarCandelabroDBContext dbContext;
        public MesaService(RestobarCandelabroDBContext dbContext)
        {
            //por inyeccion de dependencia se instancia la clase(crear el objeto)
            this.dbContext = dbContext;
        }


        //Obtener Customer a traves de su Id con Entity Frmwrk
        public async Task<Mesa> GetMesaById(int id)
        {
            var mesa = await dbContext.Mesas.Where(c => c.NumMesa == id).FirstOrDefaultAsync();
            if (mesa == null)
            {
                throw new NotFoundException($"Customer not found with id {id}");
            }
            return mesa;
        }

        //Listar Customers con Entity Frmwrk
        public async Task<IEnumerable<Mesa>> GetMesas()
        {
            return await dbContext.Mesas.ToListAsync();
        }

        //Actualizar Customer con Entity Frmwrk
        public async Task<Mesa> UpdateMesa(int id, Mesa mesa)
        {
            var mesa_a_cambiar = await dbContext.Mesas.Where(p => p.NumMesa == id).FirstOrDefaultAsync();
            if (mesa_a_cambiar == null)
            {
                throw new NotFoundException($"No se encontró un participante con la id {id}");
            }
            else
            {
                mesa.Estado = mesa_a_cambiar.Estado;
                dbContext.Mesas.Update(mesa_a_cambiar);
                await dbContext.SaveChangesAsync();
                return mesa;
            }
        }
    }
}

