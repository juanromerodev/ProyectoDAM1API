using ProyectoDAM1.Models;

namespace ProyectoDAM1.Repositories
{
    public interface IEmpleadoRepository
    {
        Task<IEnumerable<Empleado>> GetEmpleados();
        Task<Empleado> GetEmpleadoById(int id);
        Task<Empleado> UpdateEmpleado(int id, Empleado empleado);
    }
}
