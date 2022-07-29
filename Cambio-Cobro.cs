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
    public partial class Cambio_Cobro : Form
    {
        int total = 35;
        int pago, cambio;

        public Cambio_Cobro()
        {
            InitializeComponent();
        }

        private void Cambio_Cobro_Load(object sender, EventArgs e)
        {
            lbl_CantidadTotal.Text = "$" + total.ToString();
            
        }

        private void btn_iconoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_iconoConfirmar_Click(object sender, EventArgs e)
        {
            cambioCobro();
        }

        private void cambioCobro()
        {
            //txt_Pago.Text = Convert.ToString(pago);
            pago = Convert.ToInt32(txt_Pago.Text);
            cambio =  pago - total;
            lbl_CantidadCambio.Text = cambio.ToString();
            //if
        }
    }
}
