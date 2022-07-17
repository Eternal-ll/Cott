namespace Cott.Database.Entities
{
    public partial class TripUndefinedCard
    {
        public int Id { get; set; }
        public int? FileUploadId { get; set; }
        public int? CardCount { get; set; }
        public int? TripCount { get; set; }
    }
}
