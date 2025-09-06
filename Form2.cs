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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
          
            
            int x=0;
           
            int y=0;
           
            int z=0;
            {
                
                if (!(int.TryParse(textBox1.Text, out x) && int.TryParse(textBox2.Text, out y) && int.TryParse(textBox3.Text, out z)))
                {
                    MessageBox.Show("Неверное число");
                    return;
                }
            
                else
                {
                    if (x > 3 && x <= 7)
                    {

                        listBox1.Items.Add(x);
                    }
                    if (y > 3 && y <= 7)
                    {
                        listBox1.Items.Add(y);
                    }
                    if (z > 3 && z <= 7)
                    {
                        listBox1.Items.Add(z);
                    }
                }
                
            }
            label4.Text = "Диапозон чисел больше 3 \r\n и меньше или равно 7";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
