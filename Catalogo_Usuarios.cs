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
            //btn_Modificar.Visible = false;

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
                                                 Fecha = Usuario.FechaUsuario
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


    }
}
