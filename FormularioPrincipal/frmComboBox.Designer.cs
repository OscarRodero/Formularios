namespace FormularioPrincipal
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
            this.CBDropDown = new System.Windows.Forms.ComboBox();
            this.CBDropDownList = new System.Windows.Forms.ComboBox();
            this.CBEstiloSimple = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBColorElegido = new System.Windows.Forms.TextBox();
            this.TBAñadirColor = new System.Windows.Forms.TextBox();
            this.btnAñadirADropDownList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CBDropDown
            // 
            this.CBDropDown.FormattingEnabled = true;
            this.CBDropDown.Location = new System.Drawing.Point(32, 56);
            this.CBDropDown.Name = "CBDropDown";
            this.CBDropDown.Size = new System.Drawing.Size(121, 23);
            this.CBDropDown.TabIndex = 0;
            this.CBDropDown.SelectedIndexChanged += new System.EventHandler(this.CBDropDown_SelectedIndexChanged);
            // 
            // CBDropDownList
            // 
            this.CBDropDownList.FormattingEnabled = true;
            this.CBDropDownList.Location = new System.Drawing.Point(176, 56);
            this.CBDropDownList.Name = "CBDropDownList";
            this.CBDropDownList.Size = new System.Drawing.Size(121, 23);
            this.CBDropDownList.TabIndex = 1;
            this.CBDropDownList.SelectedIndexChanged += new System.EventHandler(this.CBDropDownList_SelectedIndexChanged);
            // 
            // CBEstiloSimple
            // 
            this.CBEstiloSimple.FormattingEnabled = true;
            this.CBEstiloSimple.Location = new System.Drawing.Point(320, 56);
            this.CBEstiloSimple.Name = "CBEstiloSimple";
            this.CBEstiloSimple.Size = new System.Drawing.Size(121, 23);
            this.CBEstiloSimple.TabIndex = 2;
            this.CBEstiloSimple.SelectedIndexChanged += new System.EventHandler(this.CBEstiloSimple_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Estilo DropDown";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Estilo DropDownList";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "EstiloSimple";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Muestra el último color elegido: ";
            // 
            // TBColorElegido
            // 
            this.TBColorElegido.Location = new System.Drawing.Point(208, 144);
            this.TBColorElegido.Name = "TBColorElegido";
            this.TBColorElegido.Size = new System.Drawing.Size(184, 23);
            this.TBColorElegido.TabIndex = 7;
            // 
            // TBAñadirColor
            // 
            this.TBAñadirColor.Location = new System.Drawing.Point(32, 200);
            this.TBAñadirColor.Name = "TBAñadirColor";
            this.TBAñadirColor.Size = new System.Drawing.Size(160, 23);
            this.TBAñadirColor.TabIndex = 8;
            // 
            // btnAñadirADropDownList
            // 
            this.btnAñadirADropDownList.Location = new System.Drawing.Point(200, 200);
            this.btnAñadirADropDownList.Name = "btnAñadirADropDownList";
            this.btnAñadirADropDownList.Size = new System.Drawing.Size(184, 23);
            this.btnAñadirADropDownList.TabIndex = 9;
            this.btnAñadirADropDownList.Text = "Añadir a DropDownList";
            this.btnAñadirADropDownList.UseVisualStyleBackColor = true;
            this.btnAñadirADropDownList.Click += new System.EventHandler(this.btnAñadirADropDownList_Click);
            // 
            // frmListas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAñadirADropDownList);
            this.Controls.Add(this.TBAñadirColor);
            this.Controls.Add(this.TBColorElegido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBEstiloSimple);
            this.Controls.Add(this.CBDropDownList);
            this.Controls.Add(this.CBDropDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListas";
            this.Text = "frmListas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox CBDropDown;
        private ComboBox CBDropDownList;
        private ComboBox CBEstiloSimple;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TBColorElegido;
        private TextBox TBAñadirColor;
        private Button btnAñadirADropDownList;
    }
}