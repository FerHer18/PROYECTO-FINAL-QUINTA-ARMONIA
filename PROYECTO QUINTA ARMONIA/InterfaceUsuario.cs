using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
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

        private void mostrarInfoProducto(int codigo)
        {
            BaseDatos bd = new BaseDatos(); //instancia necesaria para concetar con la base de datos
            try
            {
                bd.Connect(); //abre conexión

                //obtien la info 
                string query = "SELECT nombre, descripcion, precio, existencias FROM inventario WHERE codigo= @codigo;";
                MySqlCommand command = new MySqlCommand(query, bd.Connection);

                command.Parameters.AddWithValue("@codigo", codigo); //se añade el codigo del producto
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
            mostrarInfoProducto(1);
        }

        private void patch_Click(object sender, EventArgs e)
        {

        }

        private void buttonLotus_Click(object sender, EventArgs e)
        {

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
    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[0])); break;
                    case 1:
                        this.btn2.BackgroundImage = System.Drawing.Image.FromFile(
    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[1])); break;
                    case 2:
                        this.btn3.BackgroundImage = System.Drawing.Image.FromFile(
    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[2])); break;
                    case 3:
                        this.btn4.BackgroundImage = System.Drawing.Image.FromFile(
    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[3])); break;
                    case 4:
                        this.btn5.BackgroundImage = System.Drawing.Image.FromFile(
    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[4])); break;
                    case 5:
                        this.btn6.BackgroundImage = System.Drawing.Image.FromFile(
    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[5])); break;
                    case 6:
                        this.btn7.BackgroundImage = System.Drawing.Image.FromFile(
    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[6])); break;
                    case 7:
                        this.btn8.BackgroundImage = System.Drawing.Image.FromFile(
    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[7])); break;
                    case 8:
                        this.btn9.BackgroundImage = System.Drawing.Image.FromFile(
    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[8])); break;
                    case 9:
                        this.btn10.BackgroundImage = System.Drawing.Image.FromFile(
    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[9])); break;
                }
            }
        }
    }
}
