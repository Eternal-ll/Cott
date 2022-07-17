namespace Cott.Database.Entities
{
    public partial class TripUnknownTerminal
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public int? BatIdTransHolder { get; set; }
        public int? BatIdSub { get; set; }
        public string Fnumber { get; set; }
        public int? Ammount { get; set; }
        public DateTime? Updated { get; set; }
    }
}
