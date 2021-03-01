
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
            this.gbxAssignShiftManually.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbEmpInfo
            // 
            this.lbEmpInfo.AutoSize = true;
            this.lbEmpInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpInfo.Location = new System.Drawing.Point(338, 76);
            this.lbEmpInfo.Name = "lbEmpInfo";
            this.lbEmpInfo.Size = new System.Drawing.Size(165, 18);
            this.lbEmpInfo.TabIndex = 0;
            this.lbEmpInfo.Text = "Employee with Id:(id)";
            // 
            // lbShiftType
            // 
            this.lbShiftType.AutoSize = true;
            this.lbShiftType.Location = new System.Drawing.Point(61, 57);
            this.lbShiftType.Name = "lbShiftType";
            this.lbShiftType.Size = new System.Drawing.Size(72, 18);
            this.lbShiftType.TabIndex = 1;
            this.lbShiftType.Text = "Shift type:";
            // 
            // lbShiftDate
            // 
            this.lbShiftDate.AutoSize = true;
            this.lbShiftDate.Location = new System.Drawing.Point(15, 108);
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
            this.cbShiftType.Location = new System.Drawing.Point(152, 57);
            this.cbShiftType.Name = "cbShiftType";
            this.cbShiftType.Size = new System.Drawing.Size(200, 26);
            this.cbShiftType.TabIndex = 5;
            this.cbShiftType.Text = "Choose shift type";
            // 
            // dtpShiftDate
            // 
            this.dtpShiftDate.Location = new System.Drawing.Point(152, 108);
            this.dtpShiftDate.Name = "dtpShiftDate";
            this.dtpShiftDate.Size = new System.Drawing.Size(200, 24);
            this.dtpShiftDate.TabIndex = 6;
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(152, 165);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(200, 32);
            this.btnAssign.TabIndex = 7;
            this.btnAssign.Text = "Assign shift to employee";
            this.btnAssign.UseVisualStyleBackColor = true;
            // 
            // gbxAssignShiftManually
            // 
            this.gbxAssignShiftManually.Controls.Add(this.btnAssign);
            this.gbxAssignShiftManually.Controls.Add(this.lbShiftType);
            this.gbxAssignShiftManually.Controls.Add(this.dtpShiftDate);
            this.gbxAssignShiftManually.Controls.Add(this.lbShiftDate);
            this.gbxAssignShiftManually.Controls.Add(this.cbShiftType);
            this.gbxAssignShiftManually.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAssignShiftManually.Location = new System.Drawing.Point(208, 116);
            this.gbxAssignShiftManually.Name = "gbxAssignShiftManually";
            this.gbxAssignShiftManually.Size = new System.Drawing.Size(384, 229);
            this.gbxAssignShiftManually.TabIndex = 8;
            this.gbxAssignShiftManually.TabStop = false;
            this.gbxAssignShiftManually.Text = "Assign work shift";
            // 
            // AssignWorkShiftsManuallyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxAssignShiftManually);
            this.Controls.Add(this.lbEmpInfo);
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
    }
}