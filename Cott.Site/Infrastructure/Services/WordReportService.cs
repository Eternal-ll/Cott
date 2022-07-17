using Cott.Database.Context;
using Cott.Site.Infrastructure.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Cott.Site.Infrastructure.Services
{
    public class SkbTripsReportModel
    {
        public DateTime Created { get; set; }
        public Dictionary<long, OrganizationTripsReportModel> Data { get; set; } = new();
        public string Query { get; set; }
        public TypedTripsReportModel Total { get; set; } = new();
        public TimeSpan Elapsed { get; set; }
    }
    public class OrganizationTripsReportModel
    {
        /// <summary>
        /// № пп
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// Наименование организации
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Наименование транспортной организации
        /// </summary>
        public string Name { get; set; }
        public Dictionary<long, TypedTripsReportModel> Data { get; set; } = new();
        public TypedTripsReportModel TotalData { get; set; } = new();
    }
    public class TypedTripsReportModel
    {
        public int OrganizationIdId { get; set; }
        public long CarriageClassId { get; set; }
        public string TypeName { get; set; }

        #region Количество перевезенных держателей Социальной карты Башкортостана
        /// <summary>
        /// Общее количество перевезенных держателей Социальной карты Башкортостана, человек
        /// </summary>
        public long TransportedTotal { get; set; }
        /// <summary>
        /// в отношении которых оказание мер социальной поддержки относится к ведению Российской Федерации
        /// </summary>
        public long TransportedBySupportOfRussianFederation { get; set; }
        /// <summary>
        /// в отношении которых оказание мер социальной поддержки относится к ведению Республики Башкортостан
        /// </summary>
        public long TransportedBySupportOfRespublicBashkortostan { get; set; }
        /// <summary>
        /// пенсионеров, не включенных в федеральный и региональный регистры
        /// </summary>
        public long TransportedByThemselves { get; set; }
        #endregion

        #region Сумма выпадающих доходов
        /// <summary>
        /// Общая сумма выпадающих доходов, тыс. рублей
        /// </summary>
        public decimal IncomeTotal { get; set; }
        /// <summary>
        /// в отношении которых оказание мер социальной поддержки относится к ведению Российской Федерации
        /// </summary>
        public decimal IncomeSupportedByRussianFederation { get; set; }
        /// <summary>
        /// в отношении которых оказание мер социальной поддержки относится к ведению Республики Башкортостан
        /// </summary>
        public decimal IncomeSupportedByRespublicBashkortostan { get; set; }
        /// <summary>
        /// пенсионеров, не включенных в федеральный и региональный регистры
        /// </summary>
        public decimal IncomeByThemselves { get; set; }
        #endregion
    }
    public class WordReportService : IReportService
    {
        private readonly CottContext Context;
        private readonly ILogger Logger;

        public WordReportService(CottContext context, ILogger<WordReportService> logger)
        {
            Context = context;
            Logger = logger;
        }

        public async Task<SkbTripsReportModel> GetSkbTripsReport(int month, int year, long[] organizations, long[] regPriviliges, long[] priviliges
            , CancellationToken cancellationToken)
        {
            var context = Context;
            var templatePath = Environment.CurrentDirectory + @"\Resources\Reports\Templates\template1.xls";
            if (!File.Exists(templatePath))
            {
                return null;
            }
            var from = new DateTime(year, month, 1);
            var to = from.AddMonths(1);
            // and(Created < (select top 1 closed from Report where closingMonth < Updated order by closingMonth desc))

            // я пока не понял, это последний закрывающийся отчёт на основе которого идёт поиск...
            // !!! Неиспользуется
            var closingReport = await context.Reports
                //.Select(r => r.Closed)
                .Where(r => r.ClosingMonth < from)
                .OrderByDescending(r => r.ClosingMonth)
                .FirstOrDefaultAsync(cancellationToken);

            #region [DictRegistrPrivileges]
            /* DictRegistrPrivileges
             * 1	Фед	000
             * 2	Рег	001
             * 3	Пенс	010
             * 4	БезЛьгот	100
             * 6	Муниципал	110
             * 7	Тестовый	 999
             * 8	Тестовый Почта России	998
             * 9	МВД	101
             * 10	Школьник Стерлитамак	111
             * 11	Сотрудник школы Стерлитамак	222
             * 12	Универсальная карта Стерлитамака	333
             * 13	Без льготы	444
             * 14	Дети-сироты	555
             * 15	Беженцы	666
             * 
             */
            #endregion

            #region [Privileges]
            /*
             * 1	1	 82	инвалиды (II степень)
             * 2	2	523	Ветеран труда - вкладыш в пенсионное удостоверение
             * 3	1	 81	инвалиды (I степень)
             * 4	3	545	Пенсионеры (не льготники)
             * 5	2	521	Ветераны труда
             * 6	4	580	Многодетные семьи (30% льгота)
             * 7	1	 60	Члены семей погибших (умер) инв.,участ.ВОВ и вет.б/дейс
             * 8	2	510	Труженики тыла
             * 9	1	 83	инвалиды (III степень)
             * 10	1	 85	Инвалид без степени
             * 11	4	570	Квалифицированные работники сельской местности
             * 12	1	 20	Участники Великой Отечественной
             * 13	1	150	Бывшие несовершеннолетние узники концлагерей
             * 14	2	524	Ветераны военной службы (силовых ведомств)
             * 15	1	 84	дети-инвалиды
             * 16	1	 62	Члены семей погибших при исполнении МО,МВД,ФСБ,ГПЖС,др.
             * 17	2	522	Ветеран труда субъекта РФ
             * 18	1	140	Бывшие несовершеннолетние узники концлагерей - инвалиды
             * 19	1	 11	Участники Великой Отечественной войны, ставшие инвалидами
             * 20	2	531	Репрессированные
             * 21	2	532	Пострадавшие от политических репрессий
             * 22	4	585	Многодет.семьи с 4 и более дет.,прож. в сель.м(100%)
             * 23	4	601	Семьи,умер.уч.ЛПА на ЧАЭС в 86-87г.и в 88-90 об.Укрытие
             * 24	1	128	Гражд., эвакуир.в 1957г. "Маяк"
             * 25	1	 10	Инвалиды войны
             * 26	1	 50	Житель блокадного Ленинграда
             * 27	1	 30	Ветераны боевых действий
             * 28	1	 93	Участники ЛПА,на ЧАЭС в 86-87г.и в 88-90г.об."Укрытие"
             * 29	1	131	Граждане из подразделений особого риска, не имеющие инвалидности
             * 30	1	 12	В/сл МО,МВД,ФСБ,ГПЖС,ставшие инвалидами при исполнении
             * 31	1	 40	Военнослужащие не менее 6 мес
             * 32	4	560	Заслуженный работник отрасли
             * 33	1	132	Граждане из подразделений особого риска, имеющие инвалидность
             * 34	1	 91	Гражд., получ. луч. болезнь или др. забол. (ЧАЭС)
             * 35	1	 92	Инвалиды вследствие ЧАЭС
             * 36	1	 70	Герои СССР, РФ, Соц.
             * 37	4	 61	Члены семей погибших участников самозащиты
             * 38	1	123	ЛПА на"Маяк"в 57-58г.и гражд.,занят,на раб.Теча в 49-56
             * 39	4	602	Семьи погиб,на ЧАЭС,умерших всл.луч.бол.,др.ум.инв.ЧАЭС
             * 40	1	120	Работал в ВОВ на военных объектах
             * 41	4	603	Семьи граждан,получив,луч.и др.заболев.(смерть от Маяк)
             * 42	4	605	Семьи,потер.кормильца из числа гр.из подр.особ.риска
             * 43	1	100	Дети до 18 лет, проживающие в зоне с льготным социально-экономическим
             * 44	1	 98	Граждане, эвакуир. из зоны отчуждения ЧАЭС
             * 45	1	129	Дети первого и второго поколения, страдающие заболеваниями вследствие воздействия радиации на родителей
             * 46	4	590	Приемные семьи
             * 47	4	 63	Члены семей в/служащих, погибших в плену
             * 48	1	 94	Граждане в т.ч.военнослужащи,приним.в 88-90 гг.уч.в работах в зоне отчуждения на ЧАЭС
             * 49	1	124	Граждане в т.ч.воен­нослужащие, принимавшие в 59-61 участие в ликвидации последствий аварии в 57 "Маяк"
             * 50	1	 96	Граждане, постоянно проживающие (работающие) на территории зоны проживания с льготным социально-экономическим статусом
             * 51	1	141	Раб.,служ.,военносл.,получив,проф.заболев.вследс.ЧАЭС
             * 52	1	 95	Граждане, постоянно проживающие (рабо­тающие) на территории зоны проживания с правом на отселение
             * 53	1	125	Граждане в т.ч.воен­нослужащие, принимавшие в 59-61 участие в ликвидации последствий аварии в 57 "Маяк"
             * 54	1	111	Граждане, получившие суммарную дозу облучения, превышающую 25 сЗв (бэр)
             * 55	1	606	Гражд., получив. дозу обл. более 25 бэр (Семипал.)
             * 56	4	604	Семьи инвалидов "Маяк", если смерть от "Маяк"
             * 58	1	121	Гражд, получ. луч. бол и др. забол. (Маяк)
             * 59	4	996	Граждане, не имеющие льгот
             * 62	6	997	Учащийся
             * 63	6	998	Студент
             * 64	6	999	Аспирант
             * 65	7	1000 Для тестовых карт
             * 66	4	604	Семьи инвалидов "Маяк", если смерть от "Маяк"
             * 73	1	606	Гражд., получив. дозу обл. более 25 бэр (Семипал.)
             * 74	4	607	Получатели субсидий на оплату жилых помещений и коммунальных услуг
             * 76	4	608	Граждане, оказавшиеся в трудной жизненной ситуации - получатели
             * 77	4	609	Граждане при возникновении у них поствакцинальных осложнений -
             * 78	4	610	Неработающие лица, осуществляющие уход за ребенком - получатели
             * 79	4	611	Матери, уволенные в связи с ликвидацией организаций - получатели
             * 80	4	612	Законные представители детей погибших в/служащих - получатели
             * 81	4	613	Почетные доноры - получатели ежемесячной денежной выплаты
             * 82	4	614	Мать ребенка в/служащего, опекун ребенка в/служащего, проходящего
             * 83	4	615	Женщины, имеющие детей в возрасте до 3-х лет, уволенные в связи с
             * 84	4	616	Члены семей погибших (умерших) в/служащих - получатели
             * 85	4	617	Законные представители детей из малоимущих семей - получатели
             * 86	4	618	Лица, осуществляющие уход за ребенком-инвалидом до 18 лет -
             * 87	4	619	Семьи, проживающие в сельской местности, при рождении ребенка -
             * 89	4	620	Малоимущие граждане - получатели социального пособия
             * 90	2	525	Ветеран труда, имеющий продолжительный стаж работы
             * 91	8	995	Сотрудник МВД
             * 92	6	994	Учащийся г.Стерлитамак
             * 93	1	122	Инвалиды вследствие аварии на "Маяк"
             * 94	1	142	Рабочие,служ.,в/служ.,ставшие инвалидами вслед.ЧАЭС
             * 95	3	703	Временная карта БРСК
             * 96	7	1001 Для тестовых карт (Почта России)
             * 97	3	704	Пилотные карты
             * 98	3	705	льгота для актуализации
             * 99	10	993	Карта школьника Стерлитамак
             * 100	11	996	Карта сотрудника школы Стерлитамак
             * 101	12	2000 Универсальная карта Стерлитамака
             * 102	13	3000 Без льготы
             * 103	14	10001 Дети-сироты и дети, оставшиеся без попечения родителей
             * 104	14	10002 Лица из числа детей-сирот и детей, оставшихся без попечения родителей
             * 105	14	10003 Лица, потерявшие в период обучения обоих или единственного родителя
             * 110	15	20003 Беженцы
             */
            #endregion

            /*
             * @Org  @Fix
             *   1    18    МУП Управление инфраструктурой транспорта городского округа г. Уфа РБ
             *  12    12    МУП «Стерлитамакское троллейбусное управление» городского округа город Стерлитамак РБ
             *  11    15    МУП «Трамвайное управление» городского округа город Салават РБ
             *  60    20    МБУ "Служба речных переправ г. Уфы"
             *   6    20    ГУП «Башавтотранс» РБ
             * 113    20    ООО «ТрансСпецСервис»
             * 
             * , где @Org = TerminalHolderID
             */

            // Хардкод нужных параметров
            //var requiredOrganizations = new long[]
            //{
            //    1,12,11,60,6,113
            //};
            //var requiredPriviliges = new long[]
            //{
            //    99,100,102,103,104,105
            //};
            //var requiredRegisterPriviliges = new long[]
            //{
            //    1, 2, 3, 4, 8
            //};
            var terminalsHolders = await context.TerminalHolders
                .Where(th => organizations.Contains(th.Id))
                .ToArrayAsync();

            var query = context.Trips
                .Include(t => t.Card)
                .ThenInclude(c => c.CardHolderPrivileges)
                .Where(trip =>
                    trip.Updated > from &&
                    trip.Updated < to &&
                    trip.Created > from && trip.TerminalHolderId.HasValue &&
                    organizations.Contains(trip.TerminalHolderId.Value) &&
                    !priviliges.Contains(trip.Card.CardHolderPrivileges.First().Id) &&
                    regPriviliges.Contains(trip.Card.CardHolderPrivileges.First().PrivilegesId)
                    )
                .Select(trip => new
                {
                    trip.TerminalHolderId,
                    trip.Cost,
                    trip.CarriageClassId,
                    RegistrPrivilegesID = trip.Card.CardHolderPrivileges.Select(ch => ch.PrivilegesId).FirstOrDefault(),
                })
                .AsNoTracking()
                .ToQueryString();

            Dictionary<long, OrganizationTripsReportModel> dic = new();
            Stopwatch sw = new();
            sw.Start();
            await context.Trips
                .Include(t => t.Card)
                .ThenInclude(c => c.CardHolderPrivileges)
                .Where(trip =>
                    trip.Updated > from &&
                    trip.Updated < to &&
                    trip.Created > from && trip.TerminalHolderId.HasValue &&
                    organizations.Contains(trip.TerminalHolderId.Value) &&
                    !priviliges.Contains(trip.Card.CardHolderPrivileges.First().Id) &&
                    regPriviliges.Contains(trip.Card.CardHolderPrivileges.First().PrivilegesId)
                    )
                .Select(trip => new
                {
                    trip.TerminalHolderId,
                    trip.Cost,
                    trip.CarriageClassId,
                    RegistrPrivilegesID = trip.Card.CardHolderPrivileges.Select(ch => ch.PrivilegesId).FirstOrDefault(),
                })
                .AsNoTracking()
                // Каждая запись обрабатывается в соответствие с требуемой логикой одним запросом
                // немного хардкод, требует оптимизации
                .ForEachAsync(trip =>
                {
                    // если мы ещё не обработали чек с определенной компанией, создаём под неё модель
                    if (!dic.TryGetValue(trip.TerminalHolderId.Value, out OrganizationTripsReportModel model))
                    {
                        model = new()
                        {
                            Id = trip.TerminalHolderId.Value
                        };
                        dic[trip.TerminalHolderId.Value] = model;
                    }
                    // Если у чека нету категории транспорта?
                    if (!trip.CarriageClassId.HasValue)
                    {
                        // то мы заполняем общую статистику компании
                        switch (trip.RegistrPrivilegesID)
                        {
                            case 1:
                                model.TotalData.IncomeSupportedByRussianFederation += trip.Cost;
                                model.TotalData.TransportedBySupportOfRussianFederation++;
                                break;
                            case 2:
                                model.TotalData.IncomeSupportedByRespublicBashkortostan += trip.Cost;
                                model.TotalData.TransportedBySupportOfRespublicBashkortostan++;
                                break;
                            case 3:
                            case 4:
                            case 8:
                                model.TotalData.IncomeByThemselves += trip.Cost;
                                model.TotalData.TransportedByThemselves++;
                                break;
                        }
                        model.TotalData.IncomeTotal += trip.Cost;
                        model.TotalData.TransportedTotal++;
                        return;
                    }
                    // иначе мы пытаемся взять модель категории чека и заполняем её статистику
                    if (!model.Data.TryGetValue(trip.CarriageClassId.Value, out var data))
                    {
                        data = new()
                        {
                            CarriageClassId = trip.CarriageClassId.Value,
                        };
                        model.Data[trip.CarriageClassId.Value] = data;
                    }
                    switch (trip.RegistrPrivilegesID)
                    {
                        case 1:
                            data.IncomeSupportedByRussianFederation += trip.Cost;
                            data.TransportedBySupportOfRussianFederation++;
                            break;
                        case 2:
                            data.IncomeSupportedByRespublicBashkortostan += trip.Cost;
                            data.TransportedBySupportOfRespublicBashkortostan++;
                            break;
                        case 3:
                        case 4:
                        case 8:
                            data.IncomeByThemselves += trip.Cost;
                            data.TransportedByThemselves++;
                            break;
                    }
                }, cancellationToken);
            var result = new SkbTripsReportModel()
            {
                Created = DateTime.Now,
                Data = dic,
                Query = query,
                Elapsed = sw.Elapsed
            };
            // хардкод, требует оптимизации
            foreach (var model in dic.Values)
            {
                model.Title = terminalsHolders.FirstOrDefault(th => th.Id == model.Id).Title;
                foreach (var data in model.Data.Values)
                {
                    data.TransportedTotal = data.TransportedByThemselves + data.TransportedBySupportOfRussianFederation + data.TransportedBySupportOfRussianFederation;
                    data.IncomeTotal = data.IncomeSupportedByRussianFederation + data.IncomeByThemselves + data.IncomeSupportedByRespublicBashkortostan;

                    model.TotalData.TransportedTotal += data.TransportedTotal;
                    model.TotalData.IncomeTotal += data.IncomeTotal;

                    model.TotalData.IncomeSupportedByRespublicBashkortostan += data.IncomeSupportedByRespublicBashkortostan;
                    model.TotalData.IncomeSupportedByRussianFederation += data.IncomeSupportedByRussianFederation;
                    model.TotalData.IncomeByThemselves += data.IncomeByThemselves;

                    model.TotalData.TransportedBySupportOfRespublicBashkortostan += data.TransportedBySupportOfRespublicBashkortostan;
                    model.TotalData.TransportedBySupportOfRussianFederation += data.TransportedBySupportOfRussianFederation;
                    model.TotalData.TransportedByThemselves += data.TransportedByThemselves;
                }
                result.Total.TransportedTotal += model.TotalData.TransportedTotal;
                result.Total.IncomeTotal += model.TotalData.IncomeTotal;

                result.Total.IncomeSupportedByRespublicBashkortostan += model.TotalData.IncomeSupportedByRespublicBashkortostan;
                result.Total.IncomeSupportedByRussianFederation += model.TotalData.IncomeSupportedByRussianFederation;
                result.Total.IncomeByThemselves += model.TotalData.IncomeByThemselves;

                result.Total.TransportedBySupportOfRespublicBashkortostan += model.TotalData.TransportedBySupportOfRespublicBashkortostan;
                result.Total.TransportedBySupportOfRussianFederation += model.TotalData.TransportedBySupportOfRussianFederation;
                result.Total.TransportedByThemselves += model.TotalData.TransportedByThemselves;
            }
            return result;
        }
    }
    public class ExcelReportService : IReportService
    {
        private readonly CottContext Context;

        public ExcelReportService(CottContext context)
        {
            Context = context;
        }

        public Task<SkbTripsReportModel> GetSkbTripsReport(int month, int year, long[] organizations, long[] regPriviliges, long[] priviliges
            , CancellationToken cancellationToken)
        {
            
            throw new NotImplementedException();
        }
    }
}
