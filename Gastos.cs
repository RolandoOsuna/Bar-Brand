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

namespace WTFBarber
{
    public partial class Gastos : Form
    {
        public Gastos()
        {
            InitializeComponent();
        }

        private void Gastos_Load(object sender, EventArgs e)
        {

        }

        

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            //VALIDACION COMPLEATAR CAMPOS
            if (txt_Nombre.Text == "" || txt_Cantidad.Text == "" || txt_Descripcion.Text == "")
            {
                MessageBox.Show("Completa todos los campos");
                return;
            }
            using (var db = new wtfbarberContext.wtfbarberContext())
            {
                wtfbarberContext.Gasto gasto = new wtfbarberContext.Gasto()
                {
                    NombreGasto = txt_Nombre.Text,
                    CantidadGasto = int.Parse(txt_Cantidad.Text),
                    DescripcionGasto = txt_Descripcion.Text,
                    FechaGasto = DateTime.Now
                };
                db.Add(gasto);
                db.SaveChanges();
                MessageBox.Show(txt_Nombre.Text + " agregado a Gastos");
                limpiarTextbox();
            }
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            //VALIDACIÓN DE BOTON CANCELAR
            if (txt_Nombre.Text == "" && txt_Cantidad.Text == "" && txt_Descripcion.Text == "" )
            { }
            else if (MessageBox.Show("¿Cancelar Gasto?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                limpiarTextbox();
            }
        }
        public void limpiarTextbox()
        {
            txt_Nombre.Clear();
            txt_Cantidad.Clear();
            txt_Descripcion.Clear();
        }

        private void Gastos_KeyPress(object sender, KeyPressEventArgs e)
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
