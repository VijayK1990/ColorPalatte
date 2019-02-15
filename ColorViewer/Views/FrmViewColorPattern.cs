using ColorViewer.Controllers;
using ColorViewer.Models;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ColorViewer.Views
{
    public partial class FrmViewColorPattern : Form
    {
        private static int RowIndex = 0;
        private DataTable DT = null;
        private ColorPatternDetails CPD = null;

        public FrmViewColorPattern()
        {
            InitializeComponent();
        }

        private void FrmViewColorPattern_Load(object sender, EventArgs e)
        {
            SetDataGridView();
        }

        public void SetDataGridView()
        {
            DT = new DataTable();
            DT = SQLiteActivityController.GetTableDetails();

            if (DT != null && DT.Rows.Count != 0)
            {
                DgvColorPattern.DataSource = DT;
            }
            else
            {
                MessageBox.Show("No Color Patterns found to display. Add some to the list", "No Patterns", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Hide();
            }
        }

        private void Btn_ViewPattern_Click(object sender, EventArgs e)
        {
            DataGridViewRow SelectedRow = DgvColorPattern.Rows[RowIndex];

            int A = Convert.ToInt32(SelectedRow.Cells[3].Value.ToString());
            int R = Convert.ToInt32(SelectedRow.Cells[4].Value.ToString());
            int G = Convert.ToInt32(SelectedRow.Cells[5].Value.ToString());
            int B = Convert.ToInt32(SelectedRow.Cells[6].Value.ToString());

            Color clr = Color.FromArgb(A, R, G, B);

            FrmColorPalette fcp = new FrmColorPalette(clr);
            fcp.ShowDialog();
            Hide();
        }

        private void DgvColorPattern_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowIndex = e.RowIndex;
        }

        private void Btn_DeletePattern_Click(object sender, EventArgs e)
        {
            bool Status = false;
            DataGridViewRow SelectedRow = DgvColorPattern.Rows[RowIndex];

            CPD = new ColorPatternDetails()
            {
                PatternID = Convert.ToInt32(SelectedRow.Cells[0].Value.ToString())
            };

            Status = SQLiteActivityController.DeleteFromSQLiteDb(CPD);

            if (Status)
            {
                MessageBox.Show("Color Pattern Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Unable to delete Color Pattern", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
