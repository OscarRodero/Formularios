namespace FormularioPrincipal
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
            this.Lado1 = new System.Windows.Forms.TextBox();
            this.Lado2 = new System.Windows.Forms.TextBox();
            this.Lado3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AveriguarTriangulo = new System.Windows.Forms.Button();
            this.Respuesta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lado1
            // 
            this.Lado1.Location = new System.Drawing.Point(112, 48);
            this.Lado1.Name = "Lado1";
            this.Lado1.Size = new System.Drawing.Size(160, 23);
            this.Lado1.TabIndex = 0;
            // 
            // Lado2
            // 
            this.Lado2.Location = new System.Drawing.Point(112, 96);
            this.Lado2.Name = "Lado2";
            this.Lado2.Size = new System.Drawing.Size(160, 23);
            this.Lado2.TabIndex = 1;
            // 
            // Lado3
            // 
            this.Lado3.Location = new System.Drawing.Point(112, 144);
            this.Lado3.Name = "Lado3";
            this.Lado3.Size = new System.Drawing.Size(160, 23);
            this.Lado3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lado 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lado 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lado 3\r\n";
            // 
            // AveriguarTriangulo
            // 
            this.AveriguarTriangulo.Location = new System.Drawing.Point(112, 200);
            this.AveriguarTriangulo.Name = "AveriguarTriangulo";
            this.AveriguarTriangulo.Size = new System.Drawing.Size(160, 40);
            this.AveriguarTriangulo.TabIndex = 6;
            this.AveriguarTriangulo.Text = "¿Qué tipo de triángulo es?";
            this.AveriguarTriangulo.UseVisualStyleBackColor = true;
            this.AveriguarTriangulo.Click += new System.EventHandler(this.AveriguarTriangulo_Click);
            // 
            // Respuesta
            // 
            this.Respuesta.AutoSize = true;
            this.Respuesta.Location = new System.Drawing.Point(352, 104);
            this.Respuesta.Name = "Respuesta";
            this.Respuesta.Size = new System.Drawing.Size(86, 15);
            this.Respuesta.TabIndex = 7;
            this.Respuesta.Text = "¿¿¿Triángulo???";
            // 
            // frmTriangulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 286);
            this.Controls.Add(this.Respuesta);
            this.Controls.Add(this.AveriguarTriangulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lado3);
            this.Controls.Add(this.Lado2);
            this.Controls.Add(this.Lado1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTriangulos";
            this.Text = "frmTriangulos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Lado1;
        private TextBox Lado2;
        private TextBox Lado3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button AveriguarTriangulo;
        private Label Respuesta;
    }
}