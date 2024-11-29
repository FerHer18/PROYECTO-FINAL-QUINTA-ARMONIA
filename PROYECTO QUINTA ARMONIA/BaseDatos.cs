using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_QUINTA_ARMONIA
{
    public class BaseDatos
    {
        private MySqlConnection connection;
        public BaseDatos()
        {
            this.Connect();
        }

        public void Connect()
        {
            string cadena = "Server=localhost; Database=quinta_armonia; User=root; Password=; SslMode=none;";
            try
            {
                connection = new MySqlConnection(cadena);
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Disconnect()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
