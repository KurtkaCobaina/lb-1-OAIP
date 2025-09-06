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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string a = textBox1.Text;
            int size = int.Parse(a);
            int[] mass = new int[size];
            for (int i = 0; i < size; i++)
            {
                mass[i] = int.Parse(textBox2.Text.Split(' ')[i]);
            }
            int difference = CalculateDifference(mass);
            label1.Text = "Модуль разности: " + Math.Abs(difference);
        }

        private int CalculateDifference(int[] mass)
        {
            int negativeCount = 0;
            int positiveCount = 0;
            foreach (int num in mass)
            {
                if (num < 0)
                {
                    negativeCount++;
                }
                else if (num > 0)
                {
                    positiveCount++;
                }
            }
            return negativeCount - positiveCount;
        }
    }
}

