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
            components = new System.ComponentModel.Container();
            labelIniciarSesion = new Label();
            labelusuario = new Label();
            labelcontraseña = new Label();
            textBoxusuario = new TextBox();
            textBox2contraseña = new TextBox();
            buttonLogin = new Button();
            buttonSalir = new Button();
            lblFecha = new Label();
            lblHora = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnPlay = new Button();
            btnPause = new Button();
            SuspendLayout();
            // 
            // labelIniciarSesion
            // 
            labelIniciarSesion.AutoSize = true;
            labelIniciarSesion.BackColor = Color.Transparent;
            labelIniciarSesion.Font = new Font("Franklin Gothic Medium Cond", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelIniciarSesion.Location = new Point(734, 261);
            labelIniciarSesion.Margin = new Padding(2, 0, 2, 0);
            labelIniciarSesion.Name = "labelIniciarSesion";
            labelIniciarSesion.Size = new Size(167, 38);
            labelIniciarSesion.TabIndex = 0;
            labelIniciarSesion.Text = "Iniciar Sesión";
            // 
            // labelusuario
            // 
            labelusuario.AutoSize = true;
            labelusuario.BackColor = Color.Transparent;
            labelusuario.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelusuario.Location = new Point(690, 345);
            labelusuario.Margin = new Padding(2, 0, 2, 0);
            labelusuario.Name = "labelusuario";
            labelusuario.Size = new Size(86, 25);
            labelusuario.TabIndex = 1;
            labelusuario.Text = "Usuario: ";
            // 
            // labelcontraseña
            // 
            labelcontraseña.AutoSize = true;
            labelcontraseña.BackColor = Color.Transparent;
            labelcontraseña.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelcontraseña.Location = new Point(690, 415);
            labelcontraseña.Margin = new Padding(2, 0, 2, 0);
            labelcontraseña.Name = "labelcontraseña";
            labelcontraseña.Size = new Size(117, 25);
            labelcontraseña.TabIndex = 2;
            labelcontraseña.Text = "Contraseña: ";
            // 
            // textBoxusuario
            // 
            textBoxusuario.Location = new Point(808, 346);
            textBoxusuario.Margin = new Padding(2);
            textBoxusuario.Name = "textBoxusuario";
            textBoxusuario.Size = new Size(174, 27);
            textBoxusuario.TabIndex = 3;
            // 
            // textBox2contraseña
            // 
            textBox2contraseña.Location = new Point(808, 414);
            textBox2contraseña.Margin = new Padding(2);
            textBox2contraseña.Name = "textBox2contraseña";
            textBox2contraseña.PasswordChar = '*';
            textBox2contraseña.Size = new Size(174, 27);
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
            buttonLogin.Location = new Point(860, 538);
            buttonLogin.Margin = new Padding(2);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(134, 43);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click_1;
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = Color.Transparent;
            buttonSalir.FlatAppearance.BorderSize = 0;
            buttonSalir.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonSalir.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonSalir.FlatStyle = FlatStyle.Flat;
            buttonSalir.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSalir.Location = new Point(835, 623);
            buttonSalir.Margin = new Padding(2);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(183, 45);
            buttonSalir.TabIndex = 6;
            buttonSalir.Text = "Salir del sistema";
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Font = new Font("Segoe UI", 10F);
            lblFecha.Location = new Point(86, 172);
            lblFecha.Margin = new Padding(2, 0, 2, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(54, 23);
            lblFecha.TabIndex = 7;
            lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.BackColor = Color.Transparent;
            lblHora.Font = new Font("Segoe UI", 10F);
            lblHora.Location = new Point(86, 206);
            lblHora.Margin = new Padding(2, 0, 2, 0);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(47, 23);
            lblHora.TabIndex = 8;
            lblHora.Text = "Hora";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.Transparent;
            btnPlay.FlatAppearance.BorderSize = 0;
            btnPlay.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnPlay.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlay.Image = Properties.Resources.play;
            btnPlay.Location = new Point(429, 80);
            btnPlay.Margin = new Padding(2);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(75, 69);
            btnPlay.TabIndex = 11;
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += button1_Click;
            // 
            // btnPause
            // 
            btnPause.BackColor = Color.Transparent;
            btnPause.BackgroundImage = Properties.Resources.pause;
            btnPause.FlatAppearance.BorderSize = 0;
            btnPause.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnPause.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnPause.FlatStyle = FlatStyle.Flat;
            btnPause.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPause.Location = new Point(526, 66);
            btnPause.Margin = new Padding(2);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(98, 83);
            btnPause.TabIndex = 12;
            btnPause.UseVisualStyleBackColor = false;
            btnPause.Click += btnPause_Click;
            // 
            // PresentacionSistema
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo_presentacion;
            ClientSize = new Size(1334, 821);
            Controls.Add(lblHora);
            Controls.Add(lblFecha);
            Controls.Add(buttonSalir);
            Controls.Add(buttonLogin);
            Controls.Add(textBox2contraseña);
            Controls.Add(textBoxusuario);
            Controls.Add(labelcontraseña);
            Controls.Add(labelusuario);
            Controls.Add(labelIniciarSesion);
            Controls.Add(btnPlay);
            Controls.Add(btnPause);
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
        private Label lblFecha;
        private Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private Button btnPlay;
        private Button btnPause;
    }
}