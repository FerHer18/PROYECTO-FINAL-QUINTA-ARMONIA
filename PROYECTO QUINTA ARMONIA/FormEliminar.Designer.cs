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
            buttonDatAct = new Button();
            textBoxElimName = new TextBox();
            textBoxElimDesc = new TextBox();
            textBoxElimPrecio = new TextBox();
            textBoxElimExist = new TextBox();
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
            buttonRedondoCancelar.TextColor = Color.White;
            buttonRedondoCancelar.UseVisualStyleBackColor = false;
            buttonRedondoCancelar.Click += buttonRedondoCancelar_Click;
            // 
            // label1
            // 
            label1.Location = new Point(149, 130);
            label1.Name = "label1";
            label1.Size = new Size(162, 45);
            label1.TabIndex = 1;
            label1.Text = "Codigo del producto a eliminar";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxBuscarCodigo
            // 
            textBoxBuscarCodigo.Location = new Point(332, 140);
            textBoxBuscarCodigo.Name = "textBoxBuscarCodigo";
            textBoxBuscarCodigo.PlaceholderText = "Codigo de producto";
            textBoxBuscarCodigo.Size = new Size(162, 27);
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
            buttonRedondoEliminar.FlatStyle = FlatStyle.Flat;
            buttonRedondoEliminar.ForeColor = Color.White;
            buttonRedondoEliminar.Location = new Point(217, 374);
            buttonRedondoEliminar.Name = "buttonRedondoEliminar";
            buttonRedondoEliminar.Size = new Size(115, 56);
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
            label2.Location = new Point(280, 52);
            label2.Name = "label2";
            label2.Size = new Size(187, 23);
            label2.TabIndex = 18;
            label2.Text = "ELIMINAR PRODUCTO";
            // 
            // buttonDatAct
            // 
            buttonDatAct.BackColor = Color.Transparent;
            buttonDatAct.FlatStyle = FlatStyle.Flat;
            buttonDatAct.Location = new Point(546, 131);
            buttonDatAct.Name = "buttonDatAct";
            buttonDatAct.Size = new Size(129, 44);
            buttonDatAct.TabIndex = 20;
            buttonDatAct.UseVisualStyleBackColor = false;
            buttonDatAct.Click += buttonDatAct_Click;
            // 
            // textBoxElimName
            // 
            textBoxElimName.Enabled = false;
            textBoxElimName.Location = new Point(393, 210);
            textBoxElimName.Name = "textBoxElimName";
            textBoxElimName.Size = new Size(175, 27);
            textBoxElimName.TabIndex = 21;
            // 
            // textBoxElimDesc
            // 
            textBoxElimDesc.Enabled = false;
            textBoxElimDesc.Location = new Point(393, 243);
            textBoxElimDesc.Name = "textBoxElimDesc";
            textBoxElimDesc.Size = new Size(175, 27);
            textBoxElimDesc.TabIndex = 22;
            // 
            // textBoxElimPrecio
            // 
            textBoxElimPrecio.Enabled = false;
            textBoxElimPrecio.Location = new Point(393, 287);
            textBoxElimPrecio.Name = "textBoxElimPrecio";
            textBoxElimPrecio.Size = new Size(175, 27);
            textBoxElimPrecio.TabIndex = 23;
            // 
            // textBoxElimExist
            // 
            textBoxElimExist.Enabled = false;
            textBoxElimExist.Location = new Point(393, 333);
            textBoxElimExist.Name = "textBoxElimExist";
            textBoxElimExist.Size = new Size(175, 27);
            textBoxElimExist.TabIndex = 24;
            // 
            // FormEliminar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondoEliminar;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(809, 513);
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
    }
}