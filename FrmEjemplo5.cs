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
    public partial class FrmEjemplo5 : Form
    {
        public FrmEjemplo5()
        {
            InitializeComponent();
        }

        private void btnmostrar1_Click(object sender, EventArgs e)
        {
            //declaramos variables
            int maynegativo = -1000;
            //Implementamos proceso para valores del lbs
            for (int i = 0; i < lsbArreglo.Items.Count; i++)
            {
                string valor = lsbArreglo.Items[i].ToString();
                int numero = int.Parse(valor);
                if (numero < 0 && numero % 2 == 0)
                {
                    //incrementamos numeros negativos
                    if (numero > maynegativo)
                    {
                        maynegativo = numero;
                        //mostramos resultado 
                        txtnegativo.Text = maynegativo.ToString();
                    }
                }
                else
                {
                    // no hubieron valores negativos
                    txtnegativo.Text = "No hay números negativos pares";
                }
            }

            //declaramos variables
            double cantidadnumeros = lsbArreglo.Items.Count;
            double cantidadceros = 0;
            double porcentaje = 0;
            //Implementamos proceso para valores del lbs
            for (int i = 0; i < lsbArreglo.Items.Count; i++)
            {

                string valor = lsbArreglo.Items[i].ToString();
                int numero = int.Parse(valor);
                if (numero == 0)
                {
                    cantidadceros = cantidadceros + 1;
                }
            }
            porcentaje = (cantidadceros / cantidadnumeros) * 100;
            txtprocentaje.Text = porcentaje.ToString() + "%";

            //declaramos variables
            double prom;
            double cantidadimpares = 0;
            double suma = 0;
            for (int i = 0; i < lsbArreglo.Items.Count; i++)
            {
                string valor = lsbArreglo.Items[i].ToString();
                int numero = int.Parse(valor);
                if (numero > 0 && numero % 2 != 0)
                {
                    suma = suma + numero;
                    cantidadimpares = cantidadimpares + 1;
                }
            }
            prom = suma / cantidadimpares;
            txtpositivos.Text = prom.ToString();

            int mayor = 0;
            for (int i = 0; i < lsbArreglo.Items.Count; i++)
            {
                string valor = lsbArreglo.Items[i].ToString();
                int numero = int.Parse(valor);
                if (numero > 0 && numero % 2 == 0)
                {
                    if (numero > mayor)
                    {
                        mayor = numero;
                    }
                }
            }
            txtmayoposi.Text = mayor.ToString();
        }

        private void txtnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                lsbArreglo.Items.Add(txtnumero.Text);
                txtnumero.Clear();
                txtnumero.Focus();
            }
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Form Menu = new FrmMenu();
            Menu.Show();
            this.Hide();
        }
    }
}
