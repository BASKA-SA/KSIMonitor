using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("veranstaltung")]
    public partial class Event {
        [Column("vernr"), Key]
        public int EventID { get; set; }
        [Column("bezeichnung"), Required, StringLength(255)]
        public string Name { get; set; }
        [Column("verdatum"), Required, StringLength(20)]
        public string Date { get; set; }
        [Column("nennstart"), Required, StringLength(20)]
        public string EntryStart { get; set; }
        [Column("nennende"), Required, StringLength(20)]
        public string EntryEnd { get; set; }
        [Column("user")]
        public int? User { get; set; }
        [Column("gesperrt")]
        public uint Blocked { get; set; }
        [Column("info", TypeName = "text")]
        public string Info { get; set; }
        [Column("passwd"), StringLength(50)]
        public string Password { get; set; }
        [Column("offen")]
        public int? Open { get; set; }
        [Column("showstarter")]
        public int? ShowStarter { get; set; }
        [Column("regmode")]
        public int? RegMode { get; set; }
        [Column("adresse"), StringLength(255)]
        public string Address { get; set; }
        [Column("auslosungen")]
        public int? Draws { get; set; }
        [Column("land")]
        public uint Country { get; set; }
        [Column("lastchange", TypeName = "timestamp")]
        public DateTime LastChange { get; set; }
        [Column("limitedto")]
        public int? LimitedTo { get; set; }
        [Column("deletetodraw")]
        public int? DeleteToDraw { get; set; }
        [Column("waehrung")]
        public int Currency { get; set; }
        [Column("typ")]
        public int? Type { get; set; }
        [Column("lat"), StringLength(50)]
        public string Lat { get; set; }
        [Column("lon"), StringLength(50)]
        public string Lon { get; set; }
        [Column("liveblog")]
        public int LiveBlog { get; set; }
        [Column("indlimitclub")]
        public int IndividualLimitClub { get; set; }
        [Column("teamlimitclub")]
        public int TeamLimitClub { get; set; }
        [Column("usepaypal")]
        public int? UsePayPal { get; set; }
        [Column("paypalaccount"), StringLength(255)]
        public string PayPalAccount { get; set; }
        [Column("paypalnoamount")]
        public int? PayPalNoAmount { get; set; }
        [Column("systemtype"), StringLength(150)]
        public string SystemType { get; set; }
        [Column("bisdatum"), StringLength(20)]
        public string BillDate { get; set; }
        [Column("hidefromcalendar")]
        public int? HideFromCalendar { get; set; }
        [Column("googlecalid"), StringLength(250)]
        public string GoogleCalendarID { get; set; }
        [Column("invoiced")]
        public int? Invoiced { get; set; }
        [Column("paid")]
        public int? Paid { get; set; }
        [Column("international")]
        public int? International { get; set; }
        [Column("infoevent")]
        public int InfoEvent { get; set; }
        [Column("useothercutoffday")]
        public int? UseOtherCutoffDay { get; set; }
        [Column("othercutoffday"), StringLength(20)]
        public string OtherCutoffDay { get; set; }
        [Column("entrylimit")]
        public int EntryLimit { get; set; }
        [Column("premiumevent")]
        public int? PremiumEvent { get; set; }
        [Column("ticketshopurl"), StringLength(255)]
        public string TicketShopURL { get; set; }
        [Column("hiderefereeentries")]
        public int? HideRefereeEntries { get; set; }
        [Column("allentriesonwaitinglist")]
        public int? AllEntriesOnWaitingList { get; set; }
        [Column("usebothcutoffdates")]
        public int? UseBothCutoffDates { get; set; }
        [Column("livedtm")]
        public int? LiveDTM { get; set; }
        [Column("coachlimitclub")]
        public int CoachLimitClub { get; set; }
        [Column("refereelimitclub")]
        public int RefereeLimitClub { get; set; }
        [Column("officiallimitclub")]
        public int OfficialLimitClub { get; set; }
        [Column("usedisclaimer")]
        public int? UseDisclaimer { get; set; }
        [Column("eventcontactemail"), StringLength(255)]
        public string EventContactEmail { get; set; }
        [Column("timezone"), StringLength(50)]
        public string Timezone { get; set; }
        [Column("livestream")]
        public int? Livestream { get; set; }
        [Column("hotel")]
        public int? Hotel { get; set; }
        [Column("appsyncevent")]
        public int? AppSyncEvent { get; set; }
        [Column("appsynccat")]
        public int? AppSyncCategory { get; set; }
        [Column("appsyncclub")]
        public int? AppSyncClub { get; set; }
        [Column("puuid"), StringLength(50)]
        public string Puuid { get; set; }
        [Column("headofdelegation")]
        public int? HeadOfDelegation { get; set; }
        [Column("hideindreg")]
        public int? HideIndividualRegistrations { get; set; }
        [Column("hideteamreg")]
        public int? HideTeamRegistrations { get; set; }
        [Column("hidecoachreg")]
        public int? HideCoachRegistrations { get; set; }
        [Column("hiderefereereg")]
        public int? HideRefereeRegistrations { get; set; }
        [Column("hideofficialreg")]
        public int? HideOfficialRegistrations { get; set; }
        [Column("bankaccount", TypeName = "text")]
        public string BankAccount { get; set; }
        [Column("usebankaccount")]
        public int UseBankAccount { get; set; }
        [Column("hidecoachentries")]
        public int? HideCoachEntries { get; set; }
        [Column("hideofficialentries")]
        public int? HideOfficialEntries { get; set; }
        [Column("hideathleteentries")]
        public int? HideAthleteEntries { get; set; }
        [Column("linkevent")]
        public int LinkEvent { get; set; }
        [Column("linkeventurl"), StringLength(255)]
        public string LinkEventURL { get; set; }
        [Column("extregistrationmode")]
        public int? ExternalRegistrationMode { get; set; }
        [Column("extregistrationmoderoles"), StringLength(100)]
        public string ExternalRegistrationModeRoles { get; set; }
        [Column("billingaddress", TypeName = "text")]
        public string BillingAddress { get; set; }
        [Column("usebillingaddress")]
        public int? UseBillingAddress { get; set; }
        [Column("useranking")]
        public int UseRanking { get; set; }
        [Column("paypalextrafee")]
        public float? PaypalExtraFee { get; set; }
        [Column("allentriesonwaitinglistcoach")]
        public int AllEntriesOnWaitingListCoach { get; set; }
        [Column("allentriesonwaitinglistreferee")]
        public int AllEntriesOnWaitingListReferee { get; set; }
        [Column("allentriesonwaitinglistofficial")]
        public int AllEntriesOnWaitingListOfficial { get; set; }
        [Column("entrylimitreferee")]
        public int EntryLimitReferee { get; set; }
        [Column("entrylimitofficial")]
        public int EntryLimitOfficial { get; set; }
        [Column("waitinglistpublic")]
        public int WaitingListPublic { get; set; }
        [Column("entrylimitcoach")]
        public int EntryLimitCoach { get; set; }
        [Column("enablepressregistration")]
        public int EnablePressRegistration { get; set; }
        [Column("extregistrationnopermission")]
        public int? ExternalRegistrationNoPermission { get; set; }
        [Column("paypalextrafeepercentage")]
        public float? PaypalExtraFeePercentage { get; set; }
        [Column("smfacebook"), StringLength(255)]
        public string SMFacebook { get; set; }
        [Column("smwebsite"), StringLength(255)]
        public string SMWebsite { get; set; }
        [Column("smtwitter"), StringLength(255)]
        public string SMTwitter { get; set; }
        [Column("smyoutube"), StringLength(255)]
        public string SMYoutube { get; set; }
        [Column("smflickr"), StringLength(255)]
        public string SMFlickr { get; set; }
        [Column("smgoogle"), StringLength(255)]
        public string SMGoogle { get; set; }
        [Column("sminstagram"), StringLength(255)]
        public string SMInstagram { get; set; }
        [Column("extregistrationintrefereeonly")]
        public int ExternalRegistrationIntRefereeOnly { get; set; }
        [Column("extregistrationintcoachonly")]
        public int ExternalRegistrationIntCoachOnly { get; set; }
        [Column("starttime"), StringLength(20)]
        public string StartTime { get; set; }
        [Column("endtime"), StringLength(20)]
        public string EndTime { get; set; }
        [Column("regstarttime"), StringLength(20)]
        public string RegStartTime { get; set; }
        [Column("regendtime"), StringLength(20)]
        public string RegEndTime { get; set; }
        [Column("extid")]
        public int ExtID { get; set; }
        [Column("cartkeepopenafterdeadline")]
        public int? CartKeepOpenAfterDeadline { get; set; }
        [Column("hidemedalstatistic")]
        public int? HideMedalStatistic { get; set; }
        [Column("noteinfo", TypeName = "text")]
        public string NoteInfo { get; set; }
        [Column("noteshow")]
        public int? NoteShow { get; set; }
        [Column("showstarteronlybypermission")]
        public int ShowStarterOnlyByPermission { get; set; }
        [Column("showdrawsonlybypermission")]
        public int ShowDrawsOnlyByPermission { get; set; }
        [Column("usegestpay")]
        public int UseGestPay { get; set; }
        [Column("gestpayshoplogin"), StringLength(30)]
        public string GestPayShopLogin { get; set; }
        [Column("gestpaynoamount")]
        public int GestPayNoAmount { get; set; }
        [Column("gestpayextrafee")]
        public float GestPayExtraFee { get; set; }
        [Column("gestpayextrafeepercentage")]
        public float GestPayExtraFeePercentage { get; set; }
        [Column("limitindathlete")]
        public int LimitIndividualathlete { get; set; }
        [Column("limitindathlete_waitinglist")]
        public int LimitIndividualAthleteWaitingList { get; set; }
        [Column("indlimitcountry")]
        public int IndividualLimitCountry { get; set; }
        [Column("indentryusesportsid")]
        public int IndividualEntryUseSportsID { get; set; }
        [Column("indentryuserankingtoprank")]
        public int IndividualEntryUseRankingTopRank { get; set; }
        [Column("indentryuserankingtoprankendate"), StringLength(20)]
        public string IndividualEntryUserankingTopRankEndate { get; set; }
        [Column("paypalwlautoapproveonpayment")]
        public int PayPalWLAutoApproveOnPayment { get; set; }
        [Column("gestpaywlautoapproveonpayment")]
        public int GestPayWLAutoApproveOnPayment { get; set; }
        [Column("enablewlpaymententryremover")]
        public int EnableWLPaymentEntryRemover { get; set; }
        [Column("wlpaymententryremovermaxminutes")]
        public int WLPaymentEntryRemoverMaxMinutes { get; set; }
        [Column("exttypefilter"), StringLength(150)]
        public string ExtTypeFilter { get; set; }
        [Column("eventagegeneralfrom", TypeName = "date")]
        public DateTime? EventAgeGeneralFrom { get; set; }
        [Column("eventagegeneralto", TypeName = "date")]
        public DateTime? EventAgeGeneralTo { get; set; }
        [Column("custompaymenturl"), StringLength(255)]
        public string CustomPaymentUrl { get; set; }
        [Column("showstartercountonly")]
        public int? ShowStarterCountOnly { get; set; }
        [Column("usepaypaldonationbutton")]
        public int? UsePayPalDonationButton { get; set; }
        [Column("scoremode")]
        public int ScoreMode { get; set; }
        [Column("hideresultlist")]
        public int? HideResultList { get; set; }
        [Column("photouploadkey"), StringLength(50)]
        public string PhotoUploadKey { get; set; }
        [Column("indentryshowrankingpos")]
        public int? IndividualEntryShowRankingPos { get; set; }
        [Column("extsystems"), StringLength(255)]
        public string ExtSystems { get; set; }
        [Column("showathleteprofilespublic")]
        public int? ShowAthleteProfilesPublic { get; set; }
        [Column("usestripe")]
        public int UseStripe { get; set; }
        [Column("stripepubkey"), StringLength(255)]
        public string StripePubKey { get; set; }
        [Column("stripeseckey"), StringLength(255)]
        public string StripeSecKey { get; set; }
        [Column("stripewlautoapproveonpayment")]
        public int StripeWLAutoApproveOnPayment { get; set; }
        [Column("etrefereeselfassignment")]
        public int EtRefereeSelfAssignment { get; set; }
        [Column("etrefereeselfassignment_onepercountry")]
        public int? EtRefereeSelfAssignmentOnePerCountry { get; set; }
        [Column("enablevolunteerregistration")]
        public int? EnableVolunteerRegistration { get; set; }
        [Column("usematchnumbercodes")]
        public int? UseMatchNumberCodes { get; set; }
        [Column("usematchnumbercodestime")]
        public int? UseMatchNumberCodesTime { get; set; }
        [Column("extregsysteminfotext", TypeName = "text")]
        public string ExtRegSystemInfoText { get; set; }
        [Column("useallmatchcodes")]
        public int? UseAllMatchCodes { get; set; }
        [Column("superlicenseevent")]
        public int? SuperLicenseEvent { get; set; }
        [Column("adminallowrefereescores")]
        public int? AdminAllowRefereeScores { get; set; }
        [Column("extsystemswhitelist"), StringLength(255)]
        public string ExtSystemsWhiteList { get; set; }
        [Column("resultscustomurl"), StringLength(255)]
        public string ResultsCustomURL { get; set; }
        [Column("medalscustomurl"), StringLength(255)]
        public string MedalsCustomURL { get; set; }
        [Column("enablewlpaymententryremover_coach")]
        public int EnableWLPaymentEntryRemoverCoach { get; set; }
        [Column("wlpaymententryremovermaxminutes_coach")]
        public int WLPaymentEntryRemoverMaxMinutesCoach { get; set; }
        [Column("enablewlpaymententryremover_referee")]
        public int EnableWLPaymentEntryRemoverReferee { get; set; }
        [Column("wlpaymententryremovermaxminutes_referee")]
        public int WLPaymentEntryRemoverMaxMinutesReferee { get; set; }
        [Column("enablewlpaymententryremover_official")]
        public int EnableWLPaymentEntryRemoverOfficial { get; set; }
        [Column("wlpaymententryremovermaxminutes_official")]
        public int WLPaymentEntryRemoverMaxMinutesOfficial { get; set; }
        [Column("indentryuserankingtoprankfrom")]
        public int IndividualEntryUseRankingTopRankFrom { get; set; }
        [Column("eventcode"), StringLength(20)]
        public string EventCode { get; set; }
        [Column("athletelimitfilter", TypeName = "text")]
        public string AthleteLimitFilter { get; set; }
        [Column("indentryuserankingtoprankfrom_checkothercategories")]
        public int? IndividualEntryUseRankingTopRankFrom_CheckOtherCategories { get; set; }
        [Column("custommap", TypeName = "text")]
        public string CustomMap { get; set; }
        [Column("region")]
        public int? Region { get; set; }
        [Column("cattotallimitputwlcat")]
        public int? CategoryTotalLimitPutWLCat { get; set; }
        [Column("disableentrydelete")]
        public int? DisableEntryDelete { get; set; }
        [Column("disableentrydeletewl")]
        public int? DisableEntryDeleteWL { get; set; }
        [Column("categoryfilter", TypeName = "text")]
        public string CategoryFilter { get; set; }
    }
}
