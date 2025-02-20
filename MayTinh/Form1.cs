using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppNew
{
    public partial class frmbai1 : Form
    {
        public frmbai1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (int.TryParse(txtSoNguyenA.Text, out int Result) == false)
            {
                errorProvider.SetError(txtSoNguyenA, "Error");
            }
            if (int.TryParse(txtSoNguyenB.Text, out int Resulat) == false)
            {
                errorProvider.SetError(txtSoNguyenB, "Error");
            }
            else if(int.TryParse(txtSoNguyenA.Text, out int Resulst) && int.TryParse(txtSoNguyenB.Text, out int Resulast))
            {
                int a = int.Parse(txtSoNguyenA.Text);
                int b = int.Parse (txtSoNguyenB.Text);
                lblTong.Text ="a + b = "+ (a+b).ToString();
                lblHieu.Text ="a - b =  " + (a - b).ToString();
                lblNhan.Text ="a * b = " +  (a * b).ToString();
                if (b == 0)
                    lblChia.Text = "Lỗi chia cho 0";
                else
                {
                    lblChia.Text = "a / b = " + (a/b).ToString();
                }

            }
        }

        //D:\Project\WindowsFormsAppNew\WindowsFormsAppNew\Form1.cs
        private void txtSoNguyenA_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtSoNguyenA,"Số không hợp lệ");
        }

        private void txtSoNguyenB_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtSoNguyenB,"Số không hợp lệ");
        }
    }
}
