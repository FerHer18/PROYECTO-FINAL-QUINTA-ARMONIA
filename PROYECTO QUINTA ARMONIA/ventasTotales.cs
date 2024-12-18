﻿using Org.BouncyCastle.Asn1.Pkcs;
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
    public partial class ventasTotales : Form
    {
        private float total;
        public ventasTotales()
        {
            InitializeComponent();
        }

        private void CargarDatosEnDataGrid()
        {
            BaseDatos obj = new BaseDatos();
            List<ClaseUsuarios> ventas = obj.ConsultaUsuarios();

            dataGridView1.Columns["ID"].DataPropertyName = "id";
            dataGridView1.Columns["USUARIO"].DataPropertyName = "Nombre";
            dataGridView1.Columns["MONTO"].DataPropertyName = "Monto";

            dataGridView1.DataSource = ventas;
            obj.Disconnect();
        }
  
        private void ventasTotales_Load(object sender, EventArgs e)
        {
            CargarDatosEnDataGrid();
            ObtenerTotal();
            labelHola.Text = "Hola, Admin!";
        }
        public void ObtenerTotal()
        {
            BaseDatos obj = new BaseDatos();
            List<ClaseUsuarios> tot = obj.ConsultaUsuarios();
            foreach (ClaseUsuarios us in tot)
            {
                this.total += us.Monto;

            }

            txtTotal.Text = "$" + this.total.ToString();
            obj.Disconnect();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonRedondoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
    }
}
