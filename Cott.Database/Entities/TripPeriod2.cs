namespace Cott.Database.Entities
{
    public partial class TripPeriod2
    {
        public long Id { get; set; }
        public long? FileUploadId { get; set; }
        public long? TerminalHolderId { get; set; }
        public long TerminalId { get; set; }
        public long? AorgId { get; set; }
        public long? CatCardHolderId { get; set; }
        public long? CardId { get; set; }
        public long? StopCardId { get; set; }
        public long? CatTarifId { get; set; }
        public long? CarriageClassId { get; set; }
        public long? RouteId { get; set; }
        public long? BeginStationId { get; set; }
        public long? EndStationId { get; set; }
        public decimal? Cost { get; set; }
        public long? ExternalId { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Created { get; set; }

        public virtual Card Card { get; set; }
        public virtual FileUpload FileUpload { get; set; }
        public virtual BlackList StopCard { get; set; }
        public virtual Terminal Terminal { get; set; }
    }
}
