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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            lblFecha = new Label();
            lblHora = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonVerCarrito = new Button();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Font = new Font("Sylfaen", 8F, FontStyle.Bold);
            lblFecha.ForeColor = SystemColors.ButtonHighlight;
            lblFecha.Location = new Point(-1, 13);
            lblFecha.Margin = new Padding(2, 0, 2, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(46, 18);
            lblFecha.TabIndex = 31;
            lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.BackColor = Color.Transparent;
            lblHora.Font = new Font("Sylfaen", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHora.ForeColor = SystemColors.ButtonHighlight;
            lblHora.Location = new Point(1156, 9);
            lblHora.Margin = new Padding(2, 0, 2, 0);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(50, 22);
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
            label1.Location = new Point(491, 105);
            label1.Name = "label1";
            label1.Size = new Size(281, 23);
            label1.TabIndex = 33;
            label1.Text = "GRAFICA PRODUCTOS VENDIDOS";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(212, 172);
            chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            chart1.Series.Add(series2);
            chart1.Size = new Size(585, 531);
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
            buttonVerCarrito.Location = new Point(1014, 647);
            buttonVerCarrito.Margin = new Padding(2);
            buttonVerCarrito.Name = "buttonVerCarrito";
            buttonVerCarrito.Size = new Size(192, 67);
            buttonVerCarrito.TabIndex = 35;
            buttonVerCarrito.UseVisualStyleBackColor = false;
            buttonVerCarrito.Click += buttonVerCarrito_Click;
            // 
            // Grafica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_grafica;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1253, 826);
            Controls.Add(buttonVerCarrito);
            Controls.Add(chart1);
            Controls.Add(label1);
            Controls.Add(lblHora);
            Controls.Add(lblFecha);
            DoubleBuffered = true;
            Name = "Grafica";
            Text = "Grafica";
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
    }
}