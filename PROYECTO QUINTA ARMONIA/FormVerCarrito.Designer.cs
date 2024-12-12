namespace PROYECTO_QUINTA_ARMONIA
{
    partial class FormVerCarrito
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
            buttonRegresarComprar = new Button();
            SuspendLayout();
            // 
            // buttonRegresarComprar
            // 
            buttonRegresarComprar.BackColor = Color.Transparent;
            buttonRegresarComprar.FlatAppearance.BorderSize = 0;
            buttonRegresarComprar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonRegresarComprar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonRegresarComprar.FlatStyle = FlatStyle.Flat;
            buttonRegresarComprar.Location = new Point(534, 64);
            buttonRegresarComprar.Margin = new Padding(2);
            buttonRegresarComprar.Name = "buttonRegresarComprar";
            buttonRegresarComprar.Size = new Size(167, 32);
            buttonRegresarComprar.TabIndex = 34;
            buttonRegresarComprar.UseVisualStyleBackColor = false;
            buttonRegresarComprar.Click += buttonRegresarComprar_Click;
            // 
            // FormVerCarrito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.UIcarritoBackground1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(959, 656);
            Controls.Add(buttonRegresarComprar);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "FormVerCarrito";
            Text = "FormVerCarrito";
            Load += FormVerCarrito_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonRegresarComprar;
    }
}