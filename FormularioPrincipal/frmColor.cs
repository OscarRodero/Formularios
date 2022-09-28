using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormularioPrincipal
{
    public partial class frmColor : Form
    {
        public frmColor()
        {
            InitializeComponent();
        }

        private void btnCambioColor_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.AllowFullOpen = false;
            color.ShowHelp = true;
            if (color.ShowDialog() == DialogResult.OK)
                BackColor = color.Color;
        }

        private void btnCambiarLetra_Click(object sender, EventArgs e)
        {
            FontDialog fuente = new FontDialog();
            fuente.ShowColor = true;
            fuente.Font = textBox1.Font;
            fuente.Color = textBox1.ForeColor;
            if (fuente.ShowDialog() != DialogResult.Cancel)
            {
                textBox1.Font = fuente.Font;
                textBox1.ForeColor = fuente.Color;
            }
            ColorDialog color = new ColorDialog();
            color.AllowFullOpen = false;
            color.ShowHelp = true;
            color.Color = textBox1.ForeColor;

            if (color.ShowDialog() == DialogResult.OK)
                textBox1.BackColor = color.Color;
        }
    }
}
