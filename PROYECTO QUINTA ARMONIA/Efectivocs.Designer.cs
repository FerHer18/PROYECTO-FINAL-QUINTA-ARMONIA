namespace PROYECTO_QUINTA_ARMONIA
{
    partial class Efectivocs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            labelPagoEfectivo = new Label();
            textBoxMonto = new TextBox();
            label1 = new Label();
            button1 = new Button();
            textBoxCambio = new TextBox();
            buttonTICKET = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Recursos4;
            pictureBox1.Location = new Point(4, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(615, 594);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Beige;
            pictureBox2.Image = Properties.Resources.Letras_removebg_preview1;
            pictureBox2.Location = new Point(36, 39);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(190, 109);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Beige;
            pictureBox3.Image = Properties.Resources.Recursos__1__removebg_preview1;
            pictureBox3.Location = new Point(399, 39);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(190, 109);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // labelPagoEfectivo
            // 
            labelPagoEfectivo.AutoSize = true;
            labelPagoEfectivo.BackColor = Color.Beige;
            labelPagoEfectivo.Location = new Point(259, 212);
            labelPagoEfectivo.Name = "labelPagoEfectivo";
            labelPagoEfectivo.Size = new Size(85, 20);
            labelPagoEfectivo.TabIndex = 4;
            labelPagoEfectivo.Text = "PAGO CON:";
            // 
            // textBoxMonto
            // 
            textBoxMonto.Location = new Point(185, 246);
            textBoxMonto.Name = "textBoxMonto";
            textBoxMonto.Size = new Size(243, 27);
            textBoxMonto.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Beige;
            label1.Location = new Point(279, 383);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 11;
            label1.Text = "CAMBIO";
            // 
            // button1
            // 
            button1.Location = new Point(223, 293);
            button1.Name = "button1";
            button1.Size = new Size(169, 70);
            button1.TabIndex = 12;
            button1.Text = "PAGAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBoxCambio
            // 
            textBoxCambio.Location = new Point(185, 406);
            textBoxCambio.Name = "textBoxCambio";
            textBoxCambio.Size = new Size(243, 27);
            textBoxCambio.TabIndex = 13;
            // 
            // buttonTICKET
            // 
            buttonTICKET.Location = new Point(429, 503);
            buttonTICKET.Name = "buttonTICKET";
            buttonTICKET.Size = new Size(169, 70);
            buttonTICKET.TabIndex = 14;
            buttonTICKET.Text = "GENERAR TICKET";
            buttonTICKET.UseVisualStyleBackColor = true;
            // 
            // Efectivocs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 594);
            Controls.Add(buttonTICKET);
            Controls.Add(textBoxCambio);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBoxMonto);
            Controls.Add(labelPagoEfectivo);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Efectivocs";
            Text = "Efectivocs";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label labelPagoEfectivo;
        private TextBox textBoxMonto;
        private Label label1;
        private Button button1;
        private TextBox textBoxCambio;
        private Button buttonTICKET;
    }
}