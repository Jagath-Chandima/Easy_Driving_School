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

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server = localhost; username = root;password=; persistsecurityinfo=True;database=easy_driving_school");
            con.Open();
            MySqlCommand databaseConnection = new MySqlCommand("select 	worker_id, password from user_register where worker_id='"+txt_username.Text+"' and  password = '"+txt_password.Text+"' ", con);
            MySqlDataReader dr = databaseConnection.ExecuteReader();
            if (dr.Read())
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Invalid NICnumber or password");
                txt_username.Clear();
                txt_password.Clear();
            }
            
        }
    }
}
