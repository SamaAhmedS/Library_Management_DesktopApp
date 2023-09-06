namespace SQLSERVER1.PL
{
    partial class SignAdmin
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
            this.err = new System.Windows.Forms.Label();
            this.SignUp = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SDep = new System.Windows.Forms.TextBox();
            this.SJoinDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.SPass = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.SEmail = new System.Windows.Forms.TextBox();
            this.SID = new System.Windows.Forms.Label();
            this.StudID = new System.Windows.Forms.TextBox();
            this.LName = new System.Windows.Forms.Label();
            this.LastN = new System.Windows.Forms.TextBox();
            this.FName = new System.Windows.Forms.Label();
            this.FirstN = new System.Windows.Forms.TextBox();
            this.StudInfo = new System.Windows.Forms.GroupBox();
            this.cancel = new System.Windows.Forms.Button();
            this.StudInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // err
            // 
            this.err.AutoSize = true;
            this.err.ForeColor = System.Drawing.Color.Red;
            this.err.Location = new System.Drawing.Point(57, 444);
            this.err.Name = "err";
            this.err.Size = new System.Drawing.Size(0, 19);
            this.err.TabIndex = 3966;
            // 
            // SignUp
            // 
            this.SignUp.BackColor = System.Drawing.Color.Black;
            this.SignUp.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp.ForeColor = System.Drawing.Color.White;
            this.SignUp.Location = new System.Drawing.Point(185, 498);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(110, 31);
            this.SignUp.TabIndex = 2;
            this.SignUp.Text = "SignUP";
            this.SignUp.UseVisualStyleBackColor = false;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 19);
            this.label9.TabIndex = 3964;
            this.label9.Text = "Hire Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 19);
            this.label10.TabIndex = 3963;
            this.label10.Text = "Role";
            // 
            // SDep
            // 
            this.SDep.Location = new System.Drawing.Point(61, 315);
            this.SDep.Name = "SDep";
            this.SDep.Size = new System.Drawing.Size(203, 26);
            this.SDep.TabIndex = 3960;
            // 
            // SJoinDate
            // 
            this.SJoinDate.Checked = false;
            this.SJoinDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SJoinDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SJoinDate.Location = new System.Drawing.Point(61, 366);
            this.SJoinDate.Name = "SJoinDate";
            this.SJoinDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SJoinDate.Size = new System.Drawing.Size(203, 26);
            this.SJoinDate.TabIndex = 3959;
            this.SJoinDate.Value = new System.DateTime(2023, 5, 21, 0, 0, 0, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 19);
            this.label11.TabIndex = 3958;
            this.label11.Text = "Password:";
            // 
            // SPass
            // 
            this.SPass.Location = new System.Drawing.Point(61, 264);
            this.SPass.Name = "SPass";
            this.SPass.Size = new System.Drawing.Size(203, 26);
            this.SPass.TabIndex = 3957;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(36, 189);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 19);
            this.label17.TabIndex = 3956;
            this.label17.Text = "Email:";
            // 
            // SEmail
            // 
            this.SEmail.Location = new System.Drawing.Point(61, 211);
            this.SEmail.Name = "SEmail";
            this.SEmail.Size = new System.Drawing.Size(203, 26);
            this.SEmail.TabIndex = 3955;
            // 
            // SID
            // 
            this.SID.AutoSize = true;
            this.SID.Location = new System.Drawing.Point(36, 132);
            this.SID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SID.Name = "SID";
            this.SID.Size = new System.Drawing.Size(31, 19);
            this.SID.TabIndex = 3946;
            this.SID.Text = "ID:";
            // 
            // StudID
            // 
            this.StudID.Location = new System.Drawing.Point(59, 153);
            this.StudID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StudID.Name = "StudID";
            this.StudID.Size = new System.Drawing.Size(205, 26);
            this.StudID.TabIndex = 3945;
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(36, 79);
            this.LName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(96, 19);
            this.LName.TabIndex = 3944;
            this.LName.Text = "Last Name:";
            // 
            // LastN
            // 
            this.LastN.Location = new System.Drawing.Point(60, 100);
            this.LastN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LastN.Name = "LastN";
            this.LastN.Size = new System.Drawing.Size(204, 26);
            this.LastN.TabIndex = 3943;
            // 
            // FName
            // 
            this.FName.AutoSize = true;
            this.FName.Location = new System.Drawing.Point(36, 25);
            this.FName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(97, 19);
            this.FName.TabIndex = 3942;
            this.FName.Text = "First Name:";
            // 
            // FirstN
            // 
            this.FirstN.Location = new System.Drawing.Point(60, 46);
            this.FirstN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FirstN.Name = "FirstN";
            this.FirstN.Size = new System.Drawing.Size(204, 26);
            this.FirstN.TabIndex = 3941;
            this.FirstN.TextChanged += new System.EventHandler(this.FirstN_TextChanged_1);
            // 
            // StudInfo
            // 
            this.StudInfo.BackColor = System.Drawing.Color.Black;
            this.StudInfo.Controls.Add(this.cancel);
            this.StudInfo.Controls.Add(this.err);
            this.StudInfo.Controls.Add(this.SignUp);
            this.StudInfo.Controls.Add(this.label9);
            this.StudInfo.Controls.Add(this.label10);
            this.StudInfo.Controls.Add(this.SDep);
            this.StudInfo.Controls.Add(this.SJoinDate);
            this.StudInfo.Controls.Add(this.label11);
            this.StudInfo.Controls.Add(this.SPass);
            this.StudInfo.Controls.Add(this.label17);
            this.StudInfo.Controls.Add(this.SEmail);
            this.StudInfo.Controls.Add(this.SID);
            this.StudInfo.Controls.Add(this.StudID);
            this.StudInfo.Controls.Add(this.LName);
            this.StudInfo.Controls.Add(this.LastN);
            this.StudInfo.Controls.Add(this.FName);
            this.StudInfo.Controls.Add(this.FirstN);
            this.StudInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudInfo.ForeColor = System.Drawing.Color.White;
            this.StudInfo.Location = new System.Drawing.Point(380, 2);
            this.StudInfo.Name = "StudInfo";
            this.StudInfo.Size = new System.Drawing.Size(339, 578);
            this.StudInfo.TabIndex = 3;
            this.StudInfo.TabStop = false;
            this.StudInfo.Text = "Admin Information";
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Black;
            this.cancel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.Location = new System.Drawing.Point(40, 498);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(110, 31);
            this.cancel.TabIndex = 3967;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // SignAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SQLSERVER1.Properties.Resources._1414;
            this.ClientSize = new System.Drawing.Size(913, 543);
            this.Controls.Add(this.StudInfo);
            this.Name = "SignAdmin";
            this.Text = "SignAdmin";
            this.Load += new System.EventHandler(this.SignAdmin_Load);
            this.StudInfo.ResumeLayout(false);
            this.StudInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label err;
        private System.Windows.Forms.Button SignUp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox SDep;
        private System.Windows.Forms.DateTimePicker SJoinDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox SPass;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox SEmail;
        private System.Windows.Forms.Label SID;
        private System.Windows.Forms.TextBox StudID;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.TextBox LastN;
        private System.Windows.Forms.Label FName;
        public System.Windows.Forms.TextBox FirstN;
        private System.Windows.Forms.GroupBox StudInfo;
        private System.Windows.Forms.Button cancel;
    }
}