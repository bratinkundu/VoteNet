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
    public partial class database : Form
    {
        public database()
        {
            InitializeComponent();
        }

        private void database_Load(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection scon = new SqlConnection(Voting.Properties.Settings.Default.con);
            scon.Open();
            String qwery = "select * from [dbo].["+comboBox1.Text+"]";
            SqlDataAdapter sda = new SqlDataAdapter(qwery, scon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 fs = new Form3();
            fs.Show();
            this.Hide();
        }
    }
}
