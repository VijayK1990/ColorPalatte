using ColorViewer.Controllers;
using ColorViewer.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorViewer.Views
{
    public partial class FrmColorPalette : Form
    {
        private CMYKDetails ColorCode = null;
        private ColorPatternDetails CPD = null;
        private bool IsSecondaryWindow = false;
        private static int A_P = 0;
        private static int R_P = 0;
        private static int G_P = 0;
        private static int B_P = 0;

        public FrmColorPalette()
        {
            InitializeComponent();
        }

        public FrmColorPalette(Color cr)
        {
            InitializeComponent();
            SetColorSpecifications(cr);
            Convert_RGB_to_CMYK(cr);
            SetColorSliderVariation(cr);
            BtnChooseColorFromImage.Visible = false;
            BtnShowColor.Visible = false;
            IsSecondaryWindow = true;
        }

        private void BtnShowColor_Click(object sender, EventArgs e)
        {
            if (CldlgColorPicker.ShowDialog() == DialogResult.OK)
            {
                Color cr = CldlgColorPicker.Color;
                SetColorSpecifications(cr);
                Convert_RGB_to_CMYK(cr);
                SetColorSliderVariation(cr);
            }
        }

        private void Lbl_SelectedColor_Click(object sender, EventArgs e)
        {
            BtnShowColor_Click(this, null);
        }

        private void Txt_HEXColorCode_Leave(object sender, EventArgs e)
        {
            if (!ValidationController.ValidateColorCode(Txt_HEXColorCode.Text).Success)
            {
                MessageBox.Show("Invalid Color Code. If you have included '#' in the Color Code, then please remove '#' and then try again.", "Invalid Color Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ConvertHexToColor(Txt_HEXColorCode.Text);
            }
        }

        private void Trb_Red_Scroll(object sender, EventArgs e)
        {
            Color cr = Color.FromArgb(Convert.ToInt32(Trb_Alpha.Value), Convert.ToInt32(Trb_Red.Value), Convert.ToInt32(Trb_Green.Value), Convert.ToInt32(Trb_Blue.Value));
            SetColorSpecifications(cr);
            Convert_RGB_to_CMYK(cr);
        }

        private void Trb_Green_Scroll(object sender, EventArgs e)
        {
            Color cr = Color.FromArgb(Convert.ToInt32(Trb_Alpha.Value), Convert.ToInt32(Trb_Red.Value), Convert.ToInt32(Trb_Green.Value), Convert.ToInt32(Trb_Blue.Value));
            SetColorSpecifications(cr);
            Convert_RGB_to_CMYK(cr);
        }

        private void Trb_Blue_Scroll(object sender, EventArgs e)
        {
            Color cr = Color.FromArgb(Convert.ToInt32(Trb_Alpha.Value), Convert.ToInt32(Trb_Red.Value), Convert.ToInt32(Trb_Green.Value), Convert.ToInt32(Trb_Blue.Value));
            SetColorSpecifications(cr);
            Convert_RGB_to_CMYK(cr);
        }

        private void Trb_Alpha_Scroll(object sender, EventArgs e)
        {
            Color cr = Color.FromArgb(Convert.ToInt32(Trb_Alpha.Value), Convert.ToInt32(Trb_Red.Value), Convert.ToInt32(Trb_Green.Value), Convert.ToInt32(Trb_Blue.Value));
            SetColorSpecifications(cr);
            Convert_RGB_to_CMYK(cr);
        }

        /// <summary>
        /// Converts RGB values to CMYK Specification values
        /// </summary>
        /// <param name="cr">Color value</param>
        private void Convert_RGB_to_CMYK(Color cr)
        {
            ColorCode = new CMYKDetails();
            ColorCode = ConvertionController.ConvertRGBtoCMYK(cr);

            #region CMYK Convertion
            //Black = Math.Min(1.0 - (cr.R / 255.0), Math.Min(1.0 - (cr.G / 255.0), 1.0 - (cr.B / 255.0)));
            //Cyan = (1.0 - (cr.R / 255.0) - Black) / (1.0 - Black);
            //Magenta = (1.0 - (cr.G / 255.0) - Black) / (1.0 - Black);
            //Yellow = (1.0 - (cr.B / 255.0) - Black) / (1.0 - Black);

            #endregion

            Txt_Cyan.Text = Math.Round(ColorCode.Cyan, 2).ToString();
            Txt_Magenta.Text = Math.Round(ColorCode.Magenta, 2).ToString();
            Txt_Yellow.Text = Math.Round(ColorCode.Yellow, 2).ToString();
            Txt_Black_K.Text = Math.Round(ColorCode.Black, 2).ToString();
        }

        /// <summary>
        /// Converts HEX Color value to RGB Color
        /// </summary>
        /// <param name="HEX">Hexadecimal value of Color</param>
        private void ConvertHexToColor(string HEX)
        {
            Color NewColor = ConvertionController.GetColorFromHex(HEX);
            SetColorSpecifications(NewColor);
            Convert_RGB_to_CMYK(NewColor);
            SetColorSliderVariation(NewColor);
        }

        /// <summary>
        ///Sets the Color bifurcations based on RGB Color
        /// </summary>
        /// <param name="cr">Color Value</param>
        private void SetColorSpecifications(Color cr)
        {
            Lbl_SelectedColor.BackColor = cr;
            Txt_HEXColorCode.Text = ConvertionController.ConvertColortoHex(cr);

            Txt_Alpha.Text = cr.A.ToString();
            Txt_Red.Text = cr.R.ToString();
            Txt_Green.Text = cr.G.ToString();
            Txt_Blue.Text = cr.B.ToString();

            int A = Convert.ToInt32(cr.A);
            int R = Convert.ToInt32(cr.R);
            int G = Convert.ToInt32(cr.G);
            int B = Convert.ToInt32(cr.B);
            ARGBPercentLimit ColorLimit = ARGBPercentController.GetARGBLimit(A, R, G, B);

            //A_P = Convert.ToInt32(Math.Ceiling(((float)A / 255) * 100));
            //R_P = Convert.ToInt32(Math.Ceiling(((float)R / 255) * 100));
            //G_P = Convert.ToInt32(Math.Ceiling(((float)G / 255) * 100));
            //B_P = Convert.ToInt32(Math.Ceiling(((float)B / 255) * 100));

            A_P = Convert.ToInt32(Math.Ceiling(((float)A / 255) * ColorLimit.A));
            R_P = Convert.ToInt32(Math.Ceiling(((float)R / 255) * ColorLimit.R));
            G_P = Convert.ToInt32(Math.Ceiling(((float)G / 255) * ColorLimit.G));
            B_P = Convert.ToInt32(Math.Ceiling(((float)B / 255) * ColorLimit.B));

            Txt_Percent_Alpha.Text = A_P.ToString();
            Txt_Percent_Red.Text = R_P.ToString();
            Txt_Percent_Green.Text = G_P.ToString();
            Txt_Percent_Blue.Text = B_P.ToString();
        }

        /// <summary>
        /// Sets the Color Slider values to new Color Values
        /// </summary>
        /// <param name="cr">Color Values</param>
        private void SetColorSliderVariation(Color cr)
        {
            Trb_Red.Value = cr.R;
            Trb_Green.Value = cr.G;
            Trb_Blue.Value = cr.B;
            Trb_Alpha.Value = cr.A;
        }

        private void FrmColorPalette_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsSecondaryWindow)
            {
                Hide();
            }
            else
            {
                GC.Collect();
                Application.Exit();
            }
        }

        private void BtnChooseColorFromImage_Click(object sender, EventArgs e)
        {
            FrmFromImage ffi = new FrmFromImage();
            ffi.ShowDialog();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            bool status = false;

            if (!TxtPatterName.Text.Equals(string.Empty))
            {
                CPD = new ColorPatternDetails()
                {
                    PatternName = TxtPatterName.Text,
                    PatterHex = Txt_HEXColorCode.Text,
                    A = Convert.ToInt32(Txt_Alpha.Text),
                    R = Convert.ToInt32(Txt_Red.Text),
                    G = Convert.ToInt32(Txt_Green.Text),
                    B = Convert.ToInt32(Txt_Blue.Text),
                    C = Convert.ToSingle(Txt_Cyan.Text),
                    M = Convert.ToSingle(Txt_Magenta.Text),
                    Y = Convert.ToSingle(Txt_Yellow.Text),
                    K = Convert.ToSingle(Txt_Black_K.Text)
                };

                status = SQLiteActivityController.WriteToSQLiteDb(CPD);

                if (status)
                {
                    MessageBox.Show("Color Pattern saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unable to save Color Pattern", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Pattern Name is required and cannot be empty", "Pattern Name Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_ViewCollection_Click(object sender, EventArgs e)
        {
            FrmViewColorPattern fvcp = new FrmViewColorPattern();
            fvcp.Show();
        }

        private void FrmColorPalette_Load(object sender, EventArgs e)
        {
            LblMachineName.Text = Environment.MachineName;
            LblLoggedInAs.Text = Environment.UserName;
        }
    }
}
