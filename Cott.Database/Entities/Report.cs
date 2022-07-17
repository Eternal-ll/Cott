namespace Cott.Database.Entities
{
    public partial class Report
    {
        public int Id { get; set; }
        public DateTime ClosingMonth { get; set; }
        public DateTime Closed { get; set; }
        public int UserId { get; set; }
        public int Stage { get; set; }
    }
}
