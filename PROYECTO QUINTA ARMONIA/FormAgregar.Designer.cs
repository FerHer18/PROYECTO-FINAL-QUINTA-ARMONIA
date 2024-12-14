namespace PROYECTO_QUINTA_ARMONIA
{
    partial class FormAgregar
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
            buttonRedondoCancelar = new WinFormsAppKhee.ButtonRedondo();
            buttonRedondoConfirmar = new WinFormsAppKhee.ButtonRedondo();
            labelCodigo = new Label();
            labelDescrip = new Label();
            labelPrecio = new Label();
            labelCantidad = new Label();
            textBoxCodigo = new TextBox();
            textBoxDescrip = new TextBox();
            textBoxPrecio = new TextBox();
            textBoxExistencias = new TextBox();
            labelNombre = new Label();
            textBoxNombre = new TextBox();
            btnCargarImagen = new WinFormsAppKhee.ButtonRedondo();
            picBoxImagen = new PictureBox();
            label1 = new Label();
            lblHora = new Label();
            lblFecha = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picBoxImagen).BeginInit();
            SuspendLayout();
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
            buttonRedondoCancelar.ForeColor = Color.White;
            buttonRedondoCancelar.Location = new Point(492, 379);
            buttonRedondoCancelar.Name = "buttonRedondoCancelar";
            buttonRedondoCancelar.Size = new Size(129, 45);
            buttonRedondoCancelar.TabIndex = 0;
            buttonRedondoCancelar.TextColor = Color.White;
            buttonRedondoCancelar.UseVisualStyleBackColor = false;
            buttonRedondoCancelar.Click += buttonRedondoCancelar_Click;
            // 
            // buttonRedondoConfirmar
            // 
            buttonRedondoConfirmar.BackColor = Color.Transparent;
            buttonRedondoConfirmar.BackgroundColor = Color.Transparent;
            buttonRedondoConfirmar.BorderColor = Color.Transparent;
            buttonRedondoConfirmar.BorderRadius = 0;
            buttonRedondoConfirmar.BorderSize = 0;
            buttonRedondoConfirmar.FlatAppearance.BorderSize = 0;
            buttonRedondoConfirmar.FlatStyle = FlatStyle.Flat;
            buttonRedondoConfirmar.ForeColor = Color.White;
            buttonRedondoConfirmar.Location = new Point(216, 375);
            buttonRedondoConfirmar.Name = "buttonRedondoConfirmar";
            buttonRedondoConfirmar.Size = new Size(118, 53);
            buttonRedondoConfirmar.TabIndex = 1;
            buttonRedondoConfirmar.TextColor = Color.White;
            buttonRedondoConfirmar.UseVisualStyleBackColor = false;
            buttonRedondoConfirmar.Click += buttonRedondoConfirmar_Click;
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.BackColor = Color.Transparent;
            labelCodigo.Location = new Point(109, 136);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(155, 20);
            labelCodigo.TabIndex = 2;
            labelCodigo.Text = "Codigo del producto: ";
            // 
            // labelDescrip
            // 
            labelDescrip.AutoSize = true;
            labelDescrip.BackColor = Color.Transparent;
            labelDescrip.Location = new Point(103, 228);
            labelDescrip.Name = "labelDescrip";
            labelDescrip.Size = new Size(180, 20);
            labelDescrip.TabIndex = 3;
            labelDescrip.Text = "Descripción del producto:";
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.BackColor = Color.Transparent;
            labelPrecio.Location = new Point(105, 271);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(143, 20);
            labelPrecio.TabIndex = 4;
            labelPrecio.Text = "Precio del producto:";
            // 
            // labelCantidad
            // 
            labelCantidad.AutoSize = true;
            labelCantidad.BackColor = Color.Transparent;
            labelCantidad.Location = new Point(103, 318);
            labelCantidad.Name = "labelCantidad";
            labelCantidad.Size = new Size(162, 20);
            labelCantidad.TabIndex = 5;
            labelCantidad.Text = "Cantidad del producto:";
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Location = new Point(293, 133);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.PlaceholderText = "Codigo";
            textBoxCodigo.Size = new Size(167, 27);
            textBoxCodigo.TabIndex = 6;
            textBoxCodigo.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxDescrip
            // 
            textBoxDescrip.Location = new Point(293, 221);
            textBoxDescrip.Name = "textBoxDescrip";
            textBoxDescrip.PlaceholderText = "Descripcion";
            textBoxDescrip.Size = new Size(167, 27);
            textBoxDescrip.TabIndex = 7;
            textBoxDescrip.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Location = new Point(293, 268);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.PlaceholderText = "Precio";
            textBoxPrecio.Size = new Size(167, 27);
            textBoxPrecio.TabIndex = 8;
            textBoxPrecio.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxExistencias
            // 
            textBoxExistencias.Location = new Point(293, 311);
            textBoxExistencias.Name = "textBoxExistencias";
            textBoxExistencias.PlaceholderText = "Cantidad";
            textBoxExistencias.Size = new Size(167, 27);
            textBoxExistencias.TabIndex = 9;
            textBoxExistencias.TextAlign = HorizontalAlignment.Center;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.BackColor = Color.Transparent;
            labelNombre.Location = new Point(103, 183);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(157, 20);
            labelNombre.TabIndex = 10;
            labelNombre.Text = "Nombre del producto:";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(293, 176);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.PlaceholderText = "Nombre";
            textBoxNombre.Size = new Size(167, 27);
            textBoxNombre.TabIndex = 11;
            textBoxNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCargarImagen
            // 
            btnCargarImagen.BackColor = Color.Transparent;
            btnCargarImagen.BackgroundColor = Color.Transparent;
            btnCargarImagen.BackgroundImageLayout = ImageLayout.Stretch;
            btnCargarImagen.BorderColor = Color.Transparent;
            btnCargarImagen.BorderRadius = 0;
            btnCargarImagen.BorderSize = 0;
            btnCargarImagen.FlatAppearance.BorderSize = 0;
            btnCargarImagen.FlatStyle = FlatStyle.Flat;
            btnCargarImagen.ForeColor = Color.White;
            btnCargarImagen.Location = new Point(523, 128);
            btnCargarImagen.Name = "btnCargarImagen";
            btnCargarImagen.Size = new Size(108, 36);
            btnCargarImagen.TabIndex = 15;
            btnCargarImagen.TextColor = Color.White;
            btnCargarImagen.UseVisualStyleBackColor = false;
            btnCargarImagen.Click += btnCargarImagen_Click;
            // 
            // picBoxImagen
            // 
            picBoxImagen.BackColor = Color.Transparent;
            picBoxImagen.Location = new Point(492, 184);
            picBoxImagen.Name = "picBoxImagen";
            picBoxImagen.Size = new Size(170, 154);
            picBoxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxImagen.TabIndex = 16;
            picBoxImagen.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(293, 57);
            label1.Name = "label1";
            label1.Size = new Size(186, 23);
            label1.TabIndex = 17;
            label1.Text = "AGREGAR PRODUCTO";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.BackColor = Color.Transparent;
            lblHora.Font = new Font("Sylfaen", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHora.ForeColor = SystemColors.ButtonHighlight;
            lblHora.Location = new Point(711, -2);
            lblHora.Margin = new Padding(2, 0, 2, 0);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(50, 22);
            lblHora.TabIndex = 32;
            lblHora.Text = "Hora";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Font = new Font("Sylfaen", 6F, FontStyle.Bold);
            lblFecha.ForeColor = SystemColors.ButtonHighlight;
            lblFecha.Location = new Point(0, 6);
            lblFecha.Margin = new Padding(2, 0, 2, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(37, 14);
            lblFecha.TabIndex = 33;
            lblFecha.Text = "Fecha";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // FormAgregar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondoAgregar;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(809, 513);
            Controls.Add(lblFecha);
            Controls.Add(lblHora);
            Controls.Add(label1);
            Controls.Add(picBoxImagen);
            Controls.Add(btnCargarImagen);
            Controls.Add(textBoxNombre);
            Controls.Add(labelNombre);
            Controls.Add(textBoxExistencias);
            Controls.Add(textBoxPrecio);
            Controls.Add(textBoxDescrip);
            Controls.Add(textBoxCodigo);
            Controls.Add(labelCantidad);
            Controls.Add(labelPrecio);
            Controls.Add(labelDescrip);
            Controls.Add(labelCodigo);
            Controls.Add(buttonRedondoConfirmar);
            Controls.Add(buttonRedondoCancelar);
            DoubleBuffered = true;
            Name = "FormAgregar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAgregar";
            Load += FormAgregar_Load;
            ((System.ComponentModel.ISupportInitialize)picBoxImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private WinFormsAppKhee.ButtonRedondo buttonRedondoCancelar;
        private WinFormsAppKhee.ButtonRedondo buttonRedondoConfirmar;
        private Label labelCodigo;
        private Label labelDescrip;
        private Label labelPrecio;
        private Label labelCantidad;
        private TextBox textBoxCodigo;
        private TextBox textBoxDescrip;
        private TextBox textBoxPrecio;
        private TextBox textBoxExistencias;
        private Label labelNombre;
        private TextBox textBoxNombre;
        private WinFormsAppKhee.ButtonRedondo btnCargarImagen;
        private PictureBox picBoxImagen;
        private Label label1;
        private Label lblHora;
        private Label lblFecha;
        private System.Windows.Forms.Timer timer1;
    }
}