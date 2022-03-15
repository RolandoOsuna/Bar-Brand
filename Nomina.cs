using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WTFBarber.wtfbarberContext;
using System.Data;
using MySql.Data.MySqlClient;

namespace WTFBarber
{
    public partial class Nomina : Form
    {
        int Total, Sueldo;
        public Nomina()
        {
            InitializeComponent();
        }

        private void Nomina_Load(object sender, EventArgs e)
        {
            string mifecha;
            dtp_Desde.Format = DateTimePickerFormat.Custom;
            dtp_Desde.CustomFormat = "dd/MM/yyyy";
            dtp_Desde.Value = Convert.ToDateTime(mifecha = DateTime.Today.ToString());
            dtp_Hasta.Format = DateTimePickerFormat.Custom;
            dtp_Hasta.CustomFormat = "dd/MM/yyyy";
            dtp_Hasta.Value = Convert.ToDateTime(mifecha = DateTime.Now.ToString());
        }

        private void btn_Cobrar_Click(object sender, EventArgs e)
        {
            //VALIDACIÓN COMPLETAR CAMPOS
            if (txt_SueldoBase.Text == "" || txt_Comisiones.Text == "" || txt_Empleados.Text == "")
            {
                MessageBox.Show("Completa todos los campos alv");
            }
            using (var db = new wtfbarberContext.wtfbarberContext())
            {

                wtfbarberContext.Nomina nomina = new wtfbarberContext.Nomina()
                {
                    TotalComisionNomina = Convert.ToInt32(txt_Comisiones.Text),
                    TotalNomina = Convert.ToInt32(txt_Total.Text),
                    FechaNomina = DateTime.Now,
                };
                db.Add(nomina);
                db.SaveChanges();
                MessageBox.Show("Pago a realizado exitozamente" );
                limpiarTextbox();
            }


        }

        
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            //VALIDACIÓN DE BOTON CANCELAR
            if (txt_SueldoBase.Text == "" && txt_Comisiones.Text == "")
            { }
            else if (MessageBox.Show("¿Cancelar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                limpiarTextbox();
            }
        }




   
        private void btn_MostrarDatos_Click(object sender, EventArgs e)
        {
            var comis = "";
            using (var comisss = new wtfbarberContext.wtfbarberContext())
            {

                comis = (from V in comisss.Ventas
                            where V.FechaVenta >= dtp_Desde.Value && V.FechaVenta <= dtp_Hasta.Value
                            select V.TotalComisionVenta).Sum().ToString();
            }
            Sueldo = 3800;
            Total = (int)(Sueldo) + Convert.ToInt32(comis);

            txt_Empleados.Text = "4"; 
            txt_Comisiones.Text = comis.ToString();
            txt_Total.Text = Total.ToString();
            txt_SueldoBase.Text = Sueldo.ToString();
        }

        public void limpiarTextbox()
        {
            txt_Empleados.Text = "";
            txt_SueldoBase.Clear();
            txt_Comisiones.Clear();
            txt_Total.Clear();
        }

    }
}
