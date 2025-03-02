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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QLSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string chuoiketnoi = "Data Source=DESKTOP-DOFGP4J; " +
                             " Initial Catalog=SVB7; " +
                             " Integrated Security=True";
        SqlConnection conn = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            dssv.DataSource = GetDataTable();

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool check = true;
            if (txthoten.Text == "")
            {
                errorProvider1.SetError(txthoten, "Không được để trống!");
                check = false;

            }
            if (txtmsv.Text == "")
            {
                errorProvider1.SetError(txtmsv, "Không được để trống!");
                check = false;
            }
            if (rdnam.Checked == false && rdnu.Checked == false)
            {
                errorProvider1.SetError(rdnam, "Không được để trống!");
                errorProvider1.SetError(rdnu, "Không được để trống!");
                check = false;
            }
            if (cmbquequan.Text == "")
            {
                errorProvider1.SetError(cmbquequan, "Không được để trống!");
                check = false;
            }
            if (cmbkhoa.Text == "")
            {
                errorProvider1.SetError(cmbkhoa, "Không được để trống!");
                check = false;
            }
            if (cmblop.Text == "")
            {
                errorProvider1.SetError(cmblop, "Không được để trống!");
                check = false;
            }


            if (check)
            {
                try
                {
                    string query = "INSERT INTO SINHVIEN VALUES (@msv, @hoten, @ngaysinh, @gioitinh, @quequan, @lop, @khoa)";
                    using (conn = new SqlConnection(chuoiketnoi))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@msv", txtmsv.Text);
                        cmd.Parameters.AddWithValue("@hoten", txthoten.Text);
                        cmd.Parameters.AddWithValue("@ngaysinh", DateTime.Parse(dtpngaysinh.Text));
                        if (rdnam.Checked)
                            cmd.Parameters.AddWithValue("@gioitinh", rdnam.Text);
                        else if (rdnu.Checked)
                            cmd.Parameters.AddWithValue("@gioitinh", rdnu.Text);
                        cmd.Parameters.AddWithValue("@quequan", cmbquequan.Text);
                        cmd.Parameters.AddWithValue("@lop", cmblop.Text);
                        cmd.Parameters.AddWithValue("@khoa", cmbkhoa.Text);
                        cmd.ExecuteNonQuery();
                        dssv.DataSource = GetDataTable();
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Đã có trong danh sách", "Lỗi");
                }
            }
        }


        public DataTable GetDataTable()
        {
            DataTable dt = new DataTable();
            string query = "select * from SINHVIEN";
            using (conn = new SqlConnection(chuoiketnoi))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string query = "delete  from SINHVIEN where msv = @msv";
            using (conn = new SqlConnection(chuoiketnoi))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@msv", txtmsv.Text);
                cmd.ExecuteNonQuery();
                dssv.DataSource = GetDataTable();
                foreach (Control ctr in GetControls(tableLayoutPanel1))
                {
                    if ((ctr is TextBox) || (ctr is ComboBox) || (ctr is DateTimePicker))
                    {
                        ctr.Text = "";

                    }
                    else if (ctr is RadioButton)
                    {
                        RadioButton temp = (RadioButton)ctr;
                        temp.Checked = false;
                    }
                    else if (ctr is DateTimePicker)
                    {
                        DateTimePicker temp = (DateTimePicker)ctr;
                        temp.Value = DateTime.Now;
                    }
                }

            }
        }

        //ham lay control o panel 1
        IEnumerable<Control> GetControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                yield return control;
                if (control.HasChildren)
                {
                    foreach (Control child in GetControls(control))
                    {
                        yield return child;
                    }
                }
            }
        }

        private void dssv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtmsv.Text = dssv.Rows[e.RowIndex].Cells["msv"].Value.ToString();
                txthoten.Text = dssv.Rows[e.RowIndex].Cells["hoten"].Value.ToString();
                dtpngaysinh.Value = DateTime.Parse(dssv.Rows[e.RowIndex].Cells["ngaysinh"].Value.ToString());
                cmbquequan.Text = dssv.Rows[e.RowIndex].Cells["quequan"].Value.ToString();
                var gioitinh = dssv.Rows[e.RowIndex].Cells["gioitinh"].Value;
                if (gioitinh != null)
                {
                    string gt = gioitinh.ToString().Trim();
                    if (gt == "Nam")
                        rdnam.Checked = true;
                    else if (gt == "Nữ")
                        rdnu.Checked = true;
                }
                cmblop.Text = dssv.Rows[e.RowIndex].Cells["lop"].Value.ToString();
                cmbkhoa.Text = dssv.Rows[e.RowIndex].Cells["khoa"].Value.ToString();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "update SINHVIEN set hoten = @hoten, ngaysinh = @ngaysinh, quequan = @quequan, gioitinh = @gioitinh, khoa = @khoa, lop = @lop where msv = @msv";
                using (conn = new SqlConnection(chuoiketnoi))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@msv", txtmsv.Text);
                    cmd.Parameters.AddWithValue("@hoten", txthoten.Text);
                    cmd.Parameters.AddWithValue("@ngaysinh", DateTime.Parse(dtpngaysinh.Text));
                    if (rdnam.Checked)
                        cmd.Parameters.AddWithValue("@gioitinh", rdnam.Text);
                    else if (rdnu.Checked)
                        cmd.Parameters.AddWithValue("@gioitinh", rdnu.Text);
                    cmd.Parameters.AddWithValue("@quequan", cmbquequan.Text);
                    cmd.Parameters.AddWithValue("@lop", cmblop.Text);
                    cmd.Parameters.AddWithValue("@khoa", cmbkhoa.Text);
                    cmd.ExecuteNonQuery();
                    dssv.DataSource = GetDataTable();
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Danh sách trống", "Error");
            }
        }

        private void txtmsv_TextChanged(object sender, EventArgs e)
        {
            //if (txtmsv.Text == "")
            //    errorProvider1.SetError(txtmsv, "Không được để trống");
            //else errorProvider1.SetError(txtmsv, "");
            TextBox temp = (TextBox)sender;
            if(temp.Text == "")
                errorProvider1.SetError(temp, "Không được để trống");
            else
            {
                errorProvider1.SetError(temp, "");
            }

        }

        private void cmbquequan_TextChanged(object sender, EventArgs e)
        {
            ComboBox a = (ComboBox)sender;
            if (a.Text == "")
                errorProvider1.SetError(a, "Không được để trống");
            else
            {
                errorProvider1.SetError(a, "");
            }
        }

        private void rdnam_CheckedChanged(object sender, EventArgs e)
        {
            if (!(rdnam.Checked == false && rdnu.Checked == false))
            {
                if (rdnam.Checked == true) {
                    
                    errorProvider1.SetError(rdnu, "");
                    errorProvider1.SetError(rdnam, "");
                }
                else
                {
                    errorProvider1.SetError(rdnu, "");
                    errorProvider1.SetError(rdnam, "");
                }
            }
        }
    }
}

