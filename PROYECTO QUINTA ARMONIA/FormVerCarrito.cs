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
    public partial class FormVerCarrito : Form
    {
        public FormVerCarrito()
        {
            InitializeComponent();
        }

        private void FormVerCarrito_Load(object sender, EventArgs e)
        {
  
        }

        private void buttonRegresarComprar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
