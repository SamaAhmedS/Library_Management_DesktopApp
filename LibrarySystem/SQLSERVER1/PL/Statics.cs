using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLSERVER1.PL
{
    public partial class Statics : Form
    {
        public string serverName = "Data Source=DESKTOP-09D9S02; Initial Catalog=dd; Integrated Security=True";

        public Statics()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlConnection conn1 = new SqlConnection(serverName);
            conn1.Open();
            SqlDataAdapter d1 = new SqlDataAdapter("Select Student.ID as StudentID, Student.First_Name as firstName, Student.Second_Name, count(Book_Loan.Book_ID) as loanCount From Student LEFT JOIN Book_Loan ON Book_Loan.User_ID = Student.ID LEFT JOIN Book on Book.ID = Book_Loan.Book_ID Group By Student.ID, Student.First_Name, Student.Second_Name", conn1);
            d1.Fill(dt);
            dataGridView1.DataSource = dt;
            conn1.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlConnection conn1 = new SqlConnection(serverName);
            conn1.Open();
            SqlDataAdapter d1 = new SqlDataAdapter("SELECT Book_ID , COUNT(*) AS Loan_Count FROM Book_Loan GROUP BY Book_ID Having count(Book_ID) > all (select count(Book.ID) from Book where Book_ID <> Book.ID GROUP BY Book.ID)", conn1);
            d1.Fill(dt);
            dataGridView1.DataSource = dt;
            conn1.Close();

        }


        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlConnection conn1 = new SqlConnection(serverName);
            conn1.Open();
            SqlDataAdapter d1 = new SqlDataAdapter("SELECT Book.ID AS BookID, Book.Title, COUNT(Book_Loan.User_ID) AS LoanCount FROM Book LEFT JOIN Book_Loan ON Book_Loan.Book_ID = Book.ID GROUP BY Book.ID, Book.Title", conn1);
            d1.Fill(dt);
            dataGridView1.DataSource = dt;
            conn1.Close();
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlConnection conn1 = new SqlConnection(serverName);
            conn1.Open();
            SqlDataAdapter d1 = new SqlDataAdapter("SELECT Admin_ID, COUNT(*) AS Added_Books_Count FROM Book GROUP BY Admin_ID", conn1);
            d1.Fill(dt);
            dataGridView1.DataSource = dt;
            conn1.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Report frm = new Report();
            frm.serverName = serverName;
            frm.ShowDialog();
            this.Close();
        }
    }
}
