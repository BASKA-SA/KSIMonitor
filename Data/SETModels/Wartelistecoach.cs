using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Keyless]
    [Table("wartelistecoach")]
    public partial class Wartelistecoach {
        [Column("vernr")]
        public int Vernr { get; set; }
        [Column("katnr")]
        public int Katnr { get; set; }
        [Column("id")]
        public int Id { get; set; }
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
