namespace Cott.Database.Entities
{
    public partial class Privilege
    {
        public Privilege()
        {
            CardHolderPrivileges = new HashSet<CardHolderPrivilege>();
        }

        public long Id { get; set; }
        public long? RegistrPrivilegesId { get; set; }
        public int Code { get; set; }
        public string Title { get; set; }

        public virtual DictRegistrPrivilege RegistrPrivileges { get; set; }
        public virtual ICollection<CardHolderPrivilege> CardHolderPrivileges { get; set; }
    }
}
