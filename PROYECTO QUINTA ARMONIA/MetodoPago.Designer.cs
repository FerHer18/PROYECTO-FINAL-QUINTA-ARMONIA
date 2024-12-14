namespace PROYECTO_QUINTA_ARMONIA
{
    partial class MetodoPago
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
            label1 = new Label();
            buttonTarjeta = new Button();
            buttonOxxo = new Button();
            pictureBoxMaster = new PictureBox();
            pictureBoxOxxo = new PictureBox();
            pictureBoxTitulo = new PictureBox();
            pictureBoxLogo = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMaster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOxxo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTitulo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Beige;
            label1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(410, 185);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(368, 24);
            label1.TabIndex = 0;
            label1.Text = "POR FAVOR ELIGE TU METODO DE PAGO";
            label1.Click += label1_Click;
            // 
            // buttonTarjeta
            // 
            buttonTarjeta.Location = new Point(204, 374);
            buttonTarjeta.Margin = new Padding(4, 4, 4, 4);
            buttonTarjeta.Name = "buttonTarjeta";
            buttonTarjeta.Size = new Size(230, 96);
            buttonTarjeta.TabIndex = 1;
            buttonTarjeta.Text = "TARJETA DEBITO/CREDITO";
            buttonTarjeta.UseVisualStyleBackColor = true;
            buttonTarjeta.Click += buttonTarjeta_Click;
            // 
            // buttonOxxo
            // 
            buttonOxxo.Location = new Point(789, 374);
            buttonOxxo.Margin = new Padding(4, 4, 4, 4);
            buttonOxxo.Name = "buttonOxxo";
            buttonOxxo.Size = new Size(230, 96);
            buttonOxxo.TabIndex = 2;
            buttonOxxo.Text = "OXXO";
            buttonOxxo.UseVisualStyleBackColor = true;
            buttonOxxo.Click += buttonOxxo_Click;
            // 
            // pictureBoxMaster
            // 
            pictureBoxMaster.BackColor = Color.Beige;
            pictureBoxMaster.Image = Properties.Resources.logo_Mastercard;
            pictureBoxMaster.Location = new Point(254, 282);
            pictureBoxMaster.Margin = new Padding(4, 4, 4, 4);
            pictureBoxMaster.Name = "pictureBoxMaster";
            pictureBoxMaster.Size = new Size(139, 70);
            pictureBoxMaster.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMaster.TabIndex = 3;
            pictureBoxMaster.TabStop = false;
            // 
            // pictureBoxOxxo
            // 
            pictureBoxOxxo.Image = Properties.Resources.images;
            pictureBoxOxxo.Location = new Point(849, 282);
            pictureBoxOxxo.Margin = new Padding(4, 4, 4, 4);
            pictureBoxOxxo.Name = "pictureBoxOxxo";
            pictureBoxOxxo.Size = new Size(112, 70);
            pictureBoxOxxo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxOxxo.TabIndex = 4;
            pictureBoxOxxo.TabStop = false;
            // 
            // pictureBoxTitulo
            // 
            pictureBoxTitulo.BackColor = Color.Beige;
            pictureBoxTitulo.Image = Properties.Resources.Letras_removebg_preview;
            pictureBoxTitulo.Location = new Point(75, 48);
            pictureBoxTitulo.Margin = new Padding(4, 4, 4, 4);
            pictureBoxTitulo.Name = "pictureBoxTitulo";
            pictureBoxTitulo.Size = new Size(241, 129);
            pictureBoxTitulo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTitulo.TabIndex = 5;
            pictureBoxTitulo.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.Beige;
            pictureBoxLogo.Image = Properties.Resources.Recursos__1__removebg_preview;
            pictureBoxLogo.Location = new Point(849, 48);
            pictureBoxLogo.Margin = new Padding(4, 4, 4, 4);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(238, 129);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 6;
            pictureBoxLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Recursos5;
            pictureBox1.Location = new Point(5, 4);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1124, 592);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // MetodoPago
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 596);
            Controls.Add(pictureBoxLogo);
            Controls.Add(pictureBoxTitulo);
            Controls.Add(pictureBoxOxxo);
            Controls.Add(pictureBoxMaster);
            Controls.Add(buttonOxxo);
            Controls.Add(buttonTarjeta);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "MetodoPago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MetodoPago";
            Load += MetodoPago_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxMaster).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOxxo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTitulo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonTarjeta;
        private Button buttonOxxo;
        private PictureBox pictureBoxMaster;
        private PictureBox pictureBoxOxxo;
        private PictureBox pictureBoxTitulo;
        private PictureBox pictureBoxLogo;
        private PictureBox pictureBox1;
    }
}