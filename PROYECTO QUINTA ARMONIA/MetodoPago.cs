﻿using System;
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
    public partial class MetodoPago : Form
    {
        public MetodoPago()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonTarjeta_Click(object sender, EventArgs e)
        {
            PagoConTarjeta pagoConTarjeta = new PagoConTarjeta();
        }

        private void MetodoPago_Load(object sender, EventArgs e)
        {

        }
    }
}
