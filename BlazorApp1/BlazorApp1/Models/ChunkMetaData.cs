namespace BlazorApp1.Models
{
    public class ChunkMetaData
    {
        public string FileName { get; set; }
        public int ChunkIndex { get; set; }
        public int TotalChunks { get; set; }
        public long TotalFileSize { get; set; }
        public string ContentType { get; set; }
    }
}
