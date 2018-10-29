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
    public partial class Form1 : Form
    {
        String username;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection scon = new SqlConnection(Voting.Properties.Settings.Default.con);
            String qwery = "select * from [dbo].[Login] where username='"+textBox1.Text+"' and password='"+textBox2.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(qwery,scon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count==1)
            {
                scon.Open();
                SqlCommand scmd = new SqlCommand(qwery, scon);
                SqlDataReader sdr = scmd.ExecuteReader();
                sdr.Read();
                username = Convert.ToString(sdr.GetValue(0));
                MessageBox.Show("Login Successfull");
                if(username=="admin")
                {
                    Form3 f3 = new Form3();
                    f3.Show();
                    this.Hide();
                }
                else
                {
                    Form2 f1 = new Form2(username);
                    f1.Show();
                    this.Hide();
                }              
            }
            else
            {
                MessageBox.Show("Entered credentials are inncorrect!");
            }
            
        }
    }
}