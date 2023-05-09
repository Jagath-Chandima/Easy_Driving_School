using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Easy_Driving_School
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string Query = txt_pname.Text;
            if (Query == "")
            {
                MessageBox.Show("insert details correctly");
                return;
            }
            MySqlConnection con = new MySqlConnection("server = localhost; username = root;password=; persistsecurityinfo=True;database=easy_driving_school");
            con.Open();
            MySqlCommand databaseConnection = new MySqlCommand("insert into payments values ('" + txt_pname.Text + "','" + txt_pnic.Text + "','" + comb_type.Text + "','" + comb_time.Text + "','" + txt_value.Text + "','" + txt_paid.Text + "','" + txt_balance.Text + "')", con);
            databaseConnection.ExecuteNonQuery();
            MessageBox.Show("save");
            con.Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if(comb_type.SelectedIndex==0 && comb_time.SelectedIndex==0)
            {
                txt_value.Text = "13000";
            }
            else if (comb_type.SelectedIndex == 0 && comb_time.SelectedIndex == 1)
            {
                txt_value.Text = "23000";
            }
            else if (comb_type.SelectedIndex == 1 && comb_time.SelectedIndex == 0)
            {
                txt_value.Text = "10000";
            }
            else if (comb_type.SelectedIndex == 1 && comb_time.SelectedIndex == 1)
            {
                txt_value.Text = "30000";
            }
            if(txt_paid.Text!="")
            {
                int balance = Convert.ToInt32(txt_value.Text) - Convert.ToInt32(txt_paid.Text);
                txt_balance.Text = balance.ToString();
            }
            else
            {
                MessageBox.Show("Please enter the paid amount");
            }
        }
    }
}
