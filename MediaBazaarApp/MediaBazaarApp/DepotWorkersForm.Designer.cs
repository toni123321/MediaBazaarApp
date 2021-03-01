
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
            this.ViewStocksQuantityTab = new System.Windows.Forms.TabPage();
            this.btnShowStockByQuantity = new System.Windows.Forms.Button();
            this.cbQuantityType = new System.Windows.Forms.ComboBox();
            this.lbxStocksSortByQuantity = new System.Windows.Forms.ListBox();
            this.HistoryShelfRestockTab = new System.Windows.Forms.TabPage();
            this.lbHistoryShelfRestockRequests = new System.Windows.Forms.Label();
            this.lbxHistoryShelfRestockRequests = new System.Windows.Forms.ListBox();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbDateDayOfWeek = new System.Windows.Forms.Label();
            this.lbGreetingMsg = new System.Windows.Forms.Label();
            this.tabControlDepotWorkers.SuspendLayout();
            this.MakeShelfRestockRequestsTab.SuspendLayout();
            this.gbxStockChooseQuantity.SuspendLayout();
            this.gbxSearchStock.SuspendLayout();
            this.ViewStocksQuantityTab.SuspendLayout();
            this.HistoryShelfRestockTab.SuspendLayout();
            this.HomeTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlDepotWorkers
            // 
            this.tabControlDepotWorkers.Controls.Add(this.HomeTab);
            this.tabControlDepotWorkers.Controls.Add(this.MakeShelfRestockRequestsTab);
            this.tabControlDepotWorkers.Controls.Add(this.ViewStocksQuantityTab);
            this.tabControlDepotWorkers.Controls.Add(this.HistoryShelfRestockTab);
            this.tabControlDepotWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlDepotWorkers.Location = new System.Drawing.Point(33, 21);
            this.tabControlDepotWorkers.Name = "tabControlDepotWorkers";
            this.tabControlDepotWorkers.SelectedIndex = 0;
            this.tabControlDepotWorkers.Size = new System.Drawing.Size(915, 534);
            this.tabControlDepotWorkers.TabIndex = 1;
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
            this.MakeShelfRestockRequestsTab.Name = "MakeShelfRestockRequestsTab";
            this.MakeShelfRestockRequestsTab.Padding = new System.Windows.Forms.Padding(3);
            this.MakeShelfRestockRequestsTab.Size = new System.Drawing.Size(907, 503);
            this.MakeShelfRestockRequestsTab.TabIndex = 0;
            this.MakeShelfRestockRequestsTab.Text = "Make shelf restock requests";
            this.MakeShelfRestockRequestsTab.UseVisualStyleBackColor = true;
            // 
            // btnClearSelected
            // 
            this.btnClearSelected.Location = new System.Drawing.Point(33, 441);
            this.btnClearSelected.Name = "btnClearSelected";
            this.btnClearSelected.Size = new System.Drawing.Size(158, 42);
            this.btnClearSelected.TabIndex = 20;
            this.btnClearSelected.Text = "Unmark selected";
            this.btnClearSelected.UseVisualStyleBackColor = true;
            // 
            // gbxStockChooseQuantity
            // 
            this.gbxStockChooseQuantity.Controls.Add(this.btnConfirmRequest);
            this.gbxStockChooseQuantity.Controls.Add(this.tbxStockQuantity);
            this.gbxStockChooseQuantity.Controls.Add(this.lbStockQuantity);
            this.gbxStockChooseQuantity.Controls.Add(this.lbStockInfo);
            this.gbxStockChooseQuantity.Location = new System.Drawing.Point(625, 159);
            this.gbxStockChooseQuantity.Name = "gbxStockChooseQuantity";
            this.gbxStockChooseQuantity.Size = new System.Drawing.Size(260, 200);
            this.gbxStockChooseQuantity.TabIndex = 19;
            this.gbxStockChooseQuantity.TabStop = false;
            this.gbxStockChooseQuantity.Text = "Choose quantity";
            // 
            // btnConfirmRequest
            // 
            this.btnConfirmRequest.Location = new System.Drawing.Point(22, 141);
            this.btnConfirmRequest.Name = "btnConfirmRequest";
            this.btnConfirmRequest.Size = new System.Drawing.Size(211, 29);
            this.btnConfirmRequest.TabIndex = 3;
            this.btnConfirmRequest.Text = "Confirm request";
            this.btnConfirmRequest.UseVisualStyleBackColor = true;
            // 
            // tbxStockQuantity
            // 
            this.tbxStockQuantity.Location = new System.Drawing.Point(105, 90);
            this.tbxStockQuantity.Name = "tbxStockQuantity";
            this.tbxStockQuantity.Size = new System.Drawing.Size(128, 24);
            this.tbxStockQuantity.TabIndex = 2;
            // 
            // lbStockQuantity
            // 
            this.lbStockQuantity.AutoSize = true;
            this.lbStockQuantity.Location = new System.Drawing.Point(19, 93);
            this.lbStockQuantity.Name = "lbStockQuantity";
            this.lbStockQuantity.Size = new System.Drawing.Size(66, 18);
            this.lbStockQuantity.TabIndex = 1;
            this.lbStockQuantity.Text = "Quantity:";
            // 
            // lbStockInfo
            // 
            this.lbStockInfo.AutoSize = true;
            this.lbStockInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStockInfo.Location = new System.Drawing.Point(74, 36);
            this.lbStockInfo.Name = "lbStockInfo";
            this.lbStockInfo.Size = new System.Drawing.Size(110, 18);
            this.lbStockInfo.TabIndex = 0;
            this.lbStockInfo.Text = "Model(Brand)";
            // 
            // btnMakeShelfRestockRequest
            // 
            this.btnMakeShelfRestockRequest.Location = new System.Drawing.Point(302, 441);
            this.btnMakeShelfRestockRequest.Name = "btnMakeShelfRestockRequest";
            this.btnMakeShelfRestockRequest.Size = new System.Drawing.Size(287, 42);
            this.btnMakeShelfRestockRequest.TabIndex = 18;
            this.btnMakeShelfRestockRequest.Text = "Make a shelf restock request";
            this.btnMakeShelfRestockRequest.UseVisualStyleBackColor = true;
            // 
            // gbxSearchStock
            // 
            this.gbxSearchStock.Controls.Add(this.btnSearchStock);
            this.gbxSearchStock.Controls.Add(this.tbxSearchStock);
            this.gbxSearchStock.Location = new System.Drawing.Point(183, 24);
            this.gbxSearchStock.Name = "gbxSearchStock";
            this.gbxSearchStock.Size = new System.Drawing.Size(406, 90);
            this.gbxSearchStock.TabIndex = 17;
            this.gbxSearchStock.TabStop = false;
            this.gbxSearchStock.Text = "Search for specific stock";
            // 
            // btnSearchStock
            // 
            this.btnSearchStock.Location = new System.Drawing.Point(226, 32);
            this.btnSearchStock.Name = "btnSearchStock";
            this.btnSearchStock.Size = new System.Drawing.Size(165, 29);
            this.btnSearchStock.TabIndex = 6;
            this.btnSearchStock.Text = "Search";
            this.btnSearchStock.UseVisualStyleBackColor = true;
            // 
            // tbxSearchStock
            // 
            this.tbxSearchStock.Location = new System.Drawing.Point(10, 35);
            this.tbxSearchStock.Name = "tbxSearchStock";
            this.tbxSearchStock.Size = new System.Drawing.Size(186, 24);
            this.tbxSearchStock.TabIndex = 7;
            this.tbxSearchStock.Text = "Search...";
            // 
            // btnShowAllStocks
            // 
            this.btnShowAllStocks.Location = new System.Drawing.Point(33, 49);
            this.btnShowAllStocks.Name = "btnShowAllStocks";
            this.btnShowAllStocks.Size = new System.Drawing.Size(136, 49);
            this.btnShowAllStocks.TabIndex = 11;
            this.btnShowAllStocks.Text = "Show all stocks";
            this.btnShowAllStocks.UseVisualStyleBackColor = true;
            // 
            // lbxAllStocks
            // 
            this.lbxAllStocks.FormattingEnabled = true;
            this.lbxAllStocks.HorizontalScrollbar = true;
            this.lbxAllStocks.ItemHeight = 18;
            this.lbxAllStocks.Location = new System.Drawing.Point(33, 129);
            this.lbxAllStocks.Name = "lbxAllStocks";
            this.lbxAllStocks.Size = new System.Drawing.Size(556, 292);
            this.lbxAllStocks.TabIndex = 9;
            // 
            // ViewStocksQuantityTab
            // 
            this.ViewStocksQuantityTab.Controls.Add(this.btnShowStockByQuantity);
            this.ViewStocksQuantityTab.Controls.Add(this.cbQuantityType);
            this.ViewStocksQuantityTab.Controls.Add(this.lbxStocksSortByQuantity);
            this.ViewStocksQuantityTab.Location = new System.Drawing.Point(4, 27);
            this.ViewStocksQuantityTab.Name = "ViewStocksQuantityTab";
            this.ViewStocksQuantityTab.Padding = new System.Windows.Forms.Padding(3);
            this.ViewStocksQuantityTab.Size = new System.Drawing.Size(907, 503);
            this.ViewStocksQuantityTab.TabIndex = 1;
            this.ViewStocksQuantityTab.Text = "View stocks quantity";
            this.ViewStocksQuantityTab.UseVisualStyleBackColor = true;
            // 
            // btnShowStockByQuantity
            // 
            this.btnShowStockByQuantity.Location = new System.Drawing.Point(555, 65);
            this.btnShowStockByQuantity.Name = "btnShowStockByQuantity";
            this.btnShowStockByQuantity.Size = new System.Drawing.Size(181, 35);
            this.btnShowStockByQuantity.TabIndex = 8;
            this.btnShowStockByQuantity.Text = "Show stocks";
            this.btnShowStockByQuantity.UseVisualStyleBackColor = true;
            // 
            // cbQuantityType
            // 
            this.cbQuantityType.FormattingEnabled = true;
            this.cbQuantityType.Items.AddRange(new object[] {
            "highest price",
            "lowest price",
            "biggest quantity",
            "smallest quantity",
            ""});
            this.cbQuantityType.Location = new System.Drawing.Point(184, 70);
            this.cbQuantityType.Name = "cbQuantityType";
            this.cbQuantityType.Size = new System.Drawing.Size(288, 26);
            this.cbQuantityType.TabIndex = 7;
            this.cbQuantityType.Text = "Sort by quantity";
            // 
            // lbxStocksSortByQuantity
            // 
            this.lbxStocksSortByQuantity.FormattingEnabled = true;
            this.lbxStocksSortByQuantity.HorizontalScrollbar = true;
            this.lbxStocksSortByQuantity.ItemHeight = 18;
            this.lbxStocksSortByQuantity.Location = new System.Drawing.Point(184, 112);
            this.lbxStocksSortByQuantity.Name = "lbxStocksSortByQuantity";
            this.lbxStocksSortByQuantity.Size = new System.Drawing.Size(552, 292);
            this.lbxStocksSortByQuantity.TabIndex = 6;
            // 
            // HistoryShelfRestockTab
            // 
            this.HistoryShelfRestockTab.Controls.Add(this.lbHistoryShelfRestockRequests);
            this.HistoryShelfRestockTab.Controls.Add(this.lbxHistoryShelfRestockRequests);
            this.HistoryShelfRestockTab.Location = new System.Drawing.Point(4, 27);
            this.HistoryShelfRestockTab.Name = "HistoryShelfRestockTab";
            this.HistoryShelfRestockTab.Size = new System.Drawing.Size(907, 503);
            this.HistoryShelfRestockTab.TabIndex = 2;
            this.HistoryShelfRestockTab.Text = "History shelf restock requests";
            this.HistoryShelfRestockTab.UseVisualStyleBackColor = true;
            // 
            // lbHistoryShelfRestockRequests
            // 
            this.lbHistoryShelfRestockRequests.AutoSize = true;
            this.lbHistoryShelfRestockRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHistoryShelfRestockRequests.Location = new System.Drawing.Point(340, 55);
            this.lbHistoryShelfRestockRequests.Name = "lbHistoryShelfRestockRequests";
            this.lbHistoryShelfRestockRequests.Size = new System.Drawing.Size(246, 18);
            this.lbHistoryShelfRestockRequests.TabIndex = 13;
            this.lbHistoryShelfRestockRequests.Text = "History of shelf restock request";
            // 
            // lbxHistoryShelfRestockRequests
            // 
            this.lbxHistoryShelfRestockRequests.FormattingEnabled = true;
            this.lbxHistoryShelfRestockRequests.ItemHeight = 18;
            this.lbxHistoryShelfRestockRequests.Location = new System.Drawing.Point(97, 113);
            this.lbxHistoryShelfRestockRequests.Name = "lbxHistoryShelfRestockRequests";
            this.lbxHistoryShelfRestockRequests.Size = new System.Drawing.Size(756, 310);
            this.lbxHistoryShelfRestockRequests.TabIndex = 12;
            // 
            // HomeTab
            // 
            this.HomeTab.Controls.Add(this.lbTime);
            this.HomeTab.Controls.Add(this.lbDateDayOfWeek);
            this.HomeTab.Controls.Add(this.lbGreetingMsg);
            this.HomeTab.Location = new System.Drawing.Point(4, 27);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Size = new System.Drawing.Size(907, 503);
            this.HomeTab.TabIndex = 3;
            this.HomeTab.Text = "Home";
            this.HomeTab.UseVisualStyleBackColor = true;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(122, 259);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(41, 18);
            this.lbTime.TabIndex = 12;
            this.lbTime.Text = "Time";
            // 
            // lbDateDayOfWeek
            // 
            this.lbDateDayOfWeek.AutoSize = true;
            this.lbDateDayOfWeek.Location = new System.Drawing.Point(122, 304);
            this.lbDateDayOfWeek.Name = "lbDateDayOfWeek";
            this.lbDateDayOfWeek.Size = new System.Drawing.Size(125, 18);
            this.lbDateDayOfWeek.TabIndex = 11;
            this.lbDateDayOfWeek.Text = "Date/Day of week";
            // 
            // lbGreetingMsg
            // 
            this.lbGreetingMsg.AutoSize = true;
            this.lbGreetingMsg.Location = new System.Drawing.Point(117, 126);
            this.lbGreetingMsg.Name = "lbGreetingMsg";
            this.lbGreetingMsg.Size = new System.Drawing.Size(129, 18);
            this.lbGreetingMsg.TabIndex = 10;
            this.lbGreetingMsg.Text = "Greeting message";
            // 
            // DepotWorkersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 574);
            this.Controls.Add(this.tabControlDepotWorkers);
            this.Name = "DepotWorkersForm";
            this.Text = "DepotWorkersForm";
            this.tabControlDepotWorkers.ResumeLayout(false);
            this.MakeShelfRestockRequestsTab.ResumeLayout(false);
            this.gbxStockChooseQuantity.ResumeLayout(false);
            this.gbxStockChooseQuantity.PerformLayout();
            this.gbxSearchStock.ResumeLayout(false);
            this.gbxSearchStock.PerformLayout();
            this.ViewStocksQuantityTab.ResumeLayout(false);
            this.HistoryShelfRestockTab.ResumeLayout(false);
            this.HistoryShelfRestockTab.PerformLayout();
            this.HomeTab.ResumeLayout(false);
            this.HomeTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlDepotWorkers;
        private System.Windows.Forms.TabPage MakeShelfRestockRequestsTab;
        private System.Windows.Forms.TabPage ViewStocksQuantityTab;
        private System.Windows.Forms.Button btnShowStockByQuantity;
        private System.Windows.Forms.ComboBox cbQuantityType;
        private System.Windows.Forms.ListBox lbxStocksSortByQuantity;
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