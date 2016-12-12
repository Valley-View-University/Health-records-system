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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void linklabelAdminLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            AdminLogin adlogin = new AdminLogin();
            adlogin.ShowDialog();
            Show();
        }

        private void btnUserLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=HOSPITALRECORDS;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM UserRecord WHERE UserName = '" + textBox1.Text + "'AND UserPassword = '" + textBox2.Text + "'", con);

            DateTime now = DateTime.Now;
            string Query = "UPDATE UserRecord set [Last SignIn] ='" + now + "'where UserName = '" + textBox1.Text + "';";
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

            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                Hide();
                MessageBox.Show("Login Successful");
                UserForm uf = new UserForm();
                uf.ShowDialog();
                Show();
                
            }
            else
                MessageBox.Show("Username or Password Invalid");

            
        }
    }
}
