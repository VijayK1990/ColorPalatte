using ColorViewer.Models;
using System;
using System.Data;
using System.Data.SQLite;

namespace ColorViewer.Controllers
{
    public static class SQLiteActivityController
    {
        private static ColorPatternDetails CPD = null;
        private static readonly SQLiteBridge SQLLB = new SQLiteBridge();

        public static void InitializeSQLiteDB(out string ER)
        {
            ER = string.Empty;
            try
            {
                SQLLB.SQLLCon = new SQLiteConnection(SQLiteConnectionController.GetSQLiteDbConnection());

                using (SQLLB.SQLLCon)
                {
                    SQLLB.SQLLCon.Open();
                }

                InitializeSQLiteTable(out ER);
            }
            catch (Exception ex)
            {
                ER = ex.ToString();
            }
        }

        private static void InitializeSQLiteTable(out string ER)
        {
            SQLLB.SQLLCon = new SQLiteConnection();
            SQLLB.SQLLCmd = new SQLiteCommand();
            ER = string.Empty;

            try
            {
                SQLLB.SQLLCon = new SQLiteConnection(SQLiteConnectionController.GetSQLiteDbConnection());

                using (SQLLB.SQLLCon)
                {
                    using (SQLLB.SQLLCmd)
                    {
                        SQLLB.SQLLCmd.Connection = SQLLB.SQLLCon;
                        SQLLB.SQLLCmd.CommandType = CommandType.Text;
                        SQLLB.SQLLCmd.CommandText = SQLLiteQueryDetails.CreateTable;
                        SQLLB.SQLLCon.Open();
                        SQLLB.SQLLCmd.ExecuteNonQuery();
                        SQLLB.SQLLCon.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ER = ex.ToString();
            }
        }

        public static bool WriteToSQLiteDb(object A, out string ER)
        {
            CPD = new ColorPatternDetails();
            CPD = (ColorPatternDetails)A;
            SQLLB.SQLLCon = new SQLiteConnection();
            SQLLB.SQLLCmd = new SQLiteCommand();
            ER = string.Empty;

            try
            {
                SQLLB.SQLLCon = new SQLiteConnection(SQLiteConnectionController.GetSQLiteDbConnection());

                using (SQLLB.SQLLCon)
                {
                    using (SQLLB.SQLLCmd)
                    {
                        SQLLB.SQLLCmd.Connection = SQLLB.SQLLCon;
                        SQLLB.SQLLCmd.CommandType = CommandType.Text;
                        SQLLB.SQLLCmd.CommandText = SQLLiteQueryDetails.InsertToTable;
                        SQLLB.SQLLCmd.Parameters.AddWithValue("@PNAME", CPD.PatternName);
                        SQLLB.SQLLCmd.Parameters.AddWithValue("@PHEX", CPD.PatterHex);
                        SQLLB.SQLLCmd.Parameters.AddWithValue("@A", CPD.A);
                        SQLLB.SQLLCmd.Parameters.AddWithValue("@R", CPD.R);
                        SQLLB.SQLLCmd.Parameters.AddWithValue("@G", CPD.G);
                        SQLLB.SQLLCmd.Parameters.AddWithValue("@B", CPD.B);
                        SQLLB.SQLLCmd.Parameters.AddWithValue("@C", CPD.C);
                        SQLLB.SQLLCmd.Parameters.AddWithValue("@M", CPD.M);
                        SQLLB.SQLLCmd.Parameters.AddWithValue("@Y", CPD.Y);
                        SQLLB.SQLLCmd.Parameters.AddWithValue("@K", CPD.K);
                        SQLLB.SQLLCon.Open();
                        SQLLB.SQLiteCmdStatus = SQLLB.SQLLCmd.ExecuteNonQuery() > 0;
                        SQLLB.SQLLCon.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ER = ex.ToString();
                SQLLB.SQLiteCmdStatus = false;
            }

            return SQLLB.SQLiteCmdStatus;
        }

        public static bool DeleteFromSQLiteDb(object A, out string ER)
        {
            CPD = new ColorPatternDetails();
            CPD = (ColorPatternDetails)A;
            SQLLB.SQLLCon = new SQLiteConnection();
            SQLLB.SQLLCmd = new SQLiteCommand();
            ER = string.Empty;

            try
            {
                SQLLB.SQLLCon = new SQLiteConnection(SQLiteConnectionController.GetSQLiteDbConnection());

                using (SQLLB.SQLLCon)
                {
                    using (SQLLB.SQLLCmd)
                    {
                        SQLLB.SQLLCmd.Connection = SQLLB.SQLLCon;
                        SQLLB.SQLLCmd.CommandType = CommandType.Text;
                        SQLLB.SQLLCmd.CommandText = SQLLiteQueryDetails.DeleteFromtable;
                        SQLLB.SQLLCmd.Parameters.AddWithValue("@ID", CPD.PatternID);
                        SQLLB.SQLLCon.Open();
                        SQLLB.SQLiteCmdStatus = SQLLB.SQLLCmd.ExecuteNonQuery() > 0;
                        SQLLB.SQLLCon.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                ER = ex.ToString();
                SQLLB.SQLiteCmdStatus = false;
            }

            return SQLLB.SQLiteCmdStatus;
        }

        public static DataTable GetTableDetails(out string ER)
        {
            SQLLB.SQLDT = new DataTable();
            SQLLB.SQLLDA = new SQLiteDataAdapter();
            SQLLB.SQLLCon = new SQLiteConnection();
            SQLLB.SQLLCmd = new SQLiteCommand();
            ER = string.Empty;

            try
            {
                SQLLB.SQLLCon = new SQLiteConnection(SQLiteConnectionController.GetSQLiteDbConnection());

                using (SQLLB.SQLLCon)
                {
                    using (SQLLB.SQLLCmd)
                    {
                        SQLLB.SQLLCmd.Connection = SQLLB.SQLLCon;
                        SQLLB.SQLLCmd.CommandType = CommandType.Text;
                        SQLLB.SQLLCmd.CommandText = SQLLiteQueryDetails.ViewTable;
                        SQLLB.SQLLDA.SelectCommand = SQLLB.SQLLCmd;
                        SQLLB.SQLLDA.Fill(SQLLB.SQLDT);
                    }
                }
            }
            catch(Exception ex)
            {
                ER = ex.ToString();
                SQLLB.SQLDT = null;
            }

            return SQLLB.SQLDT;
        }
    }
}
