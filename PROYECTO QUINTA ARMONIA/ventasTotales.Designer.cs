﻿namespace PROYECTO_QUINTA_ARMONIA
{
    partial class ventasTotales
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
            label1 = new Label();
            buttonRedondoCancelar = new WinFormsAppKhee.ButtonRedondo();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            USUARIO = new DataGridViewTextBoxColumn();
            MONTO = new DataGridViewTextBoxColumn();
            label2 = new Label();
            txtTotal = new TextBox();
            lblFecha = new Label();
            lblHora = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            labelHola = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(374, 97);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(290, 45);
            label1.TabIndex = 1;
            label1.Text = "VENTAS TOTALES";
            label1.Click += label1_Click;
            // 
            // buttonRedondoCancelar
            // 
            buttonRedondoCancelar.BackColor = Color.Transparent;
            buttonRedondoCancelar.BackgroundColor = Color.Transparent;
            buttonRedondoCancelar.BorderColor = Color.Transparent;
            buttonRedondoCancelar.BorderRadius = 0;
            buttonRedondoCancelar.BorderSize = 0;
            buttonRedondoCancelar.FlatAppearance.BorderSize = 0;
            buttonRedondoCancelar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonRedondoCancelar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonRedondoCancelar.FlatStyle = FlatStyle.Flat;
            buttonRedondoCancelar.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRedondoCancelar.ForeColor = Color.White;
            buttonRedondoCancelar.Location = new Point(406, 646);
            buttonRedondoCancelar.Margin = new Padding(4);
            buttonRedondoCancelar.Name = "buttonRedondoCancelar";
            buttonRedondoCancelar.Size = new Size(222, 72);
            buttonRedondoCancelar.TabIndex = 3;
            buttonRedondoCancelar.TextColor = Color.White;
            buttonRedondoCancelar.UseVisualStyleBackColor = false;
            buttonRedondoCancelar.Click += buttonRedondoCancelar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(191, 210, 238);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, USUARIO, MONTO });
            dataGridView1.Location = new Point(164, 230);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(751, 250);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // USUARIO
            // 
            USUARIO.HeaderText = "NOMBRE";
            USUARIO.MinimumWidth = 6;
            USUARIO.Name = "USUARIO";
            USUARIO.ReadOnly = true;
            USUARIO.Width = 300;
            // 
            // MONTO
            // 
            MONTO.HeaderText = "MONTO";
            MONTO.MinimumWidth = 6;
            MONTO.Name = "MONTO";
            MONTO.ReadOnly = true;
            MONTO.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(202, 551);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(272, 45);
            label2.TabIndex = 5;
            label2.Text = "Total en ventas: ";
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(536, 568);
            txtTotal.Margin = new Padding(4);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(296, 47);
            txtTotal.TabIndex = 6;
            txtTotal.TextChanged += textBox1_TextChanged;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Font = new Font("Sylfaen", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFecha.ForeColor = SystemColors.ButtonHighlight;
            lblFecha.Location = new Point(2, 11);
            lblFecha.Margin = new Padding(2, 0, 2, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(58, 23);
            lblFecha.TabIndex = 35;
            lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.BackColor = Color.Transparent;
            lblHora.Font = new Font("Sylfaen", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHora.ForeColor = SystemColors.ButtonHighlight;
            lblHora.Location = new Point(1012, 11);
            lblHora.Margin = new Padding(2, 0, 2, 0);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(60, 26);
            lblHora.TabIndex = 34;
            lblHora.Text = "Hora";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // labelHola
            // 
            labelHola.BackColor = Color.Transparent;
            labelHola.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHola.Location = new Point(179, 102);
            labelHola.Name = "labelHola";
            labelHola.Size = new Size(200, 38);
            labelHola.TabIndex = 39;
            // 
            // ventasTotales
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondoVentas;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1108, 829);
            Controls.Add(labelHola);
            Controls.Add(lblFecha);
            Controls.Add(lblHora);
            Controls.Add(txtTotal);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(buttonRedondoCancelar);
            Controls.Add(label1);
            DoubleBuffered = true;
            Margin = new Padding(4);
            Name = "ventasTotales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ventasTotales";
            Load += ventasTotales_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private WinFormsAppKhee.ButtonRedondo buttonRedondoCancelar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn USUARIO;
        private DataGridViewTextBoxColumn MONTO;
        private Label label2;
        private TextBox txtTotal;
        private Label lblFecha;
        private Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private Label labelHola;
    }
}