using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WTFBarber.wtfbarberContext;
using System.Linq.Dynamic;

namespace WTFBarber
{
    public partial class Reportes : Form
    {
        int indice;
        public Reportes()
        {
            InitializeComponent();
        }


        private void Reportes_Load(object sender, EventArgs e)
        {
            lbl_Desde.Visible = false;
            lbl_Hasta.Visible = false;
            dtp_Desde.Visible = false;
            dtp_Hasta.Visible = false;
            string mifecha;
            dtp_Desde.Format = DateTimePickerFormat.Custom;
            dtp_Desde.CustomFormat = "dd/MM/yyyy";
            dtp_Desde.Value = Convert.ToDateTime(mifecha = DateTime.Today.ToString());
            dtp_Hasta.Format = DateTimePickerFormat.Custom;
            dtp_Hasta.CustomFormat = "dd/MM/yyyy";
            dtp_Hasta.Value = Convert.ToDateTime(mifecha = DateTime.Now.ToString());


        }
        private void cmb_TipoReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            using var db = new wtfbarberContext.wtfbarberContext();
            indice = cmb_TipoReporte.SelectedIndex;
        }
        private void btn_MostrarDatos_Click(object sender, EventArgs e)
        {
            using var db = new wtfbarberContext.wtfbarberContext();
            switch (indice)
            {
                case 0://REPORTE DETALLADO
                    dgv_Reportes.DataSource = (from Venta in db.Ventas 
                                               where Venta.FechaVenta >= dtp_Desde.Value && Venta.FechaVenta <= dtp_Hasta.Value
                                               select new
                                               {
                                                   Producto = Venta.ProductoVenta,
                                                   Empleado = Venta.EmpleadoVenta,
                                                   Comision = Venta.TotalComisionVenta,
                                                   Venta = Venta.TotalFinalVenta,
                                                   Fecha = Venta.FechaVenta 
                                               }).ToList();
                    //LBL VENTAS
                    var lblVenta = (from Venta in db.Ventas
                                    where Venta.FechaVenta >= dtp_Desde.Value && Venta.FechaVenta <= dtp_Hasta.Value
                                    select Venta.TotalFinalVenta).Sum().ToString();
                    lbl.Text = "La venta total es: \n$" + lblVenta;
                    lbl_Desde.Show();
                    lbl_Hasta.Show();
                    dtp_Desde.Visible = true;
                    dtp_Hasta.Visible = true;
                    break;
                case 1://REPORTE PRODUCTOS
                    dgv_Reportes.DataSource = (from Venta in db.Ventas 
                                               where Venta.FechaVenta >= dtp_Desde.Value && Venta.FechaVenta <= dtp_Hasta.Value
                                               group Venta by Venta.ProductoVenta into Total 
                                               select new
                                               {
                                                   Total = Total.Key,
                                                   TotalVentas = Total.Count(),
                                               }).ToList();
                    //LBL PRODUCTOS
                    var lblProductos = (from Venta in db.Ventas
                                        where Venta.FechaVenta >= dtp_Desde.Value && Venta.FechaVenta <= dtp_Hasta.Value
                                        select Venta.ProductoVenta).Count().ToString();
                    lbl.Text = "Las productos totales vendidos son: \n" + lblProductos;
                    lbl_Desde.Show();
                    lbl_Hasta.Show();
                    dtp_Desde.Visible = true;
                    dtp_Hasta.Visible = true;
                    break;
                case 2://REPORTE DE EMPLEADOS
                    dgv_Reportes.DataSource = (from Venta in db.Ventas
                                               group Venta by Venta.EmpleadoVenta into Total
                                               select new
                                               {
                                                   Total = Total.Key
                                               }).ToList();
                    lbl.Text = "";
                    lbl_Desde.Visible = false;
                    lbl_Hasta.Visible = false;
                    dtp_Desde.Visible = false;
                    dtp_Hasta.Visible = false;
                    break;
                case 3://REPORTE DE NOMINA
                    dgv_Reportes.DataSource = (from Nomina in db.Nominas
                                               where Nomina.FechaNomina >= dtp_Desde.Value && Nomina.FechaNomina <= dtp_Hasta.Value
                                               select new
                                               {
                                                   Comisiones = Nomina.TotalComisionNomina,
                                                   Nomina = Nomina.TotalNomina,
                                                   Fecha = Nomina.FechaNomina
                                               }).ToList();
                    //LBL NOMINA
                    var lblNomina = (from Nomina in db.Nominas select Nomina.TotalNomina).Sum().ToString();
                    lbl.Text = "La nomina total es: \n$" + lblNomina;
                    lbl_Desde.Show();
                    lbl_Hasta.Show();
                    dtp_Desde.Visible = true;
                    dtp_Hasta.Visible = true;
                    break;
                case 4://REPORTE DE COMISIONES 
                    dgv_Reportes.DataSource = (from Venta in db.Ventas
                                               where Venta.FechaVenta >= dtp_Desde.Value && Venta.FechaVenta <= dtp_Hasta.Value
                                               group Venta by Venta.EmpleadoVenta into Total
                                               select new
                                               {
                                                   Total = Total.Key,
                                                   TotalVentas = Total.Count(),
                                               }).ToList();
                    //LBL COMISIONES
                    var lblComision = (from Venta in db.Ventas
                                       where Venta.FechaVenta >= dtp_Desde.Value && Venta.FechaVenta <= dtp_Hasta.Value
                                       select Venta.TotalComisionVenta).Sum().ToString();
                    lbl.Text = "Las comisiones totales son: \n$" + lblComision;
                    lbl_Desde.Show();
                    lbl_Hasta.Show();
                    dtp_Desde.Visible = true;
                    dtp_Hasta.Visible = true;
                    break;
                case 5://REPORTE DE CORTE DE CAJA 
                    dgv_Reportes.DataSource = (from CorteCaja in db.Cortecajas
                                               where CorteCaja.FechaCorte >= dtp_Desde.Value && CorteCaja.FechaCorte <= dtp_Hasta.Value
                                               select new
                                               {
                                                   Productos = CorteCaja.ProductosVendidosCorte,
                                                   TotalVentas = CorteCaja.TotalVentasCorte,
                                                   Comisiones = CorteCaja.ComisionesTotalCorte,
                                                   Ganancia = CorteCaja.GananciaCorte,
                                                   Fecha = CorteCaja.FechaCorte
                                               }).ToList();
                    //LBL COMISIONES
                    var lblCorteCaja = (from CorteCaja in db.Cortecajas
                                        where CorteCaja.FechaCorte >= dtp_Desde.Value && CorteCaja.FechaCorte <= dtp_Hasta.Value
                                        select CorteCaja.GananciaCorte).Sum().ToString();
                    lbl.Text = "La ganancia total es: \n$" + lblCorteCaja;
                    lbl_Desde.Show();
                    lbl_Hasta.Show();
                    dtp_Desde.Visible = true;
                    dtp_Hasta.Visible = true;
                    break;
            }
        }
        private void btn_Generar_Click(object sender, EventArgs e)
        {
            ExportarDatos(dgv_Reportes);
        } 
        //EXPORTAR A EXCEL
        public void ExportarDatos(DataGridView datalistado)
        {
            Microsoft.Office.Interop.Excel.Application exportar = new Microsoft.Office.Interop.Excel.Application();
            exportar.Application.Workbooks.Add(true);

            int indiceColumna = 0;
            foreach(DataGridViewColumn columna in datalistado.Columns)
            {
                indiceColumna++;
                exportar.Cells[1, indiceColumna] = columna.Name;
            }
            
            int indiceFila = 0;
            foreach(DataGridViewRow fila in datalistado.Rows)
            {
                indiceFila++;
                indiceColumna = 0;
                foreach (DataGridViewColumn columna in datalistado.Columns)
                {
                    indiceColumna++;
                    exportar.Cells[indiceFila + 1, indiceColumna] = fila.Cells[columna.Name].Value;
                }
            }
            exportar.Visible = true;

        }
        


        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Cancelar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                limpiar();
            }
        }
        
       
        public void limpiar()
        {
            dgv_Reportes.Columns.Clear();
            cmb_TipoReporte.Text = "";
            lbl.Text = "";
            lbl_Desde.Visible = false;
            lbl_Hasta.Visible = false;
            dtp_Desde.Visible = false;
            dtp_Hasta.Visible = false;
        }



    }
}
