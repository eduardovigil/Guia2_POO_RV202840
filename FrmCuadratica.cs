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
    public partial class FrmCuadratica : Form
    {
        public FrmCuadratica()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            //Declaramos variables
            double a, b, c, raiz, x1,x2,raiz1,raiz2;
            //Conversion de valores
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            c = Convert.ToDouble(txtC.Text);
            //Procedimiento de la formula cuadratica
            raiz = (b * b) - 4 * a * c;
            raiz1 = -b + Math.Sqrt(raiz);
            raiz2 = -b - Math.Sqrt(raiz);
            x1 = raiz1 / (2 * a);
            x2 = raiz2 / (2 * a);
            //Entrega de resultados
            txtRespuesta1.Text = Convert.ToString(x1);
            txtRespuesta2.Text = Convert.ToString(x2);
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Form Menu = new FrmMenu();
            Menu.Show();
            this.Hide();
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
    
}
