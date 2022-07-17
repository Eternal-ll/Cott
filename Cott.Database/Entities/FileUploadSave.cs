namespace Cott.Database.Entities
{
    public partial class FileUploadSave
    {
        public long Id { get; set; }
        public long TerminalId { get; set; }
        public string FileName { get; set; }
        public DateTime Updated { get; set; }
    }
}
