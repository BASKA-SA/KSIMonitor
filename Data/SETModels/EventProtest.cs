using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("veranstaltung_protest"), Keyless]
    public partial class EventProtest {
        [Column("vernr")]
        public int EventID { get; set; }
        [Column("catid")]
        public int? CategoryID { get; set; }
        [Column("matchid"), StringLength(50)]
        public string MatchID { get; set; }
        [Column("id")]
        public int ID { get; set; }
        [Column("creation", TypeName = "timestamp")]
        public DateTime Created { get; set; }
        [Column("ringname"), StringLength(100)]
        public string RingName { get; set; }
        [Column("seconds")]
        public int Seconds { get; set; }
        [Column("athnnr")]
        public int? AthnID { get; set; }
    }
}
