namespace Cott.Database.Entities
{
    public partial class DicRole
    {
        public DicRole()
        {
            UserRoles = new HashSet<UserRole>();
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
