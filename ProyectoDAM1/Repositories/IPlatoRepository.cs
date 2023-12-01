using ProyectoDAM1.Models;

namespace ProyectoDAM1.Repositories
{
    public interface IPlatoRepository
    {
        Task<IEnumerable<Plato>> GetPlatos();
        Task<IEnumerable<Plato>> GetPlatosXCategoria(int idCategory);
        Task<Plato> GetPlatoById(int id);
        Task<Plato> UpdatePlato(int id, Plato plato);
    }
}
