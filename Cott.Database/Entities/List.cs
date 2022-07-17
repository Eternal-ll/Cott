namespace Cott.Database.Entities
{
    public partial class List
    {
        public string Подразделение { get; set; }
        public string НомерКарты { get; set; }
        public string Чип { get; set; }
        public DateTime? ДатаТранзакции { get; set; }
        public string ВремяТранзакции { get; set; }
        public string ТипОперации { get; set; }
        public double? СуммаПополнения { get; set; }
        public DateTime? ПродленДо { get; set; }
        public string СерияКарты { get; set; }
        public string НоваяСерияКарты { get; set; }
        public string ДатаИВремяДобавленияВБд { get; set; }
        public string _ { get; set; }
    }
}
