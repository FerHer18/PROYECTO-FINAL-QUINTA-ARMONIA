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
            label1 = new Label();
            textBoxBuscarCodigo = new TextBox();
            buttonRedondoEliminar = new WinFormsAppKhee.ButtonRedondo();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            buttonDatAct = new Button();
            textBoxElimCod = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonRedondoCancelar
            // 
            buttonRedondoCancelar.BackColor = Color.Transparent;
            buttonRedondoCancelar.BackgroundColor = Color.Transparent;
            buttonRedondoCancelar.BorderColor = Color.Transparent;
            buttonRedondoCancelar.BorderRadius = 0;
            buttonRedondoCancelar.BorderSize = 0;
            buttonRedondoCancelar.FlatAppearance.BorderSize = 0;
            buttonRedondoCancelar.FlatStyle = FlatStyle.Flat;
            buttonRedondoCancelar.ForeColor = Color.White;
            buttonRedondoCancelar.Location = new Point(440, 366);
            buttonRedondoCancelar.Name = "buttonRedondoCancelar";
            buttonRedondoCancelar.Size = new Size(146, 72);
            buttonRedondoCancelar.TabIndex = 0;
            buttonRedondoCancelar.Text = "CANCELAR";
            buttonRedondoCancelar.TextColor = Color.White;
            buttonRedondoCancelar.UseVisualStyleBackColor = false;
            buttonRedondoCancelar.Click += buttonRedondoCancelar_Click;
            // 
            // label1
            // 
            label1.Location = new Point(30, 105);
            label1.Name = "label1";
            label1.Size = new Size(162, 45);
            label1.TabIndex = 1;
            label1.Text = "Codigo del producto a eliminar";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxBuscarCodigo
            // 
            textBoxBuscarCodigo.Location = new Point(264, 114);
            textBoxBuscarCodigo.Name = "textBoxBuscarCodigo";
            textBoxBuscarCodigo.PlaceholderText = "Codigo de producto";
            textBoxBuscarCodigo.Size = new Size(162, 27);
            textBoxBuscarCodigo.TabIndex = 2;
            textBoxBuscarCodigo.TextAlign = HorizontalAlignment.Center;
            textBoxBuscarCodigo.TextChanged += textBoxBuscarCodigo_TextChanged;
            // 
            // buttonRedondoEliminar
            // 
            buttonRedondoEliminar.BackColor = Color.Transparent;
            buttonRedondoEliminar.BackgroundColor = Color.Transparent;
            buttonRedondoEliminar.BorderColor = Color.Transparent;
            buttonRedondoEliminar.BorderRadius = 0;
            buttonRedondoEliminar.BorderSize = 0;
            buttonRedondoEliminar.FlatAppearance.BorderSize = 0;
            buttonRedondoEliminar.FlatStyle = FlatStyle.Flat;
            buttonRedondoEliminar.ForeColor = Color.White;
            buttonRedondoEliminar.Location = new Point(217, 374);
            buttonRedondoEliminar.Name = "buttonRedondoEliminar";
            buttonRedondoEliminar.Size = new Size(115, 56);
            buttonRedondoEliminar.TabIndex = 3;
            buttonRedondoEliminar.Text = "CONFIRMAR PRODUCTO";
            buttonRedondoEliminar.TextColor = Color.White;
            buttonRedondoEliminar.UseVisualStyleBackColor = false;
            buttonRedondoEliminar.Click += buttonRedondoEliminar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(280, 52);
            label2.Name = "label2";
            label2.Size = new Size(187, 23);
            label2.TabIndex = 18;
            label2.Text = "ELIMINAR PRODUCTO";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(434, 184);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 142);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // buttonDatAct
            // 
            buttonDatAct.Location = new Point(457, 106);
            buttonDatAct.Name = "buttonDatAct";
            buttonDatAct.Size = new Size(129, 44);
            buttonDatAct.TabIndex = 20;
            buttonDatAct.Text = "Ver datos";
            buttonDatAct.UseVisualStyleBackColor = true;
            buttonDatAct.Click += buttonDatAct_Click;
            // 
            // textBoxElimCod
            // 
            textBoxElimCod.Location = new Point(217, 261);
            textBoxElimCod.Name = "textBoxElimCod";
            textBoxElimCod.Size = new Size(175, 27);
            textBoxElimCod.TabIndex = 21;
            // 
            // FormEliminar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondoEliminar;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(809, 513);
            Controls.Add(textBoxElimCod);
            Controls.Add(buttonDatAct);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(buttonRedondoEliminar);
            Controls.Add(textBoxBuscarCodigo);
            Controls.Add(label1);
            Controls.Add(buttonRedondoCancelar);
            DoubleBuffered = true;
            Name = "FormEliminar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEliminar";
            Load += FormEliminar_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private WinFormsAppKhee.ButtonRedondo buttonRedondoCancelar;
        private Label label1;
        private TextBox textBoxBuscarCodigo;
        private WinFormsAppKhee.ButtonRedondo buttonRedondoEliminar;
        private Label label2;
        private PictureBox pictureBox1;
        private Button buttonDatAct;
        private TextBox textBoxElimCod;
    }
}