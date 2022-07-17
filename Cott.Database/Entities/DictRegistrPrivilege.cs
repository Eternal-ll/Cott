namespace Cott.Database.Entities
{
    public partial class DictRegistrPrivilege
    {
        public DictRegistrPrivilege()
        {
            Privileges = new HashSet<Privilege>();
            TariffPps = new HashSet<DictTarifPp>();
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }

        public virtual ICollection<Privilege> Privileges { get; set; }

        public virtual ICollection<DictTarifPp> TariffPps { get; set; }
    }
}
