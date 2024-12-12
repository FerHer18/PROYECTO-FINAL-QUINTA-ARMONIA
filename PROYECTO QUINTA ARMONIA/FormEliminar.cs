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
using System.IO; //sirve para manejar el path.combine, ya no se ocupa pero x

namespace PROYECTO_QUINTA_ARMONIA
{
    public partial class FormEliminar : Form
    {
        private List<string> imagenes = new List<string>();
        private int cantProductos;
        public FormEliminar()
        {
            InitializeComponent();
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

        private void buttonDatAct_Click(object sender, EventArgs e)
        {
            BaseDatos obj = new BaseDatos();
            ClassProductos aux = obj.obtenerIndividual(Convert.ToInt32(this.textBoxBuscarCodigo.Text));
           // this.textBoxElimName.Text = Convert.ToString(aux.Nombre);
           // limpiar();
            this.textBoxElimName.Text = aux.Nombre;
            this.textBoxElimDesc.Text = aux.Descripcion;
            this.textBoxElimPrecio.Text = Convert.ToString(aux.Precio);
            this.textBoxElimExist.Text = Convert.ToString(aux.Existencias);
            obj.Disconnect();
        }

        public void limpiar()
        {
            this.textBoxElimName.Text = string.Empty;
        }

        
    }
}
