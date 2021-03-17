namespace MediaBazaarApp
{
    partial class RemoveStockForm
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
            this.lbProduct = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.RemoveStockAmountBTN = new System.Windows.Forms.Button();
            this.RemoveStockBTN = new System.Windows.Forms.Button();
            this.removeAmountTBX = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbProduct
            // 
            this.lbProduct.AutoSize = true;
            this.lbProduct.Location = new System.Drawing.Point(0, 0);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(47, 13);
            this.lbProduct.TabIndex = 0;
            this.lbProduct.Text = "Product:";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(0, 34);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(49, 13);
            this.lbQuantity.TabIndex = 1;
            this.lbQuantity.Text = "Quantity:";
            // 
            // RemoveStockAmountBTN
            // 
            this.RemoveStockAmountBTN.Location = new System.Drawing.Point(3, 101);
            this.RemoveStockAmountBTN.Name = "RemoveStockAmountBTN";
            this.RemoveStockAmountBTN.Size = new System.Drawing.Size(107, 23);
            this.RemoveStockAmountBTN.TabIndex = 2;
            this.RemoveStockAmountBTN.Text = "Remove amount:";
            this.RemoveStockAmountBTN.UseVisualStyleBackColor = true;
            this.RemoveStockAmountBTN.Click += new System.EventHandler(this.RemoveStockAmountBTN_Click);
            // 
            // RemoveStockBTN
            // 
            this.RemoveStockBTN.Location = new System.Drawing.Point(343, 101);
            this.RemoveStockBTN.Name = "RemoveStockBTN";
            this.RemoveStockBTN.Size = new System.Drawing.Size(87, 23);
            this.RemoveStockBTN.TabIndex = 3;
            this.RemoveStockBTN.Text = "Remove stock";
            this.RemoveStockBTN.UseVisualStyleBackColor = true;
            this.RemoveStockBTN.Click += new System.EventHandler(this.RemoveStockBTN_Click);
            // 
            // removeAmountTBX
            // 
            this.removeAmountTBX.Location = new System.Drawing.Point(116, 101);
            this.removeAmountTBX.Name = "removeAmountTBX";
            this.removeAmountTBX.Size = new System.Drawing.Size(100, 20);
            this.removeAmountTBX.TabIndex = 4;
            // 
            // RemoveStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 133);
            this.Controls.Add(this.removeAmountTBX);
            this.Controls.Add(this.RemoveStockBTN);
            this.Controls.Add(this.RemoveStockAmountBTN);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbProduct);
            this.Name = "RemoveStockForm";
            this.Text = "RemoveStockForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbProduct;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Button RemoveStockAmountBTN;
        private System.Windows.Forms.Button RemoveStockBTN;
        private System.Windows.Forms.TextBox removeAmountTBX;
    }
}