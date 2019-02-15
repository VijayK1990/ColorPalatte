using System.Drawing;

namespace ColorViewer.Models
{
    public sealed class ImageFileDetails
    {
        public int ImageWidth { get; set; } = 0;
        public int ImageHeight { get; set; } = 0;
        public int ImagePixelDepth { get; set; } = 0;
        public string ImageType { get; set; } = string.Empty;
        public string ImageResolution { get; set; } = string.Empty;
        public string ImageFileSize { get; set; } = string.Empty;
        public Color ImageDominantColor { get; set; }
    }
}
