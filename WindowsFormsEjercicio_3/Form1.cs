using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsEjercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarResultado();
            textBox1.Text += "7";
        }
        private void button12_Click(object sender, EventArgs e)
        {
            LimpiarResultado();
            textBox1.Text += ".";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            LimpiarResultado();
            // Si el TextBox está vacío, añadir "0/"
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                label1.Text = "0/";
            }
            else
            {
                // Si ya hay texto, simplemente añadir el '/'
                label1.Text += textBox1.Text += "/";
                textBox1.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimpiarResultado();
            textBox1.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LimpiarResultado();
            textBox1.Text += "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LimpiarResultado();
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LimpiarResultado();
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LimpiarResultado();
            textBox1.Text += "6";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            LimpiarResultado();
            // Si el TextBox está vacío, añadir "0*"
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                label1.Text = "0*";
            }
            else
            {
                // Si ya hay texto, simplemente añadir el '*'
                label1.Text += textBox1.Text += "*";
                textBox1.Clear();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LimpiarResultado();
            textBox1.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LimpiarResultado();
            textBox1.Text += "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LimpiarResultado();
            textBox1.Text += "3";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            LimpiarResultado();
            // Si el TextBox está vacío, añadir "0-"
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                label1.Text = "0-";
            }
            else
            {
                // Si ya hay texto, simplemente añadir el '-'
                label1.Text += textBox1.Text += "-";
                textBox1.Clear();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            LimpiarResultado();
            textBox1.Text += "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            LimpiarResultado();
            // Si el TextBox está vacío, añadir "0+"
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                label1.Text = "0+";
            }
            else
            {
                // Si ya hay texto, simplemente añadir el '+'
                label1.Text += textBox1.Text += "+";
                textBox1.Clear();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            LimpiarResultado();
            // Si el TextBox está vacío, añadir "="
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                label1.Text = "";
            }
            else
            {
                // Si ya hay texto, simplemente añadir el '-'
                label1.Text += textBox1.Text;
                textBox1.Clear();
                try
                {
                    // Evaluar la operación contenida en label1.Text
                    var result = new DataTable().Compute(label1.Text, null);

                    // Mostrar el resultado en el Label
                    textBox1.Text = result.ToString();
                    label1.Text += " =";
                }
                catch (Exception ex)
                {
                    // En caso de error, mostrar el mensaje de error
                    label1.Text = "Error: " + ex.Message;
                    
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            LimpiarResultado();
            // Verificar que el TextBox no esté vacío
            if (textBox1.Text.Length > 0)
            {
                // Eliminar el último carácter
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Verificar si el primer carácter del TextBox es un '-'
            if (textBox1.Text.StartsWith("-"))
            {
                // Si existe, quitar el signo '-'
                textBox1.Text = textBox1.Text.Substring(1);
            }
            else
            {
                // Si no existe, agregar el signo '-' al principio
                textBox1.Text = "-" + textBox1.Text;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            // Borrar todo el contenido del TextBox
            textBox1.Clear();
            

        }

        private void button19_Click(object sender, EventArgs e)
        {
            // Borrar todo el contenido del TextBox
            textBox1.Clear();
            label1.Text = string.Empty;
        }
    }
}
