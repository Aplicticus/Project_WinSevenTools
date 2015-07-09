using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WinSevenTools.SQL
{     
    public class SQLConnectionManager
    {
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter DA = null;
        private string sqlConnectionString = ConfigurationManager.ConnectionStrings["sqlConnection"].ToString();
        public SQLConnectionManager()
        {
            sqlConnection = new SqlConnection(sqlConnectionString);
        }

        public DataSet ReadDatabaseToDataSet(string sqlQuery)
        {
            DA = new SqlDataAdapter(sqlQuery, sqlConnection);
            DataSet newSet = new DataSet();
            DA.Fill(newSet);
            return newSet;
        }
        public DataTable ReadDatabaseToDataTable(string sqlQuery)
        {            
            DA = new SqlDataAdapter(sqlQuery, sqlConnection);
            DataTable newTable = new DataTable();
            DA.Fill(newTable);
            return newTable;
        }
    }
}
