using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PdfSharp.Capabilities.Features;

namespace PROYECTO_QUINTA_ARMONIA
{
    public partial class InterfaceAdmin : Form
    {
        private string Nombre; //atributo necesario para mensaje de bienvenida en inicio de sesion
        private int cantProductos;
        private List<string> imagenes;

        public InterfaceAdmin()
        {
            InitializeComponent();

        }

        public InterfaceAdmin(string nombre) //cosntructor para que salga mensaje de bienvenido al iniciar sesion en admin
        {
            InitializeComponent();
            this.Nombre = nombre;
            MessageBox.Show($"Bienvenido {this.Nombre}", "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            imagenes = new List<string>();
        }

        private void InterfaceAdmin_Load(object sender, EventArgs e)
        {
            mostrarImagenes();
        }

        private void buttonRedondoAgregar_Click(object sender, EventArgs e)
        {
            FormAgregar fA = new FormAgregar();
            this.Hide();
            fA.ShowDialog();
            this.Show();
            mostrarImagenes();
        }

        private void buttonRedondoEliminar_Click(object sender, EventArgs e)
        {
            if (this.cantProductos <= 6)
            {
                MessageBox.Show("Debe haber un mínimo de 6 articulos, no es posible eliminar");
            }
            else
            {
                FormEliminar fE = new FormEliminar();
                this.Hide();
                fE.ShowDialog();
                this.Show();
                mostrarImagenes();
            }
        }

        private void buttonRedondoRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        public void mostrarImagenes()
        {
            BaseDatos obj = new BaseDatos();
            imagenes.Clear();
            imagenes = obj.NombreImagenes();
            cantProductos = imagenes.Count;
            obj.Disconnect();

            picBox1.Image = null;
            picBox2.Image = null;
            picBox3.Image = null;
            picBox4.Image = null;
            picBox5.Image = null;
            picBox6.Image = null;
            picBox7.Image = null;
            picBox8.Image = null;
            picBox9.Image = null;
            picBox10.Image = null;

            for (int i = 0; i < imagenes.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        this.picBox1.Image = System.Drawing.Image.FromFile(
    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[0])); break;
                    case 1:
                        this.picBox2.Image = System.Drawing.Image.FromFile(
    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[1])); break;
                    case 2:
                        this.picBox3.Image = System.Drawing.Image.FromFile(
    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[2])); break;
                    case 3:
                        this.picBox4.Image = System.Drawing.Image.FromFile(
    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[3])); break;
                    case 4:
                        this.picBox5.Image = System.Drawing.Image.FromFile(
    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[4])); break;
                    case 5:
                        this.picBox6.Image = System.Drawing.Image.FromFile(
    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[5])); break;
                    case 6:
                        this.picBox7.Image = System.Drawing.Image.FromFile(
    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[6])); break;
                    case 7:
                        this.picBox8.Image = System.Drawing.Image.FromFile(
    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[7])); break;
                    case 8:
                        this.picBox9.Image = System.Drawing.Image.FromFile(
    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[8])); break;
                    case 9:
                        this.picBox10.Image = System.Drawing.Image.FromFile(
    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[9])); break;
                }
            }
        }

        private void buttonRedondoListaProd_Click(object sender, EventArgs e)
        {
            listadoProductos obj = new listadoProductos();
            this.Hide();
            obj.ShowDialog();
            this.Show();
        }

        private void buttonRedondoVentTot2_Click(object sender, EventArgs e)
        {
            ventasTotales obj = new ventasTotales();
            this.Hide();
            obj.ShowDialog();
            this.Show();
        }


        private void btnPlay_Click_1(object sender, EventArgs e)
        {
            ClaseMusica.Play();
        }

        private void btnPause_Click_1(object sender, EventArgs e)
        {
            ClaseMusica.Pause();
        }

        private void buttonRedondoModif_Click(object sender, EventArgs e)
        {
            FormModificar obj = new FormModificar();
            this.Hide();
            obj.ShowDialog();
            this.Show();
        }

        private void buttonRedondoGrafica2_Click(object sender, EventArgs e)
        {
            Grafica obj = new Grafica();
            this.Hide();
            obj.ShowDialog();
            this.Show();
        }
    }
}
