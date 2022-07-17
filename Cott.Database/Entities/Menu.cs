namespace Cott.Database.Entities
{
    public partial class Menu
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public int? OrderId { get; set; }
        public int? MenuType { get; set; }
        public int? Active { get; set; }
    }
}
