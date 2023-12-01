using System;
using System.Collections.Generic;

namespace ProyectoDAM1.Models
{
    public partial class CategoriaPlato
    {
        public CategoriaPlato()
        {
            Platos = new HashSet<Plato>();
        }

        public int IdCategoriaPlato { get; set; }
        public string DesCategoria { get; set; } = null!;

        public virtual ICollection<Plato> Platos { get; set; }
    }
}
