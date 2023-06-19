using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Keyless]
    [Table("doubleeliminationeinzel")]
    public partial class Doubleeliminationeinzel {
        [Column("vernr")]
        public int Vernr { get; set; }
        [Column("knr")]
        public int Knr { get; set; }
        [Column("nnr")]
        public int Nnr { get; set; }
        [Column("xpos")]
        public int Xpos { get; set; }
        [Column("ypos")]
        public int Ypos { get; set; }
        [Column("fieldpos")]
        public int Fieldpos { get; set; }
        [Column("pool")]
        public int Pool { get; set; }
        [Column("tabletype")]
        public int Tabletype { get; set; }
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
