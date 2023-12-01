using ProyectoDAM1.Models;
using ProyectoDAM1.Repositories;

namespace ProyectoDAM1.Services
{
    public class PedidoService : IPedidoRepository
    {
        public Task<Pedido> CreatePedido(Pedido pedido)
        {
            throw new NotImplementedException();
        }

        public Task<Pedido> GetPedidoById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Pedido>> GetPedidos()
        {
            throw new NotImplementedException();
        }
    }
}
