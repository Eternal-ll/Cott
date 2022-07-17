namespace Cott.Database.Entities
{
    public partial class TerminalsPp
    {
        public string Area { get; set; }
        public string TerminalHolder { get; set; }
        public string Content { get; set; }
        public long? ParentId { get; set; }
        public long Id { get; set; }
    }
}
