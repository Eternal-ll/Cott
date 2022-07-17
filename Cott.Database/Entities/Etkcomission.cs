namespace Cott.Database.Entities
{
    public partial class Etkcomission
    {
        public int Id { get; set; }
        public long? PaymentId { get; set; }
        public decimal? RealSum { get; set; }
        public decimal? Comis { get; set; }
        public decimal? ComisSum { get; set; }
        public decimal? AdditSum { get; set; }
        public DateTime? Updated { get; set; }

        public virtual Session Payment { get; set; }
    }
}
