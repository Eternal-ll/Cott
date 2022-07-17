namespace Cott.Database.Entities
{
    public partial class Session
    {
        public Session()
        {
            Etkcomissions = new HashSet<Etkcomission>();
        }

        public long Id { get; set; }
        public long TypeSession { get; set; }
        public long TerminalId { get; set; }
        public long? CardId { get; set; }
        public long? TariffPpid { get; set; }
        public long? OpNumber { get; set; }
        public decimal? PaySumm { get; set; }
        public decimal? Change { get; set; }
        public string Content { get; set; }
        public long Status { get; set; }
        public DateTime Updated { get; set; }
        public long? ActualPrivilegesId { get; set; }

        public virtual Card Card { get; set; }
        public virtual DictTarifPp TariffPp { get; set; }
        public virtual Terminal Terminal { get; set; }
        public virtual ICollection<Etkcomission> Etkcomissions { get; set; }
    }
}
