using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiRapChieuPhim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string chuoiketnoi = "Data Source = DESKTOP-DOFGP4J;" + "Initial Catalog = quanlixemphim;" + "Integrated Security = true;";
        public SqlConnection conn = null;
        public int thanhtien = 0;
        public Dictionary<Button, Color> buttonColors = new Dictionary<Button, Color>();
        public List<Button> dsghe = new List<Button>();
        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Green)
            {
                buttonColors.Add(btn, btn.BackColor);
                btn.BackColor = Color.Green;
                if (btn.Text[0] == 'A')
                {
                    thanhtien += 25000;
                    lblthanhtien.Text  = thanhtien.ToString();
                }
                if (btn.Text[0] == 'B')
                {
                    thanhtien += 30000;
                    lblthanhtien.Text = thanhtien.ToString();
                }
                if (btn.Text[0] == 'C')
                {
                    thanhtien += 35000;
                    lblthanhtien.Text = thanhtien.ToString();
                }
                if (btn.Text[0] == 'D')
                {
                    thanhtien += 40000;
                    lblthanhtien.Text = thanhtien.ToString();
                }
                if (btn.Text[0] == 'E')
                {
                    thanhtien += 50000;
                    lblthanhtien.Text = thanhtien.ToString();
                }
                if (btn.Text[0] == 'F')
                {
                    thanhtien += 45000;
                    lblthanhtien.Text = thanhtien.ToString();
                }
                dsghe.Add(btn);
            }
            else
            {
                btn.BackColor = buttonColors[btn];
                buttonColors.Remove(btn);
            }

        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thánh toán ?", "Xác nhận thanh toán!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (var btn in buttonColors.Keys) 
                {
                    Console.WriteLine(btn);
                    btn.BackColor = Color.Red;
                    btn.Enabled = false;
                }
                InsertTable();
            }
            else
            {
                thanhtien = 0;
                lblthanhtien.Text = "";
                foreach (var btn in dsghe) {
                    btn.BackColor = buttonColors[btn];
                }
                dsghe.Clear();
                buttonColors.Clear();
            }
        }
        
        private void InsertTable()
        {
            string query = "insert into phim values(@tenphim, @sogheban, @soghetrong, @thoigian)";
            using(conn = new SqlConnection(chuoiketnoi))
            {
                conn.Open();
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tenphim", cmbtenphim.Text);
                    cmd.Parameters.AddWithValue("@sogheban", dsghe.Count);
                    cmd.Parameters.AddWithValue("@soghetrong", (36 - dsghe.Count));
                    cmd.Parameters.AddWithValue("@thoigian", DateTime.Now.Subtract(TimeSpan.FromDays(10)));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void cmbtenphim_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbltenphim.Text = cmbtenphim.Text;
        }
    }
}
