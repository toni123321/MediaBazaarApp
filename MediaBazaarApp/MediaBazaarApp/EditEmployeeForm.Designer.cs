
namespace MediaBazaarApp
{
    partial class EditEmployeeForm
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
            this.btnEditEmpoyee = new System.Windows.Forms.Button();
            this.lbEmployeeInfo = new System.Windows.Forms.Label();
            this.cbEmConRelation = new System.Windows.Forms.ComboBox();
            this.lbEmConRelation = new System.Windows.Forms.Label();
            this.tbxEmConName = new System.Windows.Forms.TextBox();
            this.lbEmConName = new System.Windows.Forms.Label();
            this.tbxEmConEmail = new System.Windows.Forms.TextBox();
            this.lbEmConEmail = new System.Windows.Forms.Label();
            this.tbxEmConPhone = new System.Windows.Forms.TextBox();
            this.lbEmConPhone = new System.Windows.Forms.Label();
            this.lbEmpEmConDetails = new System.Windows.Forms.Label();
            this.lbEmpBsn = new System.Windows.Forms.Label();
            this.tbxEmpBsn = new System.Windows.Forms.TextBox();
            this.nudEmpHourlyWages = new System.Windows.Forms.NumericUpDown();
            this.cbEmpDepartment = new System.Windows.Forms.ComboBox();
            this.lbEmpDepartment = new System.Windows.Forms.Label();
            this.cbEmpEmploymentType = new System.Windows.Forms.ComboBox();
            this.lbEmpJobSpec = new System.Windows.Forms.Label();
            this.lbEmpAddressStreet = new System.Windows.Forms.Label();
            this.lbEmpPersonalInfo = new System.Windows.Forms.Label();
            this.tbxEmpAddressStreet = new System.Windows.Forms.TextBox();
            this.tbxEmpAddressCity = new System.Windows.Forms.TextBox();
            this.cbEmpGender = new System.Windows.Forms.ComboBox();
            this.lbEmpAddressCity = new System.Windows.Forms.Label();
            this.tbxEmpEmail = new System.Windows.Forms.TextBox();
            this.tbxEmpAddressCountry = new System.Windows.Forms.TextBox();
            this.lbEmpEmail = new System.Windows.Forms.Label();
            this.lbEmpAddressPostCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbEmpAddressCountry = new System.Windows.Forms.Label();
            this.dtpEmpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.tbxEmpAddressPostCode = new System.Windows.Forms.TextBox();
            this.lbEmpEmployementType = new System.Windows.Forms.Label();
            this.lbEmpDateOfBirth = new System.Windows.Forms.Label();
            this.lbEmpHourlyWages = new System.Windows.Forms.Label();
            this.tbxEmpPhone = new System.Windows.Forms.TextBox();
            this.lbEmpPhone = new System.Windows.Forms.Label();
            this.lbEmployeeAddress = new System.Windows.Forms.Label();
            this.tbxEmpLname = new System.Windows.Forms.TextBox();
            this.lbEmpLname = new System.Windows.Forms.Label();
            this.tbxEmpFname = new System.Windows.Forms.TextBox();
            this.lbEmpFname = new System.Windows.Forms.Label();
            this.lbEmpNationality = new System.Windows.Forms.Label();
            this.tbxEmpNationality = new System.Windows.Forms.TextBox();
            this.dtpEmpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lbEmpStartDate = new System.Windows.Forms.Label();
            this.tbxEmpEndDate = new System.Windows.Forms.TextBox();
            this.lbEmpNewEndDate = new System.Windows.Forms.Label();
            this.dtpEmpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lbEmpEndDate = new System.Windows.Forms.Label();
            this.cbxEmpIndefiniteContract = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpHourlyWages)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditEmpoyee
            // 
            this.btnEditEmpoyee.BackColor = System.Drawing.Color.LightSalmon;
            this.btnEditEmpoyee.Location = new System.Drawing.Point(515, 633);
            this.btnEditEmpoyee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditEmpoyee.Name = "btnEditEmpoyee";
            this.btnEditEmpoyee.Size = new System.Drawing.Size(263, 80);
            this.btnEditEmpoyee.TabIndex = 16;
            this.btnEditEmpoyee.Text = "Apply changes";
            this.btnEditEmpoyee.UseVisualStyleBackColor = false;
            this.btnEditEmpoyee.Click += new System.EventHandler(this.btnEditEmpoyee_Click);
            // 
            // lbEmployeeInfo
            // 
            this.lbEmployeeInfo.AutoSize = true;
            this.lbEmployeeInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbEmployeeInfo.Location = new System.Drawing.Point(387, 10);
            this.lbEmployeeInfo.Name = "lbEmployeeInfo";
            this.lbEmployeeInfo.Size = new System.Drawing.Size(433, 32);
            this.lbEmployeeInfo.TabIndex = 2;
            this.lbEmployeeInfo.Text = "Profile details of employee with ID:(Id)";
            // 
            // cbEmConRelation
            // 
            this.cbEmConRelation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbEmConRelation.FormattingEnabled = true;
            this.cbEmConRelation.Items.AddRange(new object[] {
            "Family",
            "Friend",
            "Colleague",
            "Other"});
            this.cbEmConRelation.Location = new System.Drawing.Point(135, 562);
            this.cbEmConRelation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEmConRelation.Name = "cbEmConRelation";
            this.cbEmConRelation.Size = new System.Drawing.Size(167, 33);
            this.cbEmConRelation.TabIndex = 18;
            // 
            // lbEmConRelation
            // 
            this.lbEmConRelation.AutoSize = true;
            this.lbEmConRelation.Location = new System.Drawing.Point(47, 566);
            this.lbEmConRelation.Name = "lbEmConRelation";
            this.lbEmConRelation.Size = new System.Drawing.Size(79, 25);
            this.lbEmConRelation.TabIndex = 17;
            this.lbEmConRelation.Text = "Relation:";
            // 
            // tbxEmConName
            // 
            this.tbxEmConName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmConName.Location = new System.Drawing.Point(134, 518);
            this.tbxEmConName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmConName.Name = "tbxEmConName";
            this.tbxEmConName.Size = new System.Drawing.Size(168, 31);
            this.tbxEmConName.TabIndex = 17;
            // 
            // lbEmConName
            // 
            this.lbEmConName.AutoSize = true;
            this.lbEmConName.Location = new System.Drawing.Point(61, 520);
            this.lbEmConName.Name = "lbEmConName";
            this.lbEmConName.Size = new System.Drawing.Size(63, 25);
            this.lbEmConName.TabIndex = 16;
            this.lbEmConName.Text = "Name:";
            // 
            // tbxEmConEmail
            // 
            this.tbxEmConEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmConEmail.Location = new System.Drawing.Point(414, 515);
            this.tbxEmConEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmConEmail.Name = "tbxEmConEmail";
            this.tbxEmConEmail.Size = new System.Drawing.Size(168, 31);
            this.tbxEmConEmail.TabIndex = 19;
            // 
            // lbEmConEmail
            // 
            this.lbEmConEmail.AutoSize = true;
            this.lbEmConEmail.Location = new System.Drawing.Point(338, 518);
            this.lbEmConEmail.Name = "lbEmConEmail";
            this.lbEmConEmail.Size = new System.Drawing.Size(58, 25);
            this.lbEmConEmail.TabIndex = 18;
            this.lbEmConEmail.Text = "Email:";
            // 
            // tbxEmConPhone
            // 
            this.tbxEmConPhone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmConPhone.Location = new System.Drawing.Point(414, 562);
            this.tbxEmConPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmConPhone.Name = "tbxEmConPhone";
            this.tbxEmConPhone.Size = new System.Drawing.Size(168, 31);
            this.tbxEmConPhone.TabIndex = 19;
            // 
            // lbEmConPhone
            // 
            this.lbEmConPhone.AutoSize = true;
            this.lbEmConPhone.Location = new System.Drawing.Point(335, 566);
            this.lbEmConPhone.Name = "lbEmConPhone";
            this.lbEmConPhone.Size = new System.Drawing.Size(66, 25);
            this.lbEmConPhone.TabIndex = 19;
            this.lbEmConPhone.Text = "Phone:";
            // 
            // lbEmpEmConDetails
            // 
            this.lbEmpEmConDetails.AutoSize = true;
            this.lbEmpEmConDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbEmpEmConDetails.Location = new System.Drawing.Point(165, 458);
            this.lbEmpEmConDetails.Name = "lbEmpEmConDetails";
            this.lbEmpEmConDetails.Size = new System.Drawing.Size(306, 32);
            this.lbEmpEmConDetails.TabIndex = 22;
            this.lbEmpEmConDetails.Text = "Emergency contact details:";
            // 
            // lbEmpBsn
            // 
            this.lbEmpBsn.AutoSize = true;
            this.lbEmpBsn.Location = new System.Drawing.Point(86, 358);
            this.lbEmpBsn.Name = "lbEmpBsn";
            this.lbEmpBsn.Size = new System.Drawing.Size(44, 25);
            this.lbEmpBsn.TabIndex = 15;
            this.lbEmpBsn.Text = "Bsn:";
            // 
            // tbxEmpBsn
            // 
            this.tbxEmpBsn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmpBsn.Location = new System.Drawing.Point(165, 358);
            this.tbxEmpBsn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmpBsn.Name = "tbxEmpBsn";
            this.tbxEmpBsn.Size = new System.Drawing.Size(160, 31);
            this.tbxEmpBsn.TabIndex = 15;
            // 
            // nudEmpHourlyWages
            // 
            this.nudEmpHourlyWages.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nudEmpHourlyWages.Location = new System.Drawing.Point(933, 227);
            this.nudEmpHourlyWages.Name = "nudEmpHourlyWages";
            this.nudEmpHourlyWages.Size = new System.Drawing.Size(160, 31);
            this.nudEmpHourlyWages.TabIndex = 7;
            this.nudEmpHourlyWages.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudEmpHourlyWages.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cbEmpDepartment
            // 
            this.cbEmpDepartment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbEmpDepartment.FormattingEnabled = true;
            this.cbEmpDepartment.Location = new System.Drawing.Point(933, 282);
            this.cbEmpDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEmpDepartment.Name = "cbEmpDepartment";
            this.cbEmpDepartment.Size = new System.Drawing.Size(160, 33);
            this.cbEmpDepartment.TabIndex = 8;
            // 
            // lbEmpDepartment
            // 
            this.lbEmpDepartment.AutoSize = true;
            this.lbEmpDepartment.Location = new System.Drawing.Point(816, 287);
            this.lbEmpDepartment.Name = "lbEmpDepartment";
            this.lbEmpDepartment.Size = new System.Drawing.Size(111, 25);
            this.lbEmpDepartment.TabIndex = 8;
            this.lbEmpDepartment.Text = "Department:";
            // 
            // cbEmpEmploymentType
            // 
            this.cbEmpEmploymentType.AutoCompleteCustomSource.AddRange(new string[] {
            "Full-time",
            "Part-time"});
            this.cbEmpEmploymentType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbEmpEmploymentType.FormattingEnabled = true;
            this.cbEmpEmploymentType.Items.AddRange(new object[] {
            "FULLTIME",
            "PARTTIME1",
            "PARTTIME2"});
            this.cbEmpEmploymentType.Location = new System.Drawing.Point(934, 168);
            this.cbEmpEmploymentType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEmpEmploymentType.Name = "cbEmpEmploymentType";
            this.cbEmpEmploymentType.Size = new System.Drawing.Size(160, 33);
            this.cbEmpEmploymentType.TabIndex = 5;
            // 
            // lbEmpJobSpec
            // 
            this.lbEmpJobSpec.AutoSize = true;
            this.lbEmpJobSpec.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbEmpJobSpec.Location = new System.Drawing.Point(856, 101);
            this.lbEmpJobSpec.Name = "lbEmpJobSpec";
            this.lbEmpJobSpec.Size = new System.Drawing.Size(211, 32);
            this.lbEmpJobSpec.TabIndex = 5;
            this.lbEmpJobSpec.Text = "Job specifications:";
            // 
            // lbEmpAddressStreet
            // 
            this.lbEmpAddressStreet.AutoSize = true;
            this.lbEmpAddressStreet.Location = new System.Drawing.Point(439, 263);
            this.lbEmpAddressStreet.Name = "lbEmpAddressStreet";
            this.lbEmpAddressStreet.Size = new System.Drawing.Size(61, 25);
            this.lbEmpAddressStreet.TabIndex = 11;
            this.lbEmpAddressStreet.Text = "Street:";
            // 
            // lbEmpPersonalInfo
            // 
            this.lbEmpPersonalInfo.AutoSize = true;
            this.lbEmpPersonalInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbEmpPersonalInfo.Location = new System.Drawing.Point(129, 101);
            this.lbEmpPersonalInfo.Name = "lbEmpPersonalInfo";
            this.lbEmpPersonalInfo.Size = new System.Drawing.Size(248, 32);
            this.lbEmpPersonalInfo.TabIndex = 1;
            this.lbEmpPersonalInfo.Text = "Personal information:";
            // 
            // tbxEmpAddressStreet
            // 
            this.tbxEmpAddressStreet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmpAddressStreet.Location = new System.Drawing.Point(515, 260);
            this.tbxEmpAddressStreet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmpAddressStreet.Name = "tbxEmpAddressStreet";
            this.tbxEmpAddressStreet.Size = new System.Drawing.Size(168, 31);
            this.tbxEmpAddressStreet.TabIndex = 11;
            // 
            // tbxEmpAddressCity
            // 
            this.tbxEmpAddressCity.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmpAddressCity.Location = new System.Drawing.Point(515, 308);
            this.tbxEmpAddressCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmpAddressCity.Name = "tbxEmpAddressCity";
            this.tbxEmpAddressCity.Size = new System.Drawing.Size(168, 31);
            this.tbxEmpAddressCity.TabIndex = 12;
            // 
            // cbEmpGender
            // 
            this.cbEmpGender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbEmpGender.FormattingEnabled = true;
            this.cbEmpGender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE",
            "NONBINARY",
            "OTHER"});
            this.cbEmpGender.Location = new System.Drawing.Point(165, 304);
            this.cbEmpGender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEmpGender.Name = "cbEmpGender";
            this.cbEmpGender.Size = new System.Drawing.Size(161, 33);
            this.cbEmpGender.TabIndex = 4;
            this.cbEmpGender.Text = "Choose gender";
            // 
            // lbEmpAddressCity
            // 
            this.lbEmpAddressCity.AutoSize = true;
            this.lbEmpAddressCity.Location = new System.Drawing.Point(454, 312);
            this.lbEmpAddressCity.Name = "lbEmpAddressCity";
            this.lbEmpAddressCity.Size = new System.Drawing.Size(46, 25);
            this.lbEmpAddressCity.TabIndex = 12;
            this.lbEmpAddressCity.Text = "City:";
            // 
            // tbxEmpEmail
            // 
            this.tbxEmpEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmpEmail.Location = new System.Drawing.Point(515, 157);
            this.tbxEmpEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmpEmail.Name = "tbxEmpEmail";
            this.tbxEmpEmail.Size = new System.Drawing.Size(168, 31);
            this.tbxEmpEmail.TabIndex = 9;
            // 
            // tbxEmpAddressCountry
            // 
            this.tbxEmpAddressCountry.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmpAddressCountry.Location = new System.Drawing.Point(515, 358);
            this.tbxEmpAddressCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmpAddressCountry.Name = "tbxEmpAddressCountry";
            this.tbxEmpAddressCountry.Size = new System.Drawing.Size(168, 31);
            this.tbxEmpAddressCountry.TabIndex = 13;
            // 
            // lbEmpEmail
            // 
            this.lbEmpEmail.AutoSize = true;
            this.lbEmpEmail.Location = new System.Drawing.Point(435, 160);
            this.lbEmpEmail.Name = "lbEmpEmail";
            this.lbEmpEmail.Size = new System.Drawing.Size(58, 25);
            this.lbEmpEmail.TabIndex = 9;
            this.lbEmpEmail.Text = "Email:";
            // 
            // lbEmpAddressPostCode
            // 
            this.lbEmpAddressPostCode.AutoSize = true;
            this.lbEmpAddressPostCode.Location = new System.Drawing.Point(416, 407);
            this.lbEmpAddressPostCode.Name = "lbEmpAddressPostCode";
            this.lbEmpAddressPostCode.Size = new System.Drawing.Size(92, 25);
            this.lbEmpAddressPostCode.TabIndex = 14;
            this.lbEmpAddressPostCode.Text = "PostCode:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gender:";
            // 
            // lbEmpAddressCountry
            // 
            this.lbEmpAddressCountry.AutoSize = true;
            this.lbEmpAddressCountry.Location = new System.Drawing.Point(427, 362);
            this.lbEmpAddressCountry.Name = "lbEmpAddressCountry";
            this.lbEmpAddressCountry.Size = new System.Drawing.Size(79, 25);
            this.lbEmpAddressCountry.TabIndex = 13;
            this.lbEmpAddressCountry.Text = "Country:";
            // 
            // dtpEmpDateOfBirth
            // 
            this.dtpEmpDateOfBirth.Location = new System.Drawing.Point(165, 258);
            this.dtpEmpDateOfBirth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpEmpDateOfBirth.Name = "dtpEmpDateOfBirth";
            this.dtpEmpDateOfBirth.Size = new System.Drawing.Size(212, 31);
            this.dtpEmpDateOfBirth.TabIndex = 3;
            // 
            // tbxEmpAddressPostCode
            // 
            this.tbxEmpAddressPostCode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmpAddressPostCode.Location = new System.Drawing.Point(515, 402);
            this.tbxEmpAddressPostCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmpAddressPostCode.Name = "tbxEmpAddressPostCode";
            this.tbxEmpAddressPostCode.Size = new System.Drawing.Size(168, 31);
            this.tbxEmpAddressPostCode.TabIndex = 14;
            // 
            // lbEmpEmployementType
            // 
            this.lbEmpEmployementType.AutoSize = true;
            this.lbEmpEmployementType.Location = new System.Drawing.Point(787, 171);
            this.lbEmpEmployementType.Name = "lbEmpEmployementType";
            this.lbEmpEmployementType.Size = new System.Drawing.Size(141, 25);
            this.lbEmpEmployementType.TabIndex = 5;
            this.lbEmpEmployementType.Text = "Eployment type:";
            // 
            // lbEmpDateOfBirth
            // 
            this.lbEmpDateOfBirth.AutoSize = true;
            this.lbEmpDateOfBirth.Location = new System.Drawing.Point(49, 258);
            this.lbEmpDateOfBirth.Name = "lbEmpDateOfBirth";
            this.lbEmpDateOfBirth.Size = new System.Drawing.Size(117, 25);
            this.lbEmpDateOfBirth.TabIndex = 3;
            this.lbEmpDateOfBirth.Text = "Date of birth:";
            // 
            // lbEmpHourlyWages
            // 
            this.lbEmpHourlyWages.AutoSize = true;
            this.lbEmpHourlyWages.Location = new System.Drawing.Point(808, 227);
            this.lbEmpHourlyWages.Name = "lbEmpHourlyWages";
            this.lbEmpHourlyWages.Size = new System.Drawing.Size(124, 25);
            this.lbEmpHourlyWages.TabIndex = 7;
            this.lbEmpHourlyWages.Text = "Hourly wages:";
            // 
            // tbxEmpPhone
            // 
            this.tbxEmpPhone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmpPhone.Location = new System.Drawing.Point(515, 209);
            this.tbxEmpPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmpPhone.Name = "tbxEmpPhone";
            this.tbxEmpPhone.Size = new System.Drawing.Size(168, 31);
            this.tbxEmpPhone.TabIndex = 10;
            // 
            // lbEmpPhone
            // 
            this.lbEmpPhone.AutoSize = true;
            this.lbEmpPhone.Location = new System.Drawing.Point(435, 213);
            this.lbEmpPhone.Name = "lbEmpPhone";
            this.lbEmpPhone.Size = new System.Drawing.Size(66, 25);
            this.lbEmpPhone.TabIndex = 10;
            this.lbEmpPhone.Text = "Phone:";
            // 
            // lbEmployeeAddress
            // 
            this.lbEmployeeAddress.AutoSize = true;
            this.lbEmployeeAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbEmployeeAddress.Location = new System.Drawing.Point(474, 101);
            this.lbEmployeeAddress.Name = "lbEmployeeAddress";
            this.lbEmployeeAddress.Size = new System.Drawing.Size(184, 32);
            this.lbEmployeeAddress.TabIndex = 9;
            this.lbEmployeeAddress.Text = "Contact details:";
            // 
            // tbxEmpLname
            // 
            this.tbxEmpLname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmpLname.Location = new System.Drawing.Point(166, 212);
            this.tbxEmpLname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmpLname.Name = "tbxEmpLname";
            this.tbxEmpLname.Size = new System.Drawing.Size(160, 31);
            this.tbxEmpLname.TabIndex = 2;
            // 
            // lbEmpLname
            // 
            this.lbEmpLname.AutoSize = true;
            this.lbEmpLname.Location = new System.Drawing.Point(62, 212);
            this.lbEmpLname.Name = "lbEmpLname";
            this.lbEmpLname.Size = new System.Drawing.Size(96, 25);
            this.lbEmpLname.TabIndex = 2;
            this.lbEmpLname.Text = "Last name:";
            // 
            // tbxEmpFname
            // 
            this.tbxEmpFname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmpFname.Location = new System.Drawing.Point(166, 157);
            this.tbxEmpFname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmpFname.Name = "tbxEmpFname";
            this.tbxEmpFname.Size = new System.Drawing.Size(160, 31);
            this.tbxEmpFname.TabIndex = 1;
            // 
            // lbEmpFname
            // 
            this.lbEmpFname.AutoSize = true;
            this.lbEmpFname.Location = new System.Drawing.Point(62, 157);
            this.lbEmpFname.Name = "lbEmpFname";
            this.lbEmpFname.Size = new System.Drawing.Size(98, 25);
            this.lbEmpFname.TabIndex = 1;
            this.lbEmpFname.Text = "First name:";
            // 
            // lbEmpNationality
            // 
            this.lbEmpNationality.AutoSize = true;
            this.lbEmpNationality.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpNationality.Location = new System.Drawing.Point(49, 418);
            this.lbEmpNationality.Name = "lbEmpNationality";
            this.lbEmpNationality.Size = new System.Drawing.Size(99, 25);
            this.lbEmpNationality.TabIndex = 70;
            this.lbEmpNationality.Text = "Nationality:";
            // 
            // tbxEmpNationality
            // 
            this.tbxEmpNationality.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmpNationality.Location = new System.Drawing.Point(165, 418);
            this.tbxEmpNationality.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmpNationality.Name = "tbxEmpNationality";
            this.tbxEmpNationality.Size = new System.Drawing.Size(161, 31);
            this.tbxEmpNationality.TabIndex = 71;
            // 
            // dtpEmpStartDate
            // 
            this.dtpEmpStartDate.Location = new System.Drawing.Point(933, 341);
            this.dtpEmpStartDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpEmpStartDate.Name = "dtpEmpStartDate";
            this.dtpEmpStartDate.Size = new System.Drawing.Size(208, 31);
            this.dtpEmpStartDate.TabIndex = 75;
            // 
            // lbEmpStartDate
            // 
            this.lbEmpStartDate.AutoSize = true;
            this.lbEmpStartDate.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpStartDate.Location = new System.Drawing.Point(828, 345);
            this.lbEmpStartDate.Name = "lbEmpStartDate";
            this.lbEmpStartDate.Size = new System.Drawing.Size(91, 25);
            this.lbEmpStartDate.TabIndex = 74;
            this.lbEmpStartDate.Text = "Start date:";
            // 
            // tbxEmpEndDate
            // 
            this.tbxEmpEndDate.Location = new System.Drawing.Point(934, 439);
            this.tbxEmpEndDate.Name = "tbxEmpEndDate";
            this.tbxEmpEndDate.Size = new System.Drawing.Size(208, 31);
            this.tbxEmpEndDate.TabIndex = 78;
            // 
            // lbEmpNewEndDate
            // 
            this.lbEmpNewEndDate.AutoSize = true;
            this.lbEmpNewEndDate.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpNewEndDate.Location = new System.Drawing.Point(795, 442);
            this.lbEmpNewEndDate.Name = "lbEmpNewEndDate";
            this.lbEmpNewEndDate.Size = new System.Drawing.Size(124, 25);
            this.lbEmpNewEndDate.TabIndex = 79;
            this.lbEmpNewEndDate.Text = "New end date:";
            // 
            // dtpEmpEndDate
            // 
            this.dtpEmpEndDate.Location = new System.Drawing.Point(933, 389);
            this.dtpEmpEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpEmpEndDate.Name = "dtpEmpEndDate";
            this.dtpEmpEndDate.Size = new System.Drawing.Size(208, 31);
            this.dtpEmpEndDate.TabIndex = 83;
            // 
            // lbEmpEndDate
            // 
            this.lbEmpEndDate.AutoSize = true;
            this.lbEmpEndDate.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpEndDate.Location = new System.Drawing.Point(835, 394);
            this.lbEmpEndDate.Name = "lbEmpEndDate";
            this.lbEmpEndDate.Size = new System.Drawing.Size(84, 25);
            this.lbEmpEndDate.TabIndex = 82;
            this.lbEmpEndDate.Text = "End date:";
            // 
            // cbxEmpIndefiniteContract
            // 
            this.cbxEmpIndefiniteContract.AutoSize = true;
            this.cbxEmpIndefiniteContract.Location = new System.Drawing.Point(961, 489);
            this.cbxEmpIndefiniteContract.Name = "cbxEmpIndefiniteContract";
            this.cbxEmpIndefiniteContract.Size = new System.Drawing.Size(181, 29);
            this.cbxEmpIndefiniteContract.TabIndex = 84;
            this.cbxEmpIndefiniteContract.Text = "Indefinite contract";
            this.cbxEmpIndefiniteContract.UseVisualStyleBackColor = true;
            // 
            // EditEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1310, 726);
            this.Controls.Add(this.cbxEmpIndefiniteContract);
            this.Controls.Add(this.dtpEmpEndDate);
            this.Controls.Add(this.lbEmpEndDate);
            this.Controls.Add(this.lbEmpNewEndDate);
            this.Controls.Add(this.tbxEmpEndDate);
            this.Controls.Add(this.dtpEmpStartDate);
            this.Controls.Add(this.lbEmpStartDate);
            this.Controls.Add(this.lbEmpNationality);
            this.Controls.Add(this.tbxEmpNationality);
            this.Controls.Add(this.cbEmConRelation);
            this.Controls.Add(this.lbEmConRelation);
            this.Controls.Add(this.lbEmployeeInfo);
            this.Controls.Add(this.btnEditEmpoyee);
            this.Controls.Add(this.lbEmpPersonalInfo);
            this.Controls.Add(this.tbxEmConName);
            this.Controls.Add(this.lbEmpFname);
            this.Controls.Add(this.lbEmConName);
            this.Controls.Add(this.tbxEmpFname);
            this.Controls.Add(this.tbxEmConEmail);
            this.Controls.Add(this.lbEmpLname);
            this.Controls.Add(this.lbEmConEmail);
            this.Controls.Add(this.tbxEmpLname);
            this.Controls.Add(this.tbxEmConPhone);
            this.Controls.Add(this.lbEmployeeAddress);
            this.Controls.Add(this.lbEmConPhone);
            this.Controls.Add(this.lbEmpPhone);
            this.Controls.Add(this.lbEmpEmConDetails);
            this.Controls.Add(this.tbxEmpPhone);
            this.Controls.Add(this.lbEmpBsn);
            this.Controls.Add(this.lbEmpHourlyWages);
            this.Controls.Add(this.tbxEmpBsn);
            this.Controls.Add(this.lbEmpDateOfBirth);
            this.Controls.Add(this.nudEmpHourlyWages);
            this.Controls.Add(this.lbEmpEmployementType);
            this.Controls.Add(this.cbEmpDepartment);
            this.Controls.Add(this.tbxEmpAddressPostCode);
            this.Controls.Add(this.lbEmpDepartment);
            this.Controls.Add(this.dtpEmpDateOfBirth);
            this.Controls.Add(this.cbEmpEmploymentType);
            this.Controls.Add(this.lbEmpAddressCountry);
            this.Controls.Add(this.lbEmpJobSpec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbEmpAddressStreet);
            this.Controls.Add(this.lbEmpAddressPostCode);
            this.Controls.Add(this.lbEmpEmail);
            this.Controls.Add(this.tbxEmpAddressStreet);
            this.Controls.Add(this.tbxEmpAddressCountry);
            this.Controls.Add(this.tbxEmpAddressCity);
            this.Controls.Add(this.tbxEmpEmail);
            this.Controls.Add(this.cbEmpGender);
            this.Controls.Add(this.lbEmpAddressCity);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EditEmployeeForm";
            this.Text = "EditEmployeeForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditEmployeeForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpHourlyWages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEditEmpoyee;
        private System.Windows.Forms.Label lbEmployeeInfo;
        private System.Windows.Forms.ComboBox cbEmConRelation;
        private System.Windows.Forms.Label lbEmConRelation;
        private System.Windows.Forms.TextBox tbxEmConName;
        private System.Windows.Forms.Label lbEmConName;
        private System.Windows.Forms.TextBox tbxEmConEmail;
        private System.Windows.Forms.Label lbEmConEmail;
        private System.Windows.Forms.TextBox tbxEmConPhone;
        private System.Windows.Forms.Label lbEmConPhone;
        private System.Windows.Forms.Label lbEmpEmConDetails;
        private System.Windows.Forms.Label lbEmpBsn;
        private System.Windows.Forms.TextBox tbxEmpBsn;
        private System.Windows.Forms.NumericUpDown nudEmpHourlyWages;
        private System.Windows.Forms.ComboBox cbEmpDepartment;
        private System.Windows.Forms.Label lbEmpDepartment;
        private System.Windows.Forms.ComboBox cbEmpEmploymentType;
        private System.Windows.Forms.Label lbEmpJobSpec;
        private System.Windows.Forms.Label lbEmpAddressStreet;
        private System.Windows.Forms.Label lbEmpPersonalInfo;
        private System.Windows.Forms.TextBox tbxEmpAddressStreet;
        private System.Windows.Forms.TextBox tbxEmpAddressCity;
        private System.Windows.Forms.ComboBox cbEmpGender;
        private System.Windows.Forms.Label lbEmpAddressCity;
        private System.Windows.Forms.TextBox tbxEmpEmail;
        private System.Windows.Forms.TextBox tbxEmpAddressCountry;
        private System.Windows.Forms.Label lbEmpEmail;
        private System.Windows.Forms.Label lbEmpAddressPostCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbEmpAddressCountry;
        private System.Windows.Forms.DateTimePicker dtpEmpDateOfBirth;
        private System.Windows.Forms.TextBox tbxEmpAddressPostCode;
        private System.Windows.Forms.Label lbEmpEmployementType;
        private System.Windows.Forms.Label lbEmpDateOfBirth;
        private System.Windows.Forms.Label lbEmpHourlyWages;
        private System.Windows.Forms.TextBox tbxEmpPhone;
        private System.Windows.Forms.Label lbEmpPhone;
        private System.Windows.Forms.Label lbEmployeeAddress;
        private System.Windows.Forms.TextBox tbxEmpLname;
        private System.Windows.Forms.Label lbEmpLname;
        private System.Windows.Forms.TextBox tbxEmpFname;
        private System.Windows.Forms.Label lbEmpFname;
        private System.Windows.Forms.Label lbEmpNationality;
        private System.Windows.Forms.TextBox tbxEmpNationality;
        private System.Windows.Forms.DateTimePicker dtpEmpStartDate;
        private System.Windows.Forms.Label lbEmpStartDate;
        private System.Windows.Forms.TextBox tbxEmpEndDate;
        private System.Windows.Forms.Label lbEmpNewEndDate;
        private System.Windows.Forms.DateTimePicker dtpEmpEndDate;
        private System.Windows.Forms.Label lbEmpEndDate;
        private System.Windows.Forms.CheckBox cbxEmpIndefiniteContract;
    }
}