
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
            this.lbWeight = new System.Windows.Forms.Label();
            this.tbxStockWeight = new System.Windows.Forms.TextBox();
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
            this.tbxStockPrice = new System.Windows.Forms.TextBox();
            this.lbStockPrice = new System.Windows.Forms.Label();
            this.tbxStockModel = new System.Windows.Forms.TextBox();
            this.lbStockModel = new System.Windows.Forms.Label();
            this.tbxStockBrand = new System.Windows.Forms.TextBox();
            this.lbStockBrand = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEditStock
            // 
            this.btnEditStock.BackColor = System.Drawing.Color.LightSalmon;
            this.btnEditStock.Location = new System.Drawing.Point(29, 818);
            this.btnEditStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditStock.Name = "btnEditStock";
            this.btnEditStock.Size = new System.Drawing.Size(252, 54);
            this.btnEditStock.TabIndex = 14;
            this.btnEditStock.Text = "Apply changes";
            this.btnEditStock.UseVisualStyleBackColor = false;
            this.btnEditStock.Click += new System.EventHandler(this.BtnEditStock_Click);
            // 
            // stockLb
            // 
            this.stockLb.AutoSize = true;
            this.stockLb.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.stockLb.Location = new System.Drawing.Point(93, 41);
            this.stockLb.Name = "stockLb";
            this.stockLb.Size = new System.Drawing.Size(165, 28);
            this.stockLb.TabIndex = 2;
            this.stockLb.Text = "Stock with id:(id)";
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(95, 508);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(59, 20);
            this.lbWeight.TabIndex = 21;
            this.lbWeight.Text = "Weight:";
            // 
            // tbxStockWeight
            // 
            this.tbxStockWeight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxStockWeight.Location = new System.Drawing.Point(100, 531);
            this.tbxStockWeight.Name = "tbxStockWeight";
            this.tbxStockWeight.Size = new System.Drawing.Size(136, 27);
            this.tbxStockWeight.TabIndex = 16;
            // 
            // tbxStockDepth
            // 
            this.tbxStockDepth.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxStockDepth.Location = new System.Drawing.Point(99, 468);
            this.tbxStockDepth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxStockDepth.Name = "tbxStockDepth";
            this.tbxStockDepth.Size = new System.Drawing.Size(137, 27);
            this.tbxStockDepth.TabIndex = 20;
            // 
            // lbStockDepth
            // 
            this.lbStockDepth.AutoSize = true;
            this.lbStockDepth.Location = new System.Drawing.Point(95, 443);
            this.lbStockDepth.Name = "lbStockDepth";
            this.lbStockDepth.Size = new System.Drawing.Size(53, 20);
            this.lbStockDepth.TabIndex = 19;
            this.lbStockDepth.Text = "Depth:";
            // 
            // tbxStockHeight
            // 
            this.tbxStockHeight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxStockHeight.Location = new System.Drawing.Point(98, 399);
            this.tbxStockHeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxStockHeight.Name = "tbxStockHeight";
            this.tbxStockHeight.Size = new System.Drawing.Size(137, 27);
            this.tbxStockHeight.TabIndex = 18;
            // 
            // lbStockHeight
            // 
            this.lbStockHeight.AutoSize = true;
            this.lbStockHeight.Location = new System.Drawing.Point(95, 374);
            this.lbStockHeight.Name = "lbStockHeight";
            this.lbStockHeight.Size = new System.Drawing.Size(57, 20);
            this.lbStockHeight.TabIndex = 17;
            this.lbStockHeight.Text = "Height:";
            // 
            // tbxStockWidth
            // 
            this.tbxStockWidth.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxStockWidth.Location = new System.Drawing.Point(98, 331);
            this.tbxStockWidth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxStockWidth.Name = "tbxStockWidth";
            this.tbxStockWidth.Size = new System.Drawing.Size(137, 27);
            this.tbxStockWidth.TabIndex = 16;
            // 
            // lbStockWidth
            // 
            this.lbStockWidth.AutoSize = true;
            this.lbStockWidth.Location = new System.Drawing.Point(95, 307);
            this.lbStockWidth.Name = "lbStockWidth";
            this.lbStockWidth.Size = new System.Drawing.Size(52, 20);
            this.lbStockWidth.TabIndex = 15;
            this.lbStockWidth.Text = "Width:";
            // 
            // tbxStockQuantity
            // 
            this.tbxStockQuantity.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxStockQuantity.Location = new System.Drawing.Point(99, 608);
            this.tbxStockQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxStockQuantity.Name = "tbxStockQuantity";
            this.tbxStockQuantity.Size = new System.Drawing.Size(137, 27);
            this.tbxStockQuantity.TabIndex = 13;
            // 
            // lbStockQuantity
            // 
            this.lbStockQuantity.AutoSize = true;
            this.lbStockQuantity.Location = new System.Drawing.Point(97, 573);
            this.lbStockQuantity.Name = "lbStockQuantity";
            this.lbStockQuantity.Size = new System.Drawing.Size(68, 20);
            this.lbStockQuantity.TabIndex = 12;
            this.lbStockQuantity.Text = "Quantity:";
            // 
            // tbxStockShortDescription
            // 
            this.tbxStockShortDescription.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxStockShortDescription.Location = new System.Drawing.Point(29, 692);
            this.tbxStockShortDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxStockShortDescription.Multiline = true;
            this.tbxStockShortDescription.Name = "tbxStockShortDescription";
            this.tbxStockShortDescription.Size = new System.Drawing.Size(253, 104);
            this.tbxStockShortDescription.TabIndex = 9;
            // 
            // lbStockShortDescription
            // 
            this.lbStockShortDescription.AutoSize = true;
            this.lbStockShortDescription.Location = new System.Drawing.Point(95, 651);
            this.lbStockShortDescription.Name = "lbStockShortDescription";
            this.lbStockShortDescription.Size = new System.Drawing.Size(125, 20);
            this.lbStockShortDescription.TabIndex = 8;
            this.lbStockShortDescription.Text = "Short description:";
            // 
            // tbxStockPrice
            // 
            this.tbxStockPrice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxStockPrice.Location = new System.Drawing.Point(98, 262);
            this.tbxStockPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxStockPrice.Name = "tbxStockPrice";
            this.tbxStockPrice.Size = new System.Drawing.Size(137, 27);
            this.tbxStockPrice.TabIndex = 5;
            // 
            // lbStockPrice
            // 
            this.lbStockPrice.AutoSize = true;
            this.lbStockPrice.Location = new System.Drawing.Point(95, 239);
            this.lbStockPrice.Name = "lbStockPrice";
            this.lbStockPrice.Size = new System.Drawing.Size(44, 20);
            this.lbStockPrice.TabIndex = 4;
            this.lbStockPrice.Text = "Price:";
            // 
            // tbxStockModel
            // 
            this.tbxStockModel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxStockModel.Location = new System.Drawing.Point(98, 197);
            this.tbxStockModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxStockModel.Name = "tbxStockModel";
            this.tbxStockModel.Size = new System.Drawing.Size(137, 27);
            this.tbxStockModel.TabIndex = 3;
            // 
            // lbStockModel
            // 
            this.lbStockModel.AutoSize = true;
            this.lbStockModel.Location = new System.Drawing.Point(95, 172);
            this.lbStockModel.Name = "lbStockModel";
            this.lbStockModel.Size = new System.Drawing.Size(55, 20);
            this.lbStockModel.TabIndex = 2;
            this.lbStockModel.Text = "Model:";
            // 
            // tbxStockBrand
            // 
            this.tbxStockBrand.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxStockBrand.Location = new System.Drawing.Point(98, 130);
            this.tbxStockBrand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxStockBrand.Name = "tbxStockBrand";
            this.tbxStockBrand.Size = new System.Drawing.Size(137, 27);
            this.tbxStockBrand.TabIndex = 1;
            // 
            // lbStockBrand
            // 
            this.lbStockBrand.AutoSize = true;
            this.lbStockBrand.Location = new System.Drawing.Point(95, 96);
            this.lbStockBrand.Name = "lbStockBrand";
            this.lbStockBrand.Size = new System.Drawing.Size(51, 20);
            this.lbStockBrand.TabIndex = 0;
            this.lbStockBrand.Text = "Brand:";
            // 
            // EditStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(349, 895);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.tbxStockWeight);
            this.Controls.Add(this.stockLb);
            this.Controls.Add(this.tbxStockDepth);
            this.Controls.Add(this.lbStockBrand);
            this.Controls.Add(this.lbStockDepth);
            this.Controls.Add(this.tbxStockBrand);
            this.Controls.Add(this.btnEditStock);
            this.Controls.Add(this.lbStockModel);
            this.Controls.Add(this.tbxStockHeight);
            this.Controls.Add(this.tbxStockModel);
            this.Controls.Add(this.lbStockHeight);
            this.Controls.Add(this.lbStockPrice);
            this.Controls.Add(this.tbxStockWidth);
            this.Controls.Add(this.tbxStockPrice);
            this.Controls.Add(this.lbStockWidth);
            this.Controls.Add(this.tbxStockQuantity);
            this.Controls.Add(this.lbStockShortDescription);
            this.Controls.Add(this.lbStockQuantity);
            this.Controls.Add(this.tbxStockShortDescription);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EditStockForm";
            this.Text = "EditStockForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEditStock;
        private System.Windows.Forms.Label stockLb;
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