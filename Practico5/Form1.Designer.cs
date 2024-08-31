namespace Practico5
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.RBHombre = new System.Windows.Forms.RadioButton();
            this.RBMujer = new System.Windows.Forms.RadioButton();
            this.DTFechaNac = new System.Windows.Forms.DateTimePicker();
            this.BtnFoto = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.TSaldo = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.TBFoto = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PBFoto = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ELiminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Foto1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(52, 7);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(124, 44);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(52, 68);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(129, 44);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaNac.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.ForeColor = System.Drawing.Color.White;
            this.lblFechaNac.Location = new System.Drawing.Point(52, 121);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(243, 44);
            this.lblFechaNac.TabIndex = 3;
            this.lblFechaNac.Text = "Fecha Nacimiento:";
            this.lblFechaNac.UseMnemonic = false;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.BackColor = System.Drawing.Color.Transparent;
            this.lblSexo.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.Color.White;
            this.lblSexo.Location = new System.Drawing.Point(52, 165);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(93, 44);
            this.lblSexo.TabIndex = 4;
            this.lblSexo.Text = "Sexo:";
            // 
            // RBHombre
            // 
            this.RBHombre.AutoSize = true;
            this.RBHombre.BackColor = System.Drawing.Color.Transparent;
            this.RBHombre.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBHombre.ForeColor = System.Drawing.Color.White;
            this.RBHombre.Location = new System.Drawing.Point(200, 178);
            this.RBHombre.Name = "RBHombre";
            this.RBHombre.Size = new System.Drawing.Size(106, 35);
            this.RBHombre.TabIndex = 5;
            this.RBHombre.Text = "Hombre";
            this.RBHombre.UseVisualStyleBackColor = false;
            // 
            // RBMujer
            // 
            this.RBMujer.AutoSize = true;
            this.RBMujer.BackColor = System.Drawing.Color.Transparent;
            this.RBMujer.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBMujer.ForeColor = System.Drawing.Color.White;
            this.RBMujer.Location = new System.Drawing.Point(355, 178);
            this.RBMujer.Name = "RBMujer";
            this.RBMujer.Size = new System.Drawing.Size(88, 35);
            this.RBMujer.TabIndex = 6;
            this.RBMujer.Text = "Mujer";
            this.RBMujer.UseVisualStyleBackColor = false;
            // 
            // DTFechaNac
            // 
            this.DTFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTFechaNac.ImeMode = System.Windows.Forms.ImeMode.On;
            this.DTFechaNac.Location = new System.Drawing.Point(324, 131);
            this.DTFechaNac.Name = "DTFechaNac";
            this.DTFechaNac.Size = new System.Drawing.Size(120, 22);
            this.DTFechaNac.TabIndex = 10;
            // 
            // BtnFoto
            // 
            this.BtnFoto.Location = new System.Drawing.Point(60, 270);
            this.BtnFoto.Name = "BtnFoto";
            this.BtnFoto.Size = new System.Drawing.Size(116, 45);
            this.BtnFoto.TabIndex = 8;
            this.BtnFoto.Text = "Foto";
            this.BtnFoto.UseVisualStyleBackColor = true;
            this.BtnFoto.Click += new System.EventHandler(this.BtnFoto_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Practico5.Properties.Resources.Save_37110__2_;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(273, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 53);
            this.button2.TabIndex = 9;
            this.button2.Text = "Agregar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BAgregar_Click);
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(196, 29);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(301, 22);
            this.TBNombre.TabIndex = 10;
            this.TBNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TBNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBNombre_KeyPress);
            this.TBNombre.MouseLeave += new System.EventHandler(this.TBNombre_MouseLeave);
            // 
            // TBApellido
            // 
            this.TBApellido.Location = new System.Drawing.Point(196, 80);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(301, 22);
            this.TBApellido.TabIndex = 11;
            this.TBApellido.TextChanged += new System.EventHandler(this.textBoxApellido_TextChanged);
            this.TBApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBApellido_KeyPress);
            // 
            // TSaldo
            // 
            this.TSaldo.Location = new System.Drawing.Point(200, 230);
            this.TSaldo.Name = "TSaldo";
            this.TSaldo.Size = new System.Drawing.Size(297, 22);
            this.TSaldo.TabIndex = 12;
            this.TSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TSaldo_KeyPress);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.BackColor = System.Drawing.Color.Transparent;
            this.lblSaldo.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.Color.White;
            this.lblSaldo.Location = new System.Drawing.Point(52, 218);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(102, 44);
            this.lblSaldo.TabIndex = 13;
            this.lblSaldo.Text = "Saldo:";
            // 
            // TBFoto
            // 
            this.TBFoto.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.TBFoto.Location = new System.Drawing.Point(200, 281);
            this.TBFoto.Name = "TBFoto";
            this.TBFoto.Size = new System.Drawing.Size(297, 22);
            this.TBFoto.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Practico5.Properties.Resources.fon2;
            this.panel1.Controls.Add(this.TBFoto);
            this.panel1.Controls.Add(this.lblSaldo);
            this.panel1.Controls.Add(this.TSaldo);
            this.panel1.Controls.Add(this.TBApellido);
            this.panel1.Controls.Add(this.TBNombre);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.BtnFoto);
            this.panel1.Controls.Add(this.DTFechaNac);
            this.panel1.Controls.Add(this.RBMujer);
            this.panel1.Controls.Add(this.RBHombre);
            this.panel1.Controls.Add(this.lblSexo);
            this.panel1.Controls.Add(this.lblFechaNac);
            this.panel1.Controls.Add(this.lblApellido);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Location = new System.Drawing.Point(51, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 384);
            this.panel1.TabIndex = 16;
            // 
            // PBFoto
            // 
            this.PBFoto.Image = global::Practico5.Properties.Resources.avatar_png;
            this.PBFoto.ImageLocation = "";
            this.PBFoto.Location = new System.Drawing.Point(686, 37);
            this.PBFoto.Name = "PBFoto";
            this.PBFoto.Size = new System.Drawing.Size(294, 281);
            this.PBFoto.TabIndex = 17;
            this.PBFoto.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Fecha,
            this.Columna4,
            this.Saldo,
            this.ELiminar,
            this.Foto1,
            this.Ruta});
            this.dataGridView1.Location = new System.Drawing.Point(12, 423);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1051, 150);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.Width = 125;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha de Nacimiento";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 125;
            // 
            // Columna4
            // 
            this.Columna4.HeaderText = "Sexo";
            this.Columna4.MinimumWidth = 6;
            this.Columna4.Name = "Columna4";
            this.Columna4.Width = 125;
            // 
            // Saldo
            // 
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.MinimumWidth = 6;
            this.Saldo.Name = "Saldo";
            this.Saldo.Width = 125;
            // 
            // ELiminar
            // 
            this.ELiminar.HeaderText = "Eliminar";
            this.ELiminar.MinimumWidth = 6;
            this.ELiminar.Name = "ELiminar";
            this.ELiminar.Width = 125;
            // 
            // Foto1
            // 
            this.Foto1.HeaderText = "Foto";
            this.Foto1.MinimumWidth = 6;
            this.Foto1.Name = "Foto1";
            this.Foto1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Foto1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Foto1.Width = 125;
            // 
            // Ruta
            // 
            this.Ruta.HeaderText = "Ruta";
            this.Ruta.MinimumWidth = 6;
            this.Ruta.Name = "Ruta";
            this.Ruta.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Practico5.Properties.Resources.fondoFinal;
            this.ClientSize = new System.Drawing.Size(1142, 653);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PBFoto);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.RadioButton RBHombre;
        private System.Windows.Forms.RadioButton RBMujer;
        private System.Windows.Forms.DateTimePicker DTFechaNac;
        private System.Windows.Forms.Button BtnFoto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.TextBox TSaldo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox TBFoto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PBFoto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewButtonColumn ELiminar;
        private System.Windows.Forms.DataGridViewImageColumn Foto1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruta;
    }
}

