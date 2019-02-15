namespace ColorViewer.Models
{
    public static class SQLLiteQueryDetails
    {
        public static string CreateTable { get; set; } = "CREATE TABLE IF NOT EXISTS [ColorDetails](ID INTEGER PRIMARY KEY AUTOINCREMENT, PATTERNAME TEXT, HEXCODE TEXT, A INTEGER, R INTEGER, G INTEGER, B INTEGER, C NUMERIC(7,2), M NUMERIC(7,2), Y NUMERIC(7,2), K BLACK NUMERIC(7,2));";

        public static string InsertToTable { get; set; } = "INSERT INTO ColorDetails (PATTERNAME,HEXCODE,A,R,G,B,C,M,Y,K) VALUES(@PNAME,@PHEX,@A,@R,@G,@B,@C,@M,@Y,@K);";

        public static string ViewTable { get; set; } = "SELECT * FROM ColorDetails";

        public static string DeleteFromtable { get; set; } = "DELETE FROM ColorDetails WHERE ID = @ID";
    }
}
