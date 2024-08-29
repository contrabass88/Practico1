using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_keyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void lblListaDeNumeros_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if ((textBox2.Text == "") || (textBox1.Text == ""))
            {
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int valor1 = Convert.ToInt32(textBox1.Text);
                int valor2 = Convert.ToInt32(textBox2.Text);

                
                for (int i = valor1; i <= valor2; i++)
                {
                    listBox1.Items.Add(i);
                }

                
                UpdateChart("GenerarFuncion");
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bNPares_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if ((textBox2.Text == "") || (textBox1.Text == ""))
            {
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int valor1;
                int valor2;
                valor1 = Convert.ToInt32(textBox1.Text);
                valor2 = Convert.ToInt32(textBox2.Text);

                for (int i = valor1; i <= valor2; i++)
                {
                    if (i % 2 == 0)
                    {
                        listBox1.Items.Add(i);
                    }
                }

                // Llamada al método UpdateChart después de haber generado los números
                UpdateChart("Pares");
            }
        }


        private void bNimpares_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if ((textBox2.Text == "") || (textBox1.Text == ""))
            {
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int valor1;
                int valor2;
                valor1 = Convert.ToInt32(textBox1.Text);
                valor2 = Convert.ToInt32(textBox2.Text);

                for (int i = valor1; i <= valor2; i++)
                {
                    if (i % 2 != 0)
                    {
                        listBox1.Items.Add(i);
                    }
                }

                // Llamada al método UpdateChart después de haber generado los números impares
                UpdateChart("Impares");
            }
        }


        private void BNumerosPrimos_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if ((textBox2.Text == "") || (textBox1.Text == ""))
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int valor1;
                int valor2;

                // Convertimos los valores de los TextBox a enteros
                valor1 = Convert.ToInt32(textBox1.Text);
                valor2 = Convert.ToInt32(textBox2.Text);

                // Recorremos los números en el rango
                for (int i = valor1; i <= valor2; i++)
                {
                    // Verificamos si el número es primo
                    if (EsPrimo(i))
                    {
                        listBox1.Items.Add(i);
                    }
                }

                // Llamamos a UpdateChart para graficar los números primos
                UpdateChart("Primos");
            }
        }

        // Método para verificar si un número es primo
        private bool EsPrimo(int numero)
        {
            if (numero <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0) return false;
            }
            return true;
        }


        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void UpdateChart(string tipo)
        {
            chart1.Series.Clear(); // Limpiar las series anteriores
            Series serie = new Series("Números");

            // Cambiar el tipo de gráfico según el tipo de números seleccionado
            switch (tipo)
            {
                case "GenerarFuncion":
                    serie.ChartType = SeriesChartType.Area; // Gráfico de área como ejemplo para "Generar Función"
                    break;
                case "Pares":
                    serie.ChartType = SeriesChartType.Column; // Gráfico de columnas para números pares
                    break;
                case "Impares":
                    serie.ChartType = SeriesChartType.Line; // Gráfico de líneas para números impares
                    break;
                case "Primos":
                    serie.ChartType = SeriesChartType.Pie; // Gráfico de torta para números primos
                    break;
                default:
                    serie.ChartType = SeriesChartType.Column; // Gráfico por defecto
                    break;
            }

            // Agregar los valores al gráfico
            foreach (var item in listBox1.Items)
            {
                serie.Points.AddXY(item, Convert.ToInt32(item));
            }

            chart1.Series.Add(serie);
        }
    }
}
