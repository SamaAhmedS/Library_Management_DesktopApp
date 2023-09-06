using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SQLSERVER1.BL
{
    class CLS_J1
    {
        public void D_Judge2(int redPj2, int bluepj2)
        {
            DAL.DataAccessLayer DAL1 = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[2];
            param[1] = new SqlParameter("@redPj2", SqlDbType.Int);
            param[1].Value = redPj2;

            param[3] = new SqlParameter("@bluepj2", SqlDbType.VarChar, 30);
            param[3].Value = bluepj2;
            DAL1.Open();
            DataTable Dt = new DataTable();
            Dt = DAL1.SelectData("UPDATE_PRODUCT", param);
            DAL1.ExecuteCommand("UPDATE_PRODUCT", param);
            //return Dt;
            //DAL1.ExecuteCommand("D_Judge2", param);
            DAL1.Close();
        }
    }
}
