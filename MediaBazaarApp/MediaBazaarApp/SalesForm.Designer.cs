
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
            this.components = new System.ComponentModel.Container();
            this.tabControlDepotWorkers = new System.Windows.Forms.TabControl();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.historyShortcut = new System.Windows.Forms.Panel();
            this.historyLBL = new System.Windows.Forms.Label();
            this.historyPic = new System.Windows.Forms.PictureBox();
            this.requestShortcut = new System.Windows.Forms.Panel();
            this.reqLBL = new System.Windows.Forms.Label();
            this.requestPic = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbDateDayOfWeek = new System.Windows.Forms.Label();
            this.lbGreetingMsg = new System.Windows.Forms.Label();
            this.MakeShelfRestockRequestsTab = new System.Windows.Forms.TabPage();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.btnClearSelected = new System.Windows.Forms.Button();
            this.gbxStockChooseQuantity = new System.Windows.Forms.GroupBox();
            this.btnConfirmRequest = new System.Windows.Forms.Button();
            this.tbxStockQuantity = new System.Windows.Forms.TextBox();
            this.lbStockQuantity = new System.Windows.Forms.Label();
            this.lbStockInfo = new System.Windows.Forms.Label();
            this.btnMakeShelfRestockRequest = new System.Windows.Forms.Button();
            this.gbxSearchStock = new System.Windows.Forms.GroupBox();
            this.tbxSearchStock = new System.Windows.Forms.TextBox();
            this.btnShowAllStocks = new System.Windows.Forms.Button();
            this.HistoryShelfRestockTab = new System.Windows.Forms.TabPage();
            this.dgvSRRall = new System.Windows.Forms.DataGridView();
            this.lbHistoryShelfRestockRequests = new System.Windows.Forms.Label();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.applyShortcutsBTN = new System.Windows.Forms.Button();
            this.historyCH = new System.Windows.Forms.CheckBox();
            this.reqCH = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControlDepotWorkers.SuspendLayout();
            this.HomeTab.SuspendLayout();
            this.historyShortcut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyPic)).BeginInit();
            this.requestShortcut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.MakeShelfRestockRequestsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.gbxStockChooseQuantity.SuspendLayout();
            this.gbxSearchStock.SuspendLayout();
            this.HistoryShelfRestockTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSRRall)).BeginInit();
            this.settingsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlDepotWorkers
            // 
            this.tabControlDepotWorkers.Controls.Add(this.HomeTab);
            this.tabControlDepotWorkers.Controls.Add(this.MakeShelfRestockRequestsTab);
            this.tabControlDepotWorkers.Controls.Add(this.HistoryShelfRestockTab);
            this.tabControlDepotWorkers.Controls.Add(this.settingsTab);
            this.tabControlDepotWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlDepotWorkers.Location = new System.Drawing.Point(12, 13);
            this.tabControlDepotWorkers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlDepotWorkers.Name = "tabControlDepotWorkers";
            this.tabControlDepotWorkers.SelectedIndex = 0;
            this.tabControlDepotWorkers.Size = new System.Drawing.Size(1064, 629);
            this.tabControlDepotWorkers.TabIndex = 1;
            // 
            // HomeTab
            // 
            this.HomeTab.BackColor = System.Drawing.Color.MediumTurquoise;
            this.HomeTab.Controls.Add(this.historyShortcut);
            this.HomeTab.Controls.Add(this.requestShortcut);
            this.HomeTab.Controls.Add(this.pictureBox7);
            this.HomeTab.Controls.Add(this.lbTime);
            this.HomeTab.Controls.Add(this.lbDateDayOfWeek);
            this.HomeTab.Controls.Add(this.lbGreetingMsg);
            this.HomeTab.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeTab.Location = new System.Drawing.Point(4, 24);
            this.HomeTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Size = new System.Drawing.Size(1056, 601);
            this.HomeTab.TabIndex = 3;
            this.HomeTab.Text = "Home";
            // 
            // historyShortcut
            // 
            this.historyShortcut.BackColor = System.Drawing.Color.LightSalmon;
            this.historyShortcut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.historyShortcut.Controls.Add(this.historyLBL);
            this.historyShortcut.Controls.Add(this.historyPic);
            this.historyShortcut.Location = new System.Drawing.Point(678, 476);
            this.historyShortcut.Name = "historyShortcut";
            this.historyShortcut.Size = new System.Drawing.Size(362, 80);
            this.historyShortcut.TabIndex = 19;
            this.historyShortcut.Visible = false;
            this.historyShortcut.Click += new System.EventHandler(this.HistoryShortcut_Click);
            // 
            // historyLBL
            // 
            this.historyLBL.AutoSize = true;
            this.historyLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyLBL.Location = new System.Drawing.Point(74, 22);
            this.historyLBL.Name = "historyLBL";
            this.historyLBL.Size = new System.Drawing.Size(250, 21);
            this.historyLBL.TabIndex = 1;
            this.historyLBL.Text = "View shelf restock requests history";
            this.historyLBL.Click += new System.EventHandler(this.HistoryLBL_Click);
            // 
            // historyPic
            // 
            this.historyPic.Cursor = System.Windows.Forms.Cursors.Default;
            this.historyPic.Image = global::MediaBazaarApp.Properties.Resources.outline_history_black_24dp;
            this.historyPic.Location = new System.Drawing.Point(12, 11);
            this.historyPic.Name = "historyPic";
            this.historyPic.Size = new System.Drawing.Size(56, 57);
            this.historyPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.historyPic.TabIndex = 0;
            this.historyPic.TabStop = false;
            this.historyPic.Click += new System.EventHandler(this.HistoryPic_Click);
            // 
            // requestShortcut
            // 
            this.requestShortcut.BackColor = System.Drawing.Color.LightSalmon;
            this.requestShortcut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.requestShortcut.Controls.Add(this.reqLBL);
            this.requestShortcut.Controls.Add(this.requestPic);
            this.requestShortcut.Location = new System.Drawing.Point(678, 390);
            this.requestShortcut.Name = "requestShortcut";
            this.requestShortcut.Size = new System.Drawing.Size(362, 80);
            this.requestShortcut.TabIndex = 18;
            this.requestShortcut.Visible = false;
            this.requestShortcut.Click += new System.EventHandler(this.RequestShortcut_Click);
            // 
            // reqLBL
            // 
            this.reqLBL.AutoSize = true;
            this.reqLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqLBL.Location = new System.Drawing.Point(83, 30);
            this.reqLBL.Name = "reqLBL";
            this.reqLBL.Size = new System.Drawing.Size(202, 21);
            this.reqLBL.TabIndex = 1;
            this.reqLBL.Text = "Make shelf restock requests";
            this.reqLBL.Click += new System.EventHandler(this.ReqLBL_Click);
            // 
            // requestPic
            // 
            this.requestPic.Cursor = System.Windows.Forms.Cursors.Default;
            this.requestPic.Image = global::MediaBazaarApp.Properties.Resources.outline_swap_horiz_black_24dp;
            this.requestPic.Location = new System.Drawing.Point(12, 11);
            this.requestPic.Name = "requestPic";
            this.requestPic.Size = new System.Drawing.Size(56, 57);
            this.requestPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.requestPic.TabIndex = 0;
            this.requestPic.TabStop = false;
            this.requestPic.Click += new System.EventHandler(this.RequestPic_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::MediaBazaarApp.Properties.Resources.MediaBazaarLogo;
            this.pictureBox7.Location = new System.Drawing.Point(15, 390);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(223, 191);
            this.pictureBox7.TabIndex = 15;
            this.pictureBox7.TabStop = false;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTime.Location = new System.Drawing.Point(47, 212);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(95, 45);
            this.lbTime.TabIndex = 14;
            this.lbTime.Text = "12:30";
            // 
            // lbDateDayOfWeek
            // 
            this.lbDateDayOfWeek.AutoSize = true;
            this.lbDateDayOfWeek.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateDayOfWeek.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbDateDayOfWeek.Location = new System.Drawing.Point(47, 272);
            this.lbDateDayOfWeek.Name = "lbDateDayOfWeek";
            this.lbDateDayOfWeek.Size = new System.Drawing.Size(223, 45);
            this.lbDateDayOfWeek.TabIndex = 13;
            this.lbDateDayOfWeek.Text = "Monday, 1 Jan";
            // 
            // lbGreetingMsg
            // 
            this.lbGreetingMsg.AutoSize = true;
            this.lbGreetingMsg.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGreetingMsg.Location = new System.Drawing.Point(45, 137);
            this.lbGreetingMsg.Name = "lbGreetingMsg";
            this.lbGreetingMsg.Size = new System.Drawing.Size(421, 51);
            this.lbGreetingMsg.TabIndex = 12;
            this.lbGreetingMsg.Text = "Good morning, Name!";
            // 
            // MakeShelfRestockRequestsTab
            // 
            this.MakeShelfRestockRequestsTab.BackColor = System.Drawing.Color.MediumTurquoise;
            this.MakeShelfRestockRequestsTab.Controls.Add(this.dgvStock);
            this.MakeShelfRestockRequestsTab.Controls.Add(this.btnClearSelected);
            this.MakeShelfRestockRequestsTab.Controls.Add(this.gbxStockChooseQuantity);
            this.MakeShelfRestockRequestsTab.Controls.Add(this.btnMakeShelfRestockRequest);
            this.MakeShelfRestockRequestsTab.Controls.Add(this.gbxSearchStock);
            this.MakeShelfRestockRequestsTab.Controls.Add(this.btnShowAllStocks);
            this.MakeShelfRestockRequestsTab.Location = new System.Drawing.Point(4, 24);
            this.MakeShelfRestockRequestsTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MakeShelfRestockRequestsTab.Name = "MakeShelfRestockRequestsTab";
            this.MakeShelfRestockRequestsTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MakeShelfRestockRequestsTab.Size = new System.Drawing.Size(1056, 601);
            this.MakeShelfRestockRequestsTab.TabIndex = 0;
            this.MakeShelfRestockRequestsTab.Text = "Make shelf restock requests";
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(6, 145);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersWidth = 51;
            this.dgvStock.RowTemplate.Height = 24;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(746, 344);
            this.dgvStock.TabIndex = 25;
            // 
            // btnClearSelected
            // 
            this.btnClearSelected.BackColor = System.Drawing.Color.LightSalmon;
            this.btnClearSelected.Location = new System.Drawing.Point(37, 496);
            this.btnClearSelected.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearSelected.Name = "btnClearSelected";
            this.btnClearSelected.Size = new System.Drawing.Size(178, 47);
            this.btnClearSelected.TabIndex = 20;
            this.btnClearSelected.Text = "Unmark selected";
            this.btnClearSelected.UseVisualStyleBackColor = false;
            this.btnClearSelected.Click += new System.EventHandler(this.btnClearSelected_Click);
            // 
            // gbxStockChooseQuantity
            // 
            this.gbxStockChooseQuantity.Controls.Add(this.btnConfirmRequest);
            this.gbxStockChooseQuantity.Controls.Add(this.tbxStockQuantity);
            this.gbxStockChooseQuantity.Controls.Add(this.lbStockQuantity);
            this.gbxStockChooseQuantity.Controls.Add(this.lbStockInfo);
            this.gbxStockChooseQuantity.Location = new System.Drawing.Point(758, 155);
            this.gbxStockChooseQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxStockChooseQuantity.Name = "gbxStockChooseQuantity";
            this.gbxStockChooseQuantity.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxStockChooseQuantity.Size = new System.Drawing.Size(292, 310);
            this.gbxStockChooseQuantity.TabIndex = 19;
            this.gbxStockChooseQuantity.TabStop = false;
            this.gbxStockChooseQuantity.Text = "Choose quantity";
            this.gbxStockChooseQuantity.Visible = false;
            // 
            // btnConfirmRequest
            // 
            this.btnConfirmRequest.BackColor = System.Drawing.Color.LightSalmon;
            this.btnConfirmRequest.Location = new System.Drawing.Point(34, 234);
            this.btnConfirmRequest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirmRequest.Name = "btnConfirmRequest";
            this.btnConfirmRequest.Size = new System.Drawing.Size(237, 32);
            this.btnConfirmRequest.TabIndex = 3;
            this.btnConfirmRequest.Text = "Confirm request";
            this.btnConfirmRequest.UseVisualStyleBackColor = false;
            this.btnConfirmRequest.Click += new System.EventHandler(this.btnConfirmRequest_Click);
            // 
            // tbxStockQuantity
            // 
            this.tbxStockQuantity.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxStockQuantity.Location = new System.Drawing.Point(64, 150);
            this.tbxStockQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxStockQuantity.Name = "tbxStockQuantity";
            this.tbxStockQuantity.Size = new System.Drawing.Size(144, 21);
            this.tbxStockQuantity.TabIndex = 2;
            // 
            // lbStockQuantity
            // 
            this.lbStockQuantity.AutoSize = true;
            this.lbStockQuantity.Location = new System.Drawing.Point(61, 112);
            this.lbStockQuantity.Name = "lbStockQuantity";
            this.lbStockQuantity.Size = new System.Drawing.Size(54, 15);
            this.lbStockQuantity.TabIndex = 1;
            this.lbStockQuantity.Text = "Quantity:";
            // 
            // lbStockInfo
            // 
            this.lbStockInfo.AutoSize = true;
            this.lbStockInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbStockInfo.Location = new System.Drawing.Point(59, 48);
            this.lbStockInfo.Name = "lbStockInfo";
            this.lbStockInfo.Size = new System.Drawing.Size(111, 21);
            this.lbStockInfo.TabIndex = 0;
            this.lbStockInfo.Text = "Model(Brand)";
            // 
            // btnMakeShelfRestockRequest
            // 
            this.btnMakeShelfRestockRequest.BackColor = System.Drawing.Color.LightSalmon;
            this.btnMakeShelfRestockRequest.Location = new System.Drawing.Point(340, 496);
            this.btnMakeShelfRestockRequest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMakeShelfRestockRequest.Name = "btnMakeShelfRestockRequest";
            this.btnMakeShelfRestockRequest.Size = new System.Drawing.Size(323, 47);
            this.btnMakeShelfRestockRequest.TabIndex = 18;
            this.btnMakeShelfRestockRequest.Text = "Make a shelf restock request";
            this.btnMakeShelfRestockRequest.UseVisualStyleBackColor = false;
            this.btnMakeShelfRestockRequest.Click += new System.EventHandler(this.btnMakeShelfRestockRequest_Click);
            // 
            // gbxSearchStock
            // 
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
            // tbxSearchStock
            // 
            this.tbxSearchStock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxSearchStock.Location = new System.Drawing.Point(11, 40);
            this.tbxSearchStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxSearchStock.Name = "tbxSearchStock";
            this.tbxSearchStock.Size = new System.Drawing.Size(399, 21);
            this.tbxSearchStock.TabIndex = 7;
            this.tbxSearchStock.TextChanged += new System.EventHandler(this.tbxSearchStock_TextChanged);
            // 
            // btnShowAllStocks
            // 
            this.btnShowAllStocks.BackColor = System.Drawing.Color.LightSalmon;
            this.btnShowAllStocks.Location = new System.Drawing.Point(37, 55);
            this.btnShowAllStocks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowAllStocks.Name = "btnShowAllStocks";
            this.btnShowAllStocks.Size = new System.Drawing.Size(153, 55);
            this.btnShowAllStocks.TabIndex = 11;
            this.btnShowAllStocks.Text = "Show all stocks";
            this.btnShowAllStocks.UseVisualStyleBackColor = false;
            this.btnShowAllStocks.Click += new System.EventHandler(this.btnShowAllStocks_Click_1);
            // 
            // HistoryShelfRestockTab
            // 
            this.HistoryShelfRestockTab.BackColor = System.Drawing.Color.MediumTurquoise;
            this.HistoryShelfRestockTab.Controls.Add(this.dgvSRRall);
            this.HistoryShelfRestockTab.Controls.Add(this.lbHistoryShelfRestockRequests);
            this.HistoryShelfRestockTab.Location = new System.Drawing.Point(4, 24);
            this.HistoryShelfRestockTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HistoryShelfRestockTab.Name = "HistoryShelfRestockTab";
            this.HistoryShelfRestockTab.Size = new System.Drawing.Size(1056, 601);
            this.HistoryShelfRestockTab.TabIndex = 2;
            this.HistoryShelfRestockTab.Text = "History shelf restock requests";
            // 
            // dgvSRRall
            // 
            this.dgvSRRall.AllowUserToAddRows = false;
            this.dgvSRRall.AllowUserToDeleteRows = false;
            this.dgvSRRall.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSRRall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSRRall.Location = new System.Drawing.Point(97, 124);
            this.dgvSRRall.Name = "dgvSRRall";
            this.dgvSRRall.ReadOnly = true;
            this.dgvSRRall.RowHeadersWidth = 51;
            this.dgvSRRall.RowTemplate.Height = 24;
            this.dgvSRRall.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSRRall.Size = new System.Drawing.Size(860, 417);
            this.dgvSRRall.TabIndex = 26;
            // 
            // lbHistoryShelfRestockRequests
            // 
            this.lbHistoryShelfRestockRequests.AutoSize = true;
            this.lbHistoryShelfRestockRequests.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbHistoryShelfRestockRequests.Location = new System.Drawing.Point(362, 51);
            this.lbHistoryShelfRestockRequests.Name = "lbHistoryShelfRestockRequests";
            this.lbHistoryShelfRestockRequests.Size = new System.Drawing.Size(248, 21);
            this.lbHistoryShelfRestockRequests.TabIndex = 13;
            this.lbHistoryShelfRestockRequests.Text = "History of shelf restock requests";
            // 
            // settingsTab
            // 
            this.settingsTab.BackColor = System.Drawing.Color.MediumTurquoise;
            this.settingsTab.Controls.Add(this.applyShortcutsBTN);
            this.settingsTab.Controls.Add(this.historyCH);
            this.settingsTab.Controls.Add(this.reqCH);
            this.settingsTab.Location = new System.Drawing.Point(4, 24);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTab.Size = new System.Drawing.Size(1056, 601);
            this.settingsTab.TabIndex = 4;
            this.settingsTab.Text = "Settings";
            // 
            // applyShortcutsBTN
            // 
            this.applyShortcutsBTN.Location = new System.Drawing.Point(6, 79);
            this.applyShortcutsBTN.Name = "applyShortcutsBTN";
            this.applyShortcutsBTN.Size = new System.Drawing.Size(75, 23);
            this.applyShortcutsBTN.TabIndex = 15;
            this.applyShortcutsBTN.Text = "Apply ";
            this.applyShortcutsBTN.UseVisualStyleBackColor = true;
            this.applyShortcutsBTN.Click += new System.EventHandler(this.ApplyShortcutsBTN_Click);
            // 
            // historyCH
            // 
            this.historyCH.AutoSize = true;
            this.historyCH.Location = new System.Drawing.Point(6, 41);
            this.historyCH.Name = "historyCH";
            this.historyCH.Size = new System.Drawing.Size(257, 19);
            this.historyCH.TabIndex = 14;
            this.historyCH.Text = "View shelf restock requests history shortcut";
            this.historyCH.UseVisualStyleBackColor = true;
            // 
            // reqCH
            // 
            this.reqCH.AutoSize = true;
            this.reqCH.Location = new System.Drawing.Point(6, 7);
            this.reqCH.Name = "reqCH";
            this.reqCH.Size = new System.Drawing.Size(218, 19);
            this.reqCH.TabIndex = 13;
            this.reqCH.Text = "Make shelf restock request shortcut";
            this.reqCH.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 646);
            this.Controls.Add(this.tabControlDepotWorkers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SalesForm";
            this.Text = "DepotWorkersForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SalesForm_FormClosed);
            this.tabControlDepotWorkers.ResumeLayout(false);
            this.HomeTab.ResumeLayout(false);
            this.HomeTab.PerformLayout();
            this.historyShortcut.ResumeLayout(false);
            this.historyShortcut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyPic)).EndInit();
            this.requestShortcut.ResumeLayout(false);
            this.requestShortcut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.MakeShelfRestockRequestsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.gbxStockChooseQuantity.ResumeLayout(false);
            this.gbxStockChooseQuantity.PerformLayout();
            this.gbxSearchStock.ResumeLayout(false);
            this.gbxSearchStock.PerformLayout();
            this.HistoryShelfRestockTab.ResumeLayout(false);
            this.HistoryShelfRestockTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSRRall)).EndInit();
            this.settingsTab.ResumeLayout(false);
            this.settingsTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlDepotWorkers;
        private System.Windows.Forms.TabPage MakeShelfRestockRequestsTab;
        private System.Windows.Forms.Button btnShowAllStocks;
        private System.Windows.Forms.GroupBox gbxStockChooseQuantity;
        private System.Windows.Forms.Button btnMakeShelfRestockRequest;
        private System.Windows.Forms.GroupBox gbxSearchStock;
        private System.Windows.Forms.TextBox tbxSearchStock;
        private System.Windows.Forms.TextBox tbxStockQuantity;
        private System.Windows.Forms.Label lbStockQuantity;
        private System.Windows.Forms.Label lbStockInfo;
        private System.Windows.Forms.Button btnConfirmRequest;
        private System.Windows.Forms.TabPage HistoryShelfRestockTab;
        private System.Windows.Forms.Label lbHistoryShelfRestockRequests;
        private System.Windows.Forms.Button btnClearSelected;
        private System.Windows.Forms.TabPage HomeTab;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbDateDayOfWeek;
        private System.Windows.Forms.Label lbGreetingMsg;
        private System.Windows.Forms.DataGridView dgvSRRall;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Panel historyShortcut;
        private System.Windows.Forms.Label historyLBL;
        private System.Windows.Forms.PictureBox historyPic;
        private System.Windows.Forms.Panel requestShortcut;
        private System.Windows.Forms.Label reqLBL;
        private System.Windows.Forms.PictureBox requestPic;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.Button applyShortcutsBTN;
        private System.Windows.Forms.CheckBox historyCH;
        private System.Windows.Forms.CheckBox reqCH;
    }
}