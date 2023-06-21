using KSIMonitor.Data.SETModels;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data {
    public partial class SETContext : DbContext, IDBContext {
        public SETContext(DbContextOptions<SETContext> options) : base(options) { }

        public virtual DbSet<AccessArea> AccessAreas { get; set; }
        public virtual DbSet<Association> Associations { get; set; }
        public virtual DbSet<AwardCeremonyCompleted> AwardCeremonyCompleted { get; set; }
        public virtual DbSet<Barcode> Barcodes { get; set; }
        public virtual DbSet<Binomio> Binomios { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CategoryMatch> CategoryMatches { get; set; }
        public virtual DbSet<ClientMonitor> ClientMonitors { get; set; }
        public virtual DbSet<Coach> Coaches { get; set; }
        public virtual DbSet<CoachCategory> CoachCategories { get; set; }
        public virtual DbSet<CoachCategoryAccess> CoachCategoryAccess { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<DoubleEliminationSingle> DoubleEliminationsSingle { get; set; }
        public virtual DbSet<DoubleEliminationTeam> DoubleEliminationsTeam { get; set; }
        public virtual DbSet<DrawSingle> DrawsSingle { get; set; }
        public virtual DbSet<DrawTeam> DrawsTeam { get; set; }
        public virtual DbSet<DTMDefault> DTMDefaults { get; set; }
        public virtual DbSet<EntryCoach> EntriesCoach { get; set; }
        public virtual DbSet<EntryFeeModel> EntryFeeModels { get; set; }
        public virtual DbSet<EntryOfficial> EntriesOfficial { get; set; }
        public virtual DbSet<EntryReferee> EntriesReferee { get; set; }
        public virtual DbSet<EntrySingle> EntriesSingle { get; set; }
        public virtual DbSet<EntryTeam> EntriesTeam { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<EventArea> EventAreas { get; set; }
        public virtual DbSet<EventCategory> EventCategories { get; set; }
        public virtual DbSet<EventClubEntryFee> EventClubEntryFees { get; set; }
        public virtual DbSet<EventCoachCategory> EventCoachCategories { get; set; }
        public virtual DbSet<EventCompCount> EventCompCounts { get; set; }
        public virtual DbSet<EventExchangeRate> EventExchangeRates { get; set; }
        public virtual DbSet<EventHeadOfDelegation> EventHeadOfDelegations { get; set; }
        public virtual DbSet<EventHotel> EventHotels { get; set; }
        public virtual DbSet<EventLimitBasedOnCompetitor> EventLimitBasedOnCompetitors { get; set; }
        public virtual DbSet<EventMatchDuration> EventMatchDurations { get; set; }
        public virtual DbSet<EventOfficialCategory> EventOfficialCategories { get; set; }
        public virtual DbSet<EventProtest> EventProtests { get; set; }
        public virtual DbSet<EventRefereeCategory> EventRefereeCategories { get; set; }
        public virtual DbSet<EventSeatArea> EventSeatAreas { get; set; }
        public virtual DbSet<EventSeatAreaSeat> EventSeatAreaSeats { get; set; }
        public virtual DbSet<EventType> EventTypes { get; set; }
        public virtual DbSet<EventUser> EventUsers { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<Kata> Kata { get; set; }
        public virtual DbSet<MatchCalling> MatchCallings { get; set; }
        public virtual DbSet<MatchInfo> MatchInfos { get; set; }
        public virtual DbSet<Name> Names { get; set; }
        public virtual DbSet<Nation> Nations { get; set; }
        public virtual DbSet<NationalAssociation> NationalAssociations { get; set; }
        public virtual DbSet<Official> Officials { get; set; }
        public virtual DbSet<OfficialCategory> OfficialCategories { get; set; }
        public virtual DbSet<OfficialCategoryAccess> OfficialCategoryAccess { get; set; }
        public virtual DbSet<PatternMatch> PatternMatches { get; set; }
        public virtual DbSet<PersonEmail> PersonEmails { get; set; }
        public virtual DbSet<PointHistorySingle> PointHistoriesSingle { get; set; }
        public virtual DbSet<PointHistoryTeam> PointHistoriesTeam { get; set; }
        public virtual DbSet<PointListSingle> PointListSingle { get; set; }
        public virtual DbSet<PointListTeam> PointListTeam { get; set; }
        public virtual DbSet<PoolWinnerSingle> PoolWinnersSingle { get; set; }
        public virtual DbSet<PoolWinnerTeam> PoolWinnersTeam { get; set; }
        public virtual DbSet<PressFunction> PressFunctions { get; set; }
        public virtual DbSet<PressRegistration> PressRegistrations { get; set; }
        public virtual DbSet<PressType> PressTypes { get; set; }
        public virtual DbSet<PressTypeAccess> PressTypeAccess { get; set; }
        public virtual DbSet<Referee> Referees { get; set; }
        public virtual DbSet<RefereeCategory> RefereeCategories { get; set; }
        public virtual DbSet<RefereeCategoryAccess> RefereeCategoryAccess { get; set; }
        public virtual DbSet<RefereeExam> RefereeExams { get; set; }
        public virtual DbSet<RefereeExamDecision> RefereeExamDecisions { get; set; }
        public virtual DbSet<RefereeExamResult> RefereeExamResults { get; set; }
        public virtual DbSet<RefereeMatch> RefereeMatches { get; set; }
        public virtual DbSet<RefereeMatchArea> RefereeMatchAreas { get; set; }
        public virtual DbSet<RepechageEntrySingle> RepechageEntriesSingle { get; set; }
        public virtual DbSet<RepechageEntryTeam> RepechageEntriesTeam { get; set; }
        public virtual DbSet<RepechagePool> RepechagePools { get; set; }
        public virtual DbSet<ResultSingle> ResultsSingle { get; set; }
        public virtual DbSet<ResultTeam> ResultsTeam { get; set; }
        public virtual DbSet<RoleType> RoleTypes { get; set; }
        public virtual DbSet<SportArt> SportArts { get; set; }
        public virtual DbSet<Style> Styles { get; set; }
        public virtual DbSet<SystemParameter> SystemParameters { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<TeamWaitingList> TeamWaitingList { get; set; }
        public virtual DbSet<Timetable> Timetables { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<WaitingListCoach> WaitingListCoach { get; set; }
        public virtual DbSet<WaitingListOfficial> WaitingListOfficials { get; set; }
        public virtual DbSet<WaitingListReferee> WaitingListReferee { get; set; }
        public virtual DbSet<WaitingListSingle> WaitingListSingle { get; set; }
        public virtual DbSet<WaitingListTeam> WaitingListTeam { get; set; }
        public virtual DbSet<WinType> WinTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<AccessArea>(entity => {
                entity.HasKey(e => e.AccessID).HasName("PRIMARY");
                entity.Property(e => e.Name).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<DrawSingle>(entity => {
                entity.Property(e => e.Del).HasDefaultValueSql("'0'");
                entity.Property(e => e.Pool).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<DrawTeam>(entity => {
                entity.Property(e => e.Del).HasDefaultValueSql("'0'");
                entity.Property(e => e.Pool).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Binomio>(entity => {
                entity.Property(e => e.Created).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.Sichtbar).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<ClientMonitor>(entity => {
                entity.Property(e => e.ClientMode).HasDefaultValueSql("'1'");
                entity.Property(e => e.Creation).ValueGeneratedOnAddOrUpdate().HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.Expire).HasDefaultValueSql("'1970-01-01 02:00:01'");
                entity.Property(e => e.MS).HasDefaultValueSql("'0'");
                entity.Property(e => e.Sync).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Coach>(entity => {
                entity.Property(e => e.Dan).HasDefaultValueSql("'0'");
                entity.Property(e => e.Email).HasDefaultValueSql("''");
                entity.Property(e => e.Geburt).HasDefaultValueSql("'1000-01-01'");
                entity.Property(e => e.Geschlecht).IsFixedLength();
                entity.Property(e => e.Kyu).HasDefaultValueSql("'0'");
                entity.Property(e => e.Sichtbar).HasDefaultValueSql("'1'");
                entity.Property(e => e.Title).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<DoubleEliminationSingle>(entity => {
                entity.Property(e => e.Matchtime).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.Pool).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<DoubleEliminationTeam>(entity => {
                entity.Property(e => e.Matchtime).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.Pool).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<DTMDefault>(entity => {
                entity.Property(e => e.Catname).HasDefaultValueSql("''");
                entity.Property(e => e.Color).HasDefaultValueSql("''");
                entity.Property(e => e.Sex).HasDefaultValueSql("''").IsFixedLength();
                entity.Property(e => e.Type).HasDefaultValueSql("''").IsFixedLength();
            });

            modelBuilder.Entity<EntryFeeModel>(entity => {
                entity.Property(e => e.Binomioageflatfeeage).HasDefaultValueSql("'0'");
                entity.Property(e => e.Binomioageflatfeeenable).HasDefaultValueSql("'0'");
                entity.Property(e => e.Binomiosamecode).HasDefaultValueSql("'0'");
                entity.Property(e => e.Dateentryfeewl).HasDefaultValueSql("'0'");
                entity.Property(e => e.Includealldiscount).HasDefaultValueSql("'0'");
                entity.Property(e => e.Includealldiscountteam).HasDefaultValueSql("'0'");
                entity.Property(e => e.Indentrydiscounttype).HasDefaultValueSql("'1'");
                entity.Property(e => e.Indentrydiscounttypeteam).HasDefaultValueSql("'1'");
                entity.Property(e => e.Model).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Exam>(entity => {
                entity.Property(e => e.Passmark).HasDefaultValueSql("'50'");
                entity.Property(e => e.Pecriteriasmax).HasDefaultValueSql("'5'");
                entity.Property(e => e.Tepercentage).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Category>(entity => {
                entity.HasKey(e => e.CategoryID).HasName("PRIMARY");
                entity.Property(e => e.Geschlecht).IsFixedLength();
                entity.Property(e => e.Katbez).HasDefaultValueSql("''");
                entity.Property(e => e.Team).IsFixedLength();
                entity.Property(e => e.Typ).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Kata>(entity => {
                entity.Property(e => e.Stilnr).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<NationalAssociation>(entity => {
                entity.Property(e => e.Name).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<MatchCalling>(entity => {
                entity.Property(e => e.Callmatch2).HasDefaultValueSql("'0'");
                entity.Property(e => e.Ring).HasDefaultValueSql("'0'");
                entity.Property(e => e.Winner).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PointHistorySingle>(entity => {
                entity.Property(e => e.Matchtime).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.Pool).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<PointHistoryTeam>(entity => {
                entity.Property(e => e.Matchtime).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.Pool).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Name>(entity => {
                entity.HasKey(e => e.NameID).HasName("PRIMARY");
                entity.Property(e => e.AccountEnabled).HasDefaultValueSql("'0'");
                entity.Property(e => e.Dan).HasDefaultValueSql("'0'");
                entity.Property(e => e.Email).HasDefaultValueSql("''");
                entity.Property(e => e.Geburt).HasDefaultValueSql("'1000-01-01'");
                entity.Property(e => e.Geschlecht).IsFixedLength();
                entity.Property(e => e.Isnohuman).HasDefaultValueSql("'0'");
                entity.Property(e => e.Kyu).HasDefaultValueSql("'0'");
                entity.Property(e => e.Name1).HasDefaultValueSql("''");
                entity.Property(e => e.Nationnr).HasDefaultValueSql("'0'");
                entity.Property(e => e.Sichtbar).HasDefaultValueSql("'1'");
                entity.Property(e => e.Stpktnr).HasDefaultValueSql("'0'");
                entity.Property(e => e.AssociationID).HasDefaultValueSql("'3'");
            });

            modelBuilder.Entity<Nation>(entity => {
                entity.Property(e => e.Name).HasDefaultValueSql("''");
                entity.Property(e => e.Hide).HasDefaultValueSql("'0'");
                entity.Property(e => e.ISO).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<EntryCoach>(entity => {
                entity.Property(e => e.Time).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<EntrySingle>(entity => {
                entity.Property(e => e.Measurement).HasDefaultValueSql("'0'");
                entity.Property(e => e.Time).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<EntryOfficial>(entity => {
                entity.Property(e => e.Daysinfo).HasDefaultValueSql("''");
                entity.Property(e => e.Time).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<EntryReferee>(entity => {
                entity.Property(e => e.Time).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<EntryTeam>(entity => {
                entity.Property(e => e.TeamID).ValueGeneratedOnAdd();
                entity.Property(e => e.Time).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Official>(entity => {
                entity.Property(e => e.Email).HasDefaultValueSql("''");
                entity.Property(e => e.Geburt).HasDefaultValueSql("'1000-01-01'");
                entity.Property(e => e.Geschlecht).IsFixedLength();
                entity.Property(e => e.Sichtbar).HasDefaultValueSql("'1'");
                entity.Property(e => e.Title).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<PersonEmail>(entity => {
                entity.Property(e => e.Email).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<PoolWinnerSingle>(entity => {
                entity.Property(e => e.Matchtime).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.Pool).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<PoolWinnerTeam>(entity => {
                entity.Property(e => e.Matchtime).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.Pool).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<PressRegistration>(entity => {
                entity.Property(e => e.Regtime).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<PointListSingle>(entity => {
                entity.Property(e => e.Pool).HasDefaultValueSql("'1'");
                entity.Property(e => e.S1).HasDefaultValueSql("'0'");
                entity.Property(e => e.S2).HasDefaultValueSql("'0'");
                entity.Property(e => e.S3).HasDefaultValueSql("'0'");
                entity.Property(e => e.S4).HasDefaultValueSql("'0'");
                entity.Property(e => e.S5).HasDefaultValueSql("'0'");
                entity.Property(e => e.S6).HasDefaultValueSql("'0'");
                entity.Property(e => e.S7).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PointListTeam>(entity => {
                entity.Property(e => e.Pool).HasDefaultValueSql("'1'");
                entity.Property(e => e.S1).HasDefaultValueSql("'0'");
                entity.Property(e => e.S2).HasDefaultValueSql("'0'");
                entity.Property(e => e.S3).HasDefaultValueSql("'0'");
                entity.Property(e => e.S4).HasDefaultValueSql("'0'");
                entity.Property(e => e.S5).HasDefaultValueSql("'0'");
                entity.Property(e => e.S6).HasDefaultValueSql("'0'");
                entity.Property(e => e.S7).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Referee>(entity => {
                entity.Property(e => e.Dan).HasDefaultValueSql("'0'");
                entity.Property(e => e.Email).HasDefaultValueSql("''");
                entity.Property(e => e.Geburt).HasDefaultValueSql("'1000-01-01'");
                entity.Property(e => e.Geschlecht).IsFixedLength();
                entity.Property(e => e.Kyu).HasDefaultValueSql("'0'");
                entity.Property(e => e.Lizenznr).HasDefaultValueSql("''");
                entity.Property(e => e.Sichtbar).HasDefaultValueSql("'1'");
                entity.Property(e => e.Title).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<RefereeExam>(entity => {
                entity.Property(e => e.Eventcount).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<RefereeMatch>(entity => {
                entity.Property(e => e.Lastchange).ValueGeneratedOnAddOrUpdate().HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<SportArt>(entity => {
                entity.HasKey(e => e.SportArtID).HasName("PRIMARY");
                entity.Property(e => e.Name).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Team>(entity => {
                entity.Property(e => e.Measurement).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Timetable>(entity => {
                entity.Property(e => e.Color).HasDefaultValueSql("''");
                entity.Property(e => e.Date).HasDefaultValueSql("'1000-01-01'");
                entity.Property(e => e.Endtime).HasDefaultValueSql("'1970-01-01 02:00:01'");
                entity.Property(e => e.Pool).HasDefaultValueSql("'1'");
                entity.Property(e => e.Pools).HasDefaultValueSql("'1'");
                entity.Property(e => e.Sex).HasDefaultValueSql("''");
                entity.Property(e => e.Starttime).HasDefaultValueSql("'1970-01-01 02:00:01'");
                entity.Property(e => e.Type).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<RepechageEntrySingle>(entity => {
                entity.Property(e => e.Matchtime).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<RepechageEntryTeam>(entity => {
                entity.Property(e => e.Matchtime).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<User>(entity => {
                entity.Property(e => e.Autopayment).HasDefaultValueSql("'1'");
                entity.Property(e => e.Create).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.Email).HasDefaultValueSql("''");
                entity.Property(e => e.Extregoption).HasDefaultValueSql("'0'");
                entity.Property(e => e.Geburtstag).HasDefaultValueSql("'1000-01-01'");
                entity.Property(e => e.Mandant).HasDefaultValueSql("'2'");
                entity.Property(e => e.Nachname).HasDefaultValueSql("''");
                entity.Property(e => e.Nation).HasDefaultValueSql("'0'");
                entity.Property(e => e.Passwort).HasDefaultValueSql("''");
                entity.Property(e => e.Privacypolicyagreedate).HasDefaultValueSql("'1990-01-01 01:01:01'");
                entity.Property(e => e.Title).HasDefaultValueSql("''");
                entity.Property(e => e.Vorname).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Event>(entity => {
                entity.HasKey(e => e.EventID).HasName("PRIMARY");
                entity.Property(e => e.Adminallowrefereescores).HasDefaultValueSql("'0'");
                entity.Property(e => e.Allentriesonwaitinglist).HasDefaultValueSql("'0'");
                entity.Property(e => e.Appsynccat).HasDefaultValueSql("'0'");
                entity.Property(e => e.Appsyncclub).HasDefaultValueSql("'0'");
                entity.Property(e => e.Appsyncevent).HasDefaultValueSql("'0'");
                entity.Property(e => e.Name).HasDefaultValueSql("''");
                entity.Property(e => e.Cartkeepopenafterdeadline).HasDefaultValueSql("'0'");
                entity.Property(e => e.Cattotallimitputwlcat).HasDefaultValueSql("'0'");
                entity.Property(e => e.Deletetodraw).HasDefaultValueSql("'0'");
                entity.Property(e => e.Disableentrydelete).HasDefaultValueSql("'0'");
                entity.Property(e => e.Disableentrydeletewl).HasDefaultValueSql("'0'");
                entity.Property(e => e.Enablevolunteerregistration).HasDefaultValueSql("'0'");
                entity.Property(e => e.EtrefereeselfassignmentOnepercountry).HasDefaultValueSql("'0'");
                entity.Property(e => e.Extregistrationmode).HasDefaultValueSql("'0'");
                entity.Property(e => e.Extregistrationnopermission).HasDefaultValueSql("'0'");
                entity.Property(e => e.Headofdelegation).HasDefaultValueSql("'0'");
                entity.Property(e => e.Hideathleteentries).HasDefaultValueSql("'0'");
                entity.Property(e => e.Hidecoachentries).HasDefaultValueSql("'0'");
                entity.Property(e => e.Hidecoachreg).HasDefaultValueSql("'0'");
                entity.Property(e => e.Hidefromcalendar).HasDefaultValueSql("'0'");
                entity.Property(e => e.Hideindreg).HasDefaultValueSql("'0'");
                entity.Property(e => e.Hidemedalstatistic).HasDefaultValueSql("'0'");
                entity.Property(e => e.Hideofficialentries).HasDefaultValueSql("'0'");
                entity.Property(e => e.Hideofficialreg).HasDefaultValueSql("'0'");
                entity.Property(e => e.Hiderefereeentries).HasDefaultValueSql("'0'");
                entity.Property(e => e.Hiderefereereg).HasDefaultValueSql("'0'");
                entity.Property(e => e.Hideresultlist).HasDefaultValueSql("'0'");
                entity.Property(e => e.Hideteamreg).HasDefaultValueSql("'0'");
                entity.Property(e => e.Hotel).HasDefaultValueSql("'0'");
                entity.Property(e => e.Indentryshowrankingpos).HasDefaultValueSql("'0'");
                entity.Property(e => e.IndentryuserankingtoprankfromCheckothercategories).HasDefaultValueSql("'0'");
                entity.Property(e => e.International).HasDefaultValueSql("'1'");
                entity.Property(e => e.Invoiced).HasDefaultValueSql("'0'");
                entity.Property(e => e.Land).HasDefaultValueSql("'15'");
                entity.Property(e => e.Lastchange).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.Liveblog).HasDefaultValueSql("'1'");
                entity.Property(e => e.Livestream).HasDefaultValueSql("'0'");
                entity.Property(e => e.Nennende).HasDefaultValueSql("''");
                entity.Property(e => e.Nennstart).HasDefaultValueSql("''");
                entity.Property(e => e.Noteshow).HasDefaultValueSql("'0'");
                entity.Property(e => e.Paid).HasDefaultValueSql("'0'");
                entity.Property(e => e.Paypalextrafee).HasDefaultValueSql("'0'");
                entity.Property(e => e.Paypalextrafeepercentage).HasDefaultValueSql("'0'");
                entity.Property(e => e.Paypalnoamount).HasDefaultValueSql("'0'");
                entity.Property(e => e.Premiumevent).HasDefaultValueSql("'0'");
                entity.Property(e => e.Region).HasDefaultValueSql("'0'");
                entity.Property(e => e.Showathleteprofilespublic).HasDefaultValueSql("'0'");
                entity.Property(e => e.Showstartercountonly).HasDefaultValueSql("'0'");
                entity.Property(e => e.Superlicenseevent).HasDefaultValueSql("'0'");
                entity.Property(e => e.Typ).HasDefaultValueSql("'1'");
                entity.Property(e => e.Useallmatchcodes).HasDefaultValueSql("'0'");
                entity.Property(e => e.Usebillingaddress).HasDefaultValueSql("'0'");
                entity.Property(e => e.Usebothcutoffdates).HasDefaultValueSql("'0'");
                entity.Property(e => e.Usedisclaimer).HasDefaultValueSql("'0'");
                entity.Property(e => e.Usematchnumbercodes).HasDefaultValueSql("'0'");
                entity.Property(e => e.Usematchnumbercodestime).HasDefaultValueSql("'0'");
                entity.Property(e => e.Usepaypal).HasDefaultValueSql("'0'");
                entity.Property(e => e.Usepaypaldonationbutton).HasDefaultValueSql("'0'");
                entity.Property(e => e.Verdatum).HasDefaultValueSql("''");
                entity.Property(e => e.Waehrung).HasDefaultValueSql("'45'");
            });

            modelBuilder.Entity<EventArea>(entity => {
                entity.Property(e => e.Athletesallowed).HasDefaultValueSql("'0'");
                entity.Property(e => e.Coachcatsallowed).HasDefaultValueSql("'0'");
                entity.Property(e => e.Coachesallowed).HasDefaultValueSql("'0'");
                entity.Property(e => e.Kurzbez).HasDefaultValueSql("''");
                entity.Property(e => e.Nr).HasDefaultValueSql("'0'");
                entity.Property(e => e.Offcatsallowed).HasDefaultValueSql("'0'");
                entity.Property(e => e.Officialsallowed).HasDefaultValueSql("'0'");
                entity.Property(e => e.Pressallowed).HasDefaultValueSql("'0'");
                entity.Property(e => e.Presstypeallowed).HasDefaultValueSql("'0'");
                entity.Property(e => e.Refereecatsallowed).HasDefaultValueSql("'0'");
                entity.Property(e => e.Refereesallowed).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<EventClubEntryFee>(entity => {
                entity.Property(e => e.Comment).HasDefaultValueSql("''");
                entity.Property(e => e.Discount).HasDefaultValueSql("'0'");
                entity.Property(e => e.Paidammount).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<EventProtest>(entity => {
                entity.Property(e => e.Athnnr).HasDefaultValueSql("'0'");
                entity.Property(e => e.CatID).HasDefaultValueSql("'0'");
                entity.Property(e => e.Creation).ValueGeneratedOnAddOrUpdate().HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<EventSeatAreaSeat>(entity => {
                entity.Property(e => e.Reserved).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<EventUser>(entity => {
                entity.Property(e => e.Emailnotification).HasDefaultValueSql("'1'");
                entity.Property(e => e.Time).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<EventCategory>(entity => {
                entity.Property(e => e.BodyLevel).HasDefaultValueSql("'0'");
                entity.Property(e => e.Exrefselfass).HasDefaultValueSql("'0'");
                entity.Property(e => e.GoldenpointEnable).HasDefaultValueSql("'0'");
                entity.Property(e => e.GoldenpointTime).HasDefaultValueSql("''");
                entity.Property(e => e.HeadLevel).HasDefaultValueSql("'0'");
                entity.Property(e => e.IwufAdedtf).HasDefaultValueSql("'0'");
                entity.Property(e => e.IwufCompmovement).HasDefaultValueSql("'0'");
                entity.Property(e => e.IwufData).HasDefaultValueSql("''");
                entity.Property(e => e.IwufDifficulty).HasDefaultValueSql("'0'");
                entity.Property(e => e.IwufStyle).HasDefaultValueSql("''");
                entity.Property(e => e.KyeshiTime).HasDefaultValueSql("''");
                entity.Property(e => e.Matchtype).HasDefaultValueSql("''");
                entity.Property(e => e.Pools).HasDefaultValueSql("'0'");
                entity.Property(e => e.Refdeployment).HasDefaultValueSql("'0'");
                entity.Property(e => e.RestTime).HasDefaultValueSql("''");
                entity.Property(e => e.RoundTime).HasDefaultValueSql("''");
                entity.Property(e => e.Rounds).HasDefaultValueSql("'0'");
                entity.Property(e => e.Scoremode).HasDefaultValueSql("'-1'");
                entity.Property(e => e.Seedmode).HasDefaultValueSql("'0'");
                entity.Property(e => e.Shortname).HasDefaultValueSql("''");
                entity.Property(e => e.Weightmax).HasDefaultValueSql("'0'");
                entity.Property(e => e.Weightmin).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Association>(entity => {
                entity.HasKey(e => e.AssociationID).HasName("PRIMARY");
                entity.Property(e => e.Name).HasDefaultValueSql("''");
                entity.Property(e => e.Lvnr).HasDefaultValueSql("'0'");
                entity.Property(e => e.Nation).HasDefaultValueSql("'15'");
                entity.Property(e => e.Sektionnr).HasDefaultValueSql("'0'");
                entity.Property(e => e.Stpktnr).HasDefaultValueSql("'0'");
                entity.Property(e => e.Teamtype).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<WaitingListCoach>(entity => {
                entity.Property(e => e.Time).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<WaitingListSingle>(entity => {
                entity.Property(e => e.Replacement).HasDefaultValueSql("'0'");
                entity.Property(e => e.Time).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<WaitingListOfficial>(entity => {
                entity.Property(e => e.Time).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<WaitingListReferee>(entity => {
                entity.Property(e => e.Time).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<WaitingListTeam>(entity => {
                entity.Property(e => e.Replacement).HasDefaultValueSql("'0'");
                entity.Property(e => e.TeamID).ValueGeneratedOnAdd();
                entity.Property(e => e.Time).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
