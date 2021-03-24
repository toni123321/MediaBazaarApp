
namespace MediaBazaarApp
{
    partial class DepotWorkersForm
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
            this.tabControlDepotWorkers = new System.Windows.Forms.TabControl();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbDateDayOfWeek = new System.Windows.Forms.Label();
            this.lbGreetingMsg = new System.Windows.Forms.Label();
            this.MakeShelfRestockRequestsTab = new System.Windows.Forms.TabPage();
            this.btnSehflRestockRequestsClearSelected = new System.Windows.Forms.Button();
            this.btnShelftRestockRequestsMarkAsDone = new System.Windows.Forms.Button();
            this.btnShelftRestockRequestsDecline = new System.Windows.Forms.Button();
            this.lbxAllShelfRestockRequests = new System.Windows.Forms.ListBox();
            this.HistoryShelfRestockTab = new System.Windows.Forms.TabPage();
            this.lbHistoryShelfRestockRequests = new System.Windows.Forms.Label();
            this.lbxHistoryShelfRestockRequests = new System.Windows.Forms.ListBox();
            this.tabControlDepotWorkers.SuspendLayout();
            this.HomeTab.SuspendLayout();
            this.MakeShelfRestockRequestsTab.SuspendLayout();
            this.HistoryShelfRestockTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlDepotWorkers
            // 
            this.tabControlDepotWorkers.Controls.Add(this.HomeTab);
            this.tabControlDepotWorkers.Controls.Add(this.MakeShelfRestockRequestsTab);
            this.tabControlDepotWorkers.Controls.Add(this.HistoryShelfRestockTab);
            this.tabControlDepotWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlDepotWorkers.Location = new System.Drawing.Point(0, 13);
            this.tabControlDepotWorkers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlDepotWorkers.Name = "tabControlDepotWorkers";
            this.tabControlDepotWorkers.SelectedIndex = 0;
            this.tabControlDepotWorkers.Size = new System.Drawing.Size(1029, 601);
            this.tabControlDepotWorkers.TabIndex = 2;
            // 
            // HomeTab
            // 
            this.HomeTab.Controls.Add(this.lbTime);
            this.HomeTab.Controls.Add(this.lbDateDayOfWeek);
            this.HomeTab.Controls.Add(this.lbGreetingMsg);
            this.HomeTab.Location = new System.Drawing.Point(4, 27);
            this.HomeTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Size = new System.Drawing.Size(1021, 570);
            this.HomeTab.TabIndex = 3;
            this.HomeTab.Text = "Home";
            this.HomeTab.UseVisualStyleBackColor = true;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbTime.Location = new System.Drawing.Point(137, 292);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(41, 18);
            this.lbTime.TabIndex = 12;
            this.lbTime.Text = "Time";
            // 
            // lbDateDayOfWeek
            // 
            this.lbDateDayOfWeek.AutoSize = true;
            this.lbDateDayOfWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbDateDayOfWeek.Location = new System.Drawing.Point(137, 342);
            this.lbDateDayOfWeek.Name = "lbDateDayOfWeek";
            this.lbDateDayOfWeek.Size = new System.Drawing.Size(125, 18);
            this.lbDateDayOfWeek.TabIndex = 11;
            this.lbDateDayOfWeek.Text = "Date/Day of week";
            // 
            // lbGreetingMsg
            // 
            this.lbGreetingMsg.AutoSize = true;
            this.lbGreetingMsg.Location = new System.Drawing.Point(132, 142);
            this.lbGreetingMsg.Name = "lbGreetingMsg";
            this.lbGreetingMsg.Size = new System.Drawing.Size(129, 18);
            this.lbGreetingMsg.TabIndex = 10;
            this.lbGreetingMsg.Text = "Greeting message";
            // 
            // MakeShelfRestockRequestsTab
            // 
            this.MakeShelfRestockRequestsTab.Controls.Add(this.btnSehflRestockRequestsClearSelected);
            this.MakeShelfRestockRequestsTab.Controls.Add(this.btnShelftRestockRequestsMarkAsDone);
            this.MakeShelfRestockRequestsTab.Controls.Add(this.btnShelftRestockRequestsDecline);
            this.MakeShelfRestockRequestsTab.Controls.Add(this.lbxAllShelfRestockRequests);
            this.MakeShelfRestockRequestsTab.Location = new System.Drawing.Point(4, 27);
            this.MakeShelfRestockRequestsTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MakeShelfRestockRequestsTab.Name = "MakeShelfRestockRequestsTab";
            this.MakeShelfRestockRequestsTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MakeShelfRestockRequestsTab.Size = new System.Drawing.Size(1021, 570);
            this.MakeShelfRestockRequestsTab.TabIndex = 0;
            this.MakeShelfRestockRequestsTab.Text = "View incoming restock requests";
            this.MakeShelfRestockRequestsTab.UseVisualStyleBackColor = true;
            // 
            // btnSehflRestockRequestsClearSelected
            // 
            this.btnSehflRestockRequestsClearSelected.Location = new System.Drawing.Point(734, 450);
            this.btnSehflRestockRequestsClearSelected.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSehflRestockRequestsClearSelected.Name = "btnSehflRestockRequestsClearSelected";
            this.btnSehflRestockRequestsClearSelected.Size = new System.Drawing.Size(183, 49);
            this.btnSehflRestockRequestsClearSelected.TabIndex = 19;
            this.btnSehflRestockRequestsClearSelected.Text = "Unmark selected";
            this.btnSehflRestockRequestsClearSelected.UseVisualStyleBackColor = true;
            this.btnSehflRestockRequestsClearSelected.Click += new System.EventHandler(this.btnSehflRestockRequestsClearSelected_Click);
            // 
            // btnShelftRestockRequestsMarkAsDone
            // 
            this.btnShelftRestockRequestsMarkAsDone.Location = new System.Drawing.Point(157, 450);
            this.btnShelftRestockRequestsMarkAsDone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShelftRestockRequestsMarkAsDone.Name = "btnShelftRestockRequestsMarkAsDone";
            this.btnShelftRestockRequestsMarkAsDone.Size = new System.Drawing.Size(183, 49);
            this.btnShelftRestockRequestsMarkAsDone.TabIndex = 18;
            this.btnShelftRestockRequestsMarkAsDone.Text = "Mark as \'Done\'";
            this.btnShelftRestockRequestsMarkAsDone.UseVisualStyleBackColor = true;
            this.btnShelftRestockRequestsMarkAsDone.Click += new System.EventHandler(this.btnShelftRestockRequestsMarkAsDone_Click);
            // 
            // btnShelftRestockRequestsDecline
            // 
            this.btnShelftRestockRequestsDecline.Location = new System.Drawing.Point(446, 450);
            this.btnShelftRestockRequestsDecline.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShelftRestockRequestsDecline.Name = "btnShelftRestockRequestsDecline";
            this.btnShelftRestockRequestsDecline.Size = new System.Drawing.Size(183, 49);
            this.btnShelftRestockRequestsDecline.TabIndex = 17;
            this.btnShelftRestockRequestsDecline.Text = "Decline";
            this.btnShelftRestockRequestsDecline.UseVisualStyleBackColor = true;
            this.btnShelftRestockRequestsDecline.Click += new System.EventHandler(this.btnShelftRestockRequestsDecline_Click);
            // 
            // lbxAllShelfRestockRequests
            // 
            this.lbxAllShelfRestockRequests.FormattingEnabled = true;
            this.lbxAllShelfRestockRequests.HorizontalScrollbar = true;
            this.lbxAllShelfRestockRequests.ItemHeight = 18;
            this.lbxAllShelfRestockRequests.Location = new System.Drawing.Point(30, 51);
            this.lbxAllShelfRestockRequests.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxAllShelfRestockRequests.Name = "lbxAllShelfRestockRequests";
            this.lbxAllShelfRestockRequests.Size = new System.Drawing.Size(956, 328);
            this.lbxAllShelfRestockRequests.TabIndex = 16;
            // 
            // HistoryShelfRestockTab
            // 
            this.HistoryShelfRestockTab.Controls.Add(this.lbHistoryShelfRestockRequests);
            this.HistoryShelfRestockTab.Controls.Add(this.lbxHistoryShelfRestockRequests);
            this.HistoryShelfRestockTab.Location = new System.Drawing.Point(4, 27);
            this.HistoryShelfRestockTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HistoryShelfRestockTab.Name = "HistoryShelfRestockTab";
            this.HistoryShelfRestockTab.Size = new System.Drawing.Size(1021, 570);
            this.HistoryShelfRestockTab.TabIndex = 2;
            this.HistoryShelfRestockTab.Text = "History shelf restock requests";
            this.HistoryShelfRestockTab.UseVisualStyleBackColor = true;
            // 
            // lbHistoryShelfRestockRequests
            // 
            this.lbHistoryShelfRestockRequests.AutoSize = true;
            this.lbHistoryShelfRestockRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHistoryShelfRestockRequests.Location = new System.Drawing.Point(382, 62);
            this.lbHistoryShelfRestockRequests.Name = "lbHistoryShelfRestockRequests";
            this.lbHistoryShelfRestockRequests.Size = new System.Drawing.Size(255, 18);
            this.lbHistoryShelfRestockRequests.TabIndex = 13;
            this.lbHistoryShelfRestockRequests.Text = "History of shelf restock requests";
            // 
            // lbxHistoryShelfRestockRequests
            // 
            this.lbxHistoryShelfRestockRequests.FormattingEnabled = true;
            this.lbxHistoryShelfRestockRequests.HorizontalScrollbar = true;
            this.lbxHistoryShelfRestockRequests.ItemHeight = 18;
            this.lbxHistoryShelfRestockRequests.Location = new System.Drawing.Point(109, 127);
            this.lbxHistoryShelfRestockRequests.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxHistoryShelfRestockRequests.Name = "lbxHistoryShelfRestockRequests";
            this.lbxHistoryShelfRestockRequests.Size = new System.Drawing.Size(850, 328);
            this.lbxHistoryShelfRestockRequests.TabIndex = 12;
            // 
            // DepotWorkersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 615);
            this.Controls.Add(this.tabControlDepotWorkers);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DepotWorkersForm";
            this.Text = "DepotWorkersForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SalesForm_FormClosed);
            this.Load += new System.EventHandler(this.DepotWorkersForm_Load);
            this.tabControlDepotWorkers.ResumeLayout(false);
            this.HomeTab.ResumeLayout(false);
            this.HomeTab.PerformLayout();
            this.MakeShelfRestockRequestsTab.ResumeLayout(false);
            this.HistoryShelfRestockTab.ResumeLayout(false);
            this.HistoryShelfRestockTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlDepotWorkers;
        private System.Windows.Forms.TabPage HomeTab;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbDateDayOfWeek;
        private System.Windows.Forms.Label lbGreetingMsg;
        private System.Windows.Forms.TabPage MakeShelfRestockRequestsTab;
        private System.Windows.Forms.TabPage HistoryShelfRestockTab;
        private System.Windows.Forms.Label lbHistoryShelfRestockRequests;
        private System.Windows.Forms.ListBox lbxHistoryShelfRestockRequests;
        private System.Windows.Forms.Button btnSehflRestockRequestsClearSelected;
        private System.Windows.Forms.Button btnShelftRestockRequestsMarkAsDone;
        private System.Windows.Forms.Button btnShelftRestockRequestsDecline;
        private System.Windows.Forms.ListBox lbxAllShelfRestockRequests;
    }
}