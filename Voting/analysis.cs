using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace Voting
{
    public partial class analysis : Form
    {
        String candidate,qwery1;
        double total, vote;
        int no, no1, no2, no3, no4, no5, no6;
        public analysis()
        {
            InitializeComponent();
        }

        private void analysis_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 fs = new Form3();
            fs.Show();
            this.Hide();
        }

        void countcan()
        {
            SqlConnection scon = new SqlConnection(Voting.Properties.Settings.Default.con);
            scon.Open();
            String qwery = "select count(*) from [dbo].[" + comboBox3.Text + "]";
            if(candidate=="headboy")
            {
                qwery1 = "select count(*) from [dbo].[" + comboBox3.Text + "] where headboy='" + comboBox2.Text + "'";
            }
            else
            {
                qwery1 = "select count(*) from [dbo].[" + comboBox3.Text + "] where headgirl='" + comboBox2.Text + "'";
            }
            SqlCommand scmd1 = new SqlCommand(qwery, scon);
             total = Convert.ToInt32(scmd1.ExecuteScalar());
            SqlCommand scmd = new SqlCommand(qwery1, scon);
             vote = Convert.ToInt32(scmd.ExecuteScalar());
            votecalc();
        }

        void countc()
        {
            SqlConnection scon = new SqlConnection(Voting.Properties.Settings.Default.con);
            scon.Open();
            String qwery = "select count(*) from [dbo].[" + comboBox2.Text + "]";
            String qwery1 = "select count(*) from [dbo].[" + comboBox2.Text + "] where headboy='Mihir'";
            String qwery2 = "select count(*) from [dbo].[" + comboBox2.Text + "] where headboy='Sukhveer'";
            String qwery3 = "select count(*) from [dbo].[" + comboBox2.Text + "] where headboy='Yash'";
            String qwery4 = "select count(*) from [dbo].[" + comboBox2.Text + "] where headgirl='Helly'";
            String qwery5 = "select count(*) from [dbo].[" + comboBox2.Text + "] where headgirl='Hetal'";
            String qwery6 = "select count(*) from [dbo].[" + comboBox2.Text + "] where headgirl='Navisha'";
            SqlCommand scmd = new SqlCommand(qwery, scon);
            SqlCommand scmd1 = new SqlCommand(qwery1, scon);
            SqlCommand scmd2 = new SqlCommand(qwery2, scon);
            SqlCommand scmd3 = new SqlCommand(qwery3, scon);
            SqlCommand scmd4 = new SqlCommand(qwery4, scon);
            SqlCommand scmd5 = new SqlCommand(qwery5, scon);
            SqlCommand scmd6 = new SqlCommand(qwery6, scon);
            no = Convert.ToInt32(scmd.ExecuteScalar());
            no1 = Convert.ToInt32(scmd1.ExecuteScalar());
            no2 = Convert.ToInt32(scmd2.ExecuteScalar());
            no3 = Convert.ToInt32(scmd3.ExecuteScalar());
            no4 = Convert.ToInt32(scmd4.ExecuteScalar());
            no5 = Convert.ToInt32(scmd5.ExecuteScalar());
            no6 = Convert.ToInt32(scmd6.ExecuteScalar());
            scon.Close();
        }

        void votecalc()
        {
            try
            {
                double voteper;
                voteper = (vote * 100 / total);
                groupBox1.Visible = true;
                label8.Text = Convert.ToString(total);
                label9.Text = Convert.ToString(vote);
                label10.Text = Convert.ToString(Math.Round(voteper,2)) + "%";
            }
            catch(Exception e)
            {
                MessageBox.Show("No votes casted for that class");
            }
        }
      

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Candidate")
            {
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                label3.Visible = true;
                comboBox2.Visible = true;
                comboBox2.Text = "";
                label3.Text = "Select Candidate";
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Mihir");
                comboBox2.Items.Add("Sukhveer");
                comboBox2.Items.Add("Yash");
                comboBox2.Items.Add("Helly");
                comboBox2.Items.Add("Hetal");
                comboBox2.Items.Add("Navisha");
                
            }
            else if(comboBox1.Text=="Class")
            {
                groupBox1.Visible = false;
                comboBox2.Items.Clear();
                comboBox3.Visible = false;
                comboBox2.Visible = true;
                comboBox2.Text = "";
                label3.Visible = true;
                label3.Text = "Select Class";
                label4.Visible = false;     
                comboBox2.Items.Add("1stA");
                comboBox2.Items.Add("1stB");
                comboBox2.Items.Add("1stC");
                comboBox2.Items.Add("1stD");               
                comboBox2.Items.Add("2ndA");
                comboBox2.Items.Add("2ndB");
                comboBox2.Items.Add("2ndC");
                comboBox2.Items.Add("2ndD");
                comboBox2.Items.Add("3rdA");
                comboBox2.Items.Add("3rdB");
                comboBox2.Items.Add("3rdC");
                comboBox2.Items.Add("4thA");
                comboBox2.Items.Add("4thB");
                comboBox2.Items.Add("4thC");
                comboBox2.Items.Add("5thA");
                comboBox2.Items.Add("5thB");
                comboBox2.Items.Add("5thC");
                comboBox2.Items.Add("6thA");
                comboBox2.Items.Add("6thB");
                comboBox2.Items.Add("7thA");
                comboBox2.Items.Add("7thB");
                comboBox2.Items.Add("8thA");
                comboBox2.Items.Add("8thB");
                comboBox2.Items.Add("8thC");
                comboBox2.Items.Add("9thA");
                comboBox2.Items.Add("9thB");
                comboBox2.Items.Add("10thA");
                comboBox2.Items.Add("10thB");
                comboBox2.Items.Add("11thSci");
                comboBox2.Items.Add("11thCom");
                comboBox2.Items.Add("12thSci");
                comboBox2.Items.Add("12thCom");
                
            }
            else
            {
                MessageBox.Show("No Selection");
            }
        }
        void candidatevote()
        {
            try
            {
                double vote1, vote2, vote3, vote4, vote5, vote6;
                vote1 =(double) (no1 * 100) / no;
                vote2 = (double)(no2 * 100) / no;
                vote3 = (double)(no3 * 100) / no;
                vote4 = (double)(no4 * 100) / no;
                vote5 = (double)(no5 * 100) / no;
                vote6 = (double)(no6 * 100) / no;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                label62.Visible = true;
                label11.Visible = true;
                label24.Text = Convert.ToString(no1);
                label25.Text = Convert.ToString(no2);
                label26.Text = Convert.ToString(no3);
                label27.Text = Convert.ToString(no4);
                label28.Text = Convert.ToString(no5);
                label29.Text = Convert.ToString(no6);
                label30.Text = Convert.ToString(Math.Round(vote1,2))+"%";
                label31.Text = Convert.ToString(Math.Round(vote2,2))+"%";
                label32.Text = Convert.ToString(Math.Round(vote3,2))+"%";
                label33.Text = Convert.ToString(Math.Round(vote4,2))+"%";
                label34.Text = Convert.ToString(Math.Round(vote5,2))+"%";
                label35.Text = Convert.ToString(Math.Round(vote6,2))+"%";
                label36.Text = label58.Text= Convert.ToString(no);
            }
            catch (Exception e)
            {
                MessageBox.Show("No votes casted for that class");
            }
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.Text=="Mihir"||comboBox2.Text=="Sukhveer"||comboBox2.Text=="Yash")
            {
                candidate = "headboy";
            }
            else
            {
                candidate = "headgirl";
            }
            if(comboBox1.Text=="Candidate")
            {
                comboBox3.Visible = true;
                comboBox3.Text = "";
                groupBox2.Visible = false;
                label4.Visible = true;
                label4.Text = "Select Class";
            }
            else
            {
                groupBox1.Visible = false;
                countc();
                candidatevote();
            }
            
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            countcan();
        }
    }
}
