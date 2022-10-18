using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WTFBarber
{
    public partial class Catalogo_Productos : Form
    {
        public Catalogo_Productos()
        {
            InitializeComponent();
        }

        private void Catalogo_Productos_Load(object sender, EventArgs e)
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
            //MostrarDatos();
        }
    }
}
