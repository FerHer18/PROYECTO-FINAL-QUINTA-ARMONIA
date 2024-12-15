using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

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

        public bool Login(string cuenta, string contraseña, out string tipoUsuario, out string nombreUsuario, out int id)   //el out sirve para declarar paramteros de salida, es el return
        {
            tipoUsuario = string.Empty;
            nombreUsuario = string.Empty;
            id = 0;
            string codigo;
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
                            codigo = reader["id"].ToString();
                            id = int.Parse(codigo);
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

        public int existenciasProd(string imagen)
        {
            int existencias = 0;
            string query = "SELECT existencias FROM inventario WHERE imagen= @imagen";
            if (this.connection.State != System.Data.ConnectionState.Open)
            {
                this.connection.Open();
            }
            MySqlCommand command = new MySqlCommand(query, this.connection);
            command.Parameters.AddWithValue("@imagen", imagen);

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                existencias = reader.GetInt32("existencias");
            }
            reader.Close();
            return existencias;
        }

        public void guardar(int codigo, string nombre, string descripcion, float precio, int existencias, string imagen, string imagenNo)
        {
            string query = "";
            try
            {
                query = "INSERT INTO inventario (codigo, nombre, descripcion, precio, existencias, imagen, imagenAgotada) VALUES ("
                       + "'" + codigo + "',"
                       + "'" + nombre + "',"
                       + "'" + descripcion + "',"
                       + "'" + precio + "',"
                       + "'" + existencias + "',"
                       + "'" + imagen + "',"
                       + "'" + imagenNo + "')";

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
            try
            {
                string selectQuery = "SELECT * FROM inventario WHERE codigo = @cod;";
                using (MySqlCommand selectCmd = new MySqlCommand(selectQuery, connection))
                {
                    selectCmd.Parameters.AddWithValue("@cod", cod);
                    using (MySqlDataReader reader = selectCmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("El producto con el código especificado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        string productoInfo = $"Código: {reader["codigo"]}\n" +
                                              $"Nombre: {reader["nombre"]}\n" +
                                              $"Existencias: {reader["existencias"]}\n" +
                                              $"Precio: {reader["precio"]}";

                        DialogResult result = MessageBox.Show(
                            "¿Seguro que desea eliminar el producto?\n\n" + productoInfo,
                            "Confirmación",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning
                        );

                        if (result != DialogResult.Yes)
                        {
                            MessageBox.Show("Operación cancelada.");
                            return;
                        }
                    }
                }

                string deleteQuery = "DELETE FROM inventario WHERE codigo = @cod;";
                using (MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, connection))
                {
                    deleteCmd.Parameters.AddWithValue("@cod", cod);
                    deleteCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Producto eliminado correctamente.", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
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

        public List<string> NombreImagenesNo()
        {
            List<string> nombres = new List<string>();

            try
            {
                string query = "SELECT imagenAgotada FROM inventario";
                MySqlCommand command = new MySqlCommand(query, this.connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    nombres.Add(reader["imagenAgotada"].ToString() ?? "");
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

        public List<ClassProductos> obtenerInfoImagen(string imagen)
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

        public ClassProductos obtenerIndividual(int cod)
        {
            ClassProductos item = null;
            //int codigo;
            string name;
            string desc;
            float precio;
            int existencias;
            //string imagen;
            try
            {
                string query = "SELECT * FROM inventario where codigo = " + cod + ";";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    //codigo = Convert.ToInt32(reader["codigo"]);
                    name = Convert.ToString(reader["nombre"]) ?? "";
                    desc = Convert.ToString(reader["descripcion"]) ?? "";
                    precio = Convert.ToInt32(reader["precio"]);
                    existencias = Convert.ToInt32(reader["existencias"]);

                    item = new ClassProductos(name, desc, precio, existencias);
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

        public void RestarExistencias(Compra compra)
        {
            try
            {
                using (var transaction = this.connection.BeginTransaction())
                {
                        // Leer las existencias actuales del producto
                        string selectQuery = "SELECT existencias FROM inventario WHERE codigo = @codigo;";
                        MySqlCommand selectCommand = new MySqlCommand(selectQuery, this.connection, transaction);
                        selectCommand.Parameters.AddWithValue("@codigo", compra.Codigo);

                        int existencias = 0;
                        using (MySqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                existencias = Convert.ToInt32(reader["existencias"]);
                            }
                            reader.Close();
                        }

                        // Calcular las nuevas existencias
                        int nuevasExistencias = existencias - compra.Cantidad;

                        // Actualizar las existencias
                        string updateQuery = "UPDATE inventario SET existencias = @existencias WHERE codigo = @codigo;";
                        MySqlCommand updateCommand = new MySqlCommand(updateQuery, this.connection, transaction);
                        updateCommand.Parameters.AddWithValue("@existencias", nuevasExistencias);
                        updateCommand.Parameters.AddWithValue("@codigo", compra.Codigo);

                        updateCommand.ExecuteNonQuery();

                    // Confirma la transacción
                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar las existencias: " + ex.Message);
                this.Disconnect();
            }
        }

        public void SumarExistencias(List<Compra> compra)
        {
            try
            {
                using (var transaction = this.connection.BeginTransaction())
                {
                    foreach (var item in compra)
                    {
                        // Leer las existencias actuales del producto
                        string selectQuery = "SELECT existencias FROM inventario WHERE codigo = @codigo;";
                        MySqlCommand selectCommand = new MySqlCommand(selectQuery, this.connection, transaction);
                        selectCommand.Parameters.AddWithValue("@codigo", item.Codigo);

                        int existencias = 0;
                        using (MySqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                existencias = Convert.ToInt32(reader["existencias"]);
                            }
                            reader.Close();
                        }

                        // Calcular las nuevas existencias
                        int nuevasExistencias = existencias + item.Cantidad;

                        // Actualizar las existencias
                        string updateQuery = "UPDATE inventario SET existencias = @existencias WHERE codigo = @codigo;";
                        MySqlCommand updateCommand = new MySqlCommand(updateQuery, this.connection, transaction);
                        updateCommand.Parameters.AddWithValue("@existencias", nuevasExistencias);
                        updateCommand.Parameters.AddWithValue("@codigo", item.Codigo);

                        updateCommand.ExecuteNonQuery();
                    }

                    // Confirma la transacción
                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar las existencias: " + ex.Message);
                this.Disconnect();
            }
        }

        public void ActualizarMonto(int usuario, double total)
        {
            try
            {
                using (var transaction = this.connection.BeginTransaction())
                {
                    string selectQuery = "SELECT monto FROM usuarios WHERE id = @id;";
                    MySqlCommand selectCommand = new MySqlCommand(selectQuery, this.connection, transaction);
                    selectCommand.Parameters.AddWithValue("@id", usuario);

                    double monto = 0;

                    // Usamos un bloque "using" para manejar el lector de datos
                    using (MySqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            monto = Convert.ToDouble(reader["monto"]);
                        }

                        // Cerramos explícitamente el lector antes de continuar
                        reader.Close();
                    }

                    // Calculamos el nuevo monto
                    double nuevoMonto = monto + total;

                    // Consulta para actualizar el monto
                    string updateQuery = "UPDATE usuarios SET monto = @monto WHERE id = @id;";
                    MySqlCommand updateCommand = new MySqlCommand(updateQuery, this.connection, transaction);
                    updateCommand.Parameters.AddWithValue("@monto", nuevoMonto);
                    updateCommand.Parameters.AddWithValue("@id", usuario);

                    updateCommand.ExecuteNonQuery();

                    // Confirmamos la transacción
                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el monto: " + ex.Message);

                // Desconecta la conexión en caso de error
                if (this.connection.State == System.Data.ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }
        }

        public void ActualizarTotalProductos(List<Compra> compra)
        {
            try
            {
                using (var transaction = this.connection.BeginTransaction())
                {
                    foreach (var item in compra)
                    {
                        // Leer las existencias actuales del producto
                        string selectQuery = "SELECT total FROM inventario WHERE codigo = @codigo;";
                        MySqlCommand selectCommand = new MySqlCommand(selectQuery, this.connection, transaction);
                        selectCommand.Parameters.AddWithValue("@codigo", item.Codigo);

                        double total = 0;
                        using (MySqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                total = Convert.ToInt32(reader["total"]);
                            }
                            reader.Close();
                        }

                        // Calcular las nuevas existencias
                        double nuevoTotal = total + item.Precio;

                        // Actualizar las existencias
                        string updateQuery = "UPDATE inventario SET total = @total WHERE codigo = @codigo;";
                        MySqlCommand updateCommand = new MySqlCommand(updateQuery, this.connection, transaction);
                        updateCommand.Parameters.AddWithValue("@total", nuevoTotal);
                        updateCommand.Parameters.AddWithValue("@codigo", item.Codigo);

                        updateCommand.ExecuteNonQuery();
                    }

                    // Confirma la transacción
                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar las existencias: " + ex.Message);
                this.Disconnect();
            }
        }

        public ClassProductos obtenerProd(string img)
        {
            ClassProductos item = null;
            int codigo;
            string name;
            string desc;
            float precio;
            int existencias;
            try
            {
                string query = "SELECT * FROM inventario where imagen = @imagen;";
                MySqlCommand command = new MySqlCommand(query, this.connection);
                command.Parameters.AddWithValue("@Imagen", img);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    codigo = Convert.ToInt32(reader["codigo"]);
                    name = Convert.ToString(reader["nombre"]) ?? "";
                    desc = Convert.ToString(reader["descripcion"]) ?? "";
                    precio = Convert.ToInt32(reader["precio"]);
                    existencias = Convert.ToInt32(reader["existencias"]);

                    item = new ClassProductos(codigo, name, desc, precio, existencias);
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

        public DataTable ObtenerDatosGrafica()
        {
            DataTable datos = new DataTable();
            try
            {

                string query = "SELECT nombre, total FROM inventario";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(datos); // Llena el DataTable con los resultados
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener datos: " + ex.Message);
            }

            return datos;
        }

        public void actualizar(int cod, string name, string desc, float precio, int cant)
        {
            try
            {
                string query = "UPDATE inventario SET nombre = @name, descripcion = @desc, precio = @precio, existencias = @cant WHERE codigo = @cod;";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@desc", desc);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.AddWithValue("@cant", cant);
                    cmd.Parameters.AddWithValue("@cod", cod);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Registro actualizado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la actualización: " + ex.Message);
            }
        }


    }
}
