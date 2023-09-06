namespace SQLSERVER1.PL
{
    partial class AppMainWindow
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.SignStud = new System.Windows.Forms.Button();
            this.SignAdmin = new System.Windows.Forms.Button();
            this.browsBooks = new System.Windows.Forms.Button();
            this.ManageBooks = new System.Windows.Forms.Button();
            this.Spanel = new System.Windows.Forms.Panel();
            this.Myloans = new System.Windows.Forms.Button();
            this.StudLogout = new System.Windows.Forms.Button();
            this.UpdateStudent = new System.Windows.Forms.Button();
            this.adminpanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.adminLogout = new System.Windows.Forms.Button();
            this.unlogedpanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.sid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Spanel.SuspendLayout();
            this.adminpanel.SuspendLayout();
            this.unlogedpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Location = new System.Drawing.Point(26, 159);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(155, 47);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // SignStud
            // 
            this.SignStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignStud.Location = new System.Drawing.Point(26, 79);
            this.SignStud.Name = "SignStud";
            this.SignStud.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.SignStud.Size = new System.Drawing.Size(155, 64);
            this.SignStud.TabIndex = 1;
            this.SignStud.Text = "SignUp as a student";
            this.SignStud.UseVisualStyleBackColor = true;
            this.SignStud.Click += new System.EventHandler(this.SignStud_Click_1);
            // 
            // SignAdmin
            // 
            this.SignAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.SignAdmin.Location = new System.Drawing.Point(26, 12);
            this.SignAdmin.Name = "SignAdmin";
            this.SignAdmin.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.SignAdmin.Size = new System.Drawing.Size(155, 58);
            this.SignAdmin.TabIndex = 2;
            this.SignAdmin.Text = "SignUp as an admin";
            this.SignAdmin.UseVisualStyleBackColor = true;
            this.SignAdmin.Click += new System.EventHandler(this.SignAdmin_Click_1);
            // 
            // browsBooks
            // 
            this.browsBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.browsBooks.Location = new System.Drawing.Point(29, 72);
            this.browsBooks.Name = "browsBooks";
            this.browsBooks.Size = new System.Drawing.Size(134, 55);
            this.browsBooks.TabIndex = 6;
            this.browsBooks.Text = "Browse Books";
            this.browsBooks.UseVisualStyleBackColor = true;
            this.browsBooks.Click += new System.EventHandler(this.browsBooks_Click_1);
            // 
            // ManageBooks
            // 
            this.ManageBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ManageBooks.Location = new System.Drawing.Point(28, 75);
            this.ManageBooks.Name = "ManageBooks";
            this.ManageBooks.Size = new System.Drawing.Size(134, 48);
            this.ManageBooks.TabIndex = 7;
            this.ManageBooks.Text = "Browse and manage books";
            this.ManageBooks.UseVisualStyleBackColor = true;
            this.ManageBooks.Click += new System.EventHandler(this.ManageBooks_Click_1);
            // 
            // Spanel
            // 
            this.Spanel.Controls.Add(this.Myloans);
            this.Spanel.Controls.Add(this.StudLogout);
            this.Spanel.Controls.Add(this.browsBooks);
            this.Spanel.Controls.Add(this.UpdateStudent);
            this.Spanel.Location = new System.Drawing.Point(174, 290);
            this.Spanel.Name = "Spanel";
            this.Spanel.Size = new System.Drawing.Size(190, 251);
            this.Spanel.TabIndex = 11;
            // 
            // Myloans
            // 
            this.Myloans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Myloans.Location = new System.Drawing.Point(29, 133);
            this.Myloans.Name = "Myloans";
            this.Myloans.Size = new System.Drawing.Size(134, 54);
            this.Myloans.TabIndex = 8;
            this.Myloans.Text = "My Loans";
            this.Myloans.UseVisualStyleBackColor = true;
            this.Myloans.Click += new System.EventHandler(this.Myloans_Click);
            // 
            // StudLogout
            // 
            this.StudLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.StudLogout.Location = new System.Drawing.Point(29, 193);
            this.StudLogout.Name = "StudLogout";
            this.StudLogout.Size = new System.Drawing.Size(134, 48);
            this.StudLogout.TabIndex = 7;
            this.StudLogout.Text = "Logout";
            this.StudLogout.UseVisualStyleBackColor = true;
            this.StudLogout.Click += new System.EventHandler(this.StudLogout_Click_1);
            // 
            // UpdateStudent
            // 
            this.UpdateStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.UpdateStudent.Location = new System.Drawing.Point(29, 17);
            this.UpdateStudent.Name = "UpdateStudent";
            this.UpdateStudent.Size = new System.Drawing.Size(134, 49);
            this.UpdateStudent.TabIndex = 5;
            this.UpdateStudent.Text = "Update my details";
            this.UpdateStudent.UseVisualStyleBackColor = true;
            this.UpdateStudent.Click += new System.EventHandler(this.UpdateStudent_Click);
            // 
            // adminpanel
            // 
            this.adminpanel.Controls.Add(this.button3);
            this.adminpanel.Controls.Add(this.button2);
            this.adminpanel.Controls.Add(this.adminLogout);
            this.adminpanel.Controls.Add(this.ManageBooks);
            this.adminpanel.Location = new System.Drawing.Point(164, 10);
            this.adminpanel.Name = "adminpanel";
            this.adminpanel.Size = new System.Drawing.Size(200, 259);
            this.adminpanel.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(28, 140);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 48);
            this.button3.TabIndex = 10;
            this.button3.Text = "Search for student ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(28, 10);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 48);
            this.button2.TabIndex = 9;
            this.button2.Text = "Update my details";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // adminLogout
            // 
            this.adminLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.adminLogout.Location = new System.Drawing.Point(28, 204);
            this.adminLogout.Name = "adminLogout";
            this.adminLogout.Size = new System.Drawing.Size(134, 48);
            this.adminLogout.TabIndex = 8;
            this.adminLogout.Text = "Logout";
            this.adminLogout.UseVisualStyleBackColor = true;
            this.adminLogout.Click += new System.EventHandler(this.adminLogout_Click_1);
            // 
            // unlogedpanel
            // 
            this.unlogedpanel.Controls.Add(this.btnLogin);
            this.unlogedpanel.Controls.Add(this.SignStud);
            this.unlogedpanel.Controls.Add(this.SignAdmin);
            this.unlogedpanel.Location = new System.Drawing.Point(447, 202);
            this.unlogedpanel.Name = "unlogedpanel";
            this.unlogedpanel.Size = new System.Drawing.Size(218, 223);
            this.unlogedpanel.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(551, 560);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Show Statics";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.search);
            this.panel1.Controls.Add(this.sid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(645, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 192);
            this.panel1.TabIndex = 14;
            this.panel1.Visible = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(23, 97);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 34);
            this.button4.TabIndex = 10;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.search.Location = new System.Drawing.Point(123, 97);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(95, 34);
            this.search.TabIndex = 9;
            this.search.Text = "Show";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // sid
            // 
            this.sid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sid.Location = new System.Drawing.Point(40, 52);
            this.sid.Margin = new System.Windows.Forms.Padding(2);
            this.sid.Name = "sid";
            this.sid.Size = new System.Drawing.Size(178, 24);
            this.sid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID:";
            // 
            // AppMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SQLSERVER1.Properties.Resources._1414;
            this.ClientSize = new System.Drawing.Size(1234, 711);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Spanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.adminpanel);
            this.Controls.Add(this.unlogedpanel);
            this.Name = "AppMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AppMainWindow_Load_1);
            this.Spanel.ResumeLayout(false);
            this.adminpanel.ResumeLayout(false);
            this.unlogedpanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button SignStud;
        private System.Windows.Forms.Button SignAdmin;
        private System.Windows.Forms.Button browsBooks;
        private System.Windows.Forms.Button ManageBooks;
        private System.Windows.Forms.Panel Spanel;
        private System.Windows.Forms.Button StudLogout;
        private System.Windows.Forms.Panel adminpanel;
        private System.Windows.Forms.Button adminLogout;
        private System.Windows.Forms.Panel unlogedpanel;
        private System.Windows.Forms.Button UpdateStudent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox sid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Myloans;
    }
}