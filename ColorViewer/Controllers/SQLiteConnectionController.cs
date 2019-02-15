using ColorViewer.Models;
using System.Text;

namespace ColorViewer.Controllers
{
    public static class SQLiteConnectionController
    {
        private static readonly SQLiteConnectionDetails SQLLCD = new SQLiteConnectionDetails();

        public static string GetSQLiteDbConnection()
        {
            StringBuilder SB = new StringBuilder();
            SB.Append(string.Concat("Data Source=", SQLLCD.DataSource, ";"));
            SB.Append(string.Concat("Version=", SQLLCD.Version.ToString(), ";"));
            SB.Append(string.Concat("New=", SQLLCD.NewDb.ToString(), ";"));
            SB.Append(string.Concat("Compress=", SQLLCD.DoCompress.ToString(), ";"));

            return SB.ToString();
        }
    }
}
