namespace WinFormsAppPrueba
{
    partial class frmCalendarios
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
            this.datDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.datMonthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // datDateTimePicker1
            // 
            this.datDateTimePicker1.Location = new System.Drawing.Point(174, 80);
            this.datDateTimePicker1.Name = "datDateTimePicker1";
            this.datDateTimePicker1.Size = new System.Drawing.Size(293, 27);
            this.datDateTimePicker1.TabIndex = 0;
            this.datDateTimePicker1.ValueChanged += new System.EventHandler(this.datDateTimePicker1_ValueChanged);
            // 
            // datMonthCalendar1
            // 
            this.datMonthCalendar1.Location = new System.Drawing.Point(205, 119);
            this.datMonthCalendar1.Name = "datMonthCalendar1";
            this.datMonthCalendar1.TabIndex = 1;
            this.datMonthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.datMonthCalendar1_DateChanged);
            // 
            // frmCalendarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 446);
            this.Controls.Add(this.datMonthCalendar1);
            this.Controls.Add(this.datDateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCalendarios";
            this.Text = "frmCalendarios";
            this.ResumeLayout(false);

        }

        #endregion

        private DateTimePicker datDateTimePicker1;
        private MonthCalendar datMonthCalendar1;
    }
}