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

        public MySqlConnection Connection // Propiedad pública para acceder a la conexión
        {
            get { return connection; }
        }

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

        public void guardar(int codigo, string nombre, string descripcion, float precio, int existencias, string imagen)
        {
            string query = "";
            try
            {
                query = "INSERT INTO inventario (codigo, nombre, descripcion, precio, existencias, imagen) VALUES ("
                       + "'" + codigo + "',"
                       + "'" + nombre + "',"
                       + "'" + descripcion + "',"
                       + "'" + precio + "',"
                       + "'" + existencias + "',"
                       + "'" + imagen + "')";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show(query + "Registro guardado correctamente.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
                this.Disconnect();
            }
        }

        public void eliminar(int cod)
        {
            string query = "";
            try
            {
                query = "DELETE FROM inventario WHERE codigo = " + cod + ";";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show(query + "\nRegistro Eliminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(query + "\nError: " + ex.Message);
                this.Disconnect();
            }
        }

        public List<string> NombreImagenes()
        {
            List<string> nombres = new List<string>();

            try
            {
                string query = "SELECT imagen FROM inventario";
                MySqlCommand command = new MySqlCommand(query, this.connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    nombres.Add(reader["imagen"].ToString() ?? "");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }

            return nombres;
        }
    }
}
