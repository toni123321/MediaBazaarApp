
namespace MediaBazaarApp
{
    partial class SalesForm
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
            this.btnClearSelected = new System.Windows.Forms.Button();
            this.gbxStockChooseQuantity = new System.Windows.Forms.GroupBox();
            this.btnConfirmRequest = new System.Windows.Forms.Button();
            this.tbxStockQuantity = new System.Windows.Forms.TextBox();
            this.lbStockQuantity = new System.Windows.Forms.Label();
            this.lbStockInfo = new System.Windows.Forms.Label();
            this.btnMakeShelfRestockRequest = new System.Windows.Forms.Button();
            this.gbxSearchStock = new System.Windows.Forms.GroupBox();
            this.btnSearchStock = new System.Windows.Forms.Button();
            this.tbxSearchStock = new System.Windows.Forms.TextBox();
            this.btnShowAllStocks = new System.Windows.Forms.Button();
            this.lbxAllStocks = new System.Windows.Forms.ListBox();
            this.HistoryShelfRestockTab = new System.Windows.Forms.TabPage();
            this.lbHistoryShelfRestockRequests = new System.Windows.Forms.Label();
            this.lbxHistoryShelfRestockRequests = new System.Windows.Forms.ListBox();
            this.tabControlDepotWorkers.SuspendLayout();
            this.HomeTab.SuspendLayout();
            this.MakeShelfRestockRequestsTab.SuspendLayout();
            this.gbxStockChooseQuantity.SuspendLayout();
            this.gbxSearchStock.SuspendLayout();
            this.HistoryShelfRestockTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlDepotWorkers
            // 
            this.tabControlDepotWorkers.Controls.Add(this.HomeTab);
            this.tabControlDepotWorkers.Controls.Add(this.MakeShelfRestockRequestsTab);
            this.tabControlDepotWorkers.Controls.Add(this.HistoryShelfRestockTab);
            this.tabControlDepotWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlDepotWorkers.Location = new System.Drawing.Point(37, 23);
            this.tabControlDepotWorkers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlDepotWorkers.Name = "tabControlDepotWorkers";
            this.tabControlDepotWorkers.SelectedIndex = 0;
            this.tabControlDepotWorkers.Size = new System.Drawing.Size(1029, 601);
            this.tabControlDepotWorkers.TabIndex = 1;
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
            this.MakeShelfRestockRequestsTab.Controls.Add(this.btnClearSelected);
            this.MakeShelfRestockRequestsTab.Controls.Add(this.gbxStockChooseQuantity);
            this.MakeShelfRestockRequestsTab.Controls.Add(this.btnMakeShelfRestockRequest);
            this.MakeShelfRestockRequestsTab.Controls.Add(this.gbxSearchStock);
            this.MakeShelfRestockRequestsTab.Controls.Add(this.btnShowAllStocks);
            this.MakeShelfRestockRequestsTab.Controls.Add(this.lbxAllStocks);
            this.MakeShelfRestockRequestsTab.Location = new System.Drawing.Point(4, 27);
            this.MakeShelfRestockRequestsTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MakeShelfRestockRequestsTab.Name = "MakeShelfRestockRequestsTab";
            this.MakeShelfRestockRequestsTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MakeShelfRestockRequestsTab.Size = new System.Drawing.Size(1021, 570);
            this.MakeShelfRestockRequestsTab.TabIndex = 0;
            this.MakeShelfRestockRequestsTab.Text = "Make shelf restock requests";
            this.MakeShelfRestockRequestsTab.UseVisualStyleBackColor = true;
            // 
            // btnClearSelected
            // 
            this.btnClearSelected.Location = new System.Drawing.Point(37, 496);
            this.btnClearSelected.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearSelected.Name = "btnClearSelected";
            this.btnClearSelected.Size = new System.Drawing.Size(178, 47);
            this.btnClearSelected.TabIndex = 20;
            this.btnClearSelected.Text = "Unmark selected";
            this.btnClearSelected.UseVisualStyleBackColor = true;
            this.btnClearSelected.Click += new System.EventHandler(this.btnClearSelected_Click);
            // 
            // gbxStockChooseQuantity
            // 
            this.gbxStockChooseQuantity.Controls.Add(this.btnConfirmRequest);
            this.gbxStockChooseQuantity.Controls.Add(this.tbxStockQuantity);
            this.gbxStockChooseQuantity.Controls.Add(this.lbStockQuantity);
            this.gbxStockChooseQuantity.Controls.Add(this.lbStockInfo);
            this.gbxStockChooseQuantity.Location = new System.Drawing.Point(703, 179);
            this.gbxStockChooseQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxStockChooseQuantity.Name = "gbxStockChooseQuantity";
            this.gbxStockChooseQuantity.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxStockChooseQuantity.Size = new System.Drawing.Size(292, 225);
            this.gbxStockChooseQuantity.TabIndex = 19;
            this.gbxStockChooseQuantity.TabStop = false;
            this.gbxStockChooseQuantity.Text = "Choose quantity";
            // 
            // btnConfirmRequest
            // 
            this.btnConfirmRequest.Location = new System.Drawing.Point(25, 158);
            this.btnConfirmRequest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirmRequest.Name = "btnConfirmRequest";
            this.btnConfirmRequest.Size = new System.Drawing.Size(237, 32);
            this.btnConfirmRequest.TabIndex = 3;
            this.btnConfirmRequest.Text = "Confirm request";
            this.btnConfirmRequest.UseVisualStyleBackColor = true;
            this.btnConfirmRequest.Click += new System.EventHandler(this.btnConfirmRequest_Click);
            // 
            // tbxStockQuantity
            // 
            this.tbxStockQuantity.Location = new System.Drawing.Point(118, 101);
            this.tbxStockQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxStockQuantity.Name = "tbxStockQuantity";
            this.tbxStockQuantity.Size = new System.Drawing.Size(144, 24);
            this.tbxStockQuantity.TabIndex = 2;
            // 
            // lbStockQuantity
            // 
            this.lbStockQuantity.AutoSize = true;
            this.lbStockQuantity.Location = new System.Drawing.Point(21, 104);
            this.lbStockQuantity.Name = "lbStockQuantity";
            this.lbStockQuantity.Size = new System.Drawing.Size(66, 18);
            this.lbStockQuantity.TabIndex = 1;
            this.lbStockQuantity.Text = "Quantity:";
            // 
            // lbStockInfo
            // 
            this.lbStockInfo.AutoSize = true;
            this.lbStockInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStockInfo.Location = new System.Drawing.Point(83, 40);
            this.lbStockInfo.Name = "lbStockInfo";
            this.lbStockInfo.Size = new System.Drawing.Size(110, 18);
            this.lbStockInfo.TabIndex = 0;
            this.lbStockInfo.Text = "Model(Brand)";
            // 
            // btnMakeShelfRestockRequest
            // 
            this.btnMakeShelfRestockRequest.Location = new System.Drawing.Point(340, 496);
            this.btnMakeShelfRestockRequest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMakeShelfRestockRequest.Name = "btnMakeShelfRestockRequest";
            this.btnMakeShelfRestockRequest.Size = new System.Drawing.Size(323, 47);
            this.btnMakeShelfRestockRequest.TabIndex = 18;
            this.btnMakeShelfRestockRequest.Text = "Make a shelf restock request";
            this.btnMakeShelfRestockRequest.UseVisualStyleBackColor = true;
            this.btnMakeShelfRestockRequest.Click += new System.EventHandler(this.btnMakeShelfRestockRequest_Click);
            // 
            // gbxSearchStock
            // 
            this.gbxSearchStock.Controls.Add(this.btnSearchStock);
            this.gbxSearchStock.Controls.Add(this.tbxSearchStock);
            this.gbxSearchStock.Location = new System.Drawing.Point(206, 27);
            this.gbxSearchStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxSearchStock.Name = "gbxSearchStock";
            this.gbxSearchStock.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxSearchStock.Size = new System.Drawing.Size(457, 101);
            this.gbxSearchStock.TabIndex = 17;
            this.gbxSearchStock.TabStop = false;
            this.gbxSearchStock.Text = "Search for specific stock";
            // 
            // btnSearchStock
            // 
            this.btnSearchStock.Location = new System.Drawing.Point(254, 36);
            this.btnSearchStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchStock.Name = "btnSearchStock";
            this.btnSearchStock.Size = new System.Drawing.Size(186, 32);
            this.btnSearchStock.TabIndex = 6;
            this.btnSearchStock.Text = "Search";
            this.btnSearchStock.UseVisualStyleBackColor = true;
            this.btnSearchStock.Click += new System.EventHandler(this.btnSearchStock_Click);
            // 
            // tbxSearchStock
            // 
            this.tbxSearchStock.Location = new System.Drawing.Point(11, 40);
            this.tbxSearchStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxSearchStock.Name = "tbxSearchStock";
            this.tbxSearchStock.Size = new System.Drawing.Size(209, 24);
            this.tbxSearchStock.TabIndex = 7;
            this.tbxSearchStock.Text = "Search...";
            // 
            // btnShowAllStocks
            // 
            this.btnShowAllStocks.Location = new System.Drawing.Point(37, 55);
            this.btnShowAllStocks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowAllStocks.Name = "btnShowAllStocks";
            this.btnShowAllStocks.Size = new System.Drawing.Size(153, 55);
            this.btnShowAllStocks.TabIndex = 11;
            this.btnShowAllStocks.Text = "Show all stocks";
            this.btnShowAllStocks.UseVisualStyleBackColor = true;
            this.btnShowAllStocks.Click += new System.EventHandler(this.btnShowAllStocks_Click_1);
            // 
            // lbxAllStocks
            // 
            this.lbxAllStocks.FormattingEnabled = true;
            this.lbxAllStocks.HorizontalScrollbar = true;
            this.lbxAllStocks.ItemHeight = 18;
            this.lbxAllStocks.Location = new System.Drawing.Point(37, 145);
            this.lbxAllStocks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxAllStocks.Name = "lbxAllStocks";
            this.lbxAllStocks.Size = new System.Drawing.Size(625, 310);
            this.lbxAllStocks.TabIndex = 9;
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
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 646);
            this.Controls.Add(this.tabControlDepotWorkers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SalesForm";
            this.Text = "DepotWorkersForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SalesForm_FormClosed);
            this.Load += new System.EventHandler(this.SalesForm_Load);
            this.tabControlDepotWorkers.ResumeLayout(false);
            this.HomeTab.ResumeLayout(false);
            this.HomeTab.PerformLayout();
            this.MakeShelfRestockRequestsTab.ResumeLayout(false);
            this.gbxStockChooseQuantity.ResumeLayout(false);
            this.gbxStockChooseQuantity.PerformLayout();
            this.gbxSearchStock.ResumeLayout(false);
            this.gbxSearchStock.PerformLayout();
            this.HistoryShelfRestockTab.ResumeLayout(false);
            this.HistoryShelfRestockTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlDepotWorkers;
        private System.Windows.Forms.TabPage MakeShelfRestockRequestsTab;
        private System.Windows.Forms.Button btnShowAllStocks;
        private System.Windows.Forms.ListBox lbxAllStocks;
        private System.Windows.Forms.GroupBox gbxStockChooseQuantity;
        private System.Windows.Forms.Button btnMakeShelfRestockRequest;
        private System.Windows.Forms.GroupBox gbxSearchStock;
        private System.Windows.Forms.Button btnSearchStock;
        private System.Windows.Forms.TextBox tbxSearchStock;
        private System.Windows.Forms.TextBox tbxStockQuantity;
        private System.Windows.Forms.Label lbStockQuantity;
        private System.Windows.Forms.Label lbStockInfo;
        private System.Windows.Forms.Button btnConfirmRequest;
        private System.Windows.Forms.TabPage HistoryShelfRestockTab;
        private System.Windows.Forms.Label lbHistoryShelfRestockRequests;
        private System.Windows.Forms.ListBox lbxHistoryShelfRestockRequests;
        private System.Windows.Forms.Button btnClearSelected;
        private System.Windows.Forms.TabPage HomeTab;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbDateDayOfWeek;
        private System.Windows.Forms.Label lbGreetingMsg;
    }
}