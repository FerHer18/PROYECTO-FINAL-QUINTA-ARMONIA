namespace PROYECTO_QUINTA_ARMONIA
{
    partial class PagoEnOxxo2
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
            buttonGenerar = new Button();
            pictureBoxQR = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQR).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Recursos4;
            pictureBox1.Location = new Point(-5, -2);
            pictureBox1.Margin = new Padding(5, 5, 5, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(889, 950);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Beige;
            pictureBox2.Image = Properties.Resources.Letras_removebg_preview1;
            pictureBox2.Location = new Point(20, 19);
            pictureBox2.Margin = new Padding(5, 5, 5, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(309, 174);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Beige;
            pictureBox3.Image = Properties.Resources.Recursos__1__removebg_preview1;
            pictureBox3.Location = new Point(556, 19);
            pictureBox3.Margin = new Padding(5, 5, 5, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(309, 174);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // buttonGenerar
            // 
            buttonGenerar.BackColor = Color.PaleGoldenrod;
            buttonGenerar.Location = new Point(626, 811);
            buttonGenerar.Margin = new Padding(5, 5, 5, 5);
            buttonGenerar.Name = "buttonGenerar";
            buttonGenerar.Size = new Size(239, 96);
            buttonGenerar.TabIndex = 16;
            buttonGenerar.Text = "GENERAR";
            buttonGenerar.UseVisualStyleBackColor = false;
            buttonGenerar.Click += buttonGenerar_Click;
            // 
            // pictureBoxQR
            // 
            pictureBoxQR.Location = new Point(187, 274);
            pictureBoxQR.Margin = new Padding(5, 5, 5, 5);
            pictureBoxQR.Name = "pictureBoxQR";
            pictureBoxQR.Size = new Size(462, 454);
            pictureBoxQR.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxQR.TabIndex = 17;
            pictureBoxQR.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Beige;
            label1.Font = new Font("Sylfaen", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(20, 843);
            label1.Name = "label1";
            label1.Size = new Size(567, 35);
            label1.TabIndex = 18;
            label1.Text = "Escanea este código en tu OXXO más cercano";
            // 
            // PagoEnOxxo2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 926);
            Controls.Add(label1);
            Controls.Add(pictureBoxQR);
            Controls.Add(buttonGenerar);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "PagoEnOxxo2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PagoEnOxxo2";
            Load += PagoEnOxxo2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button buttonGenerar;
        private PictureBox pictureBox4;
        private Label label1;
        private PictureBox pictureBoxQR;
    }
}