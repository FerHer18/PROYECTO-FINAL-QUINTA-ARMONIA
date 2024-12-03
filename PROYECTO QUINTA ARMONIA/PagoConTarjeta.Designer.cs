
namespace PROYECTO_QUINTA_ARMONIA
{
    partial class PagoConTarjeta
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
            labelNumeroTarjeta = new Label();
            labelVence = new Label();
            labelCVV = new Label();
            labelCorreo = new Label();
            label1 = new Label();
            label2 = new Label();
            textBoxNumero = new TextBox();
            textBoxExpira = new TextBox();
            textBoxCVV = new TextBox();
            textBoxCorreo = new TextBox();
            textBoxNombre = new TextBox();
            textBoxNumContacto = new TextBox();
            buttonPagar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Recursos4;
            pictureBox1.Location = new Point(3, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(615, 594);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Beige;
            pictureBox2.Image = Properties.Resources.Letras_removebg_preview1;
            pictureBox2.Location = new Point(17, 17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(190, 109);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Beige;
            pictureBox3.Image = Properties.Resources.Recursos__1__removebg_preview1;
            pictureBox3.Location = new Point(420, 17);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(190, 109);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // labelNumeroTarjeta
            // 
            labelNumeroTarjeta.AutoSize = true;
            labelNumeroTarjeta.BackColor = Color.Beige;
            labelNumeroTarjeta.Location = new Point(48, 180);
            labelNumeroTarjeta.Name = "labelNumeroTarjeta";
            labelNumeroTarjeta.Size = new Size(243, 20);
            labelNumeroTarjeta.TabIndex = 3;
            labelNumeroTarjeta.Text = "NUMERO DE TARJETA (16 DIGITOS)";
            // 
            // labelVence
            // 
            labelVence.AutoSize = true;
            labelVence.BackColor = Color.Beige;
            labelVence.Location = new Point(48, 237);
            labelVence.Name = "labelVence";
            labelVence.Size = new Size(57, 20);
            labelVence.TabIndex = 4;
            labelVence.Text = "EXPIRA";
            // 
            // labelCVV
            // 
            labelCVV.AutoSize = true;
            labelCVV.BackColor = Color.Beige;
            labelCVV.Location = new Point(330, 237);
            labelCVV.Name = "labelCVV";
            labelCVV.Size = new Size(36, 20);
            labelCVV.TabIndex = 5;
            labelCVV.Text = "CVV";
            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.BackColor = Color.Beige;
            labelCorreo.Location = new Point(48, 312);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(168, 20);
            labelCorreo.TabIndex = 6;
            labelCorreo.Text = "CORREO DE CONTACTO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Beige;
            label1.Location = new Point(48, 387);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 7;
            label1.Text = "NOMBRE";
            label1.Click += this.label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Beige;
            label2.Location = new Point(48, 461);
            label2.Name = "label2";
            label2.Size = new Size(173, 20);
            label2.TabIndex = 8;
            label2.Text = "NUMERO DE CONTACTO";
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(48, 203);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(243, 27);
            textBoxNumero.TabIndex = 9;
            // 
            // textBoxExpira
            // 
            textBoxExpira.Location = new Point(48, 260);
            textBoxExpira.Name = "textBoxExpira";
            textBoxExpira.Size = new Size(98, 27);
            textBoxExpira.TabIndex = 10;
            // 
            // textBoxCVV
            // 
            textBoxCVV.Location = new Point(330, 260);
            textBoxCVV.Name = "textBoxCVV";
            textBoxCVV.Size = new Size(98, 27);
            textBoxCVV.TabIndex = 11;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.Location = new Point(48, 335);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(243, 27);
            textBoxCorreo.TabIndex = 12;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(48, 410);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(243, 27);
            textBoxNombre.TabIndex = 13;
            // 
            // textBoxNumContacto
            // 
            textBoxNumContacto.Location = new Point(48, 484);
            textBoxNumContacto.Name = "textBoxNumContacto";
            textBoxNumContacto.Size = new Size(243, 27);
            textBoxNumContacto.TabIndex = 14;
            // 
            // buttonPagar
            // 
            buttonPagar.BackColor = Color.PaleGoldenrod;
            buttonPagar.Location = new Point(463, 525);
            buttonPagar.Name = "buttonPagar";
            buttonPagar.Size = new Size(147, 60);
            buttonPagar.TabIndex = 15;
            buttonPagar.Text = "PAGAR";
            buttonPagar.UseVisualStyleBackColor = false;
            // 
            // PagoConTarjeta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 597);
            Controls.Add(buttonPagar);
            Controls.Add(textBoxNumContacto);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxCorreo);
            Controls.Add(textBoxCVV);
            Controls.Add(textBoxExpira);
            Controls.Add(textBoxNumero);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelCorreo);
            Controls.Add(labelCVV);
            Controls.Add(labelVence);
            Controls.Add(labelNumeroTarjeta);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "PagoConTarjeta";
            Text = "PagoConTarjeta";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label labelNumeroTarjeta;
        private Label labelVence;
        private Label labelCVV;
        private Label labelCorreo;
        private Label label1;
        private Label label2;
        private TextBox textBoxNumero;
        private TextBox textBoxExpira;
        private TextBox textBoxCVV;
        private TextBox textBoxCorreo;
        private TextBox textBoxNombre;
        private TextBox textBoxNumContacto;
        private Button buttonPagar;
    }
}