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
    public partial class frmComboBox : Form
    {
        public frmComboBox()
        {
            InitializeComponent();
            CBDropDown.Items.Add("Amarillo");
            CBDropDown.Items.Add("Negro");
            CBDropDown.Items.Add("Rojo");
            CBDropDown.Items.Add("Verde");
            CBDropDownList.Items.Add("Verde");
            CBEstiloSimple.Items.Add("Amarillo");
            CBEstiloSimple.Items.Add("Negro");
            CBEstiloSimple.Items.Add("Rojo");
            CBEstiloSimple.Items.Add("Verde");
        }

        private void CBDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < CBDropDown.Items.Count; i++) {
                if (CBDropDown.SelectedIndex == i) { 
                    TBColorElegido.Text= CBDropDown.Items[i].ToString();
                }
            }
        }
        private void CBDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < CBDropDownList.Items.Count; i++)
            {
                if (CBDropDownList.SelectedIndex == i)
                {
                    TBColorElegido.Text = CBDropDownList.Items[i].ToString();
                }
            }
        }

        private void CBEstiloSimple_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < CBEstiloSimple.Items.Count; i++)
            {
                if (CBEstiloSimple.SelectedIndex == i)
                {
                    TBColorElegido.Text = CBEstiloSimple.Items[i].ToString();
                }
            }

        }

        private void btnAñadirADropDownList_Click(object sender, EventArgs e)
        {
            CBDropDownList.Items.Add(TBAñadirColor.Text);
        }
    }
}
