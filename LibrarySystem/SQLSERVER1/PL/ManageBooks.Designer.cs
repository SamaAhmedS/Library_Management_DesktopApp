namespace SQLSERVER1.PL
{
    partial class ManageBooks
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.copyEx = new System.Windows.Forms.Label();
            this.CancelCopy = new System.Windows.Forms.Button();
            this.AddCopybtn = new System.Windows.Forms.Button();
            this.CopyID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BookIDCopy = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.selctedBID = new System.Windows.Forms.TextBox();
            this.BookIDLable = new System.Windows.Forms.Label();
            this.u = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.TextBox();
            this.PID = new System.Windows.Forms.TextBox();
            this.BID = new System.Windows.Forms.TextBox();
            this.AddBbtn = new System.Windows.Forms.Button();
            this.CancelAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BookInfo = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BDate = new System.Windows.Forms.DateTimePicker();
            this.auID = new System.Windows.Forms.TextBox();
            this.nBooks = new System.Windows.Forms.Label();
            this.AddCopy = new System.Windows.Forms.Button();
            this.DeleteABook = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.BooksTable = new System.Windows.Forms.DataGridView();
            this.AllBooks = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sb = new System.Windows.Forms.ComboBox();
            this.ub = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            //this._TMPCLP465651TableAdapter1 = new SQLSERVER1.DataSet1TableAdapters._TMPCLP465651TableAdapter();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Back = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.BookInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksTable)).BeginInit();
            this.AllBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // copyEx
            // 
            this.copyEx.AutoSize = true;
            this.copyEx.BackColor = System.Drawing.Color.White;
            this.copyEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyEx.ForeColor = System.Drawing.Color.Red;
            this.copyEx.Location = new System.Drawing.Point(77, 144);
            this.copyEx.Name = "copyEx";
            this.copyEx.Size = new System.Drawing.Size(0, 20);
            this.copyEx.TabIndex = 399;
            // 
            // CancelCopy
            // 
            this.CancelCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelCopy.ForeColor = System.Drawing.Color.White;
            this.CancelCopy.Location = new System.Drawing.Point(50, 182);
            this.CancelCopy.Name = "CancelCopy";
            this.CancelCopy.Size = new System.Drawing.Size(98, 40);
            this.CancelCopy.TabIndex = 398;
            this.CancelCopy.Text = "Cancel";
            this.CancelCopy.UseVisualStyleBackColor = false;
            this.CancelCopy.Click += new System.EventHandler(this.CancelCopy_Click_1);
            // 
            // AddCopybtn
            // 
            this.AddCopybtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddCopybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCopybtn.ForeColor = System.Drawing.Color.White;
            this.AddCopybtn.Location = new System.Drawing.Point(187, 182);
            this.AddCopybtn.Name = "AddCopybtn";
            this.AddCopybtn.Size = new System.Drawing.Size(98, 40);
            this.AddCopybtn.TabIndex = 397;
            this.AddCopybtn.Text = "Add";
            this.AddCopybtn.UseVisualStyleBackColor = false;
            this.AddCopybtn.Click += new System.EventHandler(this.AddCopybtn_Click_1);
            // 
            // CopyID
            // 
            this.CopyID.Location = new System.Drawing.Point(68, 129);
            this.CopyID.Name = "CopyID";
            this.CopyID.Size = new System.Drawing.Size(217, 20);
            this.CopyID.TabIndex = 396;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(22, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 395;
            this.label3.Text = "Copy ID:";
            // 
            // BookIDCopy
            // 
            this.BookIDCopy.AutoSize = true;
            this.BookIDCopy.Location = new System.Drawing.Point(23, 34);
            this.BookIDCopy.Name = "BookIDCopy";
            this.BookIDCopy.Size = new System.Drawing.Size(52, 13);
            this.BookIDCopy.TabIndex = 392;
            this.BookIDCopy.Text = "Book ID: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.selctedBID);
            this.panel2.Controls.Add(this.copyEx);
            this.panel2.Controls.Add(this.CancelCopy);
            this.panel2.Controls.Add(this.AddCopybtn);
            this.panel2.Controls.Add(this.CopyID);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.BookIDLable);
            this.panel2.Controls.Add(this.BookIDCopy);
            this.panel2.Location = new System.Drawing.Point(11, 466);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 242);
            this.panel2.TabIndex = 5;
            // 
            // selctedBID
            // 
            this.selctedBID.Location = new System.Drawing.Point(67, 54);
            this.selctedBID.Name = "selctedBID";
            this.selctedBID.Size = new System.Drawing.Size(218, 20);
            this.selctedBID.TabIndex = 400;
            // 
            // BookIDLable
            // 
            this.BookIDLable.AutoSize = true;
            this.BookIDLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookIDLable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BookIDLable.Location = new System.Drawing.Point(22, 27);
            this.BookIDLable.Name = "BookIDLable";
            this.BookIDLable.Size = new System.Drawing.Size(88, 24);
            this.BookIDLable.TabIndex = 394;
            this.BookIDLable.Text = "Book ID:";
            // 
            // u
            // 
            this.u.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.u.Location = new System.Drawing.Point(151, 372);
            this.u.Name = "u";
            this.u.Size = new System.Drawing.Size(107, 40);
            this.u.TabIndex = 398;
            this.u.Text = "Update";
            this.u.UseVisualStyleBackColor = false;
            this.u.Click += new System.EventHandler(this.u_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 24);
            this.label4.TabIndex = 396;
            this.label4.Text = "Author ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 393;
            this.label1.Text = "Publisher ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 392;
            this.label2.Text = "Title:";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(6, 25);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(35, 24);
            this.ID.TabIndex = 391;
            this.ID.Text = "ID:";
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(13, 120);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(288, 29);
            this.Title.TabIndex = 390;
            // 
            // PID
            // 
            this.PID.Location = new System.Drawing.Point(13, 202);
            this.PID.Name = "PID";
            this.PID.Size = new System.Drawing.Size(288, 29);
            this.PID.TabIndex = 389;
            // 
            // BID
            // 
            this.BID.Location = new System.Drawing.Point(13, 52);
            this.BID.Name = "BID";
            this.BID.Size = new System.Drawing.Size(288, 29);
            this.BID.TabIndex = 388;
            // 
            // AddBbtn
            // 
            this.AddBbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddBbtn.Location = new System.Drawing.Point(183, 372);
            this.AddBbtn.Name = "AddBbtn";
            this.AddBbtn.Size = new System.Drawing.Size(110, 40);
            this.AddBbtn.TabIndex = 387;
            this.AddBbtn.Text = "Add";
            this.AddBbtn.UseVisualStyleBackColor = false;
            this.AddBbtn.Click += new System.EventHandler(this.AddBbtn_Click_1);
            // 
            // CancelAdd
            // 
            this.CancelAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelAdd.Location = new System.Drawing.Point(38, 372);
            this.CancelAdd.Name = "CancelAdd";
            this.CancelAdd.Size = new System.Drawing.Size(107, 40);
            this.CancelAdd.TabIndex = 386;
            this.CancelAdd.Text = "Cancel";
            this.CancelAdd.UseVisualStyleBackColor = false;
            this.CancelAdd.Click += new System.EventHandler(this.CancelAdd_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.BookInfo);
            this.panel1.Location = new System.Drawing.Point(-4, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 434);
            this.panel1.TabIndex = 4;
            // 
            // BookInfo
            // 
            this.BookInfo.Controls.Add(this.label5);
            this.BookInfo.Controls.Add(this.u);
            this.BookInfo.Controls.Add(this.BDate);
            this.BookInfo.Controls.Add(this.label4);
            this.BookInfo.Controls.Add(this.auID);
            this.BookInfo.Controls.Add(this.label1);
            this.BookInfo.Controls.Add(this.label2);
            this.BookInfo.Controls.Add(this.ID);
            this.BookInfo.Controls.Add(this.Title);
            this.BookInfo.Controls.Add(this.PID);
            this.BookInfo.Controls.Add(this.BID);
            this.BookInfo.Controls.Add(this.AddBbtn);
            this.BookInfo.Controls.Add(this.CancelAdd);
            this.BookInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookInfo.ForeColor = System.Drawing.Color.White;
            this.BookInfo.Location = new System.Drawing.Point(15, 8);
            this.BookInfo.Name = "BookInfo";
            this.BookInfo.Size = new System.Drawing.Size(307, 417);
            this.BookInfo.TabIndex = 0;
            this.BookInfo.TabStop = false;
            this.BookInfo.Text = "Book Information";
            this.BookInfo.Enter += new System.EventHandler(this.BookInfo_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 24);
            this.label5.TabIndex = 399;
            this.label5.Text = "Publication Date:";
            // 
            // BDate
            // 
            this.BDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BDate.Location = new System.Drawing.Point(13, 335);
            this.BDate.Margin = new System.Windows.Forms.Padding(2);
            this.BDate.Name = "BDate";
            this.BDate.Size = new System.Drawing.Size(289, 26);
            this.BDate.TabIndex = 397;
            // 
            // auID
            // 
            this.auID.Location = new System.Drawing.Point(13, 267);
            this.auID.Name = "auID";
            this.auID.Size = new System.Drawing.Size(288, 29);
            this.auID.TabIndex = 395;
            // 
            // nBooks
            // 
            this.nBooks.AutoSize = true;
            this.nBooks.Location = new System.Drawing.Point(565, 48);
            this.nBooks.Name = "nBooks";
            this.nBooks.Size = new System.Drawing.Size(183, 24);
            this.nBooks.TabIndex = 390;
            this.nBooks.Text = "Number of Books: ";
            // 
            // AddCopy
            // 
            this.AddCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddCopy.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCopy.ForeColor = System.Drawing.Color.White;
            this.AddCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddCopy.Location = new System.Drawing.Point(302, 573);
            this.AddCopy.Name = "AddCopy";
            this.AddCopy.Size = new System.Drawing.Size(160, 46);
            this.AddCopy.TabIndex = 389;
            this.AddCopy.Text = "Add Copy";
            this.AddCopy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddCopy.UseVisualStyleBackColor = false;
            this.AddCopy.Click += new System.EventHandler(this.AddCopy_Click_1);
            // 
            // DeleteABook
            // 
            this.DeleteABook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeleteABook.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteABook.ForeColor = System.Drawing.Color.DarkRed;
            this.DeleteABook.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteABook.Location = new System.Drawing.Point(790, 573);
            this.DeleteABook.Name = "DeleteABook";
            this.DeleteABook.Size = new System.Drawing.Size(255, 46);
            this.DeleteABook.TabIndex = 387;
            this.DeleteABook.Text = "Delete This Book";
            this.DeleteABook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteABook.UseVisualStyleBackColor = false;
            this.DeleteABook.Click += new System.EventHandler(this.DeleteABook_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(53, 573);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(168, 46);
            this.btnAdd.TabIndex = 384;
            this.btnAdd.Text = "Add Book";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // BooksTable
            // 
            this.BooksTable.AllowUserToAddRows = false;
            this.BooksTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.BooksTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BooksTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.BooksTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksTable.GridColor = System.Drawing.Color.Gray;
            this.BooksTable.Location = new System.Drawing.Point(10, 97);
            this.BooksTable.MultiSelect = false;
            this.BooksTable.Name = "BooksTable";
            this.BooksTable.ReadOnly = true;
            this.BooksTable.RowHeadersWidth = 62;
            this.BooksTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BooksTable.Size = new System.Drawing.Size(1062, 545);
            this.BooksTable.TabIndex = 347;
            this.BooksTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BooksTable_CellContentClick_1);
            // 
            // AllBooks
            // 
            this.AllBooks.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AllBooks.Controls.Add(this.textBox1);
            this.AllBooks.Controls.Add(this.sv);
            this.AllBooks.Controls.Add(this.label7);
            this.AllBooks.Controls.Add(this.label6);
            this.AllBooks.Controls.Add(this.sb);
            this.AllBooks.Controls.Add(this.ub);
            this.AllBooks.Controls.Add(this.nBooks);
            this.AllBooks.Controls.Add(this.AddCopy);
            this.AllBooks.Controls.Add(this.DeleteABook);
            this.AllBooks.Controls.Add(this.btnAdd);
            this.AllBooks.Controls.Add(this.BooksTable);
            this.AllBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllBooks.ForeColor = System.Drawing.Color.White;
            this.AllBooks.Location = new System.Drawing.Point(266, 29);
            this.AllBooks.Name = "AllBooks";
            this.AllBooks.Size = new System.Drawing.Size(1078, 677);
            this.AllBooks.TabIndex = 3;
            this.AllBooks.TabStop = false;
            this.AllBooks.Text = "All Books";
            this.AllBooks.Enter += new System.EventHandler(this.AllBooks_Enter_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(746, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 29);
            this.textBox1.TabIndex = 396;
            // 
            // sv
            // 
            this.sv.Location = new System.Drawing.Point(351, 49);
            this.sv.Margin = new System.Windows.Forms.Padding(2);
            this.sv.Name = "sv";
            this.sv.Size = new System.Drawing.Size(189, 29);
            this.sv.TabIndex = 395;
            this.sv.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 24);
            this.label7.TabIndex = 394;
            this.label7.Text = "Word";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 24);
            this.label6.TabIndex = 393;
            this.label6.Text = "Search by";
            // 
            // sb
            // 
            this.sb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sb.FormattingEnabled = true;
            this.sb.Items.AddRange(new object[] {
            "ID",
            "Title",
            "Admin_ID"});
            this.sb.Location = new System.Drawing.Point(117, 48);
            this.sb.Margin = new System.Windows.Forms.Padding(2);
            this.sb.Name = "sb";
            this.sb.Size = new System.Drawing.Size(147, 32);
            this.sb.TabIndex = 392;
            // 
            // ub
            // 
            this.ub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ub.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ub.ForeColor = System.Drawing.Color.White;
            this.ub.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ub.Location = new System.Drawing.Point(514, 573);
            this.ub.Name = "ub";
            this.ub.Size = new System.Drawing.Size(234, 46);
            this.ub.TabIndex = 391;
            this.ub.Text = "Update This Book";
            this.ub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ub.UseVisualStyleBackColor = false;
            this.ub.Click += new System.EventHandler(this.ub_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // _TMPCLP465651TableAdapter1
            // 
            //this._TMPCLP465651TableAdapter1.ClearBeforeFill = true;
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip3.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip3_Opening);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Gray;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(-1, -1);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(128, 29);
            this.Back.TabIndex = 400;
            this.Back.Text = "Back to home";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // ManageBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SQLSERVER1.Properties.Resources._14141;
            this.ClientSize = new System.Drawing.Size(1370, 706);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AllBooks);
            this.Name = "ManageBooks";
            this.Text = "ManageBooks";
            this.Load += new System.EventHandler(this.ManageBooks_Load_2);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.BookInfo.ResumeLayout(false);
            this.BookInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksTable)).EndInit();
            this.AllBooks.ResumeLayout(false);
            this.AllBooks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label copyEx;
        private System.Windows.Forms.Button CancelCopy;
        private System.Windows.Forms.Button AddCopybtn;
        private System.Windows.Forms.TextBox CopyID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BookIDCopy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label BookIDLable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox PID;
        private System.Windows.Forms.TextBox BID;
        private System.Windows.Forms.Button AddBbtn;
        private System.Windows.Forms.Button CancelAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox BookInfo;
        private System.Windows.Forms.Label nBooks;
        public System.Windows.Forms.Button AddCopy;
        public System.Windows.Forms.Button DeleteABook;
        public System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView BooksTable;
        private System.Windows.Forms.GroupBox AllBooks;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
       // private DataSet1TableAdapters._TMPCLP465651TableAdapter _TMPCLP465651TableAdapter1;
        private System.Windows.Forms.DateTimePicker BDate;
        public System.Windows.Forms.Button ub;
        private System.Windows.Forms.Button u;
        private System.Windows.Forms.TextBox auID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox sb;
        private System.Windows.Forms.TextBox sv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox selctedBID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Back;
    }
}