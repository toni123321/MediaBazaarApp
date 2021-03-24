
namespace MediaBazaarApp
{
    partial class ManageAttendanceForm
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
            this.lbxAllShifts = new System.Windows.Forms.ListBox();
            this.lbxUnattendedShifts = new System.Windows.Forms.ListBox();
            this.btnUnattended = new System.Windows.Forms.Button();
            this.btnClearSelected = new System.Windows.Forms.Button();
            this.lbEmpInfo = new System.Windows.Forms.Label();
            this.lbAllShiftsInfo = new System.Windows.Forms.Label();
            this.lbUnattendedShiftsInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxAllShifts
            // 
            this.lbxAllShifts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxAllShifts.FormattingEnabled = true;
            this.lbxAllShifts.HorizontalScrollbar = true;
            this.lbxAllShifts.ItemHeight = 18;
            this.lbxAllShifts.Location = new System.Drawing.Point(32, 100);
            this.lbxAllShifts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxAllShifts.Name = "lbxAllShifts";
            this.lbxAllShifts.Size = new System.Drawing.Size(491, 364);
            this.lbxAllShifts.TabIndex = 0;
            // 
            // lbxUnattendedShifts
            // 
            this.lbxUnattendedShifts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxUnattendedShifts.FormattingEnabled = true;
            this.lbxUnattendedShifts.HorizontalScrollbar = true;
            this.lbxUnattendedShifts.ItemHeight = 18;
            this.lbxUnattendedShifts.Location = new System.Drawing.Point(629, 100);
            this.lbxUnattendedShifts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxUnattendedShifts.Name = "lbxUnattendedShifts";
            this.lbxUnattendedShifts.Size = new System.Drawing.Size(491, 364);
            this.lbxUnattendedShifts.TabIndex = 1;
            // 
            // btnUnattended
            // 
            this.btnUnattended.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnattended.Location = new System.Drawing.Point(324, 493);
            this.btnUnattended.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUnattended.Name = "btnUnattended";
            this.btnUnattended.Size = new System.Drawing.Size(199, 58);
            this.btnUnattended.TabIndex = 2;
            this.btnUnattended.Text = "Didn\'t attend";
            this.btnUnattended.UseVisualStyleBackColor = true;
            // 
            // btnClearSelected
            // 
            this.btnClearSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSelected.Location = new System.Drawing.Point(32, 493);
            this.btnClearSelected.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearSelected.Name = "btnClearSelected";
            this.btnClearSelected.Size = new System.Drawing.Size(199, 58);
            this.btnClearSelected.TabIndex = 3;
            this.btnClearSelected.Text = "Unmark selected";
            this.btnClearSelected.UseVisualStyleBackColor = true;
            // 
            // lbEmpInfo
            // 
            this.lbEmpInfo.AutoSize = true;
            this.lbEmpInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpInfo.Location = new System.Drawing.Point(479, 25);
            this.lbEmpInfo.Name = "lbEmpInfo";
            this.lbEmpInfo.Size = new System.Drawing.Size(165, 18);
            this.lbEmpInfo.TabIndex = 4;
            this.lbEmpInfo.Text = "Employee with Id:(id)";
            // 
            // lbAllShiftsInfo
            // 
            this.lbAllShiftsInfo.AutoSize = true;
            this.lbAllShiftsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAllShiftsInfo.Location = new System.Drawing.Point(237, 67);
            this.lbAllShiftsInfo.Name = "lbAllShiftsInfo";
            this.lbAllShiftsInfo.Size = new System.Drawing.Size(72, 18);
            this.lbAllShiftsInfo.TabIndex = 5;
            this.lbAllShiftsInfo.Text = "All shifts";
            // 
            // lbUnattendedShiftsInfo
            // 
            this.lbUnattendedShiftsInfo.AutoSize = true;
            this.lbUnattendedShiftsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnattendedShiftsInfo.Location = new System.Drawing.Point(824, 67);
            this.lbUnattendedShiftsInfo.Name = "lbUnattendedShiftsInfo";
            this.lbUnattendedShiftsInfo.Size = new System.Drawing.Size(139, 18);
            this.lbUnattendedShiftsInfo.TabIndex = 6;
            this.lbUnattendedShiftsInfo.Text = "Unattended shifts";
            // 
            // ManageAttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1180, 625);
            this.Controls.Add(this.lbUnattendedShiftsInfo);
            this.Controls.Add(this.lbAllShiftsInfo);
            this.Controls.Add(this.lbEmpInfo);
            this.Controls.Add(this.btnClearSelected);
            this.Controls.Add(this.btnUnattended);
            this.Controls.Add(this.lbxUnattendedShifts);
            this.Controls.Add(this.lbxAllShifts);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ManageAttendanceForm";
            this.Text = "ManageAttendanceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxAllShifts;
        private System.Windows.Forms.ListBox lbxUnattendedShifts;
        private System.Windows.Forms.Button btnUnattended;
        private System.Windows.Forms.Button btnClearSelected;
        private System.Windows.Forms.Label lbEmpInfo;
        private System.Windows.Forms.Label lbAllShiftsInfo;
        private System.Windows.Forms.Label lbUnattendedShiftsInfo;
    }
}