namespace Cott.Database.Entities
{
    public partial class TripBlockCard
    {
        public int Id { get; set; }
        public int FileUploadId { get; set; }
        public int? BatId { get; set; }
        public int? CardId { get; set; }
        public DateTime? TranDate { get; set; }
    }
}
