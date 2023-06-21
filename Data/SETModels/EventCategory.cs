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
        public int AlterVon { get; set; }
        [Column("alternichtmehr")]
        public int Alternichtmehr { get; set; }
        [Column("startgeld")]
        public float? Startgeld { get; set; }
        [Column("teammin")]
        public int? Teammin { get; set; }
        [Column("teammax")]
        public int? Teammax { get; set; }
        [Column("resulttype")]
        public int? Resulttype { get; set; }
        [Column("othercutoffday"), StringLength(20)]
        public string Othercutoffday { get; set; }
        [Column("roundrobin")]
        public int? Roundrobin { get; set; }
        [Column("pools")]
        public int? Pools { get; set; }
        [Column("drawmodesubmode")]
        public int? Drawmodesubmode { get; set; }
        [Column("needsize")]
        public int Needsize { get; set; }
        [Column("needweight")]
        public int Needweight { get; set; }
        [Column("maxentries")]
        public int Maxentries { get; set; }
        [Column("kyufilter"), StringLength(50)]
        public string Kyufilter { get; set; }
        [Column("danfilter"), StringLength(50)]
        public string Danfilter { get; set; }
        [Column("maxentriestotal")]
        public int Maxentriestotal { get; set; }
        [Column("isrankingcat")]
        public int? Isrankingcat { get; set; }
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
        public int? GoldenpointEnable { get; set; }
        [Column("goldenpoint_time"), StringLength(5)]
        public string GoldenpointTime { get; set; }
        [Column("west_size"), StringLength(255)]
        public string WestSize { get; set; }
        [Column("weightmin")]
        public float? Weightmin { get; set; }
        [Column("weightmax")]
        public float? Weightmax { get; set; }
        [Column("shortname"), StringLength(50)]
        public string Shortname { get; set; }
        [Column("matchtype"), StringLength(20)]
        public string Matchtype { get; set; }
        [Column("seedmode")]
        public int? Seedmode { get; set; }
        [Column("matchform"), StringLength(255)]
        public string Matchform { get; set; }
        [Column("scoremode")]
        public int? Scoremode { get; set; }
        [Column("exrefselfass")]
        public int? Exrefselfass { get; set; }
        [Column("classedecane"), StringLength(100)]
        public string Classedecane { get; set; }
        [Column("gradoagility"), StringLength(255)]
        public string Gradoagility { get; set; }
        [Column("gradorallyobedience"), StringLength(255)]
        public string Gradorallyobedience { get; set; }
        [Column("refdeployment")]
        public int? Refdeployment { get; set; }
        [Column("othercutoffdaystart"), StringLength(20)]
        public string Othercutoffdaystart { get; set; }
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
        public int? IwufDifficulty { get; set; }
        [Column("iwuf_compmovement")]
        public int? IwufCompmovement { get; set; }
        [Column("iwuf_adedtf")]
        public int? IwufAdedtf { get; set; }
        [Column("iwuf_style"), StringLength(255)]
        public string IwufStyle { get; set; }
        [Column("iwuf_data"), StringLength(255)]
        public string IwufData { get; set; }
        [Column("categoryfilter", TypeName = "text")]
        public string Categoryfilter { get; set; }
    }
}
