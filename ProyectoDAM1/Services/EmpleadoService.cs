using ProyectoDAM1.Models;
using ProyectoDAM1.Repositories;

namespace ProyectoDAM1.Services
{
    public class EmpleadoService : IEmpleadoRepository
    {
        public Task<Empleado> GetEmpleadoById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Empleado>> GetEmpleados()
        {
            throw new NotImplementedException();
        }

        public Task<Empleado> UpdateEmpleado(int id, Empleado empleado)
        {
            throw new NotImplementedException();
        }
    }
}
