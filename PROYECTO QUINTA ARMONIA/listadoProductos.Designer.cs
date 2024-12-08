namespace PROYECTO_QUINTA_ARMONIA
{
    partial class listadoProductos
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
            dataGridView1 = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            existencias = new DataGridViewTextBoxColumn();
            baseDatosBindingSource = new BindingSource(components);
            buttonRedondoCancelar = new WinFormsAppKhee.ButtonRedondo();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)baseDatosBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(342, 60);
            label1.Name = "label1";
            label1.Size = new Size(215, 23);
            label1.TabIndex = 0;
            label1.Text = "LISTADO DE PRODUCTOS";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = Color.FromArgb(201, 221, 243);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { codigo, nombre, descripcion, precio, existencias });
            dataGridView1.Location = new Point(90, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(723, 339);
            dataGridView1.TabIndex = 1;
            // 
            // codigo
            // 
            codigo.HeaderText = "ID";
            codigo.MinimumWidth = 6;
            codigo.Name = "codigo";
            codigo.ReadOnly = true;
            codigo.Width = 35;
            // 
            // nombre
            // 
            nombre.HeaderText = "NOMBRE";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 125;
            // 
            // descripcion
            // 
            descripcion.HeaderText = "DESCRIPCIÓN";
            descripcion.MinimumWidth = 6;
            descripcion.Name = "descripcion";
            descripcion.ReadOnly = true;
            descripcion.Width = 300;
            // 
            // precio
            // 
            precio.HeaderText = "PRECIO";
            precio.MinimumWidth = 6;
            precio.Name = "precio";
            precio.ReadOnly = true;
            precio.Width = 90;
            // 
            // existencias
            // 
            existencias.HeaderText = "EXISTENCIAS";
            existencias.MinimumWidth = 6;
            existencias.Name = "existencias";
            existencias.ReadOnly = true;
            existencias.Width = 125;
            // 
            // baseDatosBindingSource
            // 
            baseDatosBindingSource.DataSource = typeof(BaseDatos);
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
            buttonRedondoCancelar.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRedondoCancelar.ForeColor = Color.White;
            buttonRedondoCancelar.Location = new Point(364, 470);
            buttonRedondoCancelar.Name = "buttonRedondoCancelar";
            buttonRedondoCancelar.Size = new Size(162, 45);
            buttonRedondoCancelar.TabIndex = 2;
            buttonRedondoCancelar.Text = "REGRESAR";
            buttonRedondoCancelar.TextColor = Color.White;
            buttonRedondoCancelar.UseVisualStyleBackColor = false;
            buttonRedondoCancelar.Click += buttonRedondoCancelar_Click;
            // 
            // listadoProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_listado;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(957, 608);
            Controls.Add(buttonRedondoCancelar);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "listadoProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "listadoProductos";
            Load += listadoProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)baseDatosBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private BindingSource baseDatosBindingSource;
        private WinFormsAppKhee.ButtonRedondo buttonRedondoCancelar;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn existencias;
    }
}