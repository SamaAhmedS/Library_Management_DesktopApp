namespace SQLSERVER1.PL
{
    partial class UpdateAdmin
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
            this.StudInfo = new System.Windows.Forms.GroupBox();
            this.err = new System.Windows.Forms.Label();
            this.SignUp = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.LName = new System.Windows.Forms.Label();
            this.LastN = new System.Windows.Forms.TextBox();
            this.FName = new System.Windows.Forms.Label();
            this.FirstN = new System.Windows.Forms.TextBox();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.StudInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudInfo
            // 
            this.StudInfo.BackColor = System.Drawing.Color.Black;
            this.StudInfo.Controls.Add(this.cancelbtn);
            this.StudInfo.Controls.Add(this.err);
            this.StudInfo.Controls.Add(this.SignUp);
            this.StudInfo.Controls.Add(this.label10);
            this.StudInfo.Controls.Add(this.role);
            this.StudInfo.Controls.Add(this.label11);
            this.StudInfo.Controls.Add(this.Pass);
            this.StudInfo.Controls.Add(this.label17);
            this.StudInfo.Controls.Add(this.Email);
            this.StudInfo.Controls.Add(this.LName);
            this.StudInfo.Controls.Add(this.LastN);
            this.StudInfo.Controls.Add(this.FName);
            this.StudInfo.Controls.Add(this.FirstN);
            this.StudInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudInfo.ForeColor = System.Drawing.Color.White;
            this.StudInfo.Location = new System.Drawing.Point(386, 55);
            this.StudInfo.Name = "StudInfo";
            this.StudInfo.Size = new System.Drawing.Size(279, 421);
            this.StudInfo.TabIndex = 4;
            this.StudInfo.TabStop = false;
            this.StudInfo.Text = "Admin Information";
            // 
            // err
            // 
            this.err.AutoSize = true;
            this.err.ForeColor = System.Drawing.Color.Red;
            this.err.Location = new System.Drawing.Point(41, 322);
            this.err.Name = "err";
            this.err.Size = new System.Drawing.Size(0, 19);
            this.err.TabIndex = 3966;
            // 
            // SignUp
            // 
            this.SignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignUp.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp.ForeColor = System.Drawing.Color.White;
            this.SignUp.Location = new System.Drawing.Point(146, 358);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(108, 45);
            this.SignUp.TabIndex = 2;
            this.SignUp.Text = "Update";
            this.SignUp.UseVisualStyleBackColor = false;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click_2);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 19);
            this.label10.TabIndex = 3963;
            this.label10.Text = "Role:";
            // 
            // role
            // 
            this.role.Location = new System.Drawing.Point(35, 278);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(203, 26);
            this.role.TabIndex = 3960;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 19);
            this.label11.TabIndex = 3958;
            this.label11.Text = "Password:";
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(35, 222);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(203, 26);
            this.Pass.TabIndex = 3957;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 144);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 19);
            this.label17.TabIndex = 3956;
            this.label17.Text = "Email:";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(35, 166);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(203, 26);
            this.Email.TabIndex = 3955;
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(8, 82);
            this.LName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(96, 19);
            this.LName.TabIndex = 3944;
            this.LName.Text = "Last Name:";
            // 
            // LastN
            // 
            this.LastN.Location = new System.Drawing.Point(35, 109);
            this.LastN.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.LastN.Name = "LastN";
            this.LastN.Size = new System.Drawing.Size(204, 26);
            this.LastN.TabIndex = 3943;
            // 
            // FName
            // 
            this.FName.AutoSize = true;
            this.FName.Location = new System.Drawing.Point(8, 30);
            this.FName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(97, 19);
            this.FName.TabIndex = 3942;
            this.FName.Text = "First Name:";
            this.FName.Click += new System.EventHandler(this.FName_Click);
            // 
            // FirstN
            // 
            this.FirstN.Location = new System.Drawing.Point(35, 51);
            this.FirstN.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.FirstN.Name = "FirstN";
            this.FirstN.Size = new System.Drawing.Size(204, 26);
            this.FirstN.TabIndex = 3941;
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancelbtn.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.ForeColor = System.Drawing.Color.White;
            this.cancelbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelbtn.Location = new System.Drawing.Point(12, 356);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(109, 45);
            this.cancelbtn.TabIndex = 3967;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // UpdateAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SQLSERVER1.Properties.Resources._14141;
            this.ClientSize = new System.Drawing.Size(907, 524);
            this.ControlBox = false;
            this.Controls.Add(this.StudInfo);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "UpdateAdmin";
            this.Text = "UpdateAdmin";
            this.Load += new System.EventHandler(this.UpdateAdmin_Load_1);
            this.StudInfo.ResumeLayout(false);
            this.StudInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox StudInfo;
        private System.Windows.Forms.Label err;
        private System.Windows.Forms.Button SignUp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox role;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.TextBox LastN;
        private System.Windows.Forms.Label FName;
        public System.Windows.Forms.TextBox FirstN;
        public System.Windows.Forms.Button cancelbtn;
    }
}