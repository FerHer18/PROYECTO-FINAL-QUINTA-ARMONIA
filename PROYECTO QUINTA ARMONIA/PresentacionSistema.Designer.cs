﻿namespace PROYECTO_QUINTA_ARMONIA
{
    partial class PresentacionSistema
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
            labelIniciarSesion = new Label();
            labelusuario = new Label();
            labelcontraseña = new Label();
            textBoxusuario = new TextBox();
            textBox2contraseña = new TextBox();
            buttonLogin = new Button();
            buttonSalir = new Button();
            SuspendLayout();
            // 
            // labelIniciarSesion
            // 
            labelIniciarSesion.AutoSize = true;
            labelIniciarSesion.BackColor = Color.Transparent;
            labelIniciarSesion.Font = new Font("Franklin Gothic Medium Cond", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelIniciarSesion.Location = new Point(752, 225);
            labelIniciarSesion.Name = "labelIniciarSesion";
            labelIniciarSesion.Size = new Size(199, 42);
            labelIniciarSesion.TabIndex = 0;
            labelIniciarSesion.Text = "Iniciar Sesión";
            // 
            // labelusuario
            // 
            labelusuario.AutoSize = true;
            labelusuario.BackColor = Color.Transparent;
            labelusuario.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelusuario.Location = new Point(697, 330);
            labelusuario.Name = "labelusuario";
            labelusuario.Size = new Size(97, 30);
            labelusuario.TabIndex = 1;
            labelusuario.Text = "Usuario: ";
            // 
            // labelcontraseña
            // 
            labelcontraseña.AutoSize = true;
            labelcontraseña.BackColor = Color.Transparent;
            labelcontraseña.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelcontraseña.Location = new Point(697, 417);
            labelcontraseña.Name = "labelcontraseña";
            labelcontraseña.Size = new Size(133, 30);
            labelcontraseña.TabIndex = 2;
            labelcontraseña.Text = "Contraseña: ";
            // 
            // textBoxusuario
            // 
            textBoxusuario.Location = new Point(845, 331);
            textBoxusuario.Name = "textBoxusuario";
            textBoxusuario.Size = new Size(216, 31);
            textBoxusuario.TabIndex = 3;
            // 
            // textBox2contraseña
            // 
            textBox2contraseña.Location = new Point(845, 416);
            textBox2contraseña.Name = "textBox2contraseña";
            textBox2contraseña.Size = new Size(216, 31);
            textBox2contraseña.TabIndex = 4;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.Transparent;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonLogin.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLogin.Location = new Point(836, 527);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(177, 56);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = Color.Transparent;
            buttonSalir.FlatAppearance.BorderSize = 0;
            buttonSalir.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonSalir.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonSalir.FlatStyle = FlatStyle.Flat;
            buttonSalir.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSalir.Location = new Point(812, 617);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(229, 56);
            buttonSalir.TabIndex = 6;
            buttonSalir.Text = "Salir del sistema";
            buttonSalir.UseVisualStyleBackColor = false;
            // 
            // PresentacionSistema
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo_presentacion;
            ClientSize = new Size(1336, 813);
            Controls.Add(buttonSalir);
            Controls.Add(buttonLogin);
            Controls.Add(textBox2contraseña);
            Controls.Add(textBoxusuario);
            Controls.Add(labelcontraseña);
            Controls.Add(labelusuario);
            Controls.Add(labelIniciarSesion);
            Margin = new Padding(4);
            Name = "PresentacionSistema";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PresentacionSistema";
            Load += PresentacionSistema_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelIniciarSesion;
        private Label labelusuario;
        private Label labelcontraseña;
        private TextBox textBoxusuario;
        private TextBox textBox2contraseña;
        private Button buttonLogin;
        private Button buttonSalir;
    }
}