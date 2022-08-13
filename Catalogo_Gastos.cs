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

            //Ocultartxt();
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
    }
}
