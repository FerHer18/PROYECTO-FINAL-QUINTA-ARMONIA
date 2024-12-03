namespace PROYECTO_QUINTA_ARMONIA
{
    partial class InterfaceUsuario
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
            patch = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)patch).BeginInit();
            SuspendLayout();
            // 
            // patch
            // 
            patch.BackColor = Color.Transparent;
            patch.BackgroundImage = Properties.Resources.backgroundPatch224x164;
            patch.BackgroundImageLayout = ImageLayout.None;
            patch.Location = new Point(352, 295);
            patch.Name = "patch";
            patch.Size = new Size(185, 162);
            patch.TabIndex = 0;
            patch.TabStop = false;
            // 
            // InterfaceUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(944, 541);
            Controls.Add(patch);
            Margin = new Padding(3, 2, 3, 2);
            Name = "InterfaceUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InterfaceUsuario";
            Load += InterfaceUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)patch).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox patch;
    }
}