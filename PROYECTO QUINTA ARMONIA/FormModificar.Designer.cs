namespace PROYECTO_QUINTA_ARMONIA
{
    partial class FormModificar
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
            buttonRegresar = new Button();
            lblFecha = new Label();
            lblHora = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            labelHola = new Label();
            btnConfirmar = new Button();
            textBoxCodigo = new TextBox();
            textBoxModifDescr = new TextBox();
            textBoxModifPrecio = new TextBox();
            textBoxModifName = new TextBox();
            textBoxModifCant = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // buttonRegresar
            // 
            buttonRegresar.BackColor = Color.Transparent;
            buttonRegresar.FlatAppearance.BorderSize = 0;
            buttonRegresar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonRegresar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonRegresar.FlatStyle = FlatStyle.Flat;
            buttonRegresar.Location = new Point(476, 402);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(103, 40);
            buttonRegresar.TabIndex = 0;
            buttonRegresar.UseVisualStyleBackColor = false;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Font = new Font("Sylfaen", 6F, FontStyle.Bold);
            lblFecha.ForeColor = SystemColors.ButtonHighlight;
            lblFecha.Location = new Point(-2, 3);
            lblFecha.Margin = new Padding(2, 0, 2, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(37, 14);
            lblFecha.TabIndex = 35;
            lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.BackColor = Color.Transparent;
            lblHora.Font = new Font("Sylfaen", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHora.ForeColor = SystemColors.ButtonHighlight;
            lblHora.Location = new Point(705, 0);
            lblHora.Margin = new Padding(2, 0, 2, 0);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(50, 22);
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
            labelHola.Location = new Point(128, 59);
            labelHola.Margin = new Padding(2, 0, 2, 0);
            labelHola.Name = "labelHola";
            labelHola.Size = new Size(159, 30);
            labelHola.TabIndex = 37;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.Transparent;
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnConfirmar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Location = new Point(226, 402);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(114, 40);
            btnConfirmar.TabIndex = 38;
            btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Enabled = false;
            textBoxCodigo.Location = new Point(388, 156);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(169, 27);
            textBoxCodigo.TabIndex = 41;
            // 
            // textBoxModifDescr
            // 
            textBoxModifDescr.Location = new Point(388, 243);
            textBoxModifDescr.Name = "textBoxModifDescr";
            textBoxModifDescr.Size = new Size(169, 27);
            textBoxModifDescr.TabIndex = 42;
            // 
            // textBoxModifPrecio
            // 
            textBoxModifPrecio.Location = new Point(388, 286);
            textBoxModifPrecio.Name = "textBoxModifPrecio";
            textBoxModifPrecio.Size = new Size(169, 27);
            textBoxModifPrecio.TabIndex = 43;
            // 
            // textBoxModifName
            // 
            textBoxModifName.Location = new Point(388, 200);
            textBoxModifName.Name = "textBoxModifName";
            textBoxModifName.Size = new Size(169, 27);
            textBoxModifName.TabIndex = 44;
            // 
            // textBoxModifCant
            // 
            textBoxModifCant.Location = new Point(388, 332);
            textBoxModifCant.Name = "textBoxModifCant";
            textBoxModifCant.Size = new Size(169, 27);
            textBoxModifCant.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(192, 159);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 46;
            label1.Text = "Codigo del producto";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(186, 203);
            label2.Name = "label2";
            label2.Size = new Size(154, 20);
            label2.TabIndex = 47;
            label2.Text = "Nombre del producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(163, 246);
            label3.Name = "label3";
            label3.Size = new Size(177, 20);
            label3.TabIndex = 48;
            label3.Text = "Descripcion del producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(200, 289);
            label4.Name = "label4";
            label4.Size = new Size(140, 20);
            label4.TabIndex = 49;
            label4.Text = "Precio del producto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(175, 335);
            label5.Name = "label5";
            label5.Size = new Size(165, 20);
            label5.TabIndex = 50;
            label5.Text = "Cantidad de existencias";
            // 
            // FormModificar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondoModificar;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(809, 513);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxModifCant);
            Controls.Add(textBoxModifName);
            Controls.Add(textBoxModifPrecio);
            Controls.Add(textBoxModifDescr);
            Controls.Add(textBoxCodigo);
            Controls.Add(btnConfirmar);
            Controls.Add(labelHola);
            Controls.Add(lblFecha);
            Controls.Add(lblHora);
            Controls.Add(buttonRegresar);
            DoubleBuffered = true;
            Name = "FormModificar";
            Text = "FormModificar";
            Load += FormModificar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRegresar;
        private Label lblFecha;
        private Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private Label labelHola;
        private Button btnConfirmar;
        private TextBox textBoxCodigo;
        private TextBox textBoxModifDescr;
        private TextBox textBoxModifPrecio;
        private TextBox textBoxModifName;
        private TextBox textBoxModifCant;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}