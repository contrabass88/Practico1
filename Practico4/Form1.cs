using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblListaDeNumeros_Click(object sender, EventArgs e)
        {

        }
        ErrorProvider errorP = new ErrorProvider();
        private void TxtDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool Valida = ValidarTxt.soloNumeros(e);
            if (!Valida)
                errorP.SetError(txtDesde, "Solo números");
            else
                errorP.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
