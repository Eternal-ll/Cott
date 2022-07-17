namespace Cott.Database.Entities
{
    public partial class TechnicalTransferCard
    {
        public int Id { get; set; }
        public long? TariffPpid { get; set; }
        public long OpNumber { get; set; }
        public string FromCard { get; set; }
        public long CardId { get; set; }
        public string Content { get; set; }
        public long Status { get; set; }
        public DateTime Updated { get; set; }
        public long? Reason { get; set; }
        public long UserId { get; set; }
        public string Comment { get; set; }
        public string ApplicNumb { get; set; }
    }
}
