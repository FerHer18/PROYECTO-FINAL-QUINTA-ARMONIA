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
            components = new System.ComponentModel.Container();
            patch = new PictureBox();
            lblHora = new Label();
            lblFecha = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)patch).BeginInit();
            SuspendLayout();
            // 
            // patch
            // 
            patch.BackColor = Color.Transparent;
            patch.BackgroundImage = Properties.Resources.backgroundPatch224x164;
            patch.BackgroundImageLayout = ImageLayout.None;
            patch.Location = new Point(402, 393);
            patch.Margin = new Padding(3, 4, 3, 4);
            patch.Name = "patch";
            patch.Size = new Size(211, 216);
            patch.TabIndex = 0;
            patch.TabStop = false;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.BackColor = Color.Transparent;
            lblHora.Font = new Font("Segoe UI", 10F);
            lblHora.Location = new Point(720, 102);
            lblHora.Margin = new Padding(2, 0, 2, 0);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(47, 23);
            lblHora.TabIndex = 28;
            lblHora.Text = "Hora";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Font = new Font("Segoe UI", 10F);
            lblFecha.Location = new Point(439, 102);
            lblFecha.Margin = new Padding(2, 0, 2, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(54, 23);
            lblFecha.TabIndex = 27;
            lblFecha.Text = "Fecha";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // InterfaceUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1079, 721);
            Controls.Add(lblHora);
            Controls.Add(lblFecha);
            Controls.Add(patch);
            Name = "InterfaceUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InterfaceUsuario";
            Load += InterfaceUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)patch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox patch;
        private Label lblHora;
        private Label lblFecha;
        private System.Windows.Forms.Timer timer1;
    }
}