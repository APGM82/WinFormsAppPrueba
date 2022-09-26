namespace WinFormsAppPrueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola que tal "+txbTexto1.Text);
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Form2 frmPrueba =new Form2();
            //frmPrueba.Show(); Deja volver a la anterior o abrir varias
            frmPrueba.ShowDialog();//no deja volver a la anterior hasta cerrar 
        }
    }
}