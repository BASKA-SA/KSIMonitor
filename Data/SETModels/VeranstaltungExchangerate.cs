using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("veranstaltung_exchangerate"), Keyless]
    public partial class VeranstaltungExchangerate {
        [Column("vernr")]
        public int Vernr { get; set; }
        [Column("wid")]
        public int Wid { get; set; }
        [Column("rate")]
        public float Rate { get; set; }
    }
}
