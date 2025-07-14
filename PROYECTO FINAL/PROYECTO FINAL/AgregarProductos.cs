using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PROYECTO_FINAL
{
    public partial class AgregarProductos : Form
    {
        private List<string> listaCategorias;

        public AgregarProductos()
        {
            InitializeComponent(); // Método generado automáticamente por el Designer
            CargarCategorias();    // Llenamos el comboBox con categorías al iniciar
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
            
        }

        private void txtnombreproducto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
