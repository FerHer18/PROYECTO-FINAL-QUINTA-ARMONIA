namespace PROYECTO_QUINTA_ARMONIA
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
            label1 = new Label();
            buttonRedondoCancelar = new WinFormsAppKhee.ButtonRedondo();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            USUARIO = new DataGridViewTextBoxColumn();
            MONTO = new DataGridViewTextBoxColumn();
            label2 = new Label();
            txtTotal = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(284, 64);
            label1.Name = "label1";
            label1.Size = new Size(245, 38);
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
            buttonRedondoCancelar.FlatStyle = FlatStyle.Flat;
            buttonRedondoCancelar.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRedondoCancelar.ForeColor = Color.White;
            buttonRedondoCancelar.Location = new Point(336, 517);
            buttonRedondoCancelar.Name = "buttonRedondoCancelar";
            buttonRedondoCancelar.Size = new Size(166, 45);
            buttonRedondoCancelar.TabIndex = 3;
            buttonRedondoCancelar.Text = "REGRESAR";
            buttonRedondoCancelar.TextColor = Color.White;
            buttonRedondoCancelar.UseVisualStyleBackColor = false;
            buttonRedondoCancelar.Click += buttonRedondoCancelar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(191, 210, 238);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, USUARIO, MONTO });
            dataGridView1.Location = new Point(131, 184);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(601, 200);
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
            label2.Location = new Point(162, 441);
            label2.Name = "label2";
            label2.Size = new Size(230, 38);
            label2.TabIndex = 5;
            label2.Text = "Total en ventas: ";
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(430, 441);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(238, 40);
            txtTotal.TabIndex = 6;
            txtTotal.TextChanged += textBox1_TextChanged;
            // 
            // ventasTotales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_listado;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(886, 663);
            Controls.Add(txtTotal);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(buttonRedondoCancelar);
            Controls.Add(label1);
            DoubleBuffered = true;
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
    }
}