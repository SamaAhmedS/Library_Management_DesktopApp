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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SQLSERVER1.PL
{
    public partial class AppMainWindow : Form
    {
        public int logged = 0, LoggedID;
        public string table_name;
        public string serverName ;
        public AppMainWindow()
        {

            InitializeComponent();

            unlogedpanel.Location = new Point(465, 194);
            Spanel.Location = new Point(465, 194);
            adminpanel.Location = new Point(465, 194);
            panel1.Location = new Point(465, 194);
            if (logged == 0)
            {
                unlogedpanel.Visible = true;
                Spanel.Visible = false;
                adminpanel.Visible = false;
            }
            else if (logged == 1)
            {
                unlogedpanel.Visible = false;
                Spanel.Visible = true;
                adminpanel.Visible = false;
            }
            else if (logged == 2)
            {
                unlogedpanel.Visible = false;
                Spanel.Visible = false;
                adminpanel.Visible = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            login l = new login();
            l.serverName = serverName;
            this.Visible = false;
            l.ShowDialog();
            this.Close();
        }

        private void SignAdmin_Click(object sender, EventArgs e)
        {

            SignAdmin frm = new SignAdmin();
            frm.serverName = serverName;
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

        private void SignStud_Click(object sender, EventArgs e)
        {
            if (logged == 0)
            {

                SignStudent frm = new SignStudent();
                frm.serverName = serverName;
                frm.ShowDialog();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void AppMainWindow_Load(object sender, EventArgs e)
        {
            if (logged == 0)
            {
                unlogedpanel.Visible = true;
                Spanel.Visible = false;
                adminpanel.Visible = false;
            }
            else if (logged == 1)
            {
                unlogedpanel.Visible = false;
                Spanel.Visible = true;
                adminpanel.Visible = false;
            }
            else if (logged == 2)
            {
                unlogedpanel.Visible = false;
                Spanel.Visible = false;
                adminpanel.Visible = true;
            }
        }

        private void adminLogout_Click(object sender, EventArgs e)
        {
            logged = 0;
            unlogedpanel.Visible = true;
            Spanel.Visible = false;
            adminpanel.Visible = false;
        }

        private void StudLogout_Click(object sender, EventArgs e)
        {
            logged = 0;
            unlogedpanel.Visible = true;
            Spanel.Visible = false;
            adminpanel.Visible = false;
        }

        private void browsBooks_Click(object sender, EventArgs e)
        {
            StudentBrowesBooks frm = new StudentBrowesBooks();
            frm.StudID = logged;
            frm.Show();
            this.Close();
        }

        private void SignStud_Click_1(object sender, EventArgs e)
        {
            
            SignStudent frm = new SignStudent();
            frm.serverName = serverName;
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

        private void SignAdmin_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            SignAdmin frm = new SignAdmin();
            frm.serverName = serverName;
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

        private void AppMainWindow_Load_1(object sender, EventArgs e)
        {
            unlogedpanel.Location = new Point(465, 194);
            Spanel.Location = new Point(465, 194);
            adminpanel.Location = new Point(465, 194);
            panel1.Location = new Point(465, 194);
            if (logged == 0)
            {
                unlogedpanel.Visible = true;
                Spanel.Visible = false;
                adminpanel.Visible = false;
            }
            else if (logged == 1)
            {
                unlogedpanel.Visible = false;
                Spanel.Visible = true;
                adminpanel.Visible = false;
            }
            else if (logged == 2)
            {
                unlogedpanel.Visible = false;
                Spanel.Visible = false;
                adminpanel.Visible = true;
            }
        }

        private void updateAdmin_Click(object sender, EventArgs e)
        {

        }

        private void adminLogout_Click_1(object sender, EventArgs e)
        {
            logged = 0;
            unlogedpanel.Visible = true;
            Spanel.Visible = false;
            adminpanel.Visible = false;
        }

        private void StudLogout_Click_1(object sender, EventArgs e)
        {
            logged = 0;
            unlogedpanel.Visible = true;
            Spanel.Visible = false;
            adminpanel.Visible = false;
        }

        private void ManageBooks_Click_1(object sender, EventArgs e)
        {
            //this.Visible = false;
            ManageBooks frm = new ManageBooks();
            frm.serverName = serverName;
            frm.adminID = LoggedID;
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

        private void browsBooks_Click_1(object sender, EventArgs e)
        {
            //this.Visible = false;
            StudentBrowesBooks frm = new StudentBrowesBooks();
            frm.serverName = serverName;
            frm.StudID = LoggedID;
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

        private void UpdateStudent_Click(object sender, EventArgs e)
        {
            studUpdate frm = new studUpdate();
            frm.sID = LoggedID;
            frm.ad = 0;
            frm.serverName = serverName;
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Statics frm = new Statics();
            frm.serverName = serverName;
            frm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateAdmin frm = new UpdateAdmin();
            frm.serverName = serverName;
            frm.aID = LoggedID;
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            unlogedpanel.Visible = false;
            Spanel.Visible = false;
            adminpanel.Visible = false;
            panel1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            unlogedpanel.Visible =false;
            panel1.Visible =false;
            Spanel.Visible = false;
            adminpanel.Visible = true;
        }

        private void search_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(serverName);
            con1.Open();
            table_name = "Student";
            SqlDataAdapter stud = new SqlDataAdapter("SELECT COUNT(*) FROM " + table_name + " WHERE ID = '" + Convert.ToInt32(sid.Text)+ "'", con1);
            DataTable dt1 = new DataTable();
            stud.Fill(dt1);
            con1.Close();
            if (Convert.ToInt32(dt1.Rows[0][0].ToString()) != 0)
            {
                studUpdate frm = new studUpdate();
                frm.sID = Convert.ToInt32(sid.Text);
                frm.ad = 1;
                frm.admin = LoggedID;
                frm.serverName = serverName;
                this.Visible = false;
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("there is no student with such ID");
            }
        }

        private void Myloans_Click(object sender, EventArgs e)
        {
            StudLoans frm = new StudLoans();
            frm.serverName = serverName;
            frm.StudID = LoggedID;            
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

        private void ManageBooks_Click(object sender, EventArgs e)
        {
            if (logged == 2)
            {

                ManageBooks frm = new ManageBooks();
                frm.adminID = LoggedID;
                frm.serverName = serverName;
                frm.ShowDialog();
                this.Visible = false;
                this.Close();
            }
        }
    }
}
