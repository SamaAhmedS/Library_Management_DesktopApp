using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SQLSERVER1.PL
{
    public partial class ManageBooks : Form
    {
        string bookID = "", table_name = "Book";
        public string serverName ;
        public DataTable dt = new DataTable();
        public int adminID ;
        private void Filltable()
        {
            try
            {
                SqlConnection conn11 = new SqlConnection(serverName);
                conn11.Open();
                SqlDataAdapter d = new SqlDataAdapter("select * from " + table_name, conn11);
                dt.Rows.Clear();
                d.Fill(dt);
                BooksTable.DataSource = dt;
                conn11.Close();

                textBox1.Text = BooksTable.Rows.Count.ToString();
                textBox1.ReadOnly = true;
                // Set the default cell style
                BooksTable.DefaultCellStyle.BackColor = Color.White;  // Set the default background color
                BooksTable.DefaultCellStyle.ForeColor = Color.Black;  // Set the default font color

                // Set the row header style
                BooksTable.RowHeadersDefaultCellStyle.BackColor = Color.LightGray;  // Set the background color of row headers
                BooksTable.RowHeadersDefaultCellStyle.ForeColor = Color.Black;     // Set the font color of row headers

                // Iterate through the rows and apply formatting
                foreach (DataGridViewRow row in BooksTable.Rows)
                {
                    // Customize row color and font
                    if (row.Index % 2 == 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightBlue;   // Set the background color for even rows
                        row.DefaultCellStyle.ForeColor = Color.Black;       // Set the font color for even rows
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.White;       // Set the background color for odd rows
                        row.DefaultCellStyle.ForeColor = Color.Black;       // Set the font color for odd rows
                    }
                }
            }
            catch
            {

            }
        }




        public ManageBooks()
        {
            InitializeComponent();

            AllBooks.Location = new Point(134, 45);
            panel1.Location = new Point(350, 70);
            panel2.Location = new Point(350, 70);
            panel1.Visible = false;
            panel2.Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddCopy_Click(object sender, EventArgs e)
        {
            if (BooksTable.SelectedRows.Count > 0)
            {
                AllBooks.Visible = false;
                string Bid = "Book ID: ";
                bookID = BooksTable.CurrentRow.Cells[0].Value.ToString();
                Bid += bookID;
                BookIDLable.Text = Bid;
                panel2.Visible = true;
            }
            else
            {
                MessageBox.Show("Please Select a book");
            }

        }

        private void AllBooks_Enter(object sender, EventArgs e)
        {

        }

        private void BooksTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddBbtn_Click(object sender, EventArgs e)
        {
            table_name = "Book";

            SqlConnection conn11 = new SqlConnection(serverName);
            conn11.Open();
            SqlCommand NewB = new SqlCommand("insert into " + table_name + "(ID,Title,Publisher_ID,Admin_ID)values(" + Convert.ToInt32(BID.Text) + ", '" + Title.Text + ", '" + Convert.ToInt32(PID.Text) + ", '" + adminID + "')", conn11);
            NewB.ExecuteNonQuery();
            conn11.Close();

            conn11.Open();
            SqlCommand au = new SqlCommand("insert into Book_Author " + "(Book_ID,Publisher_ID)values(" + Convert.ToInt32(BID.Text) + ",'" + Convert.ToInt32(auID.Text) + "');", conn11);
            au.ExecuteNonQuery();
            conn11.Close();
            panel1.Visible = false;
            AllBooks.Visible = true;
        }
        //show book panel1
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AllBooks.Visible = false;

            panel1.Visible = true;

        }

        private void CancelCopy_Click(object sender, EventArgs e)
        {
            Filltable();
            textBox1.Text = BooksTable.Rows.Count.ToString();
            textBox1.ReadOnly = true;
            AllBooks.Visible = true;

            panel1.Visible = false;
            panel2.Visible = false;
            copyEx.Visible = false;
        }

        private void CancelAdd_Click(object sender, EventArgs e)
        {
            AllBooks.Visible = true;

            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void DeleteABook_Click(object sender, EventArgs e)
        {
            if (BooksTable.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Do you want to delete this Book", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(serverName);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from " + table_name + " where ID= " + BooksTable.CurrentRow.Cells[0].Value, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Filltable();
                    TableHeader();
                }
            }
            else
            {
                MessageBox.Show("Please Select a book");
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void AddCopybtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Check copy id is new

                SqlConnection conn = new SqlConnection(serverName);
                conn.Open();
                table_name = "Book_Copy";
                SqlDataAdapter d2 = new SqlDataAdapter("SELECT COUNT(*) FROM " + table_name + " WHERE ID = '" + Convert.ToInt32(CopyID.Text) + "' AND Book_ID = '" + bookID + "'", conn);
                DataTable dt = new DataTable();
                d2.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    copyEx.Visible = true;
                    copyEx.Text = "There is a copy with this ID";
                }
                else
                {
                    table_name = "Book_Copy";
                    SqlConnection conn11 = new SqlConnection(serverName);
                    conn11.Open();
                    SqlCommand newcopy = new SqlCommand("INSERT INTO " + table_name + " (Book_ID,ID)VALUES(" + Convert.ToInt32(bookID) + ", '" + Convert.ToInt32(CopyID.Text) + "')", conn11);
                    newcopy.ExecuteNonQuery();
                    conn11.Close();
                    table_name = "Book";
                    SqlConnection conn1 = new SqlConnection(serverName);
                    conn1.Open();
                    SqlDataAdapter d1 = new SqlDataAdapter("select * from " + table_name + " where ID = " + Convert.ToInt32(bookID), conn1);
                    dt.Rows.Clear();
                    d1.Fill(dt);
                    int nCopy = (int)dt.Rows[0][3];
                    conn1.Close();
                    nCopy++;
                    conn1.Open();
                    SqlCommand book2 = new SqlCommand("UPDATE " + table_name + " SET No_Copies = '" + nCopy + "' WHERE ID =" + Convert.ToInt32(bookID), conn1);
                    book2.ExecuteNonQuery();
                    conn11.Close();
                    Filltable();
                    panel2.Visible = false;
                    AllBooks.Visible = true;
                }
            }
            catch
            {

            }

        }

        private void ManageBooks_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            Filltable();
            TableHeader();

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //    AppMainWindow form2 = new AppMainWindow();
        //    form2.Show();


        //}

        private void ManageBooks_Load_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            Filltable();
            TableHeader();
            AllBooks.Visible = true;
        }

        private void BooksTable_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Filltable();
            TableHeader();
            AllBooks.Visible = true;
        }

        private void AllBooks_Enter_1(object sender, EventArgs e)
        {

            panel1.Visible = false;
            panel2.Visible = false;
            Filltable();
            TableHeader();
            AllBooks.Visible = true;
        }

        private void ManageBooks_Load_2(object sender, EventArgs e)
        {

            AllBooks.Location = new Point(134, 45);
            panel1.Location = new Point(380, 130);
            panel2.Location = new Point(380, 110);
            panel1.Visible = false;
            panel2.Visible = false;
            Filltable();
            TableHeader();
            AllBooks.Visible = true;
        }
        /// addd course 
        private void AddBbtn_Click_1(object sender, EventArgs e)
        {
            if (BID.Text != "" && Title.Text != "" && auID.Text != "" && PID.Text != ""  )
            {
               // MessageBox.Show("fll");
               int valid = 0;
                SqlConnection conn = new SqlConnection(serverName);
                conn.Open();
                SqlDataAdapter d2 = new SqlDataAdapter("SELECT COUNT(*) FROM Author WHERE ID = '" + Convert.ToInt32(auID.Text) + "'", conn);
                DataTable dt = new DataTable();
                d2.Fill(dt);
                string erm = "";
                if (Convert.ToInt32(dt.Rows[0][0].ToString()) != 0)
                {
                    
                    valid++;
                }
                else
                {
                    erm += "There is no author with such Id";
                }
                conn.Close();
                conn.Open();
                SqlDataAdapter d22 = new SqlDataAdapter("SELECT COUNT(*) FROM Publisher WHERE ID = '" + Convert.ToInt32(PID.Text) + "'", conn);
                DataTable dt1 = new DataTable();
                d22.Fill(dt1);

                //MessageBox.Show(dt1.Rows[0][0].ToString());
                if (Convert.ToInt32(dt1.Rows[0][0].ToString()) != 0)
                {
                    valid++;
                }
                else
                {
                    erm += "There is no Publisher with such Id";
                }
                bool isOnlyNumbers = Regex.IsMatch(BID.Text, @"^[0-9]+$");
                if (isOnlyNumbers)
                {
                    valid++;
                }
                else
                {
                    erm += "ID must be int ";
                }
                if (valid == 3)
                {
                    SqlConnection conn11 = new SqlConnection(serverName);
                    conn11.Open();

                    string insertQuery = "INSERT INTO Book (Publisher_ID, ID, Admin_ID, BDate, Title) VALUES (@PublisherID, @ID, @AdminID, @BDate, @Title)";
                    SqlCommand newcopy = new SqlCommand(insertQuery, conn11);
                    newcopy.Parameters.AddWithValue("@PublisherID", Convert.ToInt32(PID.Text));
                    newcopy.Parameters.AddWithValue("@ID", Convert.ToInt32(BID.Text));
                    newcopy.Parameters.AddWithValue("@AdminID", adminID);
                    newcopy.Parameters.AddWithValue("@BDate", BDate.Value.ToString("yyyy-MM-dd"));
                    newcopy.Parameters.AddWithValue("@Title", Title.Text);

                    newcopy.ExecuteNonQuery();
                    conn11.Close();

                    conn11.Open();
                    try
                    {
                        SqlCommand author = new SqlCommand("INSERT INTO Book_Author (Publisher_ID,Book_ID) VALUES (" + Convert.ToInt32(auID.Text) + ", '" + Convert.ToInt32(BID.Text) + "')", conn11);
                        author.ExecuteNonQuery();
                    }
                    catch
                    {

                    }
                    MessageBox.Show("Book added Successfully ");

                    Filltable();
                    panel1.Visible = false;
                    panel2.Visible = false;
                    AllBooks.Visible = true;
                }
                else
                {
                    MessageBox.Show(erm);
                }
            }
            else
            {
                MessageBox.Show("Please fill all inputs");
            }
            Filltable();
        }

        private void CancelAdd_Click_1(object sender, EventArgs e)
        {
            Filltable();
            AllBooks.Visible = true;
            CopyID.Text = "";
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            AllBooks.Visible = false;
            AddBbtn.Visible = true;
            u.Visible = false;
            BID.Text = "";
            BID.ReadOnly = false;
            Title.Text = "";
            PID.Text = "";
            auID.Text = "";
            BDate.Location = new Point(13, 335);
            label5.Location = new Point(5, 309);
            auID.Visible = true;
            BID.Enabled = true;
            label5.Visible = true;
            label4.Visible = true;
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void AddCopy_Click_1(object sender, EventArgs e)
        {

            if (BooksTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = BooksTable.SelectedRows[0];

                // Access the value of the first cell in the selected row
                bookID = selectedRow.Cells[0].Value.ToString();
                CopyID.Text = "";
                selctedBID.Text = bookID;
                selctedBID.ReadOnly = true;
                AllBooks.Visible = false;

                panel1.Visible = false;
                panel2.Visible = true;

            }
        }

        private void AddCopybtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Check copy id is new

                SqlConnection conn = new SqlConnection(serverName);
                conn.Open();
                table_name = "Book_Copy";
                SqlDataAdapter d2 = new SqlDataAdapter("SELECT COUNT(*) FROM " + table_name + " WHERE ID = '" + Convert.ToInt32(CopyID.Text) + "' AND Book_ID = '" + bookID + "'", conn);
                DataTable dt = new DataTable();
                d2.Fill(dt);

                if (Convert.ToInt32(dt.Rows[0][0]) != 0)
                {
                    copyEx.Visible = true;
                    copyEx.Text = "There is a copy with this ID";
                }
                else
                {
                    table_name = "Book_Copy";
                    SqlConnection conn11 = new SqlConnection(serverName);
                    conn11.Open();
                    SqlCommand newcopy = new SqlCommand("INSERT INTO " + table_name + " (Book_ID,ID)VALUES(" + Convert.ToInt32(bookID) + ", '" + Convert.ToInt32(CopyID.Text) + "')", conn11);
                    newcopy.ExecuteNonQuery();
                    conn11.Close();

                    table_name = "Book";
                    SqlConnection conn1 = new SqlConnection(serverName);
                    conn1.Open();
                    SqlDataAdapter d1 = new SqlDataAdapter("SELECT * FROM Book WHERE ID = " + Convert.ToInt32(bookID), conn1);
                    dt.Rows.Clear();
                    d1.Fill(dt);
                    int nCopy = (int)dt.Rows[0][4];
                    //MessageBox.Show(dt.Rows[0][4].ToString());
                    conn1.Close();
                    nCopy++;
                    conn1.Open();
                    SqlCommand book2 = new SqlCommand("UPDATE Book SET No_Copies = " + nCopy + " WHERE ID = " + Convert.ToInt32(bookID), conn1);
                    book2.ExecuteNonQuery();
                    conn1.Close();

                    Filltable();
                    panel2.Visible = false;
                    AllBooks.Visible = true;
                    CopyID.Text = "";
                }
                Filltable();
            }
            catch
            {
                Filltable();
            }
        }

        private void CancelCopy_Click_1(object sender, EventArgs e)
        {
            AllBooks.Visible = true;
            CopyID.Text = "";
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void DeleteABook_Click_1(object sender, EventArgs e)
        {
            if (BooksTable.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Do you want to delete this Book", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = BooksTable.SelectedRows[0];

                    // Access the value of the first cell in the selected row
                    bookID = selectedRow.Cells[0].Value.ToString();
                    SqlConnection conn11 = new SqlConnection(serverName);
                    conn11.Open();
                    SqlCommand deleteCmd = new SqlCommand("DELETE FROM Book_Author WHERE Book_ID = " + Convert.ToInt32(bookID), conn11);
                    deleteCmd.ExecuteNonQuery();
                    deleteCmd = new SqlCommand("DELETE FROM Book WHERE ID = " + Convert.ToInt32(bookID), conn11);
                    deleteCmd.ExecuteNonQuery();
                    Filltable();
                }
            }
        }

        private void ub_Click(object sender, EventArgs e)
        {
            if (BooksTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = BooksTable.SelectedRows[0];

                // Access the value of the first cell in the selected row
                bookID = selectedRow.Cells[0].Value.ToString();

                
                SqlConnection conn1 = new SqlConnection(serverName);
                conn1.Open();
                SqlDataAdapter d1 = new SqlDataAdapter("SELECT * FROM Book WHERE ID = " + Convert.ToInt32(bookID), conn1);
                dt.Rows.Clear();
                d1.Fill(dt);
                conn1.Close();
                Title.Text = dt.Rows[0][1].ToString();
                PID.Text = dt.Rows[0][2].ToString();

                u.Visible = true;
                AddBbtn.Visible = false;

                //conn1.Open();
                //SqlDataAdapter d2 = new SqlDataAdapter("SELECT * FROM Book_Author WHERE Book_ID = " + Convert.ToInt32(bookID), conn1);
                //dt.Rows.Clear();
                //d2.Fill(dt);
                //auID.Text = dt.Rows[0][1].ToString();
                AllBooks.Visible = false;
                BID.Text = bookID;
                //BDate.Visible = false;
                DateTime dateTimeValue;
                DateTime.TryParse(dt.Rows[0][5].ToString(), out dateTimeValue);
                if (DateTime.TryParse(dt.Rows[0][5].ToString(), out dateTimeValue))
                {
                    BDate.Value = dateTimeValue;
                }
                
                
                auID.Visible = false;
                BID.Enabled = false;
                //label5.Visible = false;
                label4.Visible = false;
                BDate.Location =new Point (13, 267);
                label5.Location = new Point(5, 240);
                panel1.Visible =true;
                panel2.Visible = false;
            }
        }

        private void u_Click(object sender, EventArgs e)
        {
            SqlConnection conn11 = new SqlConnection(serverName);
            conn11.Open();

            SqlCommand newcopy = new SqlCommand("UPDATE Book SET Publisher_ID = " + Convert.ToInt32(PID.Text) + ", Title = '" + Title.Text + "', BDate = '" + BDate.Value.ToString("yyyy-MM-dd") + "'  WHERE ID = " + Convert.ToInt32(bookID), conn11);
            newcopy.ExecuteNonQuery();
            conn11.Close();
            
            Filltable();
            AllBooks.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void contextMenuStrip3_Opening(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //if ()
            //{
                try
                {
                    SqlConnection conn11 = new SqlConnection(serverName);
                    conn11.Open();
                    SqlDataAdapter d = new SqlDataAdapter("select * from Book " + " where " + sb.Text + " = " + sv.Text, conn11);
                    if (sb.Text == "Title")
                    {
                        d = new SqlDataAdapter("SELECT * FROM Book WHERE Title LIKE '%" + sv.Text + "%'", conn11);

                    }
                    else
                    {
                        d = new SqlDataAdapter("select * from Book " + " where " + sb.Text + " = " + sv.Text, conn11);
                    }
                    dt.Rows.Clear();
                    d.Fill(dt);
                    BooksTable.DataSource = dt;
                    conn11.Close();
                    
                    textBox1.Text = BooksTable.Rows.Count.ToString();
                    textBox1.ReadOnly = true;    

                }
                catch
                {
                Filltable ();
                }
            
        }

        private void BookInfo_Enter(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            AppMainWindow frm = new AppMainWindow();
            frm.logged = 2;
            frm.LoggedID = adminID;
            frm.serverName = serverName;
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

        private void TableHeader()
        {
            if (BooksTable.Columns.Count > 4)
            {
                BooksTable.Columns[0].HeaderText = "ID";
                BooksTable.Columns[0].Width = 290;
                BooksTable.Columns[1].HeaderText = "Title";
                BooksTable.Columns[1].Width = 200;
                BooksTable.Columns[2].HeaderText = "Publisher ID";
                BooksTable.Columns[2].Width = 140;

                BooksTable.Columns[3].HeaderText = "No Copies";
                BooksTable.Columns[3].Width = 140;
                BooksTable.Columns[4].HeaderText = "Admin ID";
                BooksTable.Columns[4].Width = 100;
                BooksTable.Columns[5].HeaderText = "Publication Date";
                BooksTable.Columns[5].Width = 130;
            }
            //BooksTable.Columns[5].HeaderText = "Author Name";
            //BooksTable.Columns[5].Width = 30;

        }
    }
}

