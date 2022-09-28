namespace FormularioPrincipal
{
    partial class frmColor
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnCambioColor = new System.Windows.Forms.Button();
            this.btnCambiarLetra = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCambioColor
            // 
            this.btnCambioColor.Location = new System.Drawing.Point(88, 56);
            this.btnCambioColor.Name = "btnCambioColor";
            this.btnCambioColor.Size = new System.Drawing.Size(208, 40);
            this.btnCambioColor.TabIndex = 0;
            this.btnCambioColor.Text = "Cambiar Color del fondo";
            this.btnCambioColor.UseVisualStyleBackColor = true;
            this.btnCambioColor.Click += new System.EventHandler(this.btnCambioColor_Click);
            // 
            // btnCambiarLetra
            // 
            this.btnCambiarLetra.Location = new System.Drawing.Point(312, 56);
            this.btnCambiarLetra.Name = "btnCambiarLetra";
            this.btnCambiarLetra.Size = new System.Drawing.Size(208, 40);
            this.btnCambiarLetra.TabIndex = 1;
            this.btnCambiarLetra.Text = "Elegir Tipo de letra";
            this.btnCambiarLetra.UseVisualStyleBackColor = true;
            this.btnCambiarLetra.Click += new System.EventHandler(this.btnCambiarLetra_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Probando";
            // 
            // frmColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCambiarLetra);
            this.Controls.Add(this.btnCambioColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmColor";
            this.Text = "frmColor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColorDialog colorDialog1;
        private Button btnCambioColor;
        private Button btnCambiarLetra;
        private TextBox textBox1;
    }
}