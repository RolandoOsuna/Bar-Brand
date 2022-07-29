using System;
using System.Collections.Generic;

#nullable disable

namespace WTFBarber.wtfbarberContext
{
    public partial class Cita
    {
        public int IdCita { get; set; }
        public string NombreCita { get; set; }
        public int TelefonoCita { get; set; }
        public DateTime FechaCita { get; set; }
    }
}
