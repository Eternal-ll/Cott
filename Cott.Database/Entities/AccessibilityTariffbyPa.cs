namespace Cott.Database.Entities
{
    public partial class AccessibilityTariffbyPa
    {
        public long AorgId { get; set; }
        public long TariffPpid { get; set; }
        public long AreaId { get; set; }

        public virtual Aorg Aorg { get; set; }
        public virtual PopulatedArea Area { get; set; }
        public virtual DictTarifPp TariffPp { get; set; }
    }
}
