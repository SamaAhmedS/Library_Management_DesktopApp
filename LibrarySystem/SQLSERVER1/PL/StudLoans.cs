using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace SQLSERVER1.PL
{
    public partial class StudLoans : Form
    {
        
        public string serverName;
        public DataTable dt = new DataTable();
        public int StudID ;
        public StudLoans()
        {
            InitializeComponent();
            // Add columns programmatically
            BooksTable.Columns.Add("BookName", "Book Name");
            BooksTable.Columns.Add("BookID", "Book ID");
            BooksTable.Columns.Add("CopyID", "Copy ID");
            BooksTable.Columns.Add("FromDate", "From Date");
            BooksTable.Columns.Add("ToDate", "To Date");

            // Set additional properties for the columns, if needed
            BooksTable.Columns[0].Width = 200;
            BooksTable.Columns[1].Width = 160;
            BooksTable.Columns[2].Width = 150;
            BooksTable.Columns[3].Width = 180;
            BooksTable.Columns[4].Width = 180;
            // Set the default cell style
            BooksTable.DefaultCellStyle.BackColor = Color.White;  // Set the default background color
            BooksTable.DefaultCellStyle.ForeColor = Color.Black;  // Set the default font color

            // Set the row header style
            BooksTable.RowHeadersDefaultCellStyle.BackColor = Color.LightGray;  // Set the background color of row headers
            BooksTable.RowHeadersDefaultCellStyle.ForeColor = Color.Black;     // Set the font color of row headers
            //Filltable();
            //MessageBox.Show(StudID.ToString());
        }
        private void Filltable()
        {
            AllBooks.Location = new Point(210, 45);
            DataTable Wholetable = new DataTable(),bookName = new DataTable();
            BooksTable.Rows.Clear();
            try
            {
                SqlConnection conn11 = new SqlConnection(serverName);
                conn11.Open();
                //SqlDataAdapter d = new SqlDataAdapter("select * from " + table_name , conn11);
                SqlDataAdapter d = new SqlDataAdapter("select Book_ID, Copy_ID, From_Date, To_Date from Book_Loan where User_ID = '" + StudID + "'", conn11);
                dt.Rows.Clear();
                d.Fill(dt);
                //check this book has a copy with TODate ends before today
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow row = dt.Rows[i];
                    conn11.Close(); conn11.Open();
                    SqlDataAdapter dd = new SqlDataAdapter("select Title from Book where ID = '" + row[0] + "'", conn11);
                    bookName.Rows.Clear();
                    dd.Fill(bookName);
                    int Indx =  BooksTable.Rows.Add(bookName.Rows[0][0].ToString(), row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());
                    BooksTable.Rows[Indx].DefaultCellStyle.BackColor = Color.White;       // Set the background color for this row
                    BooksTable.Rows[Indx].DefaultCellStyle.ForeColor = Color.Black;       // Set the font color for this row

                }
                conn11.Close();
                nBooks.Text = "Number Of Books = " + BooksTable.Rows.Count.ToString();

            }
            catch
            {

            }
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
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Filltable();
        }

        private void CancelLoan_Click(object sender, EventArgs e)
        {

            if (BooksTable.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Do you want to cancel this Loan ", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = BooksTable.SelectedRows[0];

                    // Access the value of the first cell in the selected row
                    //int  = selectedRow.Cells[0].Value.ToString();
                    SqlConnection conn11 = new SqlConnection(serverName);
                    conn11.Open();
                    SqlCommand deleteCmd = new SqlCommand("DELETE FROM Book_Loan WHERE User_ID = " + StudID + " AND Book_ID = " + Convert.ToInt32(selectedRow.Cells[1].Value) + " AND Copy_ID = " + Convert.ToInt32(selectedRow.Cells[2].Value) + " AND From_Date = '" + Convert.ToDateTime(selectedRow.Cells[3].Value) + "' AND To_Date = '" + Convert.ToDateTime(selectedRow.Cells[4].Value) + "'", conn11);
                    deleteCmd.ExecuteNonQuery();

                    Filltable();
                }
            }
        }

        private void AllBooks_Enter(object sender, EventArgs e)
        {
            Filltable();
        }

        private void BooksTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
