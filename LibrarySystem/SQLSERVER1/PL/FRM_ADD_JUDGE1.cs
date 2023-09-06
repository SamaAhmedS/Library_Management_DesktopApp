using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace SQLSERVER1
{
    public partial class FRM_JUDGE1 : Form
    {
        BL.CLS_PRODUCTS prd = new BL.CLS_PRODUCTS();
        private object txtBJ1;

        public object pbox { get; private set; }


        public FRM_JUDGE1()
        {
            InitializeComponent();
        }


        private void lblRJ1_ControlAdded(object sender, ControlEventArgs e)
        {
        }
        private void lblRJ1_Click(object sender, EventArgs e)
        {
        }
        private void FRM_JUDGE1_KeyUp(object sender, KeyEventArgs e)
        {
        }
        private void FRM_JUDGE1_MouseClick(object sender, MouseEventArgs e)
        {
        }
        private void FRM_JUDGE1_MouseUp(object sender, MouseEventArgs e)
        {
        }
        private void FRM_JUDGE1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lblRJ1.Text == "8")
            {
                lblRJ1.Text = "9";

            }
            if (lblRJ1.Text == "7")
            {
                lblRJ1.Text = "8";

            }
            if (lblRJ1.Text == "6")
            {
                lblRJ1.Text = "7";

            }
            if (lblRJ1.Text == "5")
            {
                lblRJ1.Text = "6";

            }
            if (lblRJ1.Text == "4")
            {
                lblRJ1.Text = "5";

            }
            if (lblRJ1.Text == "3")
            {
                lblRJ1.Text = "4";

            }
            if (lblRJ1.Text == "2")
            {
                lblRJ1.Text = "3";

            }
            if (lblRJ1.Text == "1")
            {
                lblRJ1.Text = "2";

            }

            if (lblRJ1.Text == "0")
            {
                lblRJ1.Text = "1";

            }
        }

        private void FRM_JUDGE1_MouseCaptureChanged(object sender, EventArgs e)
        {
            //if (lblBJ1.Text == "8")
            //{
            //    lblBJ1.Text = "9";

            //}
            //if (lblBJ1.Text == "7")
            //{
            //    lblBJ1.Text = "8";

            //}
            //if (lblBJ1.Text == "6")
            //{
            //    lblBJ1.Text = "7";

            //}
            //if (lblBJ1.Text == "5")
            //{
            //    lblBJ1.Text = "6";

            //}
            //if (lblBJ1.Text == "4")
            //{
            //    lblBJ1.Text = "5";

            //}
            //if (lblBJ1.Text == "3")
            //{
            //    lblBJ1.Text = "4";

            //}
            //if (lblBJ1.Text == "2")
            //{
            //    lblBJ1.Text = "3";

            //}
            //if (lblBJ1.Text == "1")
            //{
            //    lblBJ1.Text = "2";

            //}

            //if (lblBJ1.Text == "0")
            //{
            //    lblBJ1.Text = "1";

            //}
        }


        private void FRM_JUDGE1_ImeModeChanged(object sender, EventArgs e)
        {
            if (lblBJ1.Text == "8")
            {
                lblBJ1.Text = "9";

            }
            if (lblBJ1.Text == "7")
            {
                lblBJ1.Text = "8";

            }
            if (lblBJ1.Text == "6")
            {
                lblBJ1.Text = "7";

            }
            if (lblBJ1.Text == "5")
            {
                lblBJ1.Text = "6";

            }
            if (lblBJ1.Text == "4")
            {
                lblBJ1.Text = "5";

            }
            if (lblBJ1.Text == "3")
            {
                lblBJ1.Text = "4";

            }
            if (lblBJ1.Text == "2")
            {
                lblBJ1.Text = "3";

            }
            if (lblBJ1.Text == "1")
            {
                lblBJ1.Text = "2";

            }

            if (lblBJ1.Text == "0")
            {
                lblBJ1.Text = "1";

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            //pb.Image.Save(ms, pb.Image.RawFormat);
            //byte[] byteImage = ms.ToArray();
            //prd.ADD_JUDGE1(Convert.ToInt32(txtBJ1.Label));
    //        prd.ADD_PRODUCT(Convert.ToInt32(cmbCategories.SelectedValue), txtDes.Text
    //, txtRef.Text, Convert.ToInt32(txtQt.Text), txtPrice.Text, byteImage);
            MessageBox.Show("عمليةالاضافة تمت بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}