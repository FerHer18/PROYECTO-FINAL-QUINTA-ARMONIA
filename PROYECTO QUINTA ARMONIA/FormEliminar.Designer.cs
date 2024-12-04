namespace PROYECTO_QUINTA_ARMONIA
{
    partial class FormEliminar
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
            label1 = new Label();
            textBoxBuscarCodigo = new TextBox();
            buttonRedondoEliminar = new WinFormsAppKhee.ButtonRedondo();
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
            buttonRedondoCancelar.ForeColor = Color.White;
            buttonRedondoCancelar.Location = new Point(440, 366);
            buttonRedondoCancelar.Name = "buttonRedondoCancelar";
            buttonRedondoCancelar.Size = new Size(146, 72);
            buttonRedondoCancelar.TabIndex = 0;
            buttonRedondoCancelar.Text = "CANCELAR";
            buttonRedondoCancelar.TextColor = Color.White;
            buttonRedondoCancelar.UseVisualStyleBackColor = false;
            buttonRedondoCancelar.Click += buttonRedondoCancelar_Click;
            // 
            // label1
            // 
            label1.Location = new Point(243, 175);
            label1.Name = "label1";
            label1.Size = new Size(162, 45);
            label1.TabIndex = 1;
            label1.Text = "Codigo del producto a eliminar";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxBuscarCodigo
            // 
            textBoxBuscarCodigo.Location = new Point(217, 260);
            textBoxBuscarCodigo.Name = "textBoxBuscarCodigo";
            textBoxBuscarCodigo.PlaceholderText = "Codigo de producto";
            textBoxBuscarCodigo.Size = new Size(162, 27);
            textBoxBuscarCodigo.TabIndex = 2;
            textBoxBuscarCodigo.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonRedondoEliminar
            // 
            buttonRedondoEliminar.BackColor = Color.Transparent;
            buttonRedondoEliminar.BackgroundColor = Color.Transparent;
            buttonRedondoEliminar.BorderColor = Color.Transparent;
            buttonRedondoEliminar.BorderRadius = 30;
            buttonRedondoEliminar.BorderSize = 0;
            buttonRedondoEliminar.FlatAppearance.BorderSize = 0;
            buttonRedondoEliminar.FlatStyle = FlatStyle.Flat;
            buttonRedondoEliminar.ForeColor = Color.White;
            buttonRedondoEliminar.Location = new Point(217, 374);
            buttonRedondoEliminar.Name = "buttonRedondoEliminar";
            buttonRedondoEliminar.Size = new Size(115, 56);
            buttonRedondoEliminar.TabIndex = 3;
            buttonRedondoEliminar.Text = "CONFIRMAR PRODUCTO";
            buttonRedondoEliminar.TextColor = Color.White;
            buttonRedondoEliminar.UseVisualStyleBackColor = false;
            buttonRedondoEliminar.Click += buttonRedondoEliminar_Click;
            // 
            // FormEliminar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondoEliminar;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(809, 513);
            Controls.Add(buttonRedondoEliminar);
            Controls.Add(textBoxBuscarCodigo);
            Controls.Add(label1);
            Controls.Add(buttonRedondoCancelar);
            DoubleBuffered = true;
            Name = "FormEliminar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEliminar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private WinFormsAppKhee.ButtonRedondo buttonRedondoCancelar;
        private Label label1;
        private TextBox textBoxBuscarCodigo;
        private WinFormsAppKhee.ButtonRedondo buttonRedondoEliminar;
    }
}