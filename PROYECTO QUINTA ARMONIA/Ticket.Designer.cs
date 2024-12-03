namespace PROYECTO_QUINTA_ARMONIA
{
    partial class Ticket
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
            labelResumen = new Label();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            buttonRegresar = new Button();
            buttonContinuar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Recursos;
            pictureBox1.Location = new Point(7, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(642, 837);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // labelResumen
            // 
            labelResumen.AutoSize = true;
            labelResumen.BackColor = Color.Beige;
            labelResumen.Font = new Font("Lucida Fax", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelResumen.Location = new Point(25, 22);
            labelResumen.Name = "labelResumen";
            labelResumen.Size = new Size(339, 26);
            labelResumen.TabIndex = 1;
            labelResumen.Text = "TU RESUMEN DE COMPRA ES";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Beige;
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Image = Properties.Resources.depositphotos_119273698_stock_illustration_emoticon_with_happy_face_removebg_preview;
            pictureBox4.Location = new Point(375, 18);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(37, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Recursos3;
            pictureBox5.Location = new Point(168, 66);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(323, 620);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // buttonRegresar
            // 
            buttonRegresar.BackColor = Color.Beige;
            buttonRegresar.BackgroundImage = Properties.Resources.flechaAtras1;
            buttonRegresar.BackgroundImageLayout = ImageLayout.Stretch;
            buttonRegresar.FlatAppearance.BorderSize = 0;
            buttonRegresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegresar.Location = new Point(7, 703);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(150, 63);
            buttonRegresar.TabIndex = 9;
            buttonRegresar.Text = "REGRESAR";
            buttonRegresar.UseVisualStyleBackColor = false;
            // 
            // buttonContinuar
            // 
            buttonContinuar.BackColor = Color.Beige;
            buttonContinuar.BackgroundImage = Properties.Resources.flechaAdelante;
            buttonContinuar.BackgroundImageLayout = ImageLayout.Stretch;
            buttonContinuar.FlatAppearance.BorderSize = 0;
            buttonContinuar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonContinuar.Location = new Point(484, 700);
            buttonContinuar.Name = "buttonContinuar";
            buttonContinuar.Size = new Size(150, 63);
            buttonContinuar.TabIndex = 10;
            buttonContinuar.Text = "CONTINUAR";
            buttonContinuar.UseVisualStyleBackColor = false;
            buttonContinuar.Click += buttonContinuar_Click_1;
            // 
            // Ticket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 775);
            Controls.Add(buttonContinuar);
            Controls.Add(buttonRegresar);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(labelResumen);
            Controls.Add(pictureBox1);
            Name = "Ticket";
            Text = "Ticket";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelResumen;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button buttonRegresar;
        private Button buttonContinuar;
    }
}