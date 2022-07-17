namespace Cott.Database.Entities
{
    public partial class BksbterminalSession
    {
        public long Id { get; set; }
        public long TypeSession { get; set; }
        public int? IdBksb { get; set; }
        public string Fnumber { get; set; }
        public string CardChipId { get; set; }
        public long TariffPpid { get; set; }
        public long? OpNumber { get; set; }
        public decimal? PaySumm { get; set; }
        public string DataCard { get; set; }
        public string Res { get; set; }
        public string ResDb { get; set; }
        public int ResponseOutput { get; set; }
        public int Status { get; set; }
        public DateTime Updated { get; set; }
        public string PaymentErrorInfo { get; set; }
    }
}
