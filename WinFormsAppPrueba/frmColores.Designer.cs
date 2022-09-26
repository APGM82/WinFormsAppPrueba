namespace WinFormsAppPrueba
{
    partial class frmColores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnColor = new System.Windows.Forms.Button();
            this.btnFuentes = new System.Windows.Forms.Button();
            this.labInfo = new System.Windows.Forms.Label();
            this.txbTextoPrueba = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(123, 122);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(122, 49);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "Colores";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnFuentes
            // 
            this.btnFuentes.Location = new System.Drawing.Point(344, 122);
            this.btnFuentes.Name = "btnFuentes";
            this.btnFuentes.Size = new System.Drawing.Size(122, 49);
            this.btnFuentes.TabIndex = 1;
            this.btnFuentes.Text = "Tipo de letra";
            this.btnFuentes.UseVisualStyleBackColor = true;
            this.btnFuentes.Click += new System.EventHandler(this.btnFuentes_Click);
            // 
            // labInfo
            // 
            this.labInfo.AutoSize = true;
            this.labInfo.Location = new System.Drawing.Point(30, 53);
            this.labInfo.Name = "labInfo";
            this.labInfo.Size = new System.Drawing.Size(538, 20);
            this.labInfo.TabIndex = 2;
            this.labInfo.Text = "Escoja el color de fonde de este formulario y el tipo de letra de la caja de text" +
    "o.";
            // 
            // txbTextoPrueba
            // 
            this.txbTextoPrueba.Location = new System.Drawing.Point(30, 247);
            this.txbTextoPrueba.Multiline = true;
            this.txbTextoPrueba.Name = "txbTextoPrueba";
            this.txbTextoPrueba.Size = new System.Drawing.Size(538, 132);
            this.txbTextoPrueba.TabIndex = 3;
            // 
            // frmColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 451);
            this.Controls.Add(this.txbTextoPrueba);
            this.Controls.Add(this.labInfo);
            this.Controls.Add(this.btnFuentes);
            this.Controls.Add(this.btnColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmColores";
            this.Text = "frmColores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnColor;
        private Button btnFuentes;
        private Label labInfo;
        private TextBox txbTextoPrueba;
    }
}