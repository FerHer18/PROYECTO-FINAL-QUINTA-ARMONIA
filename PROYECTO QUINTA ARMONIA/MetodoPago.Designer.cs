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
            buttonEfectivo = new Button();
            pictureBoxEfe = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMaster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOxxo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTitulo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEfe).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(402, 106);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(339, 25);
            label1.TabIndex = 0;
            label1.Text = "POR FAVOR ELIGE TU METODO DE PAGO";
            label1.Click += label1_Click;
            // 
            // buttonTarjeta
            // 
            buttonTarjeta.Location = new Point(471, 374);
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
            buttonOxxo.Location = new Point(849, 374);
            buttonOxxo.Margin = new Padding(4, 4, 4, 4);
            buttonOxxo.Name = "buttonOxxo";
            buttonOxxo.Size = new Size(230, 96);
            buttonOxxo.TabIndex = 2;
            buttonOxxo.Text = "OXXO";
            buttonOxxo.UseVisualStyleBackColor = true;
            // 
            // pictureBoxMaster
            // 
            pictureBoxMaster.Image = Properties.Resources.logo_Mastercard;
            pictureBoxMaster.Location = new Point(522, 296);
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
            pictureBoxOxxo.Location = new Point(908, 296);
            pictureBoxOxxo.Margin = new Padding(4, 4, 4, 4);
            pictureBoxOxxo.Name = "pictureBoxOxxo";
            pictureBoxOxxo.Size = new Size(112, 70);
            pictureBoxOxxo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxOxxo.TabIndex = 4;
            pictureBoxOxxo.TabStop = false;
            // 
            // pictureBoxTitulo
            // 
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
            pictureBoxLogo.Image = Properties.Resources.Recursos__1__removebg_preview;
            pictureBoxLogo.Location = new Point(849, 48);
            pictureBoxLogo.Margin = new Padding(4, 4, 4, 4);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(238, 129);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 6;
            pictureBoxLogo.TabStop = false;
            // 
            // buttonEfectivo
            // 
            buttonEfectivo.Location = new Point(86, 374);
            buttonEfectivo.Margin = new Padding(4, 4, 4, 4);
            buttonEfectivo.Name = "buttonEfectivo";
            buttonEfectivo.Size = new Size(230, 96);
            buttonEfectivo.TabIndex = 7;
            buttonEfectivo.Text = "EFECTIVO";
            buttonEfectivo.UseVisualStyleBackColor = true;
            // 
            // pictureBoxEfe
            // 
            pictureBoxEfe.Image = Properties.Resources._5886e1740ded23575a69d032c25af805;
            pictureBoxEfe.Location = new Point(136, 296);
            pictureBoxEfe.Margin = new Padding(4, 4, 4, 4);
            pictureBoxEfe.Name = "pictureBoxEfe";
            pictureBoxEfe.Size = new Size(139, 70);
            pictureBoxEfe.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxEfe.TabIndex = 8;
            pictureBoxEfe.TabStop = false;
            // 
            // MetodoPago
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 596);
            Controls.Add(pictureBoxEfe);
            Controls.Add(buttonEfectivo);
            Controls.Add(pictureBoxLogo);
            Controls.Add(pictureBoxTitulo);
            Controls.Add(pictureBoxOxxo);
            Controls.Add(pictureBoxMaster);
            Controls.Add(buttonOxxo);
            Controls.Add(buttonTarjeta);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "MetodoPago";
            Text = "MetodoPago";
            Load += MetodoPago_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxMaster).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOxxo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTitulo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEfe).EndInit();
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
        private Button buttonEfectivo;
        private PictureBox pictureBoxEfe;
    }
}