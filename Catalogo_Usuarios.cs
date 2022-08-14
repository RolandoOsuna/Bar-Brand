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
    public partial class Catalogo_Usuarios : Form
    {
        Usuario usuarios = new Usuario();
        public int? id;

        public Catalogo_Usuarios()
        {
            InitializeComponent();
        }
        private void Catalogo_Usuarios_Load(object sender, EventArgs e)
        {
            string mifecha;
            dtp_CatalogoDesde.Format = DateTimePickerFormat.Custom;
            dtp_CatalogoDesde.CustomFormat = "dd/MM/yyyy";
            dtp_CatalogoDesde.Value = Convert.ToDateTime(mifecha = DateTime.Today.ToString());
            dtp_CatalogoHasta.Format = DateTimePickerFormat.Custom;
            dtp_CatalogoHasta.CustomFormat = "dd/MM/yyyy";
            dtp_CatalogoHasta.Value = Convert.ToDateTime(mifecha = DateTime.Now.ToString());
            btn_Guardar.Visible = false;
            btn_CancelarModificacion.Visible = false;
            //Ocultartxt();
            MostrarDatos();
        }


        public void MostrarDatos()
        {
            using (var db = new wtfbarberContext.wtfbarberContext())
            {
                var lts = from d in db.Usuarios
                          select d;
                dgv_CatalogoUsuarios.DataSource = lts.ToList();
            }
        }
        //BTN MOSTRAR DATOS
        private void btn_MostrarDatos_Click(object sender, EventArgs e)
        {
            using var db = new wtfbarberContext.wtfbarberContext();
            dgv_CatalogoUsuarios.DataSource = (from Usuario in db.Usuarios
                                             where Usuario.FechaUsuario >= dtp_CatalogoDesde.Value && Usuario.FechaUsuario <= dtp_CatalogoHasta.Value
                                             select new
                                             {
                                                 Id = Usuario.IdUsuario,
                                                 Nombre = Usuario.NombreUsuario,
                                                 Contraseña = Usuario.ContrasenaUsuario,
                                                 Privilegio = Usuario.PrivilegioUsuario,
                                                 //Fecha = Usuario.FechaUsuario
                                             }).ToList();
        }
        private int? GetId()
        {
            try
            {
                return int.Parse(dgv_CatalogoUsuarios.Rows[dgv_CatalogoUsuarios.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        //BTN AGREGAR
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            //VALIDACION CAMPOS VACIOS
            if (txt_Nombre.Text == "" || cmb_Privilegio.Text == "" || txt_Contra.Text == "")
            {
                MessageBox.Show("Completa todos los campos");
                return;
            }
                using (var db = new wtfbarberContext.wtfbarberContext())
                {
                    wtfbarberContext.Usuario usuario = new wtfbarberContext.Usuario()
                    {
                        NombreUsuario = txt_Nombre.Text.ToString(),
                        ContrasenaUsuario = txt_Contra.Text.ToString(),
                        PrivilegioUsuario = cmb_Privilegio.SelectedItem.ToString(),
                        FechaUsuario = DateTime.Now,
                    };
                    db.Add(usuario);
                    db.SaveChanges();
                    limpiarTextbox();
                    MessageBox.Show("Usuario Agregado Exitosamente");
                }
                MostrarDatos();
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
        //BTN GUARDAR
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            //VALIDACION CAMPOS VACIOS
            if (txt_Nombre.Text == "" || cmb_Privilegio.Text == "" || txt_Contra.Text == "")
            {
                MessageBox.Show("Completa todos los campos");
                return;
            }
            try
            {
                using (var db = new wtfbarberContext.wtfbarberContext())
                {
                    if (id == null)
                        usuarios = new Usuario();
                    usuarios.IdUsuario = id.Value;
                    usuarios.NombreUsuario = txt_Nombre.Text.ToString();
                    usuarios.ContrasenaUsuario = txt_Contra.Text.ToString();
                    usuarios.PrivilegioUsuario = cmb_Privilegio.SelectedItem.ToString();
                    usuarios.FechaUsuario = DateTime.Now;

                    db.Usuarios.Attach(usuarios);
                    db.Entry(usuarios).State = EntityState.Modified;
                    db.SaveChanges();

                    MessageBox.Show("Modificado");
                    Ocultartxt();
                    limpiarTextbox();
                    btn_Guardar.Visible = false;
                    btn_CancelarModificacion.Visible = false;
                    MostrarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //BTN CANCELAR MODIFICACION
        private void btn_CancelarModificacion_Click(object sender, EventArgs e)
        {
            limpiarTextbox();
            Ocultartxt();
            btn_CancelarModificacion.Visible = false;
            btn_Guardar .Visible = false;
        }

        //BTN ELIMINAR
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Eliminar Usuario?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int? id = GetId();
                if (id != null)
                {
                    using (var db = new wtfbarberContext.wtfbarberContext())
                    {
                        usuarios = db.Usuarios.Find(id);
                        db.Usuarios.Remove(usuarios);
                        db.SaveChanges();
                    }
                    MostrarDatos();
                }
            }
        }

        
        
        //METODOS
        private void CargarDatos()
        {
            using (var db = new wtfbarberContext.wtfbarberContext())
            {
                var usuarios = db.Usuarios.Find(id = GetId());
                txt_Nombre.Text = usuarios.NombreUsuario.ToString();
                txt_Contra.Text = usuarios.ContrasenaUsuario.ToString();
                cmb_Privilegio.SelectedItem = usuarios.PrivilegioUsuario;
            }
        }
        public void Ocultartxt()
        {
            lbl_Nombre.Enabled = false;
            lbl_Contra.Enabled = false;
            lbl_Privilegio.Enabled = false;
            txt_Nombre.Enabled = false;
            txt_Contra.Enabled = false;
            cmb_Privilegio.Enabled = false;
        }
        public void Mostrartxt()
        {
            lbl_Nombre.Enabled = true;
            lbl_Contra.Enabled = true;
            lbl_Privilegio.Enabled = true;
            txt_Nombre.Enabled = true;
            txt_Contra.Enabled = true;
            cmb_Privilegio.Enabled = true;
        }
        public void limpiarTextbox()
        {
            txt_Nombre.Clear();
            txt_Contra.Clear();
            cmb_Privilegio.Text = "";
        }
        
    }
}
