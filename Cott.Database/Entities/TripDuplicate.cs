namespace Cott.Database.Entities
{
    public partial class TripDuplicate
    {
        public int Id { get; set; }
        public int? FileUploadId { get; set; }
        public int? BatIdTrans { get; set; }
        public int? TripIdTrans { get; set; }
    }
}
