﻿namespace PROYECTO_QUINTA_ARMONIA
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
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Recursos4;
            pictureBox1.Location = new Point(-3, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(547, 594);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Beige;
            pictureBox2.Image = Properties.Resources.Letras_removebg_preview1;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(190, 109);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Beige;
            pictureBox3.Image = Properties.Resources.Recursos__1__removebg_preview1;
            pictureBox3.Location = new Point(342, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(190, 109);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // buttonGenerar
            // 
            buttonGenerar.BackColor = Color.PaleGoldenrod;
            buttonGenerar.Location = new Point(385, 507);
            buttonGenerar.Name = "buttonGenerar";
            buttonGenerar.Size = new Size(147, 60);
            buttonGenerar.TabIndex = 16;
            buttonGenerar.Text = "GENERAR";
            buttonGenerar.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(131, 143);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(284, 358);
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // PagoEnOxxo2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 579);
            Controls.Add(pictureBox4);
            Controls.Add(buttonGenerar);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "PagoEnOxxo2";
            Text = "PagoEnOxxo2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button buttonGenerar;
        private PictureBox pictureBox4;
    }
}