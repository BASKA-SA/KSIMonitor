using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("veranstaltung")]
    public partial class Veranstaltung {
        [Column("vernr"), Key]
        public int Vernr { get; set; }
        [Column("bezeichnung"), Required, StringLength(255)]
        public string Bezeichnung { get; set; }
        [Column("verdatum"), Required, StringLength(20)]
        public string Verdatum { get; set; }
        [Column("nennstart"), Required, StringLength(20)]
        public string Nennstart { get; set; }
        [Column("nennende"), Required, StringLength(20)]
        public string Nennende { get; set; }
        [Column("user")]
        public int? User { get; set; }
        [Column("gesperrt")]
        public uint Gesperrt { get; set; }
        [Column("info", TypeName = "text")]
        public string Info { get; set; }
        [Column("passwd"), StringLength(50)]
        public string Passwd { get; set; }
        [Column("offen")]
        public int? Offen { get; set; }
        [Column("showstarter")]
        public int? Showstarter { get; set; }
        [Column("regmode")]
        public int? Regmode { get; set; }
        [Column("adresse"), StringLength(255)]
        public string Adresse { get; set; }
        [Column("auslosungen")]
        public int? Auslosungen { get; set; }
        [Column("land")]
        public uint Land { get; set; }
        [Column("lastchange", TypeName = "timestamp")]
        public DateTime Lastchange { get; set; }
        [Column("limitedto")]
        public int? Limitedto { get; set; }
        [Column("deletetodraw")]
        public int? Deletetodraw { get; set; }
        [Column("waehrung")]
        public int Waehrung { get; set; }
        [Column("typ")]
        public int? Typ { get; set; }
        [Column("lat"), StringLength(50)]
        public string Lat { get; set; }
        [Column("lon"), StringLength(50)]
        public string Lon { get; set; }
        [Column("liveblog")]
        public int Liveblog { get; set; }
        [Column("indlimitclub")]
        public int Indlimitclub { get; set; }
        [Column("teamlimitclub")]
        public int Teamlimitclub { get; set; }
        [Column("usepaypal")]
        public int? Usepaypal { get; set; }
        [Column("paypalaccount"), StringLength(255)]
        public string Paypalaccount { get; set; }
        [Column("paypalnoamount")]
        public int? Paypalnoamount { get; set; }
        [Column("systemtype"), StringLength(150)]
        public string Systemtype { get; set; }
        [Column("bisdatum"), StringLength(20)]
        public string Bisdatum { get; set; }
        [Column("hidefromcalendar")]
        public int? Hidefromcalendar { get; set; }
        [Column("googlecalid"), StringLength(250)]
        public string Googlecalid { get; set; }
        [Column("invoiced")]
        public int? Invoiced { get; set; }
        [Column("paid")]
        public int? Paid { get; set; }
        [Column("international")]
        public int? International { get; set; }
        [Column("infoevent")]
        public int Infoevent { get; set; }
        [Column("useothercutoffday")]
        public int? Useothercutoffday { get; set; }
        [Column("othercutoffday"), StringLength(20)]
        public string Othercutoffday { get; set; }
        [Column("entrylimit")]
        public int Entrylimit { get; set; }
        [Column("premiumevent")]
        public int? Premiumevent { get; set; }
        [Column("ticketshopurl"), StringLength(255)]
        public string Ticketshopurl { get; set; }
        [Column("hiderefereeentries")]
        public int? Hiderefereeentries { get; set; }
        [Column("allentriesonwaitinglist")]
        public int? Allentriesonwaitinglist { get; set; }
        [Column("usebothcutoffdates")]
        public int? Usebothcutoffdates { get; set; }
        [Column("livedtm")]
        public int? Livedtm { get; set; }
        [Column("coachlimitclub")]
        public int Coachlimitclub { get; set; }
        [Column("refereelimitclub")]
        public int Refereelimitclub { get; set; }
        [Column("officiallimitclub")]
        public int Officiallimitclub { get; set; }
        [Column("usedisclaimer")]
        public int? Usedisclaimer { get; set; }
        [Column("eventcontactemail"), StringLength(255)]
        public string Eventcontactemail { get; set; }
        [Column("timezone"), StringLength(50)]
        public string Timezone { get; set; }
        [Column("livestream")]
        public int? Livestream { get; set; }
        [Column("hotel")]
        public int? Hotel { get; set; }
        [Column("appsyncevent")]
        public int? Appsyncevent { get; set; }
        [Column("appsynccat")]
        public int? Appsynccat { get; set; }
        [Column("appsyncclub")]
        public int? Appsyncclub { get; set; }
        [Column("puuid"), StringLength(50)]
        public string Puuid { get; set; }
        [Column("headofdelegation")]
        public int? Headofdelegation { get; set; }
        [Column("hideindreg")]
        public int? Hideindreg { get; set; }
        [Column("hideteamreg")]
        public int? Hideteamreg { get; set; }
        [Column("hidecoachreg")]
        public int? Hidecoachreg { get; set; }
        [Column("hiderefereereg")]
        public int? Hiderefereereg { get; set; }
        [Column("hideofficialreg")]
        public int? Hideofficialreg { get; set; }
        [Column("bankaccount", TypeName = "text")]
        public string Bankaccount { get; set; }
        [Column("usebankaccount")]
        public int Usebankaccount { get; set; }
        [Column("hidecoachentries")]
        public int? Hidecoachentries { get; set; }
        [Column("hideofficialentries")]
        public int? Hideofficialentries { get; set; }
        [Column("hideathleteentries")]
        public int? Hideathleteentries { get; set; }
        [Column("linkevent")]
        public int Linkevent { get; set; }
        [Column("linkeventurl"), StringLength(255)]
        public string Linkeventurl { get; set; }
        [Column("extregistrationmode")]
        public int? Extregistrationmode { get; set; }
        [Column("extregistrationmoderoles"), StringLength(100)]
        public string Extregistrationmoderoles { get; set; }
        [Column("billingaddress", TypeName = "text")]
        public string Billingaddress { get; set; }
        [Column("usebillingaddress")]
        public int? Usebillingaddress { get; set; }
        [Column("useranking")]
        public int Useranking { get; set; }
        [Column("paypalextrafee")]
        public float? Paypalextrafee { get; set; }
        [Column("allentriesonwaitinglistcoach")]
        public int Allentriesonwaitinglistcoach { get; set; }
        [Column("allentriesonwaitinglistreferee")]
        public int Allentriesonwaitinglistreferee { get; set; }
        [Column("allentriesonwaitinglistofficial")]
        public int Allentriesonwaitinglistofficial { get; set; }
        [Column("entrylimitreferee")]
        public int Entrylimitreferee { get; set; }
        [Column("entrylimitofficial")]
        public int Entrylimitofficial { get; set; }
        [Column("waitinglistpublic")]
        public int Waitinglistpublic { get; set; }
        [Column("entrylimitcoach")]
        public int Entrylimitcoach { get; set; }
        [Column("enablepressregistration")]
        public int Enablepressregistration { get; set; }
        [Column("extregistrationnopermission")]
        public int? Extregistrationnopermission { get; set; }
        [Column("paypalextrafeepercentage")]
        public float? Paypalextrafeepercentage { get; set; }
        [Column("smfacebook"), StringLength(255)]
        public string Smfacebook { get; set; }
        [Column("smwebsite"), StringLength(255)]
        public string Smwebsite { get; set; }
        [Column("smtwitter"), StringLength(255)]
        public string Smtwitter { get; set; }
        [Column("smyoutube"), StringLength(255)]
        public string Smyoutube { get; set; }
        [Column("smflickr"), StringLength(255)]
        public string Smflickr { get; set; }
        [Column("smgoogle"), StringLength(255)]
        public string Smgoogle { get; set; }
        [Column("sminstagram"), StringLength(255)]
        public string Sminstagram { get; set; }
        [Column("extregistrationintrefereeonly")]
        public int Extregistrationintrefereeonly { get; set; }
        [Column("extregistrationintcoachonly")]
        public int Extregistrationintcoachonly { get; set; }
        [Column("starttime"), StringLength(20)]
        public string Starttime { get; set; }
        [Column("endtime"), StringLength(20)]
        public string Endtime { get; set; }
        [Column("regstarttime"), StringLength(20)]
        public string Regstarttime { get; set; }
        [Column("regendtime"), StringLength(20)]
        public string Regendtime { get; set; }
        [Column("extid")]
        public int ExtID { get; set; }
        [Column("cartkeepopenafterdeadline")]
        public int? Cartkeepopenafterdeadline { get; set; }
        [Column("hidemedalstatistic")]
        public int? Hidemedalstatistic { get; set; }
        [Column("noteinfo", TypeName = "text")]
        public string Noteinfo { get; set; }
        [Column("noteshow")]
        public int? Noteshow { get; set; }
        [Column("showstarteronlybypermission")]
        public int Showstarteronlybypermission { get; set; }
        [Column("showdrawsonlybypermission")]
        public int Showdrawsonlybypermission { get; set; }
        [Column("usegestpay")]
        public int Usegestpay { get; set; }
        [Column("gestpayshoplogin"), StringLength(30)]
        public string Gestpayshoplogin { get; set; }
        [Column("gestpaynoamount")]
        public int Gestpaynoamount { get; set; }
        [Column("gestpayextrafee")]
        public float Gestpayextrafee { get; set; }
        [Column("gestpayextrafeepercentage")]
        public float Gestpayextrafeepercentage { get; set; }
        [Column("limitindathlete")]
        public int Limitindathlete { get; set; }
        [Column("limitindathlete_waitinglist")]
        public int LimitindathleteWaitinglist { get; set; }
        [Column("indlimitcountry")]
        public int Indlimitcountry { get; set; }
        [Column("indentryusesportsid")]
        public int Indentryusesportsid { get; set; }
        [Column("indentryuserankingtoprank")]
        public int Indentryuserankingtoprank { get; set; }
        [Column("indentryuserankingtoprankendate"), StringLength(20)]
        public string Indentryuserankingtoprankendate { get; set; }
        [Column("paypalwlautoapproveonpayment")]
        public int Paypalwlautoapproveonpayment { get; set; }
        [Column("gestpaywlautoapproveonpayment")]
        public int Gestpaywlautoapproveonpayment { get; set; }
        [Column("enablewlpaymententryremover")]
        public int Enablewlpaymententryremover { get; set; }
        [Column("wlpaymententryremovermaxminutes")]
        public int Wlpaymententryremovermaxminutes { get; set; }
        [Column("exttypefilter"), StringLength(150)]
        public string Exttypefilter { get; set; }
        [Column("eventagegeneralfrom", TypeName = "date")]
        public DateTime? Eventagegeneralfrom { get; set; }
        [Column("eventagegeneralto", TypeName = "date")]
        public DateTime? Eventagegeneralto { get; set; }
        [Column("custompaymenturl"), StringLength(255)]
        public string Custompaymenturl { get; set; }
        [Column("showstartercountonly")]
        public int? Showstartercountonly { get; set; }
        [Column("usepaypaldonationbutton")]
        public int? Usepaypaldonationbutton { get; set; }
        [Column("scoremode")]
        public int Scoremode { get; set; }
        [Column("hideresultlist")]
        public int? Hideresultlist { get; set; }
        [Column("photouploadkey"), StringLength(50)]
        public string Photouploadkey { get; set; }
        [Column("indentryshowrankingpos")]
        public int? Indentryshowrankingpos { get; set; }
        [Column("extsystems"), StringLength(255)]
        public string Extsystems { get; set; }
        [Column("showathleteprofilespublic")]
        public int? Showathleteprofilespublic { get; set; }
        [Column("usestripe")]
        public int Usestripe { get; set; }
        [Column("stripepubkey"), StringLength(255)]
        public string Stripepubkey { get; set; }
        [Column("stripeseckey"), StringLength(255)]
        public string Stripeseckey { get; set; }
        [Column("stripewlautoapproveonpayment")]
        public int Stripewlautoapproveonpayment { get; set; }
        [Column("etrefereeselfassignment")]
        public int Etrefereeselfassignment { get; set; }
        [Column("etrefereeselfassignment_onepercountry")]
        public int? EtrefereeselfassignmentOnepercountry { get; set; }
        [Column("enablevolunteerregistration")]
        public int? Enablevolunteerregistration { get; set; }
        [Column("usematchnumbercodes")]
        public int? Usematchnumbercodes { get; set; }
        [Column("usematchnumbercodestime")]
        public int? Usematchnumbercodestime { get; set; }
        [Column("extregsysteminfotext", TypeName = "text")]
        public string Extregsysteminfotext { get; set; }
        [Column("useallmatchcodes")]
        public int? Useallmatchcodes { get; set; }
        [Column("superlicenseevent")]
        public int? Superlicenseevent { get; set; }
        [Column("adminallowrefereescores")]
        public int? Adminallowrefereescores { get; set; }
        [Column("extsystemswhitelist"), StringLength(255)]
        public string Extsystemswhitelist { get; set; }
        [Column("resultscustomurl"), StringLength(255)]
        public string Resultscustomurl { get; set; }
        [Column("medalscustomurl"), StringLength(255)]
        public string Medalscustomurl { get; set; }
        [Column("enablewlpaymententryremover_coach")]
        public int EnablewlpaymententryremoverCoach { get; set; }
        [Column("wlpaymententryremovermaxminutes_coach")]
        public int WlpaymententryremovermaxminutesCoach { get; set; }
        [Column("enablewlpaymententryremover_referee")]
        public int EnablewlpaymententryremoverReferee { get; set; }
        [Column("wlpaymententryremovermaxminutes_referee")]
        public int WlpaymententryremovermaxminutesReferee { get; set; }
        [Column("enablewlpaymententryremover_official")]
        public int EnablewlpaymententryremoverOfficial { get; set; }
        [Column("wlpaymententryremovermaxminutes_official")]
        public int WlpaymententryremovermaxminutesOfficial { get; set; }
        [Column("indentryuserankingtoprankfrom")]
        public int Indentryuserankingtoprankfrom { get; set; }
        [Column("eventcode"), StringLength(20)]
        public string Eventcode { get; set; }
        [Column("athletelimitfilter", TypeName = "text")]
        public string Athletelimitfilter { get; set; }
        [Column("indentryuserankingtoprankfrom_checkothercategories")]
        public int? IndentryuserankingtoprankfromCheckothercategories { get; set; }
        [Column("custommap", TypeName = "text")]
        public string Custommap { get; set; }
        [Column("region")]
        public int? Region { get; set; }
        [Column("cattotallimitputwlcat")]
        public int? Cattotallimitputwlcat { get; set; }
        [Column("disableentrydelete")]
        public int? Disableentrydelete { get; set; }
        [Column("disableentrydeletewl")]
        public int? Disableentrydeletewl { get; set; }
        [Column("categoryfilter", TypeName = "text")]
        public string Categoryfilter { get; set; }
    }
}
