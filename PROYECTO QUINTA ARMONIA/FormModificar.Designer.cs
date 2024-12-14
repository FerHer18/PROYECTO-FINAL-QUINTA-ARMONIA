namespace PROYECTO_QUINTA_ARMONIA
{
    partial class FormModificar
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
            buttonRegresar = new Button();
            lblFecha = new Label();
            lblHora = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            labelHola = new Label();
            btnConfirmar = new Button();
            btnDatosActuales = new Button();
            btnCargarImagen = new Button();
            SuspendLayout();
            // 
            // buttonRegresar
            // 
            buttonRegresar.BackColor = Color.Transparent;
            buttonRegresar.FlatAppearance.BorderSize = 0;
            buttonRegresar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonRegresar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonRegresar.FlatStyle = FlatStyle.Flat;
            buttonRegresar.Location = new Point(581, 502);
            buttonRegresar.Margin = new Padding(4);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(143, 50);
            buttonRegresar.TabIndex = 0;
            buttonRegresar.UseVisualStyleBackColor = false;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Font = new Font("Sylfaen", 6F, FontStyle.Bold);
            lblFecha.ForeColor = SystemColors.ButtonHighlight;
            lblFecha.Location = new Point(-2, 4);
            lblFecha.Margin = new Padding(2, 0, 2, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(40, 16);
            lblFecha.TabIndex = 35;
            lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.BackColor = Color.Transparent;
            lblHora.Font = new Font("Sylfaen", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHora.ForeColor = SystemColors.ButtonHighlight;
            lblHora.Location = new Point(881, 0);
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
            labelHola.Location = new Point(160, 74);
            labelHola.Name = "labelHola";
            labelHola.Size = new Size(199, 38);
            labelHola.TabIndex = 37;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.Transparent;
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnConfirmar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Location = new Point(282, 502);
            btnConfirmar.Margin = new Padding(4);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(143, 50);
            btnConfirmar.TabIndex = 38;
            btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // btnDatosActuales
            // 
            btnDatosActuales.BackColor = Color.Transparent;
            btnDatosActuales.FlatAppearance.BorderSize = 0;
            btnDatosActuales.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnDatosActuales.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnDatosActuales.FlatStyle = FlatStyle.Flat;
            btnDatosActuales.Location = new Point(675, 150);
            btnDatosActuales.Margin = new Padding(4);
            btnDatosActuales.Name = "btnDatosActuales";
            btnDatosActuales.Size = new Size(143, 50);
            btnDatosActuales.TabIndex = 39;
            btnDatosActuales.UseVisualStyleBackColor = false;
            // 
            // btnCargarImagen
            // 
            btnCargarImagen.BackColor = Color.Transparent;
            btnCargarImagen.FlatAppearance.BorderSize = 0;
            btnCargarImagen.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCargarImagen.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCargarImagen.FlatStyle = FlatStyle.Flat;
            btnCargarImagen.Location = new Point(675, 219);
            btnCargarImagen.Margin = new Padding(4);
            btnCargarImagen.Name = "btnCargarImagen";
            btnCargarImagen.Size = new Size(143, 50);
            btnCargarImagen.TabIndex = 40;
            btnCargarImagen.UseVisualStyleBackColor = false;
            // 
            // FormModificar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondoModificar;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1011, 641);
            Controls.Add(btnCargarImagen);
            Controls.Add(btnDatosActuales);
            Controls.Add(btnConfirmar);
            Controls.Add(labelHola);
            Controls.Add(lblFecha);
            Controls.Add(lblHora);
            Controls.Add(buttonRegresar);
            DoubleBuffered = true;
            Margin = new Padding(4);
            Name = "FormModificar";
            Text = "FormModificar";
            Load += FormModificar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRegresar;
        private Label lblFecha;
        private Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private Label labelHola;
        private Button btnConfirmar;
        private Button btnDatosActuales;
        private Button btnCargarImagen;
    }
}