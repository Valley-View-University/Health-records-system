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
    public partial class Adminform : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=HOSPITALRECORDS;Integrated Security=True");
        public Adminform()
        {
            InitializeComponent();
        }
        //****************DELETE PROFILE METHOD*********************//
        private void btnDelProfile_Click(object sender, EventArgs e)
        {
            panelResetPassword.Hide();
            panelAddUser.Hide();
            panelDeleteRecords.Show();
        }
        //****************FORM LOAD METHOD**************************//
        private void Adminform_Load(object sender, EventArgs e)
        {
            panelDeleteRecords.Hide();
            panelResetPassword.Hide();
            panelAddUser.Hide();
        }
        //*******************RESET PASSWORD BUTTON*******************//
        private void btnResetPassword_Click(object sender, EventArgs e)
        {


            if (comboBoxUserType.Text == "User")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM UserRecord WHERE UserName = '" + textBUsername.Text + "'AND UserPassword = '" + textBoxOldPassword.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    if (textBoxNewPassword.Text == textBoxVerifyPassword.Text)
                    {
                        string Query = "UPDATE UserRecord set UserPassword ='" + textBoxNewPassword.Text + "'where UserName = '" + textBUsername.Text + "';";

                        SqlCommand cmd = new SqlCommand(Query, con);
                        SqlDataReader myReader;
                        try
                        {
                            con.Open();
                            myReader = cmd.ExecuteReader();
                            MessageBox.Show("Password Reset Successfully");
                            while (myReader.Read())
                            {
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                        MessageBox.Show("Password does not match");

                }
                else
                    MessageBox.Show("Username or Password Invalid");
            }
            else if (comboBoxUserType.Text == "Admin")
            {
                SqlDataAdapter sda1 = new SqlDataAdapter("SELECT * FROM AdminRecord WHERE AdminUsername = '" + textBUsername.Text + "'AND AdminPassword = '" + textBoxOldPassword.Text + "'", con);
                DataTable dt = new DataTable();
                sda1.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    if (textBoxNewPassword.Text == textBoxVerifyPassword.Text)
                    {
                        string Query1 = "UPDATE AdminRecord set AdminPAssword ='" + textBoxNewPassword.Text + "'where AdminUsername = '" + textBUsername.Text + "';";
                        SqlCommand cmd1 = new SqlCommand(Query1, con);
                        SqlDataReader myReader;
                        try
                        {
                            con.Open();
                            myReader = cmd1.ExecuteReader();
                            MessageBox.Show("Password Reset Successfully");
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
                    }
                    else
                        MessageBox.Show("Password does not match");
                }
                else
                    MessageBox.Show("Username or Password Invalid");
            }
            else
                MessageBox.Show("Select User Type");
        }


        //*********************METHOD TO PASSWORD RESET*****************************//
        private void btnResetPass_Click(object sender, EventArgs e)
        {
            panelResetPassword.Show();
            panelDeleteRecords.Hide();
            panelAddUser.Hide();

        }
        //***********************METHOD TO ACCOUNT DELETE****************************//
        private void buttonDeleteAccount_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM AdminRecord WHERE AdminPassword = '" + textBoxAdminPassword.Text + "'", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                string Query = "DELETE FROM UserRecord WHERE UserName = '" + this.textBoxUser.Text + "';";

                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataReader myReader;
                try
                {
                    con.Open();
                    myReader = cmd.ExecuteReader();
                    MessageBox.Show("Record Deleted");
                    while (myReader.Read())
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Record not Found");
        }


        //**********************METHOD TO VIEW RECORD**************************//
        private void btnViewPatRecord_Click(object sender, EventArgs e)
        {
            panelResetPassword.Hide(); panelDeleteRecords.Hide(); panelAddUser.Hide();


            Hide();
            Records rec = new Records();
            rec.ShowDialog();
            Show();
        }
        //***********************METHOD TO UPDATE RECORD*********************///
        private void btnUpdRecord_Click(object sender, EventArgs e)
        {

        }
        //************************METHOD TO ADD USER**************************///
        private void btnAddMedStaff_Click(object sender, EventArgs e)
        {
            panelAddUser.Show();
            panelDeleteRecords.Hide();
            panelResetPassword.Hide();
        }

        ///*************************CREATE USER BUTTON****************************///
        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            SqlDataReader myReader;
            if (comboBoxUser.Text == "Admin")
            {
                String Query = "INSERT INTO AdminRecord (AdminUsername, AdminPassword, [Last SignIn])" + "values('" + textBoxNewUserName.Text + "','" + txtBxNewPassword.Text + "','" + now + "');";
                SqlCommand cmd = new SqlCommand(Query, con);

                if (textBoxNewPassword.Text == textBoxVerifyPassword.Text)
                {

                    try
                    {
                        con.Open();
                        myReader = cmd.ExecuteReader();
                        MessageBox.Show("User Created Successfully");
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
                }
                if (comboBoxUser.Text == "User")
                {
                    String Query1 = "INSERT INTO UserRecord (UserID, UserName, UserPassword, [Last SignIn])" + "values('" + textBoxUserID.Text + "','" + textBoxNewUserName.Text + "','" + txtBxNewPassword.Text + "','" + now + "');";
                    SqlCommand cmd1 = new SqlCommand(Query1, con);

                    if (textBoxNewPassword.Text == textBoxVerifyPassword.Text)
                    {

                        try
                        {
                            con.Open();
                            myReader = cmd1.ExecuteReader();
                            MessageBox.Show("User Created Successfully");
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
                    }


                }
            }
        }

        private void comboBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUser.Text == "Admin")
            {
                textBoxUserID.Hide();
                label10.Hide();

            }
            else if (comboBoxUser.Text == "User")
            {
                textBoxUserID.Show();
                label10.Show();
            }
        }
    }
}