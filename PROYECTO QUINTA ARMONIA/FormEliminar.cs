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
    public partial class FormEliminar : Form
    {
        public FormEliminar()
        {
            InitializeComponent();
        }

        private void buttonRedondoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRedondoEliminar_Click(object sender, EventArgs e)
        {
            BaseDatos obj = new BaseDatos();
            obj.eliminar(Convert.ToInt32(this.textBoxBuscarCodigo.Text));
            this.textBoxBuscarCodigo.Text = "";
            this.textBoxBuscarCodigo.PlaceholderText = "Codigo de producto";
            obj.Disconnect();
        }

        private void FormEliminar_Load(object sender, EventArgs e)
        {

        }

        private void textBoxBuscarCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
