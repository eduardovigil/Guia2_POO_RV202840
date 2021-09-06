using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia2_POO_RV202840
{
    public partial class FrmConversiones : Form
    {
        public FrmConversiones()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (RdbTemperatura.Checked == true)
            {
                double fahrenheit, celsius1;
                celsius1 = Convert.ToDouble(txtIngreso.Text);
                fahrenheit = (celsius1 - 32) * 5 / 9;
                txtRespuesta.Text = Convert.ToString(fahrenheit);
                LblRespuesta.Text = "Conversion a Fahrenheit: ";
            }
            if (RdbLongitud.Checked == true)
            {
                double Pies, Metro;
                Metro = Convert.ToDouble(txtIngreso.Text);
                Pies = Metro * 3.281;
                txtRespuesta.Text = Convert.ToString(Pies);
                LblRespuesta.Text = "Conversion a Pies: ";
            }
            if (RdbPeso.Checked == true)
            {
                double Libras, Kilogramos;
                Kilogramos = Convert.ToDouble(txtIngreso.Text);
                Libras = Kilogramos * 2.205;
                txtRespuesta.Text = Convert.ToString(Libras);
                LblRespuesta.Text = "Conversion a Libras :";
            }
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Form Menu = new FrmMenu();
           Menu.Show();
            this.Hide();
        }

        private void txtIngreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
