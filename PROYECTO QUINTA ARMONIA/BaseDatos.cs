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

        public bool Login(string cuenta, string contraseña, out string tipoUsuario, out string nombreUsuario)   //el out sirve para declarar paramteros de salida, es el return
        {
            tipoUsuario = string.Empty;
            nombreUsuario = string.Empty;

            if (string.IsNullOrWhiteSpace(cuenta) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                string query = "SELECT * FROM usuarios WHERE Cuenta = @Cuenta AND Contraseña = @Contraseña;";
                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@Cuenta", cuenta);
                command.Parameters.AddWithValue("@Contraseña", contraseña);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            tipoUsuario = reader["Cuenta"].ToString();
                            nombreUsuario = reader["Nombre"].ToString();
                        }
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Datos incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
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

        public List<ClassProductos> Consulta()
        {
            List<ClassProductos> info = new List<ClassProductos>();
            int id;
            string name = "";
            string desc = "";
            float precio;
            int existencias;
            ClassProductos item;

            try
            {
                string query = "SELECT * FROM inventario";
                MySqlCommand command = new MySqlCommand(query, this.connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["codigo"]);
                    name = Convert.ToString(reader["nombre"]) ?? "";
                    desc = Convert.ToString(reader["descripcion"]) ?? "";
                    precio = Convert.ToSingle(reader["precio"]);
                    existencias = Convert.ToInt32(reader["existencias"]);

                    item = new ClassProductos(id, name, desc, precio, existencias);
                    info.Add(item);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }

            return info;
        }

        public List<ClassProductos> obtenerInfoProducto(string imagen)
        {
            List<ClassProductos> info = new List<ClassProductos>();
            string name;
            string desc;
            float precio;
            int existencias;
            int codigo;
            ClassProductos item;

            try
            {
                string query = "SELECT codigo, nombre, descripcion, precio, existencias FROM inventario WHERE imagen= @imagen;";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@imagen", imagen);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //id = Convert.ToInt32(reader["codigo"]);
                    name = Convert.ToString(reader["nombre"]) ?? "";
                    desc = Convert.ToString(reader["descripcion"]) ?? "";
                    precio = Convert.ToSingle(reader["precio"]);
                    existencias = Convert.ToInt32(reader["existencias"]);
                    codigo = Convert.ToInt32(reader["codigo"]);
                    item = new ClassProductos(codigo, name, desc, precio, existencias);
                    info.Add(item);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }
            return info;
        }

        public List<ClaseUsuarios> ConsultaUsuarios()
        {
            List<ClaseUsuarios> info = new List<ClaseUsuarios>();
            int id;
            string name = "";
            string cuenta = "";
            string contra = "";
            float monto;
            ClaseUsuarios item;

            try
            {
                string query = "SELECT * FROM usuarios";
                MySqlCommand command = new MySqlCommand(query, this.connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["id"]);
                    name = Convert.ToString(reader["nombre"]) ?? "";
                    cuenta = Convert.ToString(reader["cuenta"]) ?? "";
                    contra = Convert.ToString(reader["contraseña"]) ?? "";
                    monto = Convert.ToSingle(reader["monto"]);

                    if (cuenta != "admin")
                    {
                        item = new ClaseUsuarios(id, name, cuenta, contra, monto);
                        info.Add(item);
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }

            return info;
        }

        public ClassProductos mostrarExistencias(int cod)
        {
            ClassProductos item = null;
            int codigo;
            try
            {
                string query = "SELECT * FROM inventario where id = " + cod + ";";
                MySqlCommand command = new MySqlCommand(query, this.connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    codigo = Convert.ToInt32(reader["cod"]);
                    item = new ClassProductos(codigo);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }
            return item;
        }

        public ClassProductos consultarIndividual(int cod)
        {
            ClassProductos item = null;
            int id;
            string name;
            string desc;
            float precio;
            int existencias;
            string imagen;
            try
            {
                string query = "SELECT * FROM inventario where id = " + cod + ";";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["codigo"]);
                    name = Convert.ToString(reader["nombre"]) ?? "";
                    desc = Convert.ToString(reader["descripcion"]) ?? "";
                    precio = Convert.ToInt32(reader["precio"]);
                    existencias = Convert.ToInt32(reader["existencias"]);
                    imagen = Convert.ToString(reader["imagen"]) ?? "";

                    item = new ClassProductos(id, name, desc, precio, existencias);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }
            return item;

        }


    }
}
