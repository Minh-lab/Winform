
//autosizecolumn mode = fill
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

namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string chuoiketnoi = "Data Source=DESKTOP-DOFGP4J;" + "Initial Catalog=SINHVIEN;" + "Integrated Security=True";


        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            string insert = "insert into ThongTin values ('" + txtMSV.Text + "', '" + txtHoTen.Text + "','" + txtLop.Text + "')";
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.ExecuteNonQuery();

            
            DSSV.DataSource = GetSinhVien();
            

        }

        DataTable GetSinhVien()
        {

            DataTable dataTable = new DataTable();
            string query = "select * from ThongTin";
            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                conn.Open();
                SqlDataAdapter temp = new SqlDataAdapter(query,conn);
                temp.Fill(dataTable);
                conn.Close();
            }
            return dataTable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            DSSV.DataSource = GetSinhVien();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "delete from ThongTin where id = @msv";
            using (SqlConnection conn = new SqlConnection(chuoiketnoi)) { 
                conn.Open();    
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@msv", txtMSV.Text);
                cmd.ExecuteNonQuery();
            }
            DSSV.DataSource = GetSinhVien();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "select * from ThongTin where id = @id";
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@id", txtMSV.Text);
                SqlDataAdapter temp = new SqlDataAdapter(command);
                temp.Fill(dataTable);
            }
            DSSV.DataSource = dataTable;
        }
    }
}
