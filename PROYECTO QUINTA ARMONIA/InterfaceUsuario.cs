using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static PdfSharp.Capabilities.Features;

namespace PROYECTO_QUINTA_ARMONIA
{
    public partial class InterfaceUsuario : Form
    {
        private string Nombre; //atributo necesario para mensaje de bienvenida en inicio de sesion
        private List<string> imagenes;
        private int cantProductos;

        public InterfaceUsuario()
        {
            InitializeComponent();
            imagenes = new List<string>();
        }

        public InterfaceUsuario(string nombre) //cosntructor para que salga mensaje de bienvenido al iniciar sesion en usuario
        {
            InitializeComponent();
            this.Nombre = nombre;
            MessageBox.Show($"Bienvenido {this.Nombre}", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            imagenes = new List<string>();

        }

        private void InterfaceUsuario_Load(object sender, EventArgs e)
        {
            MostrarImagenes();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close(); //regresa a la presentación 
        }

        private void buttonPagar_Click(object sender, EventArgs e) //se va al form de pago 
        {
        }

        private void mostrarInfoProducto(string imagen)
        {
            if (string.IsNullOrEmpty(imagen))
            {
                MessageBox.Show("El código de la imagen es inválido.");
                return;
            }
            richTextBoxInfo.Text = "";
            BaseDatos bd = new BaseDatos(); //instancia necesaria para concetar con la base de datos
            try
            {

                //obtien la info 
                string query = "SELECT nombre, descripcion, precio, existencias FROM inventario WHERE imagen= @imagen;";
                MySqlCommand command = new MySqlCommand(query, bd.Connection);

                command.Parameters.AddWithValue("@imagen", imagen); //se añade el codigo del producto
                MySqlDataReader reader = command.ExecuteReader(); //lee

                if (reader.Read())
                {
                    //extraer datos
                    string nombre = reader["nombre"].ToString() ?? "";
                    string descripcion = reader["descripcion"].ToString() ?? "";
                    string precio = reader["precio"].ToString() ?? "";
                    string existencias = reader["existencias"].ToString() ?? "";
                    //mostrar 
                    richTextBoxInfo.Rtf = @"{\rtf1\ansi 
                    \b Nombre:\b0  " + nombre + @"\line
                    \b Descripción:\b0  " + descripcion + @"\line
                    \b Precio:\b0  " + precio + @"\line
                    \b Existencias:\b0  " + existencias + @"}";

                }
                else
                {
                    richTextBoxInfo.Text = "No encontrado.";
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: {ex.Message}");
            }
            finally
            {
                bd.Disconnect();
            }
        }

        private void buttonYakult_Click(object sender, EventArgs e)
        {
            string cod = btn1.Tag?.ToString();
            if (!string.IsNullOrEmpty(cod))
                mostrarInfoProducto(cod);
        }

        private void patch_Click(object sender, EventArgs e)
        {

        }

        private void buttonLotus_Click(object sender, EventArgs e)
        {
            string cod = btn3.Tag?.ToString();
            if (!string.IsNullOrEmpty(cod))
                mostrarInfoProducto(cod);
        }

        public void MostrarImagenes()
        {
            BaseDatos obj = new BaseDatos();
            imagenes.Clear();
            imagenes = obj.NombreImagenes();
            cantProductos = imagenes.Count;
            obj.Disconnect();

            btn1.Image = null;
            btn2.Image = null;
            btn3.Image = null;
            btn4.Image = null;
            btn5.Image = null;
            btn6.Image = null;
            btn7.Image = null;
            btn8.Image = null;
            btn9.Image = null;
            btn10.Image = null;

            for (int i = 0; i < imagenes.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        this.btn1.BackgroundImage = System.Drawing.Image.FromFile(
    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[0]));
                        btn1.Tag = imagenes[0];
                        break;
                    case 1:
                        this.btn2.BackgroundImage = System.Drawing.Image.FromFile(
    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[1]));
                        btn2.Tag = imagenes[1];
                        break;
                    case 2:
                        this.btn3.BackgroundImage = System.Drawing.Image.FromFile(
    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[2]));
                        btn3.Tag = imagenes[2];
                        break;
                    case 3:
                        this.btn4.BackgroundImage = System.Drawing.Image.FromFile(
    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[3]));
                        btn4.Tag = imagenes[3];
                        break;
                    case 4:
                        this.btn5.BackgroundImage = System.Drawing.Image.FromFile(
    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[4]));
                        btn5.Tag = imagenes[4];
                        break;
                    case 5:
                        this.btn6.BackgroundImage = System.Drawing.Image.FromFile(
    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[5]));
                        btn6.Tag = imagenes[5];
                        break;
                    case 6:
                        this.btn7.BackgroundImage = System.Drawing.Image.FromFile(
    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[6]));
                        btn7.Tag = imagenes[6];
                        break;
                    case 7:
                        this.btn8.BackgroundImage = System.Drawing.Image.FromFile(
    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[7]));
                        btn8.Tag = imagenes[7];
                        break;
                    case 8:
                        this.btn9.BackgroundImage = System.Drawing.Image.FromFile(
    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[8]));
                        btn9.Tag = imagenes[8];
                        break;
                    case 9:
                        this.btn10.BackgroundImage = System.Drawing.Image.FromFile(
    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[9]));
                        btn10.Tag = imagenes[9];
                        break;
                }
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string cod = btn2.Tag?.ToString();
            if (!string.IsNullOrEmpty(cod))
                mostrarInfoProducto(cod);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string cod = btn4.Tag?.ToString();
            if (!string.IsNullOrEmpty(cod))
                mostrarInfoProducto(cod);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            string cod = btn5.Tag?.ToString();
            if (!string.IsNullOrEmpty(cod))
                mostrarInfoProducto(cod);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            string cod = btn6.Tag?.ToString();
            if (!string.IsNullOrEmpty(cod))
                mostrarInfoProducto(cod);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            string cod = btn7.Tag?.ToString();
            if (!string.IsNullOrEmpty(cod))
                mostrarInfoProducto(cod);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            string cod = btn8.Tag?.ToString();
            if (!string.IsNullOrEmpty(cod))
                mostrarInfoProducto(cod);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            string cod = btn9.Tag?.ToString();
            if (!string.IsNullOrEmpty(cod))
                mostrarInfoProducto(cod);
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            string cod = btn10.Tag?.ToString();
            if (!string.IsNullOrEmpty(cod))
                mostrarInfoProducto(cod);
        }

        private void buttonRedondoRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            ClaseMusica.Play();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            ClaseMusica.Pause();
        }
    }
}
