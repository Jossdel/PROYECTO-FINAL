using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_FINAL
{
    public partial class AgregarProducto : Form
    {
        private object listaCategorias;

        public AgregarProducto()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCategoria.Items.Add("Alimentos");
            comboBoxCategoria.Items.Add("Electrónica");
            comboBoxCategoria.Items.Add("Ropa");

            
            comboBoxCategoria.DataSource = listaCategorias;

            
            string categoriaSeleccionada = comboBoxCategoria.SelectedItem.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
