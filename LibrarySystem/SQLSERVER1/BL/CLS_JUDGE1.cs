using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace SQLSERVER1.BL
{
    class CLS_JUDGE1
    {
        public DataTable GET_ALL_CATEGORIES()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_CATEGORIES", null);
            DAL.Close();
            return Dt;
        }

        public void ADD_Judge_1(int ID, string txtRJ_1, string txtBJ_1,
             string txtsend)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@ID1", SqlDbType.Int);
            param[0].Value = ID;

            param[1] = new SqlParameter("@txtRJ1_1", SqlDbType.VarChar,30);
            param[1].Value = txtRJ_1;

            param[2] = new SqlParameter("@txtBJ1_1", SqlDbType.VarChar, 30);
            param[2].Value = txtBJ_1;

            param[3] = new SqlParameter("@txtsend1", SqlDbType.VarChar, 50);
            param[3].Value = txtsend;


            DAL.ExecuteCommand("ADD_Judge_1", param);
            DAL.Close();

        }

        internal void ADD_Judge_1(int v, string text1, string text2)
        {
            throw new NotImplementedException();
        }

        internal void ADD_Judge_1(int v1, string text1, string text2, int v2, string text3)
        {
            throw new NotImplementedException();
        }

        internal void JUDGE1(int v1, object text1, object text2, int v2, object text3)
        {
            throw new NotImplementedException();
        }

        internal void Save(MemoryStream ms)
        {
            throw new NotImplementedException();
        }

        internal void JUDGE1(int v2, object v1, string v3, object txtRJ1, object v4, object txtBJ1)
        {
            throw new NotImplementedException();
        }

        internal void JUDGE1(object int32v1, string v1, int txtRJ1, object v2, object txtBJ1)
        {
            throw new NotImplementedException();
        }

        internal void Save(MemoryStream ms, string text)
        {
            throw new NotImplementedException();
        }
    }
}
