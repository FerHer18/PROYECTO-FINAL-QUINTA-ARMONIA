using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PdfSharp.Capabilities.Features;
using System.IO; //sirve para manejar el path.combine

namespace PROYECTO_QUINTA_ARMONIA
{
    public partial class FormEliminar : Form
    {
        private List<string> imagenes = new List<string>();
        private int cantProductos;
        public FormEliminar()
        {
            InitializeComponent();
           // imagenes = new List<string>();
        }

        private void buttonRedondoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRedondoEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                BaseDatos obj = new BaseDatos();
                int codigo = Convert.ToInt32(this.textBoxBuscarCodigo.Text);
                obj.eliminar(codigo);

                this.textBoxBuscarCodigo.Text = string.Empty;   //limpia, es lo mismo que poner = "";
                this.textBoxBuscarCodigo.PlaceholderText = "Codigo de producto";
                obj.Disconnect();

                MessageBox.Show("Producto eliminado correctamente.", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormEliminar_Load(object sender, EventArgs e)
        {

        }

        private void textBoxBuscarCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void mostrarImg(int codigo)
        {
            try
            {
                BaseDatos obj = new BaseDatos();
                imagenes = obj.NombreImagenes();
                cantProductos = imagenes.Count;
                obj.Disconnect();

                pictureBox1.Image = null; 
                for (int i = 0; i < cantProductos; i++)
                {
                    if (i + 1 == codigo) 
                    {
                        string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[i]);
                        if (File.Exists(imagePath))
                        {
                            pictureBox1.Image = System.Drawing.Image.FromFile(imagePath);
                        }
                        else
                        {
                            MessageBox.Show("La imagen asociada al producto no se encontró en el sistema.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        return; // Salir del método una vez encontrada la imagen.
                    }
                }

                // Si se termina el bucle sin encontrar una coincidencia:
                MessageBox.Show("No se encontró una imagen asociada al código ingresado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonDatAct_Click(object sender, EventArgs e)
        {
            try
            {
                BaseDatos obj = new BaseDatos();
                int codigo = Convert.ToInt32(this.textBoxBuscarCodigo.Text);

                ClassProductos aux = obj.consultarIndividual(codigo);
                this.textBoxElimCod.Text = aux.Codigo.ToString();

                mostrarImg(aux.Codigo);

                obj.Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar los datos del producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
