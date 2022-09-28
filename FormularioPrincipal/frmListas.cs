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
    public partial class frmListas : Form
    {
        public frmListas()
        {
            InitializeComponent();
            lstArticulos.Items.Add("Mesa");
            lstArticulos.Items.Add("Coche");
            lstArticulos.Items.Add("Libro");
            lstArticulos.Items.Add("Maceta");
            lstArticulos.Items.Add("Silla");
            lstArticulos.Items.Add("Estantería");
            lstArticulos.Items.Add("Lámpara");
            lstArticulos.Items.Add("Rotuladores");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lstArticulos.Items.Add(TBAgregados.Text);
        }

        private void lstArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (TBAgregados.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debes escribir un artículo", "Error", MessageBoxButtons.OK);
            }
            else {
                int i;
                i = this.lstArticulos.FindStringExact(this.TBAgregados.Text);

                if (i == -1)
                {
                    MessageBox.Show("Ese artículo no está en la Lista", "Información", MessageBoxButtons.OK);
                }
                else {
                    this.lstArticulos.SelectedIndex = i;
                }
            }
        }

        private void chkBox_MostrarEnColumnas_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_Ordenar.Checked)
            {
                lstArticulos.MultiColumn = true;
            }
            else
            {
                lstArticulos.MultiColumn = false;
            }
        }

        private void btnSeleccionarElemento_Click(object sender, EventArgs e)
        {
            if (this.TBAgregados.Text.Equals(string.Empty)) {
                MessageBox.Show("Debes escribir un artículo", "Error", MessageBoxButtons.OK);
            }
            else {
                int i;
                i = Convert.ToInt32(this.TBAgregados.Text);
                if (i > 0 && i < this.lstArticulos.Items.Count) {
                    lstArticulos.SetSelected(i - 1, true);
                }
            }
        }

        private void RB_Extendida_CheckedChanged(object sender, EventArgs e)
        {
            lstArticulos.SelectionMode = SelectionMode.MultiExtended;
        }

        private void chkBox_Ordenar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_Ordenar.Checked)
            {
                lstArticulos.Sorted = true;
                this.Controls.Add(lstArticulos);
            }
            else {
                lstArticulos.Sorted = false;
            }
            
        }

        private void btnTraspasar_Click(object sender, EventArgs e)
        {
            while (lstArticulos.SelectedItems.Count>0) { 
                lstTraspasados.Items.Add(lstArticulos.SelectedItems[0]);
                lstArticulos.Items.Remove(lstArticulos.SelectedItems[0]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (lstTraspasados.Items.Count > 0) {
                lstTraspasados.Items.Remove(lstTraspasados.Items[0]);
            }
        }
    }
}
