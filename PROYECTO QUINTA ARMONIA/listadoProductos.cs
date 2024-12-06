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
    public partial class listadoProductos : Form
    {
        public listadoProductos()
        {
            InitializeComponent();
        }

        private void CargarDatosEnDataGrid()
        {
            BaseDatos obj = new BaseDatos();
            List<ClassProductos> listado = obj.Consulta();

            List<ClassProductos> ordenado = listado.OrderByDescending(p => p.Existencias).ToList();

            dataGridView1.Columns["codigo"].DataPropertyName = "Codigo";
            dataGridView1.Columns["nombre"].DataPropertyName = "Nombre";
            dataGridView1.Columns["descripcion"].DataPropertyName = "Descripcion";
            dataGridView1.Columns["precio"].DataPropertyName = "Precio";
            dataGridView1.Columns["existencias"].DataPropertyName = "Existencias";

            dataGridView1.DataSource = ordenado;
        }

        private void listadoProductos_Load(object sender, EventArgs e)
        {
            CargarDatosEnDataGrid();
        }

        private void buttonRedondoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
