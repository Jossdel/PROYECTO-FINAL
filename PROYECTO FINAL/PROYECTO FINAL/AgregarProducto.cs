using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PROYECTO_FINAL
{
    public partial class AgregarProducto : Form
    {
        private List<string> listaCategorias;

        public AgregarProducto()
        {
            InitializeComponent(); // 👈 este método viene del archivo Designer
            CargarCategorias();    // 👈 aquí llenamos el comboBox una sola vez
        }

        private void CargarCategorias()
        {
            listaCategorias = new List<string>
            {
                "Alimentos",
                "Electrónica",
                "Ropa"
            };

            comboBoxCategoria.DataSource = listaCategorias;
        }
        private void comboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)

        {
            string categoriaSeleccionada = comboBoxCategoria.SelectedItem?.ToString();
            MessageBox.Show("Categoría seleccionada: " + categoriaSeleccionada);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // No se hace nada aún
        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
