namespace Cott.Database.Entities
{
    public partial class TechnicalTransferCardError
    {
        public int Id { get; set; }
        public string ChipCardIn { get; set; }
        public string ChipCardFrom { get; set; }
        public string Binary4In { get; set; }
        public string Binary4From { get; set; }
        public string Opt { get; set; }
        public string Oper { get; set; }
        public string Comment { get; set; }
        public string Error { get; set; }
        public string IdRefill { get; set; }
    }
}
