using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Keyless]
    [Table("veranstaltung_user")]
    public partial class VeranstaltungUser {
        [Column("verid")]
        public int Verid { get; set; }
        [Column("userid")]
        public int Userid { get; set; }
        [Column("time", TypeName = "timestamp")]
        public DateTime Time { get; set; }
        [Column("emailnotification")]
        public int Emailnotification { get; set; }
        [Column("rolelevel")]
        public int Rolelevel { get; set; }
    }
}
