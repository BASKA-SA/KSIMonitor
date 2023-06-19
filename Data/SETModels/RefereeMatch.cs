using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("referee_match")]
    public partial class RefereeMatch {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("vernr")]
        public int? Vernr { get; set; }
        [Column("refid")]
        public int? Refid { get; set; }
        [Column("matchid")]
        [StringLength(50)]
        public string Matchid { get; set; }
        [Column("matcharea")]
        public int? Matcharea { get; set; }
        [Column("katnr")]
        public int? Katnr { get; set; }
        [Column("type")]
        public int? Type { get; set; }
        [Column("pool")]
        public int? Pool { get; set; }
        [Column("position")]
        public int? Position { get; set; }
        [Column("pointscore")]
        public float? Pointscore { get; set; }
        [Column("flagscore")]
        public int? Flagscore { get; set; }
        [Column("puuid")]
        [StringLength(50)]
        public string Puuid { get; set; }
        [Column("refposition")]
        public int? Refposition { get; set; }
        [Column("lastchange", TypeName = "timestamp")]
        public DateTime Lastchange { get; set; }
    }
}
