using System.Data;
using System.Data.SQLite;

namespace ColorViewer.Models
{
    public class SQLiteBridge
    {
        public SQLiteConnection SQLLCon = null;
        public SQLiteCommand SQLLCmd = null;
        public SQLiteDataAdapter SQLLDA = null;
        public DataTable SQLDT = null;
        public bool SQLiteCmdStatus = false;        
    }
}
