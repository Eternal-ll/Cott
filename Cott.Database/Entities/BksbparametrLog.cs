namespace Cott.Database.Entities
{
    public partial class BksbparametrLog
    {
        public int Id { get; set; }
        public string ProcedureName { get; set; }
        public string IdCard { get; set; }
        public string DataCard { get; set; }
        public decimal? PaymentSum { get; set; }
        public string StartPeriod { get; set; }
        public string FactNmbReader { get; set; }
        public long? IdBksb { get; set; }
        public string NewCardDataOut { get; set; }
        public string PaymentErrorInfoOut { get; set; }
        public int? TransactionIdOut { get; set; }
        public int? NumbBlock { get; set; }
        public string ResOut { get; set; }
        public string ResDbOut { get; set; }
        public string ChekcardErrorInfoOut { get; set; }
        public int? ErrorIdOut { get; set; }
        public DateTime? Updated { get; set; }
    }
}
