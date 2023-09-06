using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLSERVER1.PL
{
    public partial class Report : Form
    {
        public string serverName = "Data Source=DESKTOP-09D9S02; Initial Catalog=dd; Integrated Security=True";
        public Report()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            using (SqlConnection conn = new SqlConnection(serverName))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM STUDENT", conn))
                {
                    int? studentCount = (int?)cmd.ExecuteScalar();
                    textBox1.Text = studentCount.ToString();
                    textBox1.Enabled = false;
                }

                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Book", conn))
                {
                    int? bookCount = (int?)cmd.ExecuteScalar();
                    textBox2.Text = bookCount.ToString();
                    textBox2.Enabled = false;
                }

                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Admin", conn))
                {
                    int? adminCount = (int?)cmd.ExecuteScalar();
                    textBox3.Text = adminCount.ToString();
                    textBox3.Enabled = false;
                }

                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Book_Loan GROUP BY Book_ID HAVING COUNT(Book_ID) > ALL (SELECT COUNT(ID) FROM Book WHERE Book_ID <> ID GROUP BY ID)", conn))
                {
                    int? bookHighestLoanCount = (int?)cmd.ExecuteScalar();
                    textBox4.Text = bookHighestLoanCount.ToString();
                    textBox4.Enabled = false;
                }

                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Book_Loan GROUP BY Book_ID HAVING COUNT(Book_ID) < ALL (SELECT COUNT(ID) FROM Book WHERE Book_ID <> ID GROUP BY ID)", conn))
                {
                    int? bookLowestLoanCount = (int?)cmd.ExecuteScalar();
                    textBox5.Text = bookLowestLoanCount.ToString();
                    textBox5.Enabled = false;
                }
            }

        }

        private void Report_Load(object sender, EventArgs e)
        {

        }
    }
}
