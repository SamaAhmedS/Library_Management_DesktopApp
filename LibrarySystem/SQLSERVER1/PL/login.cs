using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Recognition;
using System.Collections;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace SQLSERVER1.PL
{
    public partial class login : Form
    {
        public string table_name, serverName;
        public login()
        {
            InitializeComponent();

        }


        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        //cancel btn
        private void button2_Click(object sender, EventArgs e)
        {
            pass.Clear();
            userName.Clear();
            this.Close();
            AppMainWindow frm = new AppMainWindow();
            frm.logged = 0;
            frm.ShowDialog();
            //this.Enabled = false;
        }
        //Login btn
        private void button1_Click(object sender, EventArgs e)
        {
            bool isOnlyNumbers = Regex.IsMatch(userName.Text, @"^[0-9]+$");

            if (isOnlyNumbers)
            {
                int isAdmin = 0, isStudent = 0;
                SqlConnection conn = new SqlConnection(serverName);
                conn.Open();
                table_name = "Admin";
                SqlDataAdapter d2 = new SqlDataAdapter("SELECT COUNT(*) FROM Admin WHERE ID = '" + Convert.ToInt32(userName.Text) + "' AND Password = '" + pass.Text + "'", conn);
                DataTable dt = new DataTable();
                d2.Fill(dt);
                if (Convert.ToInt32(dt.Rows[0][0].ToString()) != 0)
                {
                    isAdmin = 1;
                }

                if (isAdmin == 0)
                {
                    SqlConnection con1 = new SqlConnection(serverName);
                    con1.Open();
                    table_name = "Student";
                    SqlDataAdapter stud = new SqlDataAdapter("SELECT COUNT(*) FROM " + table_name + " WHERE ID = '" + Convert.ToInt32(userName.Text) + "' AND Password = '" + pass.Text + "'", conn);
                    DataTable dt1 = new DataTable();
                    stud.Fill(dt1);
                    if (Convert.ToInt32(dt1.Rows[0][0].ToString()) != 0)
                    {
                        isStudent = 1;
                    }
                }

                if (isStudent == 1)
                {
                    MessageBox.Show("Student Login Successful");
                    //MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    AppMainWindow frm = new AppMainWindow();
                    frm.logged = 1;
                    frm.LoggedID = Convert.ToInt32(userName.Text);
                    frm.serverName = serverName;
                    this.Visible = false;
                    frm.ShowDialog();
                    this.Close();
                }
                else if (isAdmin == 1)
                {
                    MessageBox.Show("Admin Login Successful");
                    //MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    AppMainWindow frm = new AppMainWindow();
                    frm.logged = 2;
                    frm.LoggedID = Convert.ToInt32(userName.Text);
                    frm.serverName = serverName;
                    this.Visible = false;
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password");
                    pass.Clear();
                    userName.Clear();
                }
            }
            else
            {

            }

        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            AppMainWindow frm = new AppMainWindow();
            frm.logged = 0;
            frm.serverName = serverName;
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

        private void login_Load_1(object sender, EventArgs e)
        {

        }
        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void speechrec(object sender, SpeechRecognizedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
        }
    }
}
