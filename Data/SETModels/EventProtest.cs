using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("veranstaltung_protest"), Keyless]
    public partial class EventProtest {
        [Column("vernr")]
        public int EventID { get; set; }
        [Column("id")]
        public int Id { get; set; }
        [Column("creation", TypeName = "timestamp")]
        public DateTime Creation { get; set; }
        [Column("ringname"), StringLength(100)]
        public string Ringname { get; set; }
        [Column("matchid"), StringLength(50)]
        public string MatchID { get; set; }
        [Column("seconds")]
        public int Seconds { get; set; }
        [Column("athnnr")]
        public int? Athnnr { get; set; }
        [Column("catid")]
        public int? CatID { get; set; }
    }
}
