using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }
        float num1;

        private void button16_Click(object sender, EventArgs e)
        {
                
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + 9;
        }

        private void clearEX_Click(object sender, EventArgs e)
        {
            if (num1 == 0 && txtBox.TextLength > 0)
            { num1 = 0; txtBox.Clear(); }
            else if (num1 > 0 && txtBox.TextLength > 0)
            { txtBox.Clear(); }
        }
    }
}
