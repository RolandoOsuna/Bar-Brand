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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void txt_Usuario_Enter(object sender, EventArgs e)
        {
            if (txt_Usuario.Text == "USUARIO")
            {
                txt_Usuario.Text = "";
                txt_Usuario.ForeColor = Color.LightGray; 
            }
            
        }
        private void txt_Usuario_Leave(object sender, EventArgs e)
        {
            if (txt_Usuario.Text == "")
            {
                txt_Usuario.Text = "USUARIO";
                txt_Usuario.ForeColor = Color.DimGray;

            }
        }

        private void txt_Contra_Enter(object sender, EventArgs e)
        {
            if (txt_Contra.Text == "CONTRASEÑA")
            {
                txt_Contra.Text = "";
                txt_Contra.ForeColor = Color.LightGray;
                txt_Contra.UseSystemPasswordChar = true;
            }
        }

        private void txt_Contra_Leave(object sender, EventArgs e)
        {
            if (txt_Contra.Text == "")
            {       
                txt_Contra.Text = "CONTRASEÑA";
                txt_Contra.ForeColor = Color.DimGray;
                txt_Contra.UseSystemPasswordChar = false;
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            using (var db = new wtfbarberContext.wtfbarberContext())
            {
                wtfbarberContext.Usuario usuario = new wtfbarberContext.Usuario()
                {

                };
                var lts = from d in db.Usuarios 
                          where d.NombreUsuario == txt_Usuario.Text 
                          && d.ContrasenaUsuario == txt_Contra.Text 
                          select d;
                if (lts.Count() >0)
                {
                    MessageBox.Show("Bienvenido: "+ txt_Usuario.Text);
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    //MessageBox.Show("Usuario no existe");
                    lbl_Error.Text = "Error \n Usuario y/o Contraseña incorrectos";
                    limpiarTextbox();

                }
            }



            if (txt_Usuario.Text == "admin" &&  txt_Contra.Text == "admin")
            {
                dashboard.Show();
                this.Hide();
            }
     

        }
        private void txt_Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txt_Contra_TextChanged(object sender, EventArgs e)
        {

        }
        public void limpiarTextbox()
        {
            txt_Usuario.Clear();
            txt_Contra.Clear();
        }
    }
}
