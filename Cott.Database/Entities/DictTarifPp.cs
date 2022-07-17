namespace Cott.Database.Entities
{
    public partial class DictTarifPp
    {
        public DictTarifPp()
        {
            AccessibilityTariffbyPas = new HashSet<AccessibilityTariffbyPa>();
            SessionPeriods = new HashSet<SessionPeriod>();
            Sessions = new HashSet<Session>();
            RegistrPrivileges = new HashSet<DictRegistrPrivilege>();
            Terminals = new HashSet<Terminal>();
        }

        public long Id { get; set; }
        public long CategoryTariff { get; set; }
        public string Title { get; set; }
        public decimal Minsumm { get; set; }
        public decimal Maxsumm { get; set; }
        public string Content { get; set; }
        public long Status { get; set; }
        public string Mapping { get; set; }

        public virtual ICollection<AccessibilityTariffbyPa> AccessibilityTariffbyPas { get; set; }
        public virtual ICollection<SessionPeriod> SessionPeriods { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }

        public virtual ICollection<DictRegistrPrivilege> RegistrPrivileges { get; set; }
        public virtual ICollection<Terminal> Terminals { get; set; }
    }
}
