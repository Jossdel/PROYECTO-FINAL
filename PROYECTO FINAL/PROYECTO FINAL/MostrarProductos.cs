using System;
using System.Windows.Forms;

namespace PROYECTO_FINAL
{
    public partial class MostrarProductos : Form
    {
        public MostrarProductos()
        {
            InitializeComponent();
        }

        private void MostrarProductos_Load(object sender, EventArgs e)
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = FrmPrincipal.listaProductos;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
