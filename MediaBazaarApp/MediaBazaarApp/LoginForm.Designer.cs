
namespace MediaBazaarApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.lbDepartment = new System.Windows.Forms.Label();
            this.tbxEmpEmail = new System.Windows.Forms.TextBox();
            this.lbEmpEmail = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.tbxEmpId = new System.Windows.Forms.TextBox();
            this.lbEmpId = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDepartment
            // 
            this.cbDepartment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Items.AddRange(new object[] {
            "Administration",
            "Management",
            "Sales",
            "Depot"});
            this.cbDepartment.Location = new System.Drawing.Point(51, 306);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(281, 30);
            this.cbDepartment.TabIndex = 1;
            // 
            // lbDepartment
            // 
            this.lbDepartment.AutoSize = true;
            this.lbDepartment.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartment.Location = new System.Drawing.Point(48, 285);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(105, 25);
            this.lbDepartment.TabIndex = 10;
            this.lbDepartment.Text = "Department";
            // 
            // tbxEmpEmail
            // 
            this.tbxEmpEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmpEmail.Location = new System.Drawing.Point(51, 254);
            this.tbxEmpEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmpEmail.Name = "tbxEmpEmail";
            this.tbxEmpEmail.Size = new System.Drawing.Size(281, 28);
            this.tbxEmpEmail.TabIndex = 0;
            // 
            // lbEmpEmail
            // 
            this.lbEmpEmail.AutoSize = true;
            this.lbEmpEmail.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpEmail.Location = new System.Drawing.Point(48, 232);
            this.lbEmpEmail.Name = "lbEmpEmail";
            this.lbEmpEmail.Size = new System.Drawing.Size(53, 25);
            this.lbEmpEmail.TabIndex = 6;
            this.lbEmpEmail.Text = "Email";
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.LightSalmon;
            this.btnLogIn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.Location = new System.Drawing.Point(97, 428);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(200, 49);
            this.btnLogIn.TabIndex = 3;
            this.btnLogIn.Text = "Log in";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // tbxEmpId
            // 
            this.tbxEmpId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmpId.Location = new System.Drawing.Point(51, 362);
            this.tbxEmpId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmpId.Name = "tbxEmpId";
            this.tbxEmpId.Size = new System.Drawing.Size(95, 28);
            this.tbxEmpId.TabIndex = 2;
            // 
            // lbEmpId
            // 
            this.lbEmpId.AutoSize = true;
            this.lbEmpId.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpId.Location = new System.Drawing.Point(48, 340);
            this.lbEmpId.Name = "lbEmpId";
            this.lbEmpId.Size = new System.Drawing.Size(107, 25);
            this.lbEmpId.TabIndex = 8;
            this.lbEmpId.Text = "Employee ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MediaBazaarApp.Properties.Resources.MediaBazaarLogo1;
            this.pictureBox1.Location = new System.Drawing.Point(97, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(410, 533);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.lbDepartment);
            this.Controls.Add(this.tbxEmpEmail);
            this.Controls.Add(this.lbEmpEmail);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.tbxEmpId);
            this.Controls.Add(this.lbEmpId);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label lbDepartment;
        private System.Windows.Forms.TextBox tbxEmpEmail;
        private System.Windows.Forms.Label lbEmpEmail;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox tbxEmpId;
        private System.Windows.Forms.Label lbEmpId;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}