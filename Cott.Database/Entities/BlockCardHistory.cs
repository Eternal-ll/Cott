namespace Cott.Database.Entities
{
    public partial class BlockCardHistory
    {
        public long Id { get; set; }
        public long CardId { get; set; }
        public DateTime Updated { get; set; }
        public int Status { get; set; }
        public long? Batid { get; set; }
        public int? Umid { get; set; }
        public string Reason { get; set; }
    }
}
