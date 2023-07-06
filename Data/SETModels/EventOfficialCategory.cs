using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("veranstaltung_official_category"), Keyless]
    public partial class EventOfficialCategory {
        [Column("vernr")]
        public int EventID { get; set; }
        [Column("id")]
        public int ID { get; set; }
        [Column("maxentries")]
        public int? MaxEntries { get; set; }
        [Column("fee")]
        public float? Fee { get; set; }
    }
}
