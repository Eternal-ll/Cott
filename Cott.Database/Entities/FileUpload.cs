namespace Cott.Database.Entities
{
    public partial class FileUpload
    {
        public FileUpload()
        {
            TripPeriod2s = new HashSet<TripPeriod2>();
            TripPeriods = new HashSet<TripPeriod>();
            Trips = new HashSet<Trip>();
        }

        public long Id { get; set; }
        public long TerminalId { get; set; }
        public string FileName { get; set; }
        public DateTime Updated { get; set; }

        public virtual ICollection<TripPeriod2> TripPeriod2s { get; set; }
        public virtual ICollection<TripPeriod> TripPeriods { get; set; }
        public virtual ICollection<Trip> Trips { get; set; }
    }
}
