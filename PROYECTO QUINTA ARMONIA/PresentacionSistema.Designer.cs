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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PresentacionSistema));
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
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // labelIniciarSesion
            // 
            labelIniciarSesion.AutoSize = true;
            labelIniciarSesion.BackColor = Color.Transparent;
            labelIniciarSesion.Font = new Font("Cooper Black", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelIniciarSesion.Location = new Point(576, 118);
            labelIniciarSesion.Margin = new Padding(2, 0, 2, 0);
            labelIniciarSesion.Name = "labelIniciarSesion";
            labelIniciarSesion.Size = new Size(272, 42);
            labelIniciarSesion.TabIndex = 0;
            labelIniciarSesion.Text = "Iniciar Sesión";
            // 
            // labelusuario
            // 
            labelusuario.AutoSize = true;
            labelusuario.BackColor = Color.Transparent;
            labelusuario.Font = new Font("Bookman Old Style", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelusuario.Location = new Point(566, 271);
            labelusuario.Margin = new Padding(2, 0, 2, 0);
            labelusuario.Name = "labelusuario";
            labelusuario.Size = new Size(120, 27);
            labelusuario.TabIndex = 1;
            labelusuario.Text = "Usuario: ";
            // 
            // labelcontraseña
            // 
            labelcontraseña.AutoSize = true;
            labelcontraseña.BackColor = Color.Transparent;
            labelcontraseña.Font = new Font("Bookman Old Style", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelcontraseña.Location = new Point(566, 318);
            labelcontraseña.Margin = new Padding(2, 0, 2, 0);
            labelcontraseña.Name = "labelcontraseña";
            labelcontraseña.Size = new Size(164, 27);
            labelcontraseña.TabIndex = 2;
            labelcontraseña.Text = "Contraseña: ";
            // 
            // textBoxusuario
            // 
            textBoxusuario.Font = new Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxusuario.Location = new Point(731, 271);
            textBoxusuario.Margin = new Padding(2);
            textBoxusuario.Name = "textBoxusuario";
            textBoxusuario.Size = new Size(174, 27);
            textBoxusuario.TabIndex = 3;
            // 
            // textBox2contraseña
            // 
            textBox2contraseña.Font = new Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2contraseña.Location = new Point(731, 321);
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
            buttonLogin.Location = new Point(648, 421);
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
            buttonSalir.Location = new Point(852, 419);
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
            lblFecha.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(307, 35);
            lblFecha.Margin = new Padding(2, 0, 2, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(50, 17);
            lblFecha.TabIndex = 7;
            lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.BackColor = Color.Transparent;
            lblHora.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHora.Location = new Point(307, 64);
            lblHora.Margin = new Padding(2, 0, 2, 0);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(42, 17);
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
            btnPlay.Image = (Image)resources.GetObject("btnPlay.Image");
            btnPlay.Location = new Point(824, 18);
            btnPlay.Margin = new Padding(2);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(39, 44);
            btnPlay.TabIndex = 11;
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += button1_Click;
            // 
            // btnPause
            // 
            btnPause.BackColor = Color.Transparent;
            btnPause.BackgroundImage = (Image)resources.GetObject("btnPause.BackgroundImage");
            btnPause.FlatAppearance.BorderSize = 0;
            btnPause.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnPause.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnPause.FlatStyle = FlatStyle.Flat;
            btnPause.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPause.Location = new Point(781, 18);
            btnPause.Margin = new Padding(2);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(40, 48);
            btnPause.TabIndex = 12;
            btnPause.UseVisualStyleBackColor = false;
            btnPause.Click += btnPause_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rockwell", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(242, 31);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 13;
            label1.Text = "Fecha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Rockwell", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(242, 62);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 14;
            label2.Text = "Hora:";
            // 
            // PresentacionSistema
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1182, 659);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
    }
}