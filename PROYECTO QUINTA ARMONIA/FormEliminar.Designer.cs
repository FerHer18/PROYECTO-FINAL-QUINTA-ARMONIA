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
            components = new System.ComponentModel.Container();
            buttonRedondoCancelar = new WinFormsAppKhee.ButtonRedondo();
            label1 = new Label();
            textBoxBuscarCodigo = new TextBox();
            buttonRedondoEliminar = new WinFormsAppKhee.ButtonRedondo();
            label2 = new Label();
            buttonDatAct = new Button();
            textBoxElimName = new TextBox();
            textBoxElimDesc = new TextBox();
            textBoxElimPrecio = new TextBox();
            textBoxElimExist = new TextBox();
            lblFecha = new Label();
            lblHora = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            labelHola = new Label();
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
            buttonRedondoCancelar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonRedondoCancelar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonRedondoCancelar.FlatStyle = FlatStyle.Flat;
            buttonRedondoCancelar.ForeColor = Color.White;
            buttonRedondoCancelar.Location = new Point(576, 485);
            buttonRedondoCancelar.Margin = new Padding(4);
            buttonRedondoCancelar.Name = "buttonRedondoCancelar";
            buttonRedondoCancelar.Size = new Size(133, 53);
            buttonRedondoCancelar.TabIndex = 0;
            buttonRedondoCancelar.TextColor = Color.White;
            buttonRedondoCancelar.UseVisualStyleBackColor = false;
            buttonRedondoCancelar.Click += buttonRedondoCancelar_Click;
            // 
            // label1
            // 
            label1.Location = new Point(186, 162);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(202, 56);
            label1.TabIndex = 1;
            label1.Text = "Codigo del producto a eliminar";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxBuscarCodigo
            // 
            textBoxBuscarCodigo.Location = new Point(411, 175);
            textBoxBuscarCodigo.Margin = new Padding(4);
            textBoxBuscarCodigo.Name = "textBoxBuscarCodigo";
            textBoxBuscarCodigo.PlaceholderText = "Codigo de producto";
            textBoxBuscarCodigo.Size = new Size(213, 31);
            textBoxBuscarCodigo.TabIndex = 2;
            textBoxBuscarCodigo.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonRedondoEliminar
            // 
            buttonRedondoEliminar.BackColor = Color.Transparent;
            buttonRedondoEliminar.BackgroundColor = Color.Transparent;
            buttonRedondoEliminar.BorderColor = Color.Transparent;
            buttonRedondoEliminar.BorderRadius = 0;
            buttonRedondoEliminar.BorderSize = 0;
            buttonRedondoEliminar.FlatAppearance.BorderSize = 0;
            buttonRedondoEliminar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonRedondoEliminar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonRedondoEliminar.FlatStyle = FlatStyle.Flat;
            buttonRedondoEliminar.ForeColor = Color.White;
            buttonRedondoEliminar.Location = new Point(263, 485);
            buttonRedondoEliminar.Margin = new Padding(4);
            buttonRedondoEliminar.Name = "buttonRedondoEliminar";
            buttonRedondoEliminar.Size = new Size(137, 53);
            buttonRedondoEliminar.TabIndex = 3;
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
            label2.Location = new Point(364, 85);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(234, 30);
            label2.TabIndex = 18;
            label2.Text = "ELIMINAR PRODUCTO";
            // 
            // buttonDatAct
            // 
            buttonDatAct.BackColor = Color.Transparent;
            buttonDatAct.FlatAppearance.BorderSize = 0;
            buttonDatAct.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonDatAct.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonDatAct.FlatStyle = FlatStyle.Flat;
            buttonDatAct.Location = new Point(693, 162);
            buttonDatAct.Margin = new Padding(4);
            buttonDatAct.Name = "buttonDatAct";
            buttonDatAct.Size = new Size(138, 57);
            buttonDatAct.TabIndex = 20;
            buttonDatAct.UseVisualStyleBackColor = false;
            buttonDatAct.Click += buttonDatAct_Click;
            // 
            // textBoxElimName
            // 
            textBoxElimName.Enabled = false;
            textBoxElimName.Location = new Point(491, 256);
            textBoxElimName.Margin = new Padding(4);
            textBoxElimName.Name = "textBoxElimName";
            textBoxElimName.Size = new Size(218, 31);
            textBoxElimName.TabIndex = 21;
            // 
            // textBoxElimDesc
            // 
            textBoxElimDesc.Enabled = false;
            textBoxElimDesc.Location = new Point(491, 364);
            textBoxElimDesc.Margin = new Padding(4);
            textBoxElimDesc.Name = "textBoxElimDesc";
            textBoxElimDesc.Size = new Size(218, 31);
            textBoxElimDesc.TabIndex = 22;
            // 
            // textBoxElimPrecio
            // 
            textBoxElimPrecio.Enabled = false;
            textBoxElimPrecio.Location = new Point(491, 309);
            textBoxElimPrecio.Margin = new Padding(4);
            textBoxElimPrecio.Name = "textBoxElimPrecio";
            textBoxElimPrecio.Size = new Size(218, 31);
            textBoxElimPrecio.TabIndex = 23;
            // 
            // textBoxElimExist
            // 
            textBoxElimExist.Enabled = false;
            textBoxElimExist.Location = new Point(491, 405);
            textBoxElimExist.Margin = new Padding(4);
            textBoxElimExist.Name = "textBoxElimExist";
            textBoxElimExist.Size = new Size(218, 31);
            textBoxElimExist.TabIndex = 24;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Font = new Font("Sylfaen", 6F, FontStyle.Bold);
            lblFecha.ForeColor = SystemColors.ButtonHighlight;
            lblFecha.Location = new Point(14, 11);
            lblFecha.Margin = new Padding(2, 0, 2, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(40, 16);
            lblFecha.TabIndex = 35;
            lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.BackColor = Color.Transparent;
            lblHora.Font = new Font("Sylfaen", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHora.ForeColor = SystemColors.ButtonHighlight;
            lblHora.Location = new Point(894, 11);
            lblHora.Margin = new Padding(2, 0, 2, 0);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(60, 26);
            lblHora.TabIndex = 34;
            lblHora.Text = "Hora";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // labelHola
            // 
            labelHola.BackColor = Color.Transparent;
            labelHola.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHola.Location = new Point(162, 81);
            labelHola.Name = "labelHola";
            labelHola.Size = new Size(126, 38);
            labelHola.TabIndex = 36;
            // 
            // FormEliminar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondoEliminar;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1011, 641);
            Controls.Add(labelHola);
            Controls.Add(lblFecha);
            Controls.Add(lblHora);
            Controls.Add(textBoxElimExist);
            Controls.Add(textBoxElimPrecio);
            Controls.Add(textBoxElimDesc);
            Controls.Add(textBoxElimName);
            Controls.Add(buttonDatAct);
            Controls.Add(label2);
            Controls.Add(buttonRedondoEliminar);
            Controls.Add(textBoxBuscarCodigo);
            Controls.Add(label1);
            Controls.Add(buttonRedondoCancelar);
            DoubleBuffered = true;
            Margin = new Padding(4);
            Name = "FormEliminar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEliminar";
            Load += FormEliminar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private WinFormsAppKhee.ButtonRedondo buttonRedondoCancelar;
        private Label label1;
        private TextBox textBoxBuscarCodigo;
        private WinFormsAppKhee.ButtonRedondo buttonRedondoEliminar;
        private Label label2;
        private Button buttonDatAct;
        private TextBox textBoxElimName;
        private TextBox textBoxElimDesc;
        private TextBox textBoxElimPrecio;
        private TextBox textBoxElimExist;
        private Label lblFecha;
        private Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private Label labelHola;
    }
}