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

namespace Voting
{
    public partial class result : Form
    {
        double no1, no2, no3,no4,no5,no6;
        public result()
        {
            InitializeComponent();
        }

        private void result_Load(object sender, EventArgs e)
        {
            SqlConnection scon = new SqlConnection(Voting.Properties.Settings.Default.con);
            scon.Open();
            String qwery = "select * from Headboy";
            String q = "select * from Headgirl";
            SqlDataAdapter sda = new SqlDataAdapter(qwery, scon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            SqlDataAdapter sda1 = new SqlDataAdapter(q, scon);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            dataGridView2.DataSource = dt1;
            no1 = Convert.ToInt32(dt.Rows[0][1]);
            no2 = Convert.ToInt32(dt.Rows[1][1]);
            no3 = Convert.ToInt32(dt.Rows[2][1]);
            String q1 = "select sum(votes) from Headboy";
            SqlCommand scmd = new SqlCommand(q1, scon);
            int total = Convert.ToInt32(scmd.ExecuteScalar());
            label4.Text = Convert.ToString(total);
            dt.Rows[0][2] = Convert.ToString(Math.Round((no1 * 100)/total,2))+"%";
            dt.Rows[1][2] = Convert.ToString(Math.Round((no2 * 100) / total,2))+"%";
            dt.Rows[2][2] = Convert.ToString(Math.Round((no3 * 100) / total,2))+"%";
            String q2 = "select sum(votes) from Headgirl";
            SqlCommand scmd1 = new SqlCommand(q2, scon);
            int total1 = Convert.ToInt32(scmd1.ExecuteScalar());
            no4 = Convert.ToInt32(dt1.Rows[0][1]);
            no5 = Convert.ToInt32(dt1.Rows[1][1]);
            no6 = Convert.ToInt32(dt1.Rows[2][1]);
            dt1.Rows[0][2] = Convert.ToString(Math.Round((no4 * 100) / total1,2)) + "%";
            dt1.Rows[1][2] = Convert.ToString(Math.Round((no5 * 100) / total1,2))+"%";
            dt1.Rows[2][2] = Convert.ToString(Math.Round((no6 * 100) / total1,2))+"%";
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 fs = new Form3();
            fs.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
    }
}
