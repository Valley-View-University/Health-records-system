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

namespace HospRecMan
{
    public partial class AdminLogin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=HOSPITALRECORDS;Integrated Security=True");
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM AdminRecord WHERE AdminUsername = '" + textBox1.Text + "'AND AdminPassword = '" + textBox2.Text + "'", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {                
                DateTime now = DateTime.Now;
                string Query = "UPDATE AdminRecord set [Last SignIn] ='" + now + "'where AdminUsername = '" + textBox1.Text + "';";
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataReader myReader;
                try
                {
                    con.Open();
                    myReader = cmd.ExecuteReader();
                    MessageBox.Show("Please note that your sign in has been recorded");
                    while (myReader.Read())
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }

                MessageBox.Show("Login Successful");
                Hide();
                Adminform adform = new Adminform();
                adform.ShowDialog();

                Show();
                
            }
            else
                MessageBox.Show("Username or Password Invalid");

            
        }
    }
}
