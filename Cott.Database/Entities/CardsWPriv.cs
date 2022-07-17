namespace Cott.Database.Entities
{
    public partial class CardsWPriv
    {
        public long Id { get; set; }
        public string Sn { get; set; }
        public string ChipNumber { get; set; }
        public string CardNumber { get; set; }
        public long Status { get; set; }
        public long? Expr1 { get; set; }
        public long? CardId { get; set; }
        public long? PrivilegesId { get; set; }
        public long? DocId { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
    }
}
