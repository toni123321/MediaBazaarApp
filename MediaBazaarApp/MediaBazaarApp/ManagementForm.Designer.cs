
namespace MediaBazaarApp
{
    partial class ManagementForm
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
            this.tabControlManagement = new System.Windows.Forms.TabControl();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbDateDayOfWeek = new System.Windows.Forms.Label();
            this.lbGreetingMsg = new System.Windows.Forms.Label();
            this.ViewStatisticsEmpTab = new System.Windows.Forms.TabPage();
            this.lbAvgWageEmpDepartment = new System.Windows.Forms.Label();
            this.lbxAvgWageEmpDepartment = new System.Windows.Forms.ListBox();
            this.tbxAvgWageEmp = new System.Windows.Forms.TextBox();
            this.lbAvgWageEmp = new System.Windows.Forms.Label();
            this.lbNrEmpPerDepartment = new System.Windows.Forms.Label();
            this.lbxNrEmpPerDepartment = new System.Windows.Forms.ListBox();
            this.tbxNrEmp = new System.Windows.Forms.TextBox();
            this.lbNrEmp = new System.Windows.Forms.Label();
            this.ViewStatisticsStocksTab = new System.Windows.Forms.TabPage();
            this.btnShowStockStatistics = new System.Windows.Forms.Button();
            this.cbStatisticType = new System.Windows.Forms.ComboBox();
            this.lbxAllStocksStatistics = new System.Windows.Forms.ListBox();
            this.tabControlManagement.SuspendLayout();
            this.HomeTab.SuspendLayout();
            this.ViewStatisticsEmpTab.SuspendLayout();
            this.ViewStatisticsStocksTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlManagement
            // 
            this.tabControlManagement.Controls.Add(this.HomeTab);
            this.tabControlManagement.Controls.Add(this.ViewStatisticsEmpTab);
            this.tabControlManagement.Controls.Add(this.ViewStatisticsStocksTab);
            this.tabControlManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlManagement.Location = new System.Drawing.Point(14, 13);
            this.tabControlManagement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlManagement.Name = "tabControlManagement";
            this.tabControlManagement.SelectedIndex = 0;
            this.tabControlManagement.Size = new System.Drawing.Size(983, 479);
            this.tabControlManagement.TabIndex = 0;
            // 
            // HomeTab
            // 
            this.HomeTab.Controls.Add(this.lbTime);
            this.HomeTab.Controls.Add(this.lbDateDayOfWeek);
            this.HomeTab.Controls.Add(this.lbGreetingMsg);
            this.HomeTab.Location = new System.Drawing.Point(4, 27);
            this.HomeTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Size = new System.Drawing.Size(975, 448);
            this.HomeTab.TabIndex = 2;
            this.HomeTab.Text = "Home";
            this.HomeTab.UseVisualStyleBackColor = true;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(117, 247);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(41, 18);
            this.lbTime.TabIndex = 9;
            this.lbTime.Text = "Time";
            // 
            // lbDateDayOfWeek
            // 
            this.lbDateDayOfWeek.AutoSize = true;
            this.lbDateDayOfWeek.Location = new System.Drawing.Point(117, 297);
            this.lbDateDayOfWeek.Name = "lbDateDayOfWeek";
            this.lbDateDayOfWeek.Size = new System.Drawing.Size(125, 18);
            this.lbDateDayOfWeek.TabIndex = 8;
            this.lbDateDayOfWeek.Text = "Date/Day of week";
            // 
            // lbGreetingMsg
            // 
            this.lbGreetingMsg.AutoSize = true;
            this.lbGreetingMsg.Location = new System.Drawing.Point(111, 97);
            this.lbGreetingMsg.Name = "lbGreetingMsg";
            this.lbGreetingMsg.Size = new System.Drawing.Size(129, 18);
            this.lbGreetingMsg.TabIndex = 5;
            this.lbGreetingMsg.Text = "Greeting message";
            // 
            // ViewStatisticsEmpTab
            // 
            this.ViewStatisticsEmpTab.Controls.Add(this.lbAvgWageEmpDepartment);
            this.ViewStatisticsEmpTab.Controls.Add(this.lbxAvgWageEmpDepartment);
            this.ViewStatisticsEmpTab.Controls.Add(this.tbxAvgWageEmp);
            this.ViewStatisticsEmpTab.Controls.Add(this.lbAvgWageEmp);
            this.ViewStatisticsEmpTab.Controls.Add(this.lbNrEmpPerDepartment);
            this.ViewStatisticsEmpTab.Controls.Add(this.lbxNrEmpPerDepartment);
            this.ViewStatisticsEmpTab.Controls.Add(this.tbxNrEmp);
            this.ViewStatisticsEmpTab.Controls.Add(this.lbNrEmp);
            this.ViewStatisticsEmpTab.Location = new System.Drawing.Point(4, 27);
            this.ViewStatisticsEmpTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ViewStatisticsEmpTab.Name = "ViewStatisticsEmpTab";
            this.ViewStatisticsEmpTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ViewStatisticsEmpTab.Size = new System.Drawing.Size(975, 448);
            this.ViewStatisticsEmpTab.TabIndex = 0;
            this.ViewStatisticsEmpTab.Text = "View statistics for employees";
            this.ViewStatisticsEmpTab.UseVisualStyleBackColor = true;
            // 
            // lbAvgWageEmpDepartment
            // 
            this.lbAvgWageEmpDepartment.AutoSize = true;
            this.lbAvgWageEmpDepartment.Location = new System.Drawing.Point(564, 108);
            this.lbAvgWageEmpDepartment.Name = "lbAvgWageEmpDepartment";
            this.lbAvgWageEmpDepartment.Size = new System.Drawing.Size(296, 18);
            this.lbAvgWageEmpDepartment.TabIndex = 15;
            this.lbAvgWageEmpDepartment.Text = "Average wage of employees per department";
            // 
            // lbxAvgWageEmpDepartment
            // 
            this.lbxAvgWageEmpDepartment.FormattingEnabled = true;
            this.lbxAvgWageEmpDepartment.ItemHeight = 18;
            this.lbxAvgWageEmpDepartment.Location = new System.Drawing.Point(533, 153);
            this.lbxAvgWageEmpDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxAvgWageEmpDepartment.Name = "lbxAvgWageEmpDepartment";
            this.lbxAvgWageEmpDepartment.Size = new System.Drawing.Size(391, 220);
            this.lbxAvgWageEmpDepartment.TabIndex = 14;
            // 
            // tbxAvgWageEmp
            // 
            this.tbxAvgWageEmp.Location = new System.Drawing.Point(760, 40);
            this.tbxAvgWageEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxAvgWageEmp.Name = "tbxAvgWageEmp";
            this.tbxAvgWageEmp.Size = new System.Drawing.Size(164, 24);
            this.tbxAvgWageEmp.TabIndex = 13;
            // 
            // lbAvgWageEmp
            // 
            this.lbAvgWageEmp.AutoSize = true;
            this.lbAvgWageEmp.Location = new System.Drawing.Point(498, 43);
            this.lbAvgWageEmp.Name = "lbAvgWageEmp";
            this.lbAvgWageEmp.Size = new System.Drawing.Size(189, 18);
            this.lbAvgWageEmp.TabIndex = 12;
            this.lbAvgWageEmp.Text = "Average wage of employee:";
            // 
            // lbNrEmpPerDepartment
            // 
            this.lbNrEmpPerDepartment.AutoSize = true;
            this.lbNrEmpPerDepartment.Location = new System.Drawing.Point(88, 108);
            this.lbNrEmpPerDepartment.Name = "lbNrEmpPerDepartment";
            this.lbNrEmpPerDepartment.Size = new System.Drawing.Size(257, 18);
            this.lbNrEmpPerDepartment.TabIndex = 11;
            this.lbNrEmpPerDepartment.Text = "Number of employees per department";
            // 
            // lbxNrEmpPerDepartment
            // 
            this.lbxNrEmpPerDepartment.FormattingEnabled = true;
            this.lbxNrEmpPerDepartment.ItemHeight = 18;
            this.lbxNrEmpPerDepartment.Location = new System.Drawing.Point(58, 153);
            this.lbxNrEmpPerDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxNrEmpPerDepartment.Name = "lbxNrEmpPerDepartment";
            this.lbxNrEmpPerDepartment.Size = new System.Drawing.Size(345, 220);
            this.lbxNrEmpPerDepartment.TabIndex = 10;
            // 
            // tbxNrEmp
            // 
            this.tbxNrEmp.Location = new System.Drawing.Point(240, 40);
            this.tbxNrEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxNrEmp.Name = "tbxNrEmp";
            this.tbxNrEmp.Size = new System.Drawing.Size(164, 24);
            this.tbxNrEmp.TabIndex = 9;
            // 
            // lbNrEmp
            // 
            this.lbNrEmp.AutoSize = true;
            this.lbNrEmp.Location = new System.Drawing.Point(29, 43);
            this.lbNrEmp.Name = "lbNrEmp";
            this.lbNrEmp.Size = new System.Drawing.Size(158, 18);
            this.lbNrEmp.TabIndex = 8;
            this.lbNrEmp.Text = "Number of employees:";
            // 
            // ViewStatisticsStocksTab
            // 
            this.ViewStatisticsStocksTab.Controls.Add(this.btnShowStockStatistics);
            this.ViewStatisticsStocksTab.Controls.Add(this.cbStatisticType);
            this.ViewStatisticsStocksTab.Controls.Add(this.lbxAllStocksStatistics);
            this.ViewStatisticsStocksTab.Location = new System.Drawing.Point(4, 27);
            this.ViewStatisticsStocksTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ViewStatisticsStocksTab.Name = "ViewStatisticsStocksTab";
            this.ViewStatisticsStocksTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ViewStatisticsStocksTab.Size = new System.Drawing.Size(975, 448);
            this.ViewStatisticsStocksTab.TabIndex = 1;
            this.ViewStatisticsStocksTab.Text = "View statistics for stocks";
            this.ViewStatisticsStocksTab.UseVisualStyleBackColor = true;
            // 
            // btnShowStockStatistics
            // 
            this.btnShowStockStatistics.Location = new System.Drawing.Point(594, 31);
            this.btnShowStockStatistics.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowStockStatistics.Name = "btnShowStockStatistics";
            this.btnShowStockStatistics.Size = new System.Drawing.Size(204, 40);
            this.btnShowStockStatistics.TabIndex = 8;
            this.btnShowStockStatistics.Text = "Show";
            this.btnShowStockStatistics.UseVisualStyleBackColor = true;
            // 
            // cbStatisticType
            // 
            this.cbStatisticType.FormattingEnabled = true;
            this.cbStatisticType.Items.AddRange(new object[] {
            "highest price",
            "lowest price",
            "biggest quantity",
            "smallest quantity",
            ""});
            this.cbStatisticType.Location = new System.Drawing.Point(177, 37);
            this.cbStatisticType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbStatisticType.Name = "cbStatisticType";
            this.cbStatisticType.Size = new System.Drawing.Size(324, 26);
            this.cbStatisticType.TabIndex = 7;
            this.cbStatisticType.Text = "Sort based on statistic type";
            this.cbStatisticType.SelectedIndexChanged += new System.EventHandler(this.cbStatisticType_SelectedIndexChanged);
            // 
            // lbxAllStocksStatistics
            // 
            this.lbxAllStocksStatistics.FormattingEnabled = true;
            this.lbxAllStocksStatistics.HorizontalScrollbar = true;
            this.lbxAllStocksStatistics.ItemHeight = 18;
            this.lbxAllStocksStatistics.Location = new System.Drawing.Point(177, 85);
            this.lbxAllStocksStatistics.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxAllStocksStatistics.Name = "lbxAllStocksStatistics";
            this.lbxAllStocksStatistics.Size = new System.Drawing.Size(620, 310);
            this.lbxAllStocksStatistics.TabIndex = 6;
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 506);
            this.Controls.Add(this.tabControlManagement);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ManagementForm";
            this.Text = "ManagementForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagementForm_FormClosed);
            this.tabControlManagement.ResumeLayout(false);
            this.HomeTab.ResumeLayout(false);
            this.HomeTab.PerformLayout();
            this.ViewStatisticsEmpTab.ResumeLayout(false);
            this.ViewStatisticsEmpTab.PerformLayout();
            this.ViewStatisticsStocksTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlManagement;
        private System.Windows.Forms.TabPage ViewStatisticsEmpTab;
        private System.Windows.Forms.TabPage ViewStatisticsStocksTab;
        private System.Windows.Forms.Label lbAvgWageEmpDepartment;
        private System.Windows.Forms.ListBox lbxAvgWageEmpDepartment;
        private System.Windows.Forms.TextBox tbxAvgWageEmp;
        private System.Windows.Forms.Label lbAvgWageEmp;
        private System.Windows.Forms.Label lbNrEmpPerDepartment;
        private System.Windows.Forms.ListBox lbxNrEmpPerDepartment;
        private System.Windows.Forms.TextBox tbxNrEmp;
        private System.Windows.Forms.Label lbNrEmp;
        private System.Windows.Forms.Button btnShowStockStatistics;
        private System.Windows.Forms.ComboBox cbStatisticType;
        private System.Windows.Forms.ListBox lbxAllStocksStatistics;
        private System.Windows.Forms.TabPage HomeTab;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbDateDayOfWeek;
        private System.Windows.Forms.Label lbGreetingMsg;
    }
}