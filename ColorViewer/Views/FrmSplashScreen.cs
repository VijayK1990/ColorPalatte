using ColorViewer.Controllers;
using System;
using System.Windows.Forms;

namespace ColorViewer.Views
{
    public partial class FrmSplashScreen : Form
    {
        public FrmSplashScreen()
        {
            InitializeComponent();
        }

        private void FrmSplashScreen_Load(object sender, EventArgs e)
        {
            LblVersion.Text = UtilityController.SetApplicationVersion();

            if (!ValidationController.ValidateSQLiteDbExist())
            {
                SQLiteActivityController.InitializeSQLiteDB(out string ER);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            GC.Collect();
            Application.Exit();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            FrmColorPalette fcp = new FrmColorPalette();
            fcp.Show();
            Hide();
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            FrmAbout Fa = new FrmAbout();
            Fa.ShowDialog();
        }
    }
}
