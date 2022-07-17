namespace Cott.Database.Entities
{
    public partial class Aorg
    {
        public Aorg()
        {
            AccessibilityTariffbyPas = new HashSet<AccessibilityTariffbyPa>();
            Cards = new HashSet<Card>();
            HumanAorgRegistrations = new HashSet<HumanAorgRegistration>();
            InverseParent = new HashSet<Aorg>();
        }

        public long Id { get; set; }
        public long? ParentId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Updated { get; set; }
        public long Status { get; set; }

        public virtual Aorg Parent { get; set; }
        public virtual ICollection<AccessibilityTariffbyPa> AccessibilityTariffbyPas { get; set; }
        public virtual ICollection<Card> Cards { get; set; }
        public virtual ICollection<HumanAorgRegistration> HumanAorgRegistrations { get; set; }
        public virtual ICollection<Aorg> InverseParent { get; set; }
    }
}
