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
    public partial class PagoConTarjeta : Form
    {
        public PagoConTarjeta()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonPagar_Click(object sender, EventArgs e)
        {
            ExportToPdf();
        }
        private void ExportToPdf()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Guardar PDF";
            saveFileDialog.DefaultExt = "pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FormBorderStyle originalStyle = this.FormBorderStyle;

                this.FormBorderStyle = FormBorderStyle.None;

                this.Refresh();

                Bitmap bitmap = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
                this.DrawToBitmap(bitmap, new Rectangle(Point.Empty, this.ClientSize));

                this.FormBorderStyle = originalStyle;

                PdfDocument document = new PdfDocument();
                document.Info.Title = "Tu ticket será exportado en Formato PDF";

                PdfPage page = document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);

                MemoryStream stream = new MemoryStream();
                bitmap.Save(stream, ImageFormat.Png);
                XImage image = XImage.FromStream(stream);
                gfx.DrawImage(image, 0, 0, page.Width, page.Height);

                string filePath = saveFileDialog.FileName;
                document.Save(filePath);
                MessageBox.Show($"Tu ticket será guardado en: {filePath}");

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = filePath,
                    UseShellExecute = true
                });

                // Limpiar recursos
                gfx.Dispose();
                document.Close();
                bitmap.Dispose();
                image.Dispose();
                stream.Dispose();
            }
        }

        private void textBoxNumContacto_TextChanged(object sender, EventArgs e)
        {
            numeroContacto(textBoxNumContacto.Text);
        }
        void numeroContacto(string numeroContacto)
        {
            if (numeroContacto.Length != 10)
            {
                MessageBox.Show("Recuerda que el numero de Telefono es a 10 digitos :) ");
            }
            else
            {
                int[] vector4 = new int[10];
                for (int i = 0; i <= numeroContacto.Length; i++)
                {
                    vector4[i] = int.Parse(numeroContacto[i].ToString());
                }
            }
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            nombre(textBoxNombre.Text);
        }
        void nombre(string nombre)
        {
            int[] vector3 = new int[100];
            for (int i = 0; i < vector3.Length; i++)
            {
                vector3[i] = int.Parse(nombre[i].ToString());
            }
        }

        private void textBoxCorreo_TextChanged(object sender, EventArgs e)
        {
            correo(textBoxCorreo.Text);
        }
        void correo(string correo)
        {

        }

        private void textBoxCVV_TextChanged(object sender, EventArgs e)
        {
            cvv(textBoxCVV.Text);
        }
        void cvv(string cvv)
        {
            if (cvv.Length != 3)
            {
                MessageBox.Show("Recuerda que el numero CVV es de maximo 3 digitos :) ");
            }
            else
            {
                int[] vector2 = new int[3];
                for (int i = 0; i < cvv.Length; i++)
                {
                    vector2[i] = int.Parse(cvv[i].ToString());
                }

                /*for (int i = 0; i < vector2.Length; i++)
                {
                    Console.WriteLine($"Dígito {i + 1}: {vector2[i]}");
                }*/
            }
        }

        private void textBoxExpira_TextChanged(object sender, EventArgs e)
        {
            expiracion(textBoxExpira.Text);
        }
        void expiracion(string expira)
        {

        }

        private void textBoxNumero_TextChanged(object sender, EventArgs e)
        {
            numeroTarjeta(textBoxNumero.Text);
        }
        void numeroTarjeta(string numero)
        {
            if (numero.Length != 16)
            {
                MessageBox.Show("Recuerda que el numero de Tarjeta debe de teenr 16 digitos :)");
            }
            else
            {
                int[] vector = new int[16];
                for (int i = 0; i < numero.Length; i++)
                {
                    vector[i] = int.Parse(numero[i].ToString());
                }
            }
        }
    }
}
