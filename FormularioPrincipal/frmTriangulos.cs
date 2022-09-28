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
    public partial class frmTriangulos : Form
    {
        public frmTriangulos()
        {
            InitializeComponent();
        }

        private void AveriguarTriangulo_Click(object sender, EventArgs e)
        {
            if (Lado1 == Lado2 && Lado2 == Lado3)
            {
                Respuesta.Text = "El triángulo es Equilátero";
            }
            else if (Lado1 == Lado2 || Lado2 == Lado3 || Lado1 == Lado3)
            {
                Respuesta.Text = "El triángulo es Isósceles";
            }
            else {
                Respuesta.Text = "El triángulo es Escaleno";
            }
        }
    }
}
