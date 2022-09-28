namespace FormularioPrincipal
{
    partial class frmCalendario
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
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.mc = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(40, 72);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(232, 23);
            this.dtp.TabIndex = 0;
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // mc
            // 
            this.mc.Location = new System.Drawing.Point(40, 144);
            this.mc.Name = "mc";
            this.mc.TabIndex = 1;
            this.mc.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mc_DateChanged);
            // 
            // frmCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 450);
            this.Controls.Add(this.mc);
            this.Controls.Add(this.dtp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCalendario";
            this.Text = "frmCalendario";
            this.ResumeLayout(false);

        }

        #endregion

        private DateTimePicker dtp;
        private MonthCalendar mc;
    }
}