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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblDescuento.Visible = false;
            LblNeto.Visible = false;
            LblRespuesta1.Visible = false;
            LblRespuesta2.Visible = false;
            txtDescuento.Visible = false;
            txtNeto.Visible = false;
            BtnBorrar.Visible = false;
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double sueldo, neto, menos;
            if (RdbGerente.Checked == true)
            {
                
                neto = Convert.ToDouble(txtSueldo.Text);
                sueldo = neto * 0.2;
                menos = neto - sueldo;
                LblDescuento.Visible = true;
                LblNeto.Visible = true;
                LblRespuesta1.Visible = true;
                LblRespuesta2.Visible = true;
                txtDescuento.Visible = true;
                txtNeto.Visible = true;
                BtnBorrar.Visible = true;
                LblRespuesta1.Text = "El trabajador " + txtNombre.Text + " " + txtApellido.Text;
                LblRespuesta2.Text = "Gerente";
                txtDescuento.Text = "Descuento 20%";
                txtNeto.Text = Convert.ToString(menos);

            }
            if (rdbSub.Checked == true)
            {
                neto = Convert.ToDouble(txtSueldo.Text);
                sueldo = neto * 0.15;
                menos = neto - sueldo;
                LblDescuento.Visible = true;
                LblNeto.Visible = true;
                LblRespuesta1.Visible = true;
                LblRespuesta2.Visible = true;
                txtDescuento.Visible = true;
                txtNeto.Visible = true;
                BtnBorrar.Visible = true;
                LblRespuesta1.Text = "El trabajador " + txtNombre.Text + " " + txtApellido.Text;
                LblRespuesta2.Text = "Sub-Gerente";
                txtDescuento.Text = "Descuento 15%";
                txtNeto.Text = Convert.ToString(menos);

            }
            if (RdbSecretaria.Checked == true)
            {
                neto = Convert.ToDouble(txtSueldo.Text);
                sueldo = neto * 0.05;
                menos = neto - sueldo;
                LblDescuento.Visible = true;
                LblNeto.Visible = true;
                LblRespuesta1.Visible = true;
                LblRespuesta2.Visible = true;
                txtDescuento.Visible = true;
                txtNeto.Visible = true;
                BtnBorrar.Visible = true;
                LblRespuesta1.Text = "El trabajador " + txtNombre.Text + " " + txtApellido.Text;
                LblRespuesta2.Text = "Secretaria";
                txtDescuento.Text = "Descuento 5%";
                txtNeto.Text = Convert.ToString(menos);

            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            LblDescuento.Visible = false;
            LblNeto.Visible = false;
            LblRespuesta1.Visible = false;
            LblRespuesta2.Visible = false;
            txtDescuento.Visible = false;
            txtNeto.Visible = false;
            BtnBorrar.Visible = false;
            txtNombre.Clear();
            txtApellido.Clear();
            txtSueldo.Clear();
            txtNeto.Clear();
            txtDescuento.Clear();
            LblRespuesta1.Text = " ";
            LblRespuesta2.Text = " ";

        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Form Menu = new FrmMenu();
            Menu.Show();
            this.Hide();
        }

        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
