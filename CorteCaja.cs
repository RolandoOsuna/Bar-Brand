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
using System.Drawing.Printing;
//using System.Globalization.Calendar;

namespace WTFBarber
{
    public partial class CorteCaja : Form
    {
        int Productos, Comisiones, TotalVentas, Ganancia;
        string fecha;
        public Image logo { get; set; }

        public CorteCaja()
        {
            InitializeComponent();
        }
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {

        }
        private void CorteCaja_Load(object sender, EventArgs e)
        {
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "dd/MM/yyyy";
            string mifecha;
            dtp.Value = Convert.ToDateTime(mifecha = DateTime.Today.ToString());
        }

        private void btn_Aceptar_Click_1(object sender, EventArgs e)
        {
            using var db = new wtfbarberContext.wtfbarberContext();
            wtfbarberContext.Cortecaja cortecaja = new wtfbarberContext.Cortecaja()
            {
                TotalVentasCorte = Convert.ToInt32(txt_TotalVentas.Text),
                ComisionesTotalCorte = Convert.ToInt32(txt_Comisiones.Text),
                GananciaCorte = Convert.ToInt32(txt_Ganancia.Text),
                ProductosVendidosCorte = Convert.ToInt32(txt_ProductosVendidos.Text),
                FechaCorte = DateTime.Now
            };
            //VALIDACIÓN COMPLETAR CAMPOS
            if (txt_Ganancia.Text == "" || txt_Comisiones.Text == "" || txt_ProductosVendidos.Text == "" || txt_TotalVentas.Text == "")
            {
                MessageBox.Show("Completa todos los campos");
            }
            else
            {
                db.Add(cortecaja);
                db.SaveChanges();
                MessageBox.Show("Corte realizado satisfactoriamente");
                limpiarTextbox();
            }

        }



        private void btn_MostrarDatos_Click(object sender, EventArgs e)
        {
                mostrarDatos();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            //VALIDACION BOTON CANCELAR
            if (txt_Ganancia.Text == "" && txt_ProductosVendidos.Text == "" && txt_TotalVentas.Text == "" && txt_Comisiones.Text == "")
            { }
            else if (MessageBox.Show("¿Cancelar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                limpiarTextbox();
            }
        }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            //IMPRECION DE TICKET
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += printDocument1_PrintPage;
            logo = pictureBox1.Image;
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Rockwell", 14);
            int x = 10;
            int y = 10;

            e.Graphics.DrawImage(logo, 15, 20, 150, 100);
            y += 110;
            e.Graphics.DrawString("Plaza Andanza, Local #20.", font, Brushes.Black, x, y);
            y += 20;
            e.Graphics.DrawString("6692175015", font, Brushes.Black, x, y);
            y += 20;
            e.Graphics.DrawString(dtp.Text, font, Brushes.Black, x, y);
            y += 30;
            e.Graphics.DrawString("--- CORTE DE CAJA ---", font, Brushes.Black, x, y);
            y += 30;
            e.Graphics.DrawString("Productos Vendidos: " + Productos, font, Brushes.Black, x, y);
            y += 20;
            e.Graphics.DrawString("Comisiones: $" + Comisiones, font, Brushes.Black, x, y);
            y += 20;
            e.Graphics.DrawString("Total de Ventas: $" + TotalVentas, font, Brushes.Black, x, y);
            y += 35;
            e.Graphics.DrawString("Ganancia: $" + Ganancia, font, Brushes.Black, x, y);
        }
        public void consultas()
        {
            using (var consulta = new wtfbarberContext.wtfbarberContext())
            {
                fecha = dtp.Text;
            }
        }

        private void mostrarDatos()
        {
            using (var consultas = new wtfbarberContext.wtfbarberContext())
            {
                Productos = Convert.ToInt32((from C in consultas.Ventas
                                             where C.FechaVenta >= dtp.Value
                                             select C.ProductoVenta).Count().ToString());
                Comisiones = Convert.ToInt32((from C in consultas.Ventas
                                              where C.FechaVenta >= dtp.Value
                                              select C.TotalComisionVenta).Sum().ToString());
                TotalVentas = Convert.ToInt32((from C in consultas.Ventas
                                               where C.FechaVenta >= dtp.Value
                                               select C.TotalFinalVenta).Sum().ToString());
                dgv.DataSource = (from Venta in consultas.Ventas
                                  where Venta.FechaVenta >= dtp.Value
                                  select new
                                  {
                                      Producto = Venta.ProductoVenta,
                                      Empleado = Venta.EmpleadoVenta,
                                      Comision = Venta.TotalComisionVenta,
                                      Venta = Venta.TotalFinalVenta,
                                      Fecha = Venta.FechaVenta
                                  }).ToList();
            }

            Ganancia = TotalVentas - Comisiones;

            txt_ProductosVendidos.Text = Productos.ToString();
            txt_Comisiones.Text = Comisiones.ToString();
            txt_TotalVentas.Text = TotalVentas.ToString();
            txt_Ganancia.Text = Ganancia.ToString();
        }


        public void limpiarTextbox()
        {
            dgv.Columns.Clear();
            txt_Ganancia.Clear();
            txt_TotalVentas.Clear();
            txt_ProductosVendidos.Clear();
            txt_Comisiones.Clear();
        }

        private void txt_Fondo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //VALIDACION SOLO NÚMEROS
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }


    }
}
