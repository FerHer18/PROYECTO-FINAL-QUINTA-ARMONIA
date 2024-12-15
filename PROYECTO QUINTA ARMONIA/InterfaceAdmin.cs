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
            labelHola.Text = "Hola,Admin!";
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
            //imagenes.Clear();
            imagenes = obj.NombreImagenes();
            cantProductos = imagenes.Count;
            obj.Disconnect();

            Button[] botones = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10 };

            for (int i = 0; i < botones.Length; i++)
            {
                if (i < imagenes.Count)
                {
                    botones[i].Tag = imagenes[i];
                    botones[i].BackgroundImage = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[i]));
                }
                else
                {
                    botones[i].BackgroundImage = null;
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

        private void buttonRedondoGrafica2_Click(object sender, EventArgs e)
        {
            Grafica obj = new Grafica();
            this.Hide();
            obj.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Button btn = sender as Button;
            string dirImg = button1.Tag?.ToString() ?? "";
            if (!string.IsNullOrEmpty(dirImg))
            {
                FormModificar Fm = new FormModificar();
                Fm.mostrarDatos(dirImg);
                this.Hide();
                Fm.ShowDialog();
                this.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Button btn = sender as Button;
            string dirImg = button2.Tag?.ToString() ?? "";
            if (!string.IsNullOrEmpty(dirImg))
            {
                FormModificar Fm = new FormModificar();
                Fm.mostrarDatos(dirImg);
                this.Hide();
                Fm.ShowDialog();
                this.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Button btn = sender as Button;
            string dirImg = button3.Tag?.ToString() ?? "";
            if (!string.IsNullOrEmpty(dirImg))
            {
                FormModificar Fm = new FormModificar();
                Fm.mostrarDatos(dirImg);
                this.Hide();
                Fm.ShowDialog();
                this.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Button btn = sender as Button;
            string dirImg = button4.Tag?.ToString() ?? "";
            if (!string.IsNullOrEmpty(dirImg))
            {
                FormModificar Fm = new FormModificar();
                Fm.mostrarDatos(dirImg);
                this.Hide();
                Fm.ShowDialog();
                this.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Button btn = sender as Button;
            string dirImg = button5.Tag?.ToString() ?? "";
            if (!string.IsNullOrEmpty(dirImg))
            {
                FormModificar Fm = new FormModificar();
                Fm.mostrarDatos(dirImg);
                this.Hide();
                Fm.ShowDialog();
                this.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Button btn = sender as Button;
            string dirImg = button6.Tag?.ToString() ?? "";
            if (!string.IsNullOrEmpty(dirImg))
            {
                FormModificar Fm = new FormModificar();
                Fm.mostrarDatos(dirImg);
                this.Hide();
                Fm.ShowDialog();
                this.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Button btn = sender as Button;
            string dirImg = button7.Tag?.ToString() ?? "";
            if (!string.IsNullOrEmpty(dirImg))
            {
                FormModificar Fm = new FormModificar();
                Fm.mostrarDatos(dirImg);
                this.Hide();
                Fm.ShowDialog();
                this.Show();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Button btn = sender as Button;
            string dirImg = button8.Tag?.ToString() ?? "";
            if (!string.IsNullOrEmpty(dirImg))
            {
                FormModificar Fm = new FormModificar();
                Fm.mostrarDatos(dirImg);
                this.Hide();
                Fm.ShowDialog();
                this.Show();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string dirImg = button9.Tag?.ToString() ?? "";
            if (!string.IsNullOrEmpty(dirImg))
            {
                FormModificar Fm = new FormModificar();
                Fm.mostrarDatos(dirImg);
                this.Hide();
                Fm.ShowDialog();
                this.Show();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string dirImg = button10.Tag?.ToString() ?? "";
            if (!string.IsNullOrEmpty(dirImg))
            {
                FormModificar Fm = new FormModificar();
                Fm.mostrarDatos(dirImg);
                this.Hide();
                Fm.ShowDialog();
                this.Show();
            }
        }
    }
}
