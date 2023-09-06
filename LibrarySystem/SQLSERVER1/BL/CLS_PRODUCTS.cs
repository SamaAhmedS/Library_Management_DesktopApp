using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SQLSERVER1.BL
{
    class CLS_PRODUCTS
    {
        public DataTable GET_ALL_CATEGORIES()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_CATEGORIES", null);
            DAL.Close();
            return Dt;
        }

        public void ADD_PRODUCT(int ID_cat, string label_product, string ID_product,
            int Qte, string Price, byte[] img)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            param[0].Value = ID_cat;

            param[1] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar, 30);
            param[1].Value = ID_product;

            param[2] = new SqlParameter("@Labe", SqlDbType.Text);
            param[2].Value = label_product;

            param[3] = new SqlParameter("@Qte", SqlDbType.Int);
            param[3].Value = Qte;

            param[4] = new SqlParameter("@PRICE", SqlDbType.VarChar, 50);
            param[4].Value = Price;

            param[5] = new SqlParameter("@Img", SqlDbType.Image);
            param[5].Value = img;

            DAL.ExecuteCommand("ADD_PRODUCTS", param);
            DAL.Close();

        }

        public void UPDATE_PRODUCT(int ID_cat, string label_product, string ID_product,
                        int Qte, string Price, byte[] img)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            param[0].Value = ID_cat;

            param[1] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar, 30);
            param[1].Value = ID_product;

            param[2] = new SqlParameter("@Labe", SqlDbType.VarChar, 30);
            param[2].Value = label_product;

            param[3] = new SqlParameter("@Qte", SqlDbType.Int);
            param[3].Value = Qte;

            param[4] = new SqlParameter("@PRICE", SqlDbType.VarChar, 50);
            param[4].Value = Price;

            param[5] = new SqlParameter("@Img", SqlDbType.Image);
            param[5].Value = img;

            DAL.ExecuteCommand("UPDATE_PRODUCT", param);
            DAL.Close();

        }

        public DataTable VerifyProductID(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            Dt = DAL.SelectData("VerifyProductID", param);
            DAL.Close();
            return Dt;
        }

        public DataTable GET_ALL_PRODUCTS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_PRODUCTS", null);
            DAL.Close();
            return Dt;
        }

        public DataTable searchProduct(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            Dt = DAL.SelectData("searchProduct", param);
            DAL.Close();
            return Dt;
        }
        public void DeleteProduct(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar,50);
            param[0].Value = ID;

        

            DAL.ExecuteCommand("DeleteProduct", param);
            DAL.Close();

        }
        public DataTable GET_IMAGE_PRODUCT(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            Dt = DAL.SelectData("GET_IMAGE_PRODUCT", param);
            DAL.Close();
            return Dt;
        }
        public void ADD_Show40(int Number, string Club, string Name,
            decimal Result, string Weigh, byte[] img)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_CAT", SqlDbType.Decimal);
            param[0].Value = Weigh;

            param[1] = new SqlParameter("@ID_PRODUCT", SqlDbType.NVarChar, 250);
            param[1].Value = Name;

            param[2] = new SqlParameter("@Labe", SqlDbType.NVarChar, 250);
            param[2].Value = Club;

            param[3] = new SqlParameter("@Qte", SqlDbType.Decimal, 18);
            param[3].Value = Result;

            param[4] = new SqlParameter("@PRICE", SqlDbType.NVarChar, 250);
            param[4].Value = Number;

            param[5] = new SqlParameter("@Img", SqlDbType.Image);
            param[5].Value = img;

            DAL.ExecuteCommand("ADD_Show40", param);
            DAL.Close();

        }
        public void ADD_Show44(int Number, string Club, string Name,
            int Result, string Weigh, byte[] img)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            param[0].Value = Weigh;

            param[1] = new SqlParameter("@ID_PRODUCT", SqlDbType.NVarChar, 250);
            param[1].Value = Name;

            param[2] = new SqlParameter("@Labe", SqlDbType.NVarChar, 250);
            param[2].Value = Club;

            param[3] = new SqlParameter("@Qte", SqlDbType.NVarChar, 250);
            param[3].Value = Result;

            param[4] = new SqlParameter("@PRICE", SqlDbType.NVarChar, 250);
            param[4].Value = Number;

            param[5] = new SqlParameter("@Img", SqlDbType.Image);
            param[5].Value = img;

            DAL.ExecuteCommand("ADD_Show44", param);
            DAL.Close();

        }
        public void ADD_Show48(int Number, string Club, string Name,
            int Result, string Weigh, byte[] img)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            param[0].Value = Weigh;

            param[1] = new SqlParameter("@ID_PRODUCT", SqlDbType.NVarChar, 250);
            param[1].Value = Name;

            param[2] = new SqlParameter("@Labe", SqlDbType.NVarChar, 250);
            param[2].Value = Club;

            param[3] = new SqlParameter("@Qte", SqlDbType.NVarChar, 250);
            param[3].Value = Result;

            param[4] = new SqlParameter("@PRICE", SqlDbType.NVarChar, 250);
            param[4].Value = Number;

            param[5] = new SqlParameter("@Img", SqlDbType.Image);
            param[5].Value = img;

            DAL.ExecuteCommand("ADD_Show48", param);
            DAL.Close();

        }
        public void ADD_Show52(int Number, string Club, string Name,
            int Result, string Weigh, byte[] img)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            param[0].Value = Weigh;

            param[1] = new SqlParameter("@ID_PRODUCT", SqlDbType.NVarChar, 250);
            param[1].Value = Name;

            param[2] = new SqlParameter("@Labe", SqlDbType.NVarChar, 250);
            param[2].Value = Club;

            param[3] = new SqlParameter("@Qte", SqlDbType.NVarChar, 250);
            param[3].Value = Result;

            param[4] = new SqlParameter("@PRICE", SqlDbType.NVarChar, 250);
            param[4].Value = Number;

            param[5] = new SqlParameter("@Img", SqlDbType.Image);
            param[5].Value = img;

            DAL.ExecuteCommand("ADD_Show52", param);
            DAL.Close();

        }
        public void ADD_Show56(int Number, string Club, string Name,
            int Result, string Weigh, byte[] img)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            param[0].Value = Weigh;

            param[1] = new SqlParameter("@ID_PRODUCT", SqlDbType.NVarChar, 250);
            param[1].Value = Name;

            param[2] = new SqlParameter("@Labe", SqlDbType.NVarChar, 250);
            param[2].Value = Club;

            param[3] = new SqlParameter("@Qte", SqlDbType.NVarChar, 250);
            param[3].Value = Result;

            param[4] = new SqlParameter("@PRICE", SqlDbType.NVarChar, 250);
            param[4].Value = Number;

            param[5] = new SqlParameter("@Img", SqlDbType.Image);
            param[5].Value = img;

            DAL.ExecuteCommand("ADD_Show56", param);
            DAL.Close();

        }
        public void ADD_Show60(int Number, string Club, string Name,
            int Result, string Weigh, byte[] img)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            param[0].Value = Weigh;

            param[1] = new SqlParameter("@ID_PRODUCT", SqlDbType.NVarChar, 250);
            param[1].Value = Name;

            param[2] = new SqlParameter("@Labe", SqlDbType.NVarChar, 250);
            param[2].Value = Club;

            param[3] = new SqlParameter("@Qte", SqlDbType.NVarChar, 250);
            param[3].Value = Result;

            param[4] = new SqlParameter("@PRICE", SqlDbType.NVarChar, 250);
            param[4].Value = Number;

            param[5] = new SqlParameter("@Img", SqlDbType.Image);
            param[5].Value = img;

            DAL.ExecuteCommand("ADD_Show60", param);
            DAL.Close();

        }
        public void ADD_Show65(int Number, string Club, string Name,
            int Result, string Weigh, byte[] img)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            param[0].Value = Weigh;

            param[1] = new SqlParameter("@ID_PRODUCT", SqlDbType.NVarChar, 250);
            param[1].Value = Name;

            param[2] = new SqlParameter("@Labe", SqlDbType.NVarChar, 250);
            param[2].Value = Club;

            param[3] = new SqlParameter("@Qte", SqlDbType.NVarChar, 250);
            param[3].Value = Result;

            param[4] = new SqlParameter("@PRICE", SqlDbType.NVarChar, 250);
            param[4].Value = Number;

            param[5] = new SqlParameter("@Img", SqlDbType.Image);
            param[5].Value = img;

            DAL.ExecuteCommand("ADD_Show65", param);
            DAL.Close();

        }
        public void ADD_Show70(int Number, string Club, string Name,
            int Result, string Weigh, byte[] img)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            param[0].Value = Weigh;

            param[1] = new SqlParameter("@ID_PRODUCT", SqlDbType.NVarChar, 250);
            param[1].Value = Name;

            param[2] = new SqlParameter("@Labe", SqlDbType.NVarChar, 250);
            param[2].Value = Club;

            param[3] = new SqlParameter("@Qte", SqlDbType.NVarChar, 250);
            param[3].Value = Result;

            param[4] = new SqlParameter("@PRICE", SqlDbType.NVarChar, 250);
            param[4].Value = Number;

            param[5] = new SqlParameter("@Img", SqlDbType.Image);
            param[5].Value = img;

            DAL.ExecuteCommand("ADD_Show70", param);
            DAL.Close();

        }
        public void ADD_Show75(int Number, string Club, string Name,
            int Result, string Weigh, byte[] img)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            param[0].Value = Weigh;

            param[1] = new SqlParameter("@ID_PRODUCT", SqlDbType.NVarChar, 250);
            param[1].Value = Name;

            param[2] = new SqlParameter("@Labe", SqlDbType.NVarChar, 250);
            param[2].Value = Club;

            param[3] = new SqlParameter("@Qte", SqlDbType.NVarChar, 250);
            param[3].Value = Result;

            param[4] = new SqlParameter("@PRICE", SqlDbType.NVarChar, 250);
            param[4].Value = Number;

            param[5] = new SqlParameter("@Img", SqlDbType.Image);
            param[5].Value = img;

            DAL.ExecuteCommand("ADD_Show75", param);
            DAL.Close();

        }
        public void ADD_Show80(int Number, string Club, string Name,
            int Result, string Weigh, byte[] img)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            param[0].Value = Weigh;

            param[1] = new SqlParameter("@ID_PRODUCT", SqlDbType.NVarChar, 250);
            param[1].Value = Name;

            param[2] = new SqlParameter("@Labe", SqlDbType.NVarChar, 250);
            param[2].Value = Club;

            param[3] = new SqlParameter("@Qte", SqlDbType.NVarChar, 250);
            param[3].Value = Result;

            param[4] = new SqlParameter("@PRICE", SqlDbType.NVarChar, 250);
            param[4].Value = Number;

            param[5] = new SqlParameter("@Img", SqlDbType.Image);
            param[5].Value = img;

            DAL.ExecuteCommand("ADD_Show80", param);
            DAL.Close();

        }
        public void ADD_Show85(int Number, string Club, string Name,
            int Result, string Weigh, byte[] img)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            param[0].Value = Weigh;

            param[1] = new SqlParameter("@ID_PRODUCT", SqlDbType.NVarChar, 250);
            param[1].Value = Name;

            param[2] = new SqlParameter("@Labe", SqlDbType.NVarChar, 250);
            param[2].Value = Club;

            param[3] = new SqlParameter("@Qte", SqlDbType.NVarChar, 250);
            param[3].Value = Result;

            param[4] = new SqlParameter("@PRICE", SqlDbType.NVarChar, 250);
            param[4].Value = Number;

            param[5] = new SqlParameter("@Img", SqlDbType.Image);
            param[5].Value = img;

            DAL.ExecuteCommand("ADD_Show85", param);
            DAL.Close();

        }
        public void ADD_Show90(int Number, string Club, string Name,
            int Result, string Weigh, byte[] img)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            param[0].Value = Weigh;

            param[1] = new SqlParameter("@ID_PRODUCT", SqlDbType.NVarChar, 250);
            param[1].Value = Name;

            param[2] = new SqlParameter("@Labe", SqlDbType.NVarChar, 250);
            param[2].Value = Club;

            param[3] = new SqlParameter("@Qte", SqlDbType.NVarChar, 250);
            param[3].Value = Result;

            param[4] = new SqlParameter("@PRICE", SqlDbType.NVarChar, 250);
            param[4].Value = Number;

            param[5] = new SqlParameter("@Img", SqlDbType.Image);
            param[5].Value = img;

            DAL.ExecuteCommand("ADD_Show90", param);
            DAL.Close();

        }
        public void ADD_Show95(int Number, string Club, string Name,
            int Result, string Weigh, byte[] img)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            param[0].Value = Weigh;

            param[1] = new SqlParameter("@ID_PRODUCT", SqlDbType.NVarChar, 250);
            param[1].Value = Name;

            param[2] = new SqlParameter("@Labe", SqlDbType.NVarChar, 250);
            param[2].Value = Club;

            param[3] = new SqlParameter("@Qte", SqlDbType.NVarChar, 250);
            param[3].Value = Result;

            param[4] = new SqlParameter("@PRICE", SqlDbType.NVarChar, 250);
            param[4].Value = Number;

            param[5] = new SqlParameter("@Img", SqlDbType.Image);
            param[5].Value = img;

            DAL.ExecuteCommand("ADD_Show95", param);
            DAL.Close();

        }
        

    }
}
