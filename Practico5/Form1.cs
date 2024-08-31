using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Practico5
{
    public partial class Form1 : Form
    {
        private const bool V = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TBNombre.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TBNombre.Text);
            TBNombre.SelectionStart = TBNombre.Text.Length;
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            double d = 0;

            dataGridView1.Rows[n].Cells[0].Value = TBNombre.Text;
            dataGridView1.Rows[n].Cells[1].Value = TBApellido.Text;
            dataGridView1.Rows[n].Cells[2].Value = DTFechaNac.Value;
            if (RBHombre.Checked)
            {
                dataGridView1.Rows[n].Cells[3].Value = "Hombre";
            }
            else if (RBMujer.Checked)
            {
                dataGridView1.Rows[n].Cells[3].Value = "Mujer";
            }
            else
            {
                dataGridView1.Rows[n].Cells[3].Value = "X";
            }
            dataGridView1.Rows[n].Cells[4].Value = "Eliminar";

            d = Convert.ToDouble(TSaldo.Text);
            dataGridView1.Rows[n].Cells[5].Value = d;

            Image foto = Image.FromFile(TBFoto.Text);
            dataGridView1.Rows[n].Cells[6].Value = foto;
            dataGridView1.Rows[n].Cells[7].Value = TBFoto.Text;

            TBNombre.Clear();
            TBApellido.Clear();
            TSaldo.Clear();
            TBFoto.Clear();
        }

        private void BtnFoto_Click(object sender, EventArgs e)
        {
            string ruta = string.Empty;
            string directorio = @"C:\Users\tonga\source\repos\Practico5\Practico5\bin\Debug\Fotos\";
            openFileDialog1.Title = "Selecione foto de perfil";
            openFileDialog1.Filter = "JPG|.jpg|BMP |.bmp|PNG |*.png";

            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                ruta = directorio + nombrearchivo(openFileDialog1.FileName);
                File.Copy(openFileDialog1.FileName, ruta, true);
                PBFoto.Load(openFileDialog1.FileName);
                BtnFoto.Text = ruta;

            }
        }

        private string nombrearchivo(string ruta)
        {
            string archivo = string.Empty;
            FileInfo fi = new FileInfo(ruta);
            archivo = Path.GetFileNameWithoutExtension(fi.Name) + Path.GetExtension(fi.Name);

            return archivo;
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
            TBApellido.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TBApellido.Text);
            TBApellido.SelectionStart = TBNombre.Text.Length;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if (Convert.ToDouble(e.Value) <= 50)
                {
                    e.CellStyle.BackColor = Color.Red;
                }
            }
        }

        private void TBNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(e.KeyChar.ToString(), @"^[a-zA-Z\s\b]"))
            {
                e.Handled = false;
            else
                {
                    e.Handled = true;
                }
            }
        }

        private void TBApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(e.KeyChar.ToString(), @"^[a-zA-Z\s\b]"))
            {
                e.Handled = false; // input ok

            }
            else
            {
                e.Handled = true; // input denied
            }
        }

        private void TSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(e.KeyChar.ToString(), "[0-9\b,]"))
            {
                e.Handled = false; // input ok
            }
            else
            {
                e.Handled = true; // input denied
            }
        }

        private void TBNombre_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
