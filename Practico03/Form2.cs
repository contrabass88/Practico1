using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico2
{
    public partial class Pequeño : Form
    {
        public Pequeño()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LModificar_Click(object sender, EventArgs e)
        {

        }

        private void TGuardar_Click(object sender, EventArgs e)
        {
            DialogResult ask;

            if (string.IsNullOrWhiteSpace(TDni.Text) ||
                   string.IsNullOrEmpty(TApellido.Text) ||
                   string.IsNullOrEmpty(TNombre.Text))
            {
                // Mostrar mensaje de error
                ask = MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (ask == DialogResult.OK);
            }
            else
            
           

                // Mostrar el MessageBox de confirmación con "Sí" como opción predeterminada
                ask = MessageBox.Show("Seguro que desea insertar un nuevo Cliente?",
                                      "Confirmar Inserción",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question,
                                      MessageBoxDefaultButton.Button1);

                // Evaluar la respuesta del usuario
                if (ask == DialogResult.Yes)
                {
                // Código para insertar el nuevo cliente

                string nombreCompleto = $"{TNombre.Text} {TApellido.Text}";
                // ...
                MessageBox.Show($"El Cliente: {nombreCompleto} se insertó correctamente",
                            "Guardar",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);


              //  string nombre = TNombre.Text;
                //string apellido = TApellido.Text;
                //string nombreCompleto = nombre + " " + apellido;

                LModificar.Text = nombreCompleto;
                
            }
        }

        private void TDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private const string V = " ";
        ErrorProvider errorP = new ErrorProvider();
        private object pictureBox1;

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool Valida = ValidarTxt.soloNumeros(e);
            if (!Valida)
                errorP.SetError(TDni, "Solo números");
            else
                errorP.Clear();
        }

        private void TNombre_Leave(object sender, EventArgs e)
        {
            if(ValidarTxt.textVacios(TNombre))
                errorP.SetError(TNombre, "No puede dejar vacio el campo");
            else
                errorP.Clear();
        }

        private void TApellido_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.textVacios(TApellido))
                errorP.SetError(TApellido, "No puede dejar vacio el campo");
            else
                errorP.Clear();

        }

        private void TDni_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.textVacios(TDni))
                errorP.SetError(TDni, "No puede dejar vacio el campo");
            else
                errorP.Clear();
        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        { 
                bool valida = ValidarTxt.soloLetras(e);
                if (!valida)
                    errorP.SetError(TNombre, "Solo letras");
                else
                    errorP.Clear();
        }

        private void TApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTxt.soloLetras(e);
            if (!valida)
                errorP.SetError(TApellido, "Solo letras");
            else
                errorP.Clear();

        }

        private void TEliminar_Click(object sender, EventArgs e)
        {
            string nombreCompleto = $"{TNombre.Text} {TApellido.Text}";

            DialogResult ask;

            ask = MessageBox.Show($"Está a punto de eliminar al Cliente: {nombreCompleto}",
                          "Confirmar Eliminación",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Exclamation,
                          MessageBoxDefaultButton.Button2);

            if (ask == DialogResult.Yes)
            {
                TDni.Clear();
                TApellido.Clear();
                TNombre.Clear();
                TTelefono.Clear();
                LModificar.Text = "";

                CBNaranja.Checked = false;
                CBVisa.Checked = false;
                CBMastercard.Checked = false;   

                // Mostrar un mensaje opcional confirmando que se ha eliminado el cliente
                MessageBox.Show($"El Cliente: {nombreCompleto} se eliminó correctamente",
                                "Eliminación Confirmada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RBVaron_CheckedChanged(object sender, EventArgs e)
        {
  
         pictureBox2.Image = Practico03.Properties.Resources.customer_person_people_man_you_1625__1_; // Cambia la imagen a la de Varón
            
        }

        private void TNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void RBMujer_CheckedChanged_1(object sender, EventArgs e)
        {
           
           
        pictureBox2.Image = Practico03.Properties.Resources.customer_person_people_woman_you_16271; // Cambia la imagen a la de Mujer
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
