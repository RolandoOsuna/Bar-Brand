using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WTFBarber;
using WTFBarber.wtfbarberContext;


namespace WTFBarber
{
    public partial class Catalogo_Gastos : Form
    {
        Gasto gasto = new Gasto();

        public int? id;

        public Catalogo_Gastos()
        {
            InitializeComponent();
        }

        private void Catalogo_Gastos_Load(object sender, EventArgs e)
        {
            string mifecha;
            dtp_CatalogoGastosDesde.Format = DateTimePickerFormat.Custom;
            dtp_CatalogoGastosDesde.CustomFormat = "dd/MM/yyyy";
            dtp_CatalogoGastosDesde.Value = Convert.ToDateTime(mifecha = DateTime.Today.ToString());
            dtp_CatalogoGastosHasta.Format = DateTimePickerFormat.Custom;
            dtp_CatalogoGastosHasta.CustomFormat = "dd/MM/yyyy";
            dtp_CatalogoGastosHasta.Value = Convert.ToDateTime(mifecha = DateTime.Now.ToString());
            //btn_Modificar.Visible = false;

            Ocultartxt();
            MostrarDatos();
        }


        public void MostrarDatos()
        {
            using (var db = new wtfbarberContext.wtfbarberContext())
            {
                var lts = from d in db.Gastos
                          select d;
                dgv_CatalogoGastos.DataSource = lts.ToList();
            }
        }
        //BTN MOSTRAR DATOS
        private void btn_MostrarDatos_Click(object sender, EventArgs e)
        {
            using var db = new wtfbarberContext.wtfbarberContext();
            dgv_CatalogoGastos.DataSource = (from Gasto in db.Gastos
                                             where Gasto.FechaGasto >= dtp_CatalogoGastosDesde.Value && Gasto.FechaGasto <= dtp_CatalogoGastosHasta.Value
                                             select new
                                             {
                                                 Id = Gasto.IdGasto,
                                                 Nombre = Gasto.NombreGasto,
                                                 Descripcion = Gasto.DescripcionGasto,
                                                 Cantidad = Gasto.CantidadGasto,
                                                 Fecha = Gasto.FechaGasto
                                             }).ToList();
        }
        private int? GetId()
        {
            try
            {
                return int.Parse(dgv_CatalogoGastos.Rows[dgv_CatalogoGastos.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        
        //BTN MODIFICAR
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                Mostrartxt();
                CargarDatos();
                btn_Guardar.Visible = true;
                btn_CancelarModificacion.Visible = true;

            }
        }
        //BTN CANCELAR
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Eliminar Gastos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int? id = GetId();
                if (id != null)
                {
                    using (var db = new wtfbarberContext.wtfbarberContext())
                    {
                        gasto = db.Gastos.Find(id);
                        db.Gastos.Remove(gasto);
                        db.SaveChanges();
                    }
                    MostrarDatos();
                }
            }
        }
        //BTN CANCELAR MODIFICACION
        private void btn_CancelarModificacion_Click(object sender, EventArgs e)
        {
            limpiarTextbox();
            Ocultartxt();
        }
        //BTN GUARDAR
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            //VALIDACION CAMPOS VACIOS
            if (txt_Nombre.Text == "" || txt_Cantidad.Text == "" || txt_Descripcion.Text == "")
            {
                MessageBox.Show("Completa todos los campos");
                return;
            }
            try
            {
                using (var db = new wtfbarberContext.wtfbarberContext())
                {
                    if (id == null)
                        gasto = new Gasto();
                    gasto.IdGasto = id.Value;

                    gasto.IdGasto = id.Value;
                    gasto.NombreGasto = txt_Nombre.Text.ToString();
                    gasto.DescripcionGasto = txt_Descripcion.Text.ToString();
                    gasto.CantidadGasto = float.Parse(txt_Cantidad.Text);
                    gasto.FechaGasto = DateTime.Now;

                    db.Gastos.Attach(gasto);
                    db.Entry(gasto).State = EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Modificado");
                    MostrarDatos();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //METODOS
        public void CargarDatos()
        {
            using (var db = new wtfbarberContext.wtfbarberContext())
            {
                var gasto = db.Gastos.Find(id = GetId());
                txt_Nombre.Text = gasto.NombreGasto.ToString();
                txt_Descripcion.Text = gasto.DescripcionGasto.ToString();
                txt_Cantidad.Text = gasto.CantidadGasto.ToString();
            }
        }
        public void Mostrartxt()
        {
            txt_Nombre.Visible = true;
            txt_Descripcion.Visible = true;
            txt_Cantidad.Visible = true;
            lbl_Nombre.Visible = true;
            lbl_Descripcion.Visible = true;
            lbl_Cantidad.Visible = true;
            btn_CancelarModificacion.Visible = true;
            btn_Guardar.Visible = true;
        }
        public void Ocultartxt()
        {
            txt_Nombre.Visible = false;
            txt_Descripcion.Visible = false;
            txt_Cantidad.Visible = false;
            lbl_Nombre.Visible = false;
            lbl_Descripcion.Visible = false;
            lbl_Cantidad.Visible = false;
            btn_CancelarModificacion.Visible = false;
            btn_Guardar.Visible = false;
        }
        public void limpiarTextbox()
        {
            txt_Nombre.Clear();
            txt_Descripcion.Clear();
            txt_Cantidad.Clear();
        }

        private void txt_Cantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
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
