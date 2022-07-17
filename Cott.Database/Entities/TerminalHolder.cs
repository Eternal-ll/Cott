namespace Cott.Database.Entities
{
    public partial class TerminalHolder
    {
        public TerminalHolder()
        {
            TerminalHolderTypes = new HashSet<TerminalHolderType>();
            Terminals = new HashSet<Terminal>();
        }

        public long Id { get; set; }
        public long? ParentId { get; set; }
        public long TypeHolder { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public long? ExternalId { get; set; }
        public DateTime Updated { get; set; }
        public long Status { get; set; }
        public long? AreaId { get; set; }

        public virtual PopulatedArea Area { get; set; }
        public virtual ICollection<TerminalHolderType> TerminalHolderTypes { get; set; }
        public virtual ICollection<Terminal> Terminals { get; set; }
    }
}
