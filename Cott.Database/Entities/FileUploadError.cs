namespace Cott.Database.Entities
{
    public partial class FileUploadError
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public int? TerminalHolder { get; set; }
        public int? Error { get; set; }
        public DateTime? Updated { get; set; }
    }
}
