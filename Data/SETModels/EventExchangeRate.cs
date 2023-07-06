using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("veranstaltung_exchangerate"), Keyless]
    public partial class EventExchangeRate {
        [Column("vernr")]
        public int EventID { get; set; }
        [Column("wid")]
        public int WID { get; set; }
        [Column("rate")]
        public float Rate { get; set; }
    }
}
