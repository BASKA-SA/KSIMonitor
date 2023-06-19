using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Keyless]
    [Table("clientmonitor")]
    public partial class Clientmonitor {
        [Required]
        [Column("ip")]
        [StringLength(30)]
        public string Ip { get; set; }
        [Required]
        [Column("hostname")]
        [StringLength(100)]
        public string Hostname { get; set; }
        [Column("name")]
        [StringLength(100)]
        public string Name { get; set; }
        [Column("creation", TypeName = "timestamp")]
        public DateTime Creation { get; set; }
        [Column("expire", TypeName = "timestamp")]
        public DateTime Expire { get; set; }
        [Column("message", TypeName = "text")]
        public string Message { get; set; }
        [Column("verid")]
        public int Verid { get; set; }
        [Column("type")]
        public int Type { get; set; }
        [Column("ms")]
        public int? Ms { get; set; }
        [Column("matchid")]
        [StringLength(50)]
        public string Matchid { get; set; }
        [Column("nameid1")]
        public int? Nameid1 { get; set; }
        [Column("nameid2")]
        public int? Nameid2 { get; set; }
        [Column("sync")]
        public int? Sync { get; set; }
        [Column("clientmode")]
        public int? Clientmode { get; set; }
    }
}
