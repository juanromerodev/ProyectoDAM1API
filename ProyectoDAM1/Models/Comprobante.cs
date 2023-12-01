using System;
using System.Collections.Generic;

namespace ProyectoDAM1.Models
{
    public partial class Comprobante
    {
        public int NumComprobante { get; set; }
        public int? IdPedido { get; set; }

        public virtual Pedido? IdPedidoNavigation { get; set; }
    }
}
