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
    public partial class frmComboBox : Form
    {
        public frmComboBox()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbAdd.Text != "")
                cmbComboBox1.Items.Add(txbAdd.Text);
        }

        private void cmbComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbUltimoColor.Text = cmbComboBox1.SelectedItem.ToString();
        }

        private void cmbComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbUltimoColor.Text = cmbComboBox2.SelectedItem.ToString();
        }

        private void cmbComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbUltimoColor.Text = cmbComboBox3.SelectedItem.ToString();
        }
    }
}
