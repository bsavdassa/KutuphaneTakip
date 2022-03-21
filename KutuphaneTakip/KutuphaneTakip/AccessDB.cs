using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
namespace KutuphaneTakip
{
    public partial class AccessDB 
    {
        public Dictionary<string, string> tables = new Dictionary<string, string>() {};
        string dbFile;
        OleDbConnection connection;
        public AccessDB(string dbFile)
        {
            this.dbFile = dbFile;
            connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dbFile);
            connection.Open();
        }
        public void yeniTabloKaydet(string key, string table)
        {
            tables[key] = table;
        }

        public string SubString(string text, int start, int end)
        {
            string last = "";
            for (int i = start; i < end; i++)
            {
                last += text[i];
            }
            return last;
        }

        public void ExecuteQuery(string query)
        {
            new OleDbCommand(query, connection).ExecuteNonQuery();
        }

        public string CreateInsertIntoQueryString(string tableKey, Dictionary<string, string> data)
        {
            string table = tables[tableKey];
            string sqlString = "INSERT INTO " + table + " (";
            foreach (var item in data)
            {
                sqlString += item.Key + ", ";
            }
            sqlString = SubString(sqlString, 0, sqlString.Length - 2) + ") VALUES (";
            foreach (var item in data)
            {
                sqlString += "'" + item.Value + "', ";
            }
            sqlString = SubString(sqlString, 0, sqlString.Length-2) + ")";
            sqlString.Substring(0, sqlString.Length - 2);
            return sqlString;
        }
    }
}
