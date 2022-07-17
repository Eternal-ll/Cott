namespace Cott.Database.Entities
{
    public partial class TempUitMy
    {
        public string Id { get; set; }
        public string TrcId { get; set; }
        public string Ttype { get; set; }
        public string TtypeDesc { get; set; }
        public string TrmId { get; set; }
        public string TrmSn { get; set; }
        public string LongPan { get; set; }
        public string Sn { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public DateTime? Updated { get; set; }
        public string RouteNum { get; set; }
        public string Prtype { get; set; }
        public string Tarif { get; set; }
        public string CrDate { get; set; }
        public string CrTime { get; set; }
        public string AddSvc { get; set; }
    }
}
