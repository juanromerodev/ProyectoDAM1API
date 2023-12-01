using ProyectoDAM1.Models;

namespace ProyectoDAM1.Repositories
{
    public interface IMesaRepository
    {
        Task<IEnumerable<Mesa>> GetMesas();
        Task<Mesa> GetMesaById(int id);
        Task<Mesa> UpdateMesa(int id, Mesa mesa);
    }
}
