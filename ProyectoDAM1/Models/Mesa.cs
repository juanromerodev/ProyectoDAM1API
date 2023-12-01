using System;
using System.Collections.Generic;

namespace ProyectoDAM1.Models
{
    public partial class Mesa
    {
        public Mesa()
        {
            Pedidos = new HashSet<Pedido>();
        }

        public int NumMesa { get; set; }
        public string Estado { get; set; } = null!;

        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
