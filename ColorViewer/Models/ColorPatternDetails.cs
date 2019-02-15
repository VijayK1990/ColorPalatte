namespace ColorViewer.Models
{
    public sealed class ColorPatternDetails
    {
        public string PatternName { get; set; } = string.Empty;
        public string PatterHex { get; set; } = string.Empty;
        public int PatternID { get; set; } = 0;
        public int A { get; set; } = 0;
        public int R { get; set; } = 0;
        public int G { get; set; } = 0;
        public int B { get; set; } = 0;
        public float C { get; set; } = 0;
        public float M { get; set; } = 0;
        public float Y { get; set; } = 0;
        public float K { get; set; } = 0;
    }
}
