namespace Cott.Database.Entities
{
    public partial class BlackList
    {
        public BlackList()
        {
            TripPeriod2s = new HashSet<TripPeriod2>();
            TripPeriods = new HashSet<TripPeriod>();
            Trips = new HashSet<Trip>();
        }

        public long Id { get; set; }
        public string ChipNumber { get; set; }
        public long Status { get; set; }
        public DateTime Created { get; set; }

        public virtual ICollection<TripPeriod2> TripPeriod2s { get; set; }
        public virtual ICollection<TripPeriod> TripPeriods { get; set; }
        public virtual ICollection<Trip> Trips { get; set; }
    }
}
