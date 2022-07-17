namespace Cott.Database.Entities
{
    public partial class StopListFile
    {
        public long Id { get; set; }
        public string FileName { get; set; }
        public DateTime Updated { get; set; }
        public int? CountBlocked { get; set; }
        public int? CountUnblocked { get; set; }
        public int? Amount { get; set; }
        public long Agent { get; set; }
    }
}
