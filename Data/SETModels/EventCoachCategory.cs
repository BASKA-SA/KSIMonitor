using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("veranstaltung_coach_category"), Keyless]
    public partial class EventCoachCategory {
        [Column("vernr")]
        public int EventID { get; set; }
        [Column("id")]
        public int ID { get; set; }
        [Column("maxentries")]
        public int? Maxentries { get; set; }
        [Column("fee")]
        public float? Fee { get; set; }
    }
}
