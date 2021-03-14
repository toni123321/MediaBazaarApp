
namespace MediaBazaarApp
{
    partial class AssignWorkShiftsManuallyForm
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
            this.lbEmpInfo = new System.Windows.Forms.Label();
            this.lbShiftType = new System.Windows.Forms.Label();
            this.lbShiftDate = new System.Windows.Forms.Label();
            this.cbShiftType = new System.Windows.Forms.ComboBox();
            this.dtpShiftDate = new System.Windows.Forms.DateTimePicker();
            this.btnAssign = new System.Windows.Forms.Button();
            this.gbxAssignShiftManually = new System.Windows.Forms.GroupBox();
            this.lbWFH = new System.Windows.Forms.Label();
            this.cbWFH = new System.Windows.Forms.CheckBox();
            this.gbxAssignShiftManually.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbEmpInfo
            // 
            this.lbEmpInfo.AutoSize = true;
            this.lbEmpInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpInfo.Location = new System.Drawing.Point(380, 85);
            this.lbEmpInfo.Name = "lbEmpInfo";
            this.lbEmpInfo.Size = new System.Drawing.Size(165, 18);
            this.lbEmpInfo.TabIndex = 0;
            this.lbEmpInfo.Text = "Employee with Id:(id)";
            // 
            // lbShiftType
            // 
            this.lbShiftType.AutoSize = true;
            this.lbShiftType.Location = new System.Drawing.Point(79, 67);
            this.lbShiftType.Name = "lbShiftType";
            this.lbShiftType.Size = new System.Drawing.Size(72, 18);
            this.lbShiftType.TabIndex = 1;
            this.lbShiftType.Text = "Shift type:";
            // 
            // lbShiftDate
            // 
            this.lbShiftDate.AutoSize = true;
            this.lbShiftDate.Location = new System.Drawing.Point(31, 121);
            this.lbShiftDate.Name = "lbShiftDate";
            this.lbShiftDate.Size = new System.Drawing.Size(120, 18);
            this.lbShiftDate.TabIndex = 3;
            this.lbShiftDate.Text = "Date for the shift:";
            // 
            // cbShiftType
            // 
            this.cbShiftType.FormattingEnabled = true;
            this.cbShiftType.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening"});
            this.cbShiftType.Location = new System.Drawing.Point(171, 64);
            this.cbShiftType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbShiftType.Name = "cbShiftType";
            this.cbShiftType.Size = new System.Drawing.Size(224, 26);
            this.cbShiftType.TabIndex = 5;
            this.cbShiftType.Text = "Choose shift type";
            // 
            // dtpShiftDate
            // 
            this.dtpShiftDate.Location = new System.Drawing.Point(171, 121);
            this.dtpShiftDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpShiftDate.Name = "dtpShiftDate";
            this.dtpShiftDate.Size = new System.Drawing.Size(224, 24);
            this.dtpShiftDate.TabIndex = 6;
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(170, 201);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(225, 36);
            this.btnAssign.TabIndex = 7;
            this.btnAssign.Text = "Assign shift to employee";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // gbxAssignShiftManually
            // 
            this.gbxAssignShiftManually.Controls.Add(this.cbWFH);
            this.gbxAssignShiftManually.Controls.Add(this.lbWFH);
            this.gbxAssignShiftManually.Controls.Add(this.btnAssign);
            this.gbxAssignShiftManually.Controls.Add(this.lbShiftType);
            this.gbxAssignShiftManually.Controls.Add(this.dtpShiftDate);
            this.gbxAssignShiftManually.Controls.Add(this.lbShiftDate);
            this.gbxAssignShiftManually.Controls.Add(this.cbShiftType);
            this.gbxAssignShiftManually.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAssignShiftManually.Location = new System.Drawing.Point(234, 130);
            this.gbxAssignShiftManually.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxAssignShiftManually.Name = "gbxAssignShiftManually";
            this.gbxAssignShiftManually.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxAssignShiftManually.Size = new System.Drawing.Size(432, 257);
            this.gbxAssignShiftManually.TabIndex = 8;
            this.gbxAssignShiftManually.TabStop = false;
            this.gbxAssignShiftManually.Text = "Assign work shift";
            // 
            // lbWFH
            // 
            this.lbWFH.AutoSize = true;
            this.lbWFH.Location = new System.Drawing.Point(6, 158);
            this.lbWFH.Name = "lbWFH";
            this.lbWFH.Size = new System.Drawing.Size(0, 18);
            this.lbWFH.TabIndex = 8;
            // 
            // cbWFH
            // 
            this.cbWFH.AutoSize = true;
            this.cbWFH.Location = new System.Drawing.Point(171, 158);
            this.cbWFH.Name = "cbWFH";
            this.cbWFH.Size = new System.Drawing.Size(163, 22);
            this.cbWFH.TabIndex = 9;
            this.cbWFH.Text = "Working from home";
            this.cbWFH.UseVisualStyleBackColor = true;
            // 
            // AssignWorkShiftsManuallyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 506);
            this.Controls.Add(this.gbxAssignShiftManually);
            this.Controls.Add(this.lbEmpInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AssignWorkShiftsManuallyForm";
            this.Text = "AssignWorkShiftsManuallyForm";
            this.gbxAssignShiftManually.ResumeLayout(false);
            this.gbxAssignShiftManually.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEmpInfo;
        private System.Windows.Forms.Label lbShiftType;
        private System.Windows.Forms.Label lbShiftDate;
        private System.Windows.Forms.ComboBox cbShiftType;
        private System.Windows.Forms.DateTimePicker dtpShiftDate;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.GroupBox gbxAssignShiftManually;
        private System.Windows.Forms.CheckBox cbWFH;
        private System.Windows.Forms.Label lbWFH;
    }
}