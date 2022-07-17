namespace Cott.Database.Entities
{
    public partial class CardParegSaveIsh
    {
        public long Id { get; set; }
        public long CardId { get; set; }
        public long ParegId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public long Status { get; set; }
    }
}
