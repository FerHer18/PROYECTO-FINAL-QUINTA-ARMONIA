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
            components = new System.ComponentModel.Container();
            labelResumen = new Label();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            buttonContinuar = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            txtSub = new TextBox();
            label6 = new Label();
            txtIva = new TextBox();
            label7 = new Label();
            txtTotal = new TextBox();
            label8 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            dataGridViewCompras = new DataGridView();
            label10 = new Label();
            lblFecha = new Label();
            lblHora = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCompras).BeginInit();
            SuspendLayout();
            // 
            // labelResumen
            // 
            labelResumen.AutoSize = true;
            labelResumen.BackColor = Color.Beige;
            labelResumen.Font = new Font("Lucida Fax", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelResumen.Location = new Point(219, 47);
            labelResumen.Name = "labelResumen";
            labelResumen.Size = new Size(215, 26);
            labelResumen.TabIndex = 1;
            labelResumen.Text = "TU COMPRA FUE: ";
            labelResumen.Click += labelResumen_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Beige;
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Image = Properties.Resources.depositphotos_119273698_stock_illustration_emoticon_with_happy_face_removebg_preview;
            pictureBox4.Location = new Point(432, 47);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(37, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.Location = new Point(57, 90);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(580, 688);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // buttonContinuar
            // 
            buttonContinuar.BackColor = Color.FromArgb(241, 231, 199);
            buttonContinuar.BackgroundImage = Properties.Resources.flechaAdelante;
            buttonContinuar.BackgroundImageLayout = ImageLayout.Stretch;
            buttonContinuar.FlatAppearance.BorderSize = 0;
            buttonContinuar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonContinuar.Location = new Point(684, 692);
            buttonContinuar.Name = "buttonContinuar";
            buttonContinuar.Size = new Size(135, 86);
            buttonContinuar.TabIndex = 10;
            buttonContinuar.Text = "DESCARGAR COMPROBANTE";
            buttonContinuar.UseVisualStyleBackColor = false;
            buttonContinuar.Click += buttonContinuar_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = Properties.Resources.Letras_removebg_preview2;
            pictureBox2.Location = new Point(57, 90);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(172, 102);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = Properties.Resources.Recursos__1__removebg_preview2;
            pictureBox3.Location = new Point(479, 90);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(158, 102);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(456, 633);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 55;
            label5.Text = "Sub-Total";
            // 
            // txtSub
            // 
            txtSub.BackColor = Color.White;
            txtSub.Enabled = false;
            txtSub.Location = new Point(553, 626);
            txtSub.Multiline = true;
            txtSub.Name = "txtSub";
            txtSub.ReadOnly = true;
            txtSub.Size = new Size(69, 27);
            txtSub.TabIndex = 56;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Location = new Point(492, 662);
            label6.Name = "label6";
            label6.Size = new Size(31, 20);
            label6.TabIndex = 57;
            label6.Text = "IVA";
            label6.Click += label6_Click;
            // 
            // txtIva
            // 
            txtIva.BackColor = Color.White;
            txtIva.Enabled = false;
            txtIva.Location = new Point(553, 659);
            txtIva.Multiline = true;
            txtIva.Name = "txtIva";
            txtIva.ReadOnly = true;
            txtIva.Size = new Size(69, 27);
            txtIva.TabIndex = 58;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Location = new Point(479, 695);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 59;
            label7.Text = "TOTAL";
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.White;
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(553, 695);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(69, 27);
            txtTotal.TabIndex = 60;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(125, 633);
            label8.Name = "label8";
            label8.Size = new Size(309, 38);
            label8.TabIndex = 61;
            label8.Text = "¡Gracias por su compra!";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(172, 669);
            label9.Name = "label9";
            label9.Size = new Size(175, 28);
            label9.TabIndex = 50;
            label9.Text = "Si requiere factura ";
            label9.Click += label9_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(65, 221);
            panel1.Name = "panel1";
            panel1.Size = new Size(557, 10);
            panel1.TabIndex = 66;
            // 
            // panel3
            // 
            panel3.Location = new Point(65, 604);
            panel3.Name = "panel3";
            panel3.Size = new Size(557, 11);
            panel3.TabIndex = 68;
            // 
            // panel4
            // 
            panel4.Location = new Point(69, 728);
            panel4.Name = "panel4";
            panel4.Size = new Size(561, 10);
            panel4.TabIndex = 69;
            // 
            // dataGridViewCompras
            // 
            dataGridViewCompras.AllowUserToAddRows = false;
            dataGridViewCompras.AllowUserToDeleteRows = false;
            dataGridViewCompras.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCompras.Enabled = false;
            dataGridViewCompras.Location = new Point(66, 237);
            dataGridViewCompras.Name = "dataGridViewCompras";
            dataGridViewCompras.ReadOnly = true;
            dataGridViewCompras.RowHeadersWidth = 51;
            dataGridViewCompras.Size = new Size(556, 361);
            dataGridViewCompras.TabIndex = 70;
            dataGridViewCompras.CellContentClick += dataGridViewCompras_CellContentClick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(153, 697);
            label10.Name = "label10";
            label10.Size = new Size(211, 28);
            label10.TabIndex = 71;
            label10.Text = "visite nuetsro sitio web";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.White;
            lblFecha.Font = new Font("Segoe UI", 10F);
            lblFecha.Location = new Point(66, 195);
            lblFecha.Margin = new Padding(2, 0, 2, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(54, 23);
            lblFecha.TabIndex = 72;
            lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.BackColor = Color.White;
            lblHora.Font = new Font("Segoe UI", 10F);
            lblHora.Location = new Point(536, 195);
            lblHora.Margin = new Padding(2, 0, 2, 0);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(47, 23);
            lblHora.TabIndex = 73;
            lblHora.Text = "Hora";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Ticket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 231, 199);
            ClientSize = new Size(840, 806);
            Controls.Add(lblHora);
            Controls.Add(lblFecha);
            Controls.Add(label10);
            Controls.Add(dataGridViewCompras);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtTotal);
            Controls.Add(label7);
            Controls.Add(txtIva);
            Controls.Add(label6);
            Controls.Add(txtSub);
            Controls.Add(label5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(buttonContinuar);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(labelResumen);
            Name = "Ticket";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ticket";
            Load += Ticket_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCompras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelResumen;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button buttonContinuar;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label5;
        private TextBox txtSub;
        private Label label6;
        private TextBox txtIva;
        private Label label7;
        private TextBox txtTotal;
        private Label label8;
        private Label label9;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private DataGridView dataGridViewCompras;
        private Label label10;
        private Label lblFecha;
        private Label lblHora;
        private System.Windows.Forms.Timer timer1;
    }
}