using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_QUINTA_ARMONIA
{
    public partial class FormVerCarrito : Form
    {
        private List<Compra> lista;
        private string nombre;
        public FormVerCarrito(List<Compra> listaCompra, string Nombre)
        {
            InitializeComponent();
            this.lista = listaCompra;
            this.nombre = Nombre;
        }

        private void FormVerCarrito_Load(object sender, EventArgs e)
        {
            richTextBoxMostrar.Text += "Productos agregados: \n\n";
            for (int i = 0; i < lista.Count; i++)
            {
                richTextBoxMostrar.Text += lista[i].Name + " x " + lista[i].Cantidad + " - $" + lista[i].Precio.ToString("F2") + "\n";
            }
            labelHolaUsuarioUCI.Text = $"Hola, {this.nombre}!";
        }

        private void buttonRegresarComprar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            MetodoPago pagar = new MetodoPago(lista);
            this.Hide();
            pagar.ShowDialog();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            PresentacionSistema regreso = new PresentacionSistema();
            regreso.ShowDialog();
        }
    }
}
