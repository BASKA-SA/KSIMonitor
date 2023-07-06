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
                entity.Property(e => e.Created).ValueGeneratedOnAddOrUpdate().HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.Expires).HasDefaultValueSql("'1970-01-01 02:00:01'");
                entity.Property(e => e.MS).HasDefaultValueSql("'0'");
                entity.Property(e => e.Sync).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Coach>(entity => {
                entity.Property(e => e.Dan).HasDefaultValueSql("'0'");
                entity.Property(e => e.Email).HasDefaultValueSql("''");
                entity.Property(e => e.BirthDate).HasDefaultValueSql("'1000-01-01'");
                entity.Property(e => e.Gender).IsFixedLength();
                entity.Property(e => e.Kyu).HasDefaultValueSql("'0'");
                entity.Property(e => e.Visible).HasDefaultValueSql("'1'");
                entity.Property(e => e.Title).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<DoubleEliminationSingle>(entity => {
                entity.Property(e => e.MatchTime).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.Pool).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<DoubleEliminationTeam>(entity => {
                entity.Property(e => e.MatchTime).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.Pool).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<DTMDefault>(entity => {
                entity.Property(e => e.CategoryName).HasDefaultValueSql("''");
                entity.Property(e => e.Color).HasDefaultValueSql("''");
                entity.Property(e => e.Sex).HasDefaultValueSql("''").IsFixedLength();
                entity.Property(e => e.Type).HasDefaultValueSql("''").IsFixedLength();
            });

            modelBuilder.Entity<EntryFeeModel>(entity => {
                entity.Property(e => e.BinomioAgeFlatFeeAge).HasDefaultValueSql("'0'");
                entity.Property(e => e.BinomioAgeFlatFeeEnable).HasDefaultValueSql("'0'");
                entity.Property(e => e.BinomioSameCode).HasDefaultValueSql("'0'");
                entity.Property(e => e.DateEntryFeeWL).HasDefaultValueSql("'0'");
                entity.Property(e => e.IncludeAllDiscount).HasDefaultValueSql("'0'");
                entity.Property(e => e.IncludeAllDiscountTeam).HasDefaultValueSql("'0'");
                entity.Property(e => e.IndividualEntryDiscountType).HasDefaultValueSql("'1'");
                entity.Property(e => e.IndividualEntryDiscountTypeTeam).HasDefaultValueSql("'1'");
                entity.Property(e => e.Model).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Exam>(entity => {
                entity.Property(e => e.PassMark).HasDefaultValueSql("'50'");
                entity.Property(e => e.PeCriteriasMax).HasDefaultValueSql("'5'");
                entity.Property(e => e.TePercentage).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Category>(entity => {
                entity.HasKey(e => e.CategoryID).HasName("PRIMARY");
                entity.Property(e => e.Gender).IsFixedLength();
                entity.Property(e => e.Katbez).HasDefaultValueSql("''");
                entity.Property(e => e.Team).IsFixedLength();
                entity.Property(e => e.Type).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Kata>(entity => {
                entity.Property(e => e.StyleID).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<NationalAssociation>(entity => {
                entity.Property(e => e.Name).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<MatchCalling>(entity => {
                entity.Property(e => e.CallMatch2).HasDefaultValueSql("'0'");
                entity.Property(e => e.Ring).HasDefaultValueSql("'0'");
                entity.Property(e => e.Winner).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PointHistorySingle>(entity => {
                entity.Property(e => e.MatchTime).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.Pool).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<PointHistoryTeam>(entity => {
                entity.Property(e => e.MatchTime).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.Pool).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Name>(entity => {
                entity.HasKey(e => e.NameID).HasName("PRIMARY");
                entity.Property(e => e.AccountEnabled).HasDefaultValueSql("'0'");
                entity.Property(e => e.Dan).HasDefaultValueSql("'0'");
                entity.Property(e => e.Email).HasDefaultValueSql("''");
                entity.Property(e => e.BirthDate).HasDefaultValueSql("'1000-01-01'");
                entity.Property(e => e.Gender).IsFixedLength();
                entity.Property(e => e.IsNoHuman).HasDefaultValueSql("'0'");
                entity.Property(e => e.Kyu).HasDefaultValueSql("'0'");
                entity.Property(e => e.Name1).HasDefaultValueSql("''");
                entity.Property(e => e.NationID).HasDefaultValueSql("'0'");
                entity.Property(e => e.Visible).HasDefaultValueSql("'1'");
                entity.Property(e => e.StpktID).HasDefaultValueSql("'0'");
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
                entity.Property(e => e.DaysInfo).HasDefaultValueSql("''");
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
                entity.Property(e => e.BirthDate).HasDefaultValueSql("'1000-01-01'");
                entity.Property(e => e.Gender).IsFixedLength();
                entity.Property(e => e.Visible).HasDefaultValueSql("'1'");
                entity.Property(e => e.Title).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<PersonEmail>(entity => {
                entity.Property(e => e.Email).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<PoolWinnerSingle>(entity => {
                entity.Property(e => e.MatchTime).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.Pool).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<PoolWinnerTeam>(entity => {
                entity.Property(e => e.MatchTime).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.Pool).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<PressRegistration>(entity => {
                entity.Property(e => e.RegTime).HasDefaultValueSql("CURRENT_TIMESTAMP");
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
                entity.Property(e => e.BirthDate).HasDefaultValueSql("'1000-01-01'");
                entity.Property(e => e.Gender).IsFixedLength();
                entity.Property(e => e.Kyu).HasDefaultValueSql("'0'");
                entity.Property(e => e.LicenceID).HasDefaultValueSql("''");
                entity.Property(e => e.Visible).HasDefaultValueSql("'1'");
                entity.Property(e => e.Title).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<RefereeExam>(entity => {
                entity.Property(e => e.EventCount).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<RefereeMatch>(entity => {
                entity.Property(e => e.LastChange).ValueGeneratedOnAddOrUpdate().HasDefaultValueSql("CURRENT_TIMESTAMP");
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
                entity.Property(e => e.EndTime).HasDefaultValueSql("'1970-01-01 02:00:01'");
                entity.Property(e => e.Pool).HasDefaultValueSql("'1'");
                entity.Property(e => e.Pools).HasDefaultValueSql("'1'");
                entity.Property(e => e.Sex).HasDefaultValueSql("''");
                entity.Property(e => e.StartTime).HasDefaultValueSql("'1970-01-01 02:00:01'");
                entity.Property(e => e.Type).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<RepechageEntrySingle>(entity => {
                entity.Property(e => e.MatchTime).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<RepechageEntryTeam>(entity => {
                entity.Property(e => e.MatchTime).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<User>(entity => {
                entity.Property(e => e.AutoPayment).HasDefaultValueSql("'1'");
                entity.Property(e => e.Created).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.Email).HasDefaultValueSql("''");
                entity.Property(e => e.ExtRegOption).HasDefaultValueSql("'0'");
                entity.Property(e => e.BirthDate).HasDefaultValueSql("'1000-01-01'");
                entity.Property(e => e.Client).HasDefaultValueSql("'2'");
                entity.Property(e => e.Client).HasDefaultValueSql("''");
                entity.Property(e => e.NationID).HasDefaultValueSql("'0'");
                entity.Property(e => e.Password).HasDefaultValueSql("''");
                entity.Property(e => e.PrivacyPolicyAgreeDate).HasDefaultValueSql("'1990-01-01 01:01:01'");
                entity.Property(e => e.Title).HasDefaultValueSql("''");
                entity.Property(e => e.FirstName).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Event>(entity => {
                entity.HasKey(e => e.EventID).HasName("PRIMARY");
                entity.Property(e => e.AdminAllowRefereeScores).HasDefaultValueSql("'0'");
                entity.Property(e => e.AllEntriesOnWaitingList).HasDefaultValueSql("'0'");
                entity.Property(e => e.AppSyncCategory).HasDefaultValueSql("'0'");
                entity.Property(e => e.AppSyncClub).HasDefaultValueSql("'0'");
                entity.Property(e => e.AppSyncEvent).HasDefaultValueSql("'0'");
                entity.Property(e => e.Name).HasDefaultValueSql("''");
                entity.Property(e => e.CartKeepOpenAfterDeadline).HasDefaultValueSql("'0'");
                entity.Property(e => e.CategoryTotalLimitPutWLCat).HasDefaultValueSql("'0'");
                entity.Property(e => e.DeleteToDraw).HasDefaultValueSql("'0'");
                entity.Property(e => e.DisableEntryDelete).HasDefaultValueSql("'0'");
                entity.Property(e => e.DisableEntryDeleteWL).HasDefaultValueSql("'0'");
                entity.Property(e => e.EnableVolunteerRegistration).HasDefaultValueSql("'0'");
                entity.Property(e => e.EtRefereeSelfAssignmentOnePerCountry).HasDefaultValueSql("'0'");
                entity.Property(e => e.ExternalRegistrationMode).HasDefaultValueSql("'0'");
                entity.Property(e => e.ExternalRegistrationNoPermission).HasDefaultValueSql("'0'");
                entity.Property(e => e.HeadOfDelegation).HasDefaultValueSql("'0'");
                entity.Property(e => e.HideAthleteEntries).HasDefaultValueSql("'0'");
                entity.Property(e => e.HideCoachEntries).HasDefaultValueSql("'0'");
                entity.Property(e => e.HideCoachRegistrations).HasDefaultValueSql("'0'");
                entity.Property(e => e.HideFromCalendar).HasDefaultValueSql("'0'");
                entity.Property(e => e.HideIndividualRegistrations).HasDefaultValueSql("'0'");
                entity.Property(e => e.HideMedalStatistic).HasDefaultValueSql("'0'");
                entity.Property(e => e.HideOfficialEntries).HasDefaultValueSql("'0'");
                entity.Property(e => e.HideOfficialRegistrations).HasDefaultValueSql("'0'");
                entity.Property(e => e.HideRefereeEntries).HasDefaultValueSql("'0'");
                entity.Property(e => e.HideRefereeRegistrations).HasDefaultValueSql("'0'");
                entity.Property(e => e.HideResultList).HasDefaultValueSql("'0'");
                entity.Property(e => e.HideTeamRegistrations).HasDefaultValueSql("'0'");
                entity.Property(e => e.Hotel).HasDefaultValueSql("'0'");
                entity.Property(e => e.IndividualEntryShowRankingPos).HasDefaultValueSql("'0'");
                entity.Property(e => e.IndividualEntryUseRankingTopRankFrom_CheckOtherCategories).HasDefaultValueSql("'0'");
                entity.Property(e => e.International).HasDefaultValueSql("'1'");
                entity.Property(e => e.Invoiced).HasDefaultValueSql("'0'");
                entity.Property(e => e.Country).HasDefaultValueSql("'15'");
                entity.Property(e => e.LastChange).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.LiveBlog).HasDefaultValueSql("'1'");
                entity.Property(e => e.Livestream).HasDefaultValueSql("'0'");
                entity.Property(e => e.EntryEnd).HasDefaultValueSql("''");
                entity.Property(e => e.EntryStart).HasDefaultValueSql("''");
                entity.Property(e => e.NoteShow).HasDefaultValueSql("'0'");
                entity.Property(e => e.Paid).HasDefaultValueSql("'0'");
                entity.Property(e => e.PaypalExtraFee).HasDefaultValueSql("'0'");
                entity.Property(e => e.PaypalExtraFeePercentage).HasDefaultValueSql("'0'");
                entity.Property(e => e.PayPalNoAmount).HasDefaultValueSql("'0'");
                entity.Property(e => e.PremiumEvent).HasDefaultValueSql("'0'");
                entity.Property(e => e.Region).HasDefaultValueSql("'0'");
                entity.Property(e => e.ShowAthleteProfilesPublic).HasDefaultValueSql("'0'");
                entity.Property(e => e.ShowStarterCountOnly).HasDefaultValueSql("'0'");
                entity.Property(e => e.SuperLicenseEvent).HasDefaultValueSql("'0'");
                entity.Property(e => e.Type).HasDefaultValueSql("'1'");
                entity.Property(e => e.UseAllMatchCodes).HasDefaultValueSql("'0'");
                entity.Property(e => e.UseBillingAddress).HasDefaultValueSql("'0'");
                entity.Property(e => e.UseBothCutoffDates).HasDefaultValueSql("'0'");
                entity.Property(e => e.UseDisclaimer).HasDefaultValueSql("'0'");
                entity.Property(e => e.UseMatchNumberCodes).HasDefaultValueSql("'0'");
                entity.Property(e => e.UseMatchNumberCodesTime).HasDefaultValueSql("'0'");
                entity.Property(e => e.UsePayPal).HasDefaultValueSql("'0'");
                entity.Property(e => e.UsePayPalDonationButton).HasDefaultValueSql("'0'");
                entity.Property(e => e.Date).HasDefaultValueSql("''");
                entity.Property(e => e.Currency).HasDefaultValueSql("'45'");
            });

            modelBuilder.Entity<EventArea>(entity => {
                entity.Property(e => e.AthletesAllowed).HasDefaultValueSql("'0'");
                entity.Property(e => e.CoachCategoriesAllowed).HasDefaultValueSql("'0'");
                entity.Property(e => e.CoachesAllowed).HasDefaultValueSql("'0'");
                entity.Property(e => e.Kurzbez).HasDefaultValueSql("''");
                entity.Property(e => e.ID).HasDefaultValueSql("'0'");
                entity.Property(e => e.OfficialCategoriesAllowed).HasDefaultValueSql("'0'");
                entity.Property(e => e.OfficialsAllowed).HasDefaultValueSql("'0'");
                entity.Property(e => e.PressAllowed).HasDefaultValueSql("'0'");
                entity.Property(e => e.PressTypeAllowed).HasDefaultValueSql("'0'");
                entity.Property(e => e.RefereeCategoriesAllowed).HasDefaultValueSql("'0'");
                entity.Property(e => e.RefereesAllowed).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<EventClubEntryFee>(entity => {
                entity.Property(e => e.Comment).HasDefaultValueSql("''");
                entity.Property(e => e.Discount).HasDefaultValueSql("'0'");
                entity.Property(e => e.PaidAmount).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<EventProtest>(entity => {
                entity.Property(e => e.AthnID).HasDefaultValueSql("'0'");
                entity.Property(e => e.CategoryID).HasDefaultValueSql("'0'");
                entity.Property(e => e.Created).ValueGeneratedOnAddOrUpdate().HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<EventSeatAreaSeat>(entity => {
                entity.Property(e => e.Reserved).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<EventUser>(entity => {
                entity.Property(e => e.EmailNotification).HasDefaultValueSql("'1'");
                entity.Property(e => e.Time).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<EventCategory>(entity => {
                entity.Property(e => e.BodyLevel).HasDefaultValueSql("'0'");
                entity.Property(e => e.Exrefselfass).HasDefaultValueSql("'0'");
                entity.Property(e => e.GoldenPointEnable).HasDefaultValueSql("'0'");
                entity.Property(e => e.GoldenPointTime).HasDefaultValueSql("''");
                entity.Property(e => e.HeadLevel).HasDefaultValueSql("'0'");
                entity.Property(e => e.IWUFAdedtf).HasDefaultValueSql("'0'");
                entity.Property(e => e.IWUFCompmovement).HasDefaultValueSql("'0'");
                entity.Property(e => e.IWUFData).HasDefaultValueSql("''");
                entity.Property(e => e.IWUFDifficulty).HasDefaultValueSql("'0'");
                entity.Property(e => e.IWUFStyle).HasDefaultValueSql("''");
                entity.Property(e => e.KyeshiTime).HasDefaultValueSql("''");
                entity.Property(e => e.MatchType).HasDefaultValueSql("''");
                entity.Property(e => e.Pools).HasDefaultValueSql("'0'");
                entity.Property(e => e.RefDeployment).HasDefaultValueSql("'0'");
                entity.Property(e => e.RestTime).HasDefaultValueSql("''");
                entity.Property(e => e.RoundTime).HasDefaultValueSql("''");
                entity.Property(e => e.Rounds).HasDefaultValueSql("'0'");
                entity.Property(e => e.ScoreMode).HasDefaultValueSql("'-1'");
                entity.Property(e => e.SeedMode).HasDefaultValueSql("'0'");
                entity.Property(e => e.ShortName).HasDefaultValueSql("''");
                entity.Property(e => e.WeightMax).HasDefaultValueSql("'0'");
                entity.Property(e => e.WeightMin).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Association>(entity => {
                entity.HasKey(e => e.AssociationID).HasName("PRIMARY");
                entity.Property(e => e.Name).HasDefaultValueSql("''");
                entity.Property(e => e.Lvnr).HasDefaultValueSql("'0'");
                entity.Property(e => e.Nation).HasDefaultValueSql("'15'");
                entity.Property(e => e.SektionID).HasDefaultValueSql("'0'");
                entity.Property(e => e.StpktID).HasDefaultValueSql("'0'");
                entity.Property(e => e.TeamType).HasDefaultValueSql("'0'");
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
