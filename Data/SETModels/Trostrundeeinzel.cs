using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("trostrundeeinzel"), Keyless]
    public partial class Trostrundeeinzel {
        [Column("id")]
        public long ID { get; set; }
        [Column("nnr")]
        public int Nnr { get; set; }
        [Column("fieldpos")]
        public int Fieldpos { get; set; }
        [Column("trostrunde")]
        public int Trostrunde { get; set; }
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
