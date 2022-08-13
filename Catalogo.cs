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
    public partial class Catalogo : Form
    {
        Catalogo_Ventas CatalogoVentas = new Catalogo_Ventas();
        Catalogo_Gastos CatalogoGastos = new Catalogo_Gastos();
        Catalogo_Usuarios CatalogoUsuarios = new Catalogo_Usuarios();
        Catalogo_Productos CatalogoProductos = new Catalogo_Productos();
        public Catalogo()
        {
            InitializeComponent();
        }

        private void lbl_Ventas_Click(object sender, EventArgs e)
        {

        }

        private void pb_Ventas_Click(object sender, EventArgs e)
        {
            CatalogoVentas.ShowDialog();
        }

        private void pb_Usuarios_Click(object sender, EventArgs e)
        {
            CatalogoUsuarios.ShowDialog();

        }

        private void pb_Gastos_Click(object sender, EventArgs e)
        {
            CatalogoGastos.ShowDialog();
        }

        private void pb_Productos_Click(object sender, EventArgs e)
        {
            CatalogoProductos.ShowDialog();

        }
    }
}
