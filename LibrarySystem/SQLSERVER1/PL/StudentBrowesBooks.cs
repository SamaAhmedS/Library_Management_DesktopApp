using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SQLSERVER1.PL
{
    public partial class StudentBrowesBooks : Form
    {
        string bookID = "", table_name = "Book";
        public string serverName;
        public DataTable dt = new DataTable();
        public int StudID ;
        private void Filltable()
        {
            AllBooks.Location = new Point(210, 45);
            try
            {
                SqlConnection conn11 = new SqlConnection(serverName);
                conn11.Open();
                //SqlDataAdapter d = new SqlDataAdapter("select * from " + table_name , conn11);
                SqlDataAdapter d = new SqlDataAdapter("select * from Book where No_Copies > 0 ", conn11);
                dt.Rows.Clear();
                d.Fill(dt);
                //check this book has a copy with TODate ends before today
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow row = dt.Rows[i];
                    // Access data in each row
                    string BookID = row["ID"].ToString();
                    int ncopy = Convert.ToInt32(row["No_Copies"]);
                    DataTable Mytable = new DataTable();

                    d = new SqlDataAdapter("select COUNT(*) from Book_Loan where Book_ID = '" + BookID + "' AND To_Date >= '" + toDay.Value + "'", conn11);
                    Mytable.Rows.Clear();
                    d.Fill(Mytable);
                    if(Mytable.Rows.Count > 0)
                    {
                        ncopy -= Convert.ToInt32(Mytable.Rows[0][0]);
                    }
                    if (ncopy< 1)
                    {
                        row.Delete();
                    }
                    else
                    {
                        row["No_Copies"] = Convert.ToString(ncopy);
                    }
                }


                BooksTable.DataSource = dt;
                conn11.Close();
                nBooks.Text = "Number Of Books = " + BooksTable.Rows.Count.ToString();
                TableHeader();
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
        public StudentBrowesBooks()
        {
            
            InitializeComponent();
            AllBooks.Location = new Point(134, 45);
            panel1.Location = new Point(350, 70);
            Filltable();
            TableHeader();
            panel1.Visible = false;
            AllBooks.Visible = true;
        }

        private void Borrowbtn_Click(object sender, EventArgs e)
        {
            if (BooksTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = BooksTable.SelectedRows[0];

                // Access the value of the first cell in the selected row
                bookID = selectedRow.Cells[0].Value.ToString();
                AllBooks.Visible = false;
                DataTable Mytable = new DataTable();
                SqlConnection conn11 = new SqlConnection(serverName);
                conn11.Open();
                SqlDataAdapter d = new SqlDataAdapter("select ID from Book_Copy where Book_ID = '" + bookID + "'", conn11);
                Mytable.Rows.Clear();
                d.Fill(Mytable);
                List<string> collection = new List<string>() ;
                
                for (int i = 0; i < Mytable.Rows.Count; i++)
                {
                    DataRow row = Mytable.Rows[i];
                    string copyID = row["ID"].ToString();
                    DataTable table1 = new DataTable();

                    d = new SqlDataAdapter("select COUNT(*) from Book_Loan where Book_ID = '" + bookID + "' AND Copy_ID = '" + copyID +"' AND To_Date >= '" + toDay.Value + "'", conn11);
                    table1.Rows.Clear();
                    d.Fill(table1);
                    if (Convert.ToInt32(table1.Rows[0][0]) > 0)
                    {
                        row.Delete();
                    }
                    else
                    {
                        collection.Add(copyID);
                    }
                }
                selectCID.DataSource = collection;

                panel1.Visible = true;
                bookID = BooksTable.CurrentRow.Cells[0].Value.ToString();
                b.Text = bookID;

            }
            else
            {
                MessageBox.Show("Please Select a book");
            }
        }

        private void Browbook_Click(object sender, EventArgs e)
        {
        //    SqlConnection conn = new SqlConnection(serverName);
        //    conn.Open();
        //    table_name = "Book_Loan";
        //    SqlDataAdapter d2 = new SqlDataAdapter("SELECT COUNT(*) FROM " + table_name + " WHERE User_ID = '" + StudID + "' AND Copy_ID = '" + CopyID.Text + "' AND From_Date = '" + ToD.Value + "'", conn);
        //    DataTable dt = new DataTable();
        //    d2.Fill(dt);
        //    if (Convert.ToInt32(dt.Rows[0][0].ToString()) == 0)
        //    {

            //    SqlConnection conn1 = new SqlConnection(serverName);
            //    conn1.Open();
            //    SqlDataAdapter d1 = new SqlDataAdapter("select * from " + table_name + " where ID = " + Convert.ToInt32(bookID), conn1);
            //    dt.Rows.Clear();
            //    d1.Fill(dt);
            //    int nCopy = (int)dt.Rows[0][3];
            //    conn1.Close();
            //    //nCopy--;
            //    //conn1.Open();
            //    //SqlCommand book2 = new SqlCommand("UPDATE " + table_name + " SET No_Copies = '" + nCopy + "' WHERE ID =" + Convert.ToInt32(bookID), conn1);
            //    //book2.ExecuteNonQuery();
            //    //conn1.Close();


            //    table_name = "Book_Loan";
            //    SqlConnection conn11 = new SqlConnection(serverName);
            //    conn11.Open();

            //    SqlCommand newLoan = new SqlCommand("INSERT INTO " + table_name + " (Copy_ID,User_ID,From_Date,To_Date ) VALUES (" + StudID + "', '" + Convert.ToInt32(CopyID.Text) + "', '" + FD.Value + "', '" + ToD.Value + "')", conn11);
            //    newLoan.ExecuteNonQuery();

            //    conn11.Close();

            //    Filltable();
            //    panel1.Visible = false;
            //    AllBooks.Visible = true;
            //}
            //else
            //{
            //    copError.Text = "This copy is unavailable";
            //}
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            AllBooks.Visible = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Browbook_Click_1(object sender, EventArgs e)
        {
            
            if (selectCID.Text != "")
            {
                
                SqlConnection conn11 = new SqlConnection(serverName);
                conn11.Open();
                    //check in book loan 
                    SqlDataAdapter d3 = new SqlDataAdapter("SELECT COUNT(*) FROM Book_Loan WHERE Copy_ID = '" + Convert.ToInt32(selectCID.Text) + "' AND Book_ID = '" + Convert.ToInt32(bookID) + "' AND To_Date = '" + ToD.Value + "' AND User_ID = '" + StudID + "'", conn11);
                    DataTable dt1 = new DataTable();
                    d3.Fill(dt1);
                    //MessageBox.Show(dt1.Rows[0][0].ToString() + "new loan");
                    if (Convert.ToInt32(dt1.Rows[0][0].ToString()) == 0)
                    {

                        SqlConnection conec1 = new SqlConnection(serverName);
                        conec1.Open();

                        string insertQuery = "INSERT INTO Book_Loan (Copy_ID, Book_ID, User_ID, To_Date, From_Date) VALUES (@CopyID, @BookID, @UserID, @ToDate, @FromDate)";
                        SqlCommand newLoan = new SqlCommand(insertQuery, conec1);
                        newLoan.Parameters.AddWithValue("@CopyID", Convert.ToInt32(selectCID.Text));
                        newLoan.Parameters.AddWithValue("@BookID", Convert.ToInt32(bookID));
                        newLoan.Parameters.AddWithValue("@UserID", StudID);
                        newLoan.Parameters.AddWithValue("@ToDate", ToD.Value.ToString("yyyy-MM-dd"));
                        newLoan.Parameters.AddWithValue("@FromDate", FD.Value.ToString("yyyy-MM-dd"));

                        newLoan.ExecuteNonQuery();
                        conec1.Close();
                        Filltable();
                        panel1.Visible = false;
                        AllBooks.Visible = true;
                    }
                    else
                    {

                        MessageBox.Show("there is a wrong data");
                    }
                //}
            }
        }

        private void cancelbtn_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            AllBooks.Visible = true;
        }

        private void StudentBrowesBooks_Load(object sender, EventArgs e)
        {
            AllBooks.Location =  new Point(134, 45);
            panel1.Location =  new Point(350, 70);
            Filltable();TableHeader();
            panel1.Visible = false;
            AllBooks.Visible = true;
        }

        private void AllBooks_Enter(object sender, EventArgs e)
        {
            Filltable();
            panel1.Visible = false;
            AllBooks.Visible = true;
        }

        private void BooksTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            AppMainWindow frm = new AppMainWindow();
            frm.logged = 1;
            frm.LoggedID = StudID;
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
                BooksTable.Columns[0].Width = 250;
                BooksTable.Columns[1].HeaderText = "Title";
                BooksTable.Columns[1].Width = 200;
                BooksTable.Columns[2].HeaderText = "Publisher ID";
                BooksTable.Columns[2].Width = 150;

                BooksTable.Columns[3].HeaderText = "Availble Copies";
                BooksTable.Columns[3].Width = 100;
                BooksTable.Columns[4].HeaderText = "Admin ID";
                BooksTable.Columns[4].Width = 100;

                BooksTable.Columns[5].HeaderText = "Publication Date";
                BooksTable.Columns[5].Width = 150;
            }             
        }
    }
}
