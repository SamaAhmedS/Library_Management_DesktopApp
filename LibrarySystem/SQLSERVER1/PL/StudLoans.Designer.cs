namespace SQLSERVER1.PL
{
    partial class StudLoans
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AllBooks = new System.Windows.Forms.GroupBox();
            this.CancelLoan = new System.Windows.Forms.Button();
            this.nBooks = new System.Windows.Forms.Label();
            this.BooksTable = new System.Windows.Forms.DataGridView();
            this.Back = new System.Windows.Forms.Button();
            this.AllBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksTable)).BeginInit();
            this.SuspendLayout();
            // 
            // AllBooks
            // 
            this.AllBooks.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AllBooks.Controls.Add(this.CancelLoan);
            this.AllBooks.Controls.Add(this.nBooks);
            this.AllBooks.Controls.Add(this.BooksTable);
            this.AllBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllBooks.ForeColor = System.Drawing.Color.White;
            this.AllBooks.Location = new System.Drawing.Point(137, 79);
            this.AllBooks.Name = "AllBooks";
            this.AllBooks.Size = new System.Drawing.Size(959, 606);
            this.AllBooks.TabIndex = 4;
            this.AllBooks.TabStop = false;
            this.AllBooks.Text = "All Books";
            this.AllBooks.Enter += new System.EventHandler(this.AllBooks_Enter);
            // 
            // CancelLoan
            // 
            this.CancelLoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelLoan.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelLoan.ForeColor = System.Drawing.Color.White;
            this.CancelLoan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelLoan.Location = new System.Drawing.Point(366, 525);
            this.CancelLoan.Name = "CancelLoan";
            this.CancelLoan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.CancelLoan.Size = new System.Drawing.Size(237, 57);
            this.CancelLoan.TabIndex = 402;
            this.CancelLoan.Text = "Cancel This Loan";
            this.CancelLoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelLoan.UseVisualStyleBackColor = false;
            this.CancelLoan.Click += new System.EventHandler(this.CancelLoan_Click);
            // 
            // nBooks
            // 
            this.nBooks.AutoSize = true;
            this.nBooks.Location = new System.Drawing.Point(446, 42);
            this.nBooks.Name = "nBooks";
            this.nBooks.Size = new System.Drawing.Size(57, 24);
            this.nBooks.TabIndex = 392;
            this.nBooks.Text = "Book";
            // 
            // BooksTable
            // 
            this.BooksTable.AllowUserToAddRows = false;
            this.BooksTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.BooksTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BooksTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BooksTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksTable.GridColor = System.Drawing.Color.Gray;
            this.BooksTable.Location = new System.Drawing.Point(3, 96);
            this.BooksTable.MultiSelect = false;
            this.BooksTable.Name = "BooksTable";
            this.BooksTable.ReadOnly = true;
            this.BooksTable.RowHeadersWidth = 62;
            this.BooksTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BooksTable.Size = new System.Drawing.Size(952, 505);
            this.BooksTable.TabIndex = 347;
            this.BooksTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BooksTable_CellContentClick);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Gray;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(-3, -2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(138, 39);
            this.Back.TabIndex = 401;
            this.Back.Text = "Back to home";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // StudLoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SQLSERVER1.Properties.Resources._14141;
            this.ClientSize = new System.Drawing.Size(1236, 741);
            this.ControlBox = false;
            this.Controls.Add(this.Back);
            this.Controls.Add(this.AllBooks);
            this.Name = "StudLoans";
            this.Text = "My Loans";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AllBooks.ResumeLayout(false);
            this.AllBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AllBooks;
        private System.Windows.Forms.DataGridView BooksTable;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label nBooks;
        public System.Windows.Forms.Button CancelLoan;
    }
}