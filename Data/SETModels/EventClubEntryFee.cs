using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("veranstaltung_club_entryfee"), Keyless]
    public partial class EventClubEntryFee {
        [Column("vernr")]
        public int EventID { get; set; }
        [Column("vereinnr")]
        public int AssociationID { get; set; }
        [Column("paidammount")]
        public float? PaidAmount { get; set; }
        [Column("changes")]
        public int Changes { get; set; }
        [Column("discount")]
        public float? Discount { get; set; }
        [Column("notificationsent", TypeName = "date")]
        public DateTime? Notificationsent { get; set; }
        [Column("comment"), StringLength(255)]
        public string Comment { get; set; }
        [Column("comment2", TypeName = "text")]
        public string Comment2 { get; set; }
    }
}
