namespace WinFormsAppPrueba
{
    partial class frmComboBox
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
            this.labLabel1 = new System.Windows.Forms.Label();
            this.labLabel2 = new System.Windows.Forms.Label();
            this.labLabel3 = new System.Windows.Forms.Label();
            this.cmbComboBox1 = new System.Windows.Forms.ComboBox();
            this.cmbComboBox2 = new System.Windows.Forms.ComboBox();
            this.cmbComboBox3 = new System.Windows.Forms.ComboBox();
            this.labUltimoColor = new System.Windows.Forms.Label();
            this.txbUltimoColor = new System.Windows.Forms.TextBox();
            this.txbAdd = new System.Windows.Forms.TextBox();
            this.labLabelAdd = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labLabel1
            // 
            this.labLabel1.AutoSize = true;
            this.labLabel1.Location = new System.Drawing.Point(106, 76);
            this.labLabel1.Name = "labLabel1";
            this.labLabel1.Size = new System.Drawing.Size(118, 20);
            this.labLabel1.TabIndex = 0;
            this.labLabel1.Text = "Estilo dropdown";
            // 
            // labLabel2
            // 
            this.labLabel2.AutoSize = true;
            this.labLabel2.Location = new System.Drawing.Point(283, 76);
            this.labLabel2.Name = "labLabel2";
            this.labLabel2.Size = new System.Drawing.Size(146, 20);
            this.labLabel2.TabIndex = 1;
            this.labLabel2.Text = "Estilo Dropdown List";
            // 
            // labLabel3
            // 
            this.labLabel3.AutoSize = true;
            this.labLabel3.Location = new System.Drawing.Point(460, 76);
            this.labLabel3.Name = "labLabel3";
            this.labLabel3.Size = new System.Drawing.Size(95, 20);
            this.labLabel3.TabIndex = 2;
            this.labLabel3.Text = "Estilo Simple";
            // 
            // cmbComboBox1
            // 
            this.cmbComboBox1.FormattingEnabled = true;
            this.cmbComboBox1.Location = new System.Drawing.Point(106, 126);
            this.cmbComboBox1.Name = "cmbComboBox1";
            this.cmbComboBox1.Size = new System.Drawing.Size(151, 28);
            this.cmbComboBox1.TabIndex = 3;
            this.cmbComboBox1.SelectedIndexChanged += new System.EventHandler(this.cmbComboBox1_SelectedIndexChanged);
            // 
            // cmbComboBox2
            // 
            this.cmbComboBox2.FormattingEnabled = true;
            this.cmbComboBox2.Items.AddRange(new object[] {
            "Azul",
            "Rosa",
            "Verde",
            "Amarillo",
            "Rojo",
            "Negro"});
            this.cmbComboBox2.Location = new System.Drawing.Point(283, 126);
            this.cmbComboBox2.Name = "cmbComboBox2";
            this.cmbComboBox2.Size = new System.Drawing.Size(151, 28);
            this.cmbComboBox2.TabIndex = 4;
            this.cmbComboBox2.SelectedIndexChanged += new System.EventHandler(this.cmbComboBox2_SelectedIndexChanged);
            // 
            // cmbComboBox3
            // 
            this.cmbComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbComboBox3.FormattingEnabled = true;
            this.cmbComboBox3.Location = new System.Drawing.Point(460, 126);
            this.cmbComboBox3.Name = "cmbComboBox3";
            this.cmbComboBox3.Size = new System.Drawing.Size(151, 28);
            this.cmbComboBox3.TabIndex = 5;
            this.cmbComboBox3.SelectedIndexChanged += new System.EventHandler(this.cmbComboBox3_SelectedIndexChanged);
            // 
            // labUltimoColor
            // 
            this.labUltimoColor.AutoSize = true;
            this.labUltimoColor.Location = new System.Drawing.Point(106, 279);
            this.labUltimoColor.Name = "labUltimoColor";
            this.labUltimoColor.Size = new System.Drawing.Size(154, 20);
            this.labUltimoColor.TabIndex = 6;
            this.labUltimoColor.Text = "Último color elegido: ";
            // 
            // txbUltimoColor
            // 
            this.txbUltimoColor.Location = new System.Drawing.Point(283, 272);
            this.txbUltimoColor.Name = "txbUltimoColor";
            this.txbUltimoColor.ReadOnly = true;
            this.txbUltimoColor.Size = new System.Drawing.Size(191, 27);
            this.txbUltimoColor.TabIndex = 7;
            // 
            // txbAdd
            // 
            this.txbAdd.Location = new System.Drawing.Point(283, 351);
            this.txbAdd.Name = "txbAdd";
            this.txbAdd.Size = new System.Drawing.Size(201, 27);
            this.txbAdd.TabIndex = 8;
            // 
            // labLabelAdd
            // 
            this.labLabelAdd.AutoSize = true;
            this.labLabelAdd.Location = new System.Drawing.Point(106, 354);
            this.labLabelAdd.Name = "labLabelAdd";
            this.labLabelAdd.Size = new System.Drawing.Size(149, 20);
            this.labLabelAdd.TabIndex = 9;
            this.labLabelAdd.Text = "Añadir al dropdown: ";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(517, 351);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labLabelAdd);
            this.Controls.Add(this.txbAdd);
            this.Controls.Add(this.txbUltimoColor);
            this.Controls.Add(this.labUltimoColor);
            this.Controls.Add(this.cmbComboBox3);
            this.Controls.Add(this.cmbComboBox2);
            this.Controls.Add(this.cmbComboBox1);
            this.Controls.Add(this.labLabel3);
            this.Controls.Add(this.labLabel2);
            this.Controls.Add(this.labLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmComboBox";
            this.Text = "frmComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labLabel1;
        private Label labLabel2;
        private Label labLabel3;
        private ComboBox cmbComboBox1;
        private ComboBox cmbComboBox2;
        private ComboBox cmbComboBox3;
        private Label labUltimoColor;
        private TextBox txbUltimoColor;
        private TextBox txbAdd;
        private Label labLabelAdd;
        private Button btnAdd;
    }
}