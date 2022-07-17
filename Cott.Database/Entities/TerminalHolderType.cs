namespace Cott.Database.Entities
{
    public partial class TerminalHolderType
    {
        public int Id { get; set; }
        public long IdHolder { get; set; }
        public int? Type { get; set; }
        public string ShortTitle { get; set; }

        public virtual TerminalHolder IdHolderNavigation { get; set; }
    }
}
