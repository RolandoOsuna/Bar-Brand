using System;
using System.Collections.Generic;

#nullable disable

namespace WTFBarber.wtfbarberContext
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string ContrasenaUsuario { get; set; }
        public DateTime FechaUsuario { get; set; }
        public string PrivilegioUsuario { get; set; }
    }
}
