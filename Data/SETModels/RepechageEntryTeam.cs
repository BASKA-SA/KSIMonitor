using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("trostrundeteam"), Keyless]
    public partial class RepechageEntryTeam {
        [Column("id")]
        public long ID { get; set; }
        [Column("vereinnr")]
        public int AssociationID { get; set; }
        [Column("mannschaft", TypeName = "text"), Required]
        public string Team { get; set; }
        [Column("fieldpos")]
        public int FieldPos { get; set; }
        [Column("trostrunde")]
        public int Repechage { get; set; }
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
