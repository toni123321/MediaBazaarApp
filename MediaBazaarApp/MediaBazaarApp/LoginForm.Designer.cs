
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
            this.gbxLogIn = new System.Windows.Forms.GroupBox();
            this.lbEmpId = new System.Windows.Forms.Label();
            this.tbxEmpId = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.tbxEmpEmail = new System.Windows.Forms.TextBox();
            this.lbEmpEmail = new System.Windows.Forms.Label();
            this.lbMsg = new System.Windows.Forms.Label();
            this.gbxLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxLogIn
            // 
            this.gbxLogIn.Controls.Add(this.tbxEmpEmail);
            this.gbxLogIn.Controls.Add(this.lbEmpEmail);
            this.gbxLogIn.Controls.Add(this.btnLogIn);
            this.gbxLogIn.Controls.Add(this.tbxEmpId);
            this.gbxLogIn.Controls.Add(this.lbEmpId);
            this.gbxLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLogIn.Location = new System.Drawing.Point(73, 145);
            this.gbxLogIn.Name = "gbxLogIn";
            this.gbxLogIn.Size = new System.Drawing.Size(322, 249);
            this.gbxLogIn.TabIndex = 0;
            this.gbxLogIn.TabStop = false;
            this.gbxLogIn.Text = "Log in";
            // 
            // lbEmpId
            // 
            this.lbEmpId.AutoSize = true;
            this.lbEmpId.Location = new System.Drawing.Point(35, 104);
            this.lbEmpId.Name = "lbEmpId";
            this.lbEmpId.Size = new System.Drawing.Size(93, 18);
            this.lbEmpId.TabIndex = 0;
            this.lbEmpId.Text = "Employee Id:";
            // 
            // tbxEmpId
            // 
            this.tbxEmpId.Location = new System.Drawing.Point(140, 104);
            this.tbxEmpId.Name = "tbxEmpId";
            this.tbxEmpId.Size = new System.Drawing.Size(121, 24);
            this.tbxEmpId.TabIndex = 1;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(138, 158);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(123, 43);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "Log in";
            this.btnLogIn.UseVisualStyleBackColor = true;
            // 
            // tbxEmpEmail
            // 
            this.tbxEmpEmail.Location = new System.Drawing.Point(138, 59);
            this.tbxEmpEmail.Name = "tbxEmpEmail";
            this.tbxEmpEmail.Size = new System.Drawing.Size(121, 24);
            this.tbxEmpEmail.TabIndex = 0;
            // 
            // lbEmpEmail
            // 
            this.lbEmpEmail.AutoSize = true;
            this.lbEmpEmail.Location = new System.Drawing.Point(74, 62);
            this.lbEmpEmail.Name = "lbEmpEmail";
            this.lbEmpEmail.Size = new System.Drawing.Size(49, 18);
            this.lbEmpEmail.TabIndex = 3;
            this.lbEmpEmail.Text = "Email:";
            // 
            // lbMsg
            // 
            this.lbMsg.AutoSize = true;
            this.lbMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMsg.Location = new System.Drawing.Point(69, 83);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(302, 20);
            this.lbMsg.TabIndex = 1;
            this.lbMsg.Text = "Welcome to Media Bazaar system!";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 500);
            this.Controls.Add(this.lbMsg);
            this.Controls.Add(this.gbxLogIn);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.gbxLogIn.ResumeLayout(false);
            this.gbxLogIn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLogIn;
        private System.Windows.Forms.TextBox tbxEmpEmail;
        private System.Windows.Forms.Label lbEmpEmail;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox tbxEmpId;
        private System.Windows.Forms.Label lbEmpId;
        private System.Windows.Forms.Label lbMsg;
    }
}