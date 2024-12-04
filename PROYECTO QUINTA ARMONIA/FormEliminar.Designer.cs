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
            buttonRedondoCancelar.Location = new Point(457, 370);
            buttonRedondoCancelar.Name = "buttonRedondoCancelar";
            buttonRedondoCancelar.Size = new Size(146, 72);
            buttonRedondoCancelar.TabIndex = 0;
            buttonRedondoCancelar.TextColor = Color.White;
            buttonRedondoCancelar.UseVisualStyleBackColor = false;
            buttonRedondoCancelar.Click += buttonRedondoCancelar_Click;
            // 
            // FormEliminar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondoEliminar;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(809, 513);
            Controls.Add(buttonRedondoCancelar);
            DoubleBuffered = true;
            Name = "FormEliminar";
            Text = "FormEliminar";
            ResumeLayout(false);
        }

        #endregion

        private WinFormsAppKhee.ButtonRedondo buttonRedondoCancelar;
    }
}