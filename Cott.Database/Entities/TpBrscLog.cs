namespace Cott.Database.Entities
{
    public partial class TpBrscLog
    {
        public int Id { get; set; }
        public long CardId { get; set; }
        public DateTime Updated { get; set; }
        public int UserId { get; set; }
        public string ValueBefore { get; set; }
        public string ValueAfter { get; set; }
        public string ColumnName { get; set; }
        public string TableName { get; set; }
        public long RowId { get; set; }
        public string CommentSystem { get; set; }
        public string CommentUser { get; set; }

        public virtual Card Card { get; set; }
        public virtual User User { get; set; }
    }
}
