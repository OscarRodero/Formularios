namespace FormularioPrincipal
{
    partial class frmListas
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
            this.lstArticulos = new System.Windows.Forms.ListBox();
            this.chkBox_Ordenar = new System.Windows.Forms.CheckBox();
            this.chkBox_MostrarEnColumnas = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.TBAgregados = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RB_Extendida = new System.Windows.Forms.RadioButton();
            this.RB_Multiple = new System.Windows.Forms.RadioButton();
            this.RB_Simple = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTraspasar = new System.Windows.Forms.Button();
            this.btnSeleccionarElemento = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstTraspasados = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstArticulos
            // 
            this.lstArticulos.ColumnWidth = 50;
            this.lstArticulos.FormattingEnabled = true;
            this.lstArticulos.ItemHeight = 15;
            this.lstArticulos.Location = new System.Drawing.Point(24, 48);
            this.lstArticulos.Name = "lstArticulos";
            this.lstArticulos.Size = new System.Drawing.Size(200, 139);
            this.lstArticulos.TabIndex = 0;
            this.lstArticulos.SelectedIndexChanged += new System.EventHandler(this.lstArticulos_SelectedIndexChanged);
            // 
            // chkBox_Ordenar
            // 
            this.chkBox_Ordenar.AutoSize = true;
            this.chkBox_Ordenar.Location = new System.Drawing.Point(24, 200);
            this.chkBox_Ordenar.Name = "chkBox_Ordenar";
            this.chkBox_Ordenar.Size = new System.Drawing.Size(69, 19);
            this.chkBox_Ordenar.TabIndex = 1;
            this.chkBox_Ordenar.Text = "Ordenar";
            this.chkBox_Ordenar.UseVisualStyleBackColor = true;
            this.chkBox_Ordenar.CheckedChanged += new System.EventHandler(this.chkBox_Ordenar_CheckedChanged);
            // 
            // chkBox_MostrarEnColumnas
            // 
            this.chkBox_MostrarEnColumnas.AutoSize = true;
            this.chkBox_MostrarEnColumnas.Location = new System.Drawing.Point(24, 232);
            this.chkBox_MostrarEnColumnas.Name = "chkBox_MostrarEnColumnas";
            this.chkBox_MostrarEnColumnas.Size = new System.Drawing.Size(138, 19);
            this.chkBox_MostrarEnColumnas.TabIndex = 2;
            this.chkBox_MostrarEnColumnas.Text = "Mostrar en columnas";
            this.chkBox_MostrarEnColumnas.UseVisualStyleBackColor = true;
            this.chkBox_MostrarEnColumnas.CheckedChanged += new System.EventHandler(this.chkBox_MostrarEnColumnas_CheckedChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(24, 288);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(88, 40);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(136, 288);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 40);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // TBAgregados
            // 
            this.TBAgregados.Location = new System.Drawing.Point(24, 336);
            this.TBAgregados.Name = "TBAgregados";
            this.TBAgregados.Size = new System.Drawing.Size(200, 23);
            this.TBAgregados.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.RB_Extendida);
            this.panel1.Controls.Add(this.RB_Multiple);
            this.panel1.Controls.Add(this.RB_Simple);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(240, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 136);
            this.panel1.TabIndex = 6;
            // 
            // RB_Extendida
            // 
            this.RB_Extendida.AutoSize = true;
            this.RB_Extendida.Location = new System.Drawing.Point(8, 104);
            this.RB_Extendida.Name = "RB_Extendida";
            this.RB_Extendida.Size = new System.Drawing.Size(77, 19);
            this.RB_Extendida.TabIndex = 3;
            this.RB_Extendida.Text = "Extendida";
            this.RB_Extendida.UseVisualStyleBackColor = true;
            this.RB_Extendida.CheckedChanged += new System.EventHandler(this.RB_Extendida_CheckedChanged);
            // 
            // RB_Multiple
            // 
            this.RB_Multiple.AutoSize = true;
            this.RB_Multiple.Location = new System.Drawing.Point(8, 72);
            this.RB_Multiple.Name = "RB_Multiple";
            this.RB_Multiple.Size = new System.Drawing.Size(69, 19);
            this.RB_Multiple.TabIndex = 2;
            this.RB_Multiple.Text = "Múltiple";
            this.RB_Multiple.UseVisualStyleBackColor = true;
            // 
            // RB_Simple
            // 
            this.RB_Simple.AutoSize = true;
            this.RB_Simple.Checked = true;
            this.RB_Simple.Location = new System.Drawing.Point(8, 40);
            this.RB_Simple.Name = "RB_Simple";
            this.RB_Simple.Size = new System.Drawing.Size(61, 19);
            this.RB_Simple.TabIndex = 1;
            this.RB_Simple.TabStop = true;
            this.RB_Simple.Text = "Simple";
            this.RB_Simple.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de selección";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lista Artículos:";
            // 
            // btnTraspasar
            // 
            this.btnTraspasar.Location = new System.Drawing.Point(240, 200);
            this.btnTraspasar.Name = "btnTraspasar";
            this.btnTraspasar.Size = new System.Drawing.Size(144, 40);
            this.btnTraspasar.TabIndex = 8;
            this.btnTraspasar.Text = "TRASPASAR >>";
            this.btnTraspasar.UseVisualStyleBackColor = true;
            this.btnTraspasar.Click += new System.EventHandler(this.btnTraspasar_Click);
            // 
            // btnSeleccionarElemento
            // 
            this.btnSeleccionarElemento.Location = new System.Drawing.Point(240, 288);
            this.btnSeleccionarElemento.Name = "btnSeleccionarElemento";
            this.btnSeleccionarElemento.Size = new System.Drawing.Size(144, 72);
            this.btnSeleccionarElemento.TabIndex = 9;
            this.btnSeleccionarElemento.Text = "Seleccionar elemento de la posición seleccionada...";
            this.btnSeleccionarElemento.UseVisualStyleBackColor = true;
            this.btnSeleccionarElemento.Click += new System.EventHandler(this.btnSeleccionarElemento_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "LIMPIAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Artículos traspasados:";
            // 
            // lstTraspasados
            // 
            this.lstTraspasados.FormattingEnabled = true;
            this.lstTraspasados.ItemHeight = 15;
            this.lstTraspasados.Location = new System.Drawing.Point(392, 48);
            this.lstTraspasados.Name = "lstTraspasados";
            this.lstTraspasados.Size = new System.Drawing.Size(144, 139);
            this.lstTraspasados.TabIndex = 12;
            // 
            // frmListas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 386);
            this.Controls.Add(this.lstTraspasados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSeleccionarElemento);
            this.Controls.Add(this.btnTraspasar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TBAgregados);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.chkBox_MostrarEnColumnas);
            this.Controls.Add(this.chkBox_Ordenar);
            this.Controls.Add(this.lstArticulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListas";
            this.Text = "frmListas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstArticulos;
        private CheckBox chkBox_Ordenar;
        private CheckBox chkBox_MostrarEnColumnas;
        private Button btnAgregar;
        private Button btnBuscar;
        private TextBox TBAgregados;
        private Panel panel1;
        private RadioButton RB_Extendida;
        private RadioButton RB_Multiple;
        private RadioButton RB_Simple;
        private Label label1;
        private Label label2;
        private Button btnTraspasar;
        private Button btnSeleccionarElemento;
        private Button button1;
        private Label label3;
        private ListBox lstTraspasados;
    }
}