using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public Color oldColer;
        private void button31_MouseEnter(object sender, EventArgs e)
        {

            Button newObject = (Button)sender;
            oldColer = newObject.BackColor;
            newObject.BackColor = Color.Pink;
        }

        private void button31_MouseLeave(object sender, EventArgs e)
        {
            Button newObject = (Button)sender;
            newObject.BackColor = oldColer;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Button newObject = (Button)sender;
            if (richTextBox1.Text.Length == 0 && newObject.Text == "<-")
            {
                richTextBox1.Text = "";
            }
            else if (richTextBox1.Text.Length > 0 && newObject.Text == "<-")
            {
                string temp = richTextBox1.Text.Substring(0, richTextBox1.TextLength - 1);
                richTextBox1.Text = temp;
            }


            else
            {
                if (newObject.Text == "btnSpace")
                {
                    richTextBox1.Text += " ";
                }
                else
                    richTextBox1.Text += newObject.Text;
            }
            newObject.BackColor = Color.Orange;
        }











    }
}




