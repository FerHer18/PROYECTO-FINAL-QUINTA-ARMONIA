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
            buttonComprar = new Button();
            SuspendLayout();
            // 
            // buttonComprar
            // 
            buttonComprar.BackColor = Color.Transparent;
            buttonComprar.FlatAppearance.BorderSize = 0;
            buttonComprar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonComprar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonComprar.FlatStyle = FlatStyle.Flat;
            buttonComprar.Location = new Point(795, 107);
            buttonComprar.Name = "buttonComprar";
            buttonComprar.Size = new Size(271, 51);
            buttonComprar.TabIndex = 34;
            buttonComprar.UseVisualStyleBackColor = false;
            // 
            // FormVerCarrito
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.UIcarritoBackground;
            ClientSize = new Size(1484, 1080);
            Controls.Add(buttonComprar);
            Name = "FormVerCarrito";
            Text = "Form2";
            Load += FormVerCarrito_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonComprar;
    }
}