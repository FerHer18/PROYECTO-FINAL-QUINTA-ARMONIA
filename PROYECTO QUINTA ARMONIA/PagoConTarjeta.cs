using PdfSharp.Drawing;
using PdfSharp.Internal;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_QUINTA_ARMONIA
{
    public partial class PagoConTarjeta : Form
    {
        private Panel panelTicket;
        private List<Compra> lista;
 
        // Ejemplo de inicialización del panel en el constructor del formulario
        public PagoConTarjeta(List<Compra> listaCompra)
        {
            InitializeComponent();
            lista = listaCompra;
            panelTicket = new Panel();
            panelTicket.Size = new Size(400, 600);
            panelTicket.Location = new Point(50, 50); // Ajusta la ubicación según sea necesario

            // Añadir controles al panelTicket
            // Ejemplo: panelTicket.Controls.Add(new Label { Text = "Ejemplo" });

            this.Controls.Add(panelTicket);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonPagar_Click(object sender, EventArgs e)
        {
            if (camposValidos())
            {
                Ticket pagar = new Ticket(lista);
                this.Hide();
                pagar.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lo siento, por favor completa los campos de manera correcta :)");
            }
           
        }
        
        private void textBoxNumContacto_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNumContacto.Text.Length>10||!long.TryParse(textBoxNumContacto.Text,out _) && textBoxNumContacto.Text.Length > 0) 
            {
                MessageBox.Show("Hola, te recuerdo que el numero de telefono es 10 digitos :)"); 
                textBoxNumContacto.Text = string.Empty; 
            }
        }
        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBoxCorreo_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBoxCVV_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCVV.Text.Length>3||!int.TryParse(textBoxCVV.Text, out _) && textBoxCVV.Text.Length > 0) 
            {
                MessageBox.Show("Hola, te recuerdo que el CVV es de 3 digitos :)"); 
                textBoxCVV.Text = string.Empty; 
            }
        }

        private void textBoxExpira_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxNumero_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNumero.Text.Length>16||!long.TryParse(textBoxNumero.Text, out _) && textBoxNumero.Text.Length>0)
            {
                MessageBox.Show("Hola, te recuerdo que el numero de tarjeta es de 16 digitos :)"); 
                textBoxNumero.Text = string.Empty;
            }
        }
        private bool camposValidos()
        {
            bool validar = true;
            if (textBoxNumero.Text.Length!= 16||!long.TryParse(textBoxNumero.Text,out _))
            {
                MessageBox.Show("ERROR :( ,recuerda que el numero de tarjeta es de 16 Digitos por favor");
                validar = false;
            }
            if (!DateTime.TryParseExact(textBoxExpira.Text,"MM/yy", null, System.Globalization.DateTimeStyles.None,out _))
            {
                MessageBox.Show("ERROR :(, recuerda que la fecha de expiracion es dos digitos para el mes y dos para el año por favor");
                validar = false;
            }
            if (textBoxCVV.Text.Length!=3||!int.TryParse(textBoxCVV.Text,out _))
            {
                MessageBox.Show("ERROR :(, recuerda que el CVV es de ters digitos por favor");
                validar = false;
            }
            if (textBoxNumContacto.Text.Length!=10||!long.TryParse(textBoxNumContacto.Text,out _))
            {
                MessageBox.Show("ERROR :(, recuerda que el numero de telefono es de 10 digitos por favor");
                validar = false;
            }
            if (!Regex.IsMatch(textBoxCorreo.Text,@"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("ERROR :(, recuerda ingresar un formato valido de correo electronico por favor");
                validar = false;
            }
            return validar;
        }
    }
}
