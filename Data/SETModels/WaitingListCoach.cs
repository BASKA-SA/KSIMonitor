using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("wartelistecoach"), Keyless]
    public partial class WaitingListCoach {
        [Column("vernr")]
        public int EventID { get; set; }
        [Column("katnr")]
        public int CategoryID { get; set; }
        [Column("id")]
        public int ID { get; set; }
        [Column("time", TypeName = "timestamp")]
        public DateTime Time { get; set; }
        [Column("registrator")]
        public int? Registrator { get; set; }
        [Column("approved")]
        public int Approved { get; set; }
        [Column("comment", TypeName = "text")]
        public string Comment { get; set; }
    }
}
