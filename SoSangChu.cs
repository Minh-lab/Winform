using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                errorProvider1.SetError(txtInput, "Vui lòng nhập số");
                return;
            }

            Dictionary<char, string> map = new Dictionary<char, string>()
            {
                { '0', "Không" }, { '1', "Một" }, { '2', "Hai" }, { '3', "Ba" },
                { '4', "Bốn" }, { '5', "Năm" }, { '6', "Sáu" }, { '7', "Bảy" },
                { '8', "Tám" }, { '9', "Chín" }
            };

            int length = txtInput.Text.Length;
            string[] res = new string[length];

            int index = length - 1;
            res[0] = map[txtInput.Text[index]];  // Đọc chữ số cuối cùng
            index--;

            for (int i = 1; i < length; i++)
            {
                if (index < 0) break; // Tránh lỗi index âm
                char digit = txtInput.Text[index];

                switch (i)
                {
                    case 1: // Hàng chục
                        if (digit == '1')
                            res[i] = "Mười " + res[i - 1];
                        else if (digit == '0')
                            res[i] = "Lẻ " + res[i - 1];
                        else
                            res[i] = map[digit] + " Mươi " + res[i - 1];
                        break;

                    case 2: // Hàng trăm
                        if (digit != '0')
                            res[i] = map[digit] + " Trăm " + res[i - 1];
                        else
                            res[i] = "Không Trăm " + res[i - 1];
                        break;

                    case 3: // Hàng nghìn
                        res[i] = map[digit] + " Nghìn " + res[i - 1];
                        break;

                    case 4: // Hàng chục nghìn
                        if (digit == '1')
                            res[i] = "Mười " + res[i - 1];
                        else if (digit == '0')
                            res[i] = "Lẻ " + res[i - 1];
                        else
                            res[i] = map[digit] + " Mươi " + res[i - 1];
                        break;

                    case 5: // Hàng trăm nghìn
                        res[i] = map[digit] + " Trăm " + res[i - 1];
                        break;

                    case 6: // Hàng triệu
                        res[i] = map[digit] + " Triệu " + res[i - 1];
                        break;

                    case 7: // Hàng chục triệu
                        if (digit == '1')
                            res[i] = "Mười " + res[i - 1];
                        else if (digit == '0')
                            res[i] = "Lẻ " + res[i - 1];
                        else
                            res[i] = map[digit] + " Mươi " + res[i - 1];
                        break;

                    case 8: // Hàng trăm triệu
                        res[i] = map[digit] + " Trăm " + res[i - 1];
                        break;

                    default:
                        res[i] = res[i - 1];
                        break;
                }

                index--;
            }

            lblOutput.Text = res[length - 1];
        }
    }
}
