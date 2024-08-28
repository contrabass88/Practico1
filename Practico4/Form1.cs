﻿using System;
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
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                int valor1;
                int valor2;
                valor1 = Convert.ToInt32(textBox1.Text);
                valor2 = Convert.ToInt32(textBox2.Text);


                for (int i = valor1; i <= valor2; i++)
                {
                    if (i % 1 == 0)
                    {
                        listBox1.Items.Add(i);
                    }
                }

                //listBox1.Items.Add(valor2);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bNPares_Click(object sender, EventArgs e)

        {
            listBox1.Items.Clear();
            if ((textBox2.Text == "") || (textBox1.Text == ""))
                    MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

                    //listBox1.Items.Add(valor2);
                }
            }

        private void bNimpares_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            {
                if ((textBox2.Text == "") || (textBox1.Text == ""))
                    MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else
                {
                    int valor1;
                    int valor2;
                    valor1 = Convert.ToInt32(textBox1.Text);
                    valor2 = Convert.ToInt32(textBox2.Text);


                    for (int i = valor1; i <= valor2; i++)
                    {
                        if (!(i % 2 == 0))
                        {
                            listBox1.Items.Add(i);
                        }
                    }

                    //listBox1.Items.Add(valor2);
                }
            }
        }

        private void bNumerosPares_Click(object sender, EventArgs e)
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
            }
        }

        // Función que determina si un número es primo
        private bool EsPrimo(int numero)
        {
            if (numero <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }

            return true;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
