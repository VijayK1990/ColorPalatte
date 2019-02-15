using ColorViewer.Models;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace ColorViewer.Controllers
{
    public static class ConvertionController
    {
        private static CMYKDetails CMYK_ColorMode = null;
        private static ImageFileDetails IMFD = null;

        /// <summary>
        /// Return simple Hex to System readable HEX Format
        /// </summary>
        /// <param name="Hex">Simple Hex stirng</param>
        /// <returns>Converted HEX Color</returns>
        public static Color GetColorFromHex(string Hex)
        {
            return ColorTranslator.FromHtml(string.Concat("#", Hex));
        }

        /// <summary>
        ///Converts RGB Color stream to CMYK Representation
        /// </summary>
        /// <param name="cr">Color Stream</param>
        /// <returns>CMYK Color Code</returns>
        public static CMYKDetails ConvertRGBtoCMYK(Color cr)
        {
            double Black_Base = Math.Min(1.0 - (cr.R / 255.0), Math.Min(1.0 - (cr.G / 255.0), 1.0 - (cr.B / 255.0)));

            CMYK_ColorMode = new CMYKDetails()
            {
                Black = Black_Base,
                Cyan = (1.0 - (cr.R / 255.0) - Black_Base) / (1.0 - Black_Base),
                Magenta = (1.0 - (cr.G / 255.0) - Black_Base) / (1.0 - Black_Base),
                Yellow = (1.0 - (cr.B / 255.0) - Black_Base) / (1.0 - Black_Base),
            };

            return CMYK_ColorMode;
        }

        /// <summary>
        ///Converts Color to HEX Format
        /// </summary>
        /// <param name="cr">Color Code</param>
        /// <returns>HEX Color Code</returns>
        public static string ConvertColortoHex(Color cr)
        {
            return string.Format("{0:x6}", cr.ToArgb()).ToUpper();
        }

        /// <summary>
        /// Retrives Image metadata from Image file
        /// </summary>
        /// <param name="Filename">Image Filename</param>
        /// <returns>Image Metadata</returns>
        public static ImageFileDetails ConvertImagetoExtendedDetails(string Filename)
        {
            Image i = Image.FromFile(Filename);
            ImageFormat IMF = i.RawFormat;

            IMFD = new ImageFileDetails()
            {
                ImageType = IMF.ToString(),
                ImageWidth = i.Width,
                ImageHeight = i.Height,
                ImageResolution = string.Concat(Convert.ToInt32(i.VerticalResolution), "x", Convert.ToInt32(i.HorizontalResolution)),
                ImagePixelDepth = Image.GetPixelFormatSize(i.PixelFormat),
                ImageFileSize = UtilityController.GetFileSize(Filename),
                ImageDominantColor = GetDominantColor((Bitmap)Image.FromFile(Filename))
            };

            return IMFD;
        }

        public static Color GetDominantColor(Bitmap bmp)
        {
            //Used for tally
            int r = 0;
            int g = 0;
            int b = 0;

            int total = 0;

            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color clr = bmp.GetPixel(x, y);

                    r += clr.R;
                    g += clr.G;
                    b += clr.B;

                    total++;
                }
            }

            //Calculate average
            r /= total;
            g /= total;
            b /= total;

            return Color.FromArgb(r, g, b);
        }

        public static Image ConvertImageSize(Image img, Size s)
        {
            Bitmap bm = new Bitmap(img, Convert.ToInt32(img.Width * s.Width), Convert.ToInt32(img.Height * s.Height));
            Graphics g = Graphics.FromImage(bm);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            return bm;
        }
    }
}
