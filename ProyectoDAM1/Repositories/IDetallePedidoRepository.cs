using ProyectoDAM1.Models;

namespace ProyectoDAM1.Repositories
{
    public interface IDetallePedidoRepository
    {
        Task<IEnumerable<DetallePedido>> GetDetallesPedidoGeneral();
        Task<IEnumerable<DetallePedido>> GetDetallesXPedido(Pedido pedido);
        Task<DetallePedido> GetDetallePedidoById(int id);
        public Task<DetallePedido> CreateDetallePedido(DetallePedido detpedido);
    }
}
