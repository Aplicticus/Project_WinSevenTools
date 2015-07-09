using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinSevenTools.SQL
{
    public class SQLQueryManager
    {
        public Dictionary<string, string> sqlQueries;

        public SQLQueryManager()
        {
            sqlQueries = new Dictionary<string, string>();
            FillSqlQueryList();
        }

        private void FillSqlQueryList()
        {            
            sqlQueries.Add("SelectAllUsers", "SELECT * FROM tbUsers");
            
            sqlQueries.Add("SelectAllEvents", "SELECT * FROM tbEvents");



        }
    }    
}
