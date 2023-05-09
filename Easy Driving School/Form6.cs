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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DataTable datatabel = new DataTable();
            string Query = txt_NIC.Text;
            if (Query == "")
            {
                MessageBox.Show("insert details correctly");
                return;
            }
            MySqlConnection con = new MySqlConnection("server = localhost; username = root;password=; persistsecurityinfo=True;database=easy_driving_school");
            con.Open();
            MySqlCommand databaseConnection = new MySqlCommand("insert into results values ('" + txt_NIC.Text + "','" + txt_result.Text + "')", con);
            databaseConnection.ExecuteNonQuery();
            MessageBox.Show("save");
            MySqlCommand databaseConnection2 = new MySqlCommand("select * from results", con);
            MySqlDataReader reader = databaseConnection2.ExecuteReader();
            datatabel.Load(reader);
            dataGridView1.DataSource = datatabel;
            con.Close();

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            DataTable datatabel = new DataTable();
            MySqlConnection con = new MySqlConnection("server = localhost; username = root;password=; persistsecurityinfo=True;database=easy_driving_school");
            con.Open();
            MySqlCommand databaseConnection = new MySqlCommand("select * from results", con);
            MySqlDataReader reader = databaseConnection.ExecuteReader();
            datatabel.Load(reader);
            dataGridView1.DataSource = datatabel;
            con.Close();
        }
    }
}
