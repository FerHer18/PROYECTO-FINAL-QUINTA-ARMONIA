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

namespace PROYECTO_QUINTA_ARMONIA
{
    public partial class InterfaceUsuario : Form
    {
        private string Nombre; //atributo necesario para mensaje de bienvenida en inicio de sesion
        public InterfaceUsuario()
        {
            InitializeComponent();
        }

        public InterfaceUsuario(string nombre) //cosntructor para que salga mensaje de bienvenido al iniciar sesion en usuario
        {
            InitializeComponent();
            this.Nombre = nombre;
            MessageBox.Show($"Bienvenido {this.Nombre}", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void InterfaceUsuario_Load(object sender, EventArgs e)
        {

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
                    string nombre = reader["nombre"].ToString();
                    string descripcion = reader["descripcion"].ToString();
                    string precio = reader["precio"].ToString();
                    string existencias = reader["existencias"].ToString();
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

    }
}
