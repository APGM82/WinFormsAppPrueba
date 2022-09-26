namespace WinFormsAppPrueba
{
    partial class frmTriangulos
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
            this.txbLado1 = new System.Windows.Forms.TextBox();
            this.txbLado2 = new System.Windows.Forms.TextBox();
            this.txbLado3 = new System.Windows.Forms.TextBox();
            this.btnComprobar = new System.Windows.Forms.Button();
            this.labResultado = new System.Windows.Forms.Label();
            this.labLado1 = new System.Windows.Forms.Label();
            this.labLado2 = new System.Windows.Forms.Label();
            this.labLado3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbLado1
            // 
            this.txbLado1.Location = new System.Drawing.Point(263, 86);
            this.txbLado1.Name = "txbLado1";
            this.txbLado1.Size = new System.Drawing.Size(125, 27);
            this.txbLado1.TabIndex = 0;
            // 
            // txbLado2
            // 
            this.txbLado2.Location = new System.Drawing.Point(263, 127);
            this.txbLado2.Name = "txbLado2";
            this.txbLado2.Size = new System.Drawing.Size(125, 27);
            this.txbLado2.TabIndex = 1;
            // 
            // txbLado3
            // 
            this.txbLado3.Location = new System.Drawing.Point(263, 168);
            this.txbLado3.Name = "txbLado3";
            this.txbLado3.Size = new System.Drawing.Size(125, 27);
            this.txbLado3.TabIndex = 2;
            // 
            // btnComprobar
            // 
            this.btnComprobar.Location = new System.Drawing.Point(263, 221);
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.Size = new System.Drawing.Size(138, 56);
            this.btnComprobar.TabIndex = 3;
            this.btnComprobar.Text = "Comprobar Triángulo";
            this.btnComprobar.UseVisualStyleBackColor = true;
            this.btnComprobar.Click += new System.EventHandler(this.btnComprobar_Click);
            // 
            // labResultado
            // 
            this.labResultado.AutoSize = true;
            this.labResultado.Location = new System.Drawing.Point(202, 323);
            this.labResultado.Name = "labResultado";
            this.labResultado.Size = new System.Drawing.Size(0, 20);
            this.labResultado.TabIndex = 4;
            // 
            // labLado1
            // 
            this.labLado1.AutoSize = true;
            this.labLado1.Location = new System.Drawing.Point(145, 86);
            this.labLado1.Name = "labLado1";
            this.labLado1.Size = new System.Drawing.Size(57, 20);
            this.labLado1.TabIndex = 5;
            this.labLado1.Text = "Lado 1:";
            // 
            // labLado2
            // 
            this.labLado2.AutoSize = true;
            this.labLado2.Location = new System.Drawing.Point(145, 127);
            this.labLado2.Name = "labLado2";
            this.labLado2.Size = new System.Drawing.Size(57, 20);
            this.labLado2.TabIndex = 6;
            this.labLado2.Text = "Lado 2:";
            // 
            // labLado3
            // 
            this.labLado3.AutoSize = true;
            this.labLado3.Location = new System.Drawing.Point(145, 168);
            this.labLado3.Name = "labLado3";
            this.labLado3.Size = new System.Drawing.Size(57, 20);
            this.labLado3.TabIndex = 7;
            this.labLado3.Text = "Lado 3:";
            // 
            // frmTriangulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 439);
            this.Controls.Add(this.labLado3);
            this.Controls.Add(this.labLado2);
            this.Controls.Add(this.labLado1);
            this.Controls.Add(this.labResultado);
            this.Controls.Add(this.btnComprobar);
            this.Controls.Add(this.txbLado3);
            this.Controls.Add(this.txbLado2);
            this.Controls.Add(this.txbLado1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTriangulos";
            this.Text = "frmTriangulos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbLado1;
        private TextBox txbLado2;
        private TextBox txbLado3;
        private Button btnComprobar;
        private Label labResultado;
        private Label labLado1;
        private Label labLado2;
        private Label labLado3;
    }
}