namespace Practico2
{
    partial class Pequeño
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
            this.LDni = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LNya = new System.Windows.Forms.Label();
            this.LModificar = new System.Windows.Forms.Label();
            this.TDni = new System.Windows.Forms.TextBox();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.TGuardar = new System.Windows.Forms.Button();
            this.TEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Cursor = System.Windows.Forms.Cursors.Default;
            this.LDni.Location = new System.Drawing.Point(87, 103);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(30, 16);
            this.LDni.TabIndex = 0;
            this.LDni.Text = "DNI";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Cursor = System.Windows.Forms.Cursors.Default;
            this.LNombre.Location = new System.Drawing.Point(86, 156);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(56, 16);
            this.LNombre.TabIndex = 1;
            this.LNombre.Text = "Nombre";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Cursor = System.Windows.Forms.Cursors.Default;
            this.LApellido.Location = new System.Drawing.Point(86, 202);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(57, 16);
            this.LApellido.TabIndex = 2;
            this.LApellido.Text = "Apellido";
            // 
            // LNya
            // 
            this.LNya.AutoSize = true;
            this.LNya.Location = new System.Drawing.Point(87, 48);
            this.LNya.Name = "LNya";
            this.LNya.Size = new System.Drawing.Size(121, 16);
            this.LNya.TabIndex = 3;
            this.LNya.Text = "Nombre Y Apellido";
            // 
            // LModificar
            // 
            this.LModificar.AutoSize = true;
            this.LModificar.ForeColor = System.Drawing.Color.Red;
            this.LModificar.Location = new System.Drawing.Point(268, 48);
            this.LModificar.Name = "LModificar";
            this.LModificar.Size = new System.Drawing.Size(62, 16);
            this.LModificar.TabIndex = 4;
            this.LModificar.Text = "Modificar";
            this.LModificar.Click += new System.EventHandler(this.LModificar_Click);
            // 
            // TDni
            // 
            this.TDni.Location = new System.Drawing.Point(216, 97);
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(208, 22);
            this.TDni.TabIndex = 5;
            this.TDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TDni.TextChanged += new System.EventHandler(this.TDni_TextChanged);
            this.TDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDni_KeyPress);
            this.TDni.Leave += new System.EventHandler(this.TDni_Leave);
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(216, 150);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(208, 22);
            this.TNombre.TabIndex = 6;
            this.TNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TNombre_KeyPress);
            this.TNombre.Leave += new System.EventHandler(this.TNombre_Leave);
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(216, 196);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(208, 22);
            this.TApellido.TabIndex = 7;
            this.TApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TApellido.TextChanged += new System.EventHandler(this.TApellido_TextChanged);
            this.TApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TApellido_KeyPress);
            this.TApellido.Leave += new System.EventHandler(this.TApellido_Leave);
            // 
            // TGuardar
            // 
            this.TGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TGuardar.Location = new System.Drawing.Point(90, 336);
            this.TGuardar.Name = "TGuardar";
            this.TGuardar.Size = new System.Drawing.Size(75, 23);
            this.TGuardar.TabIndex = 8;
            this.TGuardar.Text = "Guardar";
            this.TGuardar.UseVisualStyleBackColor = true;
            this.TGuardar.Click += new System.EventHandler(this.TGuardar_Click);
            // 
            // TEliminar
            // 
            this.TEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEliminar.Location = new System.Drawing.Point(302, 336);
            this.TEliminar.Name = "TEliminar";
            this.TEliminar.Size = new System.Drawing.Size(75, 23);
            this.TEliminar.TabIndex = 9;
            this.TEliminar.Text = "Eliminar";
            this.TEliminar.UseVisualStyleBackColor = true;
            this.TEliminar.Click += new System.EventHandler(this.TEliminar_Click);
            // 
            // Pequeño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 548);
            this.Controls.Add(this.TEliminar);
            this.Controls.Add(this.TGuardar);
            this.Controls.Add(this.TApellido);
            this.Controls.Add(this.TNombre);
            this.Controls.Add(this.TDni);
            this.Controls.Add(this.LModificar);
            this.Controls.Add(this.LNya);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.LDni);
            this.Name = "Pequeño";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pequeño Formulario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LNya;
        private System.Windows.Forms.Label LModificar;
        private System.Windows.Forms.TextBox TDni;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.Button TGuardar;
        private System.Windows.Forms.Button TEliminar;
    }
}

