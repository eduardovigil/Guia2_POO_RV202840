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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void BtnDescuento_Click(object sender, EventArgs e)
        {
            Form Descuento = new Form1();
            Descuento.Show();
            this.Hide();
        }

        private void BtnConversion_Click(object sender, EventArgs e)
        {
            Form Conversion = new FrmConversiones();
            Conversion.Show();
            this.Hide();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCuadratica_Click(object sender, EventArgs e)
        {
            Form Cuadratica = new FrmCuadratica();
            Cuadratica.Show();
            this.Hide();
        }

        private void BtnEjemplo_Click(object sender, EventArgs e)
        {
            Form Ejemplo5 = new FrmEjemplo5();
            Ejemplo5.Show();
            this.Hide();
        }
    }
}
