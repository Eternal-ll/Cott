using Cott.Database.Context;
using Cott.Site.Infrastructure.Services;
using Cott.Site.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cott.Site.Controllers
{
    public class ReportsController : Controller
    {
        private readonly CottContext Context;
        private readonly IServiceProvider ServiceProvider;
        public ReportsController(CottContext context, IServiceProvider serviceProvider)
        {
            Context = context;
            ServiceProvider = serviceProvider;
        }
        
        private IReportService GetReportService(string output) => output switch
        {
            "Word" => ServiceProvider.GetService<WordReportService>(),
            "Excel" => ServiceProvider.GetService<ExcelReportService>(),
            _ => throw new NotImplementedException(),
        };

        public IActionResult Index() => View();

        [HttpPost]
        public async Task<IActionResult> ReportSKBTripsToFile(int month, int year, long[] organizations, long[] regPriviliges, long[] priviliges,
            CancellationToken cancellationToken)
        {
            // Планировался целенаправленный отчёт по типу выходного файла,
            // но я решил сделать один универсальный отчёт, который можно будет сохранить
            // в разных форматах
            //if (string.IsNullOrWhiteSpace(output)) return null;
            IReportService service = GetReportService("Word");
            var data = await service.GetSkbTripsReport(month, year, organizations, regPriviliges, priviliges, cancellationToken);
            
            #region Тестовые данные, когда нету локальной БД =/
            // data = new SkbTripsReportModel()
            //{
            //    Elapsed = data.Elapsed,
            //    Created = data.Created,
            //    Total = new TypedTripsReportModel()
            //    {
            //        IncomeByThemselves = 123,
            //        IncomeSupportedByRespublicBashkortostan = 234,
            //        IncomeSupportedByRussianFederation = 356534,
            //        IncomeTotal = 35345245,
            //        TransportedBySupportOfRespublicBashkortostan = 5435435,
            //        TransportedBySupportOfRussianFederation = 425245,
            //        TransportedTotal = 54354225,
            //        TransportedByThemselves = 254353
            //    },
            //    Data = new()
            //    {
            //        {
            //            0,
            //            new()
            //            {
            //                Data = new Dictionary<int, TypedTripsReportModel>()
            //            {
            //                { 0, new TypedTripsReportModel()
            //                    {
            //                        IncomeByThemselves = 123,
            //                        IncomeSupportedByRespublicBashkortostan = 234,
            //                        IncomeSupportedByRussianFederation = 356534,
            //                        IncomeTotal = 35345245,
            //                        TransportedBySupportOfRespublicBashkortostan = 5435435,
            //                        TransportedBySupportOfRussianFederation = 425245,
            //                        TransportedTotal = 54354225,
            //                        TransportedByThemselves = 254353
            //                    } },
            //                { 1, new TypedTripsReportModel()
            //                    {
            //                        IncomeByThemselves = 123,
            //                        IncomeSupportedByRespublicBashkortostan = 234,
            //                        IncomeSupportedByRussianFederation = 356534,
            //                        IncomeTotal = 35345245,
            //                        TransportedBySupportOfRespublicBashkortostan = 5435435,
            //                        TransportedBySupportOfRussianFederation = 425245,
            //                        TransportedTotal = 54354225,
            //                        TransportedByThemselves = 254353
            //                    } }
            //            },
            //                TotalData = new TypedTripsReportModel()
            //                {
            //                    IncomeByThemselves = 123,
            //                    IncomeSupportedByRespublicBashkortostan = 234,
            //                    IncomeSupportedByRussianFederation = 356534,
            //                    IncomeTotal = 35345245,
            //                    TransportedBySupportOfRespublicBashkortostan = 5435435,
            //                    TransportedBySupportOfRussianFederation = 425245,
            //                    TransportedTotal = 54354225,
            //                    TransportedByThemselves = 254353
            //                }
            //            }
            //        },
            //        {
            //            1,
            //            new()
            //            {
            //                Data = new Dictionary<int, TypedTripsReportModel>()
            //            {
            //                { 0, new TypedTripsReportModel()
            //                    {
            //                        IncomeByThemselves = 123,
            //                        IncomeSupportedByRespublicBashkortostan = 234,
            //                        IncomeSupportedByRussianFederation = 356534,
            //                        IncomeTotal = 35345245,
            //                        TransportedBySupportOfRespublicBashkortostan = 5435435,
            //                        TransportedBySupportOfRussianFederation = 425245,
            //                        TransportedTotal = 54354225,
            //                        TransportedByThemselves = 254353
            //                    } },
            //                { 1, new TypedTripsReportModel()
            //                    {
            //                        IncomeByThemselves = 123,
            //                        IncomeSupportedByRespublicBashkortostan = 234,
            //                        IncomeSupportedByRussianFederation = 356534,
            //                        IncomeTotal = 35345245,
            //                        TransportedBySupportOfRespublicBashkortostan = 5435435,
            //                        TransportedBySupportOfRussianFederation = 425245,
            //                        TransportedTotal = 54354225,
            //                        TransportedByThemselves = 254353
            //                    } }
            //            },
            //                TotalData = new TypedTripsReportModel()
            //                {
            //                    IncomeByThemselves = 123,
            //                    IncomeSupportedByRespublicBashkortostan = 234,
            //                    IncomeSupportedByRussianFederation = 356534,
            //                    IncomeTotal = 35345245,
            //                    TransportedBySupportOfRespublicBashkortostan = 5435435,
            //                    TransportedBySupportOfRussianFederation = 425245,
            //                    TransportedTotal = 54354225,
            //                    TransportedByThemselves = 254353
            //                }
            //            }
            //        }
            //    }
            //}; 
            #endregion

            return View("Test", data);
        }
        public async Task<IActionResult> TestOne() => View("TestOne", await Context.Trips
                .Include(t => t.Card)
                .ThenInclude(c => c.CardHolderPrivileges)
            .Take(100000)
            .ToListAsync());
        public IActionResult TestTwo() => View("TestOne", Context.Trips
                .Include(t => t.Card)
                .ThenInclude(c => c.CardHolderPrivileges)
            .Take(100000)
            .ToList());
    }
}
