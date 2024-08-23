using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico1
{
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void Formulario1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string apellido = textBoxApellido.Text;
            string nombreCompleto = apellido + " " + nombre;

            textBoxResultado.Text = nombreCompleto;
            limpiar();
        }

        private void limpiar()
        {
            textBoxNombre.Clear();
            textBoxApellido.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Sobrescribir ProcessCmdKey para capturar la combinación de teclas Ctrl + S
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Verificar si se presionó Ctrl + S
            if (keyData == (Keys.Control | Keys.S))
            {
                this.Close();
                return true; // Indicar que se ha manejado la tecla
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            this.textBoxResultado.Clear();
        }
    }
}
