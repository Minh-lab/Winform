using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int money = 100;

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            lblSo1.Text = rnd.Next(0, 8).ToString();
            lblSo2.Text = rnd.Next(0, 9).ToString();
            lblSo3.Text = rnd.Next(0, 10).ToString();
        }

        private void btnQuay_Click(object sender, EventArgs e)
        {
            if (money < 20)
                MessageBox.Show("Nạp Tiền Vào Bạn ei");
            else
            {
                money -= 20;
                lblTien.Text = money.ToString();
                timer1.Start();
                
            }
            btnQuay.Enabled = false;
            btnStop.Enabled = true;
            lblBonous.Text = "";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

            timer1.Stop();
            if (int.Parse(lblSo1.Text) == 7)
            {
                money += 30;
                lblBonous.Text = "+ 30";
            }
            if (int.Parse(lblSo2.Text) == 7)
            {
                money += 40;
                lblBonous.Text = "+ 40";
            }
            if (int.Parse(lblSo3.Text) == 7)
            { 
            money += 50;
            lblBonous.Text = "+ 50";
            }
            btnStop.Enabled = false;
            btnQuay.Enabled = true;


        }

        private void btnGameMoi_Click(object sender, EventArgs e)
        {
            lblSo1.Text = "0";
            lblSo2.Text = "0";
            lblSo3.Text = "0";
            money = 100;
            lblTien.Text = "100";
            btnStop.Enabled = false;
            btnQuay.Enabled= true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
