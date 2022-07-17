namespace Cott.Database.Entities
{
    public partial class Human
    {
        public Human()
        {
            HumanAorgRegistrations = new HashSet<HumanAorgRegistration>();
        }

        public long Id { get; set; }
        public string Content { get; set; }
        public long Status { get; set; }

        public virtual ICollection<HumanAorgRegistration> HumanAorgRegistrations { get; set; }
    }
}
