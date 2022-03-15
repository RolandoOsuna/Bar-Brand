using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WTFBarber
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void bnt_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_Maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_Maximizar.Visible = false;
            btn_Restaurar.Visible = true;
        }

        private void btn_Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_Restaurar.Visible = false;
            btn_Maximizar.Visible = true;
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Barra_Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_Cobro_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Cobro>();
        }
        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            CerrarSesion();
        }
        private void lbl_CerrarSesion_Click(object sender, EventArgs e)
        {
            CerrarSesion();
        }
        private void btn_CorteCaja_Click(object sender, EventArgs e)
        {
            AbrirFormulario<CorteCaja>();
        }
        private void btn_Nominas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Nomina>();
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelformulario.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
                                                                                    //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelformulario.Controls.Add(formulario);
                panelformulario.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }
        private void CerrarSesion (){
            if (MessageBox.Show("Estas seguro de salir?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_Reportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Reportes>();
        }
    }
}
