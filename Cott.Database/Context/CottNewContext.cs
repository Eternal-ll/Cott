using Microsoft.EntityFrameworkCore;
using Cott.Database.Entities;

namespace Cott.Database.Context
{
    public partial class CottNewContext : DbContext
    {
        public CottNewContext()
        {
        }

        public CottNewContext(DbContextOptions<CottNewContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccessibilityTariffbyPa> AccessibilityTariffbyPas { get; set; }
        public virtual DbSet<ActionsLog> ActionsLogs { get; set; }
        public virtual DbSet<Aorg> Aorgs { get; set; }
        public virtual DbSet<BatConformity> BatConformities { get; set; }
        public virtual DbSet<BatMyБылаПроверкаИзЦоп> BatMyБылаПроверкаИзЦопs { get; set; }
        public virtual DbSet<BksbparametrLog> BksbparametrLogs { get; set; }
        public virtual DbSet<BksbterminalError> BksbterminalErrors { get; set; }
        public virtual DbSet<BksbterminalSession> BksbterminalSessions { get; set; }
        public virtual DbSet<BlackList> BlackLists { get; set; }
        public virtual DbSet<BlockCard> BlockCards { get; set; }
        public virtual DbSet<BlockCardHistory> BlockCardHistories { get; set; }
        public virtual DbSet<BlockCardPeriod> BlockCardPeriods { get; set; }
        public virtual DbSet<Card> Cards { get; set; }
        public virtual DbSet<CardAllSave20210920> CardAllSave20210920s { get; set; }
        public virtual DbSet<CardAllSave20211120> CardAllSave20211120s { get; set; }
        public virtual DbSet<CardAllSave20211220> CardAllSave20211220s { get; set; }
        public virtual DbSet<CardBlock20210920> CardBlock20210920s { get; set; }
        public virtual DbSet<CardBlock20211120> CardBlock20211120s { get; set; }
        public virtual DbSet<CardBlockMy20210920> CardBlockMy20210920s { get; set; }
        public virtual DbSet<CardBlockUec20211220> CardBlockUec20211220s { get; set; }
        public virtual DbSet<CardBlockVsc20211220> CardBlockVsc20211220s { get; set; }
        public virtual DbSet<CardHolderPrivilege> CardHolderPrivileges { get; set; }
        public virtual DbSet<CardL> CardLs { get; set; }
        public virtual DbSet<CardMy> CardMies { get; set; }
        public virtual DbSet<CardPareg> CardParegs { get; set; }
        public virtual DbSet<CardParegSaveIsh> CardParegSaveIshes { get; set; }
        public virtual DbSet<CardT> CardTs { get; set; }
        public virtual DbSet<CardU> CardUs { get; set; }
        public virtual DbSet<CardWrongBitmap> CardWrongBitmaps { get; set; }
        public virtual DbSet<CardsWPriv> CardsWPrivs { get; set; }
        public virtual DbSet<CertifyingDoc> CertifyingDocs { get; set; }
        public virtual DbSet<CompanyPeoplePost> CompanyPeoplePosts { get; set; }
        public virtual DbSet<DicFilesError> DicFilesErrors { get; set; }
        public virtual DbSet<DicReason> DicReasons { get; set; }
        public virtual DbSet<DicRole> DicRoles { get; set; }
        public virtual DbSet<DicStation> DicStations { get; set; }
        public virtual DbSet<DicStatus> DicStatuses { get; set; }
        public virtual DbSet<DictDoc> DictDocs { get; set; }
        public virtual DbSet<DictRegistrPrivilege> DictRegistrPrivileges { get; set; }
        public virtual DbSet<DictTarifPp> DictTarifPps { get; set; }
        public virtual DbSet<Etkcomission> Etkcomissions { get; set; }
        public virtual DbSet<Etkcomission2014> Etkcomission2014s { get; set; }
        public virtual DbSet<ExtBlackList> ExtBlackLists { get; set; }
        public virtual DbSet<FileUpload> FileUploads { get; set; }
        public virtual DbSet<FileUploadError> FileUploadErrors { get; set; }
        public virtual DbSet<FileUploadReport> FileUploadReports { get; set; }
        public virtual DbSet<FileUploadSave> FileUploadSaves { get; set; }
        public virtual DbSet<FilesBat> FilesBats { get; set; }
        public virtual DbSet<Filesop> Filesops { get; set; }
        public virtual DbSet<Human> Humans { get; set; }
        public virtual DbSet<HumanAorgRegistration> HumanAorgRegistrations { get; set; }
        public virtual DbSet<List> Lists { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<MuetConformity> MuetConformities { get; set; }
        public virtual DbSet<MuetTerminal> MuetTerminals { get; set; }
        public virtual DbSet<OldcardBankMifare> OldcardBankMifares { get; set; }
        public virtual DbSet<PopulatedArea> PopulatedAreas { get; set; }
        public virtual DbSet<PopulatedAreaReg> PopulatedAreaRegs { get; set; }
        public virtual DbSet<Privilege> Privileges { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<ReportingCompany> ReportingCompanies { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }
        public virtual DbSet<SessionPeriod> SessionPeriods { get; set; }
        public virtual DbSet<Standartsession> Standartsessions { get; set; }
        public virtual DbSet<StopListFile> StopListFiles { get; set; }
        public virtual DbSet<Tb6> Tb6s { get; set; }
        public virtual DbSet<TechnicalTransferCard> TechnicalTransferCards { get; set; }
        public virtual DbSet<TechnicalTransferCardError> TechnicalTransferCardErrors { get; set; }
        public virtual DbSet<Temp123> Temp123s { get; set; }
        public virtual DbSet<Temp1234> Temp1234s { get; set; }
        public virtual DbSet<Temp12345> Temp12345s { get; set; }
        public virtual DbSet<TempActualTerminalsBat> TempActualTerminalsBats { get; set; }
        public virtual DbSet<TempActualTerminalsBatNew> TempActualTerminalsBatNews { get; set; }
        public virtual DbSet<TempD> TempDs { get; set; }
        public virtual DbSet<TempDstk> TempDstks { get; set; }
        public virtual DbSet<TempMuetMy> TempMuetMies { get; set; }
        public virtual DbSet<TempMy> TempMies { get; set; }
        public virtual DbSet<TempMyIsh> TempMyIshes { get; set; }
        public virtual DbSet<TempStuMy> TempStuMies { get; set; }
        public virtual DbSet<TempTermBat> TempTermBats { get; set; }
        public virtual DbSet<TempTermId> TempTermIds { get; set; }
        public virtual DbSet<TempUitMy> TempUitMies { get; set; }
        public virtual DbSet<Tempbat2> Tempbat2s { get; set; }
        public virtual DbSet<Tempbat3> Tempbat3s { get; set; }
        public virtual DbSet<Tempbat5> Tempbat5s { get; set; }
        public virtual DbSet<Tempbat6> Tempbat6s { get; set; }
        public virtual DbSet<Tempbt> Tempbts { get; set; }
        public virtual DbSet<Tempbt2> Tempbt2s { get; set; }
        public virtual DbSet<Tempbt3> Tempbt3s { get; set; }
        public virtual DbSet<Tempetkcard> Tempetkcards { get; set; }
        public virtual DbSet<Tempmuet> Tempmuets { get; set; }
        public virtual DbSet<Tempmuet1> Tempmuet1s { get; set; }
        public virtual DbSet<TempmuetStat> TempmuetStats { get; set; }
        public virtual DbSet<TempmuetStat1> TempmuetStat1s { get; set; }
        public virtual DbSet<Tempschool> Tempschools { get; set; }
        public virtual DbSet<Tempstu5> Tempstu5s { get; set; }
        public virtual DbSet<Term> Terms { get; set; }
        public virtual DbSet<Terminal> Terminals { get; set; }
        public virtual DbSet<TerminalArch> TerminalArches { get; set; }
        public virtual DbSet<TerminalHolder> TerminalHolders { get; set; }
        public virtual DbSet<TerminalHolderType> TerminalHolderTypes { get; set; }
        public virtual DbSet<TerminalsPp> TerminalsPps { get; set; }
        public virtual DbSet<TestTerminal> TestTerminals { get; set; }
        public virtual DbSet<TmpSrp> TmpSrps { get; set; }
        public virtual DbSet<TmpTerminal> TmpTerminals { get; set; }
        public virtual DbSet<TpBrscLog> TpBrscLogs { get; set; }
        public virtual DbSet<Tpbr> Tpbrs { get; set; }
        public virtual DbSet<Tpcard> Tpcards { get; set; }
        public virtual DbSet<Tpcard1> Tpcards1 { get; set; }
        public virtual DbSet<Trip> Trips { get; set; }
        public virtual DbSet<TripBlockCard> TripBlockCards { get; set; }
        public virtual DbSet<TripDuplicate> TripDuplicates { get; set; }
        public virtual DbSet<TripPeriod> TripPeriods { get; set; }
        public virtual DbSet<TripPeriod2> TripPeriod2s { get; set; }
        public virtual DbSet<TripUndefinedCard> TripUndefinedCards { get; set; }
        public virtual DbSet<TripUnknownTerminal> TripUnknownTerminals { get; set; }
        public virtual DbSet<TripsFixCost> TripsFixCosts { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=(local)\\SQLExpress2019;database=CottNew;integrated Security=SSPI;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccessibilityTariffbyPa>(entity =>
            {
                entity.HasKey(e => new { e.AorgId, e.TariffPpid, e.AreaId })
                    .HasName("PK__Accessib__428C3B940AA9F282");

                entity.ToTable("AccessibilityTariffbyPA");

                entity.HasIndex(e => e.AreaId, "XIF1AccessibilityTariffbyPA");

                entity.HasIndex(e => e.TariffPpid, "XIF2AccessibilityTariffbyPA");

                entity.HasIndex(e => e.AorgId, "XIF3AccessibilityTariffbyPA");

                entity.Property(e => e.AorgId).HasColumnName("AOrgID");

                entity.Property(e => e.TariffPpid).HasColumnName("TariffPPID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.HasOne(d => d.Aorg)
                    .WithMany(p => p.AccessibilityTariffbyPas)
                    .HasForeignKey(d => d.AorgId)
                    .HasConstraintName("FK__Accessibi__AOrgI__498EEC8D");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.AccessibilityTariffbyPas)
                    .HasForeignKey(d => d.AreaId)
                    .HasConstraintName("FK__Accessibi__AreaI__4A8310C6");

                entity.HasOne(d => d.TariffPp)
                    .WithMany(p => p.AccessibilityTariffbyPas)
                    .HasForeignKey(d => d.TariffPpid)
                    .HasConstraintName("FK__Accessibi__Tarif__4B7734FF");
            });

            modelBuilder.Entity<ActionsLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ActionsLog");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ChipNumber)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<Aorg>(entity =>
            {
                entity.ToTable("AOrg");

                entity.HasIndex(e => e.ParentId, "XIF1AOrg");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Content).HasColumnType("text");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK__AOrg__ParentID__1EC48A19");
            });

            modelBuilder.Entity<BatConformity>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BAT_Conformity");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AgentID");

                entity.Property(e => e.ExternalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ExternalID");

                entity.Property(e => e.Fnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FNumber");

                entity.Property(e => e.Sam)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SAM");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BatMyБылаПроверкаИзЦоп>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BAT_My_Была_проверка_из_ЦОП");

                entity.Property(e => e.FinalCost).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Fnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FNumber");

                entity.Property(e => e.Idcard)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDCard");

                entity.Property(e => e.Idroute)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDRoute");

                entity.Property(e => e.Idsubdivision)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDSubdivision");

                entity.Property(e => e.Idterminal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDTerminal");

                entity.Property(e => e.Indx)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("indx");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.RClass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("R_Class");

                entity.Property(e => e.Sam)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SAM");
            });

            modelBuilder.Entity<BksbparametrLog>(entity =>
            {
                entity.ToTable("BKSBParametrLog");

                entity.Property(e => e.ChekcardErrorInfoOut)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("Chekcard_error_info_OUT");

                entity.Property(e => e.DataCard)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("data_card");

                entity.Property(e => e.ErrorIdOut).HasColumnName("error_id_OUT");

                entity.Property(e => e.FactNmbReader)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("factNmbReader");

                entity.Property(e => e.IdBksb).HasColumnName("IdBKSB");

                entity.Property(e => e.IdCard)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NewCardDataOut)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("NewCardData_OUT");

                entity.Property(e => e.NumbBlock).HasColumnName("numbBlock");

                entity.Property(e => e.PaymentErrorInfoOut)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("Payment_error_info_OUT");

                entity.Property(e => e.PaymentSum).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ProcedureName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResDbOut)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("res_db_OUT");

                entity.Property(e => e.ResOut)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("res_OUT");

                entity.Property(e => e.StartPeriod)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionIdOut).HasColumnName("TransactionId_OUT");

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<BksbterminalError>(entity =>
            {
                entity.ToTable("BKSBTerminalErrors");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<BksbterminalSession>(entity =>
            {
                entity.ToTable("BKSBTerminalSession");

                entity.Property(e => e.CardChipId)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DataCard)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Fnumber)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FNumber");

                entity.Property(e => e.IdBksb).HasColumnName("IdBKSB");

                entity.Property(e => e.PaySumm).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PaymentErrorInfo)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Res)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("res");

                entity.Property(e => e.ResDb)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("res_db");

                entity.Property(e => e.TariffPpid).HasColumnName("TariffPPID");

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<BlackList>(entity =>
            {
                entity.ToTable("BlackList");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChipNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Created).HasColumnType("datetime");
            });

            modelBuilder.Entity<BlockCard>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Column0)
                    .HasMaxLength(50)
                    .HasColumnName("Column 0");
            });

            modelBuilder.Entity<BlockCardHistory>(entity =>
            {
                entity.ToTable("BlockCardHistory");

                entity.Property(e => e.Batid).HasColumnName("BATID");

                entity.Property(e => e.Reason)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Umid).HasColumnName("UMID");

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<BlockCardPeriod>(entity =>
            {
                entity.ToTable("BlockCardPeriod");

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateFrom).HasColumnType("datetime");

                entity.Property(e => e.DateTo).HasColumnType("datetime");

                entity.Property(e => e.DoneDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Card>(entity =>
            {
                entity.ToTable("Card");

                entity.HasIndex(e => e.CardNumber, "IDX1");

                entity.HasIndex(e => e.ChipNumber, "PL_Card_Chipnumber");

                entity.HasIndex(e => e.AccountId, "XIF1Card");

                entity.HasIndex(e => new { e.Sn, e.AorgId }, "XIF2Card");

                entity.HasIndex(e => e.AorgId, "XIF3Card");

                entity.HasIndex(e => new { e.Status, e.ChipNumber }, "_dta_index_Card_9_2023678257__K12_K5_11");

                entity.HasIndex(e => e.Id, "_dta_index_Card_9_2023678257__K1_5");

                entity.HasIndex(e => new { e.Id, e.Status, e.ChipNumber }, "_dta_index_Card_9_2023678257__K1_K12_K5_11");

                entity.HasIndex(e => new { e.Id, e.CardNumber }, "_dta_index_Card_9_2023678257__K1_K6");

                entity.HasIndex(e => new { e.ChipNumber, e.Status, e.Id }, "_dta_index_Card_9_2023678257__K5_K12_K1_6");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AorgId).HasColumnName("AOrgID");

                entity.Property(e => e.CardNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChipNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Content).HasColumnType("text");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Sn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SN");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.HasOne(d => d.Aorg)
                    .WithMany(p => p.Cards)
                    .HasForeignKey(d => d.AorgId)
                    .HasConstraintName("FK__Card__AOrgID__5224328E");

                entity.HasOne(d => d.HumanAorgRegistration)
                    .WithMany(p => p.Cards)
                    .HasForeignKey(d => new { d.Sn, d.AorgId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Card__1FB8AE52");
            });

            modelBuilder.Entity<CardAllSave20210920>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Card_ALL_SAVE_2021_09_20");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AorgId).HasColumnName("AOrgID");

                entity.Property(e => e.CardNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChipNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Content).HasColumnType("text");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Sn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SN");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<CardAllSave20211120>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Card_ALL_SAVE_2021_11_20");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AorgId).HasColumnName("AOrgID");

                entity.Property(e => e.CardNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChipNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Content).HasColumnType("text");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Sn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SN");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<CardAllSave20211220>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Card_ALL_SAVE_2021_12_20");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AorgId).HasColumnName("AOrgID");

                entity.Property(e => e.CardNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChipNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Content).HasColumnType("text");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Sn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SN");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<CardBlock20210920>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CardBlock_2021_09_20");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AorgId).HasColumnName("AOrgID");

                entity.Property(e => e.CardNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChipNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Content).HasColumnType("text");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Sn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SN");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<CardBlock20211120>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CardBlock_2021_11_20");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AorgId).HasColumnName("AOrgID");

                entity.Property(e => e.CardNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChipNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Content).HasColumnType("text");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Sn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SN");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<CardBlockMy20210920>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CardBlock_My_2021_09_20");

                entity.Property(e => e.ChipNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CardBlockUec20211220>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CardBlock_UEC_2021_12_20");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AorgId).HasColumnName("AOrgID");

                entity.Property(e => e.CardNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChipNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Content).HasColumnType("text");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Sn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SN");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<CardBlockVsc20211220>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CardBlock_VSC_2021_12_20");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AorgId).HasColumnName("AOrgID");

                entity.Property(e => e.CardNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChipNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Content).HasColumnType("text");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Sn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SN");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<CardHolderPrivilege>(entity =>
            {
                entity.HasIndex(e => e.CardId, "XIF1CardHolderPrivileges");

                entity.HasIndex(e => e.DocId, "XIF3CardHolderPrivileges");

                entity.HasIndex(e => e.PrivilegesId, "XIF4CardHolderPrivileges");

                entity.HasIndex(e => new { e.CardId, e.Id, e.PrivilegesId }, "_dta_index_CardHolderPrivileges_9_1895677801__K2_K1_K3");

                entity.HasIndex(e => new { e.PrivilegesId, e.CardId }, "_dta_index_CardHolderPrivileges_9_1895677801__K3_K2");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.DocId).HasColumnName("DocID");

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DocSeria)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrivilegesId).HasColumnName("PrivilegesID");

                entity.HasOne(d => d.Card)
                    .WithMany(p => p.CardHolderPrivileges)
                    .HasForeignKey(d => d.CardId)
                    .HasConstraintName("FK__CardHolde__CardI__531856C7");

                entity.HasOne(d => d.Doc)
                    .WithMany(p => p.CardHolderPrivileges)
                    .HasForeignKey(d => d.DocId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__CardHolde__DocID__540C7B00");

                entity.HasOne(d => d.Privileges)
                    .WithMany(p => p.CardHolderPrivileges)
                    .HasForeignKey(d => d.PrivilegesId)
                    .HasConstraintName("FK__CardHolde__Privi__38845C1C");
            });

            modelBuilder.Entity<CardL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CardL");

                entity.Property(e => e.ChipNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CardMy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Card_My");

                entity.Property(e => e.CardNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChipNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CardPareg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CardPAReg");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ParegId).HasColumnName("PARegID");

                entity.Property(e => e.RepDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CardParegSaveIsh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CardPAReg_SAVE_ISH");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ParegId).HasColumnName("PARegID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CardT>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cardT");

                entity.Property(e => e.Chip)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("chip");
            });

            modelBuilder.Entity<CardU>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CardU");

                entity.Property(e => e.ChipNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RegistrPrivilegesId).HasColumnName("RegistrPrivilegesID");

                entity.Property(e => e.TariffPpid).HasColumnName("TariffPPID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CardWrongBitmap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CardWrongBitmap");

                entity.Property(e => e.ChipNumber)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CardsWPriv>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CardsW_Priv");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.CardNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChipNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.DocId).HasColumnName("DocID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PrivilegesId).HasColumnName("PrivilegesID");

                entity.Property(e => e.Sn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SN");
            });

            modelBuilder.Entity<CertifyingDoc>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("title");

                entity.Property(e => e.TitleGenitive)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("titleGenitive");
            });

            modelBuilder.Entity<CompanyPeoplePost>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("title");

                entity.Property(e => e.TitleGenitive)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("titleGenitive");
            });

            modelBuilder.Entity<DicFilesError>(entity =>
            {
                entity.ToTable("Dic_FilesError");

                entity.Property(e => e.Ttile)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DicReason>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Title)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DicRole>(entity =>
            {
                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DicStation>(entity =>
            {
                entity.ToTable("Dic_Stations");

                entity.Property(e => e.StationName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DicStatus>(entity =>
            {
                entity.ToTable("DicStatus");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DictDoc>(entity =>
            {
                entity.ToTable("DictDoc");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Content).HasColumnType("text");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DictRegistrPrivilege>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasMany(d => d.TariffPps)
                    .WithMany(p => p.RegistrPrivileges)
                    .UsingEntity<Dictionary<string, object>>(
                        "AccessibilityTariffbyRegistr",
                        l => l.HasOne<DictTarifPp>().WithMany().HasForeignKey("TariffPpid").HasConstraintName("FK__Accessibi__Tarif__4D5F7D71"),
                        r => r.HasOne<DictRegistrPrivilege>().WithMany().HasForeignKey("RegistrPrivilegesId").HasConstraintName("FK__Accessibi__Regis__4C6B5938"),
                        j =>
                        {
                            j.HasKey("RegistrPrivilegesId", "TariffPpid").HasName("PK__Accessib__82E6B7FFCA7FEEE7");

                            j.ToTable("AccessibilityTariffbyRegistr");

                            j.HasIndex(new[] { "RegistrPrivilegesId" }, "XIF1AccessibilityTariffbyRegistr");

                            j.HasIndex(new[] { "TariffPpid" }, "XIF2AccessibilityTariffbyRegistr");

                            j.IndexerProperty<long>("RegistrPrivilegesId").HasColumnName("RegistrPrivilegesID");

                            j.IndexerProperty<long>("TariffPpid").HasColumnName("TariffPPID");
                        });
            });

            modelBuilder.Entity<DictTarifPp>(entity =>
            {
                entity.ToTable("DictTarifPP");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Content).HasColumnType("text");

                entity.Property(e => e.Mapping)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Maxsumm)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("MAXSumm");

                entity.Property(e => e.Minsumm)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("MINSumm");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Etkcomission>(entity =>
            {
                entity.ToTable("ETKComission");

                entity.Property(e => e.AdditSum).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Comis).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ComisSum).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RealSum).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.Etkcomissions)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_ETKComission_Session");
            });

            modelBuilder.Entity<Etkcomission2014>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ETKComission2014");

                entity.Property(e => e.AdditSum).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Comis).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ComisSum).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RealSum).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<ExtBlackList>(entity =>
            {
                entity.HasKey(e => e.IdCard);

                entity.ToTable("ExtBlackList");

                entity.Property(e => e.IdCard)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FileUpload>(entity =>
            {
                entity.ToTable("FileUpload");

                entity.HasIndex(e => e.TerminalId, "XIF1FileUpload");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<FileUploadError>(entity =>
            {
                entity.ToTable("FileUploadError");

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<FileUploadReport>(entity =>
            {
                entity.ToTable("FileUploadReport");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<FileUploadSave>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FileUploadSave");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<FilesBat>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FilesBAT");

                entity.Property(e => e.CardId)
                    .HasMaxLength(50)
                    .HasColumnName("cardId");

                entity.Property(e => e.CardType)
                    .HasMaxLength(50)
                    .HasColumnName("cardType");

                entity.Property(e => e.DateTimes)
                    .HasMaxLength(50)
                    .HasColumnName("dateTimes");

                entity.Property(e => e.FactoryNumber)
                    .HasMaxLength(50)
                    .HasColumnName("factoryNumber");

                entity.Property(e => e.HolderSubdiv)
                    .HasMaxLength(50)
                    .HasColumnName("holderSubdiv");

                entity.Property(e => e.Indexs)
                    .HasMaxLength(50)
                    .HasColumnName("indexs");

                entity.Property(e => e.RouteNum)
                    .HasMaxLength(50)
                    .HasColumnName("routeNum");

                entity.Property(e => e.Sums)
                    .HasMaxLength(50)
                    .HasColumnName("sums");
            });

            modelBuilder.Entity<Filesop>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("filesops");

                entity.Property(e => e.CardId)
                    .HasMaxLength(50)
                    .HasColumnName("cardId");

                entity.Property(e => e.CardType)
                    .HasMaxLength(50)
                    .HasColumnName("cardType");

                entity.Property(e => e.DateTimes)
                    .HasMaxLength(50)
                    .HasColumnName("dateTimes");

                entity.Property(e => e.FactoryNumber)
                    .HasMaxLength(50)
                    .HasColumnName("factoryNumber");

                entity.Property(e => e.HolderSubdiv)
                    .HasMaxLength(50)
                    .HasColumnName("holderSubdiv");

                entity.Property(e => e.Indexs)
                    .HasMaxLength(50)
                    .HasColumnName("indexs");

                entity.Property(e => e.RouteNum)
                    .HasMaxLength(50)
                    .HasColumnName("routeNum");

                entity.Property(e => e.Sums)
                    .HasMaxLength(50)
                    .HasColumnName("sums");
            });

            modelBuilder.Entity<Human>(entity =>
            {
                entity.ToTable("Human");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Content).HasColumnType("text");
            });

            modelBuilder.Entity<HumanAorgRegistration>(entity =>
            {
                entity.HasKey(e => new { e.Sn, e.AorgId })
                    .HasName("PK__HumanAOr__D77A3738300875F1");

                entity.ToTable("HumanAOrgRegistration");

                entity.HasIndex(e => e.AorgId, "XIF1HumanAOrgRegistration");

                entity.HasIndex(e => e.HumanId, "XIF2HumanAOrgRegistration");

                entity.HasIndex(e => e.AreaId, "XIF3HumanAOrgRegistration");

                entity.Property(e => e.Sn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SN");

                entity.Property(e => e.AorgId).HasColumnName("AOrgID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Content).HasColumnType("text");

                entity.Property(e => e.HumanId).HasColumnName("HumanID");

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.HasOne(d => d.Aorg)
                    .WithMany(p => p.HumanAorgRegistrations)
                    .HasForeignKey(d => d.AorgId)
                    .HasConstraintName("FK__HumanAOrg__AOrgI__56E8E7AB");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.HumanAorgRegistrations)
                    .HasForeignKey(d => d.AreaId)
                    .HasConstraintName("FK__HumanAOrg__AreaI__57DD0BE4");

                entity.HasOne(d => d.Human)
                    .WithMany(p => p.HumanAorgRegistrations)
                    .HasForeignKey(d => d.HumanId)
                    .HasConstraintName("FK__HumanAOrg__Human__257187A8");
            });

            modelBuilder.Entity<List>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("List");

                entity.Property(e => e._)
                    .HasMaxLength(255)
                    .HasColumnName(" ");

                entity.Property(e => e.ВремяТранзакции)
                    .HasMaxLength(255)
                    .HasColumnName("Время транзакции");

                entity.Property(e => e.ДатаИВремяДобавленияВБд)
                    .HasMaxLength(255)
                    .HasColumnName("Дата и время добавления в БД");

                entity.Property(e => e.ДатаТранзакции)
                    .HasColumnType("datetime")
                    .HasColumnName("Дата транзакции");

                entity.Property(e => e.НоваяСерияКарты)
                    .HasMaxLength(255)
                    .HasColumnName("Новая серия карты");

                entity.Property(e => e.НомерКарты)
                    .HasMaxLength(255)
                    .HasColumnName("номер карты");

                entity.Property(e => e.Подразделение).HasMaxLength(255);

                entity.Property(e => e.ПродленДо)
                    .HasColumnType("datetime")
                    .HasColumnName("Продлен до");

                entity.Property(e => e.СерияКарты)
                    .HasMaxLength(255)
                    .HasColumnName("Серия карты");

                entity.Property(e => e.СуммаПополнения).HasColumnName("Сумма пополнения");

                entity.Property(e => e.ТипОперации)
                    .HasMaxLength(255)
                    .HasColumnName("Тип операции");

                entity.Property(e => e.Чип).HasMaxLength(255);
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("Menu");

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.Property(e => e.Url).HasMaxLength(100);
            });

            modelBuilder.Entity<MuetConformity>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MUET_Conformity");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AgentID");

                entity.Property(e => e.Fnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FNumber");

                entity.Property(e => e.Sam)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SAM");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MuetTerminal>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Fnumber)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FNumber");

                entity.Property(e => e.IdSubdiv).HasColumnName("idSubdiv");
            });

            modelBuilder.Entity<OldcardBankMifare>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("oldcardBank-mifare");

                entity.Property(e => e.Column0)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Column 0");

                entity.Property(e => e.IdMifare)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID_Mifare");
            });

            modelBuilder.Entity<PopulatedArea>(entity =>
            {
                entity.ToTable("PopulatedArea");

                entity.HasIndex(e => e.ParentId, "XIF1PopulatedArea");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Content).HasColumnType("text");

                entity.Property(e => e.Kladr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("kladr");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PopulatedAreaReg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PopulatedAreaReg");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Rcode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RCode");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Privilege>(entity =>
            {
                entity.HasIndex(e => e.RegistrPrivilegesId, "XIF1Privileges");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RegistrPrivilegesId).HasColumnName("RegistrPrivilegesID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.RegistrPrivileges)
                    .WithMany(p => p.Privileges)
                    .HasForeignKey(d => d.RegistrPrivilegesId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Privilege__Regis__4C8B54C9");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.ToTable("Report");

                entity.HasIndex(e => e.Closed, "closed_Report");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Closed)
                    .HasColumnType("datetime")
                    .HasColumnName("closed");

                entity.Property(e => e.ClosingMonth)
                    .HasColumnType("datetime")
                    .HasColumnName("closingMonth");

                entity.Property(e => e.Stage).HasColumnName("stage");

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<ReportingCompany>(entity =>
            {
                entity.ToTable("ReportingCompany");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ContractNum).HasColumnName("contractNum");

                entity.Property(e => e.DocId).HasColumnName("docId");

                entity.Property(e => e.FirstSecondReport)
                    .HasColumnType("datetime")
                    .HasColumnName("firstSecondReport");

                entity.Property(e => e.OwnerFio)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ownerFIO");

                entity.Property(e => e.OwnerFiogenitive)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ownerFIOGenitive");

                entity.Property(e => e.ParentId).HasColumnName("parentId");

                entity.Property(e => e.PostId).HasColumnName("postId");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<Session>(entity =>
            {
                entity.ToTable("Session");

                entity.HasIndex(e => new { e.TypeSession, e.Status, e.PaySumm, e.Updated }, "MisIndxSession");

                entity.HasIndex(e => e.Updated, "PK_Session_Updated");

                entity.HasIndex(e => e.CardId, "XIF1Session");

                entity.HasIndex(e => e.TerminalId, "XIF2Session");

                entity.HasIndex(e => e.TariffPpid, "XIF3Session");

                entity.HasIndex(e => new { e.Status, e.Updated, e.Id, e.CardId, e.TerminalId }, "_dta_index_Session_9_1959678029__K10_K11_K1_K4_K3");

                entity.HasIndex(e => new { e.TypeSession, e.Status, e.Updated, e.Id }, "_dta_index_Session_9_1959678029__K2_K10_K11_K1_3_7");

                entity.HasIndex(e => new { e.CardId, e.Status }, "_dta_index_Session_9_1959678029__K4_K10_11");

                entity.HasIndex(e => new { e.TariffPpid, e.Updated, e.Id, e.CardId }, "_dta_index_Session_9_1959678029__K5_K11_K1_K4");

                entity.HasIndex(e => e.OpNumber, "_dta_index_Session_9_1959678029__K6_1_10");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActualPrivilegesId).HasColumnName("ActualPrivilegesID");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.Change).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Content).HasColumnType("text");

                entity.Property(e => e.PaySumm).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TariffPpid).HasColumnName("TariffPPID");

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.HasOne(d => d.Card)
                    .WithMany(p => p.Sessions)
                    .HasForeignKey(d => d.CardId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Session__CardID__5AB9788F");

                entity.HasOne(d => d.TariffPp)
                    .WithMany(p => p.Sessions)
                    .HasForeignKey(d => d.TariffPpid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Session__TariffP__5BAD9CC8");

                entity.HasOne(d => d.Terminal)
                    .WithMany(p => p.Sessions)
                    .HasForeignKey(d => d.TerminalId)
                    .HasConstraintName("FK__Session__Termina__5CA1C101");
            });

            modelBuilder.Entity<SessionPeriod>(entity =>
            {
                entity.ToTable("SessionPeriod");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ActualPrivilegesId).HasColumnName("ActualPrivilegesID");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.Change).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Content).HasColumnType("text");

                entity.Property(e => e.PaySumm).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TariffPpid).HasColumnName("TariffPPID");

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.HasOne(d => d.Card)
                    .WithMany(p => p.SessionPeriods)
                    .HasForeignKey(d => d.CardId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__SessionPe__CardI__4A83DC1D");

                entity.HasOne(d => d.TariffPp)
                    .WithMany(p => p.SessionPeriods)
                    .HasForeignKey(d => d.TariffPpid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__SessionPe__Tarif__4B780056");

                entity.HasOne(d => d.Terminal)
                    .WithMany(p => p.SessionPeriods)
                    .HasForeignKey(d => d.TerminalId)
                    .HasConstraintName("FK__SessionPe__Termi__4C6C248F");
            });

            modelBuilder.Entity<Standartsession>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("standartsession");

                entity.Property(e => e.DataBytes4l80010117014400000000000000000000Bytes4lBytes5)
                    .HasMaxLength(255)
                    .HasColumnName("<DATA><BYTES4L>80010117014400000000000000000000</BYTES4L><BYTES5");

                entity.Property(e => e.F10).HasColumnType("datetime");

                entity.Property(e => e.Null)
                    .HasMaxLength(255)
                    .HasColumnName("null");

                entity.Property(e => e.Null1)
                    .HasMaxLength(255)
                    .HasColumnName("null1");
            });

            modelBuilder.Entity<StopListFile>(entity =>
            {
                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<Tb6>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb6");

                entity.Property(e => e.Indx)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("indx");
            });

            modelBuilder.Entity<TechnicalTransferCard>(entity =>
            {
                entity.ToTable("TechnicalTransferCard");

                entity.HasIndex(e => new { e.CardId, e.OpNumber, e.Status }, "_dta_index_TechnicalTransferCard_9_1666821000__K5_K3_K7");

                entity.Property(e => e.ApplicNumb)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Content).HasColumnType("text");

                entity.Property(e => e.FromCard)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TariffPpid).HasColumnName("TariffPPID");

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<TechnicalTransferCardError>(entity =>
            {
                entity.ToTable("TechnicalTransferCardError");

                entity.Property(e => e.Binary4From)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Binary4FROM");

                entity.Property(e => e.Binary4In)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Binary4IN");

                entity.Property(e => e.ChipCardFrom)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ChipCardIn)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Error)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IdRefill)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Oper)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Opt)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Temp123>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp123");

                entity.Property(e => e.FinalCost)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FNumber");

                entity.Property(e => e.Idcard)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDCard");

                entity.Property(e => e.Idroute)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDRoute");

                entity.Property(e => e.Idsubdivision)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDSubdivision");

                entity.Property(e => e.Idterminal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDTerminal");

                entity.Property(e => e.Indx)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("indx");

                entity.Property(e => e.PaymentDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RClass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("R_Class");

                entity.Property(e => e.Sam)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SAM");
            });

            modelBuilder.Entity<Temp1234>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp1234");

                entity.Property(e => e.BagCost)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bag_cost");

                entity.Property(e => e.BeginNmb)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("begin_nmb");

                entity.Property(e => e.ClassNmb)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("class_nmb");

                entity.Property(e => e.EndNmb)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("end_nmb");

                entity.Property(e => e.Finalcost)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("finalcost");

                entity.Property(e => e.Fnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FNumber");

                entity.Property(e => e.IdConductor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdRoute)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idRoute");

                entity.Property(e => e.IdSubdivision)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idSubdivision");

                entity.Property(e => e.IdUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idcard)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idcard");

                entity.Property(e => e.Idterminal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idterminal");

                entity.Property(e => e.Indx)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("indx");

                entity.Property(e => e.NewRemainder)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OpCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Paymentdate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("paymentdate");

                entity.Property(e => e.Sam)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SAM");

                entity.Property(e => e.TicketNmb)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCard)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCash)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Temp12345>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp12345");

                entity.Property(e => e.ClassNmb)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("class_nmb");

                entity.Property(e => e.Finalcost)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("finalcost");

                entity.Property(e => e.IdRoute)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idRoute");

                entity.Property(e => e.IdSubdivision)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idSubdivision");

                entity.Property(e => e.Idcard)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idcard");

                entity.Property(e => e.Idterminal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idterminal");

                entity.Property(e => e.Indx)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("indx");

                entity.Property(e => e.NumTerminal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Paymentdate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("paymentdate");

                entity.Property(e => e.Sam)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SAM");
            });

            modelBuilder.Entity<TempActualTerminalsBat>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempActualTerminalsBat");

                entity.Property(e => e.FactNumb)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdSubdivision)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("idSubdivision");

                entity.Property(e => e.IdTerminal)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("idTerminal");

                entity.Property(e => e.SName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("sName");
            });

            modelBuilder.Entity<TempActualTerminalsBatNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempActualTerminalsBat_New");

                entity.Property(e => e.FactNumb)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdSubdivision)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idSubdivision");

                entity.Property(e => e.IdTerminal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idTerminal");

                entity.Property(e => e.SName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("sName");
            });

            modelBuilder.Entity<TempD>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_DS");

                entity.Property(e => e.AddSvc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ADD_SVC");

                entity.Property(e => e.CrDate)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CR_DATE");

                entity.Property(e => e.CrTime)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CR_TIME");

                entity.Property(e => e.Date)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DATE");

                entity.Property(e => e.Ern)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ERN");

                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.LongPan)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LONG_PAN");

                entity.Property(e => e.PanHash)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PAN_HASH");

                entity.Property(e => e.Prtype)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PRTYPE");

                entity.Property(e => e.RouteNum)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ROUTE_NUM");

                entity.Property(e => e.Sn)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SN");

                entity.Property(e => e.Tarif)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TARIF");

                entity.Property(e => e.Time)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TIME");

                entity.Property(e => e.TrcId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TRC_ID");

                entity.Property(e => e.TrmId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TRM_ID");

                entity.Property(e => e.TrmSn)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TRM_SN");

                entity.Property(e => e.Ttype)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TTYPE");

                entity.Property(e => e.TtypeDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TTYPE_DESC");
            });

            modelBuilder.Entity<TempDstk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_DSTK");

                entity.Property(e => e.AddSvc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ADD_SVC");

                entity.Property(e => e.CrDate)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CR_DATE");

                entity.Property(e => e.CrTime)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CR_TIME");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Date)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DATE");

                entity.Property(e => e.Ern)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ERN");

                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.LongPan)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LONG_PAN");

                entity.Property(e => e.Prtype)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PRTYPE");

                entity.Property(e => e.RouteNum)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ROUTE_NUM");

                entity.Property(e => e.Sn)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SN");

                entity.Property(e => e.Tarif)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TARIF");

                entity.Property(e => e.Time)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TIME");

                entity.Property(e => e.TrcId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TRC_ID");

                entity.Property(e => e.TrmId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TRM_ID");

                entity.Property(e => e.TrmSn)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TRM_SN");

                entity.Property(e => e.Ttype)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TTYPE");

                entity.Property(e => e.TtypeDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TTYPE_DESC");

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<TempMuetMy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_MUET_My");

                entity.Property(e => e.AddSvc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ADD_SVC");

                entity.Property(e => e.CrDate)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CR_DATE");

                entity.Property(e => e.CrTime)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CR_TIME");

                entity.Property(e => e.Date)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DATE");

                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.LongPan)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LONG_PAN");

                entity.Property(e => e.Prtype)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PRTYPE");

                entity.Property(e => e.RouteNum)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ROUTE_NUM");

                entity.Property(e => e.Sn)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SN");

                entity.Property(e => e.Tarif)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TARIF");

                entity.Property(e => e.Time)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TIME");

                entity.Property(e => e.TrcId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TRC_ID");

                entity.Property(e => e.TrmId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TRM_ID");

                entity.Property(e => e.TrmSn)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TRM_SN");

                entity.Property(e => e.Ttype)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TTYPE");

                entity.Property(e => e.TtypeDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TTYPE_DESC");

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<TempMy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempMy");

                entity.Property(e => e.AddSvc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ADD_SVC");

                entity.Property(e => e.CrDate)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CR_DATE");

                entity.Property(e => e.CrTime)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CR_TIME");

                entity.Property(e => e.Date)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DATE");

                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.LongPan)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LONG_PAN");

                entity.Property(e => e.Prtype)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PRTYPE");

                entity.Property(e => e.RouteNum)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ROUTE_NUM");

                entity.Property(e => e.Sn)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SN");

                entity.Property(e => e.Tarif)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TARIF");

                entity.Property(e => e.Time)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TIME");

                entity.Property(e => e.TrcId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TRC_ID");

                entity.Property(e => e.TrmId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TRM_ID");

                entity.Property(e => e.TrmSn)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TRM_SN");

                entity.Property(e => e.Ttype)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TTYPE");

                entity.Property(e => e.TtypeDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TTYPE_DESC");

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<TempMyIsh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempMy_ISH");

                entity.Property(e => e.AddSvc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ADD_SVC");

                entity.Property(e => e.CrDate)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CR_DATE");

                entity.Property(e => e.CrTime)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CR_TIME");

                entity.Property(e => e.Date)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DATE");

                entity.Property(e => e.Ern)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ERN");

                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.LongPan)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LONG_PAN");

                entity.Property(e => e.PanHash)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PAN_HASH");

                entity.Property(e => e.Prtype)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PRTYPE");

                entity.Property(e => e.RouteNum)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ROUTE_NUM");

                entity.Property(e => e.Sn)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SN");

                entity.Property(e => e.Tarif)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TARIF");

                entity.Property(e => e.Time)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TIME");

                entity.Property(e => e.TrcId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TRC_ID");

                entity.Property(e => e.TrmId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TRM_ID");

                entity.Property(e => e.TrmSn)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TRM_SN");

                entity.Property(e => e.Ttype)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TTYPE");

                entity.Property(e => e.TtypeDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TTYPE_DESC");
            });

            modelBuilder.Entity<TempStuMy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_STU_My");

                entity.Property(e => e.AddSvc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ADD_SVC");

                entity.Property(e => e.CrDate)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CR_DATE");

                entity.Property(e => e.CrTime)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CR_TIME");

                entity.Property(e => e.Date)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DATE");

                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.LongPan)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LONG_PAN");

                entity.Property(e => e.Prtype)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PRTYPE");

                entity.Property(e => e.RouteNum)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ROUTE_NUM");

                entity.Property(e => e.Sn)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SN");

                entity.Property(e => e.Tarif)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TARIF");

                entity.Property(e => e.Time)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TIME");

                entity.Property(e => e.TrcId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TRC_ID");

                entity.Property(e => e.TrmId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TRM_ID");

                entity.Property(e => e.TrmSn)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TRM_SN");

                entity.Property(e => e.Ttype)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TTYPE");

                entity.Property(e => e.TtypeDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TTYPE_DESC");

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<TempTermBat>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempTermBAT");

                entity.Property(e => e.FactNumb)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdSubdivision)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idSubdivision");

                entity.Property(e => e.IdTerminal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idTerminal");

                entity.Property(e => e.SName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sName");
            });

            modelBuilder.Entity<TempTermId>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempTermID");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.Idterm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idterm");
            });

            modelBuilder.Entity<TempUitMy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_UIT_My");

                entity.Property(e => e.AddSvc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ADD_SVC");

                entity.Property(e => e.CrDate)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CR_DATE");

                entity.Property(e => e.CrTime)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CR_TIME");

                entity.Property(e => e.Date)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DATE");

                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.LongPan)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LONG_PAN");

                entity.Property(e => e.Prtype)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PRTYPE");

                entity.Property(e => e.RouteNum)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ROUTE_NUM");

                entity.Property(e => e.Sn)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SN");

                entity.Property(e => e.Tarif)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TARIF");

                entity.Property(e => e.Time)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TIME");

                entity.Property(e => e.TrcId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TRC_ID");

                entity.Property(e => e.TrmId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TRM_ID");

                entity.Property(e => e.TrmSn)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TRM_SN");

                entity.Property(e => e.Ttype)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TTYPE");

                entity.Property(e => e.TtypeDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TTYPE_DESC");

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<Tempbat2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempbat2");

                entity.Property(e => e.CardId).HasColumnName("cardId");

                entity.Property(e => e.CountRef).HasColumnName("countRef");

                entity.Property(e => e.TermId).HasColumnName("termId");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasColumnName("updated");
            });

            modelBuilder.Entity<Tempbat3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempbat3");

                entity.Property(e => e.Cid1)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("cid1");

                entity.Property(e => e.Cid2)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("cid2");

                entity.Property(e => e.Id1).HasColumnName("id1");

                entity.Property(e => e.Id2).HasColumnName("id2");

                entity.Property(e => e.RowNumb1).HasColumnName("row_numb1");

                entity.Property(e => e.RowNumb2).HasColumnName("row_numb2");
            });

            modelBuilder.Entity<Tempbat5>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempbat5");

                entity.Property(e => e.CardId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("cardID");

                entity.Property(e => e.Cardtype)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("cardtype");

                entity.Property(e => e.Datetim)
                    .HasMaxLength(29)
                    .IsUnicode(false)
                    .HasColumnName("datetim");

                entity.Property(e => e.FactoryNumber)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("factoryNumber");

                entity.Property(e => e.HolderSubdiv)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("holderSubdiv");

                entity.Property(e => e.Indexx)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("indexx");

                entity.Property(e => e.RouteClass)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("routeClass");

                entity.Property(e => e.RouteNumb)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("routeNumb");

                entity.Property(e => e.Summ)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("summ");
            });

            modelBuilder.Entity<Tempbat6>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempbat6");

                entity.Property(e => e.CardId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("cardID");

                entity.Property(e => e.Cardtype)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("cardtype");

                entity.Property(e => e.Datetim)
                    .HasMaxLength(29)
                    .IsUnicode(false)
                    .HasColumnName("datetim");

                entity.Property(e => e.FactoryNumber)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("factoryNumber");

                entity.Property(e => e.HolderSubdiv)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("holderSubdiv");

                entity.Property(e => e.Indexx)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("indexx");

                entity.Property(e => e.RouteClass)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("routeClass");

                entity.Property(e => e.RouteNumb)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("routeNumb");

                entity.Property(e => e.Summ)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("summ");
            });

            modelBuilder.Entity<Tempbt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempbt");

                entity.Property(e => e.BagCost)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bag_cost");

                entity.Property(e => e.BeginNmb)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("begin_nmb");

                entity.Property(e => e.ClassNmb)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("class_nmb");

                entity.Property(e => e.EndNmb)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("end_nmb");

                entity.Property(e => e.Finalcost)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("finalcost");

                entity.Property(e => e.IdConductor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdRoute)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idRoute");

                entity.Property(e => e.IdSubdivision)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idSubdivision");

                entity.Property(e => e.IdUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idcard)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idcard");

                entity.Property(e => e.Idterminal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idterminal");

                entity.Property(e => e.Indx)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("indx");

                entity.Property(e => e.NewRemainder)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OpCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Paymentdate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("paymentdate");

                entity.Property(e => e.TicketNmb)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCard)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCash)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tempbt2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempbt2");

                entity.Property(e => e.BagCost)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bag_cost");

                entity.Property(e => e.BeginNmb)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("begin_nmb");

                entity.Property(e => e.ClassNmb)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("class_nmb");

                entity.Property(e => e.EndNmb)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("end_nmb");

                entity.Property(e => e.Finalcost)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("finalcost");

                entity.Property(e => e.IdConductor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdRoute)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idRoute");

                entity.Property(e => e.IdSubdivision)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idSubdivision");

                entity.Property(e => e.IdUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idcard)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idcard");

                entity.Property(e => e.Idterminal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idterminal");

                entity.Property(e => e.Indx)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("indx");

                entity.Property(e => e.NewRemainder)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OpCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Paymentdate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("paymentdate");

                entity.Property(e => e.TicketNmb)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCard)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCash)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tempbt3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempbt3");

                entity.Property(e => e.BagCost)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bag_cost");

                entity.Property(e => e.BeginNmb)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("begin_nmb");

                entity.Property(e => e.ClassNmb)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("class_nmb");

                entity.Property(e => e.EndNmb)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("end_nmb");

                entity.Property(e => e.Finalcost)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("finalcost");

                entity.Property(e => e.IdConductor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdRoute)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idRoute");

                entity.Property(e => e.IdSubdivision)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idSubdivision");

                entity.Property(e => e.IdUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idcard)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idcard");

                entity.Property(e => e.Idterminal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idterminal");

                entity.Property(e => e.Indx)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("indx");

                entity.Property(e => e.NewRemainder)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OpCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Paymentdate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("paymentdate");

                entity.Property(e => e.TicketNmb)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCard)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCash)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tempetkcard>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempetkcard");

                entity.Property(e => e.Sn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SN");
            });

            modelBuilder.Entity<Tempmuet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempmuet");

                entity.Property(e => e.Finalcost)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("finalcost");

                entity.Property(e => e.IdCard)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("id_card");

                entity.Property(e => e.IdSubdivision)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("idSubdivision");

                entity.Property(e => e.Idterminal)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("idterminal");

                entity.Property(e => e.Indx)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("indx");

                entity.Property(e => e.Paymentdate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("paymentdate");
            });

            modelBuilder.Entity<Tempmuet1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempmuet1");

                entity.Property(e => e.Finalcost)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("finalcost");

                entity.Property(e => e.IdCard)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("id_card");

                entity.Property(e => e.IdSubdivision)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("idSubdivision");

                entity.Property(e => e.Idterminal)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("idterminal");

                entity.Property(e => e.Indx)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("indx");

                entity.Property(e => e.Paymentdate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("paymentdate");
            });

            modelBuilder.Entity<TempmuetStat>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempmuetSTAT");

                entity.Property(e => e.Chip10Number)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("chip10Number");

                entity.Property(e => e.ChipNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("chipNumber");

                entity.Property(e => e.Cost)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("cost");

                entity.Property(e => e.CottDate)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("cottDate");

                entity.Property(e => e.CottTime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cottTime");

                entity.Property(e => e.DateTrans)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("dateTrans");

                entity.Property(e => e.Gluh1)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("gluh1");

                entity.Property(e => e.Gluh2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("gluh2");

                entity.Property(e => e.IdTc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("idTC");

                entity.Property(e => e.NumberEklz)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("numberEKLZ");

                entity.Property(e => e.NumberRoute)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("numberRoute");

                entity.Property(e => e.Region)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("region");

                entity.Property(e => e.SerialCard)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("serialCard");

                entity.Property(e => e.SerialTerminal)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("serialTerminal");

                entity.Property(e => e.TimeTrans)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("timeTrans");

                entity.Property(e => e.TypeOper)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("typeOper");

                entity.Property(e => e.TypeTicket)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("typeTicket");
            });

            modelBuilder.Entity<TempmuetStat1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempmuetSTAT1");

                entity.Property(e => e.Finalcost)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("finalcost");

                entity.Property(e => e.FuctNumb)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdCard)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("id_card");

                entity.Property(e => e.IdSubdivision)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("idSubdivision");

                entity.Property(e => e.Idterminal)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("idterminal");

                entity.Property(e => e.Paymentdate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("paymentdate");
            });

            modelBuilder.Entity<Tempschool>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempschool");

                entity.Property(e => e.Chip)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("chip");

                entity.Property(e => e.Numcard)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("numcard");
            });

            modelBuilder.Entity<Tempstu5>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempstu5");

                entity.Property(e => e.Cardid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cardid");

                entity.Property(e => e.Datetim)
                    .HasMaxLength(29)
                    .IsUnicode(false)
                    .HasColumnName("datetim");

                entity.Property(e => e.Indexx)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("indexx");

                entity.Property(e => e.Termid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("termid");
            });

            modelBuilder.Entity<Term>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("term");

                entity.Property(e => e.Fnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FNumber");

                entity.Property(e => e.Idterminal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idterminal");
            });

            modelBuilder.Entity<Terminal>(entity =>
            {
                entity.ToTable("Terminal");

                entity.HasIndex(e => e.Fnumber, "PK_TerminalFNumber");

                entity.HasIndex(e => e.ModelId, "XIF1Terminal");

                entity.HasIndex(e => e.AgentId, "XIF2Terminal");

                entity.HasIndex(e => e.SoftId, "XIF3Terminal");

                entity.HasIndex(e => e.AreaId, "XIF4Terminal");

                entity.HasIndex(e => e.AreaId, "_dta_index_Terminal_9_132195521__K2_1_3");

                entity.HasIndex(e => new { e.AreaId, e.Id }, "_dta_index_Terminal_9_132195521__K2_K1");

                entity.HasIndex(e => new { e.Fnumber, e.Status, e.Id }, "_dta_index_Terminal_9_132195521__K6_K15_K1");

                entity.HasIndex(e => new { e.Fnumber, e.AgentId }, "_dta_index_Terminal_9_132195521__K6_K3_1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AgentId).HasColumnName("AgentID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Content).HasColumnType("text");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.ExternalId).HasColumnName("ExternalID");

                entity.Property(e => e.Fnumber)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FNumber");

                entity.Property(e => e.Ip)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("IP");

                entity.Property(e => e.Mac)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MAC");

                entity.Property(e => e.ModelId).HasColumnName("ModelID");

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SoftId).HasColumnName("SoftID");

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.HasOne(d => d.Agent)
                    .WithMany(p => p.Terminals)
                    .HasForeignKey(d => d.AgentId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Terminal__AgentI__607251E5");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.Terminals)
                    .HasForeignKey(d => d.AreaId)
                    .HasConstraintName("FK__Terminal__AreaID__2A363CC5");

                entity.HasMany(d => d.Tariffs)
                    .WithMany(p => p.Terminals)
                    .UsingEntity<Dictionary<string, object>>(
                        "AccessibilityTariffbyTerminal",
                        l => l.HasOne<DictTarifPp>().WithMany().HasForeignKey("TariffId").HasConstraintName("FK__Accessibi__Tarif__4E53A1AA"),
                        r => r.HasOne<Terminal>().WithMany().HasForeignKey("TerminalId").HasConstraintName("FK__Accessibi__Termi__4F47C5E3"),
                        j =>
                        {
                            j.HasKey("TerminalId", "TariffId").HasName("PK__Accessib__44C89A902EFA0D77");

                            j.ToTable("AccessibilityTariffbyTerminal");

                            j.HasIndex(new[] { "TerminalId" }, "XIF1AccessibilityTariffbyTerminal");

                            j.HasIndex(new[] { "TariffId" }, "XIF2AccessibilityTariffbyTerminal");

                            j.IndexerProperty<long>("TerminalId").HasColumnName("TerminalID");

                            j.IndexerProperty<long>("TariffId").HasColumnName("TariffID");
                        });
            });

            modelBuilder.Entity<TerminalArch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TerminalArch");

                entity.Property(e => e.AgentId).HasColumnName("AgentID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Content).HasColumnType("text");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.ExternalId).HasColumnName("ExternalID");

                entity.Property(e => e.Fnumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FNumber");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ip)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("IP");

                entity.Property(e => e.Mac)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MAC");

                entity.Property(e => e.ModelId).HasColumnName("ModelID");

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SoftId).HasColumnName("SoftID");

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<TerminalHolder>(entity =>
            {
                entity.ToTable("TerminalHolder");

                entity.HasIndex(e => e.ParentId, "XIF1TerminalHolder");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Content).HasColumnType("text");

                entity.Property(e => e.ExternalId).HasColumnName("ExternalID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.TerminalHolders)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__TerminalH__AreaI__625A9A57");
            });

            modelBuilder.Entity<TerminalHolderType>(entity =>
            {
                entity.ToTable("TerminalHolderType");

                entity.Property(e => e.ShortTitle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdHolderNavigation)
                    .WithMany(p => p.TerminalHolderTypes)
                    .HasForeignKey(d => d.IdHolder)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TerminalHolderType_TerminalHolder");
            });

            modelBuilder.Entity<TerminalsPp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TerminalsPP");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Content).HasColumnType("text");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.TerminalHolder)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TestTerminal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TestTerminal");

                entity.Property(e => e.AgentId).HasColumnName("AgentID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Content).HasColumnType("text");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.ExternalId).HasColumnName("ExternalID");

                entity.Property(e => e.Fnumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FNumber");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ip)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("IP");

                entity.Property(e => e.Mac)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MAC");

                entity.Property(e => e.ModelId).HasColumnName("ModelID");

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SoftId).HasColumnName("SoftID");

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<TmpSrp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmpSRP");

                entity.Property(e => e.Card)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cost)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdRoute)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idRoute");

                entity.Property(e => e.Idterminal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idterminal");

                entity.Property(e => e.Indx).HasColumnName("indx");

                entity.Property(e => e.Paymentdate)
                    .HasColumnType("datetime")
                    .HasColumnName("paymentdate");
            });

            modelBuilder.Entity<TmpTerminal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TmpTerminal");

                entity.Property(e => e.Column0)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Column 0");
            });

            modelBuilder.Entity<TpBrscLog>(entity =>
            {
                entity.ToTable("TpBrscLog");

                entity.HasIndex(e => new { e.RowId, e.UserId }, "_dta_index_TpBrscLog_9_517628937__K9_K4_3_11");

                entity.Property(e => e.ColumnName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CommentSystem)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CommentUser)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.ValueAfter)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ValueBefore)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Card)
                    .WithMany(p => p.TpBrscLogs)
                    .HasForeignKey(d => d.CardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TpBrscLog_Card");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TpBrscLogs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TpBrscLog_Users");
            });

            modelBuilder.Entity<Tpbr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tpbr");

                entity.Property(e => e.Cardtype)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("cardtype");

                entity.Property(e => e.Chip)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("chip");

                entity.Property(e => e.Indx)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("indx");

                entity.Property(e => e.Paymentdate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("paymentdate");

                entity.Property(e => e.Routeid)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("routeid");

                entity.Property(e => e.T1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("t1");

                entity.Property(e => e.T10)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("t10");

                entity.Property(e => e.T11)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("t11");

                entity.Property(e => e.T12)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("t12");

                entity.Property(e => e.T13)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("t13");

                entity.Property(e => e.T2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("t2");

                entity.Property(e => e.T3)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("t3");

                entity.Property(e => e.T4)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("t4");

                entity.Property(e => e.T5)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("t5");

                entity.Property(e => e.T6)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("t6");

                entity.Property(e => e.T7)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("t7");

                entity.Property(e => e.T8)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("t8");

                entity.Property(e => e.T9)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("t9");
            });

            modelBuilder.Entity<Tpcard>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tpcard");

                entity.Property(e => e.Column0)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Column 0");

                entity.Property(e => e.Column1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Column 1");
            });

            modelBuilder.Entity<Tpcard1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tpcards");

                entity.Property(e => e.Chip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chip");

                entity.Property(e => e.Number)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("number");
            });

            modelBuilder.Entity<Trip>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__Trip__3214EC2620DE5059")
                    .IsClustered(false);

                entity.ToTable("Trip");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AorgId).HasColumnName("AOrgID");

                entity.Property(e => e.BeginStationId).HasColumnName("BeginStationID");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.CarriageClassId).HasColumnName("CarriageClassID");

                entity.Property(e => e.CatCardHolderId).HasColumnName("CatCardHolderID");

                entity.Property(e => e.CatTarifId).HasColumnName("CatTarifID");

                entity.Property(e => e.Cost).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.EndStationId).HasColumnName("EndStationID");

                entity.Property(e => e.ExternalId).HasColumnName("ExternalID");

                entity.Property(e => e.FileUploadId).HasColumnName("FileUploadID");

                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.Property(e => e.StopCardId).HasColumnName("StopCardID");

                entity.Property(e => e.TerminalHolderId).HasColumnName("TerminalHolderID");

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.HasOne(d => d.Card)
                    .WithMany(p => p.Trips)
                    .HasForeignKey(d => d.CardId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Trip__CardID__02E7657A");

                entity.HasOne(d => d.FileUpload)
                    .WithMany(p => p.Trips)
                    .HasForeignKey(d => d.FileUploadId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Trip__FileUpload__03DB89B3");

                entity.HasOne(d => d.StopCard)
                    .WithMany(p => p.Trips)
                    .HasForeignKey(d => d.StopCardId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Trip__StopCardID__04CFADEC");

                entity.HasOne(d => d.Terminal)
                    .WithMany(p => p.Trips)
                    .HasForeignKey(d => d.TerminalId)
                    .HasConstraintName("FK__Trip__TerminalID__05C3D225");
            });

            modelBuilder.Entity<TripBlockCard>(entity =>
            {
                entity.ToTable("TripBlockCard");

                entity.Property(e => e.TranDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TripDuplicate>(entity =>
            {
                entity.ToTable("TripDuplicate");
            });

            modelBuilder.Entity<TripPeriod>(entity =>
            {
                entity.ToTable("TripPeriod");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AorgId).HasColumnName("AOrgID");

                entity.Property(e => e.BeginStationId).HasColumnName("BeginStationID");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.CarriageClassId).HasColumnName("CarriageClassID");

                entity.Property(e => e.CatCardHolderId).HasColumnName("CatCardHolderID");

                entity.Property(e => e.CatTarifId).HasColumnName("CatTarifID");

                entity.Property(e => e.Cost).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.EndStationId).HasColumnName("EndStationID");

                entity.Property(e => e.ExternalId).HasColumnName("ExternalID");

                entity.Property(e => e.FileUploadId).HasColumnName("FileUploadID");

                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.Property(e => e.StopCardId).HasColumnName("StopCardID");

                entity.Property(e => e.TerminalHolderId).HasColumnName("TerminalHolderID");

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.HasOne(d => d.Card)
                    .WithMany(p => p.TripPeriods)
                    .HasForeignKey(d => d.CardId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__TripPerio__CardI__3B41988D");

                entity.HasOne(d => d.FileUpload)
                    .WithMany(p => p.TripPeriods)
                    .HasForeignKey(d => d.FileUploadId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__TripPerio__FileU__3C35BCC6");

                entity.HasOne(d => d.StopCard)
                    .WithMany(p => p.TripPeriods)
                    .HasForeignKey(d => d.StopCardId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__TripPerio__StopC__3D29E0FF");

                entity.HasOne(d => d.Terminal)
                    .WithMany(p => p.TripPeriods)
                    .HasForeignKey(d => d.TerminalId)
                    .HasConstraintName("FK__TripPerio__Termi__3E1E0538");
            });

            modelBuilder.Entity<TripPeriod2>(entity =>
            {
                entity.ToTable("TripPeriod2");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AorgId).HasColumnName("AOrgID");

                entity.Property(e => e.BeginStationId).HasColumnName("BeginStationID");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.CarriageClassId).HasColumnName("CarriageClassID");

                entity.Property(e => e.CatCardHolderId).HasColumnName("CatCardHolderID");

                entity.Property(e => e.CatTarifId).HasColumnName("CatTarifID");

                entity.Property(e => e.Cost).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.EndStationId).HasColumnName("EndStationID");

                entity.Property(e => e.ExternalId).HasColumnName("ExternalID");

                entity.Property(e => e.FileUploadId).HasColumnName("FileUploadID");

                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.Property(e => e.StopCardId).HasColumnName("StopCardID");

                entity.Property(e => e.TerminalHolderId).HasColumnName("TerminalHolderID");

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.HasOne(d => d.Card)
                    .WithMany(p => p.TripPeriod2s)
                    .HasForeignKey(d => d.CardId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__TripPerio2__CardI__3B41988D");

                entity.HasOne(d => d.FileUpload)
                    .WithMany(p => p.TripPeriod2s)
                    .HasForeignKey(d => d.FileUploadId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__TripPerio2__FileU__3C35BCC6");

                entity.HasOne(d => d.StopCard)
                    .WithMany(p => p.TripPeriod2s)
                    .HasForeignKey(d => d.StopCardId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__TripPerio2__StopC__3D29E0FF");

                entity.HasOne(d => d.Terminal)
                    .WithMany(p => p.TripPeriod2s)
                    .HasForeignKey(d => d.TerminalId)
                    .HasConstraintName("FK__TripPerio2__Termi__3E1E0538");
            });

            modelBuilder.Entity<TripUndefinedCard>(entity =>
            {
                entity.ToTable("TripUndefinedCard");
            });

            modelBuilder.Entity<TripUnknownTerminal>(entity =>
            {
                entity.ToTable("TripUnknownTerminal");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fnumber)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FNumber");

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<TripsFixCost>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Cost)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("cost");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Fio)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("fio");

                entity.Property(e => e.UserLogin)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("userLogin");

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("userPassword");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.ToTable("UserRole");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRole_DicRoles");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRole_UserRole");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
