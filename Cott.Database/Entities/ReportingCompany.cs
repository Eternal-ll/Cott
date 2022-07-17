namespace Cott.Database.Entities
{
    public partial class ReportingCompany
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ParentId { get; set; }
        public string OwnerFio { get; set; }
        public string OwnerFiogenitive { get; set; }
        public int? PostId { get; set; }
        public short Rate { get; set; }
        public int DocId { get; set; }
        public short ContractNum { get; set; }
        public DateTime? FirstSecondReport { get; set; }
    }
}
