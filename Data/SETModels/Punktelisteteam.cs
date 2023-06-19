using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Keyless]
    [Table("punktelisteteam")]
    public partial class Punktelisteteam {
        [Column("vernr")]
        public int Vernr { get; set; }
        [Column("knr")]
        public int Knr { get; set; }
        [Column("vereinnr")]
        public int Vereinnr { get; set; }
        [Required]
        [Column("mannschaft", TypeName = "text")]
        public string Mannschaft { get; set; }
        [Column("fieldpos")]
        public int Fieldpos { get; set; }
        [Column("pool")]
        public int Pool { get; set; }
        [Column("s1")]
        public float? S1 { get; set; }
        [Column("s2")]
        public float? S2 { get; set; }
        [Column("s3")]
        public float? S3 { get; set; }
        [Column("s4")]
        public float? S4 { get; set; }
        [Column("s5")]
        public float? S5 { get; set; }
        [Column("s6")]
        public float? S6 { get; set; }
        [Column("s7")]
        public float? S7 { get; set; }
        [Column("kata")]
        public int? Kata { get; set; }
        [Column("extra")]
        public float? Extra { get; set; }
        [Column("generatedfromcat")]
        public int Generatedfromcat { get; set; }
        [Column("sothers", TypeName = "text")]
        public string Sothers { get; set; }
    }
}
