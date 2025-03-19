using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using Newtonsoft.Json;
using System.Data.SqlTypes;

namespace QuanLiThuVien
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string chuoiketnoi = "Data Source=DESKTOP-DOFGP4J;" + "Initial Catalog=THUVIEN;" + "Integrated Security=True";
        SqlConnection conn = null;
        public int stt = 0, thanhtien = 0;
        string filepath = @"D:\Winform\QuanLiThuVien\stt.json";

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

        DataTable GetThongTinMuonSach()
        {
            DataTable dt = new DataTable();
            string query = "select stt, hoten, sach.tensach, ngaymuon, ngaytra, thanhtien from sach, muonsach where sach.masach = muonsach.idsach";
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
                //string json = System.IO.File.ReadAllText(@"D:\Winform\QuanLiThuVien\stt.json");
                //stt = JsonConvert.DeserializeObject<int>(json);

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
                    string query = "insert into muonsach values(@stt, @tensv, @ngaymuon, @ngaytra, @thanhtien, @id)";
                    using (conn = new SqlConnection(chuoiketnoi))
                    {
                        conn.Open();
                        int k = getcurrentStt(conn);
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@stt", k);
                        cmd.Parameters.AddWithValue("@tensv", cmbtensv.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@ngaymuon", dtpngaymuon.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@ngaytra", dtpngaytra.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@thanhtien", thanhtien.ToString());
                        cmd.Parameters.AddWithValue("@id", getMaSach(cmbtensach.Text));
                        cmd.ExecuteNonQuery();
                        dsmuontra.DataSource = GetThongTinMuonSach();
                 //string sttstring = stt.ToString();
                        //System.IO.File.WriteAllText(@"D:\Winform\QuanLiThuVien\stt.json", sttstring);
                    }

                }
                //string jsonstr;
                //jsonstr = JsonConvert.SerializeObject(stt);

            }
            catch (SqlException)
            {
            }
        }

        int getcurrentStt(SqlConnection conn)
        {
            try { 
            int k;
            DataTable dt = new DataTable();
            string query = "select stt from muonsach order by stt desc";

                 SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.Fill(dt);
             k = int.Parse(dt.Rows[0]["stt"].ToString());
               return k + 1;
            }
            catch(IndexOutOfRangeException){
                return 0; }
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
           using(conn = new SqlConnection(chuoiketnoi))
            {
                conn.Open();
                dsmuontra.DataSource = GetThongTinMuonSach();
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

        private void TraSach_Click(object sender, EventArgs e)
        {
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
                string query = "update muonsach set ngaytra = @ngaytra where idsach = @masach";
                    using (conn = new SqlConnection(chuoiketnoi))
                    {
                        conn.Open();
                        SqlCommand sqlCommand = new SqlCommand(query, conn);
                        sqlCommand.Parameters.AddWithValue("@ngaytra", DateTime.Now.ToString("yyyy-MM-dd"));
                        sqlCommand.Parameters.AddWithValue("@masach", getMaSach(cmbtensach.Text));
                        sqlCommand.ExecuteNonQuery();
                        lblsongaymuon.Text = (DateTime.Now - dtpngaymuon.Value).Days.ToString();
                        dtpngaytra.Value = (DateTime.Now);
                        int date = int.Parse(lblsongaymuon.Text);
                        if (date > 40)
                        {
                            int thanhtien = 2000 * (date - 40);
                            string query2 = "update muonsach set thanhtien = @thanhtien where idsach = @masach";
                            sqlCommand = new SqlCommand(query2, conn);
                            sqlCommand.Parameters.AddWithValue("@thanhtien", thanhtien.ToString());
                            sqlCommand.Parameters.AddWithValue("@masach", getMaSach(cmbtensach.Text));

                        }
                        dsmuontra.DataSource = GetThongTinMuonSach();
                    }
                }
 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dsoutdate.DataSource = GetOutdate();
        }

        DataTable GetOutdate()
        {
            DataTable dt = new DataTable();
            string query = "select hoten, ngaymuon, ngaytra, DATEDIFF(DAY, ngaymuon, GETDATE()) as Songaymuon from muonsach where DATEDIFF(DAY, ngaymuon, GETDATE()) > 40";
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
            string query = "select sach.tensach,count(idsach) as solan from muonsach,sach where muonsach.idsach = sach.masach group by muonsach.idsach, tensach;";
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
            dsmuontra.DataSource = GetThongTinMuonSach();
            lblsongaymuon.Text = "";
            stt = 0;
            string json = stt.ToString();
            System.IO.File.WriteAllText(filepath, json);
        }

        private void buttonresetsach_Click(object sender, EventArgs e)
        {
            string query = "delete from muonsach";
            string query2 = "delete from sach";
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            sqlCommand.ExecuteNonQuery();
            sqlCommand = new SqlCommand(query2, conn);
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

        string getMaSach(string tensach)
        {
            string query = "SELECT masach FROM sach WHERE tensach = @tensach";

            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tensach", tensach);
                    object result = cmd.ExecuteScalar();
                    return result.ToString(); // Trả về null nếu không có dữ liệu
                }
            }
        }

        string getTenSach(string masach)
        {
            string query = "select tensach from sach where masach = @masach";
            using (conn = new SqlConnection(chuoiketnoi))
            {
                conn.Open();
                using (SqlCommand sql = new SqlCommand(query, conn))
                {
                    sql.Parameters.AddWithValue("@masach", masach);
                    object result = sql.ExecuteScalar();
                    return result.ToString();
                }
            }
        }

    }
}
