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
    public partial class PresentacionSistema : Form
    {
        public PresentacionSistema()
        {
            InitializeComponent();
        }

        private void PresentacionSistema_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1358, 869); //Tamaño fijo del formulario
            this.AutoSize = false; //Evita redimensionamiento automático
            this.AutoScaleMode = AutoScaleMode.None; //Desactiva escalado automático
            this.MaximumSize = this.Size; //Establece un tamaño máximo igual al tamaño fijo
            this.MinimumSize = this.Size; //Establece un tamaño mínimo igual al tamaño fijo
            this.AutoScroll = true;
        }
    }
}
