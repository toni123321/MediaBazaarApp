
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
            this.gbxEditEmployee = new System.Windows.Forms.GroupBox();
            this.cbEmpHourlyWages = new System.Windows.Forms.ComboBox();
            this.cbEmpPosition = new System.Windows.Forms.ComboBox();
            this.cbEmpEmploymentType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbEmpAddressStreet = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.btnEditEmpoyee = new System.Windows.Forms.Button();
            this.lbEmpEmployementType = new System.Windows.Forms.Label();
            this.lbEmpPosition = new System.Windows.Forms.Label();
            this.lbEmpDateOfBirth = new System.Windows.Forms.Label();
            this.lbEmpHourlyWages = new System.Windows.Forms.Label();
            this.tbxEmpPhone = new System.Windows.Forms.TextBox();
            this.lbEmpPhone = new System.Windows.Forms.Label();
            this.lbEmployeeAddress = new System.Windows.Forms.Label();
            this.tbxEmpLname = new System.Windows.Forms.TextBox();
            this.lbEmpLname = new System.Windows.Forms.Label();
            this.tbxEmpFname = new System.Windows.Forms.TextBox();
            this.lbEmpFname = new System.Windows.Forms.Label();
            this.lbEmployeeInfo = new System.Windows.Forms.Label();
            this.gbxEditEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxEditEmployee
            // 
            this.gbxEditEmployee.Controls.Add(this.cbEmpHourlyWages);
            this.gbxEditEmployee.Controls.Add(this.cbEmpPosition);
            this.gbxEditEmployee.Controls.Add(this.cbEmpEmploymentType);
            this.gbxEditEmployee.Controls.Add(this.label5);
            this.gbxEditEmployee.Controls.Add(this.lbEmpAddressStreet);
            this.gbxEditEmployee.Controls.Add(this.label4);
            this.gbxEditEmployee.Controls.Add(this.tbxEmpAddressStreet);
            this.gbxEditEmployee.Controls.Add(this.tbxEmpAddressCity);
            this.gbxEditEmployee.Controls.Add(this.cbEmpGender);
            this.gbxEditEmployee.Controls.Add(this.lbEmpAddressCity);
            this.gbxEditEmployee.Controls.Add(this.tbxEmpEmail);
            this.gbxEditEmployee.Controls.Add(this.tbxEmpAddressCountry);
            this.gbxEditEmployee.Controls.Add(this.lbEmpEmail);
            this.gbxEditEmployee.Controls.Add(this.lbEmpAddressPostCode);
            this.gbxEditEmployee.Controls.Add(this.label1);
            this.gbxEditEmployee.Controls.Add(this.lbEmpAddressCountry);
            this.gbxEditEmployee.Controls.Add(this.dtpEmpDateOfBirth);
            this.gbxEditEmployee.Controls.Add(this.tbxEmpAddressPostCode);
            this.gbxEditEmployee.Controls.Add(this.btnEditEmpoyee);
            this.gbxEditEmployee.Controls.Add(this.lbEmpEmployementType);
            this.gbxEditEmployee.Controls.Add(this.lbEmpPosition);
            this.gbxEditEmployee.Controls.Add(this.lbEmpDateOfBirth);
            this.gbxEditEmployee.Controls.Add(this.lbEmpHourlyWages);
            this.gbxEditEmployee.Controls.Add(this.tbxEmpPhone);
            this.gbxEditEmployee.Controls.Add(this.lbEmpPhone);
            this.gbxEditEmployee.Controls.Add(this.lbEmployeeAddress);
            this.gbxEditEmployee.Controls.Add(this.tbxEmpLname);
            this.gbxEditEmployee.Controls.Add(this.lbEmpLname);
            this.gbxEditEmployee.Controls.Add(this.tbxEmpFname);
            this.gbxEditEmployee.Controls.Add(this.lbEmpFname);
            this.gbxEditEmployee.Location = new System.Drawing.Point(125, 49);
            this.gbxEditEmployee.Name = "gbxEditEmployee";
            this.gbxEditEmployee.Size = new System.Drawing.Size(655, 491);
            this.gbxEditEmployee.TabIndex = 1;
            this.gbxEditEmployee.TabStop = false;
            this.gbxEditEmployee.Text = "Edit employee";
            // 
            // cbEmpHourlyWages
            // 
            this.cbEmpHourlyWages.FormattingEnabled = true;
            this.cbEmpHourlyWages.Location = new System.Drawing.Point(142, 356);
            this.cbEmpHourlyWages.Name = "cbEmpHourlyWages";
            this.cbEmpHourlyWages.Size = new System.Drawing.Size(160, 24);
            this.cbEmpHourlyWages.TabIndex = 36;
            // 
            // cbEmpPosition
            // 
            this.cbEmpPosition.FormattingEnabled = true;
            this.cbEmpPosition.Location = new System.Drawing.Point(142, 318);
            this.cbEmpPosition.Name = "cbEmpPosition";
            this.cbEmpPosition.Size = new System.Drawing.Size(160, 24);
            this.cbEmpPosition.TabIndex = 35;
            // 
            // cbEmpEmploymentType
            // 
            this.cbEmpEmploymentType.FormattingEnabled = true;
            this.cbEmpEmploymentType.Items.AddRange(new object[] {
            "Administration",
            "Management",
            "Depot worker",
            "Shop employee"});
            this.cbEmpEmploymentType.Location = new System.Drawing.Point(143, 279);
            this.cbEmpEmploymentType.Name = "cbEmpEmploymentType";
            this.cbEmpEmploymentType.Size = new System.Drawing.Size(160, 24);
            this.cbEmpEmploymentType.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(101, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Job specifications:";
            // 
            // lbEmpAddressStreet
            // 
            this.lbEmpAddressStreet.AutoSize = true;
            this.lbEmpAddressStreet.Location = new System.Drawing.Point(382, 157);
            this.lbEmpAddressStreet.Name = "lbEmpAddressStreet";
            this.lbEmpAddressStreet.Size = new System.Drawing.Size(50, 17);
            this.lbEmpAddressStreet.TabIndex = 17;
            this.lbEmpAddressStreet.Text = "Street:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Personal information:";
            // 
            // tbxEmpAddressStreet
            // 
            this.tbxEmpAddressStreet.Location = new System.Drawing.Point(458, 154);
            this.tbxEmpAddressStreet.Name = "tbxEmpAddressStreet";
            this.tbxEmpAddressStreet.Size = new System.Drawing.Size(168, 22);
            this.tbxEmpAddressStreet.TabIndex = 5;
            // 
            // tbxEmpAddressCity
            // 
            this.tbxEmpAddressCity.Location = new System.Drawing.Point(458, 192);
            this.tbxEmpAddressCity.Name = "tbxEmpAddressCity";
            this.tbxEmpAddressCity.Size = new System.Drawing.Size(168, 22);
            this.tbxEmpAddressCity.TabIndex = 18;
            // 
            // cbEmpGender
            // 
            this.cbEmpGender.FormattingEnabled = true;
            this.cbEmpGender.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Other",
            "Not specified"});
            this.cbEmpGender.Location = new System.Drawing.Point(142, 192);
            this.cbEmpGender.Name = "cbEmpGender";
            this.cbEmpGender.Size = new System.Drawing.Size(161, 24);
            this.cbEmpGender.TabIndex = 30;
            this.cbEmpGender.Text = "Choose gender";
            // 
            // lbEmpAddressCity
            // 
            this.lbEmpAddressCity.AutoSize = true;
            this.lbEmpAddressCity.Location = new System.Drawing.Point(397, 195);
            this.lbEmpAddressCity.Name = "lbEmpAddressCity";
            this.lbEmpAddressCity.Size = new System.Drawing.Size(35, 17);
            this.lbEmpAddressCity.TabIndex = 19;
            this.lbEmpAddressCity.Text = "City:";
            // 
            // tbxEmpEmail
            // 
            this.tbxEmpEmail.Location = new System.Drawing.Point(458, 71);
            this.tbxEmpEmail.Name = "tbxEmpEmail";
            this.tbxEmpEmail.Size = new System.Drawing.Size(168, 22);
            this.tbxEmpEmail.TabIndex = 29;
            // 
            // tbxEmpAddressCountry
            // 
            this.tbxEmpAddressCountry.Location = new System.Drawing.Point(458, 232);
            this.tbxEmpAddressCountry.Name = "tbxEmpAddressCountry";
            this.tbxEmpAddressCountry.Size = new System.Drawing.Size(168, 22);
            this.tbxEmpAddressCountry.TabIndex = 20;
            // 
            // lbEmpEmail
            // 
            this.lbEmpEmail.AutoSize = true;
            this.lbEmpEmail.Location = new System.Drawing.Point(379, 74);
            this.lbEmpEmail.Name = "lbEmpEmail";
            this.lbEmpEmail.Size = new System.Drawing.Size(46, 17);
            this.lbEmpEmail.TabIndex = 28;
            this.lbEmpEmail.Text = "Email:";
            // 
            // lbEmpAddressPostCode
            // 
            this.lbEmpAddressPostCode.AutoSize = true;
            this.lbEmpAddressPostCode.Location = new System.Drawing.Point(359, 271);
            this.lbEmpAddressPostCode.Name = "lbEmpAddressPostCode";
            this.lbEmpAddressPostCode.Size = new System.Drawing.Size(73, 17);
            this.lbEmpAddressPostCode.TabIndex = 25;
            this.lbEmpAddressPostCode.Text = "PostCode:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Gender:";
            // 
            // lbEmpAddressCountry
            // 
            this.lbEmpAddressCountry.AutoSize = true;
            this.lbEmpAddressCountry.Location = new System.Drawing.Point(371, 235);
            this.lbEmpAddressCountry.Name = "lbEmpAddressCountry";
            this.lbEmpAddressCountry.Size = new System.Drawing.Size(61, 17);
            this.lbEmpAddressCountry.TabIndex = 21;
            this.lbEmpAddressCountry.Text = "Country:";
            // 
            // dtpEmpDateOfBirth
            // 
            this.dtpEmpDateOfBirth.Location = new System.Drawing.Point(142, 152);
            this.dtpEmpDateOfBirth.Name = "dtpEmpDateOfBirth";
            this.dtpEmpDateOfBirth.Size = new System.Drawing.Size(161, 22);
            this.dtpEmpDateOfBirth.TabIndex = 1;
            // 
            // tbxEmpAddressPostCode
            // 
            this.tbxEmpAddressPostCode.Location = new System.Drawing.Point(458, 268);
            this.tbxEmpAddressPostCode.Name = "tbxEmpAddressPostCode";
            this.tbxEmpAddressPostCode.Size = new System.Drawing.Size(168, 22);
            this.tbxEmpAddressPostCode.TabIndex = 24;
            // 
            // btnEditEmpoyee
            // 
            this.btnEditEmpoyee.Location = new System.Drawing.Point(240, 421);
            this.btnEditEmpoyee.Name = "btnEditEmpoyee";
            this.btnEditEmpoyee.Size = new System.Drawing.Size(192, 42);
            this.btnEditEmpoyee.TabIndex = 16;
            this.btnEditEmpoyee.Text = "Apply changes";
            this.btnEditEmpoyee.UseVisualStyleBackColor = true;
            // 
            // lbEmpEmployementType
            // 
            this.lbEmpEmployementType.AutoSize = true;
            this.lbEmpEmployementType.Location = new System.Drawing.Point(8, 282);
            this.lbEmpEmployementType.Name = "lbEmpEmployementType";
            this.lbEmpEmployementType.Size = new System.Drawing.Size(109, 17);
            this.lbEmpEmployementType.TabIndex = 14;
            this.lbEmpEmployementType.Text = "Eployment type:";
            // 
            // lbEmpPosition
            // 
            this.lbEmpPosition.AutoSize = true;
            this.lbEmpPosition.Location = new System.Drawing.Point(53, 318);
            this.lbEmpPosition.Name = "lbEmpPosition";
            this.lbEmpPosition.Size = new System.Drawing.Size(62, 17);
            this.lbEmpPosition.TabIndex = 12;
            this.lbEmpPosition.Text = "Position:";
            // 
            // lbEmpDateOfBirth
            // 
            this.lbEmpDateOfBirth.AutoSize = true;
            this.lbEmpDateOfBirth.Location = new System.Drawing.Point(26, 152);
            this.lbEmpDateOfBirth.Name = "lbEmpDateOfBirth";
            this.lbEmpDateOfBirth.Size = new System.Drawing.Size(90, 17);
            this.lbEmpDateOfBirth.TabIndex = 10;
            this.lbEmpDateOfBirth.Text = "Date of birth:";
            // 
            // lbEmpHourlyWages
            // 
            this.lbEmpHourlyWages.AutoSize = true;
            this.lbEmpHourlyWages.Location = new System.Drawing.Point(18, 356);
            this.lbEmpHourlyWages.Name = "lbEmpHourlyWages";
            this.lbEmpHourlyWages.Size = new System.Drawing.Size(97, 17);
            this.lbEmpHourlyWages.TabIndex = 8;
            this.lbEmpHourlyWages.Text = "Hourly wages:";
            // 
            // tbxEmpPhone
            // 
            this.tbxEmpPhone.Location = new System.Drawing.Point(458, 109);
            this.tbxEmpPhone.Name = "tbxEmpPhone";
            this.tbxEmpPhone.Size = new System.Drawing.Size(168, 22);
            this.tbxEmpPhone.TabIndex = 7;
            // 
            // lbEmpPhone
            // 
            this.lbEmpPhone.AutoSize = true;
            this.lbEmpPhone.Location = new System.Drawing.Point(379, 112);
            this.lbEmpPhone.Name = "lbEmpPhone";
            this.lbEmpPhone.Size = new System.Drawing.Size(53, 17);
            this.lbEmpPhone.TabIndex = 6;
            this.lbEmpPhone.Text = "Phone:";
            // 
            // lbEmployeeAddress
            // 
            this.lbEmployeeAddress.AutoSize = true;
            this.lbEmployeeAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmployeeAddress.Location = new System.Drawing.Point(432, 30);
            this.lbEmployeeAddress.Name = "lbEmployeeAddress";
            this.lbEmployeeAddress.Size = new System.Drawing.Size(121, 17);
            this.lbEmployeeAddress.TabIndex = 4;
            this.lbEmployeeAddress.Text = "Contact details:";
            // 
            // tbxEmpLname
            // 
            this.tbxEmpLname.Location = new System.Drawing.Point(143, 115);
            this.tbxEmpLname.Name = "tbxEmpLname";
            this.tbxEmpLname.Size = new System.Drawing.Size(160, 22);
            this.tbxEmpLname.TabIndex = 3;
            // 
            // lbEmpLname
            // 
            this.lbEmpLname.AutoSize = true;
            this.lbEmpLname.Location = new System.Drawing.Point(39, 115);
            this.lbEmpLname.Name = "lbEmpLname";
            this.lbEmpLname.Size = new System.Drawing.Size(78, 17);
            this.lbEmpLname.TabIndex = 2;
            this.lbEmpLname.Text = "Last name:";
            // 
            // tbxEmpFname
            // 
            this.tbxEmpFname.Location = new System.Drawing.Point(143, 68);
            this.tbxEmpFname.Name = "tbxEmpFname";
            this.tbxEmpFname.Size = new System.Drawing.Size(160, 22);
            this.tbxEmpFname.TabIndex = 1;
            // 
            // lbEmpFname
            // 
            this.lbEmpFname.AutoSize = true;
            this.lbEmpFname.Location = new System.Drawing.Point(39, 71);
            this.lbEmpFname.Name = "lbEmpFname";
            this.lbEmpFname.Size = new System.Drawing.Size(78, 17);
            this.lbEmpFname.TabIndex = 0;
            this.lbEmpFname.Text = "First name:";
            // 
            // lbEmployeeInfo
            // 
            this.lbEmployeeInfo.AutoSize = true;
            this.lbEmployeeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmployeeInfo.Location = new System.Drawing.Point(292, 26);
            this.lbEmployeeInfo.Name = "lbEmployeeInfo";
            this.lbEmployeeInfo.Size = new System.Drawing.Size(333, 20);
            this.lbEmployeeInfo.TabIndex = 2;
            this.lbEmployeeInfo.Text = "Profile details of employee with ID:(Id)";
            // 
            // EditEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 588);
            this.Controls.Add(this.lbEmployeeInfo);
            this.Controls.Add(this.gbxEditEmployee);
            this.Name = "EditEmployeeForm";
            this.Text = "EditEmployeeForm";
            this.gbxEditEmployee.ResumeLayout(false);
            this.gbxEditEmployee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxEditEmployee;
        private System.Windows.Forms.ComboBox cbEmpHourlyWages;
        private System.Windows.Forms.ComboBox cbEmpPosition;
        private System.Windows.Forms.ComboBox cbEmpEmploymentType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbEmpAddressStreet;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.Button btnEditEmpoyee;
        private System.Windows.Forms.Label lbEmpEmployementType;
        private System.Windows.Forms.Label lbEmpPosition;
        private System.Windows.Forms.Label lbEmpDateOfBirth;
        private System.Windows.Forms.Label lbEmpHourlyWages;
        private System.Windows.Forms.TextBox tbxEmpPhone;
        private System.Windows.Forms.Label lbEmpPhone;
        private System.Windows.Forms.Label lbEmployeeAddress;
        private System.Windows.Forms.TextBox tbxEmpLname;
        private System.Windows.Forms.Label lbEmpLname;
        private System.Windows.Forms.TextBox tbxEmpFname;
        private System.Windows.Forms.Label lbEmpFname;
        private System.Windows.Forms.Label lbEmployeeInfo;
    }
}