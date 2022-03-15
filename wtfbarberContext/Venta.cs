using System;
using System.Collections.Generic;

#nullable disable

namespace WTFBarber.wtfbarberContext
{
    public partial class Venta
    {
        public int IdVentas { get; set; }
        public string EmpleadoVenta { get; set; }
        public string ProductoVenta { get; set; }
        public DateTime FechaVenta { get; set; }
        public double ComisionVenta { get; set; }
        public double TotalComisionVenta { get; set; }
        public double TotalFinalVenta { get; set; }
    }
}
