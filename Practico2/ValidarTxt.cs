using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico2
{
    internal class ValidarTxt
    {
        public static bool soloNumeros(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else
            {
                e.Handled = true;
                return false;
            }
        }

        public static bool textVacios(TextBox pTxt)
        {
            if (pTxt.Text == string.Empty)
            {
                pTxt.Focus();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool soloLetras(KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es una letra o si es una tecla de control (como backspace)
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false; // Permitir la tecla presionada
                return true;
            }
            else
            {
                e.Handled = true; // Bloquear la tecla presionada
                return false;
            }
        }

    }
}
