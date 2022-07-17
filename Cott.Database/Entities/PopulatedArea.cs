namespace Cott.Database.Entities
{
    public partial class PopulatedArea
    {
        public PopulatedArea()
        {
            AccessibilityTariffbyPas = new HashSet<AccessibilityTariffbyPa>();
            HumanAorgRegistrations = new HashSet<HumanAorgRegistration>();
            TerminalHolders = new HashSet<TerminalHolder>();
            Terminals = new HashSet<Terminal>();
        }

        public long Id { get; set; }
        public long? ParentId { get; set; }
        public long TypeArea { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Kladr { get; set; }

        public virtual ICollection<AccessibilityTariffbyPa> AccessibilityTariffbyPas { get; set; }
        public virtual ICollection<HumanAorgRegistration> HumanAorgRegistrations { get; set; }
        public virtual ICollection<TerminalHolder> TerminalHolders { get; set; }
        public virtual ICollection<Terminal> Terminals { get; set; }
    }
}
