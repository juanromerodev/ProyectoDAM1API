using System;
using System.Collections.Generic;

namespace ProyectoDAM1.Models
{
    public partial class Bebidum
    {
        public int IdBebida { get; set; }
        public string DetalleBebida { get; set; } = null!;
        public string DescripcionBebida { get; set; } = null!;
        public string ImagenUrl { get; set; } = null!;
        public int IdProducto { get; set; }
        public int CategoriaBebidaId { get; set; }

        public virtual CategoriaBebidum CategoriaBebida { get; set; } = null!;
        public virtual Producto IdProductoNavigation { get; set; } = null!;
    }
}
