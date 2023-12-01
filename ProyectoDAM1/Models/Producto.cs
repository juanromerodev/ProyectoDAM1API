using System;
using System.Collections.Generic;

namespace ProyectoDAM1.Models
{
    public partial class Producto
    {
        public Producto()
        {
            Bebida = new HashSet<Bebidum>();
            DetallePedidos = new HashSet<DetallePedido>();
            Platos = new HashSet<Plato>();
        }

        public int IdProducto { get; set; }
        public decimal PrecioUnit { get; set; }

        public virtual ICollection<Bebidum> Bebida { get; set; }
        public virtual ICollection<DetallePedido> DetallePedidos { get; set; }
        public virtual ICollection<Plato> Platos { get; set; }
    }
}
