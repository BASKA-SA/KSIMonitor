using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("clientmonitor"), Keyless]
    public partial class Clientmonitor {
        [Column("ip"), Required, StringLength(30)]
        public string IP { get; set; }
        [Column("hostname"), Required, StringLength(100)]
        public string Hostname { get; set; }
        [Column("name"), StringLength(100)]
        public string Name { get; set; }
        [Column("creation", TypeName = "timestamp")]
        public DateTime Creation { get; set; }
        [Column("expire", TypeName = "timestamp")]
        public DateTime Expire { get; set; }
        [Column("message", TypeName = "text")]
        public string Message { get; set; }
        [Column("verid")]
        public int VerID { get; set; }
        [Column("type")]
        public int Type { get; set; }
        [Column("ms")]
        public int? MS { get; set; }
        [Column("matchid"), StringLength(50)]
        public string MatchID { get; set; }
        [Column("nameid1")]
        public int? NameID1 { get; set; }
        [Column("nameid2")]
        public int? NameID2 { get; set; }
        [Column("sync")]
        public int? Sync { get; set; }
        [Column("clientmode")]
        public int? ClientMode { get; set; }
    }
}
