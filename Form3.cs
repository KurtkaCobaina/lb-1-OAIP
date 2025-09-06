using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Лаба_оаип_7
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int N = 0;
            if (!(int.TryParse(textBox1.Text, out N)))
            {
                MessageBox.Show("Неверное число");
                return;
            }
            else
            {
                int a = 0, b = 1, c = 1;

                while (c < N)
                {
                    listBox1.Items.Add(c);
                    a = b;
                    b = c;
                    c = a + b;

                }
                label2.Text = "Ряд чисел \r\n фибоначи";
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
