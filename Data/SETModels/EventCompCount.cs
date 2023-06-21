using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("veranstaltung_compcount"), Keyless]
    public partial class EventCompCount {
        [Column("vernr")]
        public int EventID { get; set; }
        [Column("nnr")]
        public int NameID { get; set; }
        [Column("eventcount")]
        public int EventCount { get; set; }
    }
}
