namespace HospRecMan
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label patientIDLabel;
            System.Windows.Forms.Label patientTypeLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label middleNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label homeAddressLabel;
            System.Windows.Forms.Label occupationLabel;
            System.Windows.Forms.Label officeAddressLabel;
            System.Windows.Forms.Label weightLabel;
            System.Windows.Forms.Label heightLabel;
            System.Windows.Forms.Label nextOfKinLabel;
            System.Windows.Forms.Label kinPhoneNoLabel;
            System.Windows.Forms.Label lastHospitalVisitedLabel;
            System.Windows.Forms.Label diagnosisLabel;
            System.Windows.Forms.Label prescriptionsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.hOSPITALRECORDSDataSet = new HospRecMan.HOSPITALRECORDSDataSet();
            this.patientRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientRecordsTableAdapter = new HospRecMan.HOSPITALRECORDSDataSetTableAdapters.PatientRecordsTableAdapter();
            this.tableAdapterManager = new HospRecMan.HOSPITALRECORDSDataSetTableAdapters.TableAdapterManager();
            this.patientRecordsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.patientRecordsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.patientIDTextBox = new System.Windows.Forms.TextBox();
            this.patientTypeTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.homeAddressTextBox = new System.Windows.Forms.TextBox();
            this.occupationTextBox = new System.Windows.Forms.TextBox();
            this.officeAddressTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.nextOfKinTextBox = new System.Windows.Forms.TextBox();
            this.kinPhoneNoTextBox = new System.Windows.Forms.TextBox();
            this.lastHospitalVisitedTextBox = new System.Windows.Forms.TextBox();
            this.diagnosisTextBox = new System.Windows.Forms.TextBox();
            this.prescriptionsTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            patientIDLabel = new System.Windows.Forms.Label();
            patientTypeLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            middleNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            homeAddressLabel = new System.Windows.Forms.Label();
            occupationLabel = new System.Windows.Forms.Label();
            officeAddressLabel = new System.Windows.Forms.Label();
            weightLabel = new System.Windows.Forms.Label();
            heightLabel = new System.Windows.Forms.Label();
            nextOfKinLabel = new System.Windows.Forms.Label();
            kinPhoneNoLabel = new System.Windows.Forms.Label();
            lastHospitalVisitedLabel = new System.Windows.Forms.Label();
            diagnosisLabel = new System.Windows.Forms.Label();
            prescriptionsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPITALRECORDSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientRecordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientRecordsBindingNavigator)).BeginInit();
            this.patientRecordsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // patientIDLabel
            // 
            patientIDLabel.AutoSize = true;
            patientIDLabel.Location = new System.Drawing.Point(54, 91);
            patientIDLabel.Name = "patientIDLabel";
            patientIDLabel.Size = new System.Drawing.Size(57, 13);
            patientIDLabel.TabIndex = 3;
            patientIDLabel.Text = "Patient ID:";
            // 
            // patientTypeLabel
            // 
            patientTypeLabel.AutoSize = true;
            patientTypeLabel.Location = new System.Drawing.Point(282, 91);
            patientTypeLabel.Name = "patientTypeLabel";
            patientTypeLabel.Size = new System.Drawing.Size(70, 13);
            patientTypeLabel.TabIndex = 5;
            patientTypeLabel.Text = "Patient Type:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(92, 116);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 7;
            firstNameLabel.Text = "First Name:";
            // 
            // middleNameLabel
            // 
            middleNameLabel.AutoSize = true;
            middleNameLabel.Location = new System.Drawing.Point(211, 116);
            middleNameLabel.Name = "middleNameLabel";
            middleNameLabel.Size = new System.Drawing.Size(72, 13);
            middleNameLabel.TabIndex = 9;
            middleNameLabel.Text = "Middle Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(406, 116);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 11;
            lastNameLabel.Text = "Last Name:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(30, 192);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            phoneNumberLabel.TabIndex = 13;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // homeAddressLabel
            // 
            homeAddressLabel.AutoSize = true;
            homeAddressLabel.Location = new System.Drawing.Point(397, 176);
            homeAddressLabel.Name = "homeAddressLabel";
            homeAddressLabel.Size = new System.Drawing.Size(79, 13);
            homeAddressLabel.TabIndex = 15;
            homeAddressLabel.Text = "Home Address:";
            // 
            // occupationLabel
            // 
            occupationLabel.AutoSize = true;
            occupationLabel.Location = new System.Drawing.Point(30, 237);
            occupationLabel.Name = "occupationLabel";
            occupationLabel.Size = new System.Drawing.Size(65, 13);
            occupationLabel.TabIndex = 17;
            occupationLabel.Text = "Occupation:";
            // 
            // officeAddressLabel
            // 
            officeAddressLabel.AutoSize = true;
            officeAddressLabel.Location = new System.Drawing.Point(388, 238);
            officeAddressLabel.Name = "officeAddressLabel";
            officeAddressLabel.Size = new System.Drawing.Size(79, 13);
            officeAddressLabel.TabIndex = 19;
            officeAddressLabel.Text = "Office Address:";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new System.Drawing.Point(30, 275);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(44, 13);
            weightLabel.TabIndex = 21;
            weightLabel.Text = "Weight:";
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Location = new System.Drawing.Point(33, 305);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new System.Drawing.Size(41, 13);
            heightLabel.TabIndex = 23;
            heightLabel.Text = "Height:";
            // 
            // nextOfKinLabel
            // 
            nextOfKinLabel.AutoSize = true;
            nextOfKinLabel.Location = new System.Drawing.Point(30, 340);
            nextOfKinLabel.Name = "nextOfKinLabel";
            nextOfKinLabel.Size = new System.Drawing.Size(64, 13);
            nextOfKinLabel.TabIndex = 25;
            nextOfKinLabel.Text = "Next Of Kin:";
            // 
            // kinPhoneNoLabel
            // 
            kinPhoneNoLabel.AutoSize = true;
            kinPhoneNoLabel.Location = new System.Drawing.Point(30, 383);
            kinPhoneNoLabel.Name = "kinPhoneNoLabel";
            kinPhoneNoLabel.Size = new System.Drawing.Size(76, 13);
            kinPhoneNoLabel.TabIndex = 27;
            kinPhoneNoLabel.Text = "Kin Phone No:";
            // 
            // lastHospitalVisitedLabel
            // 
            lastHospitalVisitedLabel.AutoSize = true;
            lastHospitalVisitedLabel.Location = new System.Drawing.Point(33, 416);
            lastHospitalVisitedLabel.Name = "lastHospitalVisitedLabel";
            lastHospitalVisitedLabel.Size = new System.Drawing.Size(105, 13);
            lastHospitalVisitedLabel.TabIndex = 29;
            lastHospitalVisitedLabel.Text = "Last Hospital Visited:";
            // 
            // diagnosisLabel
            // 
            diagnosisLabel.AutoSize = true;
            diagnosisLabel.Location = new System.Drawing.Point(397, 309);
            diagnosisLabel.Name = "diagnosisLabel";
            diagnosisLabel.Size = new System.Drawing.Size(56, 13);
            diagnosisLabel.TabIndex = 31;
            diagnosisLabel.Text = "Diagnosis:";
            // 
            // prescriptionsLabel
            // 
            prescriptionsLabel.AutoSize = true;
            prescriptionsLabel.Location = new System.Drawing.Point(397, 416);
            prescriptionsLabel.Name = "prescriptionsLabel";
            prescriptionsLabel.Size = new System.Drawing.Size(70, 13);
            prescriptionsLabel.TabIndex = 33;
            prescriptionsLabel.Text = "Prescriptions:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(302, 28);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(384, 30);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(129, 20);
            this.textBoxSearch.TabIndex = 1;
            // 
            // hOSPITALRECORDSDataSet
            // 
            this.hOSPITALRECORDSDataSet.DataSetName = "HOSPITALRECORDSDataSet";
            this.hOSPITALRECORDSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientRecordsBindingSource
            // 
            this.patientRecordsBindingSource.DataMember = "PatientRecords";
            this.patientRecordsBindingSource.DataSource = this.hOSPITALRECORDSDataSet;
            // 
            // patientRecordsTableAdapter
            // 
            this.patientRecordsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminRecordTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PatientRecordsTableAdapter = this.patientRecordsTableAdapter;
            this.tableAdapterManager.PersonnelRecordsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HospRecMan.HOSPITALRECORDSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserRecordTableAdapter = null;
            // 
            // patientRecordsBindingNavigator
            // 
            this.patientRecordsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.patientRecordsBindingNavigator.BindingSource = this.patientRecordsBindingSource;
            this.patientRecordsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.patientRecordsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.patientRecordsBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.patientRecordsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.patientRecordsBindingNavigatorSaveItem});
            this.patientRecordsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.patientRecordsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.patientRecordsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.patientRecordsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.patientRecordsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.patientRecordsBindingNavigator.Name = "patientRecordsBindingNavigator";
            this.patientRecordsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.patientRecordsBindingNavigator.Size = new System.Drawing.Size(527, 25);
            this.patientRecordsBindingNavigator.TabIndex = 2;
            this.patientRecordsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // patientRecordsBindingNavigatorSaveItem
            // 
            this.patientRecordsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.patientRecordsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("patientRecordsBindingNavigatorSaveItem.Image")));
            this.patientRecordsBindingNavigatorSaveItem.Name = "patientRecordsBindingNavigatorSaveItem";
            this.patientRecordsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.patientRecordsBindingNavigatorSaveItem.Text = "Save Data";
            this.patientRecordsBindingNavigatorSaveItem.Click += new System.EventHandler(this.patientRecordsBindingNavigatorSaveItem_Click);
            // 
            // patientIDTextBox
            // 
            this.patientIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientRecordsBindingSource, "PatientID", true));
            this.patientIDTextBox.Location = new System.Drawing.Point(165, 88);
            this.patientIDTextBox.Name = "patientIDTextBox";
            this.patientIDTextBox.ReadOnly = true;
            this.patientIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.patientIDTextBox.TabIndex = 4;
            // 
            // patientTypeTextBox
            // 
            this.patientTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientRecordsBindingSource, "PatientType", true));
            this.patientTypeTextBox.Location = new System.Drawing.Point(393, 88);
            this.patientTypeTextBox.Name = "patientTypeTextBox";
            this.patientTypeTextBox.ReadOnly = true;
            this.patientTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.patientTypeTextBox.TabIndex = 6;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientRecordsBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(39, 141);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.ReadOnly = true;
            this.firstNameTextBox.Size = new System.Drawing.Size(127, 20);
            this.firstNameTextBox.TabIndex = 8;
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientRecordsBindingSource, "MiddleName", true));
            this.middleNameTextBox.Location = new System.Drawing.Point(172, 141);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.ReadOnly = true;
            this.middleNameTextBox.Size = new System.Drawing.Size(166, 20);
            this.middleNameTextBox.TabIndex = 10;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientRecordsBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(354, 141);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.ReadOnly = true;
            this.lastNameTextBox.Size = new System.Drawing.Size(161, 20);
            this.lastNameTextBox.TabIndex = 12;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientRecordsBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(141, 189);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.ReadOnly = true;
            this.phoneNumberTextBox.Size = new System.Drawing.Size(142, 20);
            this.phoneNumberTextBox.TabIndex = 14;
            // 
            // homeAddressTextBox
            // 
            this.homeAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientRecordsBindingSource, "HomeAddress", true));
            this.homeAddressTextBox.Location = new System.Drawing.Point(338, 189);
            this.homeAddressTextBox.Multiline = true;
            this.homeAddressTextBox.Name = "homeAddressTextBox";
            this.homeAddressTextBox.ReadOnly = true;
            this.homeAddressTextBox.Size = new System.Drawing.Size(177, 46);
            this.homeAddressTextBox.TabIndex = 16;
            // 
            // occupationTextBox
            // 
            this.occupationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientRecordsBindingSource, "Occupation", true));
            this.occupationTextBox.Location = new System.Drawing.Point(141, 230);
            this.occupationTextBox.Name = "occupationTextBox";
            this.occupationTextBox.ReadOnly = true;
            this.occupationTextBox.Size = new System.Drawing.Size(142, 20);
            this.occupationTextBox.TabIndex = 18;
            // 
            // officeAddressTextBox
            // 
            this.officeAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientRecordsBindingSource, "OfficeAddress", true));
            this.officeAddressTextBox.Location = new System.Drawing.Point(338, 254);
            this.officeAddressTextBox.Multiline = true;
            this.officeAddressTextBox.Name = "officeAddressTextBox";
            this.officeAddressTextBox.ReadOnly = true;
            this.officeAddressTextBox.Size = new System.Drawing.Size(175, 47);
            this.officeAddressTextBox.TabIndex = 20;
            // 
            // weightTextBox
            // 
            this.weightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientRecordsBindingSource, "Weight", true));
            this.weightTextBox.Location = new System.Drawing.Point(141, 272);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.ReadOnly = true;
            this.weightTextBox.Size = new System.Drawing.Size(142, 20);
            this.weightTextBox.TabIndex = 22;
            // 
            // heightTextBox
            // 
            this.heightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientRecordsBindingSource, "Height", true));
            this.heightTextBox.Location = new System.Drawing.Point(141, 302);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.ReadOnly = true;
            this.heightTextBox.Size = new System.Drawing.Size(142, 20);
            this.heightTextBox.TabIndex = 24;
            // 
            // nextOfKinTextBox
            // 
            this.nextOfKinTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientRecordsBindingSource, "NextOfKin", true));
            this.nextOfKinTextBox.Location = new System.Drawing.Point(141, 340);
            this.nextOfKinTextBox.Name = "nextOfKinTextBox";
            this.nextOfKinTextBox.ReadOnly = true;
            this.nextOfKinTextBox.Size = new System.Drawing.Size(142, 20);
            this.nextOfKinTextBox.TabIndex = 26;
            // 
            // kinPhoneNoTextBox
            // 
            this.kinPhoneNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientRecordsBindingSource, "KinPhoneNo", true));
            this.kinPhoneNoTextBox.Location = new System.Drawing.Point(141, 376);
            this.kinPhoneNoTextBox.Name = "kinPhoneNoTextBox";
            this.kinPhoneNoTextBox.ReadOnly = true;
            this.kinPhoneNoTextBox.Size = new System.Drawing.Size(142, 20);
            this.kinPhoneNoTextBox.TabIndex = 28;
            // 
            // lastHospitalVisitedTextBox
            // 
            this.lastHospitalVisitedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientRecordsBindingSource, "LastHospitalVisited", true));
            this.lastHospitalVisitedTextBox.Location = new System.Drawing.Point(144, 409);
            this.lastHospitalVisitedTextBox.Name = "lastHospitalVisitedTextBox";
            this.lastHospitalVisitedTextBox.ReadOnly = true;
            this.lastHospitalVisitedTextBox.Size = new System.Drawing.Size(139, 20);
            this.lastHospitalVisitedTextBox.TabIndex = 30;
            // 
            // diagnosisTextBox
            // 
            this.diagnosisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientRecordsBindingSource, "Diagnosis", true));
            this.diagnosisTextBox.Location = new System.Drawing.Point(338, 333);
            this.diagnosisTextBox.Multiline = true;
            this.diagnosisTextBox.Name = "diagnosisTextBox";
            this.diagnosisTextBox.ReadOnly = true;
            this.diagnosisTextBox.Size = new System.Drawing.Size(175, 75);
            this.diagnosisTextBox.TabIndex = 32;
            // 
            // prescriptionsTextBox
            // 
            this.prescriptionsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientRecordsBindingSource, "Prescriptions", true));
            this.prescriptionsTextBox.Location = new System.Drawing.Point(338, 441);
            this.prescriptionsTextBox.Multiline = true;
            this.prescriptionsTextBox.Name = "prescriptionsTextBox";
            this.prescriptionsTextBox.ReadOnly = true;
            this.prescriptionsTextBox.Size = new System.Drawing.Size(175, 61);
            this.prescriptionsTextBox.TabIndex = 34;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(527, 374);
            this.dataGridView1.TabIndex = 35;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 514);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(patientIDLabel);
            this.Controls.Add(this.patientIDTextBox);
            this.Controls.Add(patientTypeLabel);
            this.Controls.Add(this.patientTypeTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(middleNameLabel);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(homeAddressLabel);
            this.Controls.Add(this.homeAddressTextBox);
            this.Controls.Add(occupationLabel);
            this.Controls.Add(this.occupationTextBox);
            this.Controls.Add(officeAddressLabel);
            this.Controls.Add(this.officeAddressTextBox);
            this.Controls.Add(weightLabel);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(heightLabel);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(nextOfKinLabel);
            this.Controls.Add(this.nextOfKinTextBox);
            this.Controls.Add(kinPhoneNoLabel);
            this.Controls.Add(this.kinPhoneNoTextBox);
            this.Controls.Add(lastHospitalVisitedLabel);
            this.Controls.Add(this.lastHospitalVisitedTextBox);
            this.Controls.Add(diagnosisLabel);
            this.Controls.Add(this.diagnosisTextBox);
            this.Controls.Add(prescriptionsLabel);
            this.Controls.Add(this.prescriptionsTextBox);
            this.Controls.Add(this.patientRecordsBindingNavigator);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonSearch);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hOSPITALRECORDSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientRecordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientRecordsBindingNavigator)).EndInit();
            this.patientRecordsBindingNavigator.ResumeLayout(false);
            this.patientRecordsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private HOSPITALRECORDSDataSet hOSPITALRECORDSDataSet;
        private System.Windows.Forms.BindingSource patientRecordsBindingSource;
        private HOSPITALRECORDSDataSetTableAdapters.PatientRecordsTableAdapter patientRecordsTableAdapter;
        private HOSPITALRECORDSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator patientRecordsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton patientRecordsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox patientIDTextBox;
        private System.Windows.Forms.TextBox patientTypeTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox homeAddressTextBox;
        private System.Windows.Forms.TextBox occupationTextBox;
        private System.Windows.Forms.TextBox officeAddressTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox nextOfKinTextBox;
        private System.Windows.Forms.TextBox kinPhoneNoTextBox;
        private System.Windows.Forms.TextBox lastHospitalVisitedTextBox;
        private System.Windows.Forms.TextBox diagnosisTextBox;
        private System.Windows.Forms.TextBox prescriptionsTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}