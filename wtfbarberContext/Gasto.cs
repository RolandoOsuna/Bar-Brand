using System;
using System.Collections.Generic;

#nullable disable

namespace WTFBarber.wtfbarberContext
{
    public partial class Gasto
    {
        public int IdGasto { get; set; }
        public string NombreGasto { get; set; }
        public string DescripcionGasto { get; set; }
        public float CantidadGasto { get; set; }
        public DateTime FechaGasto { get; set; }
    }
}
