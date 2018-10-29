using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voting
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            database db = new database();
            db.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result rt = new result();
            rt.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            analysis any = new analysis();
            any.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 fs1 = new Form1();
            this.Hide();
            fs1.Show();

            
        }
    }
}
