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
                if (newObject.Name == "btnSpace")
                {
                    richTextBox1.Text += " ";
                }
                else
                    richTextBox1.Text += newObject.Text;
            }
            newObject.BackColor = Color.Orange;
        }

        private Dictionary<Button, Color> buttonColors = new Dictionary<Button, Color>();

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            string temp = e.KeyCode.ToString().ToUpper();
            Console.WriteLine(temp);
            if (temp == "SPACE")
            {
                btnSpace.Focus();
                buttonColors[btnSpace] = btnSpace.BackColor;
                button31_Click(btnSpace, e);
                this.ActiveControl = null;

            }
            if (temp == "BACK")
            {
                button41.Focus();
                buttonColors[button41] = button41.BackColor;
                button31_Click(button41, e);
                this.ActiveControl = null;

            }
            if(temp == "RETURN")
            {
                richTextBox1.Text += "\n";
                this.ActiveControl = null;
            }
            else { 
            foreach (Control c in GetAllControls(this))
            {
                if (c is Button btn && btn.Text.ToUpper() == temp)
                {
                    btn.Focus();

                    // Lưu màu hiện tại của phím
                    if (!buttonColors.ContainsKey(btn))
                        buttonColors[btn] = btn.BackColor;

                    button31_Click(btn, e);
                    this.ActiveControl = null;
                    }
                else if (c is Button btn1 && btn1.Name.ToUpper() == temp)
                {
                    btn1.Focus();

                    // Lưu màu hiện tại của phím
                    if (!buttonColors.ContainsKey(btn1))
                        buttonColors[btn1] = btn1.BackColor;

                    button31_Click(btn1, e);
                    this.ActiveControl = null;
                }
             }
            }
        }
        

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            string temp = e.KeyCode.ToString().ToUpper();
            if (temp == "SPACE")
            {
                btnSpace.Focus();
                btnSpace.BackColor = buttonColors[btnSpace];
                buttonColors.Remove(btnSpace);
                this.ActiveControl = null;


            }
            foreach (Control c in GetAllControls(this))
            {
                if (c is Button btn && btn.Text.ToUpper() == temp)
                {
                    btn.Focus();

                    // Phục hồi màu ban đầu nếu đã lưu
                    if (buttonColors.ContainsKey(btn))
                    {
                        btn.BackColor = buttonColors[btn];
                        buttonColors.Remove(btn);
                    }
                    this.ActiveControl = null;
                }
                else if (c is Button btn1 && btn1.Name.ToUpper() == temp)
                {
                    btn1.Focus();
                    btn1.BackColor = buttonColors[btn1];
                    buttonColors.Remove(btn1);
                    this.ActiveControl = null;
                }
            }
        }

        public IEnumerable<Control> GetAllControls(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                yield return c;
                if (c.HasChildren)
                {
                    foreach (Control c2 in GetAllControls(c)) { yield return c2; }
                }
            }
        }

    }
}




