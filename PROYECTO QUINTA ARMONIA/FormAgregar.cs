﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PROYECTO_QUINTA_ARMONIA
{
    public partial class FormAgregar : Form
    {
        private string nomImagen = "";
        private string nomImagenNo = "";
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
            labelHola.Text = "Hola,Admin!";
        }

        private void buttonRedondoConfirmar_Click(object sender, EventArgs e)
        {
            int id;
            string nombre;
            string descripcion;
            float precio;
            int existencias;
            string imagen;
            string imagenNo;

            id = Convert.ToInt32(this.textBoxCodigo.Text);
            nombre = this.textBoxNombre.Text;
            descripcion = this.textBoxDescrip.Text;
            precio = Convert.ToSingle(this.textBoxPrecio.Text);
            existencias = Convert.ToInt32(this.textBoxExistencias.Text);
            imagen = this.nomImagen;
            imagenNo = this.nomImagenNo;

            BaseDatos obj = new BaseDatos();
            obj.guardar(id, nombre, descripcion, precio, existencias, imagen, imagenNo);
            limpiarGuardar();
            obj.Disconnect();
        }

        public void limpiarGuardar()
        {
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
            this.picBoxImagen.Image = null;
            this.picBoxImagenNo.Image = null;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void buttonRedondo1_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagen = new OpenFileDialog();

            //abrimos el explorador de archivos de windowa
            if (abrirImagen.ShowDialog() == DialogResult.OK)
            {
                picBoxImagenNo.ImageLocation = abrirImagen.FileName;
                picBoxImagenNo.SizeMode = PictureBoxSizeMode.StretchImage; //adaptar la imagen al tamaño del picture box
                this.nomImagenNo = Path.GetFileName(abrirImagen.FileName);
            }
        }
    }
}
