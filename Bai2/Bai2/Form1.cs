using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Ham kiem tra so nguyen to
        public bool checkNT(int n)
        {
            if (n < 2)
                return false;
            if (n == 2 || n == 3)
                return true;
            else if (n % 2 == 0 || n % 3 == 0)
                return false;
            else
            {
                int sq = (int)Math.Sqrt(n);
                for (int i = 5; i <= sq; i += 2)// 6k + 1 | 6k - 1
                {
                    if ((n % i == 0) || (n % (i + 2) == 0))
                        return false;
                }
            }
            return true;
        }

        //ham kiem tra so chinh phuong
        public bool checkCP(int n)
        {
            if (n == 0)
                return false;
            if (n == (int)Math.Sqrt(n) * (int)Math.Sqrt(n))
                return true;
            return false;
        }

        //ham kiem tra so hoan hao
        public bool checkPerfect(int n)
        {
            if (n < 6)
                return false;
            int sum = 1;
            int sq = (int)Math.Sqrt(n);
            for (int i = 2; i <= sq; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                    if (i != n / i)
                        sum += n / i;
                }
            }
            return sum == n;
        }
        //D:\Project\BaiTapWinForm\Bai2(WinformCoBan)\Bai2(WinformCoBan)\Form1.cs
        private void txtSoNguyen_Leave(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(txtSoNguyen.Text);
                if (n <= 0 || n >= 1000)
                {
                    MessageBox.Show("N phải thỏa mãn 0 < n < 1000", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSoNguyen.Text = "";
                    txtSoNguyen.Focus();
                }
                else
                {

                    //in ra cac so nguyen to nho hon n
                    string SoNguyenTo = "";
                    for (int i = 0; i < n; i++)
                    {
                        if (checkNT(i))
                            SoNguyenTo += i + " ";
                    }
                    lblSoNguyenTo.Text = SoNguyenTo;// gan thuoc tinh text cua lblSoNguyenTo = SoNguyenTo

                    //in ra cac so chinh phuong nho hon n
                    string SoChinhPhuong = "";
                    for (int i = 0; i < n; i++)
                    {
                        if (checkCP(i))
                            SoChinhPhuong += i + " ";
                    }
                    lblSoChinhPhuong.Text += SoChinhPhuong;// gan thuoc tinh text cua lblSoChinhPhuong = SoChinhPhuong


                    //in ra cac so hoan hao nho hon n
                    string SoHoanChinh = "";
                    for (int i = 0; i < n; i++)
                    {
                        if (checkPerfect(i))
                            SoHoanChinh += i + " ";
                    }
                    lblSoHoanChinh.Text = SoHoanChinh;// gan thuoc tinh text cua lblSoNguyenTo = SoNguyenTo

                    if (lblSoChinhPhuong.Text == "")
                        lblSoChinhPhuong.Text = "Không có số nào thỏa mãn";
                    if (lblSoHoanChinh.Text == "")
                        lblSoHoanChinh.Text = "Không có số nào thỏa mãn";
                    if (lblSoNguyenTo.Text == "")
                        lblSoNguyenTo.Text = "Không có số nào thỏa mãn";

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Phải là số nguyên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoNguyen.Text = "";
                txtSoNguyen.Focus();
            }
        }

        private void txtSoNguyen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSoNguyen_Leave(sender, e);
            }
        }
    }
}
