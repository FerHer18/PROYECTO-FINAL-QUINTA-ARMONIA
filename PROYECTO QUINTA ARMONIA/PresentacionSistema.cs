using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Media;

namespace PROYECTO_QUINTA_ARMONIA
{
    public partial class PresentacionSistema : Form
    {
        private WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        public PresentacionSistema()
        {
            InitializeComponent();
        }

        private void PresentacionSistema_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1358, 869); //Tamaño fijo del formulario
            this.AutoSize = false; //Evita redimensionamiento automático
            this.AutoScaleMode = AutoScaleMode.None; //Desactiva escalado automático
            this.MaximumSize = this.Size; //Establece un tamaño máximo igual al tamaño fijo
            this.MinimumSize = this.Size; //Establece un tamaño mínimo igual al tamaño fijo
            this.AutoScroll = true;

            var rutaArchivo = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "musica-fondo.mp3");
            try
            {
                player.URL = rutaArchivo;
                player.settings.volume = 100;
                player.controls.play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al reproducir el archivo: " + ex.Message);
            }
        }

        private void textBoxusuario_TextChanged(object sender, EventArgs e)
        {

        }

        public void login(string cuenta, string contraseña)
        {
            if (string.IsNullOrWhiteSpace(cuenta) || string.IsNullOrWhiteSpace(contraseña)) //verifica que haya algo en los textBox
            {
                MessageBox.Show("Complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); //mensaje de error si es null
                return;
            }

            BaseDatos bd = new BaseDatos(); //instancia necesaria para concetar con la base de datos 
            try
            {
                //consulta en la tabla de usuarios 
                string query = "SELECT * FROM usuarios WHERE Cuenta = @Cuenta AND Contraseña = @Contraseña;";
                MySqlCommand command = new MySqlCommand(query, bd.Connection);

                //parametros para la consulta
                command.Parameters.AddWithValue("@Cuenta", cuenta);
                command.Parameters.AddWithValue("@Contraseña", contraseña);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows) //verifica si se devolvio algo después de la consulta 
                    {
                        MessageBox.Show("---> BIENVENIDO A QUINTA ARMONIA <---"); //en caso de que los datos sean correctos 
                        while (reader.Read())
                        {
                            string tipo = reader["Cuenta"].ToString();

                            if (tipo == "admin" || tipo == "admin1") //si es admin
                            {
                                string nombreAdm = reader["Nombre"].ToString();
                                this.Hide(); //se esconde el form de presentación 
                                InterfaceAdmin interfaceAdm = new InterfaceAdmin(nombreAdm); //se le manda el nombre de la persona que se logeo
                                interfaceAdm.ShowDialog(); //se ejecuta el form admin y regresa a la siguiente instruccion
                                this.Show(); //regresa a la presentación
                            }
                            else if (tipo == "usuario1" || tipo == "guest" || tipo == "usuario2" || tipo == "usuario3" || tipo == "usuario4") //si es usuario o invitado
                            {
                                string nombreUs = reader["Nombre"].ToString();
                                botonPlay interfaceUsu = new botonPlay(nombreUs);
                                this.Hide();
                                interfaceUsu.ShowDialog();
                                this.Show();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Datos incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                bd.Disconnect();
            }
        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            login(textBoxusuario.Text, textBox2contraseña.Text);

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        public void button1_Click(object sender, EventArgs e)
        {
            player.controls.play();
        }

        public void btnPause_Click(object sender, EventArgs e)
        {
            player.controls.pause();
        }
    }
}
