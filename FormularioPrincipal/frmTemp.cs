using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioPrincipal
{
    public partial class frmTemp : Form
    {
        public frmTemp()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NUD1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NUD1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(229, 80);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(258, 23);
            this.txtBox1.TabIndex = 0;
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(229, 141);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.ReadOnly = true;
            this.txtBox2.Size = new System.Drawing.Size(258, 23);
            this.txtBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Indica el intervalo, en segundos, que quieres que cambiel a palabra de un cuadro " +
    "de texto al otro:";
            // 
            // NUD1
            // 
            this.NUD1.Location = new System.Drawing.Point(229, 260);
            this.NUD1.Name = "NUD1";
            this.NUD1.Size = new System.Drawing.Size(258, 23);
            this.NUD1.TabIndex = 3;
            this.NUD1.ValueChanged += new System.EventHandler(this.NUD1_ValueChanged);
            // 
            // frmTemp
            // 
            this.ClientSize = new System.Drawing.Size(782, 390);
            this.Controls.Add(this.NUD1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.txtBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTemp";
            this.Load += new System.EventHandler(this.frmTemp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUD1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmTemp_Load(object sender, EventArgs e)
        {

        }

        private TextBox txtBox1;
        private TextBox txtBox2;
        private Label label1;
        private NumericUpDown NUD1;

        private void NUD1_ValueChanged(object sender, EventArgs e)
        {
            NUD1.Value = 1;
            NUD1.Maximum = 10;
            NUD1.Minimum = 1;
        }
    }
}
