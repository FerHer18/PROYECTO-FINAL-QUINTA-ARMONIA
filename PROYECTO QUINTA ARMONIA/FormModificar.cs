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
        private string imagen;
        private ClassProductos prod = null;
        public FormModificar(string imagen)
        {
            InitializeComponent();
            this.imagen = imagen;
        }

        public void mostrarDatos()
        {
            BaseDatos obj = new BaseDatos();
            prod = obj.obtenerProd(imagen);
            obj.Disconnect();
            this.textBoxModifName.Text = prod.Nombre;
            this.textBoxModifDescr.Text = prod.Descripcion;
            this.textBoxModifPrecio.Text = prod.Precio.ToString();
            this.textBoxModifCant.Text = prod.Existencias.ToString();
            this.textBoxCodigo.Text = prod.Codigo.ToString();


        }

        private void FormModificar_Load(object sender, EventArgs e)
        {
            labelHola.Text = "Hola, Admin!";
            mostrarDatos();
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int cod;
            string nombre;
            string desc;
            float precio;
            int existencias;


            nombre = this.textBoxModifName.Text;
            desc = this.textBoxModifDescr.Text;
            precio = Convert.ToSingle(this.textBoxModifPrecio.Text);    //para convertirlo a flotante
            existencias = Convert.ToInt32(this.textBoxModifCant.Text);
            cod = Convert.ToInt32(this.textBoxCodigo.Text);

            BaseDatos obj = new BaseDatos();
            obj.actualizar(cod, nombre, desc, precio, existencias);
            obj.Disconnect();
        }
    }
}
