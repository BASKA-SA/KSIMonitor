using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Keyless]
    [Table("wartelisteteam")]
    [Index("Teamid", Name = "teamid", IsUnique = true)]
    public partial class Wartelisteteam {
        [Column("vernr")]
        public int Vernr { get; set; }
        [Column("knr")]
        public int Knr { get; set; }
        [Column("vereinnr")]
        public int Vereinnr { get; set; }
        [Required]
        [Column("mannschaft", TypeName = "text")]
        public string Mannschaft { get; set; }
        [Column("time", TypeName = "timestamp")]
        public DateTime Time { get; set; }
        [Column("registrator")]
        public int? Registrator { get; set; }
        [Column("teamid")]
        public int Teamid { get; set; }
        [Column("approved")]
        public int Approved { get; set; }
        [Column("comment", TypeName = "text")]
        public string Comment { get; set; }
        [Column("replacement")]
        public int? Replacement { get; set; }
    }
}
