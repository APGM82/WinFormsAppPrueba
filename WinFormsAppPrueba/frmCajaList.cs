using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinFormsAppPrueba
{
    public partial class frmCajaList : Form
    {
        public frmCajaList()
        {
            InitializeComponent();
        }

        private void rbtSimple_CheckedChanged(object sender, EventArgs e)
        {
            lstListaArticulos.SelectionMode = SelectionMode.One;
        }

        private void lstListaArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Título del formulario que no aparece porque esta aindado
            this.Text = lstListaArticulos.SelectedItem.ToString();
        }

        private void rbtMultiple_CheckedChanged(object sender, EventArgs e)
        {
            lstListaArticulos.SelectionMode = SelectionMode.MultiSimple;
        }

        private void rbtExtendida_CheckedChanged(object sender, EventArgs e)
        {
            lstListaArticulos.SelectionMode = SelectionMode.MultiExtended;
        }

        private void chkOrdenar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOrdenar.Checked)
            {
                lstListaArticulos.Sorted = true;
            }
            else
            {
                lstListaArticulos.Sorted = false;
            }
        }

        private void chkColumnas_CheckedChanged(object sender, EventArgs e)
        {
            if (chkColumnas.Checked)
            {
                lstListaArticulos.MultiColumn = true;
            }
            else
            {
                lstListaArticulos.MultiColumn = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lstListaArticulos.Items.Add(txbTexto.Text);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.txbTexto.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debes escribir algo más abajo", "Error", MessageBoxButtons.OK);
            }
            else
            {
                int i;
                i = this.lstListaArticulos.FindStringExact(this.txbTexto.Text);
                if (i == -1)
                {
                    MessageBox.Show("El artículo no está en la lista", "Información", MessageBoxButtons.OK);
                }
                else
                {
                    this.lstListaArticulos.SelectedIndex = i;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.txbTexto.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debes introducir un número", "Error", MessageBoxButtons.OK);
            }
            else
            {
                int i;
                i = Convert.ToInt32(this.txbTexto.Text);
                if (i > 0 && i < this.lstListaArticulos.Items.Count)
                {
                    this.lstListaArticulos.SetSelected(i - 1, true);
                }
                else if (i < 0)
                {
                    MessageBox.Show("No puede haber elementos negativos en la lista", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("No hay tantos elementos en la lista", "Error", MessageBoxButtons.OK);
                }
            }
        }
    }
}
