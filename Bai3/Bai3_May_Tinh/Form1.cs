using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3_May_Tinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Color oldColor;

        public string a, b, res;
        public string c;
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Button newObject = (Button)sender;
            newObject.BackColor = oldColor;
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Button newObject = (Button)sender;
            oldColor = newObject.BackColor;
            newObject.BackColor = Color.Pink;
        }

        private void buttonKq_Click(object sender, EventArgs e)
        {
            string expression = textBox1.Text;
            textBox2.Text = EvaluateExpression(expression);
        }

        private string EvaluateExpression(string expression)
        {
            // Kiểm tra nếu biểu thức không hợp lệ (bắt đầu hoặc kết thúc bằng toán tử)
            if (Regex.IsMatch(expression, @"^[\*/\+\-]") || Regex.IsMatch(expression, @"[\*/\+\-]$"))
                return "Syntax Error";

            // Thêm dấu `+` trước số âm nếu cần
            expression = Regex.Replace(expression, @"(^|[\+\-\*/])\s*(-\d+)", "$1(0$2)");

            // Tách số và toán tử
            List<string> numbers = Regex.Split(expression, @"([\+\-\*/])").Where(x => !string.IsNullOrEmpty(x)).ToList();

            if (numbers.Count < 3) return "Syntax Error"; // Ít hơn 3 phần tử thì sai

            // Xử lý nhân / chia trước
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == "*" || numbers[i] == "/")
                {
                    double left = double.Parse(numbers[i - 1]);
                    double right = double.Parse(numbers[i + 1]);

                    if (numbers[i] == "/" && right == 0)
                        return "Error: Division by Zero";

                    double result = numbers[i] == "*" ? left * right : left / right;

                    numbers[i - 1] = result.ToString();
                    numbers.RemoveAt(i);
                    numbers.RemoveAt(i);
                    i--; // Lùi lại vì danh sách bị giảm kích thước
                }
            }

            // Xử lý cộng / trừ từ trái qua phải
            double finalResult = double.Parse(numbers[0]);
            for (int i = 1; i < numbers.Count; i += 2)
            {
                double right = double.Parse(numbers[i + 1]);
                finalResult = numbers[i] == "+" ? finalResult + right : finalResult - right;
            }

            return finalResult.ToString();
        }



        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Button button = (Button)sender;
                textBox1.Text += button.Text;

        }
    }
}
