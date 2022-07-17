namespace Cott.Database.Entities
{
    public partial class BlockCardPeriod
    {
        public int Id { get; set; }
        public int IdCard { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public long ChangeFrom { get; set; }
        public long? ChangeTo { get; set; }
        public int Done { get; set; }
        public DateTime DoneDate { get; set; }
        public string Comment { get; set; }
    }
}
