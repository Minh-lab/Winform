using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QuanLiThuVien
{
    public partial class Form1 : Form
    {
        public int stt = 0, thanhtien = 0;
        public Form1()
        {
            InitializeComponent();
        }
        string chuoiketnoi = "Data Source=DESKTOP-DOFGP4J;" + "Initial Catalog=THUVIEN;" + "Integrated Security=True";
        SqlConnection conn = null;
        private void btnthemsach_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = true;
                errorProvider1.Clear();
                if (txtmasach.Text == "")
                {
                    errorProvider1.SetError(txtmasach, "Không được để trống!");
                    check = false;
                }
                if (txttensach.Text == "")
                {
                    errorProvider1.SetError(txttensach, "Không được để trống!");
                    check = false;
                }
                if (check)
                {
                    string query = "insert into sach values(@masach, @tensach)";
                    using (conn = new SqlConnection(chuoiketnoi))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@masach", txtmasach.Text);
                        cmd.Parameters.AddWithValue("@tensach", txttensach.Text);
                        cmd.ExecuteNonQuery();
                        dssach.DataSource = GetAllSach();
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Mã sách đã có trong danh sách!", "Error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            dssach.DataSource = GetAllSach();
        }

        DataTable GetAllSach()
        {
            DataTable dt = new DataTable();
            string query = "select * from sach";
            using (conn = new SqlConnection(chuoiketnoi))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);

            }
            return dt;
        }
        DataTable GetMuonTraSach()
        {
            DataTable dt = new DataTable();
            string query = "select * from muonsach";
            using (conn = new SqlConnection(chuoiketnoi))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);

            }
            return dt;
        }
        List<string> getName()
        {
            List<string> name = new List<string>();
            string query = "select tensach from sach";
            DataTable dt = new DataTable();
            using (conn = new SqlConnection(chuoiketnoi))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            name.Add(reader["tensach"].ToString());
                        }
                    }
                }
            }
            return name;
        }

        private void btnmuonsach_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = true;
                errorProvider1.Clear();
                if (cmbtensv.Text == "")
                {
                    errorProvider1.SetError(cmbtensv, "Không được để trống!");
                    check = false;
                }
                if (cmbtensach.Text == "")
                {
                    errorProvider1.SetError(cmbtensach, "Không được để trống!");
                    check = false;
                }
                if (check)
                {
                    string query = "insert into muonsach values(@stt, @tensv, @tensach, @ngaymuon, @ngaytra, @thanhtien)";
                    using (conn = new SqlConnection(chuoiketnoi))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@stt", stt);
                        cmd.Parameters.AddWithValue("@tensv", cmbtensv.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@tensach", cmbtensach.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@ngaymuon", dtpngaymuon.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@ngaytra", dtpngaytra.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@thanhtien", thanhtien.ToString());

                        cmd.ExecuteNonQuery();
                        stt += 1;
                        dsmuontra.DataSource = GetMuonTraSach();
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Error", "Mã sách đã có trong danh sách");
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
           using(conn = new SqlConnection(chuoiketnoi))
            {
                conn.Open();
                dsmuontra.DataSource = GetMuonTraSach();
                if(stt == 0)
                {
                    dtpngaytra.Value = dtpngaymuon.Value.AddDays(40);
                }
            }
            List<string> bookName = getName();
            cmbtensach.DataSource = bookName;
        }

        private void dssach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) { 
                txtmasach.Text = dssach.Rows[e.RowIndex].Cells["masach"].Value.ToString();
                txttensach.Text = dssach.Rows[e.RowIndex].Cells["tensach"].Value.ToString();
                lblsongaymuon.Text = (dtpngaytra.Value.DayOfYear - dtpngaymuon.Value.DayOfYear).ToString();
            }
        }

        private void dsmuontra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                cmbtensv.Text = dsmuontra.Rows[e.RowIndex].Cells["name"].Value.ToString();
                cmbtensach.Text = dsmuontra.Rows[e.RowIndex].Cells["namebook"].Value.ToString();
                dtpngaymuon.Value = DateTime.Parse(dsmuontra.Rows[e.RowIndex].Cells["datemuon"].Value.ToString());
                dtpngaytra.Value = DateTime.Parse(dsmuontra.Rows[e.RowIndex].Cells["datetra"].Value.ToString());
                lblsongaymuon.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try { 
            errorProvider1.Clear();
            bool check = true;
            if (cmbtensv.Text == "")
            {
                errorProvider1.SetError(cmbtensv, "Không được để trống!");
                check = false;
            }
            if (cmbtensach.Text == "")
            {
                errorProvider1.SetError(cmbtensach, "Không được để trống!");
                check = false;
            }
            if (check)
            {
                string query = "update muonsach set ngaytra = @ngaytra where tensach = @tensach and tensv = @tensv";
                    using (conn = new SqlConnection(chuoiketnoi))
                    {
                        conn.Open();
                        SqlCommand sqlCommand = new SqlCommand(query, conn);
                        sqlCommand.Parameters.AddWithValue("@ngaytra", DateTime.Now.ToString("yyyy-MM-dd"));
                        sqlCommand.Parameters.AddWithValue("@tensach", cmbtensach.Text);
                        sqlCommand.Parameters.AddWithValue("@tensv", cmbtensv.Text);
                        sqlCommand.ExecuteNonQuery();
                        lblsongaymuon.Text = (DateTime.Now - dtpngaymuon.Value).Days.ToString();
                        dtpngaytra.Value = (DateTime.Now);
                        int date = int.Parse(lblsongaymuon.Text);
                        if (date > 40)
                        {
                            int thanhtien = 2000 * (date - 40);
                            string query2 = "update muonsach set thanhtien = @thanhtien where tensach = @tensach and tensv = @tensv";
                            sqlCommand = new SqlCommand(query2, conn);
                            sqlCommand.Parameters.AddWithValue("@thanhtien", thanhtien.ToString());
                            sqlCommand.Parameters.AddWithValue("@tensach", cmbtensach.Text);
                            sqlCommand.Parameters.AddWithValue("@tensv", cmbtensv.Text);
                            sqlCommand.ExecuteNonQuery();

                        }
                        dsmuontra.DataSource = GetMuonTraSach();
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Error", "Đã có trong ds");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dsoutdate.DataSource = GetOutdate();
        }

        DataTable GetOutdate()
        {
            DataTable dt = new DataTable();
            string query = "select tensv, ngaymuon, ngaytra, DATEDIFF(DAY, ngaymuon, GETDATE()) as Songaymuon from muonsach where DATEDIFF(DAY, ngaymuon, GETDATE()) > 40";
            using (conn = new SqlConnection(chuoiketnoi))
            {
                conn.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);
                sqlDataAdapter.Fill(dt);
            }
            return dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dscount.DataSource = GetCountBook();
        }

        DataTable GetCountBook()
        {
            DataTable dt = new DataTable();
            string query = "select tensach,count(tensach) as solanmuon from muonsach group by tensach order by solanmuon desc";
            using (conn = new SqlConnection(chuoiketnoi))
            {
                conn.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);
                sqlDataAdapter.Fill(dt);
            }
            return dt;
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            string query = "delete from muonsach";
            using(conn = new SqlConnection(chuoiketnoi))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            dsmuontra.DataSource = GetMuonTraSach();
            lblsongaymuon.Text = "";
            stt = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "delete from sach";
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            sqlCommand.ExecuteNonQuery();
            dssach.DataSource = GetAllSach();
            txtmasach.Text = "";
            txttensach.Text = "";

        }

        private void txtmasach_TextChanged(object sender, EventArgs e)
        {
            TextBox temp = (TextBox)sender;
            if(temp.Text == "")
                errorProvider1.SetError(temp, "Không được để trống");
            else
                errorProvider1.SetError(temp, "");
        }

        private void dtpngaymuon_ValueChanged(object sender, EventArgs e)
        {

            dtpngaytra.Value = dtpngaymuon.Value.AddDays(40);
        }
    }
}
