using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea_20_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
        }
        public static void sumar(double var1, double var2)
        {
            double res = var1 + var2;

            MessageBox.Show("la respuesta es "+ res);
        }
        public static void res(double var1, double var2)
        {
            double res = var1 - var2;

            MessageBox.Show("la respuesta es " + res);
        }
        public static void mul(double var1, double var2)
        {
            double res = var1 * var2;

            MessageBox.Show("la respuesta es " + res);
        }
        public static void div(double var1, double var2)
        {
            double res = var1 / var2;

            MessageBox.Show("la respuesta es " + res);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sumar(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                res(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
                textBox1.Clear();
                textBox2.Clear();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                mul(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
                textBox1.Clear();
                textBox2.Clear();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                div(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
                textBox1.Clear();
                textBox2.Clear();
            }

        }
    }
}
