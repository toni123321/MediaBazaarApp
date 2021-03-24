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
            this.removeAmountBTN = new System.Windows.Forms.Button();
            this.removeStockBTN = new System.Windows.Forms.Button();
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
            this.lbQuantity.Location = new System.Drawing.Point(0, 28);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(49, 13);
            this.lbQuantity.TabIndex = 1;
            this.lbQuantity.Text = "Quantity:";
            // 
            // removeAmountBTN
            // 
            this.removeAmountBTN.Location = new System.Drawing.Point(3, 83);
            this.removeAmountBTN.Name = "removeAmountBTN";
            this.removeAmountBTN.Size = new System.Drawing.Size(106, 23);
            this.removeAmountBTN.TabIndex = 2;
            this.removeAmountBTN.Text = "Remove amount:";
            this.removeAmountBTN.UseVisualStyleBackColor = true;
            this.removeAmountBTN.Click += new System.EventHandler(this.RemoveAmountBTN_Click);
            // 
            // removeStockBTN
            // 
            this.removeStockBTN.Location = new System.Drawing.Point(352, 83);
            this.removeStockBTN.Name = "removeStockBTN";
            this.removeStockBTN.Size = new System.Drawing.Size(90, 23);
            this.removeStockBTN.TabIndex = 3;
            this.removeStockBTN.Text = "Remove stock";
            this.removeStockBTN.UseVisualStyleBackColor = true;
            this.removeStockBTN.Click += new System.EventHandler(this.RemoveStockBTN_Click);
            // 
            // removeAmountTBX
            // 
            this.removeAmountTBX.Location = new System.Drawing.Point(115, 86);
            this.removeAmountTBX.Name = "removeAmountTBX";
            this.removeAmountTBX.Size = new System.Drawing.Size(100, 20);
            this.removeAmountTBX.TabIndex = 4;
            // 
            // RemoveStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 118);
            this.Controls.Add(this.removeAmountTBX);
            this.Controls.Add(this.removeStockBTN);
            this.Controls.Add(this.removeAmountBTN);
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
        private System.Windows.Forms.Button removeAmountBTN;
        private System.Windows.Forms.Button removeStockBTN;
        private System.Windows.Forms.TextBox removeAmountTBX;
    }
}