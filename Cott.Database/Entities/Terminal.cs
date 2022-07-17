namespace Cott.Database.Entities
{
    public partial class Terminal
    {
        public Terminal()
        {
            SessionPeriods = new HashSet<SessionPeriod>();
            Sessions = new HashSet<Session>();
            TripPeriod2s = new HashSet<TripPeriod2>();
            TripPeriods = new HashSet<TripPeriod>();
            Trips = new HashSet<Trip>();
            Tariffs = new HashSet<DictTarifPp>();
        }

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
        public DateTime Created { get; set; }
        public long? ExternalId { get; set; }
        public DateTime Updated { get; set; }
        public long Status { get; set; }

        public virtual TerminalHolder Agent { get; set; }
        public virtual PopulatedArea Area { get; set; }
        public virtual ICollection<SessionPeriod> SessionPeriods { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
        public virtual ICollection<TripPeriod2> TripPeriod2s { get; set; }
        public virtual ICollection<TripPeriod> TripPeriods { get; set; }
        public virtual ICollection<Trip> Trips { get; set; }

        public virtual ICollection<DictTarifPp> Tariffs { get; set; }
    }
}
