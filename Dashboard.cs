﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;
namespace WTFBarber
{
    public partial class Dashboard : Form
    {
        public static string PrivilegioUsuario;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public Dashboard()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7,48);
            Barra_Lateral.Controls.Add(leftBorderBtn);
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            using(var db = new wtfbarberContext.wtfbarberContext())
            {
                PrivilegioUsuario =( from d in db.Usuarios
                              select d.PrivilegioUsuario).ToString();

                if(PrivilegioUsuario.ToString() == "Admin")
                {
                    btn_iconoCatalogo.Enabled = false;
                    btn_iconoCorteCaja.Enabled = false;
                    btn_iconoNomina.Enabled = false;
                    btn_iconoReportes.Enabled = false;
                    
                }
                else 
                {
                    btn_iconoCatalogo.Enabled = true;
                    btn_iconoCorteCaja.Enabled = true;
                    btn_iconoNomina.Enabled = true;
                    btn_iconoReportes.Enabled = true;
                }
            }
        }
        //Métodos Btn_iconos
        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.Silver;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0,currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
        private void DisableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(168, 168, 168);
                currentBtn.ForeColor = Color.FromArgb(255,255,255);
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                //currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //Restaurar, Cerrar, Maximizar-Minimizarm, Mover barra de título
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

        //Cerrar Sesion
        private void CerrarSesion (){
            if (MessageBox.Show("Estas seguro de salir?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            CerrarSesion();
        }
        private void lbl_CerrarSesion_Click(object sender, EventArgs e)
        {
            CerrarSesion();
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


        private void btn_iconoCobro_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.FromArgb(226, 22, 186));
            AbrirFormulario<Cobro>();
        }

        private void btn_iconoCorteCaja_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.FromArgb(48, 160, 220));
            AbrirFormulario<CorteCaja>();
        }

        private void btn_iconoNomina_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.FromArgb(48, 160, 8));
            AbrirFormulario<Nomina>();
        }

        private void btn_iconoReportes_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.FromArgb(255, 0, 0));
            AbrirFormulario<Reportes>();
        }

        private void btn_iconoCitas_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.FromArgb(255, 191, 0));
            AbrirFormulario<Citas>();
        }

        private void btn_iconoGastos_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.Gray);
            AbrirFormulario<Gastos>();
        }

        private void btn_iconoCatalogo_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.Chocolate);
            AbrirFormulario<Catalogo>();
        }

        private void btn_iconoInicio_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.Silver);
            //Dashboard.Show();

        }

        private void panelformulario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Barra_Lateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Barra_Titulo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
