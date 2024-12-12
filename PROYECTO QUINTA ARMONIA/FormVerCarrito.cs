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

        public FormVerCarrito(List<Compra> listaCompra)
        {
            InitializeComponent();
            this.lista = listaCompra;
        }

        private void FormVerCarrito_Load(object sender, EventArgs e)
        {
            richTextBoxMostrar.Text += "Productos agregados: \n\n";
            for (int i = 0; i < lista.Count; i++)
            {
                richTextBoxMostrar.Text += lista[i].Name + " x " + lista[i].Cantidad + " - $" + lista[i].Precio.ToString("F2") + "\n";
            }
        }

        private void buttonRegresarComprar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) ///pendeiente 
        {
            this.Close();
            PresentacionSistema regreso = new PresentacionSistema();
            regreso.ShowDialog();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            MetodoPago pagar = new MetodoPago();
            this.Hide();
            pagar.ShowDialog();
            //no se a donde se va despues 
        }

        private void richTextBoxMostrar_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
