using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using testConn.PL;

namespace testConn
{
    public partial class Form1 : Form
    {
 

        BL.CLS_PRODUCTS prd = new BL.CLS_PRODUCTS();
        public object pbox { get; private set; }

        int secs, min, hours;
        public Form1()
        {
            InitializeComponent();
        }
        Stopwatch sw = new Stopwatch();

        MySqlConnection conmy = new MySqlConnection("Server=localhost; database=ddddd; UID=root; Password=; SslMode=none");

        SqlConnection conq = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        SqlConnection conq2 = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Judges;Integrated Security=True");

        //OleDbConnection conn = new OleDbConnection();
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= ElectronicArbitration1.accdb;Persist Security Info=True");
        

        public bool InvalidTimeException { get; private set; }

        //private int Value;

        //private readonly object txtreadB1;

        private void btnOpen_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //If txtredpj1.Value = 0 is txtbluepj1.Value = 0 Then
            // Me.Boxrj1.Visible = False
            // Me.Boxbj1.Visible = False
            //    End If
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= ElectronicArbitration1.accdb;Persist Security Info=True";
        }
        private void Execute(string str)
        {
            try
            {
                // الاتصال اكسل
                OleDbConnection conn0 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=task2.xlsx;Extended Properties='Excel 12.0 Xml;HDR=YES'");
                OleDbCommand cmd0 = new OleDbCommand("select * from [sheet1$]", conn0);

                string cmdText;
                cmdText = str;
                cmd0.CommandText = cmdText;
                conn0.Open();
                cmd0.ExecuteNonQuery();
                conn0.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SqlExecute(string str)
        {
            try
            {
                //  الاتصال سيرفر
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-09D9S02;Initial Catalog=Product_DB;Persist Security Info=True;User ID=admin1;Password=123");

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandText = str;
                conn.Open();
                cmd.ExecuteNonQuery();
               
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //OleDbCommand cmd = new OleDbCommand();
            //cmd.Connection = conn;
            //cmd.CommandText = "create table dept(deptno number primary key,deptname text)";

            //cmd.ExecuteNonQuery();

            OleDbCommand cmd = new OleDbCommand("insert into dept values(1, 'Information Systems')", conn);
            //conn.Open();
            cmd.ExecuteNonQuery();
            //conn.Close();

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OleDbConnection conn2 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= ElectronicArbitration2.accdb;Persist Security Info=True");
            OleDbCommand cmd = new OleDbCommand("select * from Judge1", conn2);
            conn2.Open();
            OleDbDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    txtread.Text += reader[0] + " ; " + reader[1] + "\n";
            //}

            reader.Read();
            //lbl.Text = reader.GetValue(1).ToString();
            txtreadB1.Text = reader[3].ToString();
            txtreadR1.Text = reader[1].ToString();
            //lbl.Text += reader["deptname"].ToString();





            conn2.Close();





        }
        //int ID;
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {

                 SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-09D9S02,1433;Initial Catalog=Product_DB;Persist Security Info=True;User ID=admin1;Password=123");
                //SqlCommand cmd11 = new SqlCommand("select * from Q_Judge", conn);
                SqlCommand cmd11 = new SqlCommand("Q_Judge1", conn);

                conn.Open();
                SqlDataReader reader1 = cmd11.ExecuteReader();
                //ID = Convert.ToInt32(cmd11.ExecuteScalar());
                reader1.Read();
                txtreadB1.Text = reader1[3].ToString();
                txtreadR1.Text = reader1[1].ToString();
                
                conn.Close();

            }
            catch
            {
            }
        }
        private void btnFill_Click(object sender, EventArgs e)
        {
          
        }

        private void btnSaveImg_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= ElectronicArbitration2.accdb;Persist Security Info=True");
                OleDbCommand cm = new OleDbCommand("insert into img values(1,@img)", con);

                cm.Parameters.AddWithValue("@img", File.ReadAllBytes("jjjjj.jpg"));


                con.Open();
                cm.ExecuteNonQuery();
                con.Close();

            }
            catch
            {
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {

                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-09D9S02,1433;Initial Catalog=Product_DB;Persist Security Info=True;User ID=admin1;Password=123");
                //SqlCommand cmd11 = new SqlCommand("select * from Q_Judge", conn);
                SqlCommand cmd11 = new SqlCommand("Q_Judge2", conn);

                conn.Open();
                SqlDataReader reader2 = cmd11.ExecuteReader();
                //ID = Convert.ToInt32(cmd11.ExecuteScalar());
                reader2.Read();
                txtreadB2.Text = reader2[3].ToString();
                txtreadR2.Text = reader2[1].ToString();

                conn.Close();


                ////OleDbConnection conn2 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= ElectronicArbitration2.accdb;Persist Security Info=True");
                ////OleDbCommand cmd2 = new OleDbCommand("select * from headJudgej2", conn2);

                ////conn2.Open();
                ////OleDbDataReader reader2 = cmd2.ExecuteReader();
                ////reader2.Read();
                ////txtreadB2.Text = reader2[3].ToString();
                ////txtreadR2.Text = reader2[1].ToString();
                ////conn2.Close();
            }
            catch
            {
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-09D9S02,1433;Initial Catalog=Product_DB;Persist Security Info=True;User ID=admin1;Password=123");
                //SqlCommand cmd11 = new SqlCommand("select * from Q_Judge", conn);
                SqlCommand cmd11 = new SqlCommand("Q_Judge3", conn);

                conn.Open();
                SqlDataReader reader1 = cmd11.ExecuteReader();
                //ID = Convert.ToInt32(cmd11.ExecuteScalar());
                reader1.Read();
                txtreadB3.Text = reader1[3].ToString();
                txtreadR3.Text = reader1[1].ToString();

                conn.Close();
            }
            catch
            {
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-09D9S02,1433;Initial Catalog=Product_DB;Persist Security Info=True;User ID=admin1;Password=123");
                //SqlCommand cmd11 = new SqlCommand("select * from Q_Judge", conn);
                SqlCommand cmd11 = new SqlCommand("Q_Judge4", conn);

                conn.Open();
                SqlDataReader reader1 = cmd11.ExecuteReader();
                //ID = Convert.ToInt32(cmd11.ExecuteScalar());
                reader1.Read();
                txtreadB4.Text = reader1[3].ToString();
                txtreadR4.Text = reader1[1].ToString();

                conn.Close();
            }
            catch
            {
            }

        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-09D9S02,1433;Initial Catalog=Product_DB;Persist Security Info=True;User ID=admin1;Password=123");
                //SqlCommand cmd11 = new SqlCommand("select * from Q_Judge", conn);
                SqlCommand cmd11 = new SqlCommand("Q_Judge5", conn);

                conn.Open();
                SqlDataReader reader1 = cmd11.ExecuteReader();
                //ID = Convert.ToInt32(cmd11.ExecuteScalar());
                reader1.Read();
                txtreadB5.Text = reader1[3].ToString();
                txtreadR5.Text = reader1[1].ToString();

                conn.Close();
            }
            catch
            {
            }
        }

        private void bntShow_Click(object sender, EventArgs e)
        {
            try
            {

            double x, y, t;
            x = double.Parse(txtreadR1.Text);
            y = double.Parse(txtreadB1.Text);
            t = double.Parse(lbl1.Text);
            t = x - y;
            lbl1.Text = t.ToString();

            //lbl1.Text = "1";
            //pBR1.Visible = true;
                //var frm = new ElectronicArbitration2();
                //frm.Show();
                if (t <= 0)
                {
                    pBR1.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("اكتب قيمه");
            }
        }

        private void pBR1_Click(object sender, EventArgs e)
        {





            //int R1, B1, t1;
            
            //R1 = int.Parse(txtreadR1.Text);
            //B1 = int.Parse(txtreadB1.Text);
            //t1 = int.Parse(tr1.Text);
            //t1 = R1 - B1;
            //if (R1 == B1) 
            //pBR1.Visible = true; 

           
        }

        private void pBb1_Click(object sender, EventArgs e)
        {
            try
            {

                double x, y, t;
                x = double.Parse(txtreadR3.Text);
                y = double.Parse(txtreadB3.Text);
                t = double.Parse(lbl1.Text);
                t = x + y;
                lbl1.Text = t.ToString();

                //lbl1.Text = "1";
                //pBR1.Visible = true;
                //var frm = new ElectronicArbitration2();
                //frm.Show();
                if (t == 0)
                {
                    pBR1.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("اكتب قيمه");
            }


            //            int R1, B1;
            //R1 = int.Parse(txtreadR1.Text);
            //B1 = int.Parse(txtreadB1.Text);
            //if (R1 > B1)Invalid = pBR1.Visible = true; 

        }

        private void tr1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            double x1, y1, t1;
            x1 = double.Parse(txtreadR1.Text);
            y1 = double.Parse(txtreadB1.Text);
            t1 = double.Parse(lbl1.Text);

            t1 = x1 - y1;

            lbl1.Text = t1.ToString();

            {

                if (txtreadB1.Text == txtreadR1.Text)
                {
                    pBb1.Visible = true;
                    pBR1.Visible = true;
                }


                if (t1 >= 0)
                {
                    pBR1.Visible = true;
                    pBb1.Visible = false;
                }
                if (t1 <= 0)
                {
                    pBb1.Visible = true;
                    pBR1.Visible = false;
                }
                if (t1 == 0)
                {
                    pBR1.Visible = true;
                    pBb1.Visible = true;
                }
            }
            

            }

        private void timer7_Tick(object sender, EventArgs e)
        {
            double x2, y2, t2;
            x2 = double.Parse(txtreadR2.Text);
            y2 = double.Parse(txtreadB2.Text);
            //t1 = double.Parse(lbl1.Text);
            t2 = double.Parse(lbl2.Text);
            //t1 = x - y;
            t2 = y2 - x2;
            //lbl1.Text = t1.ToString();
            lbl2.Text = t2.ToString();



            if (x2 == 0)
            {
                pBR2.Visible = true;
            }
            if (y2 == 0)
            {
                pBb2.Visible = true;

            }
            if (y2 >= x2)
            {
                pBR2.Visible = false;
                pBb2.Visible = true;

            }

            if (y2 <= x2)
            {
                pBb2.Visible = false;
                pBR2.Visible = true;
            }
            if (t2 == 0)
            {
                pBR2.Visible = true;
                pBb2.Visible = true;
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {

            double x3, y3, t3;
            x3 = double.Parse(txtreadR3.Text);
            y3 = double.Parse(txtreadB3.Text);
            //t1 = double.Parse(lbl1.Text);
            t3 = double.Parse(lbl3.Text);
            //t1 = x - y;
            t3 = y3 - x3;
            //lbl1.Text = t1.ToString();
            lbl3.Text = t3.ToString();



            if (x3 == 0)
            {
                pBR3.Visible = true;
            }
            if (y3 == 0)
            {
                pBb3.Visible = true;

            }
            if (y3 >= x3)
            {
                pBR3.Visible = false;
                pBb3.Visible = true;

            }

            if (y3 <= x3)
            {
                pBb3.Visible = false;
                pBR3.Visible = true;
            }
            if (t3 == 0)
            {
                pBR3.Visible = true;
                pBb3.Visible = true;
            }
        }

        private void timer9_Tick(object sender, EventArgs e)
        {

            double x4, y4, t4;
            x4 = double.Parse(txtreadR4.Text);
            y4 = double.Parse(txtreadB4.Text);
            //t1 = double.Parse(lbl1.Text);
            t4 = double.Parse(lbl4.Text);
            //t1 = x - y;
            t4 = y4 - x4;
            //lbl1.Text = t1.ToString();
            lbl4.Text = t4.ToString();



            if (x4 == 0)
            {
                pBR4.Visible = true;
            }
            if (y4 == 0)
            {
                pBb4.Visible = true;

            }
            if (y4 >= x4)
            {
                pBR4.Visible = false;
                pBb4.Visible = true;

            }

            if (y4 <= x4)
            {
                pBb4.Visible = false;
                pBR4.Visible = true;
            }
            if (t4 == 0)
            {
                pBR4.Visible = true;
                pBb4.Visible = true;
            }
        }

        private void timer10_Tick(object sender, EventArgs e)
        {

            double x5, y5, t5;
            x5 = double.Parse(txtreadR5.Text);
            y5 = double.Parse(txtreadB5.Text);
            //t1 = double.Parse(lbl1.Text);
            t5 = double.Parse(lbl5.Text);
            //t1 = x - y;
            t5 = y5 - x5;
            //lbl1.Text = t1.ToString();
            lbl5.Text = t5.ToString();



            if (x5 == 0)
            {
                pBR5.Visible = true;
            }
            if (y5 == 0)
            {
                pBb5.Visible = true;

            }
            if (y5 >= x5)
            {
                pBR5.Visible = false;
                pBb5.Visible = true;

            }

            if (y5 <= x5)
            {
                pBb5.Visible = false;
                pBR5.Visible = true;
            }
            if (t5 == 0)
            {
                pBR5.Visible = true;
                pBb5.Visible = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click_1(object sender, EventArgs e)
        {
            try
            {

                conq.Open();
                //conq.Open();
                MessageBox.Show("Open");

                conq2.Open();
                MessageBox.Show("Open2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            try
            {
                conq.Close();
                MessageBox.Show("Close");

                conq2.Close();
                MessageBox.Show("Close2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            double x6, y6, t6;
            x6 = double.Parse(txtR1.Text);
            y6 = double.Parse(txtB1.Text);
            t6 = double.Parse(lbl6.Text);

            t6 = x6 - y6;

            lbl6.Text = t6.ToString();

            {

                if (txtB1 == txtR1)
                {
                    pBb6.Visible = true;
                    pBR6.Visible = true;
                }


                if (t6 >= 0)
                {
                    pBR6.Visible = true;
                    pBb6.Visible = false;
                }
                if (t6 <= 0)
                {
                    pBb6.Visible = true;
                    pBR6.Visible = false;
                }
                if (t6 == 0)
                {
                    pBR6.Visible = false;
                    pBb6.Visible = false;
                }

            }
            }

        private void timer12_Tick(object sender, EventArgs e)
        {
            double x7, y7, t7;
            x7 = double.Parse(txtR2.Text);
            y7 = double.Parse(txtB2.Text);
            t7 = double.Parse(lbl7.Text);

            t7 = x7 - y7;

            lbl7.Text = t7.ToString();

            {

                if (txtB2 == txtR2)
                {
                    pBb7.Visible = true;
                    pBR7.Visible = true;
                }


                if (t7 >= 0)
                {
                    pBR7.Visible = true;
                    pBb7.Visible = false;
                }
                if (t7 <= 0)
                {
                    pBb7.Visible = true;
                    pBR7.Visible = false;
                }
                if (t7 == 0)
                {
                    pBR7.Visible = false;
                    pBb7.Visible = false;
                }
            }


            }


        private void timer13_Tick(object sender, EventArgs e)
        {
            double x8, y8, t8;
            x8 = double.Parse(txtR3.Text);
            y8 = double.Parse(txtB3.Text);
            t8 = double.Parse(lbl8.Text);

            t8 = x8 - y8;

            lbl8.Text = t8.ToString();

            {

                if (txtB3 == txtR3)
                {
                    pBb8.Visible = true;
                    pBR8.Visible = true;
                }


                if (t8 >= 0)
                {
                    pBR8.Visible = true;
                    pBb8.Visible = false;
                }
                if (t8 <= 0)
                {
                    pBb8.Visible = true;
                    pBR8.Visible = false;
                }
                if (t8 == 0)
                {
                    pBR8.Visible = false;
                    pBb8.Visible = false;
                }

            }
        }

        private void btnR1_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.txtNR = txtNR.Text;
            Properties.Settings.Default.txtCR = txtCR.Text;

            txtR1.Text = ("1");
            btnR1.Text = ("1");


            var frm = new Form3(this);
            frm.Show(secondss);

            try
            {
                OleDbConnection conn0 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=task1.xlsx;Extended Properties='Excel 12.0 Xml;HDR=YES'");
                OleDbCommand cmd0 = new OleDbCommand("select * from [sheet1$]", conn0);

                string cmdText;
                cmdText = "insert into [sheet1$] ([ID],[nameR],[clubR],[nameB],[clubB],[Weigh],[jR1],[jB1],[jR2],[jB2],[jR3],[jB3],[jR4],[jB4],[jR5],[jB5],[R],[Result],[wr],[wb],[xr],[xb],[cr],[cb],[er],[eb]) values('" + lblR.Text + "','" + txtNR.Text + "','" + txtCR.Text + "','" + txtNB.Text + "','" + txtCB.Text + "','" + lblWeigh.Text + "','" + txtreadR1.Text + "','" + txtreadB1.Text + "','" + txtreadR2.Text + "','" + txtreadB2.Text + "','" + txtreadR3.Text + "','" + txtreadB3.Text + "','" + txtreadR4.Text + "','" + txtreadB4.Text + "','" + txtreadR5.Text + "','" + txtreadB5.Text + "','" + label8.Text + "','" + Red.Text + "','"+ txtRW1.Text+ "','" + txtBW1.Text + "','" + txtRX1.Text + "','" + txtBX1.Text + "','" + txtR81.Text + "','" + txtB81.Text + "','" + txtRE1.Text + "','" + txtBE1.Text + "')";
                cmd0.CommandText = cmdText;
                conn0.Open();
                cmd0.ExecuteNonQuery();
                conn0.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnR2_Click(object sender, EventArgs e)
        {
            txtR2.Text = ("1");
            btnR2.Text = ("1");
            if (txtB1.Text == "1")
            {
                Properties.Settings.Default.txtNR = txtNR.Text;
                Properties.Settings.Default.txtCR = txtCR.Text;
                Properties.Settings.Default.txtNB = txtNB.Text;
                Properties.Settings.Default.txtCB = txtCB.Text;
                var frm1 = new Form5();
                frm1.Show(secondss);
            }
            if (txtB1.Text == "0")
            {
                var frm = new Form3(this);
                frm.Show(secondss);
            }

            try
            {
                OleDbConnection conn0 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=task1.xlsx;Extended Properties='Excel 12.0 Xml;HDR=YES'");
                OleDbCommand cmd0 = new OleDbCommand("select * from [sheet1$]", conn0);

                string cmdText;
                cmdText = "insert into [sheet1$] ([ID],[nameR],[clubR],[nameB],[clubB],[Weigh],[jR1],[jB1],[jR2],[jB2],[jR3],[jB3],[jR4],[jB4],[jR5],[jB5],[R],[Result],[wr],[wb],[xr],[xb],[cr],[cb],[er],[eb]) values('" + lblR.Text + "','" + txtNR.Text + "','" + txtCR.Text + "','" + txtNB.Text + "','" + txtCB.Text + "','" + lblWeigh.Text + "','" + txtreadR1.Text + "','" + txtreadB1.Text + "','" + txtreadR2.Text + "','" + txtreadB2.Text + "','" + txtreadR3.Text + "','" + txtreadB3.Text + "','" + txtreadR4.Text + "','" + txtreadB4.Text + "','" + txtreadR5.Text + "','" + txtreadB5.Text + "','" + label7.Text + "','" + Red.Text + "','" + txtRW2.Text + "','" + txtBW2.Text + "','" + txtRX2.Text + "','" + txtBX2.Text + "','" + txtR82.Text + "','" + txtB82.Text + "','" + txtRE2.Text + "','" + txtBE2.Text + "')";
                cmd0.CommandText = cmdText;
                conn0.Open();
                cmd0.ExecuteNonQuery();
                conn0.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnR3_Click(object sender, EventArgs e)
        {
            txtR3.Text = ("1");
            btnR3.Text = ("1");
            var frm = new Form3(this);
            frm.Show(secondss);
            try
            {
                OleDbConnection conn0 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=task1.xlsx;Extended Properties='Excel 12.0 Xml;HDR=YES'");
                OleDbCommand cmd0 = new OleDbCommand("select * from [sheet1$]", conn0);

                string cmdText;
                cmdText = "insert into [sheet1$] ([ID],[nameR],[clubR],[nameB],[clubB],[Weigh],[jR1],[jB1],[jR2],[jB2],[jR3],[jB3],[jR4],[jB4],[jR5],[jB5],[R],[Result],[wr],[wb],[xr],[xb],[cr],[cb],[er],[eb]) values('" + lblR.Text + "','" + txtNR.Text + "','" + txtCR.Text + "','" + txtNB.Text + "','" + txtCB.Text + "','" + lblWeigh.Text + "','" + txtreadR1.Text + "','" + txtreadB1.Text + "','" + txtreadR2.Text + "','" + txtreadB2.Text + "','" + txtreadR3.Text + "','" + txtreadB3.Text + "','" + txtreadR4.Text + "','" + txtreadB4.Text + "','" + txtreadR5.Text + "','" + txtreadB5.Text + "','" + label6.Text + "','" + Red.Text + "','" + txtRW3.Text + "','" + txtBW3.Text + "','" + txtRX3.Text + "','" + txtBX3.Text + "','" + txtR83.Text + "','" + txtB83.Text + "','" + txtRE3.Text + "','" + txtBE3.Text + "')";
                cmd0.CommandText = cmdText;
                conn0.Open();
                cmd0.ExecuteNonQuery();
                conn0.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnB1_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.txtNB = txtNB.Text;
            Properties.Settings.Default.txtCB = txtCB.Text;

            txtB1.Text = ("1");
            btnB1.Text = ("1");
            var frm = new Form4();
            frm.Show(secondss);
            try
            {
                OleDbConnection conn0 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=task1.xlsx;Extended Properties='Excel 12.0 Xml;HDR=YES'");
                OleDbCommand cmd0 = new OleDbCommand("select * from [sheet1$]", conn0);

                string cmdText;
                cmdText = "insert into [sheet1$] ([ID],[nameR],[clubR],[nameB],[clubB],[Weigh],[jR1],[jB1],[jR2],[jB2],[jR3],[jB3],[jR4],[jB4],[jR5],[jB5],[R],[Result],[wr],[wb],[xr],[xb],[cr],[cb],[er],[eb]) values('" + lblR.Text + "','" + txtNR.Text + "','" + txtCR.Text + "','" + txtNB.Text + "','" + txtCB.Text + "','" + lblWeigh.Text + "','" + txtreadR1.Text + "','" + txtreadB1.Text + "','" + txtreadR2.Text + "','" + txtreadB2.Text + "','" + txtreadR3.Text + "','" + txtreadB3.Text + "','" + txtreadR4.Text + "','" + txtreadB4.Text + "','" + txtreadR5.Text + "','" + txtreadB5.Text + "','" + label8.Text + "','" + Blue.Text + "','" + txtRW1.Text + "','" + txtBW1.Text + "','" + txtRX1.Text + "','" + txtBX1.Text + "','" + txtR81.Text + "','" + txtB81.Text + "','" + txtRE1.Text + "','" + txtBE1.Text + "')";
                cmd0.CommandText = cmdText;
                conn0.Open();
                cmd0.ExecuteNonQuery();
                conn0.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            txtB2.Text = ("1");
            btnB2.Text = ("1");
            if (txtR1.Text == "1")
            {
                Properties.Settings.Default.txtNR = txtNR.Text;
                Properties.Settings.Default.txtCR = txtCR.Text;
                Properties.Settings.Default.txtNB = txtNB.Text;
                Properties.Settings.Default.txtCB = txtCB.Text;
                var frm1 = new Form5();
                frm1.Show(secondss);
            }
            if (txtR1.Text == "0")
            {
                var frm = new Form4();
                frm.Show(secondss);
            }
            
            try
            {
                OleDbConnection conn0 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=task1.xlsx;Extended Properties='Excel 12.0 Xml;HDR=YES'");
                OleDbCommand cmd0 = new OleDbCommand("select * from [sheet1$]", conn0);

                string cmdText;
                cmdText = "insert into [sheet1$] ([ID],[nameR],[clubR],[nameB],[clubB],[Weigh],[jR1],[jB1],[jR2],[jB2],[jR3],[jB3],[jR4],[jB4],[jR5],[jB5],[R],[Result],[wr],[wb],[xr],[xb],[cr],[cb],[er],[eb]) values('" + lblR.Text + "','" + txtNR.Text + "','" + txtCR.Text + "','" + txtNB.Text + "','" + txtCB.Text + "','" + lblWeigh.Text + "','" + txtreadR1.Text + "','" + txtreadB1.Text + "','" + txtreadR2.Text + "','" + txtreadB2.Text + "','" + txtreadR3.Text + "','" + txtreadB3.Text + "','" + txtreadR4.Text + "','" + txtreadB4.Text + "','" + txtreadR5.Text + "','" + txtreadB5.Text + "','" + label7.Text + "','" + Blue.Text + "','" + txtRW2.Text + "','" + txtBW2.Text + "','" + txtRX2.Text + "','" + txtBX2.Text + "','" + txtR82.Text + "','" + txtB82.Text + "','" + txtRE2.Text + "','" + txtBE2.Text + "')";
                cmd0.CommandText = cmdText;
                conn0.Open();
                cmd0.ExecuteNonQuery();
                conn0.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            txtB3.Text = ("1");
            btnB3.Text = ("1");
            var frm = new Form4();
            frm.Show(secondss);
            try
            {
                OleDbConnection conn0 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=task1.xlsx;Extended Properties='Excel 12.0 Xml;HDR=YES'");
                OleDbCommand cmd0 = new OleDbCommand("select * from [sheet1$]", conn0);

                string cmdText;
                cmdText = "insert into [sheet1$] ([ID],[nameR],[clubR],[nameB],[clubB],[Weigh],[jR1],[jB1],[jR2],[jB2],[jR3],[jB3],[jR4],[jB4],[jR5],[jB5],[R],[Result],[wr],[wb],[xr],[xb],[cr],[cb],[er],[eb]) values('" + lblR.Text + "','" + txtNR.Text + "','" + txtCR.Text + "','" + txtNB.Text + "','" + txtCB.Text + "','" + lblWeigh.Text + "','" + txtreadR1.Text + "','" + txtreadB1.Text + "','" + txtreadR2.Text + "','" + txtreadB2.Text + "','" + txtreadR3.Text + "','" + txtreadB3.Text + "','" + txtreadR4.Text + "','" + txtreadB4.Text + "','" + txtreadR5.Text + "','" + txtreadB5.Text + "','" + label6.Text + "','" + Blue.Text + "','" + txtRW3.Text + "','" + txtBW3.Text + "','" + txtRX3.Text + "','" + txtBX3.Text + "','" + txtR83.Text + "','" + txtB83.Text + "','" + txtRE3.Text + "','" + txtBE3.Text + "')";
                cmd0.CommandText = cmdText;
                conn0.Open();
                cmd0.ExecuteNonQuery();
                conn0.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtR1.Text = ("0");
            txtR2.Text = ("0");
            txtR3.Text = ("0");
            txtB1.Text = ("0");
            txtB2.Text = ("0");
            txtB3.Text = ("0");
            btnR1.Text = ("0");
            btnR2.Text = ("0");
            btnR3.Text = ("0");
            btnB1.Text = ("0");
            btnB2.Text = ("0");
            btnB3.Text = ("0");


            txtRW1.Text = ("0");
            pBRW1.Visible = false;
            txtRW1.Visible = false;
            txtRX1.Text = ("0");
            pBRX1.Visible = false;
            txtRX1.Visible =false;
            txtR81.Text = ("0");
            txtR81.Visible = false;
            pBR81.Visible = false;
            txtRE1.Text = ("0");
            txtRE1.Visible = false;
            pBRE1.Visible = false;
            txtRE2.Text = ("0");
            txtRE2.Visible = false;
            pBRE2.Visible = false;
            txtRE3.Text = ("0");
            txtRE3.Visible = false;
            pBRE3.Visible = false;
            txtR81.Text = ("0");
            txtR81.Visible = false;
            pBR81.Visible = false;
            txtRX2.Text = ("0");
            txtRX2.Visible = false;
            pBRX2.Visible = false;
            txtRX3.Text = ("0");
            txtRX3.Visible = false;
            pBRX3.Visible = false;
            txtR82.Text = ("0");
            txtR82.Visible = false;
            pBR82.Visible = false;
            txtR83.Text = ("0");
            txtR83.Visible = false;
            pBR83.Visible = false;
            txtRW2.Text = ("0");
            txtRW2.Visible = false;
            pBRW2.Visible = false;
            txtRW3.Text = ("0");
            txtRW3.Visible = false;
            pBRW3.Visible = false;

            txtBW1.Text = ("0");
            pBBW1.Visible = false;
            txtBW1.Visible = false;
            txtBX1.Text = ("0");
            pBBX1.Visible = false;
            txtBX1.Visible = false;
            txtB81.Text = ("0");
            txtB81.Visible = false;
            pBB81.Visible = false;
            txtBE1.Text = ("0");
            txtBE1.Visible = false;
            pBBE1.Visible = false;
            txtBE2.Text = ("0");
            txtBE2.Visible = false;
            pBBE2.Visible = false;
            txtBE3.Text = ("0");
            txtBE3.Visible = false;
            pBBE3.Visible = false;
            txtB81.Text = ("0");
            txtB81.Visible = false;
            pBB81.Visible = false;
            txtBX2.Text = ("0");
            txtBX2.Visible = false;
            pBBX2.Visible = false;
            txtBX3.Text = ("0");
            txtBX3.Visible = false;
            pBBX3.Visible = false;
            txtB82.Text = ("0");
            txtB82.Visible = false;
            pBB82.Visible = false;
            txtB83.Text = ("0");
            txtB83.Visible = false;
            pBB83.Visible = false;
            txtBW2.Text = ("0");
            txtBW2.Visible = false;
            pBBW2.Visible = false;
            txtBW3.Text = ("0");
            txtBW3.Visible = false;
            pBBW3.Visible = false;


        }

        private void btnRW1_Click(object sender, EventArgs e)
        {


            if (txtRW1.Text == "8")
            {
                txtRW1.Text = "9";

            }
            if (txtRW1.Text == "7")
            {
                txtRW1.Text = "8";

            }
            if (txtRW1.Text == "6")
            {
                txtRW1.Text = "7";

            }
            if (txtRW1.Text == "5")
            {
                txtRW1.Text = "6";

            }
            if (txtRW1.Text == "4")
            {
                txtRW1.Text = "5";

            }
            if (txtRW1.Text == "3")
            {
                txtRW1.Text = "4";

            }
            if (txtRW1.Text == "2")
            {
                txtRW1.Text = "3";

            }
            if (txtRW1.Text == "1")
            {
                txtRW1.Text = "2";

            }
            
            if (txtRW1.Text == "0" )
            {
                txtRW1.Text= "1";
                
            }

            txtRW1.Visible = true;
            pBRW1.Visible = true;

            

            //txtRW1.Text = ("1") + Text;


            //else secondss.Text = "0" + secs.ToString();
        }

        private void btnRX1_Click(object sender, EventArgs e)
        {
            if (txtRX1.Text == "2")
            {
                txtRX1.Text = "3";
                wmp.URL = "2.mp3";
                wmp.controls.play();
                MessageBox.Show("حصول اللاعب على ثلاث انذارات الركن الازرق الفائز بالمباراة", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            if (txtRX1.Text == "1")
            {
                txtRX1.Text = "2";

            }

            if (txtRX1.Text == "0")
            {
                txtRX1.Text = "1";

            }
            txtRX1.Visible = true;
            pBRX1.Visible = true;
        }

        private void btnR81_Click(object sender, EventArgs e)
        {
           
            if (txtR81.Text == "1")
            {
                txtR81.Text = "2";
                
                wmp.URL = "2.mp3";
                wmp.controls.play();
                MessageBox.Show("العد مرتين الجولة لصالح الركن الازرق", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (txtR81.Text == "0")
            {
                txtR81.Text = "1";

            }
            txtR81.Visible = true;
            pBR81.Visible = true;
        }

        private void btnRE1_Click(object sender, EventArgs e)
        {
            if (txtRE1.Text == "1")
            {
                txtRE1.Text = "2";

                wmp.URL = "2.mp3";
                wmp.controls.play();
                MessageBox.Show("خروج مرتين الجولة لصالح الركن الازرق", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (txtRE1.Text == "0")
            {
                txtRE1.Text = "1";

            }
            txtRE1.Visible = true;
            pBRE1.Visible = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStop.Show();
            btnStart.Hide();
            btnStart.BackColor = Color.Red;
            btnStop.BackColor = Color.Green;
            sw.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Show();
            btnStop.Hide();
            btnStop.BackColor = Color.Red;
            btnStart.BackColor = Color.Green;
            sw.Stop();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnStart.Show();
            btnStop.BackColor = Color.Red;
            btnStart.BackColor = Color.Green;
            sw.Reset();
        }

        private void timeStopWatch_Tick(object sender, EventArgs e)
        {
            //long h = sw.Elapsed.Hours;
            long m = sw.Elapsed.Minutes;
            long s = sw.Elapsed.Seconds;
            long t = sw.Elapsed.Ticks;
            long d = sw.Elapsed.Days;

            //string strH = (h < 10) ? "0" + h : h + "";
            string strM = (m < 10) ? "0" + m : m + "";
            string strS = (s < 10) ? "0" + s : s + "";
            //string strT = (cbxTicks.Checked) ? t + "." : "";
            //string strD = (cbxDays.Checked) ? "Days: " + d + " > " : "";

            string allTime =  strM + ":" + strS ;

            lblTime.Text = allTime;

        }

        private void btnStop_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnRE2_Click(object sender, EventArgs e)
        {
            if (txtRE2.Text == "1")
            {
                txtRE2.Text = "2";

                wmp.URL = "2.mp3";
                wmp.controls.play();
                MessageBox.Show("خروج مرتين الجولة لصالح الركن الازرق", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (txtRE2.Text == "0")
            {
                txtRE2.Text = "1";

            }
            txtRE2.Visible = true;
            pBRE2.Visible = true;
        }

        private void btnRE3_Click(object sender, EventArgs e)
        {
            if (txtRE3.Text == "1")
            {
                txtRE3.Text = "2";

                wmp.URL = "2.mp3";
                wmp.controls.play();
                MessageBox.Show("خروج مرتين الجولة لصالح الركن الازرق", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (txtRE3.Text == "0")
            {
                txtRE3.Text = "1";

            }
            txtRE3.Visible = true;
            pBRE3.Visible = true;
        }

        private void btnR82_Click(object sender, EventArgs e)
        {
            if (txtR82.Text == "1")
            {
                txtR82.Text = "2";

                wmp.URL = "2.mp3";
                wmp.controls.play();
                MessageBox.Show("العد مرتين الجولة لصالح الركن الازرق", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (txtR82.Text == "0")
            {
                txtR82.Text = "1";

            }
            txtR82.Visible = true;
            pBR82.Visible = true;
        }

        private void btnR83_Click(object sender, EventArgs e)
        {
            if (txtR83.Text == "1")
            {
                txtR83.Text = "2";

                wmp.URL = "2.mp3";
                wmp.controls.play();
                MessageBox.Show("العد مرتين الجولة لصالح الركن الازرق", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (txtR83.Text == "0")
            {
                txtR83.Text = "1";

            }
            txtR83.Visible = true;
            pBR83.Visible = true;
        }

        private void btnRX2_Click(object sender, EventArgs e)
        {
            if (txtRX2.Text == "2")
            {
                txtRX2.Text = "3";
                wmp.URL = "2.mp3";
                wmp.controls.play();
                MessageBox.Show("حصول اللاعب على ثلاث انذارات الركن الازرق الفائز بالمباراة", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (txtRX2.Text == "1")
            {
                txtRX2.Text = "2";

            }

            if (txtRX2.Text == "0")
            {
                txtRX2.Text = "1";

            }
            txtRX2.Visible = true;
            pBRX2.Visible = true;
        }

        private void btnRX3_Click(object sender, EventArgs e)
        {
            if (txtRX3.Text == "2")
            {
                txtRX3.Text = "3";
                wmp.URL = "2.mp3";
                wmp.controls.play();
                MessageBox.Show("حصول اللاعب على ثلاث انذارات الركن الازرق الفائز بالمباراة", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (txtRX3.Text == "1")
            {
                txtRX3.Text = "2";

            }

            if (txtRX3.Text == "0")
            {
                txtRX3.Text = "1";

            }
            txtRX3.Visible = true;
            pBRX3.Visible = true;
        }

        private void btnRW2_Click(object sender, EventArgs e)
        {
           
            if (txtRW2.Text == "8")
            {
                txtRW2.Text = "9";

            }
            if (txtRW2.Text == "7")
            {
                txtRW2.Text = "8";

            }
            if (txtRW2.Text == "6")
            {
                txtRW2.Text = "7";

            }
            if (txtRW2.Text == "5")
            {
                txtRW2.Text = "6";

            }
            if (txtRW2.Text == "4")
            {
                txtRW2.Text = "5";

            }
            if (txtRW2.Text == "3")
            {
                txtRW2.Text = "4";

            }
            if (txtRW2.Text == "2")
            {
                txtRW2.Text = "3";

            }
            if (txtRW2.Text == "1")
            {
                txtRW2.Text = "2";

            }

            if (txtRW2.Text == "0")
            {
                txtRW2.Text = "1";

            }
            txtRW2.Visible = true;
            pBRW2.Visible = true;
        }

        private void btnRW3_Click(object sender, EventArgs e)
        {
           
            if (txtRW3.Text == "8")
            {
                txtRW3.Text = "9";

            }
            if (txtRW3.Text == "7")
            {
                txtRW3.Text = "8";

            }
            if (txtRW3.Text == "6")
            {
                txtRW3.Text = "7";

            }
            if (txtRW3.Text == "5")
            {
                txtRW3.Text = "6";

            }
            if (txtRW3.Text == "4")
            {
                txtRW3.Text = "5";

            }
            if (txtRW3.Text == "3")
            {
                txtRW3.Text = "4";

            }
            if (txtRW3.Text == "2")
            {
                txtRW3.Text = "3";

            }
            if (txtRW3.Text == "1")
            {
                txtRW3.Text = "2";

            }

            if (txtRW3.Text == "0")
            {
                txtRW3.Text = "1";

            }
            txtRW3.Visible = true;
            pBRW3.Visible = true;
        }

        private void btnBW1_Click(object sender, EventArgs e)
        {

            if (txtBW1.Text == "8")
            {
                txtBW1.Text = "9";

            }
            if (txtBW1.Text == "7")
            {
                txtBW1.Text = "8";

            }
            if (txtBW1.Text == "6")
            {
                txtBW1.Text = "7";

            }
            if (txtBW1.Text == "5")
            {
                txtBW1.Text = "6";

            }
            if (txtBW1.Text == "4")
            {
                txtBW1.Text = "5";

            }
            if (txtBW1.Text == "3")
            {
                txtBW1.Text = "4";

            }
            if (txtBW1.Text == "2")
            {
                txtBW1.Text = "3";

            }
            if (txtBW1.Text == "1")
            {
                txtBW1.Text = "2";

            }

            if (txtBW1.Text == "0")
            {
                txtBW1.Text = "1";

            }
            txtBW1.Visible = true;
            pBBW1.Visible = true;
        }

        private void btnBW2_Click(object sender, EventArgs e)
        {

            if (txtBW2.Text == "8")
            {
                txtBW2.Text = "9";

            }
            if (txtBW2.Text == "7")
            {
                txtBW2.Text = "8";

            }
            if (txtBW2.Text == "6")
            {
                txtBW2.Text = "7";

            }
            if (txtBW2.Text == "5")
            {
                txtBW2.Text = "6";

            }
            if (txtBW2.Text == "4")
            {
                txtBW2.Text = "5";

            }
            if (txtBW2.Text == "3")
            {
                txtBW2.Text = "4";

            }
            if (txtBW2.Text == "2")
            {
                txtBW2.Text = "3";

            }
            if (txtBW2.Text == "1")
            {
                txtBW2.Text = "2";

            }

            if (txtBW2.Text == "0")
            {
                txtBW2.Text = "1";

            }
            txtBW2.Visible = true;
            pBBW2.Visible = true;
        }

        private void btnBW3_Click(object sender, EventArgs e)
        {

            if (txtBW3.Text == "8")
            {
                txtBW3.Text = "9";

            }
            if (txtBW3.Text == "7")
            {
                txtBW3.Text = "8";

            }
            if (txtBW3.Text == "6")
            {
                txtBW3.Text = "7";

            }
            if (txtBW3.Text == "5")
            {
                txtBW3.Text = "6";

            }
            if (txtBW3.Text == "4")
            {
                txtBW3.Text = "5";

            }
            if (txtBW3.Text == "3")
            {
                txtBW3.Text = "4";

            }
            if (txtBW3.Text == "2")
            {
                txtBW3.Text = "3";

            }
            if (txtBW3.Text == "1")
            {
                txtBW3.Text = "2";

            }

            if (txtBW3.Text == "0")
            {
                txtBW3.Text = "1";

            }
            txtBW3.Visible = true;
            pBBW3.Visible = true;
        }

        private void btnBX1_Click(object sender, EventArgs e)
        {
            if (txtBX1.Text == "2")
            {
                txtBX1.Text = "3";
                wmp.URL = "2.mp3";
                wmp.controls.play();
                MessageBox.Show("حصول اللاعب على ثلاث انذارات الركن الاحمر الفائز بالمباراة", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (txtBX1.Text == "1")
            {
                txtBX1.Text = "2";

            }

            if (txtBX1.Text == "0")
            {
                txtBX1.Text = "1";

            }
            txtBX1.Visible = true;
            pBBX1.Visible = true;
        }

        private void btnBX2_Click(object sender, EventArgs e)
        {
            if (txtBX2.Text == "2")
            {
                txtBX2.Text = "3";
                wmp.URL = "2.mp3";
                wmp.controls.play();
                MessageBox.Show("حصول اللاعب على ثلاث انذارات الركن الاحمر الفائز بالمباراة", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (txtBX2.Text == "1")
            {
                txtBX2.Text = "2";

            }

            if (txtBX2.Text == "0")
            {
                txtBX2.Text = "1";

            }
            txtBX2.Visible = true;
            pBBX2.Visible = true;
        }

        private void btnBX3_Click(object sender, EventArgs e)
        {
            if (txtBX3.Text == "2")
            {
                txtBX3.Text = "3";
                wmp.URL = "2.mp3";
                wmp.controls.play();
                MessageBox.Show("حصول اللاعب على ثلاث انذارات الركن الاحمر الفائز بالمباراة", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (txtBX3.Text == "1")
            {
                txtBX3.Text = "2";

            }

            if (txtBX3.Text == "0")
            {
                txtBX3.Text = "1";

            }
            txtBX3.Visible = true;
            pBBX3.Visible = true;
        }

        private void btnB81_Click(object sender, EventArgs e)
        {
            if (txtB81.Text == "1")
            {
                txtB81.Text = "2";

                wmp.URL = "2.mp3";
                wmp.controls.play();
                MessageBox.Show("العد مرتين الجولة لصالح الركن الاحمر", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (txtB81.Text == "0")
            {
                txtB81.Text = "1";

            }
            txtB81.Visible = true;
            pBB81.Visible = true;
        }

        private void btnB82_Click(object sender, EventArgs e)
        {
            if (txtB82.Text == "1")
            {
                txtB82.Text = "2";

                wmp.URL = "2.mp3";
                wmp.controls.play();
                MessageBox.Show("العد مرتين الجولة لصالح الركن الاحمر", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (txtB82.Text == "0")
            {
                txtB82.Text = "1";

            }
            txtB82.Visible = true;
            pBB82.Visible = true;
        }

        private void btnB83_Click(object sender, EventArgs e)
        {
            if (txtB83.Text == "1")
            {
                txtB83.Text = "2";

                wmp.URL = "2.mp3";
                wmp.controls.play();
                MessageBox.Show("العد مرتين الجولة لصالح الركن الاحمر", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (txtB83.Text == "0")
            {
                txtB83.Text = "1";

            }
            txtB83.Visible = true;
            pBB83.Visible = true;
        }

        private void btnBE1_Click(object sender, EventArgs e)
        {
            if (txtBE1.Text == "1")
            {
                txtBE1.Text = "2";

                wmp.URL = "2.mp3";
                wmp.controls.play();
                MessageBox.Show("خروج مرتين الجولة لصالح الركن الاحمر", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (txtBE1.Text == "0")
            {
                txtBE1.Text = "1";

            }
            txtBE1.Visible = true;
            pBBE1.Visible = true;
        }

        private void btnBE2_Click(object sender, EventArgs e)
        {
            if (txtBE2.Text == "1")
            {
                txtBE2.Text = "2";

                wmp.URL = "2.mp3";
                wmp.controls.play();
                MessageBox.Show("خروج مرتين الجولة لصالح الركن الاحمر", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (txtBE2.Text == "0")
            {
                txtBE2.Text = "1";

            }
            txtBE2.Visible = true;
            pBBE2.Visible = true;
        }

        private void btnBE3_Click(object sender, EventArgs e)
        {
            if (txtBE3.Text == "1")
            {
                txtBE3.Text = "2";

                wmp.URL = "2.mp3";
                wmp.controls.play();
                
                MessageBox.Show("خروج مرتين الجولة لصالح الركن الاحمر", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (txtBE3.Text == "0")
            {
                txtBE3.Text = "1";

            }
            txtBE3.Visible = true;
            pBBE3.Visible = true;
        }

        private void btnStop1_Click(object sender, EventArgs e)
        {
            btnContinue.Show();
            btnStop1.Hide();
            btnStop1.BackColor = Color.Red;
            btnContinue.BackColor = Color.Green;
            stopwatch.Enabled = false;

           
           
            wmp.controls.pause();
            
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            btnStart1.Show();
            btnPause.Hide();
            btnStop1.Hide();
            btnContinue.Hide();
            btnStop1.BackColor = Color.Red;
            btnContinue.BackColor = Color.Green;
            btnStart1.BackColor = Color.Green;
            stopwatch.Stop();

            numericUpDownHrs.Enabled = true;
            numericUpDownMin.Enabled = true;
            numericUpDownSecon.Enabled = true;

            hourss.Text = "00";
            minutess.Text = "00";
            secondss.Text = "00";


         
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            btnStop1.Show();
            btnContinue.Hide();
            btnContinue.BackColor = Color.Red;
            btnStop1.BackColor = Color.Green;
            
            if (Convert.ToInt32 ( secondss.Text ) <= 10 && minutess.Text== "00")
            {
                wmp.controls.play();
            }
            stopwatch.Enabled = true;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnStart1.PerformClick();
        }

        WMPLib.WindowsMediaPlayer wmp = new WMPLib.WindowsMediaPlayer();
        private int value;

        private void btnOpenE_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection conn1 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=task.xlsx;Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1;MAXSCANROWS=0'");
                OleDbCommand cmdd = new OleDbCommand("select * from [sheet1$]", conn1);
                //cmdd.CommandText = "select * from [sheet1$] where name<=5";
                cmdd.CommandText = "select * from [sheet1$]";
                DataTable tbl = new DataTable();

                //lbl.Text = DateTime.Now.ToString("hh:mm:ss:" + DateTime.Now.Ticks);
                //lbl.Text = DateTime.Now.ToString("select * from [sheet1$] where name<=5");

                conn1.Open();
                tbl.Load(cmdd.ExecuteReader());
                conn1.Close();
                dgv.DataSource = tbl;


                if (dgv.CurrentRow != null)
                {

                    lblR.Text = dgv.CurrentRow.Cells[0].Value.ToString();
                    txtNR.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                    txtCR.Text = dgv.CurrentRow.Cells[2].Value.ToString();
                    txtNB.Text = dgv.CurrentRow.Cells[3].Value.ToString();
                    txtCB.Text = dgv.CurrentRow.Cells[4].Value.ToString();
                    lblWeigh.Text = dgv.CurrentRow.Cells[5].Value.ToString();
                }
                //MessageBox.Show(tbl.Columns[0].ColumnName);
                //lbl.Text += "\n" + DateTime.Now.ToString("hh:mm:ss." + DateTime.Now.Ticks);
            }
            catch
            {

            }
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                
                lblR.Text = dgv.CurrentRow.Cells[0].Value.ToString();
                txtNR.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                txtCR.Text = dgv.CurrentRow.Cells[2].Value.ToString();
                txtNB.Text = dgv.CurrentRow.Cells[3].Value.ToString();
                txtCB.Text = dgv.CurrentRow.Cells[4].Value.ToString();
                lblWeigh.Text = dgv.CurrentRow.Cells[5].Value.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                OleDbConnection conn0 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=task2.xlsx;Extended Properties='Excel 12.0 Xml;HDR=YES'");
                OleDbCommand cmd0 = new OleDbCommand("select * from [sheet1$]", conn0);

                string cmdText;
                cmdText = "insert into [sheet1$] ([ID],[name],[club],[result],[Weigh]) values('" + lblR.Text + "','" + txtNR.Text + "','" + txtCR.Text + "','" + Red.Text + "','" + lblWeigh.Text + "')";
                cmd0.CommandText = cmdText;
                conn0.Open();
                cmd0.ExecuteNonQuery();
                conn0.Close();



            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-09D9S02;Initial Catalog=Product_DB;Persist Security Info=True;User ID=admin1;Password=123");

                SqlCommand cmd = new SqlCommand();


                cmd.Connection = conn;
                if (lblWeigh.Text == "40")
                {
                    cmd.CommandText = "insert into Result40 Values (" + lblR.Text + ",'" + txtNR.Text + "','" + txtCR.Text + "','" + btnSave.Text + "','" + lblWeigh.Text + "')";
                }

                if (lblWeigh.Text == "48")
                {
                    cmd.CommandText = "insert into Result48 Values (" + lblR.Text + ",'" + txtNR.Text + "','" + txtCR.Text + "','" + btnSave.Text + "','" + lblWeigh.Text + "')";
                }
                if (lblWeigh.Text == "52")
                {
                    cmd.CommandText = "insert into Result52 Values (" + lblR.Text + ",'" + txtNR.Text + "','" + txtCR.Text + "','" + btnSave.Text + "','" + lblWeigh.Text + "')";
                }

                if (lblWeigh.Text == "56")
                {
                    cmd.CommandText = "insert into Result56 Values (" + lblR.Text + ",'" + txtNR.Text + "','" + txtCR.Text + "','" + btnSave.Text + "','" + lblWeigh.Text + "')";
                }
                if (lblWeigh.Text == "60")
                {
                    cmd.CommandText = "insert into Result60 Values (" + lblR.Text + ",'" + txtNR.Text + "','" + txtCR.Text + "','" + btnSave.Text + "','" + lblWeigh.Text + "')";
                }

                if (lblWeigh.Text == "65")
                {
                    cmd.CommandText = "insert into Result65 Values (" + lblR.Text + ",'" + txtNR.Text + "','" + txtCR.Text + "','" + btnSave.Text + "','" + lblWeigh.Text + "')";
                }
                if (lblWeigh.Text == "70")
                {
                    cmd.CommandText = "insert into Result70 Values (" + lblR.Text + ",'" + txtNR.Text + "','" + txtCR.Text + "','" + btnSave.Text + "','" + lblWeigh.Text + "')";
                }

                if (lblWeigh.Text == "75")
                {
                    cmd.CommandText = "insert into Result75 Values (" + lblR.Text + ",'" + txtNR.Text + "','" + txtCR.Text + "','" + btnSave.Text + "','" + lblWeigh.Text + "')";
                }
                if (lblWeigh.Text == "80")
                {
                    cmd.CommandText = "insert into Result80 Values (" + lblR.Text + ",'" + txtNR.Text + "','" + txtCR.Text + "','" + btnSave.Text + "','" + lblWeigh.Text + "')";
                }

                if (lblWeigh.Text == "85")
                {
                    cmd.CommandText = "insert into Result85 Values (" + lblR.Text + ",'" + txtNR.Text + "','" + txtCR.Text + "','" + btnSave.Text + "','" + lblWeigh.Text + "')";
                }
                if (lblWeigh.Text == "90")
                {
                    cmd.CommandText = "insert into Result90 Values (" + lblR.Text + ",'" + txtNR.Text + "','" + txtCR.Text + "','" + btnSave.Text + "','" + lblWeigh.Text + "')";
                }

                if (lblWeigh.Text == "95")
                {
                    cmd.CommandText = "insert into Result95 Values (" + lblR.Text + ",'" + txtNR.Text + "','" + txtCR.Text + "','" + btnSave.Text + "','" + lblWeigh.Text + "')";
                }
                if (lblWeigh.Text == "95B")
                {
                    cmd.CommandText = "insert into Result95B Values (" + lblR.Text + ",'" + txtNR.Text + "','" + txtCR.Text + "','" + btnSave.Text + "','" + lblWeigh.Text + "')";
                }


                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("((  شكراً على التسجيل * من فضلك غير المباراة التالية))", "Information ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            try
            {

                OleDbConnection conn0 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=task2.xlsx;Extended Properties='Excel 12.0 Xml;HDR=YES'");
                OleDbCommand cmd0 = new OleDbCommand("select * from [sheet1$]", conn0);

                string cmdText;
                cmdText = "insert into [sheet1$] ([ID],[name],[club],[Result],[Weigh]) values('" + lblR.Text + "','" + txtNB.Text + "','" + txtCB.Text + "','" + Blue.Text + "','" + lblWeigh.Text + "')";
                cmd0.CommandText = cmdText;
                conn0.Open();
                cmd0.ExecuteNonQuery();
                conn0.Close();

                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-09D9S02;Initial Catalog=Product_DB;Persist Security Info=True;User ID=admin1;Password=123");

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                if (lblWeigh.Text == "40")
                {
                    cmd.CommandText = "insert into Result40 Values (" + lblR.Text + ",'" + txtNB.Text + "','" + txtCB.Text + "','" + btnSave2.Text + "','" + lblWeigh.Text + "')";
                }

                if (lblWeigh.Text == "48")
                {
                    cmd.CommandText = "insert into Result48 Values (" + lblR.Text + ",'" + txtNB.Text + "','" + txtCB.Text + "','" + btnSave2.Text + "','" + lblWeigh.Text + "')";
                }
                if (lblWeigh.Text == "52")
                {
                    cmd.CommandText = "insert into Result52 Values (" + lblR.Text + ",'" + txtNB.Text + "','" + txtCB.Text + "','" + btnSave2.Text + "','" + lblWeigh.Text + "')";
                }

                if (lblWeigh.Text == "56")
                {
                    cmd.CommandText = "insert into Result56 Values (" + lblR.Text + ",'" + txtNB.Text + "','" + txtCB.Text + "','" + btnSave2.Text + "','" + lblWeigh.Text + "')";
                }
                if (lblWeigh.Text == "60")
                {
                    cmd.CommandText = "insert into Result60 Values (" + lblR.Text + ",'" + txtNB.Text + "','" + txtCB.Text + "','" + btnSave2.Text + "','" + lblWeigh.Text + "')";
                }

                if (lblWeigh.Text == "65")
                {
                    cmd.CommandText = "insert into Result65 Values (" + lblR.Text + ",'" + txtNB.Text + "','" + txtCB.Text + "','" + btnSave2.Text + "','" + lblWeigh.Text + "')";
                }
                if (lblWeigh.Text == "70")
                {
                    cmd.CommandText = "insert into Result70 Values (" + lblR.Text + ",'" + txtNB.Text + "','" + txtCB.Text + "','" + btnSave2.Text + "','" + lblWeigh.Text + "')";
                }

                if (lblWeigh.Text == "75")
                {
                    cmd.CommandText = "insert into Result75 Values (" + lblR.Text + ",'" + txtNB.Text + "','" + txtCB.Text + "','" + btnSave2.Text + "','" + lblWeigh.Text + "')";
                }
                if (lblWeigh.Text == "80")
                {
                    cmd.CommandText = "insert into Result80 Values (" + lblR.Text + ",'" + txtNB.Text + "','" + txtCB.Text + "','" + btnSave2.Text + "','" + lblWeigh.Text + "')";
                }

                if (lblWeigh.Text == "85")
                {
                    cmd.CommandText = "insert into Result85 Values (" + lblR.Text + ",'" + txtNB.Text + "','" + txtCB.Text + "','" + btnSave2.Text + "','" + lblWeigh.Text + "')";
                }
                if (lblWeigh.Text == "90")
                {
                    cmd.CommandText = "insert into Result90 Values (" + lblR.Text + ",'" + txtNB.Text + "','" + txtCB.Text + "','" + btnSave2.Text + "','" + lblWeigh.Text + "')";
                }

                if (lblWeigh.Text == "95")
                {
                    cmd.CommandText = "insert into Result95 Values (" + lblR.Text + ",'" + txtNB.Text + "','" + txtCB.Text + "','" + btnSave2.Text + "','" + lblWeigh.Text + "')";
                }
                if (lblWeigh.Text == "95B")
                {
                     cmd.CommandText = "insert into Result95B Values (" + lblR.Text + ",'" + txtNB.Text + "','" + txtCB.Text + "','" + btnSave2.Text + "','" + lblWeigh.Text + "')";
                }
               
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("((  شكراً على التسجيل * من فضلك غير المباراة التالية))", "Information ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void label16_Click(object sender, EventArgs e)
        {
            txtRW1.Text = ("0");
            pBRW1.Visible = false;
            txtRW1.Visible = false;
            txtRW2.Text = ("0");
            pBRW2.Visible = false;
            txtRW2.Visible = false;
            txtRW3.Text = ("0");
            pBRW3.Visible = false;
            txtRW3.Visible = false;
        }

        private void label15_Click(object sender, EventArgs e)
        {
            txtRX1.Text = ("0");
            pBRX1.Visible = false;
            txtRX1.Visible = false;
            txtRX2.Text = ("0");
            pBRX2.Visible = false;
            txtRX2.Visible = false;
            txtRX3.Text = ("0");
            pBRX3.Visible = false;
            txtRX3.Visible = false;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            txtR81.Text = ("0");
            pBR81.Visible = false;
            txtR81.Visible = false;
            txtR82.Text = ("0");
            pBR82.Visible = false;
            txtR82.Visible = false;
            txtR83.Text = ("0");
            pBR83.Visible = false;
            txtR83.Visible = false;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            txtRE1.Text = ("0");
            txtRE1.Visible = false;
            pBRE1.Visible = false;
            txtRE2.Text = ("0");
            txtRE2.Visible = false;
            pBRE2.Visible = false;
            txtRE3.Text = ("0");
            txtRE3.Visible = false;
            pBRE3.Visible = false;
        }

        private void label17_Click(object sender, EventArgs e)
        {
            txtBW1.Text = ("0");
            pBBW1.Visible = false;
            txtBW1.Visible = false;
            txtBW2.Text = ("0");
            pBBW2.Visible = false;
            txtBW2.Visible = false;
            txtBW3.Text = ("0");
            pBBW3.Visible = false;
            txtBW3.Visible = false;
        }

        private void label18_Click(object sender, EventArgs e)
        {
            txtBX1.Text = ("0");
            pBBX1.Visible = false;
            txtBX1.Visible = false;
            txtBX2.Text = ("0");
            pBBX2.Visible = false;
            txtBX2.Visible = false;
            txtBX3.Text = ("0");
            pBBX3.Visible = false;
            txtBX3.Visible = false;
        }

        private void label19_Click(object sender, EventArgs e)
        {
            txtB81.Text = ("0");
            pBB81.Visible = false;
            txtB81.Visible = false;
            txtB82.Text = ("0");
            pBB82.Visible = false;
            txtB82.Visible = false;
            txtB83.Text = ("0");
            pBB83.Visible = false;
            txtB83.Visible = false;
        }

        private void label20_Click(object sender, EventArgs e)
        {
            txtBE1.Text = ("0");
            txtBE1.Visible = false;
            pBBE1.Visible = false;
            txtBE2.Text = ("0");
            txtBE2.Visible = false;
            pBBE2.Visible = false;
            txtBE3.Text = ("0");
            txtBE3.Visible = false;
            pBBE3.Visible = false;
        }

        private void label23_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label26_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-09D9S02;Initial Catalog=Product_DB;Persist Security Info=True;User ID=admin1;Password=123");
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandText = "Delete from Judge1";
                //cmd.CommandText = "Delete from Judge2";
                conn.Open();
                cmd.ExecuteNonQuery();
                //MessageBox.Show("مسح");
                conn.Close();
            }
            catch (SqlException )
            {
                //MessageBox.Show("Error");
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {
        }

        private void stopwatch_Tick(object sender, EventArgs e)
        {
            if (hours == 0 && min == 0 && secs == 0)
            {
                stopwatch.Stop();
                wmp.URL = "1.mp3";
                wmp.controls.stop();

                //wmp.URL = "2.mp3";
                //wmp.controls.play();

                btnStop1.Hide();
                btnPause.Hide();
                btnStart1.Show();
                btnContinue.Hide();
                btnStart1.BackColor = Color.Green;

                //MessageBox.Show("countdown Ended", "seesharp");
                numericUpDownHrs.Enabled = true;
                numericUpDownMin.Enabled = true;
                numericUpDownSecon.Enabled = true;
                btnStart1.Enabled = true;

                hourss.Text = "00";
                minutess.Text = "00";
                secondss.Text = ":00";

                numericUpDownHrs.Text = "00";
                numericUpDownMin.Text = "02";
                numericUpDownSecon.Text = "00";




            }
            else
            {
                if (secs < 1)
                {
                    secs = 59;
                    if (min < 1)
                    {
                        min = 59;
                        if (hours != 0)
                            hours--;


                    }
                    else min -= 1;

                }
                else secs -= 1;
            }
            if (hours > 9)
                hourss.Text = hours.ToString();
            else hourss.Text = "0" + hours.ToString();
            if (min > 9)
                minutess.Text = min.ToString();
            else minutess.Text = "0" + min.ToString();
            if (secs > 9)
                secondss.Text = secs.ToString();
            else secondss.Text = "0" + secs.ToString();

            if (hours == 0 && min == 0 && secs == 10)
            {
                wmp.URL = "1.mp3";
                wmp.controls.play();
            }
            if (hours == 0 && min == 0 && secs == 1)
            {
                wmp.URL = "2.mp3";
                wmp.controls.play();
            }


        }

        private void btnStart1_Click(object sender, EventArgs e)
        {
            btnStop1.Show();
            btnPause.Show();
            btnStart1.Hide();
            btnContinue.Hide();
            btnStart1.BackColor = Color.Red;
            btnStop1.BackColor = Color.Green;

            hours = int.Parse(numericUpDownHrs.Text);
            min = int.Parse(numericUpDownMin.Text);
            secs = int.Parse(numericUpDownSecon.Text);
            numericUpDownHrs.Enabled = false;
            numericUpDownMin.Enabled = false;
            numericUpDownSecon.Enabled = false;
            btnStart1.Enabled = true;

            stopwatch.Start();
        }
    }
}
