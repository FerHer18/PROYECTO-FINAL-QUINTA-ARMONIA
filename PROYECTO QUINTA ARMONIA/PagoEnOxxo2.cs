using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using QRCoder;

namespace PROYECTO_QUINTA_ARMONIA
{
    public partial class PagoEnOxxo2 : Form
    {
        public PagoEnOxxo2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void PagoEnOxxo2_Load(object sender, EventArgs e)
        {
            QRCodeGenerator qrCodeGenerator = new QRCodeGenerator();
            QRCodeData codeData = qrCodeGenerator.CreateQrCode("OXXO", QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(codeData);

            Bitmap qrCodeImage = qrCode.GetGraphic(10, Color.Black, Color.White, true);
            pictureBoxQR.Image = qrCodeImage;
        }

        private void generarTicket()
        {
            int formWidth = 660;
            int formHeight = 830;
            int ticketWidth = formWidth;
            int ticketHeight = formHeight - 100;
            int x = 146;
            int y = 260;

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
            saveFileDialog.Filter = "PDF files (.pdf)|.pdf";
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

        private void buttonGenerar_Click(object sender, EventArgs e)
        {
            generarTicket();
        }
    }
}
