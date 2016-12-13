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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=HOSPITALRECORDS;Integrated Security=True");
        private void patientRecordsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientRecordsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hOSPITALRECORDSDataSet);

        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hOSPITALRECORDSDataSet.PatientRecords' table. You can move, or remove it, as needed.
            this.patientRecordsTableAdapter.Fill(this.hOSPITALRECORDSDataSet.PatientRecords);

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM PatientRecords WHERE  PatientID = '"+textBoxSearch.Text +"'",con);
            try
            {
                SDA.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
