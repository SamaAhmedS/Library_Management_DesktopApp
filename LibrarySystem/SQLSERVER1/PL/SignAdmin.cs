using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLSERVER1.PL
{
    public partial class SignAdmin : Form
    {
        public int adminID ;
        public string serverName;
        public SignAdmin()
        {
            InitializeComponent();
        }

        private void MBooks_Click(object sender, EventArgs e)
        {

        }

        private void StudInfo_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            AppMainWindow frm = new AppMainWindow();
            frm.logged = 0;
            frm.ShowDialog();
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            if ((FirstN.Text != "") && (LastN.Text != "") && (StudID.Text != "") &&
                (SEmail.Text != "") && (SPass.Text != "") && (SDep.Text != ""))
            {
                string erMess = "";
                int valid = 0;
                //FirstN,LastN, StudID, SEmail,SPass,SDep,SJoinDate

                bool isOnlyNumbers = Regex.IsMatch(StudID.Text, @"^[0-9]+$");

                if (isOnlyNumbers)
                {
                    valid++;
                }
                else
                {
                    erMess += "ID must be a numbers";
                }

                if (checkEmail(SEmail.Text))
                {
                    valid++;
                }
                else
                {
                    erMess += "  Invalid email ";
                }

                if (valid == 2)
                {
                    string table_name = "Admin";
                    SqlConnection conn11 = new SqlConnection(serverName);
                    conn11.Open();

                    string insertQuery = "INSERT INTO " + table_name + " (ID, First_Name, Second_Name, Email, Password, Role, Hire_Date) VALUES (@ID, @FirstName, @SecondName, @Email, @Password, @Role, @HireDate)";
                    SqlCommand newadmin = new SqlCommand(insertQuery, conn11);
                    newadmin.Parameters.AddWithValue("@ID", Convert.ToInt32(StudID.Text));
                    newadmin.Parameters.AddWithValue("@FirstName", FirstN.Text);
                    newadmin.Parameters.AddWithValue("@SecondName", LastN.Text);
                    newadmin.Parameters.AddWithValue("@Email", SEmail.Text);
                    newadmin.Parameters.AddWithValue("@Password", SPass.Text);
                    newadmin.Parameters.AddWithValue("@Role", SDep.Text);
                    newadmin.Parameters.AddWithValue("@HireDate", SJoinDate.Value.ToString("yyyy-MM-dd"));

                    newadmin.ExecuteNonQuery();
                    conn11.Close();

                    MessageBox.Show("Admin SignUp Successful");
                    AppMainWindow frm = new AppMainWindow();
                    frm.logged = 0;
                    frm.serverName = serverName;
                    this.Visible = false;
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {

                    err.Visible = true;
                    err.Text = erMess;
                }
            }
            else
            {
                err.Visible = true;
                err.Text = "Please fill all inputs";
            }
        }
        public bool checkEmail(String email)
        {
            bool isMatch = Regex.IsMatch(email, @"^[a-zA-Z0-9]+@gmail\.com$");
            return isMatch;

        }

        private void SJoinDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void err_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void SDep_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void SPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void SEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void SID_Click(object sender, EventArgs e)
        {

        }

        private void StudID_TextChanged(object sender, EventArgs e)
        {

        }

        private void LName_Click(object sender, EventArgs e)
        {

        }

        private void LastN_TextChanged(object sender, EventArgs e)
        {

        }

        private void FName_Click(object sender, EventArgs e)
        {

        }

        private void FirstN_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {

        }

        private void FirstN_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void SignAdmin_Load(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            AppMainWindow frm = new AppMainWindow();
            frm.logged = 0;
            frm.serverName = serverName;
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }
    }
}
