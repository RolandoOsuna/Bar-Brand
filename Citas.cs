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
    public partial class Citas : Form
    {
        public Citas()
        {
            InitializeComponent();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            //VALIDACION COMPLEATAR CAMPOS
            if (txt_nombre.Text == "" || txt_telefono.Text == "")
            {
                MessageBox.Show("Completa todos los campos");
                return;
            }
            using (var db = new wtfbarberContext.wtfbarberContext())
            {
                wtfbarberContext.Cita cita = new wtfbarberContext.Cita()
                {
                    NombreCita = txt_nombre.Text,
                    TelefonoCita = txt_telefono.Text,
                    FechaCita = dtp_cita.Value
                };
                db.Add(cita);
                db.SaveChanges();
                MessageBox.Show("Cita de "+ txt_nombre.Text+" Agendada");
                limpiarTextbox();
            }
        }

        public void limpiarTextbox()
        {
            txt_nombre.Clear();
            txt_telefono.Clear();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            //VALIDACIÓN DE BOTON CANCELAR
            if (txt_nombre.Text == "" && txt_telefono.Text == "")
            { }
            else if (MessageBox.Show("¿Cancelar Cita?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                limpiarTextbox();
            }
        }

        private void Citas_Load(object sender, EventArgs e)
        {
            using(wtfbarberContext.wtfbarberContext db = new wtfbarberContext.wtfbarberContext())
            {
                var lts = from d in db.Citas
                          select d;
                dgv_Citas.DataSource = lts.ToList();
            }
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
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
