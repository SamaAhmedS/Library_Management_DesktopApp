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
    public partial class UpdateAdmin : Form
    {
        public int aID ;
        public string serverName ;

        public UpdateAdmin()
        {
            InitializeComponent();
            LoadS();

        }
        private void UpdateAdmin_Load(object sender, EventArgs e)
        {
            LoadS();
        }
        void LoadS()
        {
            if (serverName != "")
            {
                
                DataTable dt = new DataTable();
                using (SqlConnection conn1 = new SqlConnection())
                {
                    conn1.ConnectionString = "Data Source=SAMA1\\SQLEXPRESS; Initial Catalog=dd; Integrated Security=True"; 

                    // Rest of your code here, such as executing queries or performing database operations

                    conn1.Open();
                    SqlDataAdapter d1 = new SqlDataAdapter("SELECT * FROM Admin WHERE ID = " + aID, conn1);
                    d1.Fill(dt);
                    //MessageBox.Show(dt.Rows[0][1].ToString());
                    if (dt.Rows.Count > 0)
                    {
                        if (Convert.ToInt32(dt.Rows[0][0].ToString()) == aID)
                        {
                            //MessageBox.Show("loded11");
                            FirstN.Text = dt.Rows[0][3].ToString();
                            Email.Text = dt.Rows[0][1].ToString();
                            Pass.Text = dt.Rows[0][2].ToString();
                            role.Text = dt.Rows[0][5].ToString();
                            LastN.Text = dt.Rows[0][4].ToString();
                        }
                    }
                } 
                
            }

        }

        private void SignUp_Click(object sender, EventArgs e)
        {

            SqlConnection conn1 = new SqlConnection(serverName);
            conn1.Open();
            SqlCommand sup = new SqlCommand("UPDATE Admin SET First_Name = @FirstName, Second_Name = @SecondName WHERE ID = @StudentID", conn1);
            sup.Parameters.AddWithValue("@FirstName", FirstN.Text);
            sup.Parameters.AddWithValue("@SecondName", LastN.Text);
            sup.Parameters.AddWithValue("@StudentID", aID);

            sup.ExecuteNonQuery();
            conn1.Close();

        }

        private void SignUp_Click_1(object sender, EventArgs e)
        {
            LoadS();
        }

        private void SignUp_Click_2(object sender, EventArgs e)
        {
            SqlConnection conn1 = new SqlConnection(serverName);
            conn1.Open();
            SqlCommand sup = new SqlCommand("UPDATE Admin SET First_Name = @FirstName, Second_Name = @SecondName, Email = @Email, Password = @Pass, Role = @Rol WHERE ID = @aID", conn1);
            sup.Parameters.AddWithValue("@FirstName", FirstN.Text);
            sup.Parameters.AddWithValue("@SecondName", LastN.Text);
            sup.Parameters.AddWithValue("@Email", Email.Text);
            sup.Parameters.AddWithValue("@Pass", Pass.Text); 
            sup.Parameters.AddWithValue("@Rol", role.Text);
            sup.Parameters.AddWithValue("@aID", aID);
            sup.ExecuteNonQuery();
            conn1.Close();
            //MessageBox.Show(FirstN.Text);
            AppMainWindow frm = new AppMainWindow();
            frm.logged = 2;
            frm.serverName = serverName;
            frm.LoggedID = aID;
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

        private void UpdateAdmin_Load_1(object sender, EventArgs e)
        {
            LoadS();
        }

        private void FName_Click(object sender, EventArgs e)
        {

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            AppMainWindow frm = new AppMainWindow();
            frm.logged = 2;
            frm.serverName = serverName;
            frm.LoggedID = aID;
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }
    }
}
