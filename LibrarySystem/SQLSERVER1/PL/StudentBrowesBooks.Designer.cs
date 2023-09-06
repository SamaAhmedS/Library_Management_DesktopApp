namespace SQLSERVER1.PL
{
    partial class StudentBrowesBooks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectCID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.TextBox();
            this.FD = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.copError = new System.Windows.Forms.Label();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.ToD = new System.Windows.Forms.DateTimePicker();
            this.Browbook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AllBooks = new System.Windows.Forms.GroupBox();
            this.nBooks = new System.Windows.Forms.Label();
            this.Borrowbtn = new System.Windows.Forms.Button();
            this.BooksTable = new System.Windows.Forms.DataGridView();
            this.toDay = new System.Windows.Forms.DateTimePicker();
            this.Back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.AllBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.selectCID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.b);
            this.panel1.Controls.Add(this.FD);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.copError);
            this.panel1.Controls.Add(this.cancelbtn);
            this.panel1.Controls.Add(this.ToD);
            this.panel1.Controls.Add(this.Browbook);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 431);
            this.panel1.TabIndex = 5;
            // 
            // selectCID
            // 
            this.selectCID.FormattingEnabled = true;
            this.selectCID.Location = new System.Drawing.Point(17, 130);
            this.selectCID.Name = "selectCID";
            this.selectCID.Size = new System.Drawing.Size(190, 21);
            this.selectCID.TabIndex = 394;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 393;
            this.label4.Text = "Book ID:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(17, 54);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(190, 20);
            this.b.TabIndex = 392;
            // 
            // FD
            // 
            this.FD.Location = new System.Drawing.Point(17, 217);
            this.FD.Margin = new System.Windows.Forms.Padding(2);
            this.FD.Name = "FD";
            this.FD.Size = new System.Drawing.Size(190, 20);
            this.FD.TabIndex = 390;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(3, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 389;
            this.label3.Text = "From Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(1, 256);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 388;
            this.label2.Text = "To Date";
            // 
            // copError
            // 
            this.copError.AutoSize = true;
            this.copError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copError.ForeColor = System.Drawing.Color.White;
            this.copError.Location = new System.Drawing.Point(61, 310);
            this.copError.Name = "copError";
            this.copError.Size = new System.Drawing.Size(0, 24);
            this.copError.TabIndex = 387;
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancelbtn.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.ForeColor = System.Drawing.Color.White;
            this.cancelbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelbtn.Location = new System.Drawing.Point(7, 370);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(109, 45);
            this.cancelbtn.TabIndex = 386;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click_1);
            // 
            // ToD
            // 
            this.ToD.Checked = false;
            this.ToD.Location = new System.Drawing.Point(17, 289);
            this.ToD.Name = "ToD";
            this.ToD.Size = new System.Drawing.Size(190, 20);
            this.ToD.TabIndex = 0;
            // 
            // Browbook
            // 
            this.Browbook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Browbook.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browbook.ForeColor = System.Drawing.Color.White;
            this.Browbook.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Browbook.Location = new System.Drawing.Point(122, 370);
            this.Browbook.Name = "Browbook";
            this.Browbook.Size = new System.Drawing.Size(109, 45);
            this.Browbook.TabIndex = 385;
            this.Browbook.Text = "Borrow ";
            this.Browbook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Browbook.UseVisualStyleBackColor = false;
            this.Browbook.Click += new System.EventHandler(this.Browbook_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Copy ID:";
            // 
            // AllBooks
            // 
            this.AllBooks.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AllBooks.Controls.Add(this.nBooks);
            this.AllBooks.Controls.Add(this.Borrowbtn);
            this.AllBooks.Controls.Add(this.BooksTable);
            this.AllBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllBooks.ForeColor = System.Drawing.Color.White;
            this.AllBooks.Location = new System.Drawing.Point(252, 44);
            this.AllBooks.Name = "AllBooks";
            this.AllBooks.Size = new System.Drawing.Size(1017, 592);
            this.AllBooks.TabIndex = 4;
            this.AllBooks.TabStop = false;
            this.AllBooks.Text = "All Books";
            this.AllBooks.Enter += new System.EventHandler(this.AllBooks_Enter);
            // 
            // nBooks
            // 
            this.nBooks.AutoSize = true;
            this.nBooks.Location = new System.Drawing.Point(382, 39);
            this.nBooks.Name = "nBooks";
            this.nBooks.Size = new System.Drawing.Size(0, 24);
            this.nBooks.TabIndex = 390;
            // 
            // Borrowbtn
            // 
            this.Borrowbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Borrowbtn.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrowbtn.ForeColor = System.Drawing.Color.White;
            this.Borrowbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Borrowbtn.Location = new System.Drawing.Point(435, 528);
            this.Borrowbtn.Name = "Borrowbtn";
            this.Borrowbtn.Size = new System.Drawing.Size(237, 57);
            this.Borrowbtn.TabIndex = 384;
            this.Borrowbtn.Text = "Borrow This Book";
            this.Borrowbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Borrowbtn.UseVisualStyleBackColor = false;
            this.Borrowbtn.Click += new System.EventHandler(this.Borrowbtn_Click);
            // 
            // BooksTable
            // 
            this.BooksTable.AllowUserToAddRows = false;
            this.BooksTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BooksTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BooksTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksTable.GridColor = System.Drawing.Color.Gray;
            this.BooksTable.Location = new System.Drawing.Point(7, 91);
            this.BooksTable.MultiSelect = false;
            this.BooksTable.Name = "BooksTable";
            this.BooksTable.ReadOnly = true;
            this.BooksTable.RowHeadersWidth = 62;
            this.BooksTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BooksTable.Size = new System.Drawing.Size(1006, 564);
            this.BooksTable.TabIndex = 347;
            this.BooksTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BooksTable_CellContentClick);
            // 
            // toDay
            // 
            this.toDay.Location = new System.Drawing.Point(12, 494);
            this.toDay.Name = "toDay";
            this.toDay.Size = new System.Drawing.Size(200, 20);
            this.toDay.TabIndex = 391;
            this.toDay.Visible = false;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Gray;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(0, 0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(128, 29);
            this.Back.TabIndex = 392;
            this.Back.Text = "Back to home";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // StudentBrowesBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::SQLSERVER1.Properties.Resources._14141;
            this.ClientSize = new System.Drawing.Size(1320, 655);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.toDay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AllBooks);
            this.Name = "StudentBrowesBooks";
            this.Text = "StudentBrowesBooks";
            this.Load += new System.EventHandler(this.StudentBrowesBooks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.AllBooks.ResumeLayout(false);
            this.AllBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label copError;
        public System.Windows.Forms.Button cancelbtn;
        public System.Windows.Forms.Button Browbook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox AllBooks;
        private System.Windows.Forms.DateTimePicker ToD;
        private System.Windows.Forms.Label nBooks;
        public System.Windows.Forms.Button Borrowbtn;
        private System.Windows.Forms.DataGridView BooksTable;
        private System.Windows.Forms.DateTimePicker FD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox selectCID;
        private System.Windows.Forms.DateTimePicker toDay;
        private System.Windows.Forms.Button Back;
    }
}