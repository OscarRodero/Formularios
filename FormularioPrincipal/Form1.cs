namespace FormularioPrincipal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTextBox_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                DialogResult rs = MessageBox.Show("¿Desea cerrar el formulario?", "¡Atención!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    this.MdiChildren[0].Close();
                    frmTextBox n = new frmTextBox();
                    n.MdiParent = this;
                    n.Dock = DockStyle.Fill;
                    n.Show();
                }
            }
            else
            {
                frmTextBox n = new frmTextBox();
                n.MdiParent = this;
                n.Dock = DockStyle.Fill;
                n.Show();
            }
        }

        private void btnTriangulos_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                DialogResult rs = MessageBox.Show("¿Desea cerrar el formulario?", "¡Atención!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    this.MdiChildren[0].Close();
                    frmTriangulos n = new frmTriangulos();
                    n.MdiParent = this;
                    n.Dock = DockStyle.Fill;
                    n.Show();
                }
            }
            else
            {
                frmTriangulos n = new frmTriangulos();
                n.MdiParent = this;
                n.Dock = DockStyle.Fill;
                n.Show();
            }

        }

        private void btnColores_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                DialogResult rs = MessageBox.Show("¿Desea cerrar el formulario?", "¡Atención!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    this.MdiChildren[0].Close();
                    frmColor n = new frmColor();
                    n.MdiParent = this;
                    n.Dock = DockStyle.Fill;
                    n.Show();
                }
            }
            else
            {
                frmColor n = new frmColor();
                n.MdiParent = this;
                n.Dock = DockStyle.Fill;
                n.Show();
            }
        }

        private void btnListas_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                DialogResult rs = MessageBox.Show("¿Desea cerrar el formulario?", "¡Atención!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    this.MdiChildren[0].Close();
                    frmListas n = new frmListas();
                    n.MdiParent = this;
                    n.Dock = DockStyle.Fill;
                    n.Show();
                }
            }
            else
            {
                frmListas n = new frmListas();
                n.MdiParent = this;
                n.Dock = DockStyle.Fill;
                n.Show();
            }
        }

        private void btnCajas_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                DialogResult rs = MessageBox.Show("¿Desea cerrar el formulario?", "¡Atención!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    this.MdiChildren[0].Close();
                    frmCajas n = new frmCajas();
                    n.MdiParent = this;
                    n.Dock = DockStyle.Fill;
                    n.Show();
                }
            }
            else
            {
                frmCajas n = new frmCajas();
                n.MdiParent = this;
                n.Dock = DockStyle.Fill;
                n.Show();
            }
        }
        private void btnComboBox_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                DialogResult rs = MessageBox.Show("¿Desea cerrar el formulario?", "¡Atención!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    this.MdiChildren[0].Close();
                    frmComboBox n = new frmComboBox();
                    n.MdiParent = this;
                    n.Dock = DockStyle.Fill;
                    n.Show();
                }
            }
            else
            {
                frmComboBox n = new frmComboBox();
                n.MdiParent = this;
                n.Dock = DockStyle.Fill;
                n.Show();
            }
        }
        private void btnCalendarios_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                DialogResult rs = MessageBox.Show("¿Desea cerrar el formulario?", "¡Atención!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    this.MdiChildren[0].Close();
                    frmCalendario n = new frmCalendario();
                    n.MdiParent = this;
                    n.Dock = DockStyle.Fill;
                    n.Show();
                }
            }
            else
            {
                frmCalendario n = new frmCalendario();
                n.MdiParent = this;
                n.Dock = DockStyle.Fill;
                n.Show();
            }
        }

    }
}