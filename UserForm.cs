using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospRecMan
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

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
    }
}
