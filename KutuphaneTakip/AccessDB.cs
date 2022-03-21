using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
namespace KutuphaneTakip
{
    partial class AccessDB
    {
        Dictionary<string, string> tables = new Dictionary<string, string>()
        {
            { "user", "Kullanici" },
            { "books", "Kitaplar" }
        };
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db.accdb");

        public void yeniTabloKaydet(string key, string table)
        {
            tables[key] = table;
        }



    }
}
