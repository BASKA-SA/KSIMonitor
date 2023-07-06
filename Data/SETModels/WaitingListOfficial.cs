using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("wartelisteofficial"), Keyless]
    public partial class WaitingListOfficial {
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
        [Column("daysinfo"), StringLength(50)]
        public string DaysInfo { get; set; }
        [Column("approved")]
        public int Approved { get; set; }
        [Column("comment", TypeName = "text")]
        public string Comment { get; set; }
    }
}
