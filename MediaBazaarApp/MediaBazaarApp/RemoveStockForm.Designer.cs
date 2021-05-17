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
            this.lbProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbProduct.Location = new System.Drawing.Point(1, 10);
            this.lbProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(88, 28);
            this.lbProduct.TabIndex = 0;
            this.lbProduct.Text = "Product:";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbQuantity.Location = new System.Drawing.Point(1, 44);
            this.lbQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(95, 28);
            this.lbQuantity.TabIndex = 1;
            this.lbQuantity.Text = "Quantity:";
            // 
            // removeAmountBTN
            // 
            this.removeAmountBTN.BackColor = System.Drawing.Color.LightSalmon;
            this.removeAmountBTN.Location = new System.Drawing.Point(5, 102);
            this.removeAmountBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeAmountBTN.Name = "removeAmountBTN";
            this.removeAmountBTN.Size = new System.Drawing.Size(123, 36);
            this.removeAmountBTN.TabIndex = 2;
            this.removeAmountBTN.Text = "Remove amount:";
            this.removeAmountBTN.UseVisualStyleBackColor = false;
            this.removeAmountBTN.Click += new System.EventHandler(this.RemoveAmountBTN_Click);
            // 
            // removeStockBTN
            // 
            this.removeStockBTN.BackColor = System.Drawing.Color.LightSalmon;
            this.removeStockBTN.Location = new System.Drawing.Point(402, 102);
            this.removeStockBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeStockBTN.Name = "removeStockBTN";
            this.removeStockBTN.Size = new System.Drawing.Size(105, 36);
            this.removeStockBTN.TabIndex = 3;
            this.removeStockBTN.Text = "Remove stock";
            this.removeStockBTN.UseVisualStyleBackColor = false;
            this.removeStockBTN.Click += new System.EventHandler(this.RemoveStockBTN_Click);
            // 
            // removeAmountTBX
            // 
            this.removeAmountTBX.BackColor = System.Drawing.Color.WhiteSmoke;
            this.removeAmountTBX.Location = new System.Drawing.Point(136, 108);
            this.removeAmountTBX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeAmountTBX.Name = "removeAmountTBX";
            this.removeAmountTBX.Size = new System.Drawing.Size(116, 25);
            this.removeAmountTBX.TabIndex = 4;
            // 
            // RemoveStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(519, 154);
            this.Controls.Add(this.removeAmountTBX);
            this.Controls.Add(this.removeStockBTN);
            this.Controls.Add(this.removeAmountBTN);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbProduct);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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