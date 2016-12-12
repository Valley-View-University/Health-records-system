using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HospRecMan
{
    public partial class Records : Form
    {
        public Records()
        {
            InitializeComponent();
        }

        private string imgLocation;
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=HOSPITALRECORDS;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        private void adminRecordBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.adminRecordBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hOSPITALRECORDSDataSet);

        }

        private void Records_Load(object sender, EventArgs e)
        {
            adminRecordBindingNavigator.Hide();
            // TODO: This line of code loads data into the 'hOSPITALRECORDSDataSet.UserRecord' table. You can move, or remove it, as needed.
            this.userRecordTableAdapter.Fill(this.hOSPITALRECORDSDataSet.UserRecord);
            // TODO: This line of code loads data into the 'hOSPITALRECORDSDataSet.PersonnelRecords' table. You can move, or remove it, as needed.
            this.personnelRecordsTableAdapter.Fill(this.hOSPITALRECORDSDataSet.PersonnelRecords);
            // TODO: This line of code loads data into the 'hOSPITALRECORDSDataSet.PatientRecords' table. You can move, or remove it, as needed.
            this.patientRecordsTableAdapter.Fill(this.hOSPITALRECORDSDataSet.PatientRecords);
            // TODO: This line of code loads data into the 'hOSPITALRECORDSDataSet.AdminRecord' table. You can move, or remove it, as needed.
            this.adminRecordTableAdapter.Fill(this.hOSPITALRECORDSDataSet.AdminRecord);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*.jpg";//"png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";

            dialog.InitialDirectory = @"Libraries\Pictures";
            dialog.Title = "Select Patient Photo";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string picPath = dialog.FileName.ToString();
                textBox1.Text = picPath;
                pictureBox1.ImageLocation = picPath;

                pictureBox1.Image = new Bitmap(dialog.FileName);
                textBox1.Text = dialog.FileName;

                imgLocation = dialog.FileName.ToString();
                textBox1.Text = imgLocation;
                pictureBox1.ImageLocation = imgLocation;
            }
        }

        private void buttonSavePatientInfo_Click(object sender, EventArgs e)
        {
            byte[] imagesBt = null;
            FileStream stream = new FileStream(this.textBox1.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(stream);
            imagesBt = br.ReadBytes((int)stream.Length);

            string Query = "INSERT INTO PatientRecords (PatientID, PatientType, Image, FirstName, MiddleName, LastName, PhoneNumber, HomeAddress, Occupation, OfficeAddress, Weight, Height, NextOfKin, KinPhoneNo, LastHospitalVisited, Diagnosis, Prescriptions)" + "values('" + patientIDTextBox.Text + "','" + patientTypeTextBox.Text + "','"+ "@IMG" +"','"+ firstNameTextBox.Text + "','" + middleNameTextBox.Text + "','" + lastNameTextBox.Text + "','" + phoneNumberTextBox.Text + "','" + homeAddressTextBox.Text + "','" + occupationTextBox.Text + "','" + officeAddressTextBox.Text + "','" + weightTextBox.Text + "','" + heightTextBox.Text + "','" + nextOfKinTextBox.Text + "','" + kinPhoneNoTextBox.Text + "','" + lastHospitalVisitedTextBox.Text + "','" + diagnosisTextBox.Text + "','" + prescriptionsTextBox.Text + "');";
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader myReader;

            try
            {
                con.Open();
                cmd.Parameters.Add(new SqlParameter("@IMG", imagesBt));
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Patient Info Saved Successfully");
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

        private void personnelRecordsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
