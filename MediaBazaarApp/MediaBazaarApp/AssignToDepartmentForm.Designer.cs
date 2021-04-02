
namespace MediaBazaarApp
{
    partial class AssignToDepartmentForm
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
            this.lbAdditionalInfo = new System.Windows.Forms.Label();
            this.btnChangeDepartment = new System.Windows.Forms.Button();
            this.gbxChangeDepartment = new System.Windows.Forms.GroupBox();
            this.lbChooseNewDep = new System.Windows.Forms.Label();
            this.btnApplyChanges = new System.Windows.Forms.Button();
            this.cbNewDep = new System.Windows.Forms.ComboBox();
            this.lbxDepEmp = new System.Windows.Forms.ListBox();
            this.lbInfo = new System.Windows.Forms.Label();
            this.gbxChangeDepartment.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAdditionalInfo
            // 
            this.lbAdditionalInfo.AutoSize = true;
            this.lbAdditionalInfo.Location = new System.Drawing.Point(344, 85);
            this.lbAdditionalInfo.Name = "lbAdditionalInfo";
            this.lbAdditionalInfo.Size = new System.Drawing.Size(577, 20);
            this.lbAdditionalInfo.TabIndex = 14;
            this.lbAdditionalInfo.Text = "(If you successfully change the employee\'s department, the line becomes green) ";
            // 
            // btnChangeDepartment
            // 
            this.btnChangeDepartment.Location = new System.Drawing.Point(711, 160);
            this.btnChangeDepartment.Name = "btnChangeDepartment";
            this.btnChangeDepartment.Size = new System.Drawing.Size(182, 52);
            this.btnChangeDepartment.TabIndex = 13;
            this.btnChangeDepartment.Text = "Change department";
            this.btnChangeDepartment.UseVisualStyleBackColor = true;
            // 
            // gbxChangeDepartment
            // 
            this.gbxChangeDepartment.Controls.Add(this.lbChooseNewDep);
            this.gbxChangeDepartment.Controls.Add(this.btnApplyChanges);
            this.gbxChangeDepartment.Controls.Add(this.cbNewDep);
            this.gbxChangeDepartment.Location = new System.Drawing.Point(711, 264);
            this.gbxChangeDepartment.Name = "gbxChangeDepartment";
            this.gbxChangeDepartment.Size = new System.Drawing.Size(455, 269);
            this.gbxChangeDepartment.TabIndex = 12;
            this.gbxChangeDepartment.TabStop = false;
            this.gbxChangeDepartment.Text = "Change department";
            // 
            // lbChooseNewDep
            // 
            this.lbChooseNewDep.AutoSize = true;
            this.lbChooseNewDep.Location = new System.Drawing.Point(135, 52);
            this.lbChooseNewDep.Name = "lbChooseNewDep";
            this.lbChooseNewDep.Size = new System.Drawing.Size(187, 20);
            this.lbChooseNewDep.TabIndex = 1;
            this.lbChooseNewDep.Text = "Choose new department:";
            // 
            // btnApplyChanges
            // 
            this.btnApplyChanges.Location = new System.Drawing.Point(137, 165);
            this.btnApplyChanges.Name = "btnApplyChanges";
            this.btnApplyChanges.Size = new System.Drawing.Size(187, 55);
            this.btnApplyChanges.TabIndex = 6;
            this.btnApplyChanges.Text = "Apply changes";
            this.btnApplyChanges.UseVisualStyleBackColor = true;
            // 
            // cbNewDep
            // 
            this.cbNewDep.FormattingEnabled = true;
            this.cbNewDep.Location = new System.Drawing.Point(139, 103);
            this.cbNewDep.Name = "cbNewDep";
            this.cbNewDep.Size = new System.Drawing.Size(185, 28);
            this.cbNewDep.TabIndex = 0;
            // 
            // lbxDepEmp
            // 
            this.lbxDepEmp.FormattingEnabled = true;
            this.lbxDepEmp.ItemHeight = 20;
            this.lbxDepEmp.Location = new System.Drawing.Point(35, 149);
            this.lbxDepEmp.Name = "lbxDepEmp";
            this.lbxDepEmp.Size = new System.Drawing.Size(641, 384);
            this.lbxDepEmp.TabIndex = 11;
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.Location = new System.Drawing.Point(285, 48);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(675, 25);
            this.lbInfo.TabIndex = 10;
            this.lbInfo.Text = "This department has employees, you should change their department";
            // 
            // AssignToDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 624);
            this.Controls.Add(this.lbAdditionalInfo);
            this.Controls.Add(this.btnChangeDepartment);
            this.Controls.Add(this.gbxChangeDepartment);
            this.Controls.Add(this.lbxDepEmp);
            this.Controls.Add(this.lbInfo);
            this.Name = "AssignToDepartmentForm";
            this.Text = "AssignToDepartmentForm";
            this.gbxChangeDepartment.ResumeLayout(false);
            this.gbxChangeDepartment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAdditionalInfo;
        private System.Windows.Forms.Button btnChangeDepartment;
        private System.Windows.Forms.GroupBox gbxChangeDepartment;
        private System.Windows.Forms.Label lbChooseNewDep;
        private System.Windows.Forms.Button btnApplyChanges;
        private System.Windows.Forms.ComboBox cbNewDep;
        private System.Windows.Forms.ListBox lbxDepEmp;
        private System.Windows.Forms.Label lbInfo;
    }
}