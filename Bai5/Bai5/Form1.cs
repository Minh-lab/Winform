using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntgiai_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txta.Text);
                int b = int.Parse(txtb.Text);
                int c = int.Parse(txtc.Text);
                if (a == 0 && b == 0 && c == 0)
                {
                    MessageBox.Show("PT Vo So Nghiem");
                }
                else if (a == 0)
                {
                    MessageBox.Show("a Phai Khac 0");
                }
                else if (a != 0)
                {
                    double delta = b * b - 4 * a * c;
                    if (delta < 0)
                    {
                        MessageBox.Show("PT Vo Nghiem!");
                    }
                    else
                    {
                        double x1 = -((b - Math.Sqrt(delta)) / 2 * a);
                        double x2 = -((b + Math.Sqrt(delta)) / 2 * a);
                        Console.WriteLine(a);
                        Console.WriteLine(b);
                        Console.WriteLine(Math.Sqrt(delta));

                        lblx1.Text = x1.ToString();
                        lblx2.Text = x2.ToString();
                    }
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Sai dinh dang a, b, c", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Loi chia cho 0", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void đổiMàuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control control1 = contextMenuStrip1.SourceControl;
            if (control1 != null  )
            {
                using (ColorDialog colorDialog = new ColorDialog())
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                    {
                        control1.BackColor = colorDialog.Color;
                    } 
            }
        }

        private void đổiFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control control = contextMenuStrip1.SourceControl;
            if (control != null) 
            {
                using (FontDialog fontDialog = new FontDialog())
                {
                    if (fontDialog.ShowDialog() == DialogResult.OK)
                    {
                        control.Font = fontDialog.Font; // Đổi font của control được chọn
                    }
                }
            }
        }


        public Color oldColor;
        private void label2_MouseEnter(object sender, EventArgs e)
        {
            Label newColor = (Label)sender;
            if (newColor != null)
            {
                oldColor = newColor.BackColor;
                newColor.BackColor = Color.Gray;
            }
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            Label newColor = (Label)sender;
            if(newColor != null)
                newColor.BackColor = oldColor;
        }



 
    }
}
