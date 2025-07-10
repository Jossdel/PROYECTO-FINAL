using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PROYECTO_FINAL
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        public class Producto
        {
            public string Nombre { get; set; }
            public decimal Precio { get; set; }
            public int Cantidad { get; set; }
        }
        public static List<Producto> listaProductos = new List<Producto>();



        // Evento que se ejecuta al cargar el formulario principal
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            // Puedes dejar este espacio para inicializaciones si es necesario
        }

        // Abrir formulario para agregar productos
        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarProducto form = new AgregarProducto();
            form.MdiParent = this;
            form.Show();
        }

        // Abrir formulario para mostrar productos
        private void mostrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarProductos form = new MostrarProductos();
            form.MdiParent = this;
            form.Show();
        }

        // Abrir formulario para actualizar productos
        private void actualizarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarProducto form = new ActualizarProducto();
            form.MdiParent = this;
            form.Show();
        }

        // Abrir formulario para eliminar productos
        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarProducto form = new EliminarProducto();
            form.MdiParent = this;
            form.Show();
        }

        // Exportar datos (pendiente de implementación)
        private void exportarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listaProductos.Count == 0)
            {
                MessageBox.Show("No hay productos para exportar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Archivo CSV (*.csv)|*.csv";
            guardar.Title = "Guardar archivo de productos";

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (System.IO.StreamWriter escritor = new System.IO.StreamWriter(guardar.FileName, false, Encoding.UTF8))
                    {
                        // Escribir encabezados
                        escritor.WriteLine("Nombre,Precio,Cantidad");

                        // Escribir datos de productos
                        foreach (var producto in listaProductos)
                        {
                            string linea = $"{producto.Nombre},{producto.Precio},{producto.Cantidad}";
                            escritor.WriteLine(linea);
                        }
                    }

                    MessageBox.Show("Datos exportados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar los datos:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // Cerrar la aplicación
        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
