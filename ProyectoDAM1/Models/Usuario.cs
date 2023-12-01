using System;
using System.Collections.Generic;

namespace ProyectoDAM1.Models
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        public int IdEmpleado { get; set; }
        public string Correo { get; set; } = null!;
        public string Contrasenia { get; set; } = null!;
        public string ImagenUrl { get; set; } = null!;

        public virtual Empleado IdEmpleadoNavigation { get; set; } = null!;
    }
}
