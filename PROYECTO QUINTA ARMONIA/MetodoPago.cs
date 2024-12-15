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
    public partial class MetodoPago : Form
    {
        private List<Compra> lista;
        private string usuario;
        private int idUsuario;

        private InterfaceUsuario inter;
        public MetodoPago(List<Compra> listaCompra, string nombre, int codigo, InterfaceUsuario interUs)
        {
            InitializeComponent();
            lista = listaCompra;
            usuario = nombre;
            idUsuario = codigo;
            this.inter = interUs;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonTarjeta_Click(object sender, EventArgs e)
        {
            PagoConTarjeta pagoConTarjeta = new PagoConTarjeta(lista, usuario, idUsuario, this.inter);
            this.Hide();
            pagoConTarjeta.ShowDialog();
        }

        private void MetodoPago_Load(object sender, EventArgs e)
        {

        }

        private void buttonOxxo_Click(object sender, EventArgs e)
        {
            PagoEnOxxo2 pagoEnOxxo2 = new PagoEnOxxo2();
            this.Hide();
            pagoEnOxxo2.ShowDialog();
        }
    }
}
