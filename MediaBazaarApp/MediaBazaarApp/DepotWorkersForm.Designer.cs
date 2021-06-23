
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
            this.components = new System.ComponentModel.Container();
            this.tabControlDepotWorkers = new System.Windows.Forms.TabControl();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.historyShortcut = new System.Windows.Forms.Panel();
            this.historyLBL = new System.Windows.Forms.Label();
            this.requestShortcut = new System.Windows.Forms.Panel();
            this.reqLBL = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbDateDayOfWeek = new System.Windows.Forms.Label();
            this.lbGreetingMsg = new System.Windows.Forms.Label();
            this.MakeShelfRestockRequestsTab = new System.Windows.Forms.TabPage();
            this.lbViewIncomingRestockRequests = new System.Windows.Forms.Label();
            this.dgvSRRPending = new System.Windows.Forms.DataGridView();
            this.btnSehflRestockRequestsClearSelected = new System.Windows.Forms.Button();
            this.btnShelftRestockRequestsMarkAsDone = new System.Windows.Forms.Button();
            this.btnShelftRestockRequestsDecline = new System.Windows.Forms.Button();
            this.HistoryShelfRestockTab = new System.Windows.Forms.TabPage();
            this.dgvSRRdone = new System.Windows.Forms.DataGridView();
            this.lbHistoryShelfRestockRequests = new System.Windows.Forms.Label();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.applyShortcutsBTN = new System.Windows.Forms.Button();
            this.historyCH = new System.Windows.Forms.CheckBox();
            this.reqCH = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.historyPic = new System.Windows.Forms.PictureBox();
            this.reqPic = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.tabControlDepotWorkers.SuspendLayout();
            this.HomeTab.SuspendLayout();
            this.historyShortcut.SuspendLayout();
            this.requestShortcut.SuspendLayout();
            this.MakeShelfRestockRequestsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSRRPending)).BeginInit();
            this.HistoryShelfRestockTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSRRdone)).BeginInit();
            this.settingsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlDepotWorkers
            // 
            this.tabControlDepotWorkers.Controls.Add(this.HomeTab);
            this.tabControlDepotWorkers.Controls.Add(this.MakeShelfRestockRequestsTab);
            this.tabControlDepotWorkers.Controls.Add(this.HistoryShelfRestockTab);
            this.tabControlDepotWorkers.Controls.Add(this.settingsTab);
            this.tabControlDepotWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlDepotWorkers.Location = new System.Drawing.Point(0, 14);
            this.tabControlDepotWorkers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlDepotWorkers.Name = "tabControlDepotWorkers";
            this.tabControlDepotWorkers.SelectedIndex = 0;
            this.tabControlDepotWorkers.Size = new System.Drawing.Size(900, 639);
            this.tabControlDepotWorkers.TabIndex = 2;
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
            this.HomeTab.Location = new System.Drawing.Point(4, 24);
            this.HomeTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Size = new System.Drawing.Size(892, 611);
            this.HomeTab.TabIndex = 3;
            this.HomeTab.Text = "Home";
            // 
            // historyShortcut
            // 
            this.historyShortcut.BackColor = System.Drawing.Color.LightSalmon;
            this.historyShortcut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.historyShortcut.Controls.Add(this.historyLBL);
            this.historyShortcut.Controls.Add(this.historyPic);
            this.historyShortcut.Location = new System.Drawing.Point(514, 481);
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
            // requestShortcut
            // 
            this.requestShortcut.BackColor = System.Drawing.Color.LightSalmon;
            this.requestShortcut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.requestShortcut.Controls.Add(this.reqLBL);
            this.requestShortcut.Controls.Add(this.reqPic);
            this.requestShortcut.Location = new System.Drawing.Point(514, 395);
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
            this.reqLBL.Location = new System.Drawing.Point(74, 22);
            this.reqLBL.Name = "reqLBL";
            this.reqLBL.Size = new System.Drawing.Size(216, 21);
            this.reqLBL.TabIndex = 1;
            this.reqLBL.Text = "View incoming stock requests";
            this.reqLBL.Click += new System.EventHandler(this.ReqLBL_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTime.Location = new System.Drawing.Point(51, 217);
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
            this.lbDateDayOfWeek.Location = new System.Drawing.Point(51, 277);
            this.lbDateDayOfWeek.Name = "lbDateDayOfWeek";
            this.lbDateDayOfWeek.Size = new System.Drawing.Size(223, 45);
            this.lbDateDayOfWeek.TabIndex = 13;
            this.lbDateDayOfWeek.Text = "Monday, 1 Jan";
            // 
            // lbGreetingMsg
            // 
            this.lbGreetingMsg.AutoSize = true;
            this.lbGreetingMsg.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGreetingMsg.Location = new System.Drawing.Point(49, 142);
            this.lbGreetingMsg.Name = "lbGreetingMsg";
            this.lbGreetingMsg.Size = new System.Drawing.Size(421, 51);
            this.lbGreetingMsg.TabIndex = 12;
            this.lbGreetingMsg.Text = "Good morning, Name!";
            // 
            // MakeShelfRestockRequestsTab
            // 
            this.MakeShelfRestockRequestsTab.BackColor = System.Drawing.Color.MediumTurquoise;
            this.MakeShelfRestockRequestsTab.Controls.Add(this.lbViewIncomingRestockRequests);
            this.MakeShelfRestockRequestsTab.Controls.Add(this.dgvSRRPending);
            this.MakeShelfRestockRequestsTab.Controls.Add(this.btnSehflRestockRequestsClearSelected);
            this.MakeShelfRestockRequestsTab.Controls.Add(this.btnShelftRestockRequestsMarkAsDone);
            this.MakeShelfRestockRequestsTab.Controls.Add(this.btnShelftRestockRequestsDecline);
            this.MakeShelfRestockRequestsTab.Location = new System.Drawing.Point(4, 24);
            this.MakeShelfRestockRequestsTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MakeShelfRestockRequestsTab.Name = "MakeShelfRestockRequestsTab";
            this.MakeShelfRestockRequestsTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MakeShelfRestockRequestsTab.Size = new System.Drawing.Size(892, 611);
            this.MakeShelfRestockRequestsTab.TabIndex = 0;
            this.MakeShelfRestockRequestsTab.Text = "View incoming restock requests";
            // 
            // lbViewIncomingRestockRequests
            // 
            this.lbViewIncomingRestockRequests.AutoSize = true;
            this.lbViewIncomingRestockRequests.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbViewIncomingRestockRequests.Location = new System.Drawing.Point(296, 42);
            this.lbViewIncomingRestockRequests.Name = "lbViewIncomingRestockRequests";
            this.lbViewIncomingRestockRequests.Size = new System.Drawing.Size(243, 21);
            this.lbViewIncomingRestockRequests.TabIndex = 26;
            this.lbViewIncomingRestockRequests.Text = "Incoming shelf restock requests";
            // 
            // dgvSRRPending
            // 
            this.dgvSRRPending.AllowUserToAddRows = false;
            this.dgvSRRPending.AllowUserToDeleteRows = false;
            this.dgvSRRPending.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSRRPending.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvSRRPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSRRPending.Location = new System.Drawing.Point(6, 88);
            this.dgvSRRPending.Name = "dgvSRRPending";
            this.dgvSRRPending.ReadOnly = true;
            this.dgvSRRPending.RowHeadersWidth = 51;
            this.dgvSRRPending.RowTemplate.Height = 24;
            this.dgvSRRPending.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSRRPending.Size = new System.Drawing.Size(880, 386);
            this.dgvSRRPending.TabIndex = 25;
            // 
            // btnSehflRestockRequestsClearSelected
            // 
            this.btnSehflRestockRequestsClearSelected.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSehflRestockRequestsClearSelected.Location = new System.Drawing.Point(703, 515);
            this.btnSehflRestockRequestsClearSelected.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSehflRestockRequestsClearSelected.Name = "btnSehflRestockRequestsClearSelected";
            this.btnSehflRestockRequestsClearSelected.Size = new System.Drawing.Size(160, 52);
            this.btnSehflRestockRequestsClearSelected.TabIndex = 19;
            this.btnSehflRestockRequestsClearSelected.Text = "Unmark selected";
            this.btnSehflRestockRequestsClearSelected.UseVisualStyleBackColor = false;
            this.btnSehflRestockRequestsClearSelected.Click += new System.EventHandler(this.btnSehflRestockRequestsClearSelected_Click);
            // 
            // btnShelftRestockRequestsMarkAsDone
            // 
            this.btnShelftRestockRequestsMarkAsDone.BackColor = System.Drawing.Color.SpringGreen;
            this.btnShelftRestockRequestsMarkAsDone.Location = new System.Drawing.Point(26, 515);
            this.btnShelftRestockRequestsMarkAsDone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShelftRestockRequestsMarkAsDone.Name = "btnShelftRestockRequestsMarkAsDone";
            this.btnShelftRestockRequestsMarkAsDone.Size = new System.Drawing.Size(160, 52);
            this.btnShelftRestockRequestsMarkAsDone.TabIndex = 18;
            this.btnShelftRestockRequestsMarkAsDone.Text = "Done";
            this.btnShelftRestockRequestsMarkAsDone.UseVisualStyleBackColor = false;
            this.btnShelftRestockRequestsMarkAsDone.Click += new System.EventHandler(this.btnShelftRestockRequestsMarkAsDone_Click);
            // 
            // btnShelftRestockRequestsDecline
            // 
            this.btnShelftRestockRequestsDecline.BackColor = System.Drawing.Color.OrangeRed;
            this.btnShelftRestockRequestsDecline.Location = new System.Drawing.Point(203, 515);
            this.btnShelftRestockRequestsDecline.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShelftRestockRequestsDecline.Name = "btnShelftRestockRequestsDecline";
            this.btnShelftRestockRequestsDecline.Size = new System.Drawing.Size(160, 52);
            this.btnShelftRestockRequestsDecline.TabIndex = 17;
            this.btnShelftRestockRequestsDecline.Text = "Decline";
            this.btnShelftRestockRequestsDecline.UseVisualStyleBackColor = false;
            this.btnShelftRestockRequestsDecline.Click += new System.EventHandler(this.btnShelftRestockRequestsDecline_Click);
            // 
            // HistoryShelfRestockTab
            // 
            this.HistoryShelfRestockTab.BackColor = System.Drawing.Color.MediumTurquoise;
            this.HistoryShelfRestockTab.Controls.Add(this.dgvSRRdone);
            this.HistoryShelfRestockTab.Controls.Add(this.lbHistoryShelfRestockRequests);
            this.HistoryShelfRestockTab.Location = new System.Drawing.Point(4, 24);
            this.HistoryShelfRestockTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HistoryShelfRestockTab.Name = "HistoryShelfRestockTab";
            this.HistoryShelfRestockTab.Size = new System.Drawing.Size(892, 611);
            this.HistoryShelfRestockTab.TabIndex = 2;
            this.HistoryShelfRestockTab.Text = "History shelf restock requests";
            // 
            // dgvSRRdone
            // 
            this.dgvSRRdone.AllowUserToAddRows = false;
            this.dgvSRRdone.AllowUserToDeleteRows = false;
            this.dgvSRRdone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSRRdone.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvSRRdone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSRRdone.Location = new System.Drawing.Point(17, 123);
            this.dgvSRRdone.Name = "dgvSRRdone";
            this.dgvSRRdone.ReadOnly = true;
            this.dgvSRRdone.RowHeadersWidth = 51;
            this.dgvSRRdone.RowTemplate.Height = 24;
            this.dgvSRRdone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSRRdone.Size = new System.Drawing.Size(860, 417);
            this.dgvSRRdone.TabIndex = 25;
            // 
            // lbHistoryShelfRestockRequests
            // 
            this.lbHistoryShelfRestockRequests.AutoSize = true;
            this.lbHistoryShelfRestockRequests.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbHistoryShelfRestockRequests.Location = new System.Drawing.Point(297, 55);
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
            this.settingsTab.Size = new System.Drawing.Size(892, 611);
            this.settingsTab.TabIndex = 4;
            this.settingsTab.Text = "Settings";
            // 
            // applyShortcutsBTN
            // 
            this.applyShortcutsBTN.Location = new System.Drawing.Point(542, 94);
            this.applyShortcutsBTN.Name = "applyShortcutsBTN";
            this.applyShortcutsBTN.Size = new System.Drawing.Size(110, 52);
            this.applyShortcutsBTN.TabIndex = 18;
            this.applyShortcutsBTN.Text = "Apply ";
            this.applyShortcutsBTN.UseVisualStyleBackColor = true;
            this.applyShortcutsBTN.Click += new System.EventHandler(this.ApplyShortcutsBTN_Click_1);
            // 
            // historyCH
            // 
            this.historyCH.Appearance = System.Windows.Forms.Appearance.Button;
            this.historyCH.Location = new System.Drawing.Point(8, 75);
            this.historyCH.Name = "historyCH";
            this.historyCH.Size = new System.Drawing.Size(239, 71);
            this.historyCH.TabIndex = 17;
            this.historyCH.Text = "View shelf restock requests history shortcut";
            this.historyCH.UseVisualStyleBackColor = true;
            // 
            // reqCH
            // 
            this.reqCH.Appearance = System.Windows.Forms.Appearance.Button;
            this.reqCH.Location = new System.Drawing.Point(8, 6);
            this.reqCH.Name = "reqCH";
            this.reqCH.Size = new System.Drawing.Size(239, 63);
            this.reqCH.TabIndex = 16;
            this.reqCH.Text = "View shelf restock request shortcut";
            this.reqCH.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            // reqPic
            // 
            this.reqPic.Cursor = System.Windows.Forms.Cursors.Default;
            this.reqPic.Image = global::MediaBazaarApp.Properties.Resources.outline_swap_horiz_black_24dp;
            this.reqPic.Location = new System.Drawing.Point(12, 11);
            this.reqPic.Name = "reqPic";
            this.reqPic.Size = new System.Drawing.Size(56, 57);
            this.reqPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.reqPic.TabIndex = 0;
            this.reqPic.TabStop = false;
            this.reqPic.Click += new System.EventHandler(this.ReqPic_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::MediaBazaarApp.Properties.Resources.MediaBazaarLogo;
            this.pictureBox7.Location = new System.Drawing.Point(19, 395);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(223, 191);
            this.pictureBox7.TabIndex = 15;
            this.pictureBox7.TabStop = false;
            // 
            // DepotWorkersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 653);
            this.Controls.Add(this.tabControlDepotWorkers);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DepotWorkersForm";
            this.Text = "DepotWorkersForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SalesForm_FormClosed);
            this.Load += new System.EventHandler(this.DepotWorkersForm_Load);
            this.tabControlDepotWorkers.ResumeLayout(false);
            this.HomeTab.ResumeLayout(false);
            this.HomeTab.PerformLayout();
            this.historyShortcut.ResumeLayout(false);
            this.historyShortcut.PerformLayout();
            this.requestShortcut.ResumeLayout(false);
            this.requestShortcut.PerformLayout();
            this.MakeShelfRestockRequestsTab.ResumeLayout(false);
            this.MakeShelfRestockRequestsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSRRPending)).EndInit();
            this.HistoryShelfRestockTab.ResumeLayout(false);
            this.HistoryShelfRestockTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSRRdone)).EndInit();
            this.settingsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.historyPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlDepotWorkers;
        private System.Windows.Forms.TabPage HomeTab;
        private System.Windows.Forms.TabPage MakeShelfRestockRequestsTab;
        private System.Windows.Forms.TabPage HistoryShelfRestockTab;
        private System.Windows.Forms.Label lbHistoryShelfRestockRequests;
        private System.Windows.Forms.Button btnSehflRestockRequestsClearSelected;
        private System.Windows.Forms.Button btnShelftRestockRequestsMarkAsDone;
        private System.Windows.Forms.Button btnShelftRestockRequestsDecline;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbDateDayOfWeek;
        private System.Windows.Forms.Label lbGreetingMsg;
        private System.Windows.Forms.DataGridView dgvSRRPending;
        private System.Windows.Forms.DataGridView dgvSRRdone;
        private System.Windows.Forms.Panel historyShortcut;
        private System.Windows.Forms.Label historyLBL;
        private System.Windows.Forms.PictureBox historyPic;
        private System.Windows.Forms.Panel requestShortcut;
        private System.Windows.Forms.Label reqLBL;
        private System.Windows.Forms.PictureBox reqPic;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.Button applyShortcutsBTN;
        private System.Windows.Forms.CheckBox historyCH;
        private System.Windows.Forms.CheckBox reqCH;
        private System.Windows.Forms.Label lbViewIncomingRestockRequests;
    }
}