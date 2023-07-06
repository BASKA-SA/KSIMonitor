using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("referee_match")]
    public partial class RefereeMatch {
        [Column("id"), Key]
        public int ID { get; set; }
        [Column("vernr")]
        public int? EventID { get; set; }
        [Column("refid")]
        public int? RefereeID { get; set; }
        [Column("matchid"), StringLength(50)]
        public string MatchID { get; set; }
        [Column("matcharea")]
        public int? MatchArea { get; set; }
        [Column("katnr")]
        public int? CategoryID { get; set; }
        [Column("type")]
        public int? Type { get; set; }
        [Column("pool")]
        public int? Pool { get; set; }
        [Column("position")]
        public int? Position { get; set; }
        [Column("pointscore")]
        public float? PointScore { get; set; }
        [Column("flagscore")]
        public int? FlagScore { get; set; }
        [Column("puuid"), StringLength(50)]
        public string PuuID { get; set; }
        [Column("refposition")]
        public int? RefereePosition { get; set; }
        [Column("lastchange", TypeName = "timestamp")]
        public DateTime LastChange { get; set; }
    }
}
