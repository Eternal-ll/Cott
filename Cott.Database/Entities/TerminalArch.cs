namespace Cott.Database.Entities
{
    public partial class TerminalArch
    {
        public long Id { get; set; }
        public long? AreaId { get; set; }
        public long? AgentId { get; set; }
        public long? ModelId { get; set; }
        public long? SoftId { get; set; }
        public string Fnumber { get; set; }
        public string Password { get; set; }
        public string Ip { get; set; }
        public string Mac { get; set; }
        public long? TypeTerminal { get; set; }
        public string Content { get; set; }
        public DateTime? Created { get; set; }
        public long? ExternalId { get; set; }
        public DateTime? Updated { get; set; }
        public long? Status { get; set; }
    }
}
