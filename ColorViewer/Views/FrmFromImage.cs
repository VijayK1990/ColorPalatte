using ColorViewer.Controllers;
using ColorViewer.Models;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace ColorViewer.Views
{
    public partial class FrmFromImage : Form
    {
        private static ImageFileDetails IMFD = null;
        private static string ImageFileName = string.Empty;
        private static Image Org_Img;
        private Point _MouseDown;

        public FrmFromImage()
        {
            InitializeComponent();
        }

        private void FrmFromImage_Load(object sender, EventArgs e)
        {
            Lbl_ZoomFactor.Text = string.Concat(Trb_Zoom_In_Out.Value, "x");
            OfdChooseImageFile.Filter = UtilityController.GetAvailableImageCodecs();
            DoubleBuffered = true;
        }

        private void BtnChooseImage_Click(object sender, EventArgs e)
        {
            DialogResult dr = OfdChooseImageFile.ShowDialog();

            if (dr == DialogResult.OK)
            {
                ImageFileName = OfdChooseImageFile.FileName;

                if (OfdChooseImageFile.ValidateNames)
                {
                    PibSelectedImage.Image = Image.FromFile(ImageFileName);
                    Org_Img = Image.FromFile(ImageFileName);
                    SetImageMetadata(ImageFileName, OfdChooseImageFile.SafeFileName);
                }
            }
        }

        private void SetImageMetadata(string f, string f2)
        {
            IMFD = new ImageFileDetails();
            IMFD = ConvertionController.ConvertImagetoExtendedDetails(f);

            Lbl_Filename.Text = f2;
            Lbl_FileType.Text = IMFD.ImageType;
            Lbl_Height.Text = IMFD.ImageHeight.ToString();
            Lbl_Width.Text = IMFD.ImageWidth.ToString();
            Lbl_PixelDepth.Text = IMFD.ImagePixelDepth.ToString() + "bit";
            Lbl_Resolution.Text = IMFD.ImageResolution;
            Lbl_FileSize.Text = IMFD.ImageFileSize;
            LblDominantColor.Text = string.Concat("A: ", IMFD.ImageDominantColor.A, ", R: ", IMFD.ImageDominantColor.R, ",\nG: ", IMFD.ImageDominantColor.G, ",B: ", IMFD.ImageDominantColor.B);
            LblDominantColor.BackColor = IMFD.ImageDominantColor;
        }

        private void PibSelectedImage_Click(object sender, EventArgs e)
        {
            Color? clr = null;
            PropertyInfo ImgRectProp = typeof(PictureBox).GetProperty("ImageRectangle", BindingFlags.GetProperty | BindingFlags.NonPublic | BindingFlags.Instance);

            if (PibSelectedImage.Image != null)
            {
                MouseEventArgs mea = (MouseEventArgs)e;
                Bitmap Org = (Bitmap)PibSelectedImage.Image;

                switch (PibSelectedImage.SizeMode)
                {
                    case PictureBoxSizeMode.Normal:
                    case PictureBoxSizeMode.AutoSize:
                        {
                            clr = Org.GetPixel(mea.X, mea.Y);
                            break;
                        }
                    case PictureBoxSizeMode.CenterImage:
                    case PictureBoxSizeMode.StretchImage:
                    case PictureBoxSizeMode.Zoom:
                        {
                            Rectangle r = (Rectangle)ImgRectProp.GetValue(PibSelectedImage, null);

                            if (r.Contains(mea.Location))
                            {
                                using (Bitmap cpy = new Bitmap(PibSelectedImage.ClientSize.Width, PibSelectedImage.ClientSize.Height))
                                {
                                    using (Graphics g = Graphics.FromImage(cpy))
                                    {
                                        g.DrawImage(PibSelectedImage.Image, r);
                                        clr = cpy.GetPixel(mea.X, mea.Y);
                                    }
                                }
                            }
                            break;
                        }
                }

                if (!clr.HasValue)
                {
                    MessageBox.Show("Color not found. Please click on the Image to pick a color", "Invalid Color", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    FrmColorPalette fcp = new FrmColorPalette((Color)clr);
                    fcp.ShowDialog();
                }
            }
        }

        private void Trb_Zoom_In_Out_Scroll(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Trb_Zoom_In_Out.Value) > 0)
            {
                PibSelectedImage.SizeMode = PictureBoxSizeMode.CenterImage;
                PibSelectedImage.Image = null;
                PibSelectedImage.Image = ConvertionController.ConvertImageSize(Org_Img, new Size(Convert.ToInt32(Trb_Zoom_In_Out.Value), Convert.ToInt32(Trb_Zoom_In_Out.Value)));
                Lbl_ZoomFactor.Text = string.Concat(Trb_Zoom_In_Out.Value, "x");
            }
            else
            {
                Lbl_ZoomFactor.Text = string.Concat(Trb_Zoom_In_Out.Value, "x");
                PibSelectedImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void PibSelectedImage_MouseMove(object sender, MouseEventArgs e)
        {
            MouseEventArgs Mea = e as MouseEventArgs;

            if (Mea.Button == MouseButtons.Left)
            {
                Point MPointCurrent = Mea.Location;

                int _deltaX = MPointCurrent.X - _MouseDown.X;
                int _deltaY = MPointCurrent.Y - _MouseDown.Y;

                int _newX = PibSelectedImage.Location.X + _deltaX;
                int _newY = PibSelectedImage.Location.Y + _deltaY;

                PibSelectedImage.Location = new Point(_newX, _newY);
            }
        }

        private void PibSelectedImage_MouseDown(object sender, MouseEventArgs e)
        {
            MouseEventArgs Mea = e;

            if (Mea.Button == MouseButtons.Left)
            {
                _MouseDown = Mea.Location;
            }
        }

        private void PibSelectedImage_MouseUp(object sender, MouseEventArgs e)
        {
            MouseEventArgs Mea = e;

            if (Mea.Button == MouseButtons.Left)
            {
                // Pan functions
                Point MousePosCurrent = Mea.Location;

                int _deltaX = MousePosCurrent.X - _MouseDown.X;
                int _deltaY = MousePosCurrent.Y - _MouseDown.Y;

                int _newX = PibSelectedImage.Location.X + _deltaX;
                int _newY = PibSelectedImage.Location.Y + _deltaY;

                PibSelectedImage.Location = new Point(_newX, _newY);
            }
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            int newWidth = Org_Img.Width,
                newHeight = Org_Img.Height,
                newX = PibSelectedImage.Location.X,
                newY = PibSelectedImage.Location.Y;

            if (e.Delta > 0)
            {
                newWidth = PibSelectedImage.Size.Width + (PibSelectedImage.Size.Width / 10);
                newHeight = PibSelectedImage.Size.Height + (PibSelectedImage.Size.Height / 10);
                newX = PibSelectedImage.Location.X - (PibSelectedImage.Size.Width / 10 / 2);
                newY = PibSelectedImage.Location.Y - (PibSelectedImage.Size.Height / 10 / 2);
            }
            else if (e.Delta < 0)
            {
                newWidth = PibSelectedImage.Size.Width - (PibSelectedImage.Size.Width / 10);
                newHeight = PibSelectedImage.Size.Height - (PibSelectedImage.Size.Height / 10);
                newX = PibSelectedImage.Location.X + (PibSelectedImage.Size.Width / 10 / 2);
                newY = PibSelectedImage.Location.Y + (PibSelectedImage.Size.Height / 10 / 2);

                // Prevent image from zooming out beyond original size
                if (newWidth < Org_Img.Width)
                {
                    newWidth = Org_Img.Width;
                    newHeight = Org_Img.Height;
                    newX = 0;
                    newY = 0;
                }
            }

            PibSelectedImage.Size = new Size(newWidth, newHeight);
            PibSelectedImage.Location = new Point(newX, newY);
        }
    }
}