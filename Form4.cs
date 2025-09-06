using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба_оаип_7
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string a = textBox1.Text;
            int n = int.Parse(a);
            int[,] matrix = new int[n, n];
            string inputMatrix = textBox2.Text;
            string[] values = inputMatrix.Split(' ');

            if (values.Length != n * n)
            {
                MessageBox.Show("Неверное количество элементов в матрице.");
                return;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (!int.TryParse(values[i * n + j], out matrix[i, j]))
                    {
                        MessageBox.Show("Пожалуйста, введите целые числа для элементов матрицы.");
                        return;
                    }
                }
            }
            inputMatrix = "";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    inputMatrix += matrix[i, j] + " ";
                }
                inputMatrix += Environment.NewLine;
                richTextBox1.Text = inputMatrix;
            }



            for (int i = 0; i < n; i++)
            {
                int temp = matrix[i, i];
                matrix[i, i] = matrix[i, n - 1 - i];
                matrix[i, n - i - 1] = temp;
            }

            string outputMatrix = "";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    outputMatrix += matrix[i, j] + " ";
                }
                outputMatrix += Environment.NewLine;

            }

            richTextBox2.Text = outputMatrix;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}