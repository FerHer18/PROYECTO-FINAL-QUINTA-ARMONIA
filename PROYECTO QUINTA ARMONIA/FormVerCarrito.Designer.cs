﻿namespace PROYECTO_QUINTA_ARMONIA
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
            components = new System.ComponentModel.Container();
            buttonRegresarComprar = new Button();
            btnLogout = new Button();
            btnPagar = new Button();
            richTextBoxMostrar = new RichTextBox();
            labelHola = new Label();
            lblFecha = new Label();
            lblHora = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // buttonRegresarComprar
            // 
            buttonRegresarComprar.BackColor = Color.Transparent;
            buttonRegresarComprar.FlatAppearance.BorderSize = 0;
            buttonRegresarComprar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonRegresarComprar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonRegresarComprar.FlatStyle = FlatStyle.Flat;
            buttonRegresarComprar.Location = new Point(668, 80);
            buttonRegresarComprar.Margin = new Padding(2);
            buttonRegresarComprar.Name = "buttonRegresarComprar";
            buttonRegresarComprar.Size = new Size(209, 40);
            buttonRegresarComprar.TabIndex = 34;
            buttonRegresarComprar.UseVisualStyleBackColor = false;
            buttonRegresarComprar.Click += buttonRegresarComprar_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new Point(985, 759);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(142, 32);
            btnLogout.TabIndex = 35;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.Transparent;
            btnPagar.FlatAppearance.BorderSize = 0;
            btnPagar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnPagar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnPagar.FlatStyle = FlatStyle.Flat;
            btnPagar.Location = new Point(752, 478);
            btnPagar.Margin = new Padding(2);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(304, 80);
            btnPagar.TabIndex = 36;
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // richTextBoxMostrar
            // 
            richTextBoxMostrar.BorderStyle = BorderStyle.None;
            richTextBoxMostrar.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBoxMostrar.Location = new Point(141, 248);
            richTextBoxMostrar.Margin = new Padding(2);
            richTextBoxMostrar.Name = "richTextBoxMostrar";
            richTextBoxMostrar.Size = new Size(410, 320);
            richTextBoxMostrar.TabIndex = 37;
            richTextBoxMostrar.Text = "";
            // 
            // labelHola
            // 
            labelHola.BackColor = Color.Transparent;
            labelHola.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHola.Location = new Point(179, 85);
            labelHola.Margin = new Padding(2, 0, 2, 0);
            labelHola.Name = "labelHola";
            labelHola.Size = new Size(422, 38);
            labelHola.TabIndex = 38;
            labelHola.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Font = new Font("Sylfaen", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFecha.ForeColor = SystemColors.ButtonHighlight;
            lblFecha.Location = new Point(22, 5);
            lblFecha.Margin = new Padding(2, 0, 2, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(68, 26);
            lblFecha.TabIndex = 39;
            lblFecha.Text = "Fecha";
            lblFecha.Click += lblFecha_Click;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.BackColor = Color.Transparent;
            lblHora.Font = new Font("Sylfaen", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHora.ForeColor = SystemColors.ButtonHighlight;
            lblHora.Location = new Point(1044, 5);
            lblHora.Margin = new Padding(2, 0, 2, 0);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(60, 26);
            lblHora.TabIndex = 40;
            lblHora.Text = "Hora";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // FormVerCarrito
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.UIcarritoBackground1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1199, 820);
            Controls.Add(lblHora);
            Controls.Add(lblFecha);
            Controls.Add(labelHola);
            Controls.Add(richTextBoxMostrar);
            Controls.Add(btnPagar);
            Controls.Add(btnLogout);
            Controls.Add(buttonRegresarComprar);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "FormVerCarrito";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormVerCarrito";
            Load += FormVerCarrito_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRegresarComprar;
        private Button btnLogout;
        private Button btnPagar;
        private RichTextBox richTextBoxMostrar;
        private Label labelHola;
        private Label lblFecha;
        private Label lblHora;
        private System.Windows.Forms.Timer timer1;
    }
}