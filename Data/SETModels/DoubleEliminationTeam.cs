using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("doubleeliminationteam"), Keyless]
    public partial class DoubleEliminationTeam {
        [Column("vernr")]
        public int EventID { get; set; }
        [Column("knr")]
        public int CategoryID { get; set; }
        [Column("vereinnr")]
        public int AssociationID { get; set; }
        [Column("mannschaft", TypeName = "text"), Required]
        public string Team { get; set; }
        [Column("xpos")]
        public int Xpos { get; set; }
        [Column("ypos")]
        public int Ypos { get; set; }
        [Column("fieldpos")]
        public int Fieldpos { get; set; }
        [Column("pool")]
        public int Pool { get; set; }
        [Column("tabletype")]
        public int TableType { get; set; }
        [Column("points")]
        public int? Points { get; set; }
        [Column("kata")]
        public int? Kata { get; set; }
        [Column("matchid"), StringLength(50)]
        public string MatchID { get; set; }
        [Column("matchtime", TypeName = "timestamp")]
        public DateTime MatchTime { get; set; }
        [Column("wintype")]
        public int? WinType { get; set; }
    }
}
