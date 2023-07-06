using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("veranstaltungkat"), Keyless]
    public partial class EventCategory {
        [Column("vernr")]
        public int EventID { get; set; }
        [Column("knr")]
        public int CategoryID { get; set; }
        [Column("alterVon")]
        public int AgeFrom { get; set; }
        [Column("alternichtmehr")]
        public int AgeNotMoreThan { get; set; }
        [Column("startgeld")]
        public float? StartMoney { get; set; }
        [Column("teammin")]
        public int? TeamMin { get; set; }
        [Column("teammax")]
        public int? TeamMax { get; set; }
        [Column("resulttype")]
        public int? ResultType { get; set; }
        [Column("othercutoffday"), StringLength(20)]
        public string OtherCutOffDay { get; set; }
        [Column("roundrobin")]
        public int? RoundRobin { get; set; }
        [Column("pools")]
        public int? Pools { get; set; }
        [Column("drawmodesubmode")]
        public int? DrawModeSubMode { get; set; }
        [Column("needsize")]
        public int NeedSize { get; set; }
        [Column("needweight")]
        public int NeedWeight { get; set; }
        [Column("maxentries")]
        public int MaxEntries { get; set; }
        [Column("kyufilter"), StringLength(50)]
        public string KyuFilter { get; set; }
        [Column("danfilter"), StringLength(50)]
        public string DanFilter { get; set; }
        [Column("maxentriestotal")]
        public int MaxEntriesTotal { get; set; }
        [Column("isrankingcat")]
        public int? IsRankingCategory { get; set; }
        [Column("body_level")]
        public int? BodyLevel { get; set; }
        [Column("head_level")]
        public int? HeadLevel { get; set; }
        [Column("rounds")]
        public int? Rounds { get; set; }
        [Column("round_time"), StringLength(5)]
        public string RoundTime { get; set; }
        [Column("kyeshi_time"), StringLength(5)]
        public string KyeshiTime { get; set; }
        [Column("rest_time"), StringLength(5)]
        public string RestTime { get; set; }
        [Column("goldenpoint_enable")]
        public int? GoldenPointEnable { get; set; }
        [Column("goldenpoint_time"), StringLength(5)]
        public string GoldenPointTime { get; set; }
        [Column("west_size"), StringLength(255)]
        public string WestSize { get; set; }
        [Column("weightmin")]
        public float? WeightMin { get; set; }
        [Column("weightmax")]
        public float? WeightMax { get; set; }
        [Column("shortname"), StringLength(50)]
        public string ShortName { get; set; }
        [Column("matchtype"), StringLength(20)]
        public string MatchType { get; set; }
        [Column("seedmode")]
        public int? SeedMode { get; set; }
        [Column("matchform"), StringLength(255)]
        public string MatchForm { get; set; }
        [Column("scoremode")]
        public int? ScoreMode { get; set; }
        [Column("exrefselfass")]
        public int? Exrefselfass { get; set; }
        [Column("classedecane"), StringLength(100)]
        public string Classedecane { get; set; }
        [Column("gradoagility"), StringLength(255)]
        public string Gradoagility { get; set; }
        [Column("gradorallyobedience"), StringLength(255)]
        public string Gradorallyobedience { get; set; }
        [Column("refdeployment")]
        public int? RefDeployment { get; set; }
        [Column("othercutoffdaystart"), StringLength(20)]
        public string OtherCutOffDayStart { get; set; }
        [Column("gradosdsfreestyle"), StringLength(255)]
        public string Gradosdsfreestyle { get; set; }
        [Column("gradosdsspeedwater"), StringLength(255)]
        public string Gradosdsspeedwater { get; set; }
        [Column("gradosdssplashdog"), StringLength(255)]
        public string Gradosdssplashdog { get; set; }
        [Column("gradosdsobedience"), StringLength(255)]
        public string Gradosdsobedience { get; set; }
        [Column("gradosdshoopers"), StringLength(255)]
        public string Gradosdshoopers { get; set; }
        [Column("classedecanesah"), StringLength(255)]
        public string Classedecanesah { get; set; }
        [Column("iwuf_difficulty")]
        public int? IWUFDifficulty { get; set; }
        [Column("iwuf_compmovement")]
        public int? IWUFCompmovement { get; set; }
        [Column("iwuf_adedtf")]
        public int? IWUFAdedtf { get; set; }
        [Column("iwuf_style"), StringLength(255)]
        public string IWUFStyle { get; set; }
        [Column("iwuf_data"), StringLength(255)]
        public string IWUFData { get; set; }
        [Column("categoryfilter", TypeName = "text")]
        public string CategoryFilter { get; set; }
    }
}
