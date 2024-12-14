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
            buttonRedondoCancelar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonRedondoCancelar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonRedondoCancelar.FlatStyle = FlatStyle.Flat;
            buttonRedondoCancelar.ForeColor = Color.White;
            buttonRedondoCancelar.Location = new Point(615, 484);
            buttonRedondoCancelar.Margin = new Padding(4);
            buttonRedondoCancelar.Name = "buttonRedondoCancelar";
            buttonRedondoCancelar.Size = new Size(144, 46);
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
            buttonRedondoConfirmar.Location = new Point(274, 474);
            buttonRedondoConfirmar.Margin = new Padding(4);
            buttonRedondoConfirmar.Name = "buttonRedondoConfirmar";
            buttonRedondoConfirmar.Size = new Size(140, 56);
            buttonRedondoConfirmar.TabIndex = 1;
            buttonRedondoConfirmar.TextColor = Color.White;
            buttonRedondoConfirmar.UseVisualStyleBackColor = false;
            buttonRedondoConfirmar.Click += buttonRedondoConfirmar_Click;
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.BackColor = Color.Transparent;
            labelCodigo.Location = new Point(136, 170);
            labelCodigo.Margin = new Padding(4, 0, 4, 0);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(188, 25);
            labelCodigo.TabIndex = 2;
            labelCodigo.Text = "Codigo del producto: ";
            // 
            // labelDescrip
            // 
            labelDescrip.AutoSize = true;
            labelDescrip.BackColor = Color.Transparent;
            labelDescrip.Location = new Point(129, 285);
            labelDescrip.Margin = new Padding(4, 0, 4, 0);
            labelDescrip.Name = "labelDescrip";
            labelDescrip.Size = new Size(216, 25);
            labelDescrip.TabIndex = 3;
            labelDescrip.Text = "Descripción del producto:";
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.BackColor = Color.Transparent;
            labelPrecio.Location = new Point(131, 339);
            labelPrecio.Margin = new Padding(4, 0, 4, 0);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(172, 25);
            labelPrecio.TabIndex = 4;
            labelPrecio.Text = "Precio del producto:";
            // 
            // labelCantidad
            // 
            labelCantidad.AutoSize = true;
            labelCantidad.BackColor = Color.Transparent;
            labelCantidad.Location = new Point(129, 398);
            labelCantidad.Margin = new Padding(4, 0, 4, 0);
            labelCantidad.Name = "labelCantidad";
            labelCantidad.Size = new Size(195, 25);
            labelCantidad.TabIndex = 5;
            labelCantidad.Text = "Cantidad del producto:";
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Location = new Point(366, 166);
            textBoxCodigo.Margin = new Padding(4);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.PlaceholderText = "Codigo";
            textBoxCodigo.Size = new Size(208, 31);
            textBoxCodigo.TabIndex = 6;
            textBoxCodigo.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxDescrip
            // 
            textBoxDescrip.Location = new Point(366, 276);
            textBoxDescrip.Margin = new Padding(4);
            textBoxDescrip.Name = "textBoxDescrip";
            textBoxDescrip.PlaceholderText = "Descripcion";
            textBoxDescrip.Size = new Size(208, 31);
            textBoxDescrip.TabIndex = 7;
            textBoxDescrip.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Location = new Point(366, 335);
            textBoxPrecio.Margin = new Padding(4);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.PlaceholderText = "Precio";
            textBoxPrecio.Size = new Size(208, 31);
            textBoxPrecio.TabIndex = 8;
            textBoxPrecio.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxExistencias
            // 
            textBoxExistencias.Location = new Point(366, 389);
            textBoxExistencias.Margin = new Padding(4);
            textBoxExistencias.Name = "textBoxExistencias";
            textBoxExistencias.PlaceholderText = "Cantidad";
            textBoxExistencias.Size = new Size(208, 31);
            textBoxExistencias.TabIndex = 9;
            textBoxExistencias.TextAlign = HorizontalAlignment.Center;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.BackColor = Color.Transparent;
            labelNombre.Location = new Point(129, 229);
            labelNombre.Margin = new Padding(4, 0, 4, 0);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(190, 25);
            labelNombre.TabIndex = 10;
            labelNombre.Text = "Nombre del producto:";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(366, 220);
            textBoxNombre.Margin = new Padding(4);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.PlaceholderText = "Nombre";
            textBoxNombre.Size = new Size(208, 31);
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
            btnCargarImagen.Location = new Point(654, 160);
            btnCargarImagen.Margin = new Padding(4);
            btnCargarImagen.Name = "btnCargarImagen";
            btnCargarImagen.Size = new Size(135, 45);
            btnCargarImagen.TabIndex = 15;
            btnCargarImagen.TextColor = Color.White;
            btnCargarImagen.UseVisualStyleBackColor = false;
            btnCargarImagen.Click += btnCargarImagen_Click;
            // 
            // picBoxImagen
            // 
            picBoxImagen.BackColor = Color.Transparent;
            picBoxImagen.Location = new Point(615, 230);
            picBoxImagen.Margin = new Padding(4);
            picBoxImagen.Name = "picBoxImagen";
            picBoxImagen.Size = new Size(212, 192);
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
            label1.Location = new Point(366, 71);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(231, 30);
            label1.TabIndex = 17;
            label1.Text = "AGREGAR PRODUCTO";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.BackColor = Color.Transparent;
            lblHora.Font = new Font("Sylfaen", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHora.ForeColor = SystemColors.ButtonHighlight;
            lblHora.Location = new Point(889, -2);
            lblHora.Margin = new Padding(2, 0, 2, 0);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(60, 26);
            lblHora.TabIndex = 32;
            lblHora.Text = "Hora";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Font = new Font("Sylfaen", 6F, FontStyle.Bold);
            lblFecha.ForeColor = SystemColors.ButtonHighlight;
            lblFecha.Location = new Point(0, 8);
            lblFecha.Margin = new Padding(2, 0, 2, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(40, 16);
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
            labelHola.Location = new Point(158, 75);
            labelHola.Name = "labelHola";
            labelHola.Size = new Size(126, 38);
            labelHola.TabIndex = 34;
            // 
            // FormAgregar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondoAgregar;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1011, 641);
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
            Margin = new Padding(4);
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
        private Label labelHola;
    }
}