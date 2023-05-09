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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btn_Csava_Click(object sender, EventArgs e)
        {
            string Query = txt_Cname.Text;
            if (Query == "")
            {
                MessageBox.Show("insert details correctly");
                return;
            }
            MySqlConnection con = new MySqlConnection("server = localhost; username = root;password=; persistsecurityinfo=True;database=easy_driving_school");
            con.Open();
            MySqlCommand databaseConnection = new MySqlCommand("insert into client_register values ('" + txt_Cname.Text + "','" + txt_Cnic.Text + "','" + txt_Cadd.Text + "','" + txt_Cpnum.Text + "','" + comb_type.Text + "','" + comb_time.Text + "','" + comb_dob.Text + "','" + comb_id.Text + "','" + comb_photoes.Text + "')", con);
            databaseConnection.ExecuteNonQuery();
            MessageBox.Show("save");
            con.Close();

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
