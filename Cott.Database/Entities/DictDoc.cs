namespace Cott.Database.Entities
{
    public partial class DictDoc
    {
        public DictDoc()
        {
            CardHolderPrivileges = new HashSet<CardHolderPrivilege>();
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public virtual ICollection<CardHolderPrivilege> CardHolderPrivileges { get; set; }
    }
}
