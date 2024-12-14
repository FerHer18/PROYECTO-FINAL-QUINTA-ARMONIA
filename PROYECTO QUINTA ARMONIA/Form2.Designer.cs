namespace PROYECTO_QUINTA_ARMONIA
{
    partial class Grafica
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            lblFecha = new Label();
            lblHora = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonVerCarrito = new Button();
            labelHola = new Label();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Font = new Font("Sylfaen", 8F, FontStyle.Bold);
            lblFecha.ForeColor = SystemColors.ButtonHighlight;
            lblFecha.Location = new Point(-1, 16);
            lblFecha.Margin = new Padding(2, 0, 2, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(53, 22);
            lblFecha.TabIndex = 31;
            lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.BackColor = Color.Transparent;
            lblHora.Font = new Font("Sylfaen", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHora.ForeColor = SystemColors.ButtonHighlight;
            lblHora.Location = new Point(1445, 11);
            lblHora.Margin = new Padding(2, 0, 2, 0);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(60, 26);
            lblHora.TabIndex = 32;
            lblHora.Text = "Hora";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(614, 131);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(347, 30);
            label1.TabIndex = 33;
            label1.Text = "GRAFICA PRODUCTOS VENDIDOS";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(265, 215);
            chart1.Margin = new Padding(4);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            chart1.Series.Add(series1);
            chart1.Size = new Size(731, 664);
            chart1.TabIndex = 34;
            chart1.Text = "chart1";
            // 
            // buttonVerCarrito
            // 
            buttonVerCarrito.BackColor = Color.Transparent;
            buttonVerCarrito.FlatAppearance.BorderSize = 0;
            buttonVerCarrito.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonVerCarrito.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonVerCarrito.FlatStyle = FlatStyle.Flat;
            buttonVerCarrito.Location = new Point(1268, 809);
            buttonVerCarrito.Margin = new Padding(2);
            buttonVerCarrito.Name = "buttonVerCarrito";
            buttonVerCarrito.Size = new Size(240, 84);
            buttonVerCarrito.TabIndex = 35;
            buttonVerCarrito.UseVisualStyleBackColor = false;
            buttonVerCarrito.Click += buttonVerCarrito_Click;
            // 
            // labelHola
            // 
            labelHola.BackColor = Color.Transparent;
            labelHola.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHola.Location = new Point(388, 123);
            labelHola.Name = "labelHola";
            labelHola.Size = new Size(228, 38);
            labelHola.TabIndex = 40;
            // 
            // Grafica
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_grafica;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1566, 1032);
            Controls.Add(labelHola);
            Controls.Add(buttonVerCarrito);
            Controls.Add(chart1);
            Controls.Add(label1);
            Controls.Add(lblHora);
            Controls.Add(lblFecha);
            DoubleBuffered = true;
            Margin = new Padding(4);
            Name = "Grafica";
            Text = "Grafica";
            Load += Grafica_Load;
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFecha;
        private Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button buttonVerCarrito;
        private Label labelHola;
    }
}