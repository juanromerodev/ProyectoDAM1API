using ProyectoDAM1.Models;

namespace ProyectoDAM1.Repositories
{
    public interface IPedidoRepository
    {
        Task<IEnumerable<Pedido>> GetPedidos();
        Task<Pedido> GetPedidoById(int id);
        Task<Pedido> CreatePedido(Pedido pedido);
    }
}
