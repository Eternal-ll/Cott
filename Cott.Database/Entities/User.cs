namespace Cott.Database.Entities
{
    public partial class User
    {
        public User()
        {
            TpBrscLogs = new HashSet<TpBrscLog>();
            UserRoles = new HashSet<UserRole>();
        }

        public int Id { get; set; }
        public string Fio { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }

        public virtual ICollection<TpBrscLog> TpBrscLogs { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
