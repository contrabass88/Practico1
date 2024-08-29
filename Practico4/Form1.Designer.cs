namespace Practico4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblListaDeNumeros = new System.Windows.Forms.Label();
            this.bNumerosPares = new System.Windows.Forms.Button();
            this.bNumerosImpares = new System.Windows.Forms.Button();
            this.BNumerosPrimos = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(12, 75);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(48, 16);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "Desde";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(12, 138);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(43, 16);
            this.lblHasta.TabIndex = 1;
            this.lblHasta.Text = "Hasta";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_keyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(88, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Generar Función";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(241, 75);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(280, 324);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblListaDeNumeros
            // 
            this.lblListaDeNumeros.AutoSize = true;
            this.lblListaDeNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaDeNumeros.Location = new System.Drawing.Point(299, 9);
            this.lblListaDeNumeros.Name = "lblListaDeNumeros";
            this.lblListaDeNumeros.Size = new System.Drawing.Size(310, 42);
            this.lblListaDeNumeros.TabIndex = 6;
            this.lblListaDeNumeros.Text = "Lista de Números";
            this.lblListaDeNumeros.Click += new System.EventHandler(this.lblListaDeNumeros_Click);
            // 
            // bNumerosPares
            // 
            this.bNumerosPares.Location = new System.Drawing.Point(15, 254);
            this.bNumerosPares.Name = "bNumerosPares";
            this.bNumerosPares.Size = new System.Drawing.Size(162, 47);
            this.bNumerosPares.TabIndex = 7;
            this.bNumerosPares.Text = "Número Pares";
            this.bNumerosPares.UseVisualStyleBackColor = true;
            this.bNumerosPares.Click += new System.EventHandler(this.bNPares_Click);
            // 
            // bNumerosImpares
            // 
            this.bNumerosImpares.Location = new System.Drawing.Point(15, 307);
            this.bNumerosImpares.Name = "bNumerosImpares";
            this.bNumerosImpares.Size = new System.Drawing.Size(162, 47);
            this.bNumerosImpares.TabIndex = 8;
            this.bNumerosImpares.Text = "Números Impares";
            this.bNumerosImpares.UseVisualStyleBackColor = true;
            this.bNumerosImpares.Click += new System.EventHandler(this.bNimpares_Click);
            // 
            // BNumerosPrimos
            // 
            this.BNumerosPrimos.Location = new System.Drawing.Point(12, 360);
            this.BNumerosPrimos.Name = "BNumerosPrimos";
            this.BNumerosPrimos.Size = new System.Drawing.Size(162, 47);
            this.BNumerosPrimos.TabIndex = 9;
            this.BNumerosPrimos.Text = "Números Primos";
            this.BNumerosPrimos.UseVisualStyleBackColor = true;
            this.BNumerosPrimos.Click += new System.EventHandler(this.bNumerosPares_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(540, 75);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(330, 324);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.BNumerosPrimos);
            this.Controls.Add(this.bNumerosImpares);
            this.Controls.Add(this.bNumerosPares);
            this.Controls.Add(this.lblListaDeNumeros);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Name = "Form1";
            this.Text = "Formulario 4";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblListaDeNumeros;
        private System.Windows.Forms.Button bNumerosPares;
        private System.Windows.Forms.Button bNumerosImpares;
        private System.Windows.Forms.Button BNumerosPrimos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

