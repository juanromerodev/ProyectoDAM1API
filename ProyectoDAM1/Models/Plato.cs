using System;
using System.Collections.Generic;

namespace ProyectoDAM1.Models
{
    public partial class Plato
    {
        public int IdPlato { get; set; }
        public string DetallePlato { get; set; } = null!;
        public string DescripcionPlato { get; set; } = null!;
        public string ImagenUrl { get; set; } = null!;
        public int IdProducto { get; set; }
        public int CategoriaPlatoId { get; set; }

        public virtual CategoriaPlato CategoriaPlato { get; set; } = null!;
        public virtual Producto IdProductoNavigation { get; set; } = null!;
    }
}
