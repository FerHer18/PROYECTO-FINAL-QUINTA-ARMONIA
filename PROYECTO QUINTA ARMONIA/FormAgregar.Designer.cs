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
            labelHola = new Label();
            picBoxImagenNo = new PictureBox();
            buttonRedondo1 = new WinFormsAppKhee.ButtonRedondo();
            ((System.ComponentModel.ISupportInitialize)picBoxImagen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxImagenNo).BeginInit();
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
            buttonRedondoCancelar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonRedondoCancelar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonRedondoCancelar.FlatStyle = FlatStyle.Flat;
            buttonRedondoCancelar.ForeColor = Color.White;
            buttonRedondoCancelar.Location = new Point(597, 480);
            buttonRedondoCancelar.Name = "buttonRedondoCancelar";
            buttonRedondoCancelar.Size = new Size(137, 45);
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
            buttonRedondoConfirmar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonRedondoConfirmar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonRedondoConfirmar.FlatStyle = FlatStyle.Flat;
            buttonRedondoConfirmar.ForeColor = Color.White;
            buttonRedondoConfirmar.Location = new Point(311, 476);
            buttonRedondoConfirmar.Name = "buttonRedondoConfirmar";
            buttonRedondoConfirmar.Size = new Size(112, 52);
            buttonRedondoConfirmar.TabIndex = 1;
            buttonRedondoConfirmar.TextColor = Color.White;
            buttonRedondoConfirmar.UseVisualStyleBackColor = false;
            buttonRedondoConfirmar.Click += buttonRedondoConfirmar_Click;
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.BackColor = Color.Transparent;
            labelCodigo.Font = new Font("Segoe UI", 10F);
            labelCodigo.Location = new Point(66, 181);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(168, 23);
            labelCodigo.TabIndex = 2;
            labelCodigo.Text = "Codigo del producto";
            // 
            // labelDescrip
            // 
            labelDescrip.AutoSize = true;
            labelDescrip.BackColor = Color.Transparent;
            labelDescrip.Font = new Font("Segoe UI", 10F);
            labelDescrip.Location = new Point(33, 292);
            labelDescrip.Name = "labelDescrip";
            labelDescrip.Size = new Size(201, 23);
            labelDescrip.TabIndex = 3;
            labelDescrip.Text = "Descripción del producto";
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.BackColor = Color.Transparent;
            labelPrecio.Font = new Font("Segoe UI", 10F);
            labelPrecio.Location = new Point(74, 347);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(160, 23);
            labelPrecio.TabIndex = 4;
            labelPrecio.Text = "Precio del producto";
            // 
            // labelCantidad
            // 
            labelCantidad.AutoSize = true;
            labelCantidad.BackColor = Color.Transparent;
            labelCantidad.Font = new Font("Segoe UI", 10F);
            labelCantidad.Location = new Point(52, 402);
            labelCantidad.Name = "labelCantidad";
            labelCantidad.Size = new Size(182, 23);
            labelCantidad.TabIndex = 5;
            labelCantidad.Text = "Cantidad del producto";
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Font = new Font("Segoe UI", 11F);
            textBoxCodigo.Location = new Point(249, 179);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.PlaceholderText = "Codigo";
            textBoxCodigo.Size = new Size(224, 32);
            textBoxCodigo.TabIndex = 6;
            textBoxCodigo.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxDescrip
            // 
            textBoxDescrip.Font = new Font("Segoe UI", 11F);
            textBoxDescrip.Location = new Point(249, 290);
            textBoxDescrip.Name = "textBoxDescrip";
            textBoxDescrip.PlaceholderText = "Descripcion";
            textBoxDescrip.Size = new Size(224, 32);
            textBoxDescrip.TabIndex = 7;
            textBoxDescrip.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Font = new Font("Segoe UI", 11F);
            textBoxPrecio.Location = new Point(249, 345);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.PlaceholderText = "Precio";
            textBoxPrecio.Size = new Size(224, 32);
            textBoxPrecio.TabIndex = 8;
            textBoxPrecio.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxExistencias
            // 
            textBoxExistencias.Font = new Font("Segoe UI", 11F);
            textBoxExistencias.Location = new Point(249, 400);
            textBoxExistencias.Name = "textBoxExistencias";
            textBoxExistencias.PlaceholderText = "Cantidad";
            textBoxExistencias.Size = new Size(224, 32);
            textBoxExistencias.TabIndex = 9;
            textBoxExistencias.TextAlign = HorizontalAlignment.Center;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.BackColor = Color.Transparent;
            labelNombre.Font = new Font("Segoe UI", 10F);
            labelNombre.Location = new Point(58, 240);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(176, 23);
            labelNombre.TabIndex = 10;
            labelNombre.Text = "Nombre del producto";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Font = new Font("Segoe UI", 11F);
            textBoxNombre.Location = new Point(249, 234);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.PlaceholderText = "Nombre";
            textBoxNombre.Size = new Size(224, 32);
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
            btnCargarImagen.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCargarImagen.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCargarImagen.FlatStyle = FlatStyle.Flat;
            btnCargarImagen.ForeColor = Color.White;
            btnCargarImagen.Location = new Point(550, 149);
            btnCargarImagen.Name = "btnCargarImagen";
            btnCargarImagen.Size = new Size(142, 54);
            btnCargarImagen.TabIndex = 15;
            btnCargarImagen.TextColor = Color.White;
            btnCargarImagen.UseVisualStyleBackColor = false;
            btnCargarImagen.Click += btnCargarImagen_Click;
            // 
            // picBoxImagen
            // 
            picBoxImagen.BackColor = Color.Transparent;
            picBoxImagen.Location = new Point(527, 240);
            picBoxImagen.Name = "picBoxImagen";
            picBoxImagen.Size = new Size(216, 196);
            picBoxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxImagen.TabIndex = 16;
            picBoxImagen.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(390, 77);
            label1.Name = "label1";
            label1.Size = new Size(218, 28);
            label1.TabIndex = 17;
            label1.Text = "AGREGAR PRODUCTO";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.BackColor = Color.Transparent;
            lblHora.Font = new Font("Sylfaen", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHora.ForeColor = SystemColors.ButtonHighlight;
            lblHora.Location = new Point(1015, 9);
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
            // labelHola
            // 
            labelHola.BackColor = Color.Transparent;
            labelHola.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHola.Location = new Point(177, 79);
            labelHola.Margin = new Padding(2, 0, 2, 0);
            labelHola.Name = "labelHola";
            labelHola.Size = new Size(121, 30);
            labelHola.TabIndex = 34;
            // 
            // picBoxImagenNo
            // 
            picBoxImagenNo.BackColor = Color.Transparent;
            picBoxImagenNo.Location = new Point(780, 236);
            picBoxImagenNo.Name = "picBoxImagenNo";
            picBoxImagenNo.Size = new Size(214, 196);
            picBoxImagenNo.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxImagenNo.TabIndex = 35;
            picBoxImagenNo.TabStop = false;
            // 
            // buttonRedondo1
            // 
            buttonRedondo1.BackColor = Color.Transparent;
            buttonRedondo1.BackgroundColor = Color.Transparent;
            buttonRedondo1.BackgroundImageLayout = ImageLayout.Stretch;
            buttonRedondo1.BorderColor = Color.Transparent;
            buttonRedondo1.BorderRadius = 0;
            buttonRedondo1.BorderSize = 0;
            buttonRedondo1.FlatAppearance.BorderSize = 0;
            buttonRedondo1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonRedondo1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonRedondo1.FlatStyle = FlatStyle.Flat;
            buttonRedondo1.ForeColor = Color.White;
            buttonRedondo1.Location = new Point(842, 164);
            buttonRedondo1.Name = "buttonRedondo1";
            buttonRedondo1.Size = new Size(163, 54);
            buttonRedondo1.TabIndex = 36;
            buttonRedondo1.TextColor = Color.White;
            buttonRedondo1.UseVisualStyleBackColor = false;
            buttonRedondo1.Click += buttonRedondo1_Click;
            // 
            // FormAgregar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_agregar;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1041, 643);
            Controls.Add(buttonRedondo1);
            Controls.Add(picBoxImagenNo);
            Controls.Add(labelHola);
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
            ((System.ComponentModel.ISupportInitialize)picBoxImagenNo).EndInit();
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
        private Label labelHola;
        private PictureBox picBoxImagenNo;
        private WinFormsAppKhee.ButtonRedondo buttonRedondo1;
    }
}