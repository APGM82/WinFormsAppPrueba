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
    public partial class FormContenedor : Form
    {
        public FormContenedor()
        {
            InitializeComponent();
        }

        private void btnBoton1_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "Form1") 
                {
                    DialogResult rs =MessageBox.Show( "¿Desea cerrar el formulario?","¡Atención!",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if(rs== DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        Form1 f = new Form1();
                        f.MdiParent = this;
                        f.Dock = DockStyle.Fill;
                        f.Show();
                    }
                }
            }
            else 
            {
                Form1 frmHijo = new Form1();
                frmHijo.MdiParent = this;
                frmHijo.Dock = DockStyle.Fill;
                frmHijo.Show();
            }
            
        }

        private void btnTriangulos_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "frmTriangulos")
                {
                    DialogResult rs = MessageBox.Show("¿Desea cerrar el formulario actual?", "¡Advertencia!", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        frmTriangulos ft = new frmTriangulos();
                        ft.MdiParent = this;
                        ft.Dock = DockStyle.Fill;
                        ft.Show();
                    }
                }
            }
            else
            {
                frmTriangulos ft = new frmTriangulos();
                ft.MdiParent = this;
                ft.Dock = DockStyle.Fill;
                ft.Show();
            }
        }

        private void btnColores_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "frmEjercicio3")
                {
                    DialogResult rs = MessageBox.Show("¿Desea cerrar el formulario actual?", "¡Advertencia!", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        frmColores ft = new frmColores();
                        ft.MdiParent = this;
                        ft.Dock = DockStyle.Fill;
                        ft.Show();
                    }
                }
            }
            else
            {
                frmColores ft = new frmColores();
                ft.MdiParent = this;
                ft.Dock = DockStyle.Fill;
                ft.Show();
            }
        }

        private void btnComboBox_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "frmComboBox")
                {
                    DialogResult rs = MessageBox.Show("¿Desea cerrar el formulario actual?", "¡Advertencia!", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        frmComboBox ft = new frmComboBox();
                        ft.MdiParent = this;
                        ft.Dock = DockStyle.Fill;
                        ft.Show();
                    }
                }
            }
            else
            {
                frmComboBox ft = new frmComboBox();
                ft.MdiParent = this;
                ft.Dock = DockStyle.Fill;
                ft.Show();
            }
        }

        private void btnCalendarios_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "frmCalendarios")
                {
                    DialogResult rs = MessageBox.Show("¿Desea cerrar el formulario actual?", "¡Advertencia!", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        frmCalendarios ft = new frmCalendarios();
                        ft.MdiParent = this;
                        ft.Dock = DockStyle.Fill;
                        ft.Show();
                    }
                }
            }
            else
            {
                frmCalendarios ft = new frmCalendarios();
                ft.MdiParent = this;
                ft.Dock = DockStyle.Fill;
                ft.Show();
            }
        }

        private void btnCajas_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "frmCajaList")
                {
                    DialogResult rs = MessageBox.Show("¿Desea cerrar el formulario actual?", "¡Advertencia!", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        frmCajaList ft = new frmCajaList();
                        ft.MdiParent = this;
                        ft.Dock = DockStyle.Fill;
                        ft.Show();
                    }
                }
            }
            else
            {
                frmCajaList ft = new frmCajaList();
                ft.MdiParent = this;
                ft.Dock = DockStyle.Fill;
                ft.Show();
            }
        }
    }
}
