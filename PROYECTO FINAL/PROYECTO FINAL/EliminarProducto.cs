using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PROYECTO_FINAL
{
    public partial class EliminarProducto : Form
    {
        private List<string> listaProductos;

        public EliminarProducto()
        {
            InitializeComponent();
            CargarProductos();
        }

        private void CargarProductos()
        {
            listaProductos = new List<string> { "Arroz", "Laptop", "Camisa" };
            listBoxProductos.DataSource = null;
            listBoxProductos.DataSource = listaProductos;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            string productoSeleccionado = listBoxProductos.SelectedItem?.ToString();

            if (productoSeleccionado != null)
            {
                listaProductos.Remove(productoSeleccionado);
                listBoxProductos.DataSource = null;
                listBoxProductos.DataSource = listaProductos;
                MessageBox.Show("Producto eliminado: " + productoSeleccionado);
            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminar.");
            }
        }
    }
}
