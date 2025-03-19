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
using Newtonsoft.Json;

namespace QuanLyBanHang
{
    public partial class Form1 : Form
    {
        public string chuoiketnoi = "Data Source = DESKTOP-DOFGP4J;" + " Initial Catalog = quanlibanhang;" + "Integrated Security = true;";
        Dictionary<string, int> item = new Dictionary<string, int>
        {
            {"Kem", 2000 },
            {"Táo", 5000 },
            {"Lê", 6000 },

        };



        public Form1()
        {
            InitializeComponent();
        }

        private void btntaodonhang_Click(object sender, EventArgs e)
        {
            string query = "delete from donhang";
            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            txttongtien.Text = "";
            txtdongia.Text = "";
            txtsoluong.Text = "";
            txttenkhach.Text = "";
            cmbtenhang.Text = "";
           
            danhsach.DataSource = getDanhSach();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            danhsach.DataSource = getDanhSach();
            cmbtenhang.DataSource = new BindingSource(item.Keys, null);
        }
        DataTable getDanhSach()
        {
            DataTable dt = new DataTable();
            string query = "SELECT ROW_NUMBER() OVER (ORDER BY tenhang) AS stt, tenhang, soluong, dongia, thanhtien FROM donhang";
            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                conn.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {

            string query = "insert into donhang values(@tenhang, @soluong, @dongia, @thanhtien)";
            int thanhtien = int.Parse(txtdongia.Text) * int.Parse(txtsoluong.Text);
            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@tenhang", cmbtenhang.Text);
                command.Parameters.AddWithValue("@soluong", txtsoluong.Text);
                command.Parameters.AddWithValue("@dongia", txtdongia.Text);
                command.Parameters.AddWithValue("@thanhtien", thanhtien.ToString());
                command.ExecuteNonQuery();

            }
            danhsach.DataSource = getDanhSach();
        }

        private void cmbtenhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtdongia.Text = item[cmbtenhang.Text].ToString();
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            string query = "select sum(thanhtien) as tongtien from donhang";
            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                object res = cmd.ExecuteScalar();
                txttongtien.Text = res.ToString();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string query = "delete from donhang where tenhang = @tenhang";
            using (SqlConnection conn = new SqlConnection(chuoiketnoi) )
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn)) 
                {
                    cmd.Parameters.AddWithValue("@tenhang", cmbtenhang.Text);
                    cmd.ExecuteNonQuery();  
                }
            }
            danhsach.DataSource= getDanhSach();
        }

        private void danhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                cmbtenhang.Text = danhsach.Rows[e.RowIndex].Cells["tenhang"].Value.ToString();
                txtdongia.Text = danhsach.Rows[e.RowIndex].Cells["dongia"].Value.ToString();
                txtsoluong.Text = danhsach.Rows[e.RowIndex].Cells["soluong"].Value.ToString();
            }
        }

        private void đổiMàuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control cureenrControl = contextMenuStrip1.SourceControl;
            if (colorDialog1.ShowDialog() == DialogResult.OK) 
            {
                cureenrControl.BackColor = colorDialog1.Color;
            }
        }
    }
}

