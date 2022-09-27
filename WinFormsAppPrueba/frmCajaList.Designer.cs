namespace WinFormsAppPrueba
{
    partial class frmCajaList
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
            this.lstListaArticulos = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtExtendida = new System.Windows.Forms.RadioButton();
            this.rbtMultiple = new System.Windows.Forms.RadioButton();
            this.rbtSimple = new System.Windows.Forms.RadioButton();
            this.lstListaTraspasados = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnTraspasar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.chkOrdenar = new System.Windows.Forms.CheckBox();
            this.chkColumnas = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txbTexto = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstListaArticulos
            // 
            this.lstListaArticulos.FormattingEnabled = true;
            this.lstListaArticulos.ItemHeight = 20;
            this.lstListaArticulos.Items.AddRange(new object[] {
            "Patatas",
            "Manzanas",
            "Melones",
            "El anillo único",
            "Melocotones",
            "Ciruelas",
            "Aguacates",
            "Papayas",
            "Tomates",
            "Calabazas",
            "Pepinos",
            "Zanahorias",
            "Mangos",
            "Moras",
            "Peras",
            "Fresas",
            "Sandías"});
            this.lstListaArticulos.Location = new System.Drawing.Point(26, 47);
            this.lstListaArticulos.Name = "lstListaArticulos";
            this.lstListaArticulos.Size = new System.Drawing.Size(217, 164);
            this.lstListaArticulos.TabIndex = 0;
            this.lstListaArticulos.SelectedIndexChanged += new System.EventHandler(this.lstListaArticulos_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumPurple;
            this.groupBox1.Controls.Add(this.rbtExtendida);
            this.groupBox1.Controls.Add(this.rbtMultiple);
            this.groupBox1.Controls.Add(this.rbtSimple);
            this.groupBox1.Location = new System.Drawing.Point(249, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 164);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de selección";
            // 
            // rbtExtendida
            // 
            this.rbtExtendida.AutoSize = true;
            this.rbtExtendida.Location = new System.Drawing.Point(17, 129);
            this.rbtExtendida.Name = "rbtExtendida";
            this.rbtExtendida.Size = new System.Drawing.Size(96, 24);
            this.rbtExtendida.TabIndex = 2;
            this.rbtExtendida.TabStop = true;
            this.rbtExtendida.Text = "Extendida";
            this.rbtExtendida.UseVisualStyleBackColor = true;
            this.rbtExtendida.CheckedChanged += new System.EventHandler(this.rbtExtendida_CheckedChanged);
            // 
            // rbtMultiple
            // 
            this.rbtMultiple.AutoSize = true;
            this.rbtMultiple.Location = new System.Drawing.Point(17, 82);
            this.rbtMultiple.Name = "rbtMultiple";
            this.rbtMultiple.Size = new System.Drawing.Size(85, 24);
            this.rbtMultiple.TabIndex = 1;
            this.rbtMultiple.TabStop = true;
            this.rbtMultiple.Text = "Múltiple";
            this.rbtMultiple.UseVisualStyleBackColor = true;
            this.rbtMultiple.CheckedChanged += new System.EventHandler(this.rbtMultiple_CheckedChanged);
            // 
            // rbtSimple
            // 
            this.rbtSimple.AutoSize = true;
            this.rbtSimple.Location = new System.Drawing.Point(17, 35);
            this.rbtSimple.Name = "rbtSimple";
            this.rbtSimple.Size = new System.Drawing.Size(76, 24);
            this.rbtSimple.TabIndex = 0;
            this.rbtSimple.TabStop = true;
            this.rbtSimple.Text = "Simple";
            this.rbtSimple.UseVisualStyleBackColor = true;
            this.rbtSimple.CheckedChanged += new System.EventHandler(this.rbtSimple_CheckedChanged);
            // 
            // lstListaTraspasados
            // 
            this.lstListaTraspasados.FormattingEnabled = true;
            this.lstListaTraspasados.ItemHeight = 20;
            this.lstListaTraspasados.Location = new System.Drawing.Point(431, 47);
            this.lstListaTraspasados.Name = "lstListaTraspasados";
            this.lstListaTraspasados.Size = new System.Drawing.Size(170, 164);
            this.lstListaTraspasados.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(37, 315);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 29);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(137, 315);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 29);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnTraspasar
            // 
            this.btnTraspasar.Location = new System.Drawing.Point(249, 228);
            this.btnTraspasar.Name = "btnTraspasar";
            this.btnTraspasar.Size = new System.Drawing.Size(176, 47);
            this.btnTraspasar.TabIndex = 5;
            this.btnTraspasar.Text = "TRASPASAR >>>";
            this.btnTraspasar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(431, 228);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(170, 47);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // chkOrdenar
            // 
            this.chkOrdenar.AutoSize = true;
            this.chkOrdenar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.chkOrdenar.Location = new System.Drawing.Point(60, 234);
            this.chkOrdenar.Name = "chkOrdenar";
            this.chkOrdenar.Size = new System.Drawing.Size(85, 24);
            this.chkOrdenar.TabIndex = 7;
            this.chkOrdenar.Text = "Ordenar";
            this.chkOrdenar.UseVisualStyleBackColor = true;
            this.chkOrdenar.CheckedChanged += new System.EventHandler(this.chkOrdenar_CheckedChanged);
            // 
            // chkColumnas
            // 
            this.chkColumnas.AutoSize = true;
            this.chkColumnas.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.chkColumnas.Location = new System.Drawing.Point(60, 264);
            this.chkColumnas.Name = "chkColumnas";
            this.chkColumnas.Size = new System.Drawing.Size(169, 24);
            this.chkColumnas.TabIndex = 8;
            this.chkColumnas.Text = "Mostrar en columnas";
            this.chkColumnas.UseVisualStyleBackColor = true;
            this.chkColumnas.CheckedChanged += new System.EventHandler(this.chkColumnas_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 82);
            this.button1.TabIndex = 9;
            this.button1.Text = "Seleccionar elemento en la posicion indicada";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbTexto
            // 
            this.txbTexto.Location = new System.Drawing.Point(37, 370);
            this.txbTexto.Name = "txbTexto";
            this.txbTexto.Size = new System.Drawing.Size(194, 27);
            this.txbTexto.TabIndex = 10;
            // 
            // frmCajaList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(709, 456);
            this.Controls.Add(this.txbTexto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkColumnas);
            this.Controls.Add(this.chkOrdenar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnTraspasar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstListaTraspasados);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstListaArticulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCajaList";
            this.Text = "frmCajaList";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstListaArticulos;
        private GroupBox groupBox1;
        private RadioButton rbtExtendida;
        private RadioButton rbtMultiple;
        private RadioButton rbtSimple;
        private ListBox lstListaTraspasados;
        private Button btnAgregar;
        private Button btnBuscar;
        private Button btnTraspasar;
        private Button btnLimpiar;
        private CheckBox chkOrdenar;
        private CheckBox chkColumnas;
        private Button button1;
        private TextBox txbTexto;
    }
}