using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easy_Driving_School
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 f3 = new Form3();
            f3.Show();

        }

        private void btn_client_reg_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void btn_payments_Click(object sender, EventArgs e)
        {
            this.Close();
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void btn_results_Click(object sender, EventArgs e)
        {
            this.Close();
            Form6 f6 = new Form6();
            f6.Show();
        }

        private void btn_timetable_Click(object sender, EventArgs e)
        {
            this.Close();
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
