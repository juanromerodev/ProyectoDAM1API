using System;
using System.Collections.Generic;

namespace ProyectoDAM1.Models
{
    public partial class CategoriaBebidum
    {
        public CategoriaBebidum()
        {
            Bebida = new HashSet<Bebidum>();
        }

        public int IdCategoriaBebida { get; set; }
        public string DesCategoria { get; set; } = null!;

        public virtual ICollection<Bebidum> Bebida { get; set; }
    }
}
