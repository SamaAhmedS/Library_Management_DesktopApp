namespace SQLSERVER1.PL
{
    partial class studUpdate
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
            this.delete = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.Label();
            this.SignUp = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.SDep = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SPass = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.SEmail = new System.Windows.Forms.TextBox();
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
            this.StudInfo.Controls.Add(this.delete);
            this.StudInfo.Controls.Add(this.err);
            this.StudInfo.Controls.Add(this.SignUp);
            this.StudInfo.Controls.Add(this.label10);
            this.StudInfo.Controls.Add(this.SDep);
            this.StudInfo.Controls.Add(this.label11);
            this.StudInfo.Controls.Add(this.SPass);
            this.StudInfo.Controls.Add(this.label17);
            this.StudInfo.Controls.Add(this.SEmail);
            this.StudInfo.Controls.Add(this.LName);
            this.StudInfo.Controls.Add(this.LastN);
            this.StudInfo.Controls.Add(this.FName);
            this.StudInfo.Controls.Add(this.FirstN);
            this.StudInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudInfo.ForeColor = System.Drawing.Color.White;
            this.StudInfo.Location = new System.Drawing.Point(445, 39);
            this.StudInfo.Name = "StudInfo";
            this.StudInfo.Size = new System.Drawing.Size(324, 410);
            this.StudInfo.TabIndex = 3;
            this.StudInfo.TabStop = false;
            this.StudInfo.Text = "Student Information";
            this.StudInfo.Enter += new System.EventHandler(this.StudInfo_Enter);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Black;
            this.delete.Enabled = false;
            this.delete.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(28, 358);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(142, 31);
            this.delete.TabIndex = 3967;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Visible = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // err
            // 
            this.err.AutoSize = true;
            this.err.ForeColor = System.Drawing.Color.Red;
            this.err.Location = new System.Drawing.Point(31, 326);
            this.err.Name = "err";
            this.err.Size = new System.Drawing.Size(0, 19);
            this.err.TabIndex = 3966;
            // 
            // SignUp
            // 
            this.SignUp.BackColor = System.Drawing.Color.Black;
            this.SignUp.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp.ForeColor = System.Drawing.Color.White;
            this.SignUp.Location = new System.Drawing.Point(176, 358);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(142, 31);
            this.SignUp.TabIndex = 2;
            this.SignUp.Text = "Update";
            this.SignUp.UseVisualStyleBackColor = false;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 19);
            this.label10.TabIndex = 3963;
            this.label10.Text = "Department:";
            // 
            // SDep
            // 
            this.SDep.Location = new System.Drawing.Point(9, 269);
            this.SDep.Name = "SDep";
            this.SDep.Size = new System.Drawing.Size(252, 26);
            this.SDep.TabIndex = 3960;
            this.SDep.TextChanged += new System.EventHandler(this.SDep_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 19);
            this.label11.TabIndex = 3958;
            this.label11.Text = "Password:";
            // 
            // SPass
            // 
            this.SPass.Location = new System.Drawing.Point(9, 218);
            this.SPass.Name = "SPass";
            this.SPass.Size = new System.Drawing.Size(252, 26);
            this.SPass.TabIndex = 3957;
            this.SPass.TextChanged += new System.EventHandler(this.SPass_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 143);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 19);
            this.label17.TabIndex = 3956;
            this.label17.Text = "Email:";
            // 
            // SEmail
            // 
            this.SEmail.Location = new System.Drawing.Point(9, 165);
            this.SEmail.Name = "SEmail";
            this.SEmail.Size = new System.Drawing.Size(252, 26);
            this.SEmail.TabIndex = 3955;
            this.SEmail.TextChanged += new System.EventHandler(this.SEmail_TextChanged);
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(6, 77);
            this.LName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(96, 19);
            this.LName.TabIndex = 3944;
            this.LName.Text = "Last Name:";
            // 
            // LastN
            // 
            this.LastN.Location = new System.Drawing.Point(9, 100);
            this.LastN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LastN.Name = "LastN";
            this.LastN.Size = new System.Drawing.Size(252, 26);
            this.LastN.TabIndex = 3943;
            this.LastN.TextChanged += new System.EventHandler(this.LastN_TextChanged);
            // 
            // FName
            // 
            this.FName.AutoSize = true;
            this.FName.Location = new System.Drawing.Point(6, 25);
            this.FName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(97, 19);
            this.FName.TabIndex = 3942;
            this.FName.Text = "First Name:";
            // 
            // FirstN
            // 
            this.FirstN.Location = new System.Drawing.Point(9, 46);
            this.FirstN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FirstN.Name = "FirstN";
            this.FirstN.Size = new System.Drawing.Size(252, 26);
            this.FirstN.TabIndex = 3941;
            this.FirstN.TextChanged += new System.EventHandler(this.FirstN_TextChanged);
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.Color.Black;
            this.cancelbtn.Enabled = false;
            this.cancelbtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.ForeColor = System.Drawing.Color.White;
            this.cancelbtn.Location = new System.Drawing.Point(28, 358);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(142, 31);
            this.cancelbtn.TabIndex = 3968;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Visible = false;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // studUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SQLSERVER1.Properties.Resources._14141;
            this.ClientSize = new System.Drawing.Size(1002, 546);
            this.Controls.Add(this.StudInfo);
            this.Name = "studUpdate";
            this.Text = "studUpdate";
            this.Load += new System.EventHandler(this.studUpdate_Load);
            this.StudInfo.ResumeLayout(false);
            this.StudInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox StudInfo;
        private System.Windows.Forms.Label err;
        private System.Windows.Forms.Button SignUp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox SDep;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox SPass;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox SEmail;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.TextBox LastN;
        private System.Windows.Forms.Label FName;
        public System.Windows.Forms.TextBox FirstN;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button cancelbtn;
    }
}