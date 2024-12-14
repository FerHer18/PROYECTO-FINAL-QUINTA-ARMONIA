using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    }
}
