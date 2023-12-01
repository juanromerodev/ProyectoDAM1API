using System;
using System.Collections.Generic;

namespace ProyectoDAM1.Models
{
    public partial class Pedido
    {
        public Pedido()
        {
            Comprobantes = new HashSet<Comprobante>();
            DetallePedidos = new HashSet<DetallePedido>();
        }

        public int IdPedido { get; set; }
        public decimal? Total { get; set; }
        public int? NumMesa { get; set; }

        public virtual Mesa? NumMesaNavigation { get; set; }
        public virtual ICollection<Comprobante> Comprobantes { get; set; }
        public virtual ICollection<DetallePedido> DetallePedidos { get; set; }
    }
}
