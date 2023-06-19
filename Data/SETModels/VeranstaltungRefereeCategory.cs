using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Keyless]
    [Table("veranstaltung_referee_category")]
    public partial class VeranstaltungRefereeCategory {
        [Column("vernr")]
        public int Vernr { get; set; }
        [Column("id")]
        public int Id { get; set; }
        [Column("maxentries")]
        public int? Maxentries { get; set; }
        [Column("fee")]
        public float? Fee { get; set; }
    }
}
