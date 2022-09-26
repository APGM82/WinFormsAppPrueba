using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppPrueba
{
    public partial class frmTriangulos : Form
    {
        public frmTriangulos()
        {
            InitializeComponent();
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            bool valido1;
            bool valido2;
            bool valido3;
            float caja1;
            float caja2;
            float caja3;

            valido1 = float.TryParse(txbLado1.Text, out caja1);
            if (!valido1) MessageBox.Show("El número introducido \"" + txbLado1.Text + "\" no es válido");

            valido2 = float.TryParse(txbLado2.Text, out caja2);
            if (!valido2) MessageBox.Show("El número introducido \"" + txbLado2.Text + "\" no es válido");

            valido3 = float.TryParse(txbLado3.Text, out caja3);
            if (!valido3) MessageBox.Show("El número introducido:\"" + txbLado3.Text + "\"no es válido");


            if (valido1 && valido2 && valido3)
            {
                bool comprobarValidez()
                {

                    if (caja1 + caja2 <= caja3 || caja1 + caja3 <= caja2 || caja2 + caja3 <= caja1)
                        return false;
                    else
                        return true;
                }
                bool booValidez = comprobarValidez();
                if (booValidez == true)
                {
                    if (caja1 != caja2 && caja2 != caja3)
                    {
                        labResultado.Text = "Es un triangulo posible y es escaleno";
                    }
                    else if (caja1 == caja2 && caja1 == caja3)
                    {
                        labResultado.Text = "Es un triangulo posible y es equilátero";
                    }
                    else
                    {
                        labResultado.Text = "Es un triangulo posible y es isósceles";
                    }
                }
                else
                {
                    labResultado.Text = "Este triángulo no es posible";
                }
            }
        }
    }
}
