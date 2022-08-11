using System;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing;
using System.Linq;
using System.Data;
using WTFBarber;
using WTFBarber.wtfbarberContext;

namespace WTFBarber
{
    public partial class Cobro : Form
    {
        public int Precio, numeroVenta;
        public double Comision;
        public int ComisionVenta = 0;
        public string fecha;
        public Image logo { get; set; }
        Cambio_Cobro CambioCobro = new Cambio_Cobro();
        public Cobro()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {

        }

        private void Cobro_Load(object sender, EventArgs e)
        {
            mostrarlbl();
        }
        public void btn_Cobrar_Click(object sender, EventArgs e)
        {
            //VALIDACION COMPLEATAR CAMPOS
            if (txt_Precio.Text == "" || cmb_Empleado.Text == "" || cmb_Producto.Text == "")
            {
                MessageBox.Show("Completa todos los campos alv");
                return;
            }
            //CAMBIO

                using (var db = new wtfbarberContext.wtfbarberContext())
                {
                    wtfbarberContext.Venta venta = new wtfbarberContext.Venta()
                    {
                        EmpleadoVenta = cmb_Empleado.SelectedItem.ToString(),
                     
                        ProductoVenta = cmb_Producto.SelectedItem.ToString(),
                        TotalFinalVenta = double.Parse(txt_Precio.Text),
                        ComisionVenta = ComisionVenta,
                        TotalComisionVenta = double.Parse(txt_Comision.Text),
                        FechaVenta = DateTime.Now,
                    };
                    db.Add(venta);
                    db.SaveChanges();
                    limpiarTextbox();
                    mostrarlbl();
                    //CambioCobro.Show();
                    MessageBox.Show("Venta realizada");
               

                }
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
            e.Graphics.DrawString(fecha, font, Brushes.Black, x, y);
            y += 30;
            e.Graphics.DrawString("Venta# " + numeroVenta, font, Brushes.Black, x, y);
            y += 20;
            e.Graphics.DrawString("Producto: " + cmb_Producto.SelectedItem, font, Brushes.Black, x, y);
            y += 20;
            e.Graphics.DrawString("Empleado: " + cmb_Empleado.SelectedItem, font, Brushes.Black, x, y);
            y += 35;
            e.Graphics.DrawString("Total: $" + Precio, font, Brushes.Black, x, y);
            y += 40;
            e.Graphics.DrawString("--- Gracias por Visitarnos ---", font, Brushes.Black, x, y);

        } 
        public void cmb_Producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cmb_Producto.SelectedIndex;
            txt_Comision.Clear();
            cmb_Empleado.Text = "";
            Precio = indice;
            switch (indice)
            {
                case 0:
                    Precio = 150;
                    break;
                case 1:
                    Precio = 120;
                    break;
                case 2:
                    Precio = 160;
                    break;
                case 3:
                    Precio = 140;
                    break;
                case 4:
                    Precio = 150;
                    break;
                case 5:
                    Precio = 100;
                    break;
                case 6:
                    Precio = 50;
                    break;
                case 7:
                    Precio = 50;
                    break;
                case 8:
                    Precio = 250;
                    break;
                case 9:
                    Precio = 150;
                    break;
                case 10:
                    Precio = 350;
                    break;
                case 11:
                    Precio = 450;
                    break;
            }
            txt_Precio.Text = Precio.ToString();
        }
        public void cmb_Empleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cmb_Empleado.SelectedIndex;

            if (indice == 0)
            {
                Comision = Precio * .50;
                ComisionVenta = 50;
            }
            else if (indice == 1 || indice == 2 || indice == 3)
            {
                Comision = Precio * .40;
                ComisionVenta = 40;

            }
            txt_Comision.Text = Comision.ToString();

        }

        private void btn_Cancelar_Click_1(object sender, EventArgs e)
        {
            //VALIDACIÓN DE BOTON CANCELAR
            if (txt_Precio.Text == "" && txt_Comision.Text == "" /*&& txt_Producto.Text == "" && txt_Empleado.Text == ""*/)
            { }
            else if (MessageBox.Show("¿Cancelar Venta?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                limpiarTextbox();
            }
        }
        public void limpiarTextbox()
        {
            lbl.Text = "";
            cmb_Producto.Text = "";
            txt_Precio.Clear();
            cmb_Empleado.Text = "";
            txt_Comision.Clear();
        }
        public void mostrarlbl()
        {
            using (var consulta = new wtfbarberContext.wtfbarberContext())
            {
                numeroVenta = Convert.ToInt32((from v in consulta.Ventas select v.IdVentas).Count().ToString());
                lbl.Text = "Venta Número: \n" + numeroVenta;
                fecha = DateTime.Now.ToString();

            }
        }
        private void txt_Precio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Precio_KeyPress(object sender, KeyPressEventArgs e)
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
