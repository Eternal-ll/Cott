namespace Cott.Site.Infrastructure.Services.Interfaces
{
    public interface IReportService
    {
        /// <summary>
        /// Отчет о количестве поездок СКБ
        /// </summary>
        /// <param name="month">Месяц отчётного периода</param>
        /// <param name="year">Год отчётного периода</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<SkbTripsReportModel> GetSkbTripsReport(int month, int year, long[] organizations, long[] regPriviliges, long[] priviliges
            , CancellationToken cancellationToken);
    }
}
