namespace Cott.Database.Entities
{
    public partial class CardHolderPrivilege
    {
        public long Id { get; set; }
        public long CardId { get; set; }
        public long PrivilegesId { get; set; }
        public long? DocId { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public string DocNumber { get; set; }
        public string DocSeria { get; set; }

        public virtual Card Card { get; set; }
        public virtual DictDoc Doc { get; set; }
        public virtual Privilege Privileges { get; set; }
    }
}
