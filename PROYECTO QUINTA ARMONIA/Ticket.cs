using PdfSharp.Drawing;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_QUINTA_ARMONIA
{
    public partial class Ticket : Form
    {
        private List<Compra> lista;
        private float subtotal;
        private double impuesto;
        private double total;
        private string usuario;
        private int idUsuario;
        private InterfaceUsuario inter;
        public Ticket(List<Compra> listaCompra,string name, int codigo, InterfaceUsuario inter)
        {
            InitializeComponent();
            lista = listaCompra;
            usuario = name;
            idUsuario = codigo;
            this.inter = inter;
        }

        public void ObtenerTotal()
        {
            foreach(var item in lista)
            {
                subtotal += item.Precio;
            }
            txtSub.Text= subtotal.ToString();
            impuesto = subtotal * 0.06;
            txtIva.Text= impuesto.ToString();
            total += impuesto + subtotal;
            txtTotal.Text = total.ToString();
        }


        private void buttonRegresar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void buttonContinuar_Click_1(object sender, EventArgs e)
        {
            generarTicket();
            this.Close();
            
        }
    

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void generarTicket()
        {
            int formWidth = 680;
            int formHeight = 853;
            int ticketWidth = formWidth;
            int ticketHeight = formHeight - 100;
            int x = 0;
            int y = 0;

            Bitmap bitmap = new Bitmap(ticketWidth, ticketHeight);

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.CopyFromScreen(this.PointToScreen(new Point(x, y)), Point.Empty, new Size(ticketWidth, ticketHeight));
            }
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Tu ticket será exportado en Formato PDF";

            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);

            using (MemoryStream stream = new MemoryStream())
            {
                bitmap.Save(stream, ImageFormat.Png);
                XImage image = XImage.FromStream(stream);
                gfx.DrawImage(image, 0, 0, page.Width, page.Height);
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Guardar PDF";
            saveFileDialog.DefaultExt = "pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                document.Save(filePath);
                MessageBox.Show($"Tu ticket será guardado en: {filePath}");

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
            gfx.Dispose();
            document.Close();
            bitmap.Dispose();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void labelResumen_Click(object sender, EventArgs e)
        {

        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            dataGridViewCompras.DataSource = lista;
            ObtenerTotal();
            dataGridViewCompras.ClearSelection(); // Limpia la selección inicial
            dataGridViewCompras.CurrentCell = null; // Evita que una celda esté activa
            ActualizarDatos();
            inter.NuevaCompra = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text= DateTime.Now.ToString("HH:mm:ss");
        }

        public void ActualizarDatos()
        {
            //Reflejar la compra en la base de datos
            BaseDatos obj = new BaseDatos();
            obj.ActualizarExistencias(lista);
            obj.ActualizarMonto(idUsuario, total);
            obj.ActualizarTotalProductos(lista);
            obj.Disconnect();
        }
    }
}
