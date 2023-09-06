using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SQLSERVER1.PL
{
    public partial class studUpdate : Form
    {
        public int sID,ad=0,admin;
        public string serverName;
        public studUpdate()
        {
            InitializeComponent();
            
            cancelbtn.Visible = true;
            cancelbtn.Enabled = true;
            if (ad == 1)
            {

                cancelbtn.Visible = false;
                cancelbtn.Enabled = false;
                delete.Visible = true;
                delete.Enabled = true;

            }
        }
        private void studUpdate_Load(object sender, EventArgs e)
        {

            cancelbtn.Visible = true;
            cancelbtn.Enabled = true;
            if (ad == 1)
            {
                cancelbtn.Visible = false;
                cancelbtn.Enabled = false;
                delete.Visible = true;
                delete.Enabled = true;

            }
            LoadS();
        }
        void LoadS()
        {

            //MessageBox.Show(serverName);
            DataTable dt = new DataTable();
            SqlConnection conn1 = new SqlConnection(serverName);
            conn1.Open();
            SqlDataAdapter d1 = new SqlDataAdapter("SELECT * FROM Student WHERE ID = " + sID, conn1);
            d1.Fill(dt);

            if (dt.Rows.Count>0)
            {
                if (Convert.ToInt32(dt.Rows[0][0].ToString()) == sID)
                {
                    FirstN.Text = dt.Rows[0][1].ToString();
                    SEmail.Text = dt.Rows[0][3].ToString();
                    SPass.Text = dt.Rows[0][4].ToString();
                    SDep.Text = dt.Rows[0][6].ToString();
                    LastN.Text = dt.Rows[0][2].ToString();
                }
            }

        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(serverName);
            SqlConnection conec1 = new SqlConnection(serverName);
            conec1.Open();
            SqlCommand sup = new SqlCommand("UPDATE Student SET First_Name = @FirstName, Second_Name = @SecondName, Email = @Email, Password = @Pass, Department = @Dpart WHERE ID = @StudentID", conec1);
            sup.Parameters.AddWithValue("@FirstName", FirstN.Text);
            sup.Parameters.AddWithValue("@SecondName", LastN.Text);
            sup.Parameters.AddWithValue("@Email", SEmail.Text);
            sup.Parameters.AddWithValue("@Pass", SPass.Text);
            sup.Parameters.AddWithValue("@Dpart", SDep.Text);
            sup.Parameters.AddWithValue("@StudentID", sID);

            sup.ExecuteNonQuery();

            conec1.Close();
            AppMainWindow frm = new AppMainWindow();
            frm.logged = 1;
            frm.LoggedID = sID;
            if (ad == 1)
            {
                frm.logged = 2;
                frm.LoggedID = admin;
                           
            }

            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

        private void FirstN_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastN_TextChanged(object sender, EventArgs e)
        {

        }

        private void SEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void SPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void SDep_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            AppMainWindow frm = new AppMainWindow();
            frm.logged = 1;
            frm.LoggedID = sID;
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection conn11 = new SqlConnection(serverName);
            conn11.Open();
            SqlCommand deleteCmd = new SqlCommand("DELETE FROM Student WHERE ID = " + Convert.ToInt32(sID), conn11);
            deleteCmd.ExecuteNonQuery();
            conn11.Close();
            AppMainWindow frm = new AppMainWindow();
            frm.logged = 2;
            frm.LoggedID = admin;
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
            
        }

        private void StudInfo_Enter(object sender, EventArgs e)
        {
            LoadS();
        }
    }
}
