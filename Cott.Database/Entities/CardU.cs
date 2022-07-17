namespace Cott.Database.Entities
{
    public partial class CardU
    {
        public string ChipNumber { get; set; }
        public long? RegistrPrivilegesId { get; set; }
        public long? TariffPpid { get; set; }
        public long Id { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
    }
}
