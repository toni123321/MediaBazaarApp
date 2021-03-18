
namespace MediaBazaarApp
{
    partial class EditStockForm
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
            this.btnEditStock = new System.Windows.Forms.Button();
            this.stockLb = new System.Windows.Forms.Label();
            this.gbxEditStock = new System.Windows.Forms.GroupBox();
            this.tbxStockDepth = new System.Windows.Forms.TextBox();
            this.lbStockDepth = new System.Windows.Forms.Label();
            this.tbxStockHeight = new System.Windows.Forms.TextBox();
            this.lbStockHeight = new System.Windows.Forms.Label();
            this.tbxStockWidth = new System.Windows.Forms.TextBox();
            this.lbStockWidth = new System.Windows.Forms.Label();
            this.tbxStockQuantity = new System.Windows.Forms.TextBox();
            this.lbStockQuantity = new System.Windows.Forms.Label();
            this.tbxStockShortDescription = new System.Windows.Forms.TextBox();
            this.lbStockShortDescription = new System.Windows.Forms.Label();
            this.lbStockDimensions = new System.Windows.Forms.Label();
            this.tbxStockPrice = new System.Windows.Forms.TextBox();
            this.lbStockPrice = new System.Windows.Forms.Label();
            this.tbxStockModel = new System.Windows.Forms.TextBox();
            this.lbStockModel = new System.Windows.Forms.Label();
            this.tbxStockBrand = new System.Windows.Forms.TextBox();
            this.lbStockBrand = new System.Windows.Forms.Label();
            this.tbxStockWeight = new System.Windows.Forms.TextBox();
            this.lbWeight = new System.Windows.Forms.Label();
            this.gbxEditStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditStock
            // 
            this.btnEditStock.Location = new System.Drawing.Point(19, 580);
            this.btnEditStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditStock.Name = "btnEditStock";
            this.btnEditStock.Size = new System.Drawing.Size(259, 49);
            this.btnEditStock.TabIndex = 14;
            this.btnEditStock.Text = "Apply changes";
            this.btnEditStock.UseVisualStyleBackColor = true;
            this.btnEditStock.Click += new System.EventHandler(this.BtnEditStock_Click);
            // 
            // stockLb
            // 
            this.stockLb.AutoSize = true;
            this.stockLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockLb.Location = new System.Drawing.Point(126, 31);
            this.stockLb.Name = "stockLb";
            this.stockLb.Size = new System.Drawing.Size(114, 15);
            this.stockLb.TabIndex = 2;
            this.stockLb.Text = "Stock with id:(id)";
            // 
            // gbxEditStock
            // 
            this.gbxEditStock.Controls.Add(this.lbWeight);
            this.gbxEditStock.Controls.Add(this.tbxStockWeight);
            this.gbxEditStock.Controls.Add(this.tbxStockDepth);
            this.gbxEditStock.Controls.Add(this.lbStockDepth);
            this.gbxEditStock.Controls.Add(this.btnEditStock);
            this.gbxEditStock.Controls.Add(this.tbxStockHeight);
            this.gbxEditStock.Controls.Add(this.lbStockHeight);
            this.gbxEditStock.Controls.Add(this.tbxStockWidth);
            this.gbxEditStock.Controls.Add(this.lbStockWidth);
            this.gbxEditStock.Controls.Add(this.tbxStockQuantity);
            this.gbxEditStock.Controls.Add(this.lbStockQuantity);
            this.gbxEditStock.Controls.Add(this.tbxStockShortDescription);
            this.gbxEditStock.Controls.Add(this.lbStockShortDescription);
            this.gbxEditStock.Controls.Add(this.lbStockDimensions);
            this.gbxEditStock.Controls.Add(this.tbxStockPrice);
            this.gbxEditStock.Controls.Add(this.lbStockPrice);
            this.gbxEditStock.Controls.Add(this.tbxStockModel);
            this.gbxEditStock.Controls.Add(this.lbStockModel);
            this.gbxEditStock.Controls.Add(this.tbxStockBrand);
            this.gbxEditStock.Controls.Add(this.lbStockBrand);
            this.gbxEditStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEditStock.Location = new System.Drawing.Point(35, 77);
            this.gbxEditStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxEditStock.Name = "gbxEditStock";
            this.gbxEditStock.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxEditStock.Size = new System.Drawing.Size(326, 648);
            this.gbxEditStock.TabIndex = 15;
            this.gbxEditStock.TabStop = false;
            this.gbxEditStock.Text = "Edit stock";
            // 
            // tbxStockDepth
            // 
            this.tbxStockDepth.Location = new System.Drawing.Point(123, 305);
            this.tbxStockDepth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxStockDepth.Name = "tbxStockDepth";
            this.tbxStockDepth.Size = new System.Drawing.Size(154, 21);
            this.tbxStockDepth.TabIndex = 20;
            // 
            // lbStockDepth
            // 
            this.lbStockDepth.AutoSize = true;
            this.lbStockDepth.Location = new System.Drawing.Point(33, 311);
            this.lbStockDepth.Name = "lbStockDepth";
            this.lbStockDepth.Size = new System.Drawing.Size(43, 15);
            this.lbStockDepth.TabIndex = 19;
            this.lbStockDepth.Text = "Depth:";
            // 
            // tbxStockHeight
            // 
            this.tbxStockHeight.Location = new System.Drawing.Point(124, 262);
            this.tbxStockHeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxStockHeight.Name = "tbxStockHeight";
            this.tbxStockHeight.Size = new System.Drawing.Size(154, 21);
            this.tbxStockHeight.TabIndex = 18;
            // 
            // lbStockHeight
            // 
            this.lbStockHeight.AutoSize = true;
            this.lbStockHeight.Location = new System.Drawing.Point(33, 265);
            this.lbStockHeight.Name = "lbStockHeight";
            this.lbStockHeight.Size = new System.Drawing.Size(46, 15);
            this.lbStockHeight.TabIndex = 17;
            this.lbStockHeight.Text = "Height:";
            // 
            // tbxStockWidth
            // 
            this.tbxStockWidth.Location = new System.Drawing.Point(124, 216);
            this.tbxStockWidth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxStockWidth.Name = "tbxStockWidth";
            this.tbxStockWidth.Size = new System.Drawing.Size(154, 21);
            this.tbxStockWidth.TabIndex = 16;
            // 
            // lbStockWidth
            // 
            this.lbStockWidth.AutoSize = true;
            this.lbStockWidth.Location = new System.Drawing.Point(33, 220);
            this.lbStockWidth.Name = "lbStockWidth";
            this.lbStockWidth.Size = new System.Drawing.Size(41, 15);
            this.lbStockWidth.TabIndex = 15;
            this.lbStockWidth.Text = "Width:";
            // 
            // tbxStockQuantity
            // 
            this.tbxStockQuantity.Location = new System.Drawing.Point(123, 383);
            this.tbxStockQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxStockQuantity.Name = "tbxStockQuantity";
            this.tbxStockQuantity.Size = new System.Drawing.Size(154, 21);
            this.tbxStockQuantity.TabIndex = 13;
            // 
            // lbStockQuantity
            // 
            this.lbStockQuantity.AutoSize = true;
            this.lbStockQuantity.Location = new System.Drawing.Point(33, 386);
            this.lbStockQuantity.Name = "lbStockQuantity";
            this.lbStockQuantity.Size = new System.Drawing.Size(54, 15);
            this.lbStockQuantity.TabIndex = 12;
            this.lbStockQuantity.Text = "Quantity:";
            // 
            // tbxStockShortDescription
            // 
            this.tbxStockShortDescription.Location = new System.Drawing.Point(19, 457);
            this.tbxStockShortDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxStockShortDescription.Multiline = true;
            this.tbxStockShortDescription.Name = "tbxStockShortDescription";
            this.tbxStockShortDescription.Size = new System.Drawing.Size(258, 94);
            this.tbxStockShortDescription.TabIndex = 9;
            // 
            // lbStockShortDescription
            // 
            this.lbStockShortDescription.AutoSize = true;
            this.lbStockShortDescription.Location = new System.Drawing.Point(82, 419);
            this.lbStockShortDescription.Name = "lbStockShortDescription";
            this.lbStockShortDescription.Size = new System.Drawing.Size(102, 15);
            this.lbStockShortDescription.TabIndex = 8;
            this.lbStockShortDescription.Text = "Short description:";
            // 
            // lbStockDimensions
            // 
            this.lbStockDimensions.AutoSize = true;
            this.lbStockDimensions.Location = new System.Drawing.Point(97, 175);
            this.lbStockDimensions.Name = "lbStockDimensions";
            this.lbStockDimensions.Size = new System.Drawing.Size(76, 15);
            this.lbStockDimensions.TabIndex = 6;
            this.lbStockDimensions.Text = "Dimensions:";
            // 
            // tbxStockPrice
            // 
            this.tbxStockPrice.Location = new System.Drawing.Point(124, 126);
            this.tbxStockPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxStockPrice.Name = "tbxStockPrice";
            this.tbxStockPrice.Size = new System.Drawing.Size(154, 21);
            this.tbxStockPrice.TabIndex = 5;
            // 
            // lbStockPrice
            // 
            this.lbStockPrice.AutoSize = true;
            this.lbStockPrice.Location = new System.Drawing.Point(40, 126);
            this.lbStockPrice.Name = "lbStockPrice";
            this.lbStockPrice.Size = new System.Drawing.Size(38, 15);
            this.lbStockPrice.TabIndex = 4;
            this.lbStockPrice.Text = "Price:";
            // 
            // tbxStockModel
            // 
            this.tbxStockModel.Location = new System.Drawing.Point(124, 76);
            this.tbxStockModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxStockModel.Name = "tbxStockModel";
            this.tbxStockModel.Size = new System.Drawing.Size(154, 21);
            this.tbxStockModel.TabIndex = 3;
            // 
            // lbStockModel
            // 
            this.lbStockModel.AutoSize = true;
            this.lbStockModel.Location = new System.Drawing.Point(33, 80);
            this.lbStockModel.Name = "lbStockModel";
            this.lbStockModel.Size = new System.Drawing.Size(45, 15);
            this.lbStockModel.TabIndex = 2;
            this.lbStockModel.Text = "Model:";
            // 
            // tbxStockBrand
            // 
            this.tbxStockBrand.Location = new System.Drawing.Point(124, 31);
            this.tbxStockBrand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxStockBrand.Name = "tbxStockBrand";
            this.tbxStockBrand.Size = new System.Drawing.Size(154, 21);
            this.tbxStockBrand.TabIndex = 1;
            // 
            // lbStockBrand
            // 
            this.lbStockBrand.AutoSize = true;
            this.lbStockBrand.Location = new System.Drawing.Point(33, 34);
            this.lbStockBrand.Name = "lbStockBrand";
            this.lbStockBrand.Size = new System.Drawing.Size(43, 15);
            this.lbStockBrand.TabIndex = 0;
            this.lbStockBrand.Text = "Brand:";
            // 
            // tbxStockWeight
            // 
            this.tbxStockWeight.Location = new System.Drawing.Point(124, 341);
            this.tbxStockWeight.Name = "tbxStockWeight";
            this.tbxStockWeight.Size = new System.Drawing.Size(153, 21);
            this.tbxStockWeight.TabIndex = 16;
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(33, 347);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(48, 15);
            this.lbWeight.TabIndex = 21;
            this.lbWeight.Text = "Weight:";
            // 
            // EditStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 756);
            this.Controls.Add(this.gbxEditStock);
            this.Controls.Add(this.stockLb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EditStockForm";
            this.Text = "EditStockForm";
            this.gbxEditStock.ResumeLayout(false);
            this.gbxEditStock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEditStock;
        private System.Windows.Forms.Label stockLb;
        private System.Windows.Forms.GroupBox gbxEditStock;
        private System.Windows.Forms.TextBox tbxStockDepth;
        private System.Windows.Forms.Label lbStockDepth;
        private System.Windows.Forms.TextBox tbxStockHeight;
        private System.Windows.Forms.Label lbStockHeight;
        private System.Windows.Forms.TextBox tbxStockWidth;
        private System.Windows.Forms.Label lbStockWidth;
        private System.Windows.Forms.TextBox tbxStockQuantity;
        private System.Windows.Forms.Label lbStockQuantity;
        private System.Windows.Forms.TextBox tbxStockShortDescription;
        private System.Windows.Forms.Label lbStockShortDescription;
        private System.Windows.Forms.Label lbStockDimensions;
        private System.Windows.Forms.TextBox tbxStockPrice;
        private System.Windows.Forms.Label lbStockPrice;
        private System.Windows.Forms.TextBox tbxStockModel;
        private System.Windows.Forms.Label lbStockModel;
        private System.Windows.Forms.TextBox tbxStockBrand;
        private System.Windows.Forms.Label lbStockBrand;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.TextBox tbxStockWeight;
    }
}