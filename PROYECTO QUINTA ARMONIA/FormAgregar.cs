using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

namespace PROYECTO_QUINTA_ARMONIA
{
    public partial class FormAgregar : Form
    {
        private string nomImagen = "";
        public FormAgregar()
        {
            InitializeComponent();
        }

        private void buttonRedondoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAgregar_Load(object sender, EventArgs e)
        {

        }

        private void buttonRedondoConfirmar_Click(object sender, EventArgs e)
        {
            int id;
            string nombre;
            string descripcion;
            float precio;
            int existencias;
            string imagen;

            id = Convert.ToInt32(this.textBoxCodigo.Text);
            nombre = this.textBoxNombre.Text;
            descripcion = this.textBoxDescrip.Text;
            precio = Convert.ToSingle(this.textBoxPrecio.Text);
            existencias = Convert.ToInt32(this.textBoxExistencias.Text);
            imagen = this.nomImagen;

            BaseDatos obj = new BaseDatos();
            obj.guardar(id, nombre, descripcion, precio, existencias,imagen);
            limpiarGuardar();
            obj.Disconnect();
        }

        public void limpiarGuardar()
        {
            MessageBox.Show("Entre a limpiar");
            this.textBoxCodigo.Text = "";
            this.textBoxCodigo.PlaceholderText = "Codigo";
            this.textBoxNombre.Text = "";
            this.textBoxNombre.PlaceholderText = "Nombre";
            this.textBoxDescrip.Text = "";
            this.textBoxDescrip.PlaceholderText = "Descripcion";
            this.textBoxPrecio.Text = "";
            this.textBoxPrecio.PlaceholderText = "Precio";
            this.textBoxExistencias.Text = "";
            this.textBoxExistencias.PlaceholderText = "Existencias";
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagen = new OpenFileDialog();

            //abrimos el explorador de archivos de windowa
            if (abrirImagen.ShowDialog() == DialogResult.OK)
            {
                picBoxImagen.ImageLocation = abrirImagen.FileName;
                picBoxImagen.SizeMode = PictureBoxSizeMode.StretchImage; //adaptar la imagen al tamaño del picture box
                this.nomImagen = Path.GetFileName(abrirImagen.FileName);
            }
        }
    }
}
