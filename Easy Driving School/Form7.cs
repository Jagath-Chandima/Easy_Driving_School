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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DataTable datatabel = new DataTable();
            string Query = txt_id.Text;
            if (Query == "")
            {
                MessageBox.Show("insert details correctly");
                return;
            }
            MySqlConnection con = new MySqlConnection("server = localhost; username = root;password=; persistsecurityinfo=True;database=easy_driving_school");
            con.Open();
            MySqlCommand databaseConnection = new MySqlCommand("insert into time_table values ('" +this.txt_id.Text + "','" + this.dateTimePicker1.Value + "','" + this.dateTimePicker2.Value + "','" + this.dateTimePicker3.Value + "','" + this.dateTimePicker4.Value + "')", con);
            databaseConnection.ExecuteNonQuery();
            MessageBox.Show("save");
            MySqlCommand databaseConnection2 = new MySqlCommand("select * from time_table", con);
            MySqlDataReader reader = databaseConnection2.ExecuteReader();
            datatabel.Load(reader);
            dataGridView1.DataSource = datatabel;
            con.Close();

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            DataTable datatabel = new DataTable();
            MySqlConnection con = new MySqlConnection("server = localhost; username = root;password=; persistsecurityinfo=True;database=easy_driving_school");
            con.Open();
            MySqlCommand databaseConnection = new MySqlCommand("select * from time_table", con);
            MySqlDataReader reader = databaseConnection.ExecuteReader();
            datatabel.Load(reader);
            dataGridView1.DataSource = datatabel;
            con.Close();
        }
    }
}
