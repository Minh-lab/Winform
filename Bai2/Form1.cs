using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2_WinformCoBan_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Hàm kiểm tra số nguyên tố
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

        //hàm kiểm tra số chính phương
        public bool checkCP(int n)
        {
            if (n == 0)
                return false;
            if (n == (int)Math.Sqrt(n) * (int)Math.Sqrt(n))
                return true;
            return false;
        }
        
        //Hàm kiểm tra số hoàn hảo
        public bool checkPerfect(int n)
        {
            if (n < 6)
                return false;
            int sum = 1;
            int sq = (int)Math.Sqrt(n);
            for(int i = 2; i <= sq; i++)
            {
                if(n % i == 0)
                {
                    sum += i;
                    if (i != n / i)
                        sum += n / i;
                }
            }
            return sum == n;
        }
        private void txtSoNguyen_Leave(object sender, EventArgs e)
        {
            try
            {
                
                label4.Location = new Point(5, 160);
                label3.Location = new Point(5, 195);
                lblSoChinhPhuong.Location = new Point(225, 170);
                lblSoHoanChinh.Location = new Point(202, 205);

                int n = Convert.ToInt32(txtSoNguyen.Text);

                if (n <= 0 || n >= 1000)
                {
                    MessageBox.Show("N phải thỏa mãn 0 < n < 1000", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSoNguyen.Text = "";
                    txtSoNguyen.Focus();
                }
                else
                {

                    //In ra các số nguyên tố nhỏ hơn n
                    string SoNguyenTo = "";
                    for (int i = 0; i < n; i++)
                    {
                        if (checkNT(i))
                            SoNguyenTo += i + " ";
                    }
                    lblSoNguyenTo.Text = SoNguyenTo;// gan thuoc tinh text cua lblSoNguyenTo = SoNguyenTo
                    
                    //In ra các số chính phương nhỏ hơn n
                    string SoChinhPhuong = "";
                    for (int i = 0; i < n; i++)
                    {
                        if (checkCP(i))
                            SoChinhPhuong += i + " ";
                    }
                    lblSoChinhPhuong.Text = SoChinhPhuong;// gan thuoc tinh text cua lblSoChinhPhuong = SoChinhPhuong


                    //In ra các số hoàn hảo nhỏ hơn n
                    string SoHoanChinh = "";
                    for (int i = 0; i < n; i++)
                    {
                        if(checkPerfect(i))
                            SoHoanChinh += i + " ";
                    }
                    lblSoHoanChinh.Text = SoHoanChinh;// gan thuoc tinh text cua lblSoHoanChinh = SoHoanChinh

                    if (lblSoChinhPhuong.Text == "")
                        lblSoChinhPhuong.Text = "Không có số nào thỏa mãn";
                    if (lblSoHoanChinh.Text == "")
                        lblSoHoanChinh.Text = "Không có số nào thỏa mãn";
                    if (lblSoNguyenTo.Text == "")
                        lblSoNguyenTo.Text = "Không có số nào thỏa mãn";
                    lblSoChinhPhuong.Location = new Point(225, lblSoChinhPhuong.Location.Y + 10);
                    lblSoHoanChinh.Location = new Point(202, lblSoHoanChinh.Location.Y + 10);
                    label4.Location = new Point(5, label4.Location.Y + 10);
                    label3.Location = new Point(5, label3.Location.Y + 10);


                }
            }
            catch (FormatException)
            {
                if (txtSoNguyen.Text == "")
                    MessageBox.Show("Không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Phải là số nguyên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSoNguyen.Text = "";
                    txtSoNguyen.Focus();
                }
            }
        }
        //sự kiện KeyDown cho phép hiển thị khi bấm Enter
        private void txtSoNguyen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { 
                txtSoNguyen_Leave(sender, e);
            }
        }


    }
}
