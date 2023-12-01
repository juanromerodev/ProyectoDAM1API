using ProyectoDAM1.Models;
using ProyectoDAM1.Repositories;

namespace ProyectoDAM1.Services
{
    public class DetallePedidoService : IDetallePedidoRepository
    {
        public Task<DetallePedido> CreateDetallePedido(DetallePedido detpedido)
        {
            throw new NotImplementedException();
        }

        public Task<DetallePedido> GetDetallePedidoById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DetallePedido>> GetDetallesPedidoGeneral()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DetallePedido>> GetDetallesXPedido(Pedido pedido)
        {
            throw new NotImplementedException();
        }
    }
}
