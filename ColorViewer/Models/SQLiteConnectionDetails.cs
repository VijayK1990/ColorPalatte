using System.Windows.Forms;

namespace ColorViewer.Models
{
    public sealed class SQLiteConnectionDetails
    {
        public string DataSource { get; set; } = Application.StartupPath + @"\ColorCollection.db";
        public int Version { get; set; } = 3;
        public bool NewDb { get; set; } = true;
        public bool DoCompress { get; set; } = true;
    }
}
