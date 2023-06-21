using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("doubleeliminationeinzel"), Keyless]
    public partial class DoubleEliminationSingle {
        [Column("vernr")]
        public int EventID { get; set; }
        [Column("knr")]
        public int CategoryID { get; set; }
        [Column("nnr")]
        public int NameID { get; set; }
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
        [Column("matchid"), StringLength(50)]
        public string Matchid { get; set; }
        [Column("matchtime", TypeName = "timestamp")]
        public DateTime Matchtime { get; set; }
        [Column("wintype")]
        public int? Wintype { get; set; }
    }
}
