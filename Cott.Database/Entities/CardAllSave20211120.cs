namespace Cott.Database.Entities
{
    public partial class CardAllSave20211120
    {
        public long Id { get; set; }
        public long AorgId { get; set; }
        public string Sn { get; set; }
        public long? AccountId { get; set; }
        public string ChipNumber { get; set; }
        public string CardNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public long Status { get; set; }
    }
}
