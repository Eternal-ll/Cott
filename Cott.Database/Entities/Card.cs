namespace Cott.Database.Entities
{
    public partial class Card
    {
        public Card()
        {
            CardHolderPrivileges = new HashSet<CardHolderPrivilege>();
            SessionPeriods = new HashSet<SessionPeriod>();
            Sessions = new HashSet<Session>();
            TpBrscLogs = new HashSet<TpBrscLog>();
            TripPeriod2s = new HashSet<TripPeriod2>();
            TripPeriods = new HashSet<TripPeriod>();
            Trips = new HashSet<Trip>();
        }

        public long Id { get; set; }
        public long AorgId { get; set; }
        public string Sn { get; set; }
        public long? AccountId { get; set; }
        public string ChipNumber { get; set; }
        public string CardNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public long Status { get; set; }

        public virtual Aorg Aorg { get; set; }
        public virtual HumanAorgRegistration HumanAorgRegistration { get; set; }
        public virtual ICollection<CardHolderPrivilege> CardHolderPrivileges { get; set; }
        public virtual ICollection<SessionPeriod> SessionPeriods { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
        public virtual ICollection<TpBrscLog> TpBrscLogs { get; set; }
        public virtual ICollection<TripPeriod2> TripPeriod2s { get; set; }
        public virtual ICollection<TripPeriod> TripPeriods { get; set; }
        public virtual ICollection<Trip> Trips { get; set; }
    }
}
