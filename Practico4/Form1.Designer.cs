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
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblListaDeNumeros = new System.Windows.Forms.Label();
            this.bNumerosPares = new System.Windows.Forms.Button();
            this.bNumerosImpares = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(243, 69);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(48, 16);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "Desde";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(243, 132);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(43, 16);
            this.lblHasta.TabIndex = 1;
            this.lblHasta.Text = "Hasta";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(297, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_keyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(297, 132);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 186);
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
            this.listBox1.Location = new System.Drawing.Point(440, 69);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(471, 324);
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
            this.bNumerosPares.Location = new System.Drawing.Point(226, 237);
            this.bNumerosPares.Name = "bNumerosPares";
            this.bNumerosPares.Size = new System.Drawing.Size(162, 47);
            this.bNumerosPares.TabIndex = 7;
            this.bNumerosPares.Text = "Número Pares";
            this.bNumerosPares.UseVisualStyleBackColor = true;
            this.bNumerosPares.Click += new System.EventHandler(this.bNPares_Click);
            // 
            // bNumerosImpares
            // 
            this.bNumerosImpares.Location = new System.Drawing.Point(226, 290);
            this.bNumerosImpares.Name = "bNumerosImpares";
            this.bNumerosImpares.Size = new System.Drawing.Size(162, 47);
            this.bNumerosImpares.TabIndex = 8;
            this.bNumerosImpares.Text = "Números Impares";
            this.bNumerosImpares.UseVisualStyleBackColor = true;
            this.bNumerosImpares.Click += new System.EventHandler(this.bNimpares_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(226, 343);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 47);
            this.button4.TabIndex = 9;
            this.button4.Text = "Números Primos";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 450);
            this.Controls.Add(this.button4);
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
        private System.Windows.Forms.Button button4;
    }
}

