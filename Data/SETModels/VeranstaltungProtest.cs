using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Keyless]
    [Table("veranstaltung_protest")]
    public partial class VeranstaltungProtest {
        [Column("vernr")]
        public int Vernr { get; set; }
        [Column("id")]
        public int Id { get; set; }
        [Column("creation", TypeName = "timestamp")]
        public DateTime Creation { get; set; }
        [Column("ringname")]
        [StringLength(100)]
        public string Ringname { get; set; }
        [Column("matchid")]
        [StringLength(50)]
        public string Matchid { get; set; }
        [Column("seconds")]
        public int Seconds { get; set; }
        [Column("athnnr")]
        public int? Athnnr { get; set; }
        [Column("catid")]
        public int? Catid { get; set; }
    }
}
