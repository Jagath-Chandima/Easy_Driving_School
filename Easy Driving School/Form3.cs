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
    public partial class Form3 : Form
    {
       
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string Query = txt_name.Text;
            if (Query == "")
            {
                MessageBox.Show("insert quary");
                return;
            }
            MySqlConnection con = new MySqlConnection("server = localhost; username = root;password=; persistsecurityinfo=True;database=easy_driving_school");
            con.Open();
            MySqlCommand databaseConnection = new MySqlCommand("insert into user_register values ('" + txt_workerid.Text + "','" + txt_name.Text + "','" + comb_post.Text + "','" + txt_password.Text + "')",con);
            databaseConnection.ExecuteNonQuery();
            MessageBox.Show("save");
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 f1 = new Form2();
            f1.Show();
        }
    }
}
