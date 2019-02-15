using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;

namespace ColorViewer.Controllers
{
    public static class UtilityController
    {
        /// <summary>
        /// Retrives Application Version Details
        /// </summary>
        public static string SetApplicationVersion()
        {
            return string.Concat(FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion, " [beta]");
        }

        /// <summary>
        /// Retrives available Image Codec from System
        /// </summary>
        /// <returns></returns>
        public static string GetAvailableImageCodecs()
        {
            var codecs = ImageCodecInfo.GetImageEncoders();
            var codecFilter = "Image Files|";

            foreach (var codec in codecs)
            {
                codecFilter += codec.FilenameExtension + ";";
            }

            return codecFilter;
        }

        /// <summary>
        /// Retrives Image/File Size
        /// </summary>
        /// <param name="Filename">Filename for which size is to be calculated</param>
        /// <returns>Filesize in  B,KB,MB,GB</returns>
        public static string GetFileSize(string Filename)
        {
            var fileLength = new FileInfo(Filename).Length;
            string[] sizes = { "B", "KB", "MB", "GB" };
            int order = 0;
            while (fileLength >= 1024 && order + 1 < sizes.Length)
            {
                order++;
                fileLength = fileLength / 1024;
            }

            return string.Format("{0:0.##} {1}", fileLength, sizes[order]);
        }
    }
}
