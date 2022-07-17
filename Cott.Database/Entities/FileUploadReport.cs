namespace Cott.Database.Entities
{
    public partial class FileUploadReport
    {
        public int Id { get; set; }
        public int FileUploadId { get; set; }
        public int? Total { get; set; }
        public int? Processed { get; set; }
    }
}
