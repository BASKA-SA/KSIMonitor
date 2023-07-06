using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("veranstaltung_user"), Keyless]
    public partial class EventUser {
        [Column("verid")]
        public int EventID { get; set; }
        [Column("userid")]
        public int UserID { get; set; }
        [Column("time", TypeName = "timestamp")]
        public DateTime Time { get; set; }
        [Column("emailnotification")]
        public int EmailNotification { get; set; }
        [Column("rolelevel")]
        public int RoleLevel { get; set; }
    }
}
