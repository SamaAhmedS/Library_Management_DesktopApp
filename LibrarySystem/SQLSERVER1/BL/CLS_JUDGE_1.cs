using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SQLSERVER1.BL
{
    class CLS_JUDGE_1
    {
        public DataTable GET_ALL_CATEGORIES()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_CATEGORIES", null);
            DAL.Close();
            return Dt;
        }

        public void ADD_JUDGE_1(int ID, string txtRJ_1, string txtBJ_1)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[1] = new SqlParameter("@txtRJ1_1", SqlDbType.VarChar, 30);
            param[1].Value = txtRJ_1;

            param[2] = new SqlParameter("@txtBJ1_1", SqlDbType.VarChar,30);
            param[2].Value = @txtBJ_1;

            DAL.ExecuteCommand("ADD_Judge_1", param);
            DAL.Close();

        }
    }
}
