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
    public partial class frmColores : Form
    {
        public frmColores()
        {
            InitializeComponent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current color.
            MyDialog.Color = frmColores.DefaultBackColor;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
                this.BackColor = MyDialog.Color;
        }

        private void btnFuentes_Click(object sender, EventArgs e)
        {
            FontDialog dialogoFuentes = new FontDialog();

            if (dialogoFuentes.ShowDialog() == DialogResult.OK)
                txbTextoPrueba.Font = dialogoFuentes.Font;
        }
    }
}
