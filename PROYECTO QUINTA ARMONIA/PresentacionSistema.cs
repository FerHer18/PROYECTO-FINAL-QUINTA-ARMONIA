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

namespace PROYECTO_QUINTA_ARMONIA
{
    public partial class PresentacionSistema : Form
    {
        
        public PresentacionSistema()
        {
            InitializeComponent();
            string rutaArchivo = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "musica-fondo.mp3");
            ClaseMusica.Load(rutaArchivo);
        }

        private void PresentacionSistema_Load(object sender, EventArgs e)
        {
            ClaseMusica.Play();
        }

        private void textBoxusuario_TextChanged(object sender, EventArgs e)
        {

        }

       
        public void login(string cuenta, string contraseña)
        {
            BaseDatos bd = new BaseDatos(); // Crear la instancia manualmente
            try
            {
                if (bd.Login(cuenta, contraseña, out string tipoUsuario, out string nombreUsuario, out int id)) //lo de out es que la funcion va a regresar
                                                                                                    //dos cosas y con la palabra out
                                                                                                    //no es necesario uso de cosas extra, y es mas facil
                {
                    MessageBox.Show("---> BIENVENIDO A QUINTA ARMONIA <---");

                    if (tipoUsuario == "admin")
                    {
                        this.Hide();
                        InterfaceAdmin interfaceAdm = new InterfaceAdmin(nombreUsuario);
                        interfaceAdm.ShowDialog();
                        //ResetForm();
                        this.textBoxusuario.Text = "";
                        this.textBoxusuario.PlaceholderText = "usuario";
                        this.textBox2contraseña.Text = "";
                        this.textBox2contraseña.PlaceholderText = "contraseña";
                        this.Show();
                    }
                    else if (tipoUsuario == "usuario1" || tipoUsuario == "guest" || tipoUsuario == "usuario2" || tipoUsuario == "usuario3" || tipoUsuario == "usuario4")
                    {
                        this.Hide();
                        InterfaceUsuario interfaceUsu = new InterfaceUsuario(nombreUsuario, id);
                        interfaceUsu.ShowDialog();
                        //ResetForm();
                        this.textBoxusuario.Text = "";
                        this.textBoxusuario.PlaceholderText = "usuario";
                        this.textBox2contraseña.Text = "";
                        this.textBox2contraseña.PlaceholderText = "contraseña";
                        this.Show();
                    }
                }
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
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        public void button1_Click(object sender, EventArgs e)
        {
            ClaseMusica.Play();
        }

        public void btnPause_Click(object sender, EventArgs e)
        {
            ClaseMusica.Pause();
        }
    }
}
