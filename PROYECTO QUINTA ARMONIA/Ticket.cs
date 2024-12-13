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
        public Ticket(List<Compra> listaCompra)
        {
            InitializeComponent();
            lista = listaCompra;
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
            int formWidth = 850;
            int formHeight = 853;
            int ticketWidth = formWidth;
            int ticketHeight = formHeight - 120;
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
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
