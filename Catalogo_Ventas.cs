using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WTFBarber;
using WTFBarber.wtfbarberContext;
using System.Linq.Dynamic;
using Microsoft.EntityFrameworkCore;

namespace WTFBarber
{
    public partial class Catalogo_Ventas : Form
    {
        Cobro cobro = new Cobro();
        Venta venta = new Venta();

        public int Precio, numeroVenta;
        public double Comision;
        public int ComisionVenta = 0;
        public string fecha;
        public int? id;
        public Catalogo_Ventas()
        {
            InitializeComponent();
            //this.id = id;
            //if(id != null)
            //{
            //    CargarDatos(); 
            //}
        }
        private void Catalogo_Ventas_Load(object sender, EventArgs e)
        {
            string mifecha;
            dtp_CatalogoVentasDesde.Format = DateTimePickerFormat.Custom;
            dtp_CatalogoVentasDesde.CustomFormat = "dd/MM/yyyy";
            dtp_CatalogoVentasDesde.Value = Convert.ToDateTime(mifecha = DateTime.Today.ToString());
            dtp_CatalogoVentasHasta.Format = DateTimePickerFormat.Custom;
            dtp_CatalogoVentasHasta.CustomFormat = "dd/MM/yyyy";
            dtp_CatalogoVentasHasta.Value = Convert.ToDateTime(mifecha = DateTime.Now.ToString());
            //btn_Modificar.Visible = false;

            Ocultartxt();
            MostrarDatos();
        }
        //CANCELAR VENTA
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Cancelar Venta?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int? id = GetId();
                if (id != null)
                {
                    using (var db = new wtfbarberContext.wtfbarberContext())
                    {
                        venta = db.Ventas.Find(id);
                        db.Ventas.Remove(venta);
                        db.SaveChanges();
                    }
                    MostrarDatos();
                }
            }
        }

        private void dtp_CatalogoVentas_ValueChanged(object sender, EventArgs e)
        {

        }
        //BTN MOSTRAR DATOS
        private void btn_MostrarDatos_Click(object sender, EventArgs e)
        {
            using var db = new wtfbarberContext.wtfbarberContext();
            dgv_CatalogoVentas.DataSource = (from Venta in db.Ventas
                                       where Venta.FechaVenta >= dtp_CatalogoVentasDesde.Value && Venta.FechaVenta <= dtp_CatalogoVentasHasta.Value
                                             select new
                                       {
                                           Id = Venta.IdVentas, 
                                           Producto = Venta.ProductoVenta,
                                           Empleado = Venta.EmpleadoVenta,
                                           Comision = Venta.TotalComisionVenta,
                                           Venta = Venta.TotalFinalVenta,
                                           Fecha = Venta.FechaVenta
                                       }).ToList();
        }
        //BTN CANCELAR MODIFICACION
        private void btn_CancelarModificacion_Click(object sender, EventArgs e)
        {
            Ocultartxt();
        }
        //BTN GUARDAR
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                using(var db = new wtfbarberContext.wtfbarberContext())
                {
                    if(id == null)
                        venta = new Venta();
                    venta.IdVentas = id.Value;

                    venta.EmpleadoVenta = cmb_Empleado.SelectedItem.ToString();
                    venta.ProductoVenta = cmb_Producto.SelectedItem.ToString();
                    venta.TotalFinalVenta = double.Parse(txt_Precio.Text);
                    venta.ComisionVenta = ComisionVenta;
                    venta.TotalComisionVenta = double.Parse(txt_Comision.Text);
                    venta.FechaVenta = DateTime.Now;
                    
                    db.Ventas.Attach(venta);
                    db.Entry(venta).State = EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Modificado");
                    MostrarDatos();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
        //BTN MODIFICAR
        private int? GetId()
        {
            try
            {
                return int.Parse(dgv_CatalogoVentas.Rows[dgv_CatalogoVentas.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            
            int? id = GetId();
            if(id != null)
            {
                Mostrartxt();
                CargarDatos();
            }
        }

        private void cmb_Producto_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void cmb_Empleado_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void CargarDatos()
        {
            using(var db = new wtfbarberContext.wtfbarberContext())
            {
                var venta = db.Ventas.Find(id = GetId());
                cmb_Producto.SelectedItem = venta.ProductoVenta;
                cmb_Empleado.SelectedItem = venta.EmpleadoVenta;
                txt_Comision.Text = venta.TotalComisionVenta.ToString();
                txt_Precio.Text = venta.TotalFinalVenta.ToString();
            }                
        }
        public void MostrarDatos() {
            using (var db = new wtfbarberContext.wtfbarberContext())
            {
                var lts = from d in db.Ventas
                          select d;
                dgv_CatalogoVentas.DataSource = lts.ToList();
            }
        }
        public void Mostrartxt()
        {
            cmb_Empleado.Visible = true;
            cmb_Producto.Visible = true;
            txt_Comision.Visible = true;
            txt_Precio.Visible = true;
            lbl_Producto.Visible = true;
            lbl_Precio.Visible = true;
            lbl_Empleado.Visible = true;
            lbl_Comision.Visible = true;
            btn_CancelarModificacion.Visible = true;
            btn_Guardar.Visible = true;

        }

        

        public void Ocultartxt()
        {
            cmb_Empleado.Visible = false;
            cmb_Producto.Visible = false;
            txt_Comision.Visible = false;
            txt_Precio.Visible = false;
            lbl_Producto.Visible = false;
            lbl_Precio.Visible = false;
            lbl_Empleado.Visible = false;
            lbl_Comision.Visible = false;
            btn_CancelarModificacion.Visible = false;
            btn_Guardar.Visible = false;
        }
    }
}
