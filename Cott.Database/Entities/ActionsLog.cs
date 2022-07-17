namespace Cott.Database.Entities
{
    public partial class ActionsLog
    {
        public long Id { get; set; }
        public DateTime Updated { get; set; }
        public string ChipNumber { get; set; }
        public string TableName { get; set; }
        public string Action { get; set; }
        public string Description { get; set; }
    }
}
