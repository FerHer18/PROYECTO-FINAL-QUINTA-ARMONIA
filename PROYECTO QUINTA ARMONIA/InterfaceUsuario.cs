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
using Org.BouncyCastle.Pqc.Crypto.Lms;
using static PdfSharp.Capabilities.Features;

namespace PROYECTO_QUINTA_ARMONIA
{
    public partial class InterfaceUsuario : Form
    {
        private string Nombre; //atributo necesario para mensaje de bienvenida en inicio de sesion
        List<Compra> listaCompra = new List<Compra>();
        private List<string> imagenes = new List<string>();
        private int cantProductos;
        private int cantidad = 0;
        List<ClassProductos> datos;
        public bool NuevaCompra { get; set; } = false;

        private int prodSelect = 0;
        private int existencias = 0;
        private string nomProd;
        private float precio;
        private int id;

        public InterfaceUsuario()
        {
            InitializeComponent();
        }

        public InterfaceUsuario(bool nueva)
        {
            InitializeComponent();
            NuevaCompra = nueva;
        }

        public InterfaceUsuario(string nombre, int codigo) //cosntructor para que salga mensaje de bienvenido al iniciar sesion en usuario
        {
            InitializeComponent();
            this.Nombre = nombre;
            MessageBox.Show($"Bienvenido {this.Nombre}", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            imagenes = new List<string>();
            id = codigo;
        }

        private void InterfaceUsuario_Load(object sender, EventArgs e)
        {
            MostrarImagenes();
            labelHola.Text = $"Hola, {this.Nombre}!";
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

        private void patch_Click(object sender, EventArgs e)
        {

        }

        public void MostrarImagenes()
        {
            BaseDatos obj = new BaseDatos();
            imagenes.Clear();
            imagenes = obj.NombreImagenes();
            cantProductos = imagenes.Count;

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

            int existencias;

            for (int i = 0; i < imagenes.Count; i++)
            {
                existencias = obj.existenciasProd(imagenes[i]);
                switch (i)
                {
                    case 0:
                        if (existencias != 0)
                        {
                            this.btn1.BackgroundImage = System.Drawing.Image.FromFile(
                                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[0])); 
                        }
                        btn1.Tag = imagenes[0];
                        break;
                    case 1:
                        if (existencias != 0)
                        {
                            this.btn2.BackgroundImage = System.Drawing.Image.FromFile(
                                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[1]));
                        }      
                        btn2.Tag = imagenes[1];
                        break;
                    case 2:
                        if(existencias != 0)
                        {
                            this.btn3.BackgroundImage = System.Drawing.Image.FromFile(
                                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[2]));
                        }
                        btn3.Tag = imagenes[2];
                        break;
                    case 3:
                        if(existencias != 0)
                        {
                            this.btn4.BackgroundImage = System.Drawing.Image.FromFile(
                                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[3]));
                        }    
                        btn4.Tag = imagenes[3];
                        break;
                    case 4:
                        if (existencias != 0)
                        {
                            this.btn5.BackgroundImage = System.Drawing.Image.FromFile(
                                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[4]));
                        } 
                        btn5.Tag = imagenes[4];
                        break;
                    case 5:
                        if (existencias != 0)
                        {
                            this.btn6.BackgroundImage = System.Drawing.Image.FromFile(
                                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[5]));
                        }
                        btn6.Tag = imagenes[5];
                        break;
                    case 6:
                        if (existencias != 0)
                        {
                            this.btn7.BackgroundImage = System.Drawing.Image.FromFile(
                                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[6]));
                        }
                        btn7.Tag = imagenes[6];
                        break;
                    case 7:
                        if (existencias != 0)
                        {
                            this.btn8.BackgroundImage = System.Drawing.Image.FromFile(
                                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[7]));
                        }                        
                        btn8.Tag = imagenes[7];
                        break;
                    case 8:
                        if (existencias != 0)
                        {
                            this.btn9.BackgroundImage = System.Drawing.Image.FromFile(
                                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[8]));
                        }                     
                        btn9.Tag = imagenes[8];
                        break;
                    case 9:
                        if (existencias != 0)
                        {
                            this.btn10.BackgroundImage = System.Drawing.Image.FromFile(
                                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagenes[9]));
                        }                   
                        btn10.Tag = imagenes[9];
                        break;
                }
            }

            obj.Disconnect();
        }

        private void mostrarInfoProducto(string imagen)
        {
            if (string.IsNullOrEmpty(imagen))
            {
                MessageBox.Show("El código de la imagen es inválido.");
                return;
            }
            richTextBoxInfo.Text = "";
            BaseDatos obj = new BaseDatos(); //instancia necesaria para concetar con la base de datos
            datos = obj.obtenerInfoImagen(imagen);
            if (datos != null && datos.Count > 0)   //el .Count es para checar si una lista tiene elementos o es diferente de null
            {
                foreach (var prod in datos)
                {
                    this.prodSelect = prod.Codigo;
                    this.existencias = prod.Existencias;
                    this.nomProd = prod.Nombre;
                    this.precio = prod.Precio;
                    if (prod.Existencias != 0)
                    {
                        richTextBoxInfo.Rtf = @"{\rtf1\ansi 
\pard\ql\sl360\slmult1\li0\b Nombre:\b0 " + prod.Nombre + @"\line
\pard\ql\sl360\slmult1\li0\b Descripción:\b0 " + prod.Descripcion + @"\line
\pard\ql\sl360\slmult1\li0\b Precio:\b0 " + prod.Precio + @"\line
\pard\ql\sl360\slmult1\li0\b Existencias:\b0 " + prod.Existencias + @"}";
                    }
                    else
                    {
                        richTextBoxInfo.Text = "PRODUCTO AGOTADO";
                    }
                   
                }
            }
            else
            {
                this.richTextBoxInfo.Text = "Producto no encontrado\n";
            }
        }

        //el Tag funciona como get y set, entonces nos da el valor de la imagen y la convierte en string, la cual
        //la utiliza el metodo mostrarInfoProducto
        private void buttonYakult_Click(object sender, EventArgs e)
        {
            string cod = btn1.Tag?.ToString() ?? "";
            if (!string.IsNullOrEmpty(cod))
            {
                cantidad = 0;
                labelCantidad.Text = cantidad.ToString();
                mostrarInfoProducto(cod);
            }

        }

        private void buttonLotus_Click(object sender, EventArgs e)
        {
            string cod = btn3.Tag?.ToString() ?? "";
            if (!string.IsNullOrEmpty(cod))
            {
                cantidad = 0;
                labelCantidad.Text = cantidad.ToString();
                mostrarInfoProducto(cod);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string cod = btn2.Tag?.ToString() ?? "";
            if (!string.IsNullOrEmpty(cod))
            {
                cantidad = 0;
                labelCantidad.Text = cantidad.ToString();
                mostrarInfoProducto(cod);
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string cod = btn4.Tag?.ToString() ?? "";
            if (!string.IsNullOrEmpty(cod))
            {
                cantidad = 0;
                labelCantidad.Text = cantidad.ToString();
                mostrarInfoProducto(cod);
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            string cod = btn5.Tag?.ToString() ?? "";
            if (!string.IsNullOrEmpty(cod))
            {
                cantidad = 0;
                labelCantidad.Text = cantidad.ToString();
                mostrarInfoProducto(cod);
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            string cod = btn6.Tag?.ToString() ?? "";
            if (!string.IsNullOrEmpty(cod))
            {
                cantidad = 0;
                labelCantidad.Text = cantidad.ToString();
                mostrarInfoProducto(cod);
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            string cod = btn7.Tag?.ToString() ?? "";
            if (!string.IsNullOrEmpty(cod))
            {
                cantidad = 0;
                labelCantidad.Text = cantidad.ToString();
                mostrarInfoProducto(cod);
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            string cod = btn8.Tag?.ToString() ?? "";
            if (!string.IsNullOrEmpty(cod))
            {
                cantidad = 0;
                labelCantidad.Text = cantidad.ToString();
                mostrarInfoProducto(cod);
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            string cod = btn9.Tag?.ToString() ?? "";
            if (!string.IsNullOrEmpty(cod))
            {
                cantidad = 0;
                labelCantidad.Text = cantidad.ToString();
                mostrarInfoProducto(cod);
            }
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            string cod = btn10.Tag?.ToString() ?? "";
            if (!string.IsNullOrEmpty(cod))
            {
                cantidad = 0;
                labelCantidad.Text = cantidad.ToString();
                mostrarInfoProducto(cod);
            }
        }

        private void EjecutarCompra()
        {
            //Mensaje de confirmación con un ícono
            MessageBox.Show(
                $"Se agregó al carrito: {this.nomProd} x {this.cantidad}", //Mensaje
                "Producto agregado",                           //Título de la ventana
                MessageBoxButtons.OK,                         //Botón de confirmación
                MessageBoxIcon.Information                    //Icono de exclamación
            );
        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {
            if (this.prodSelect != 0 && this.cantidad != 0)
            {
                EjecutarCompra();
                //Agregar a la lista
                float total = precio * cantidad;
                Compra item = new Compra(this.prodSelect, this.nomProd, total, this.cantidad);
                listaCompra.Add(item);
                this.cantidad = 0;
                labelCantidad.Text = cantidad.ToString();
            }
            else if (this.cantidad == 0)
            {
                MessageBox.Show("La cantidad de productos debe ser mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        private void buttonRedondoRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            ClaseMusica.Play();
        }
        #region INUTIL POR AHORA
        public List<Compra> getCompra()
        {
            return listaCompra;
        }
        #endregion

        private void btnPause_Click(object sender, EventArgs e)
        {
            ClaseMusica.Pause();
        }

        private void buttonVerCarrito_Click(object sender, EventArgs e)
        {
            FormVerCarrito f1 = new FormVerCarrito(listaCompra,Nombre, id, Nombre, this);
            this.Hide();
            f1.ShowDialog();
            this.Show();
            if (NuevaCompra == true)
            {
                listaCompra.Clear();
                NuevaCompra = false;
            }

        }

        private void InterfaceUsuario_Shown(object sender, EventArgs e)
        {
            MostrarImagenes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            if (cantidad < this.existencias)
            {
                cantidad++;
                labelCantidad.Text = cantidad.ToString();
            }
            else
            {
                MessageBox.Show("NO HAY MAS EXISTENCIAS");
            }

        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            if (cantidad > 0)
            {
                cantidad--;
                labelCantidad.Text = cantidad.ToString();
            }
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Deseas eliminar todo el carrito?", "Confirmación de eliminar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                listaCompra.Clear();
                MessageBox.Show($"Se eliminaron todos los productos", "Carrito vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void richTextBoxInfo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
