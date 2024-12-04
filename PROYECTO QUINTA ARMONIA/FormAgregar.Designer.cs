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
            labelDirImg = new Label();
            textBoxImagen = new TextBox();
            labelAgregar = new Label();
            SuspendLayout();
            // 
            // buttonRedondoCancelar
            // 
            buttonRedondoCancelar.BackColor = Color.Transparent;
            buttonRedondoCancelar.BackgroundColor = Color.Transparent;
            buttonRedondoCancelar.BorderColor = Color.Transparent;
            buttonRedondoCancelar.BorderRadius = 30;
            buttonRedondoCancelar.BorderSize = 0;
            buttonRedondoCancelar.FlatAppearance.BorderSize = 0;
            buttonRedondoCancelar.FlatStyle = FlatStyle.Flat;
            buttonRedondoCancelar.ForeColor = Color.Black;
            buttonRedondoCancelar.Location = new Point(457, 379);
            buttonRedondoCancelar.Name = "buttonRedondoCancelar";
            buttonRedondoCancelar.Size = new Size(129, 45);
            buttonRedondoCancelar.TabIndex = 0;
            buttonRedondoCancelar.Text = "CANCELAR";
            buttonRedondoCancelar.TextColor = Color.Black;
            buttonRedondoCancelar.UseVisualStyleBackColor = false;
            buttonRedondoCancelar.Click += buttonRedondoCancelar_Click;
            // 
            // buttonRedondoConfirmar
            // 
            buttonRedondoConfirmar.BackColor = Color.Transparent;
            buttonRedondoConfirmar.BackgroundColor = Color.Transparent;
            buttonRedondoConfirmar.BorderColor = Color.Transparent;
            buttonRedondoConfirmar.BorderRadius = 30;
            buttonRedondoConfirmar.BorderSize = 0;
            buttonRedondoConfirmar.FlatAppearance.BorderSize = 0;
            buttonRedondoConfirmar.FlatStyle = FlatStyle.Flat;
            buttonRedondoConfirmar.ForeColor = Color.Black;
            buttonRedondoConfirmar.Location = new Point(223, 375);
            buttonRedondoConfirmar.Name = "buttonRedondoConfirmar";
            buttonRedondoConfirmar.Size = new Size(118, 53);
            buttonRedondoConfirmar.TabIndex = 1;
            buttonRedondoConfirmar.Text = "CONFIRMAR MOVIMIENTO";
            buttonRedondoConfirmar.TextColor = Color.Black;
            buttonRedondoConfirmar.UseVisualStyleBackColor = false;
            buttonRedondoConfirmar.Click += buttonRedondoConfirmar_Click;
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Location = new Point(98, 116);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(148, 20);
            labelCodigo.TabIndex = 2;
            labelCodigo.Text = "Codigo del producto";
            // 
            // labelDescrip
            // 
            labelDescrip.AutoSize = true;
            labelDescrip.Location = new Point(103, 199);
            labelDescrip.Name = "labelDescrip";
            labelDescrip.Size = new Size(177, 20);
            labelDescrip.TabIndex = 3;
            labelDescrip.Text = "Descripción del producto";
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Location = new Point(103, 253);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(140, 20);
            labelPrecio.TabIndex = 4;
            labelPrecio.Text = "Precio del producto";
            // 
            // labelCantidad
            // 
            labelCantidad.AutoSize = true;
            labelCantidad.Location = new Point(103, 302);
            labelCantidad.Name = "labelCantidad";
            labelCantidad.Size = new Size(159, 20);
            labelCantidad.TabIndex = 5;
            labelCantidad.Text = "Cantidad del producto";
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Location = new Point(282, 116);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.PlaceholderText = "Codigo";
            textBoxCodigo.Size = new Size(167, 27);
            textBoxCodigo.TabIndex = 6;
            textBoxCodigo.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxDescrip
            // 
            textBoxDescrip.Location = new Point(293, 199);
            textBoxDescrip.Name = "textBoxDescrip";
            textBoxDescrip.PlaceholderText = "Descripcion";
            textBoxDescrip.Size = new Size(167, 27);
            textBoxDescrip.TabIndex = 7;
            textBoxDescrip.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Location = new Point(293, 250);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.PlaceholderText = "Precio";
            textBoxPrecio.Size = new Size(167, 27);
            textBoxPrecio.TabIndex = 8;
            textBoxPrecio.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxExistencias
            // 
            textBoxExistencias.Location = new Point(293, 295);
            textBoxExistencias.Name = "textBoxExistencias";
            textBoxExistencias.PlaceholderText = "Cantidad";
            textBoxExistencias.Size = new Size(167, 27);
            textBoxExistencias.TabIndex = 9;
            textBoxExistencias.TextAlign = HorizontalAlignment.Center;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(105, 159);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(154, 20);
            labelNombre.TabIndex = 10;
            labelNombre.Text = "Nombre del producto";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(293, 166);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.PlaceholderText = "Nombre";
            textBoxNombre.Size = new Size(167, 27);
            textBoxNombre.TabIndex = 11;
            textBoxNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // labelDirImg
            // 
            labelDirImg.AutoSize = true;
            labelDirImg.Location = new Point(115, 342);
            labelDirImg.Name = "labelDirImg";
            labelDirImg.Size = new Size(147, 20);
            labelDirImg.TabIndex = 12;
            labelDirImg.Text = "Direccion de imagen";
            // 
            // textBoxImagen
            // 
            textBoxImagen.Location = new Point(293, 342);
            textBoxImagen.Name = "textBoxImagen";
            textBoxImagen.PlaceholderText = "Direccion de imagen";
            textBoxImagen.Size = new Size(162, 27);
            textBoxImagen.TabIndex = 13;
            textBoxImagen.TextAlign = HorizontalAlignment.Center;
            // 
            // labelAgregar
            // 
            labelAgregar.AutoSize = true;
            labelAgregar.Location = new Point(297, 49);
            labelAgregar.Name = "labelAgregar";
            labelAgregar.Size = new Size(128, 20);
            labelAgregar.TabIndex = 14;
            labelAgregar.Text = "Agregar producto";
            // 
            // FormAgregar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondoAgregar;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(809, 513);
            Controls.Add(labelAgregar);
            Controls.Add(textBoxImagen);
            Controls.Add(labelDirImg);
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
            Text = "FormAgregar";
            Load += FormAgregar_Load;
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
        private Label labelDirImg;
        private TextBox textBoxImagen;
        private Label labelAgregar;
    }
}