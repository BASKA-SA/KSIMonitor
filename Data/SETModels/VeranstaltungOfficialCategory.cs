using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("veranstaltung_official_category"), Keyless]
    public partial class VeranstaltungOfficialCategory {
        [Column("vernr")]
        public int Vernr { get; set; }
        [Column("id")]
        public int ID { get; set; }
        [Column("maxentries")]
        public int? Maxentries { get; set; }
        [Column("fee")]
        public float? Fee { get; set; }
    }
}
