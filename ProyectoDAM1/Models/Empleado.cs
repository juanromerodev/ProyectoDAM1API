using System;
using System.Collections.Generic;

namespace ProyectoDAM1.Models
{
    public partial class Empleado
    {
        public Empleado()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int IdEmpleado { get; set; }
        public string Nombres { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public string Cargo { get; set; } = null!;
        public string Dni { get; set; } = null!;

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
