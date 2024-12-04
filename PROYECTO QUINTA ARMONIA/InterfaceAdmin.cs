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
    public partial class InterfaceAdmin : Form
    {
        private string Nombre; //atributo necesario para mensaje de bienvenida en inicio de sesion
        public InterfaceAdmin()
        {
            InitializeComponent();
        }

        public InterfaceAdmin(string nombre) //cosntructor para que salga mensaje de bienvenido al iniciar sesion en admin
        {
            InitializeComponent();
            this.Nombre = nombre;
            MessageBox.Show($"Bienvenido {this.Nombre}", "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void InterfaceAdmin_Load(object sender, EventArgs e)
        {

        }

        private void buttonRedondoAgregar_Click(object sender, EventArgs e)
        {
            FormAgregar fA = new FormAgregar();
            this.Hide();
            fA.ShowDialog();
            this.Show();
        }

        private void buttonRedondoEliminar_Click(object sender, EventArgs e)
        {
            FormEliminar fE = new FormEliminar();
            this.Hide(); fE.ShowDialog(); this.Show();
        }

        private void buttonRedondoRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
