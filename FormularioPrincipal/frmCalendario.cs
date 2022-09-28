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
    public partial class frmCalendario : Form
    {
        public frmCalendario()
        {
            InitializeComponent();
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            mc.SelectionStart = dtp.Value;
        }

        private void mc_DateChanged(object sender, DateRangeEventArgs e)
        {
            dtp.Value = mc.SelectionStart;
        }
    }
}
