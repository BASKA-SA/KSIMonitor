using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("wartelisteteam"), Keyless, Index(nameof(TeamID), Name = "teamid", IsUnique = true)]
    public partial class Wartelisteteam {
        [Column("vernr")]
        public int Vernr { get; set; }
        [Column("knr")]
        public int Knr { get; set; }
        [Column("vereinnr")]
        public int Vereinnr { get; set; }
        [Column("mannschaft", TypeName = "text"), Required]
        public string Mannschaft { get; set; }
        [Column("time", TypeName = "timestamp")]
        public DateTime Time { get; set; }
        [Column("registrator")]
        public int? Registrator { get; set; }
        [Column("teamid")]
        public int TeamID { get; set; }
        [Column("approved")]
        public int Approved { get; set; }
        [Column("comment", TypeName = "text")]
        public string Comment { get; set; }
        [Column("replacement")]
        public int? Replacement { get; set; }
    }
}
