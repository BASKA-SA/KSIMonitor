using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Keyless]
    [Table("veranstaltung_club_entryfee")]
    public partial class VeranstaltungClubEntryfee {
        [Column("vernr")]
        public int Vernr { get; set; }
        [Column("vereinnr")]
        public int Vereinnr { get; set; }
        [Column("paidammount")]
        public float? Paidammount { get; set; }
        [Column("comment")]
        [StringLength(255)]
        public string Comment { get; set; }
        [Column("changes")]
        public int Changes { get; set; }
        [Column("discount")]
        public float? Discount { get; set; }
        [Column("notificationsent", TypeName = "date")]
        public DateTime? Notificationsent { get; set; }
        [Column("comment2", TypeName = "text")]
        public string Comment2 { get; set; }
    }
}