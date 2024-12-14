using PdfSharp.Quality;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization;

namespace PROYECTO_QUINTA_ARMONIA
{
    public partial class Grafica : Form
    {
        public Grafica()
        {
            InitializeComponent();
            ObtenerGrafica();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        public void ObtenerGrafica()
        {
            BaseDatos obj = new BaseDatos();
            DataTable datos = obj.ObtenerDatosGrafica();

            chart1.Series.Clear();
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            chart1.Series.Add("Datos");
            chart1.Series["Datos"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            foreach (DataRow row in datos.Rows)
            {
                string articulo = Convert.ToString(row["nombre"]);
                double total = Convert.ToDouble(row["total"]);
                chart1.Series["Datos"].Points.AddXY(articulo, total);
            }

            chart1.Series["Datos"].IsValueShownAsLabel = true;

        }

        private void buttonVerCarrito_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Grafica_Load(object sender, EventArgs e)
        {
            labelHola.Text = "Hola, Admin!";
        }
    }
}
