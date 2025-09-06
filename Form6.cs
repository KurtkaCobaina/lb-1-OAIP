using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба_оаип_7
{

    public partial class Form6 : Form
    {
        private int first;
        private int second;

        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            first = int.Parse(textBox1.Text);
            second = int.Parse(textBox2.Text);
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            FractionCalculator ob = new FractionCalculator();
            ob.Read(first, second);
            int divisor = ob.ACDC();
            first /= divisor;
            second /= divisor;
            label3.Text = "Несокрощаемая дробь: " + first + "/" + second;
        }
    }
    public class FractionCalculator
    {
        private int first;
        private int second;

        public void Read(int  first, int second)
        {
            this.first = first;
            this.second = second;
        }

        private int ACDC(int first, int second)
        {
            if (second == 0)
            {
                return first;
            }
            else
            {
                return ACDC(second, first % second);
            }
        }

        public int ACDC()
        {
            if (second == 0)
            {
                return first;
            }
            else
            {
                return ACDC(second, first % second);
            }
        }
    }

}
