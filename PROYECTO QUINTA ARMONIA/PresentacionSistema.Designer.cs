namespace PROYECTO_QUINTA_ARMONIA
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
            SuspendLayout();
            // 
            // labelIniciarSesion
            // 
            labelIniciarSesion.AutoSize = true;
            labelIniciarSesion.BackColor = Color.Transparent;
            labelIniciarSesion.Font = new Font("Franklin Gothic Medium Cond", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelIniciarSesion.Location = new Point(602, 180);
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
            labelusuario.Location = new Point(558, 264);
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
            labelcontraseña.Location = new Point(558, 334);
            labelcontraseña.Margin = new Padding(2, 0, 2, 0);
            labelcontraseña.Name = "labelcontraseña";
            labelcontraseña.Size = new Size(117, 25);
            labelcontraseña.TabIndex = 2;
            labelcontraseña.Text = "Contraseña: ";
            // 
            // textBoxusuario
            // 
            textBoxusuario.Location = new Point(676, 265);
            textBoxusuario.Margin = new Padding(2);
            textBoxusuario.Name = "textBoxusuario";
            textBoxusuario.Size = new Size(174, 27);
            textBoxusuario.TabIndex = 3;
            // 
            // textBox2contraseña
            // 
            textBox2contraseña.Location = new Point(676, 333);
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
            buttonLogin.Location = new Point(676, 423);
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
            buttonSalir.Location = new Point(650, 494);
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
            lblFecha.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(95, 180);
            lblFecha.Margin = new Padding(2, 0, 2, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(58, 25);
            lblFecha.TabIndex = 7;
            lblFecha.Text = "fecha";
            lblFecha.Click += lblFecha_Click;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.BackColor = Color.Transparent;
            lblHora.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHora.Location = new Point(95, 214);
            lblHora.Margin = new Padding(2, 0, 2, 0);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(51, 25);
            lblHora.TabIndex = 8;
            lblHora.Text = "hora";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // PresentacionSistema
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo_presentacion;
            ClientSize = new Size(1325, 790);
            Controls.Add(lblHora);
            Controls.Add(lblFecha);
            Controls.Add(buttonSalir);
            Controls.Add(buttonLogin);
            Controls.Add(textBox2contraseña);
            Controls.Add(textBoxusuario);
            Controls.Add(labelcontraseña);
            Controls.Add(labelusuario);
            Controls.Add(labelIniciarSesion);
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
    }
}