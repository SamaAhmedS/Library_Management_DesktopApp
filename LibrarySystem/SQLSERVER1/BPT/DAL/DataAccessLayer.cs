using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SQLSERVER1.DAL
{
    class DataAccessLayer
    {
        SqlConnection sqlconnection;

        //This Constructor Inisialize the connection object
        public DataAccessLayer()
        {
            sqlconnection = new SqlConnection(@"Server=.\SQLEXPRESS; Database=Product_DB; Integrated Security=true");
        }

        //Method to open the connection

        public void Open()
        {
            if (sqlconnection.State != ConnectionState.Open)
            {
                sqlconnection.Open();
            }
        }
        //Method to close the connection

        public void Close()
        {
            if (sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }
        //Method to Read Data From Database

        public DataTable SelectData(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;

            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }

            SqlDataAdapter Da = new SqlDataAdapter(sqlcmd);
            DataTable Dt = new DataTable();
            Da.Fill(Dt);
            return Dt;
        }
        //Method to Insert, update, and Delete Data From Database 
        public void ExecuteCommand(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;

            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }
            sqlcmd.ExecuteNonQuery();
            //sqlcmd.ExecuteNonQueryAsync();
            //sqlcmd.ExecuteReaderAsync();
            //sqlcmd.ExecuteXmlReader();
        }
    }
}
