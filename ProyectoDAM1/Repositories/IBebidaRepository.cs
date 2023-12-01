using ProyectoDAM1.Models;

namespace ProyectoDAM1.Repositories
{
    public interface IBebidaRepository
    {
        Task<IEnumerable<Bebidum>> GetBebidas();
        Task<IEnumerable<Bebidum>> GetBebidasXCategoria(int idCategory);
        Task<Bebidum> GetBebidaById(int id);
        Task<Bebidum> UpdateBebida(int id, Bebidum bebida);
    }
}
