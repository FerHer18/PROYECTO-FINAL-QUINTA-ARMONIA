using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PROYECTO_QUINTA_ARMONIA
{
    public partial class FormModificar : Form
    {
        List<ClassProductos> datos;
        public FormModificar()
        {
            InitializeComponent();
        }

        public void mostrarDatos(string img)
        {
            InitializeComponent();
            BaseDatos obj = new BaseDatos();
            datos = obj.obtenerProd(img);

            if (datos.Count > 0)
            {
                var producto = datos[0];

                this.textBoxModifName.Text = producto.Nombre;
                this.textBoxModifDescr.Text = producto.Descripcion;
                this.textBoxModifPrecio.Text = producto.Precio.ToString();
                this.textBoxModifCant.Text = producto.Existencias.ToString();
                this.textBoxCodigo.Text = producto.Codigo.ToString();
            }
        }

        private void FormModificar_Load(object sender, EventArgs e)
        {
            labelHola.Text = "Hola, Admin!";
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
