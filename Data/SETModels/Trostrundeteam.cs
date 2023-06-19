using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Keyless]
    [Table("trostrundeteam")]
    public partial class Trostrundeteam {
        [Column("id")]
        public long Id { get; set; }
        [Column("vereinnr")]
        public int Vereinnr { get; set; }
        [Required]
        [Column("mannschaft", TypeName = "text")]
        public string Mannschaft { get; set; }
        [Column("fieldpos")]
        public int Fieldpos { get; set; }
        [Column("trostrunde")]
        public int Trostrunde { get; set; }
        [Column("points")]
        public int? Points { get; set; }
        [Column("kata")]
        public int? Kata { get; set; }
        [Column("matchid")]
        [StringLength(50)]
        public string Matchid { get; set; }
        [Column("matchtime", TypeName = "timestamp")]
        public DateTime Matchtime { get; set; }
        [Column("wintype")]
        public int? Wintype { get; set; }
    }
}
