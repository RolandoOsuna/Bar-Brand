using System;
using System.Collections.Generic;

#nullable disable

namespace WTFBarber.wtfbarberContext
{
    public partial class Cortecaja
    {
        public int IdCorte { get; set; }
        public int TotalVentasCorte { get; set; }
        public int ComisionesTotalCorte { get; set; }
        public int GananciaCorte { get; set; }
        public int ProductosVendidosCorte { get; set; }
        public DateTime FechaCorte { get; set; }
    }
}
