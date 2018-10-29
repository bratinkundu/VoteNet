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
    public partial class Form2 : Form
    {
        String boyvote, girlvote,username,qwery1,query;

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public Form2(String username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            boyvote = radiotext();
            girlvote = radiotext1();
            if(boyvote=="" || girlvote=="" || textBox1.Text=="")
            {
                MessageBox.Show("All credentials must be filled!");
            }
            else if(comboBox1.Text=="")
            {
                MessageBox.Show("Please select the class!");
            }
            else
            {
                SqlConnection scon = new SqlConnection(Voting.Properties.Settings.Default.con);
                scon.Open();
                if(username=="test")
                {
                     qwery1 = "select * from [dbo].[Sample] where roll_no=" + Convert.ToInt32(textBox1.Text);
                     query = "insert into [dbo].[Sample] values (" + Convert.ToInt32(textBox1.Text) + ",'" + boyvote + "','" + girlvote + "')";
                }
                else
                {
                    qwery1 = "select * from [dbo].[" + comboBox1.Text + "] where roll_no=" + Convert.ToInt32(textBox1.Text) ;
                    query = "insert into  [dbo].[" + comboBox1.Text + "] values (" + Convert.ToInt32(textBox1.Text) + ",'" + boyvote + "','" + girlvote + "')";
                }
                SqlDataAdapter sda = new SqlDataAdapter(qwery1, scon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("You cannot vote again");
                    textBox1.Text = "";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;
                    comboBox1.SelectedIndex = -1;
                }
                else
                {
                    if (comboBox1.SelectedIndex > 13)
                    {
                        String query1 = "update Headboy set votes=Headboy.votes+1 where candidate='"+boyvote+"'";
                        String query2 = "update Headgirl set votes=Headgirl.votes+1 where candidate='" +girlvote + "'";
                        SqlCommand scmd1 = new SqlCommand(query1,scon);
                        SqlCommand scmd2 = new SqlCommand(query2, scon);
                        scmd1.ExecuteNonQuery();
                        scmd2.ExecuteNonQuery();
                    }
                    SqlCommand scmd = new SqlCommand(query, scon);
                    if (scmd.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("Vote registered!");
                        textBox1.Text = "";
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        radioButton5.Checked = false;
                        radioButton6.Checked = false;
                        comboBox1.SelectedIndex=-1;
                    }
                    else
                    {
                        MessageBox.Show("Cannot take your vote!");
                    }
                }
            }
        }
        public string radiotext()
        {
            if(radioButton1.Checked)
            {
                return radioButton1.Text;
            }
            else if(radioButton2.Checked)
            {
                return radioButton2.Text;
            }
            else if(radioButton3.Checked)
            {
                return radioButton3.Text;
            }
            else
            {
                return "";
            } 
        }
        public string radiotext1()
        {
            if (radioButton4.Checked)
            {
                return radioButton4.Text;
            }
            else if (radioButton5.Checked)
            {
                return radioButton5.Text;
            }
            else if (radioButton6.Checked)
            {
                return radioButton6.Text;
            }
            else
            {
                return "";
            }
        }
    }
}
