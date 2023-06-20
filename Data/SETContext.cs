using KSIMonitor.Data.SETModels;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data {
    public partial class SETContext : DbContext, IDBContext {
        public SETContext(DbContextOptions<SETContext> options) : base(options) { }

        public virtual DbSet<Accessarea> AccessAreas { get; set; }
        public virtual DbSet<Auslosungeinzel> Auslosungeinzels { get; set; }
        public virtual DbSet<Auslosungteam> Auslosungteams { get; set; }
        public virtual DbSet<Barcode> Barcodes { get; set; }
        public virtual DbSet<Binomio> Binomios { get; set; }
        public virtual DbSet<CategoryMatch> CategoryMatches { get; set; }
        public virtual DbSet<Clientmonitor> Clientmonitors { get; set; }
        public virtual DbSet<Coach> Coaches { get; set; }
        public virtual DbSet<CoachCategory> CoachCategories { get; set; }
        public virtual DbSet<CoachcatAccess> CoachcatAccesses { get; set; }
        public virtual DbSet<Doubleeliminationeinzel> Doubleeliminationeinzels { get; set; }
        public virtual DbSet<Doubleeliminationteam> Doubleeliminationteams { get; set; }
        public virtual DbSet<Dtmdefault> Dtmdefaults { get; set; }
        public virtual DbSet<Entryfeemodel> Entryfeemodels { get; set; }
        public virtual DbSet<Ergebniseinzel> Ergebniseinzels { get; set; }
        public virtual DbSet<Ergebnisteam> Ergebnisteams { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<Kategorie> Kategories { get; set; }
        public virtual DbSet<Kata> Kata { get; set; }
        public virtual DbSet<Landesverband> Landesverbands { get; set; }
        public virtual DbSet<MatchCalling> MatchCallings { get; set; }
        public virtual DbSet<Matchinfo> Matchinfos { get; set; }
        public virtual DbSet<Mitschrifteinzel> Mitschrifteinzels { get; set; }
        public virtual DbSet<Mitschriftteam> Mitschriftteams { get; set; }
        public virtual DbSet<Name> Names { get; set; }
        public virtual DbSet<Nation> Nations { get; set; }
        public virtual DbSet<Nennungencoach> Nennungencoaches { get; set; }
        public virtual DbSet<Nennungeneinzel> Nennungeneinzels { get; set; }
        public virtual DbSet<Nennungenofficial> Nennungenofficials { get; set; }
        public virtual DbSet<Nennungenreferee> Nennungenreferees { get; set; }
        public virtual DbSet<Nennungenteam> Nennungenteams { get; set; }
        public virtual DbSet<Official> Officials { get; set; }
        public virtual DbSet<OfficialCategory> OfficialCategories { get; set; }
        public virtual DbSet<OfficialcatAccess> OfficialcatAccesses { get; set; }
        public virtual DbSet<PatterMatch> PatterMatches { get; set; }
        public virtual DbSet<Personemail> Personemails { get; set; }
        public virtual DbSet<Poolsiegereinzel> Poolsiegereinzels { get; set; }
        public virtual DbSet<Poolsiegerteam> Poolsiegerteams { get; set; }
        public virtual DbSet<PressFunction> PressFunctions { get; set; }
        public virtual DbSet<PressRegistration> PressRegistrations { get; set; }
        public virtual DbSet<PressType> PressTypes { get; set; }
        public virtual DbSet<PresstypeAccess> PresstypeAccesses { get; set; }
        public virtual DbSet<Punktelisteeinzel> Punktelisteeinzels { get; set; }
        public virtual DbSet<Punktelisteteam> Punktelisteteams { get; set; }
        public virtual DbSet<Referee> Referees { get; set; }
        public virtual DbSet<RefereeCategory> RefereeCategories { get; set; }
        public virtual DbSet<RefereeExam> RefereeExams { get; set; }
        public virtual DbSet<RefereeExamDecision> RefereeExamDecisions { get; set; }
        public virtual DbSet<RefereeExamResult> RefereeExamResults { get; set; }
        public virtual DbSet<RefereeMatch> RefereeMatches { get; set; }
        public virtual DbSet<RefereeMatcharea> RefereeMatchareas { get; set; }
        public virtual DbSet<RefereecatAccess> RefereecatAccesses { get; set; }
        public virtual DbSet<RoleTyp> RoleTyps { get; set; }
        public virtual DbSet<SiegerehrungErledigt> SiegerehrungErledigts { get; set; }
        public virtual DbSet<Sportart> Sportarts { get; set; }
        public virtual DbSet<Stilrichtung> Stilrichtungs { get; set; }
        public virtual DbSet<Sysparam> Sysparams { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<TeamWarteliste> TeamWartelistes { get; set; }
        public virtual DbSet<Timetable> Timetables { get; set; }
        public virtual DbSet<TrostrundePool> TrostrundePools { get; set; }
        public virtual DbSet<Trostrundeeinzel> Trostrundeeinzels { get; set; }
        public virtual DbSet<Trostrundeteam> Trostrundeteams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Veranstaltung> Veranstaltungs { get; set; }
        public virtual DbSet<VeranstaltungArea> VeranstaltungAreas { get; set; }
        public virtual DbSet<VeranstaltungClubEntryfee> VeranstaltungClubEntryfees { get; set; }
        public virtual DbSet<VeranstaltungCoachCategory> VeranstaltungCoachCategories { get; set; }
        public virtual DbSet<VeranstaltungCompcount> VeranstaltungCompcounts { get; set; }
        public virtual DbSet<VeranstaltungExchangerate> VeranstaltungExchangerates { get; set; }
        public virtual DbSet<VeranstaltungHeadofdelegation> VeranstaltungHeadofdelegations { get; set; }
        public virtual DbSet<VeranstaltungHotel> VeranstaltungHotels { get; set; }
        public virtual DbSet<VeranstaltungLimitbasedoncompetitor> VeranstaltungLimitbasedoncompetitors { get; set; }
        public virtual DbSet<VeranstaltungMatchduration> VeranstaltungMatchdurations { get; set; }
        public virtual DbSet<VeranstaltungOfficialCategory> VeranstaltungOfficialCategories { get; set; }
        public virtual DbSet<VeranstaltungProtest> VeranstaltungProtests { get; set; }
        public virtual DbSet<VeranstaltungRefereeCategory> VeranstaltungRefereeCategories { get; set; }
        public virtual DbSet<VeranstaltungSeatArea> VeranstaltungSeatAreas { get; set; }
        public virtual DbSet<VeranstaltungSeatAreaSeat> VeranstaltungSeatAreaSeats { get; set; }
        public virtual DbSet<VeranstaltungTyp> VeranstaltungTyps { get; set; }
        public virtual DbSet<VeranstaltungUser> VeranstaltungUsers { get; set; }
        public virtual DbSet<Veranstaltungkat> Veranstaltungkats { get; set; }
        public virtual DbSet<Verein> Vereins { get; set; }
        public virtual DbSet<Waehrung> Waehrungs { get; set; }
        public virtual DbSet<Wartelistecoach> Wartelistecoaches { get; set; }
        public virtual DbSet<Wartelisteeinzel> Wartelisteeinzels { get; set; }
        public virtual DbSet<Wartelisteofficial> Wartelisteofficials { get; set; }
        public virtual DbSet<Wartelistereferee> Wartelistereferees { get; set; }
        public virtual DbSet<Wartelisteteam> Wartelisteteams { get; set; }
        public virtual DbSet<Wintype> Wintypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Accessarea>(entity => {
                entity.HasKey(e => e.Accnr).HasName("PRIMARY");
                entity.Property(e => e.Bezeichnung).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Auslosungeinzel>(entity => {
                entity.Property(e => e.Del).HasDefaultValueSql("'0'");
                entity.Property(e => e.Pool).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Auslosungteam>(entity => {
                entity.Property(e => e.Del).HasDefaultValueSql("'0'");
                entity.Property(e => e.Pool).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Binomio>(entity => {
                entity.Property(e => e.Created).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.Sichtbar).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Clientmonitor>(entity => {
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

            modelBuilder.Entity<Doubleeliminationeinzel>(entity => {
                entity.Property(e => e.Matchtime).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.Pool).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Doubleeliminationteam>(entity => {
                entity.Property(e => e.Matchtime).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.Pool).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Dtmdefault>(entity => {
                entity.Property(e => e.Catname).HasDefaultValueSql("''");
                entity.Property(e => e.Color).HasDefaultValueSql("''");
                entity.Property(e => e.Sex).HasDefaultValueSql("''").IsFixedLength();
                entity.Property(e => e.Type).HasDefaultValueSql("''").IsFixedLength();
            });

            modelBuilder.Entity<Entryfeemodel>(entity => {
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

            modelBuilder.Entity<Kategorie>(entity => {
                entity.HasKey(e => e.Knr).HasName("PRIMARY");
                entity.Property(e => e.Geschlecht).IsFixedLength();
                entity.Property(e => e.Katbez).HasDefaultValueSql("''");
                entity.Property(e => e.Team).IsFixedLength();
                entity.Property(e => e.Typ).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Kata>(entity => {
                entity.Property(e => e.Stilnr).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Landesverband>(entity => {
                entity.Property(e => e.Bezeichnung).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<MatchCalling>(entity => {
                entity.Property(e => e.Callmatch2).HasDefaultValueSql("'0'");
                entity.Property(e => e.Ring).HasDefaultValueSql("'0'");
                entity.Property(e => e.Winner).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Mitschrifteinzel>(entity => {
                entity.Property(e => e.Matchtime).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.Pool).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Mitschriftteam>(entity => {
                entity.Property(e => e.Matchtime).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.Pool).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Name>(entity => {
                entity.HasKey(e => e.Nnr).HasName("PRIMARY");
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
                entity.Property(e => e.Vereinnr).HasDefaultValueSql("'3'");
            });

            modelBuilder.Entity<Nation>(entity => {
                entity.Property(e => e.Bezeichnung).HasDefaultValueSql("''");
                entity.Property(e => e.Hide).HasDefaultValueSql("'0'");
                entity.Property(e => e.ISO).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Nennungencoach>(entity => {
                entity.Property(e => e.Time).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Nennungeneinzel>(entity => {
                entity.Property(e => e.Measurement).HasDefaultValueSql("'0'");
                entity.Property(e => e.Time).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Nennungenofficial>(entity => {
                entity.Property(e => e.Daysinfo).HasDefaultValueSql("''");
                entity.Property(e => e.Time).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Nennungenreferee>(entity => {
                entity.Property(e => e.Time).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Nennungenteam>(entity => {
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

            modelBuilder.Entity<Personemail>(entity => {
                entity.Property(e => e.Email).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Poolsiegereinzel>(entity => {
                entity.Property(e => e.Matchtime).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.Pool).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Poolsiegerteam>(entity => {
                entity.Property(e => e.Matchtime).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.Pool).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<PressRegistration>(entity => {
                entity.Property(e => e.Regtime).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Punktelisteeinzel>(entity => {
                entity.Property(e => e.Pool).HasDefaultValueSql("'1'");
                entity.Property(e => e.S1).HasDefaultValueSql("'0'");
                entity.Property(e => e.S2).HasDefaultValueSql("'0'");
                entity.Property(e => e.S3).HasDefaultValueSql("'0'");
                entity.Property(e => e.S4).HasDefaultValueSql("'0'");
                entity.Property(e => e.S5).HasDefaultValueSql("'0'");
                entity.Property(e => e.S6).HasDefaultValueSql("'0'");
                entity.Property(e => e.S7).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Punktelisteteam>(entity => {
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

            modelBuilder.Entity<Sportart>(entity => {
                entity.HasKey(e => e.Sportartnr).HasName("PRIMARY");
                entity.Property(e => e.Bezeichnung).HasDefaultValueSql("''");
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

            modelBuilder.Entity<Trostrundeeinzel>(entity => {
                entity.Property(e => e.Matchtime).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Trostrundeteam>(entity => {
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

            modelBuilder.Entity<Veranstaltung>(entity => {
                entity.HasKey(e => e.Vernr).HasName("PRIMARY");
                entity.Property(e => e.Adminallowrefereescores).HasDefaultValueSql("'0'");
                entity.Property(e => e.Allentriesonwaitinglist).HasDefaultValueSql("'0'");
                entity.Property(e => e.Appsynccat).HasDefaultValueSql("'0'");
                entity.Property(e => e.Appsyncclub).HasDefaultValueSql("'0'");
                entity.Property(e => e.Appsyncevent).HasDefaultValueSql("'0'");
                entity.Property(e => e.Bezeichnung).HasDefaultValueSql("''");
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

            modelBuilder.Entity<VeranstaltungArea>(entity => {
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

            modelBuilder.Entity<VeranstaltungClubEntryfee>(entity => {
                entity.Property(e => e.Comment).HasDefaultValueSql("''");
                entity.Property(e => e.Discount).HasDefaultValueSql("'0'");
                entity.Property(e => e.Paidammount).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<VeranstaltungProtest>(entity => {
                entity.Property(e => e.Athnnr).HasDefaultValueSql("'0'");
                entity.Property(e => e.CatID).HasDefaultValueSql("'0'");
                entity.Property(e => e.Creation).ValueGeneratedOnAddOrUpdate().HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<VeranstaltungSeatAreaSeat>(entity => {
                entity.Property(e => e.Reserved).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<VeranstaltungUser>(entity => {
                entity.Property(e => e.Emailnotification).HasDefaultValueSql("'1'");
                entity.Property(e => e.Time).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Veranstaltungkat>(entity => {
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

            modelBuilder.Entity<Verein>(entity => {
                entity.HasKey(e => e.Vereinnr).HasName("PRIMARY");
                entity.Property(e => e.Bezeichnung).HasDefaultValueSql("''");
                entity.Property(e => e.Lvnr).HasDefaultValueSql("'0'");
                entity.Property(e => e.Nation).HasDefaultValueSql("'15'");
                entity.Property(e => e.Sektionnr).HasDefaultValueSql("'0'");
                entity.Property(e => e.Stpktnr).HasDefaultValueSql("'0'");
                entity.Property(e => e.Teamtype).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Wartelistecoach>(entity => {
                entity.Property(e => e.Time).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Wartelisteeinzel>(entity => {
                entity.Property(e => e.Replacement).HasDefaultValueSql("'0'");
                entity.Property(e => e.Time).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Wartelisteofficial>(entity => {
                entity.Property(e => e.Time).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Wartelistereferee>(entity => {
                entity.Property(e => e.Time).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Wartelisteteam>(entity => {
                entity.Property(e => e.Replacement).HasDefaultValueSql("'0'");
                entity.Property(e => e.TeamID).ValueGeneratedOnAdd();
                entity.Property(e => e.Time).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
