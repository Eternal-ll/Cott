namespace Cott.Database.Entities
{
    public partial class HumanAorgRegistration
    {
        public HumanAorgRegistration()
        {
            Cards = new HashSet<Card>();
        }

        public string Sn { get; set; }
        public long AorgId { get; set; }
        public long? HumanId { get; set; }
        public long AreaId { get; set; }
        public string Content { get; set; }
        public DateTime Updated { get; set; }

        public virtual Aorg Aorg { get; set; }
        public virtual PopulatedArea Area { get; set; }
        public virtual Human Human { get; set; }
        public virtual ICollection<Card> Cards { get; set; }
    }
}
